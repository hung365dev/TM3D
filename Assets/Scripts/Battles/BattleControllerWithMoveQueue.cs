using System;
using UnityEngine;
using System.Collections;
using monsters;
using Items;
using PixelCrushers.DialogueSystem;
using utils;


namespace Battles
{
	public class BattleControllerWithMoveQueue : BattleControllerWithTeams
	{
		
		public delegate void OnMoveQueueComplete();
		public event OnMoveQueueComplete onMoveQueueCompleted;
		
		
		public delegate void OnBattleComplete(BattleTeam aWinningTeam,BattleTeam aLosingTeam);
		public event OnBattleComplete onBattleCompleted;
		public static int MOVE_TURN = 0;
		private float _lastUpdateTime = 0.0f;
		public GameObject lookAtObject;
			
		protected void cancelMoveQueue() {
			while(_moveQueue!=null&&_moveQueue.size>0) {
				_moveQueue.Pop();
			}
			if(this._currentItem!=null)
			this._currentItem.onMoveQueueItemChange -= this.onMoveQueueItemChanged;
			_currentItem = null;
			this.onMoveQueueGenerated -= onMoveQueueCreated;
			this.onMonstersIdle -= onMonstersIdled;
			
		}
		
		protected void doEndBattle() {
			if(_teams[0].teamIsDead) {
				if(onBattleCompleted!=null) {
					onBattleCompleted(_teams[1],_teams[0]);
				}
			} else {
				if(onBattleCompleted!=null) {
					onBattleCompleted(_teams[0],_teams[1]);
				}
			}
		}
		protected override void unpackInitData() {
			
			BattleInit initData = BattleInit.REF;
			if(initData==null) {
				Debug.LogError("BattleInit Data was null.");
				return;
			}
			_battlesConversation = initData.forcedConversation;
			if(initData.convoNPCName!=null) {
				this.GetComponent<OverrideActorName>().overrideName = initData.convoNPCName;
			}
			base.unpackInitData();
			this._positionOfMoveQueueEntry = 0;
			this._battleTurn = 0;
		}
		public BattleControllerWithMoveQueue ()
		{
			this.onMoveQueueGenerated += onMoveQueueCreated;
			this.onMonstersIdle += onMonstersIdled;
			
		}

		protected virtual void onMonsterCaughtResult(ItemBait aItem,EMonsterCatchResult aResult) {
			this.playersTeam.setMovesToUseBait(aItem,aResult);
			
		}
		

		protected void onMonstersIdled() {
			if(_currentItem!=null) {
		//		Debug.Log ("onMonstersIdled");
				this._currentItem.advanceMoveQueueFromState(EMoveQueueItemStatus.HPHits);
			}
		}
		protected void onMoveQueueCreated(BetterList<MoveQueueItem> aMoveQueue) {
			if(countdownTimer!=null) {
				countdownTimer.stop();
				
				countdownTimer.text = "";
			}
			this.easyTarget.gameObject.SetActive(false);
			_moveQueue = aMoveQueue;
			this.FadeBlackScreen(0.0f,0.1f);
			topLabel.gameObject.SetActive(false);
			Debug.Log ("Move Queue Size is: "+_moveQueue.size);
			for(int i = 0;i<_moveQueue.size;i++) {
				if((_moveQueue[i].moveData==null)&&(_moveQueue[i].baitItem==null)&&(_moveQueue[i].usedItem==null)) {
					_moveQueue.RemoveAt(i);
					i--;
				}
				else
				_moveQueue[i].setTimesToHit();
			}
			processMoveQueue();
			
		
		}
		private void processMoveQueue() {
			if(_moveQueue==null) {
				Debug.LogWarning("Move Queue was null, that doesn't seem right");
				return;
			}
			if(_moveQueue.size==0) {
				if(this.onMoveQueueCompleted==null) {
					Debug.LogWarning("No event listener for BattleControllerWithMoveQueue.onMoveQueueCompleted");
				} else {
					lookAtObject = null;
					
					this.GetComponent<CameraTrack>().target = null;
					MOVE_TURN++;
					onMoveQueueCompleted();
				}
				return;
			}
			_currentItem = _moveQueue[0];
			_moveQueue.RemoveAt(0);
			Debug.Log("processMoveQueue, new item taken, remaining move queue size: "+_moveQueue.size);
			performMove();
		}
		private BattleMonsterWithMoves actionMonster {
			get {
				return _currentItem.actioningMonster;
			}
		}
		private IEnumerator onDelayedWaitForQueueChange() {
			_lastUpdateTime = Time.time;
			yield return new WaitForSeconds(0.01f);
			if(Time.time-_lastUpdateTime<1.0f) {
			//	Debug.LogError("There was not enough time between changes");
			}
			BattleControllerMain.REF.addDebug("onMoveQueueItemChanged: "+_currentItem.status);
			switch(_currentItem.status) {
			case(EMoveQueueItemStatus.Start):
				// THe only way we can ever get here is in a multi-hit move, so we want to remove the listener for onMoveQueueItemChanged,
				// Because we will add a new listener in the next function.
				if(this.battleComplete) {
					this._currentItem.status = EMoveQueueItemStatus.MoveBackToPosition;
					this._currentItem.timesToHit = 0;
					this._currentItem.advanceMoveQueueFromState(EMoveQueueItemStatus.MoveBackToPosition);
					
					this.GetComponent<CameraTrack>().SetTarget(null);
					
				} else {
					this._currentItem.onMoveQueueItemChange -= onMoveQueueItemChanged;
					
					this.performMove();
				}
				
				break;
			case(EMoveQueueItemStatus.ChangeToOtherMove):
				this.checkIfMoveNeedsToChange(this._currentItem);
				break;
			case(EMoveQueueItemStatus.AttackAnimation):
				
				this.GetComponent<CameraTrack>().SetTarget(this._currentItem.actioningMonster.transform);
				StartCoroutine(this.doAttackAnimation(this._currentItem));
				break;
			case(EMoveQueueItemStatus.HPHits):
				this.applyHPEffectsToTeams(this._currentItem);
				
				// No advance move queue here.
				this.doAttackHitAnimation(this._currentItem);	
				if(allTeamsIdle) {
					this._currentItem.advanceMoveQueueFromState(EMoveQueueItemStatus.HPHits);
				}
				break;
			case(EMoveQueueItemStatus.HPHitsPassiveEffects):
				this.handlePostHitPassiveEffect(this._currentItem);
				break;
			case(EMoveQueueItemStatus.StatusEffects):
				StartCoroutine(this.applyStatusEffectsToTeams(this._currentItem));
				break;
			case(EMoveQueueItemStatus.HPBoosts):
				this.applyHPBoostsToTeams(this._currentItem);
				break;
			case(EMoveQueueItemStatus.StatusBoosts):
				this.applyStatusBoostsToTeams(this._currentItem);
				break;
				
			case(EMoveQueueItemStatus.MoveBackToPosition):
				StartCoroutine(moveMonsterBackToPosition(this._currentItem));
				break;
				
			case(EMoveQueueItemStatus.InflictMyEffects):
				this._currentItem.actioningMonster.postMoveStatusEffects(this._currentItem);
				break;
			case(EMoveQueueItemStatus.StatEffectors):
				StartCoroutine(applyStatEffectorsToTeams(this._currentItem));
				break;
			case(EMoveQueueItemStatus.EndMoveQueuePassiveEffects):
				handleMoveQueueEndPassiveEffects(this._currentItem);
				break;
			case(EMoveQueueItemStatus.Finish):
				this._currentItem.onMoveQueueItemChange -= onMoveQueueItemChanged;
				killExhaustedMonsters();
				deleteDeadMonstersFromQueue();
				
				this.GetComponent<CameraTrack>().SetTarget(null);
				if(battleComplete) {
					hideExtraButtons();
					if(playersTeam.teamIsDead&&BattleBase.COST_TO_CONTINUE>0&&!multiplayerBattle) {
						this.continueBattleScreen.gameObject.SetActive(true);
						cancelMoveQueue();
						
					} else {
						Debug.Log("Battle is complete!");
						if(_teams[0].teamIsDead) {
							if(onBattleCompleted!=null) {
								onBattleCompleted(_teams[1],_teams[0]);
							}
						} else {
							if(onBattleCompleted!=null) {
								onBattleCompleted(_teams[0],_teams[1]);
							}
						}
					}
				} else {
					if(_currentItem.moveData!=null&&_currentItem.moveData.alsoApplyThis!=null&&_currentItem.moveData.percentChanceOfFollowOn>BattleRandomizer.random) {
						if(_currentItem.hitMonsters.size>0) {
							_currentItem.moveData = _currentItem.moveData.alsoApplyThis;
							_currentItem.status = EMoveQueueItemStatus.Start;
							_currentItem.setTimesToHit();
							_currentItem.followOnMove = true;
							if(_currentItem.moveData.isBoost) {
								
								_currentItem.targetTeam = positionFromTeam(teamFromMonster((BattleMonster) _currentItem.actioningMonster));
								switch(_currentItem.moveData.splashRange) {
									case(ESplashRange.BoostMe):
										_currentItem.targetMonster = teamFromPosition(_currentItem.targetTeam).positionForMonster((BattleMonster) _currentItem.actioningMonster);
									break;  
								}
							} else {
								_currentItem.targetTeam = positionFromTeam(otherTeam(teamFromMonster((BattleMonster) _currentItem.actioningMonster)));
							}
							_currentItem.targettedMonster.Clear();
							//performMove();
							onMoveQueueItemChanged();
							break;
						}
					}
					if(_moveQueue.size>0&&!battleComplete) {
						_currentItem = _moveQueue[0];
						_moveQueue.RemoveAt(0);
						performMove();
					} else {
						_currentItem = null;
						prepareTeamsForNextTurn();
						if(!battleComplete) {
							this.showMovesForMonster(this.playersTeam.nextUnsetMonster);
							if(this.playersTeam.nextUnsetMonster!=null)
								this.playersTeam.bringMonsterToFront(playersTeam.nextUnsetMonster);
							this._battleTurn++;
							MOVE_TURN++;
							_positionOfMoveQueueEntry = 0;
							this.startConversation();
							
							
							if(this.countdownTimer!=null) {
								this.countdownTimer.preLabel = "Select Moves: ";
								this.countdownTimer.startStandardTimer();
								this.countdownTimer.onStandardTimerExpired += onAutoSelectMoves;
							}
							
						}
					}
				}
				break;
			}
		}
		private void onMoveQueueItemChanged() {
			StartCoroutine(onDelayedWaitForQueueChange());
		}
		private IEnumerator applyStatEffectorsToTeams(MoveQueueItem aMoveQueueItem) {
			float timeToDelay = _teams[0].applyStatEffectToTeam(aMoveQueueItem,this._commentaryManager);
			timeToDelay += _teams[1].applyStatEffectToTeam(aMoveQueueItem,this._commentaryManager);
			timeToDelay += 0.25f;
			yield return new WaitForSeconds(timeToDelay);
			
			aMoveQueueItem.advanceMoveQueueFromState(EMoveQueueItemStatus.StatEffectors);
		}
		
		private void killExhaustedMonsters() {
			this.playersTeam.killExhaustedMonsters();
			this.opponentTeam.killExhaustedMonsters();
		}
		private void deleteDeadMonstersFromQueue() {
			for(byte c = 0 ; c < this._moveQueue.size ; c++) {
				if(_moveQueue[c].actioningMonster.hp==0||_moveQueue[c].actioningMonster.monster.restingStatus!=ERestingStatus.Awake) {
					_moveQueue.RemoveAt(c);
					c--;
				}
			}
		}
		private void performMove() {
			if(this._currentItem!=null) {
				if(_currentItem.moveData!=null) {
					EStatusEffects reasonForNoMove = actionMonster.lingeringEffectsAllowMove();
					
					
					if(reasonForNoMove==EStatusEffects.None) {
						
						BattleTeam targetTeam = teamFromPosition(_currentItem.targetTeam);
						int originalTarget = (int) _currentItem.targetMonster;
						int targetPositionInt = (int) targetTeam.updatedTargetPosition(_currentItem.targetMonster);
						EMonsterPos pos = targetTeam.updatedTargetPosition(_currentItem.targetMonster);
						Vector3 targetMonsterPosition = BattleConstants.getFaceOffPosition(_currentItem.targetTeam,pos);
						if(this._currentItem.firstHit) {
							Debug.Log ("<color=yellow>This was the first hit, I'm taking: "+_currentItem.moveData.energy+"</color>");
							float energyForMove = _currentItem.moveData.getEnergy(_currentItem.actioningMonster.unlockLevelForMove(_currentItem.moveData));
							
							if(_currentItem.actioningMonster.energy>= energyForMove)
								_currentItem.actioningMonster.energy -= _currentItem.moveData.energy; else {
									_currentItem.moveData = MovesLib.REF.struggleMove;
									BattleTeam ownersTeam = this.teamFromMonster((BattleMonster) _currentItem.actioningMonster);
									BattleTeam otherTeam = this.otherTeam(ownersTeam);
									ETeamPosition otherPosition = this.positionFromTeam(otherTeam);
									_currentItem.targetTeam = otherPosition;
								}
							this._currentItem.firstHit = false;
						} else {
							Debug.Log ("<color=blue>This was not the first hit, I'm not taking: "+_currentItem.moveData.energy+"</color>");
							
						}
						if(_currentItem.moveData.attackAnimation.movementType=="Normal"&&targetTeam!=this.teamFromMonster((BattleMonster) actionMonster)) {
							iTween.MoveTo(actionMonster.gameObject,new Vector3(targetMonsterPosition.x,targetMonsterPosition.y,targetMonsterPosition.z),1.0f);
							StartCoroutine(pauseToAttackAnimation(0.1f,(BattleMonster) actionMonster));
						} else
						if(_currentItem.moveData.attackAnimation.movementType=="OnTargetOnly")
						  {
							StartCoroutine(pauseToAttackAnimation(0.1f,(BattleMonster) actionMonster));
							} else {
							actionMonster.doAttackAnimation();	
							
							this._currentItem.onMoveQueueItemChange += onMoveQueueItemChanged;
							this._currentItem.advanceMoveQueueFromState(EMoveQueueItemStatus.Start);
						}
						if((_currentItem.timesToHit==_currentItem.maxTimesToHit||_currentItem.maxTimesToHit==0)&&(!_currentItem.followOnMove))
							this._commentaryManager.addCommentaryMessage(_currentItem.actioningTeam.name+"'s "+_currentItem.actioningMonster.name+" used "+_currentItem.moveData.Name,ECommentaryMessageType.StandardMessage,ECommentaryMessagePosition.CenterMessage);
						
					} else {
						this._currentItem.onMoveQueueItemChange += onMoveQueueItemChanged;
						_currentItem.actioningMonster.showStatusEffect(reasonForNoMove);
						string reasonForNoMoveString = "";
						switch(reasonForNoMove.ToString().ToLower()) {
							case("sleep"):reasonForNoMoveString = "is Asleep!";break;
							case("flinch"):reasonForNoMoveString = "Flinched!";break;
							case("paralyze"):reasonForNoMoveString = "is Paralyzed!";break;
							case("freeze"):reasonForNoMoveString = "is Frozen!";break;
							case("confusion"):reasonForNoMoveString = "is too Confused!";break;
						}
						MoveLibItem responsible = _currentItem.actioningMonster.reasonForLastNoMove();
						if(responsible!=null)
							this._commentaryManager.addCommentaryMessage(_currentItem.actioningTeam.name+"'s "+_currentItem.actioningMonster.name+" "+reasonForNoMoveString+" Due to: "+responsible.Name,ECommentaryMessageType.StandardMessage,ECommentaryMessagePosition.CenterMessage); else
							this._commentaryManager.addCommentaryMessage(_currentItem.actioningTeam.name+"'s "+_currentItem.actioningMonster.name+" "+reasonForNoMoveString+"",ECommentaryMessageType.StandardMessage,ECommentaryMessagePosition.CenterMessage); 
						_currentItem.actioningMonster.doDefenseAnimation();
						 
						StartCoroutine(pauseToSkipToFinish());
					} 
				} else {
					// Is this bait being used?
					if(this._currentItem.baitItem!=null) {
						
						this._currentItem.onMoveQueueItemChange += onMoveQueueItemChanged;
						this._commentaryManager.addCommentaryMessage(this.playersTeam.name+" used "+_currentItem.baitItem.Name(),ECommentaryMessageType.StandardMessage,ECommentaryMessagePosition.CenterMessage);
						StartCoroutine(doCaptureAttempt());
					} else
					if(this._currentItem.usedItem!=null) {
						if(!this._currentItem.hasMoveQueueListener)
							this._currentItem.onMoveQueueItemChange += onMoveQueueItemChanged; else {
								Debug.LogError("Move Queue item had listener already!");
							}
						this._commentaryManager.addCommentaryMessage(this.playersTeam.name+" used "+_currentItem.usedItem.Name()+" on "+_currentItem.actioningMonster.monster.name,ECommentaryMessageType.StandardMessage,ECommentaryMessagePosition.CenterMessage);
						doItemConsume();
					} else
					// What case causes this?
					StartCoroutine(pauseMiniSkipToFinish());
				}
			}
		}
		private void doItemConsume() {
			StartCoroutine(this._currentItem.actioningMonster.consumeItem(_currentItem.usedItem,_currentItem));
		
		}
		
		private IEnumerator doCaptureAttempt() {
			BattleMonster opp = this.opponentTeam.monstersAsBattleMonster[BattleConstants.FRONT_INDEX];
			
			BetterList<BattleMonster> ms = this.opponentTeam.monstersAsBattleMonster;
			for(int i = 0;i<ms.size;i++) {
				if(ms[i].monster.restingStatus==ERestingStatus.Awake) {
					opp = ms[i];
				}
			}
			
			opp.createCaughtAnimEffect(1);
			
			yield return new WaitForSeconds(1.5f);
			Debug.Log ("Has this missed?");
			if(_currentItem.baitResult==EMonsterCatchResult.Missed) {
				this._commentaryManager.addCommentaryMessage(_currentItem.baitItem.Name()+" Missed!",ECommentaryMessageType.StandardMessage,ECommentaryMessagePosition.CenterMessage);
				yield return new WaitForSeconds(0.5f);
				_currentItem.skipToFinish();
			} else {
				
				opp.createCaughtAnimEffect(2);
				yield return new WaitForSeconds(0.5f);
				if(_currentItem.baitResult==EMonsterCatchResult.NotClose) {
					this._commentaryManager.addCommentaryMessage(opp.name+" does not seem interested in "+_currentItem.baitItem.Name()+"",ECommentaryMessageType.StandardMessage,ECommentaryMessagePosition.CenterMessage);
					
					yield return new WaitForSeconds(0.5f);
					_currentItem.skipToFinish();
					
				} else if(_currentItem.baitResult==EMonsterCatchResult.Close) {
					this._commentaryManager.addCommentaryMessage(opp.name+" seems curious about "+_currentItem.baitItem.Name(),ECommentaryMessageType.StandardMessage,ECommentaryMessagePosition.CenterMessage);
					
					yield return new WaitForSeconds(0.5f);
					_currentItem.skipToFinish();
					
				} else if(_currentItem.baitResult==EMonsterCatchResult.Caught) {
					
					opp.createCaughtAnimEffect(3);
					yield return new WaitForSeconds(1.5f);
					this._commentaryManager.addCommentaryMessage(opp.name+" took the bait!",ECommentaryMessageType.StandardMessage,ECommentaryMessagePosition.CenterMessage);
					opp.hasBeenCaught = true;
					opp.healthBarEnabled = false;
					iTween.MoveTo(opp.gameObject,new Vector3(0.0f,-0.5f,0.0f),1.0f);
					this.playersTeam.fadeOutTeam();
					this._currentItem.skipToFinish();
				}
			}
			
		}
		private IEnumerator pauseMiniSkipToFinish() {
			yield return new WaitForSeconds(0.1f);
			_currentItem.skipToFinish();
		}
		
		private IEnumerator pauseToSkipToFinish() {
			yield return new WaitForSeconds(1.0f);
			_currentItem.skipToFinish();
		}
		private IEnumerator pauseToAttackAnimation(float aDelay,BattleMonster aActionMonster) {
			yield return new WaitForSeconds(aDelay);
			aActionMonster.doAttackAnimation();	
			
			this._currentItem.onMoveQueueItemChange += onMoveQueueItemChanged;
			this._currentItem.advanceMoveQueueFromState(EMoveQueueItemStatus.Start);
		}
	}
} 

