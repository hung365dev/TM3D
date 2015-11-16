using System;
using UnityEngine;
using System.Collections;
using PixelCrushers.DialogueSystem;


namespace Battles
{
	public class BattleControllerWithTeams : BattleControllerWithInterface
	{
		public BattleTeam[] _teams; 
		
		public delegate void OnMoveQueueGenerated(BetterList<MoveQueueItem> aMoveQueue);
		public event OnMoveQueueGenerated onMoveQueueGenerated;
		
		public EasyTarget easyTarget;
		public delegate void OnAllMonstersIdle();
		public event OnAllMonstersIdle onMonstersIdle;
		
		
		
		public BattleControllerWithTeams ()
		{ 
		
		}

		public override void cleanUpBattle() {
			onMoveQueueGenerated = null;
			onMonstersIdle = null;
			base.cleanUpBattle ();

			
			_teams[0].onReadyForNextTurn -= onTeamReady;
			_teams[0].onMoveHasBeenSet -= onMoveHasBeenSet;
			_teams[0].onAllMonstersIdle -= onTeamIdle;
			_teams[0].onMonsterFainted -= onMonsterFainted;
			_teams[0].onCommentaryMessage -= onCommentaryMessage;
			_teams[0].onTargetFound -= onFoundTargetForMove;
			_teams [0].cleanUp ();

			_teams[1].onReadyForNextTurn -= onTeamReady;
			_teams[1].onMoveHasBeenSet -= onMoveHasBeenSet;
			_teams[1].onAllMonstersIdle -= onTeamIdle;
			_teams[1].onMonsterFainted -= onMonsterFainted;
			_teams[1].onCommentaryMessage -= onCommentaryMessage;
			_teams[1].onTargetFound -= onFoundTargetForMove;
			_teams [1].cleanUp ();
			base.cleanUpBattle ();
		}

		public virtual void InitTeams() {
			
			_teams[0].onReadyForNextTurn += onTeamReady;
			_teams[0].onMoveHasBeenSet += onMoveHasBeenSet;
			_teams[0].onAllMonstersIdle += onTeamIdle;
			_teams[0].onMonsterFainted += onMonsterFainted;
			_teams[0].onCommentaryMessage += onCommentaryMessage;
			
			_teams[1].onReadyForNextTurn += onTeamReady;
			_teams[1].onMoveHasBeenSet += onMoveHasBeenSet;
			_teams[1].onAllMonstersIdle += onTeamIdle;
			_teams[1].onMonsterFainted += onMonsterFainted;
			_teams[1].onCommentaryMessage += onCommentaryMessage;
		}
		protected void onAutoSelectMoves() {
			Debug.Log ("onAutoSelectMoves()");
			countdownTimer.stop();
			this.playersTeam.autoSelectMoves();
			barController.show = false;
			this.FadeBlackScreen(0.0f,0.1f);
			
			opponentTeam.onTargetFound -= onFoundTargetForMove;
			
			playersTeam.onTargetFound -= onFoundTargetForMove;
			doResetMonstersDisplay();
			
			topLabel.gameObject.SetActive(false);
		}
		protected void handlePostHitPassiveEffect(MoveQueueItem aItem) {
			aItem.advanceMoveQueueFromState(EMoveQueueItemStatus.HPHitsPassiveEffects);
		}
		
		private void onCommentaryMessage(string aMessage,ECommentaryMessageType aMessageType,EMonsterPos aPosition,ETeamPosition aTeam) {
			switch(aMessageType) {
			case(ECommentaryMessageType.DmgInEffective):
				this._commentaryManager.addCommentaryInEffectiveMessage(aMessage,teamFromPosition(aTeam).monsterFromPosition(aPosition).gameObject);
				break;
			case(ECommentaryMessageType.DmgEffective):
				this._commentaryManager.addCommentaryEffectiveMessage(aMessage,teamFromPosition(aTeam).monsterFromPosition(aPosition).gameObject);
				break;
			case(ECommentaryMessageType.StandardMessage):
				this._commentaryManager.addCommentaryMessage(aMessage,aMessageType,ECommentaryMessagePosition.CenterMessage);
				break;
			case(ECommentaryMessageType.DamageMessage):
				this._commentaryManager.addCommentaryMessage(aMessage,aMessageType,aTeam,aPosition,teamFromPosition(aTeam).monsterFromPosition(aPosition).gameObject);
				break;
			case(ECommentaryMessageType.DmgCritical):
				this._commentaryManager.addCommentaryMessage(aMessage,aMessageType,aTeam,aPosition,teamFromPosition(aTeam).monsterFromPosition(aPosition).gameObject);
				break;
			}
		}
		
		protected bool battleComplete {
			get {
				return _teams[0].teamIsDead||_teams[1].teamIsDead;
			}
		}
		
		private void onTeamIdle() {
			if(allTeamsIdle) {
				if(onMonstersIdle!=null) {
					onMonstersIdle();
				}
			}
		}
		
		protected bool allTeamsIdle {
			get {
				return _teams[0].combinedMoveFlags==EMoveFlag.Idle;
			}
		}
		
		private void onMonsterFainted(BattleTeamBase aTeam,BattleMonster aMonster) {
			//if(aTeam.isLocalTeam) {
				this._commentaryManager.addCommentaryMessage(aMonster.ownersName+"'s "+aMonster.name+" has Fainted!",ECommentaryMessageType.StandardMessage,ECommentaryMessagePosition.CenterMessage);
			//}
			if(aTeam.teamIsDead) {
				handleBattleOver(aTeam as BattleTeam);
			}
		}
		protected BattleTeam otherTeam(BattleTeam aTeam) {
			if(_teams[0]==aTeam) {
				return _teams[1];
			} else {
				return _teams[0];
			}
			}
		private void findTargetInTeam(BattleTeam aAttacking,BattleTeam aDefending,BattleMonster aMonster,MoveQueueItem aMoveQueue,bool aAutomatic) {
			if((aDefending.monsterCount==1)||(aAutomatic)) {
				if(aAttacking.nextUnsetMonster!=null) {
					StartCoroutine(delayToShowNextMonster(aAttacking));
				} else {
					aAttacking.declareReadyForNextTurn();
				}
			} else {
				if(aMoveQueue.moveData.splashRange==ESplashRange.RandomOpponent) {
					// Doesn't matter what target we put here, it will be randomized later
					aMoveQueue.targetMonster = aDefending.positionForMonster(aDefending.monstersAsBattleMonster[0]);
					if(aAttacking.nextUnsetMonster!=null) {
						StartCoroutine(delayToShowNextMonster(aAttacking));
					} else {
						aAttacking.declareReadyForNextTurn();
					}
					return;
				}
				topLabel.text = "Select a Target";
				aAttacking.healthBars = false;
				aDefending.healthBars = false;
				FadeBlackScreen(0.8f,0.1f);
				aAttacking.bringMonsterToFront(aMonster);
				aMonster.healthBarEnabled = true;
				BetterList<BattleMonster> otherMonsters = aDefending.monstersAsBattleMonster;
				easyTarget.gameObject.SetActive(true);
				easyTarget.initTargets(otherMonsters,aDefending);
				for(byte c = 0;c<otherMonsters.size;c++) {
					aDefending.bringMonsterToFront(otherMonsters[c]);
					otherMonsters[c].healthBarEnabled = true;
				}
				aDefending.onTargetFound += onFoundTargetForMove;
				aDefending.findTargetForMove(aMoveQueue);
				
				
			}
		}
		private void onMoveHasBeenSet(BattleTeam aTeam,BattleMonster aMonster,MoveQueueItem aMoveQueue,bool aAutomatic) {
	//		Debug.Log ("onMoveHasbeenSet");
			if(aTeam.isLocalTeam) {
				easyTarget.gameObject.SetActive(false);
				this._positionOfMoveQueueEntry++;
				BattleBase.MultiplayerDebugText("onMoveHasBeenSet (LocalTeam)!!!!!!!!!!!!!!!!!!!!!!!!");
				if(aMoveQueue.moveData!=null) {
					
					BattleBase.MultiplayerDebugText("Move was not null");
					if(aMoveQueue.moveData.isBoost) {
						
						BattleBase.MultiplayerDebugText("Is boost for team, find target in team");
						aMoveQueue.targetTeam = positionFromTeam(aTeam);
						findTargetInTeam(aTeam,aTeam,aMonster,aMoveQueue,aAutomatic);
					} else {
						
						BattleBase.MultiplayerDebugText("Is not boost for team, find target in opponent");
						findTargetInTeam(aTeam,otherTeam(aTeam),aMonster,aMoveQueue,aAutomatic);
						}
				} else {
					if(aMoveQueue.usedItem!=null) {
						aMoveQueue.targetTeam = positionFromTeam(aTeam);
						findTargetInTeam(aTeam,aTeam,aMonster,aMoveQueue,true);
					}
					
					if(aTeam.allMonstersHaveMoves) {
						
						
						aTeam.declareReadyForNextTurn();
					}
				}
			} else {
				if(aTeam.allMonstersHaveMoves) {
					aTeam.declareReadyForNextTurn();
				}
			}
		}
		
		protected void doResetMonstersDisplay() {
			this.opponentTeam.healthBars = true;
			this.playersTeam.healthBars = true;
			this.playersTeam.unfadeAllMonsters();
			this.playersTeam.allMonstersBackInPlace();
			this.opponentTeam.unfadeAllMonsters();
			this.opponentTeam.allMonstersBackInPlace();
		}
		private void onFoundTargetForMove(MoveQueueItem aItem) {
			
			opponentTeam.onTargetFound -= onFoundTargetForMove;
			 
			playersTeam.onTargetFound -= onFoundTargetForMove;
			easyTarget.gameObject.SetActive(false);
			
			doResetMonstersDisplay();
			BattleBase.QueueText("Found Target for Move, my next unset monster is: "+playersTeam.nextUnsetMonster); 
			
			if(playersTeam.nextUnsetMonster!=null) {
				StartCoroutine(delayToShowNextMonster(this.playersTeam));
			} else {
				FadeBlackScreen(0.0f,0.1f);
				playersTeam.declareReadyForNextTurn();
			}
		}
		IEnumerator delayToShowNextMonster(BattleTeamBase aTeam){   
			
			//FadeBlackScreen(0.0f,0.1f);
			yield return new WaitForSeconds(0.1f);
			if(aTeam.nextUnsetMonster!=null) {
				this.opponentTeam.healthBars = true;
				this.playersTeam.healthBars = true;
				this.opponentTeam.unfadeAllMonsters();
				this.playersTeam.allMonstersBackInPlace();
				this.opponentTeam.allMonstersBackInPlace();
				this.showMovesForMonster(aTeam.nextUnsetMonster);
				if(aTeam.nextUnsetMonster!=null)
					this.playersTeam.bringMonsterToFront(aTeam.nextUnsetMonster);
			}
		}
		
		private static int SortBySpeed(MoveQueueItem a1, MoveQueueItem a2) {
			if(a1.moveSpeed>a2.moveSpeed) {
				return -1;
			} else if(a1.moveSpeed==a2.moveSpeed) {
				return 0;
			}
			else
			{
				return 1;
			}
		}
		
		private void generateMoveQueue() {
			BetterList<MoveQueueItem> moveQueue = new BetterList<MoveQueueItem>();
			for(byte i = 0 ; i < this._teams.Length ; i++) {
				BetterList<MoveQueueItem> fmq = _teams[i].futureMoveQueue;
				for(byte c = 0;c<fmq.size;c++) {
					moveQueue.Add(fmq[c]);
				}
			}
			moveQueue.Sort(SortBySpeed);
			Debug.Log("generateMoveQueue()->Move Queue Length is: "+moveQueue.size);
			if(this._moveQueue!=null&&this._moveQueue.size>0) {
				Debug.Log ("I've been told to create a redundant move queue, ignoring");
			} else 
			if(this.onMoveQueueGenerated!=null) {
				this.onMoveQueueGenerated(moveQueue);
			} else {
				Debug.Log ("onMoveQueueGenerated is null!");
			}
		}
		public bool multiplayerBattle {
			get {
				return (this.opponentTeam.teamType==ETeamControllerType.MultiplayerUser);
			}
		}
		
		private IEnumerator DelayToAcceptMoveQueue(BetterList<MoveQueueItem> aMoveQueue) {
			while(moveQueueActive) {
				yield return new WaitForSeconds(0.25f);
			}
			this.opponentTeam.handleMultiplayerMoveQueue(aMoveQueue);
		}
		protected void onMultiplayerMoveQueueReceived(BetterList<MoveQueueItem> aMoveQueue) {
			if(this.moveQueueActive) {
				BattleBase.MultiplayerDebugText("My move queue is active so I'm waiting to receive this move queue");
				StartCoroutine(DelayToAcceptMoveQueue(aMoveQueue));
			} else {
				
				BattleBase.MultiplayerDebugText("My move queue is not active so I'm taking this move queue now.");
				this.opponentTeam.handleMultiplayerMoveQueue(aMoveQueue);
			}

		}
		private void onTeamReady(BetterList<MoveQueueItem> aMoveQueue,BattleTeam aTeam) {
			if(aTeam.name==opponentTeam.name) {
				BattleBase.QueueText("Opponent is ready for next turn"); 
			} else {
				BattleBase.QueueText("I am ready for next turn"); 
			}
			BattleBase.MultiplayerDebugText("Team is ready: "+aTeam.name+" - "+aMoveQueue.size);
			if(aTeam.isLocalTeam&&aTeam==playersTeam) {
				if(multiplayerBattle) {
					BattleBase.DebugText("sendMyMoveQueue");
					BattleBase.QueueText("I am sending my move queue over."); 
					
					//.REF.sendMyMoveQueue(aMoveQueue);
					if(countdownTimer!=null) {
						countdownTimer.startLongTimer();
						countdownTimer.preLabel = "Waiting for Opponent: ";
					}
				}
			}
			if(allTeamsReady) {
				BattleBase.MultiplayerDebugText("All teams are ready is ready: "+aTeam.name+" - "+aMoveQueue.size);
				this.generateMoveQueue();
			} else {
				if(opponentTeam.nextTurnReady==EReadyForNextTurnStatus.MovesUnset) {
					// Opponent hasn't set their moves yet
					if(opponentTeam.teamType==ETeamControllerType.RegularAI||opponentTeam.teamType==ETeamControllerType.WildAI) {
						// If it's an AI team, force set of moves
						opponentTeam.selectAIMoves();
					}
				}
			}
		}
		protected void applyStatusBoostsToTeams(MoveQueueItem aMoveQueueItem) {
			if(_teams[0].applyHPStatusBoostsToTeam(aMoveQueueItem)||_teams[1].applyHPStatusBoostsToTeam(aMoveQueueItem)) {
				
			} else {
				aMoveQueueItem.advanceMoveQueueFromState(EMoveQueueItemStatus.StatusBoosts);
			}
		}
		protected void applyHPBoostsToTeams(MoveQueueItem aMoveQueueItem) {
			if(_teams[0].applyHPBoostsToTeam(aMoveQueueItem,_commentaryManager)||_teams[1].applyHPBoostsToTeam(aMoveQueueItem,_commentaryManager)) {
			
			} else {
				aMoveQueueItem.advanceMoveQueueFromState(EMoveQueueItemStatus.HPBoosts);
			}
		}
		

		protected void prepareTeamsForNextTurn() {

			if (((int)this.orbitCamera & (int)EOrbitCamOptions.OnTurnStart) == (int)EOrbitCamOptions.OnTurnStart) {
				this.teamACameraPath.gameObject.SetActive (true);
			} else {
				this.teamACameraPath.gameObject.SetActive(false);
				this.teamBCameraPath.gameObject.SetActive(false);
			}
			_teams[0].prepareTeamForNextTurn();
			_teams[1].prepareTeamForNextTurn();
		}
		protected void applyHPEffectsToTeams(MoveQueueItem aMoveQueueItem) {
			_teams[0].applyHPEffectToTeam(aMoveQueueItem,_commentaryManager);
			_teams[1].applyHPEffectToTeam(aMoveQueueItem,_commentaryManager);
		}
		
		protected IEnumerator applyStatusEffectsToTeams(MoveQueueItem aMoveQueueItem) {
			float delay = _teams[0].applyStatusEffectToTeam(aMoveQueueItem,this._commentaryManager);
			delay += _teams[1].applyStatusEffectToTeam(aMoveQueueItem,this._commentaryManager);
			yield return new WaitForSeconds(delay);
			aMoveQueueItem.advanceMoveQueueFromState(EMoveQueueItemStatus.StatusEffects);
		}
		
		protected IEnumerator moveMonsterBackToPosition(MoveQueueItem aItem) {
			BattleTeam myTeam = aItem.actioningTeam;
			Vector3 pos = BattleConstants.getMyPosition(this.positionFromTeam(myTeam),myTeam.positionForMonster(aItem.actioningMonster.gameObject),this.transform.parent.gameObject.transform.position);
			Hashtable h = new Hashtable();
			h.Add("position",pos);
			h.Add ("time",0.5f);
		/*	h.Add ("oncompletetarget",this.gameObject);
			h.Add ("oncomplete","onDoAttackAnimation"); 
			h.Add ("oncompleteparams",actionMonster);*/
			h.Add("easetype",iTween.EaseType.easeOutCubic); 
			iTween.MoveTo(aItem.actioningMonster.gameObject,h);

			yield return new WaitForSeconds(0.5f);
			aItem.advanceMoveQueueFromState(EMoveQueueItemStatus.MoveBackToPosition);
		}
		protected ETeamPosition positionFromTeam(BattleTeam aTeam) {
			if(_teams[0]==aTeam) {
				return ETeamPosition.LeftTeam;
			} else {
				return ETeamPosition.RightTeam;
			}
		}
		protected void checkIfMoveNeedsToChange(MoveQueueItem aMoveQueueItem) {
			if(!_teams[0].changeMoveIfNeeded(aMoveQueueItem))
				_teams[1].changeMoveIfNeeded(aMoveQueueItem);
			aMoveQueueItem.advanceMoveQueueFromState(EMoveQueueItemStatus.ChangeToOtherMove);
			
		}
		private bool allTeamsReady {
			get {
				for(byte i = 0;i<_teams.Length;i++) {
					if(_teams[i]==opponentTeam) {
						BattleBase.QueueText("Checking opponent team for readiness"); 
					} else {
						BattleBase.QueueText("Checking my team for readiness"); 
					}

					if(_teams[i].nextTurnReady!=EReadyForNextTurnStatus.Ready) {

						if(_teams[i]==opponentTeam) {
							BattleBase.QueueText("Opponent team not ready"); 
						} else {
							BattleBase.QueueText("My team not ready"); 
						}
						
						return false;
					}
				}
				return true;
			}
		}
		
		protected void handleMoveQueueEndPassiveEffects(MoveQueueItem aMoveQueue) {
			BattleBase.DebugText("BattleControllerWithTeams->handleMoveQueueEndPassiveEffects");
			PassiveEffect effect = aMoveQueue.actioningMonster.monster.hasPassiveEffectForTime(EWhenToApply.AtEndOfMoveQueue,
			                                                                                    0f,
			                                                                                    aMoveQueue.actioningMonster.monster.HpAsPercentage,
			                                                                                    aMoveQueue.actioningMonster.monster.elementType,
			                                                                                    ElementalLibrary.REF.getElement("Normal"),
			                                                                                    aMoveQueue.actioningTeam.monstersApartFrom((BattleMonster) aMoveQueue.actioningMonster),
			                                                                                    otherTeam(aMoveQueue.actioningTeam).monstersAsBattleMonster,
			                                                                                    aMoveQueue.moveData.rangeStatus,
			                                                                                    (BattleMonster) aMoveQueue.actioningMonster,
			                                                                                    aMoveQueue.moveData.elementType);
			
			float delayAmount = 0f;
			if(effect!=null) {
				_commentaryManager.passiveEffect = effect;
				_commentaryManager.battleMonster = (BattleMonster) aMoveQueue.actioningMonster; 
				if(effect.applyToSelf) {
					delayAmount += this.teamFromMonster((BattleMonster) aMoveQueue.actioningMonster).applyPassiveEffectToMonsters(EWhenToApply.AtEndOfMoveQueue,effect,(BattleMonster) aMoveQueue.actioningMonster,aMoveQueue.actioningTeam.positionForMonster((BattleMonster) aMoveQueue.actioningMonster),aMoveQueue);
				} else {
					delayAmount += this.otherTeam(this.teamFromMonster((BattleMonster) aMoveQueue.actioningMonster)).applyPassiveEffectToMonsters(EWhenToApply.AtEndOfMoveQueue,effect,(BattleMonster) aMoveQueue.actioningMonster,aMoveQueue.actioningTeam.positionForMonster((BattleMonster) aMoveQueue.actioningMonster),aMoveQueue);
				}
				
				_commentaryManager.passiveEffect = null;
				_commentaryManager.battleMonster = null; 
			}
			
			for(int i = 0;i<aMoveQueue.hitMonsters.size;i++) {
				effect = aMoveQueue.actioningMonster.monster.hasPassiveEffectForTime(EWhenToApply.WhenHitByMoveTypeAtEndOfMoveQueue,
				                                                                     0f,
				                                                                     aMoveQueue.actioningMonster.monster.HpAsPercentage,
				                                                                     aMoveQueue.actioningMonster.monster.elementType,
				                                                                     aMoveQueue.hitMonsters[i].monster.elementType,
				                                                                     aMoveQueue.actioningTeam.monstersApartFrom((BattleMonster) aMoveQueue.actioningMonster),
				                                                                     otherTeam(aMoveQueue.actioningTeam).monstersAsBattleMonster,
				                                                                     aMoveQueue.moveData.rangeStatus,
				                                                                     (BattleMonster) aMoveQueue.actioningMonster,
				                                                                     aMoveQueue.moveData.elementType);
				if(effect!=null) {
					
					_commentaryManager.passiveEffect = effect;
					_commentaryManager.battleMonster = (BattleMonster) aMoveQueue.actioningMonster; 
					
					BattleMonster m = (BattleMonster) aMoveQueue.hitMonsters[i];
					BattleTeam myTeam = otherTeam(aMoveQueue.actioningTeam);
					if(effect.applyToSelf) {
						delayAmount += myTeam.applyPassiveEffectToMonsters(EWhenToApply.WhenHitByMoveTypeAtEndOfMoveQueue,effect,m,myTeam.positionForMonster(m),aMoveQueue);
					} else {
					
					}
					_commentaryManager.passiveEffect = null;
					_commentaryManager.battleMonster = null; 
					
					
				}
			}

			
			
			StartCoroutine(delayToAdvancedMoveQueue(EMoveQueueItemStatus.EndMoveQueuePassiveEffects,aMoveQueue,delayAmount));
			
		}
		private IEnumerator delayToAdvancedMoveQueue(EMoveQueueItemStatus aExpectedState,MoveQueueItem aMoveQueue,float aDelay) {
			yield return new WaitForSeconds(aDelay);
			aMoveQueue.advanceMoveQueueFromState(aExpectedState);
		}
		protected override void unpackInitData() {
			
			base.unpackInitData();
		/*	easyTarget.onClicked += onEasyTargetClicked;;
			BattleInit initData = BattleInit.REF;
			if(initData==null) {
				Debug.LogError("BattleInit Data was null.");
				return;
			}
	//		
//			
			//StartCoroutine(UnpackTeamsThroughFrames(initData));
			_teams[0].initFromData(initData.teams[0],ETeamPosition.LeftTeam);
			_teams[1].initFromData(initData.teams[1],ETeamPosition.RightTeam);
			
			
			positionMonsters();
			_teams[0].initBattleStartPassiveEffects(_teams[1]);
			_teams[1].initBattleStartPassiveEffects(_teams[0]);
			
			_teams[0].setMonstersLayerOffsets();
			_teams[1].setMonstersLayerOffsets();
			if(_teams[1].teamType==ETeamControllerType.WildAI) {
				this.baitButton.gameObject.SetActive(true);
				this.escapeButton.gameObject.SetActive(true);
				worldStoreBtn.gameObject.SetActive(true);
			} else {
				this.baitButton.gameObject.SetActive(false);
				this.escapeButton.gameObject.SetActive(false);
				this.worldStoreBtn.gameObject.SetActive(false);
			}
			
			if(_teams[1]!=null) {
				OverrideActorName oa = this.GetComponent<OverrideActorName>();
				if(oa!=null) {
					oa.name = _teams[1].displayName;
				}
			}
			StartCoroutine(doBattleStartMessage());*/
		}

		protected void unpackTeam1() {
			easyTarget.onClicked += onEasyTargetClicked;;
			BattleInit initData = BattleInit.REF;
			if(initData==null) {
				Debug.LogError("BattleInit Data was null.");
				return;
			}
			//		
			//			
			//StartCoroutine(UnpackTeamsThroughFrames(initData));
			_teams[0].initFromData(initData.teams[0],ETeamPosition.LeftTeam);

		}
		
		protected void unpackTeam2() {
			BattleInit initData = BattleInit.REF;
			if(initData==null) {
				Debug.LogError("BattleInit Data was null.");
				return;
			}
			//		
			//			
			//StartCoroutine(UnpackTeamsThroughFrames(initData));
			_teams[1].initFromData(initData.teams[1],ETeamPosition.RightTeam);

			_teams[1].initBattleStartPassiveEffects(_teams[0]);

			if(_teams[1].teamType==ETeamControllerType.WildAI) {
				this.baitButton.gameObject.SetActive(true);
				this.escapeButton.gameObject.SetActive(true);
				worldStoreBtn.gameObject.SetActive(true);
			} else {
				if(baitButton!=null) {
					this.baitButton.gameObject.SetActive(false);
					this.escapeButton.gameObject.SetActive(false);
					this.worldStoreBtn.gameObject.SetActive(false);
				}
			}
			
			if(_teams[1]!=null) {
				OverrideActorName oa = this.GetComponent<OverrideActorName>();
				if(oa!=null) {
					oa.name = _teams[1].displayName;
				}
			}
			Vector3 team2MonsterPos = this.opponentTeam.monstersAsBattleMonster [0].transform.position;
			Debug.Log ("unpackTeam2: Monster 2 Position: " + team2MonsterPos);
			StartCoroutine(doBattleStartMessage());
		}
		private void onEasyTargetClicked (BattleMonster aMonster, BattleTeam aTeam) {
			aTeam.onMonsterClicked(aMonster);
			easyTarget.gameObject.SetActive(false);
		}
		private IEnumerator doBattleStartMessage() {
			while(_commentaryManager==null)
				yield return new WaitForEndOfFrame();
			if(opponentTeam.wild) {
				if(opponentTeam.uncaughtMonsters.size>0) {
					if(opponentTeam.uncaughtMonsters.size==1) 
						_commentaryManager.addCommentaryMessage("Uncaught Terra Monster: "+opponentTeam.uncaughtMonsters[BattleConstants.FRONT_INDEX].name,ECommentaryMessageType.StandardMessage,ECommentaryMessagePosition.CenterMessage); else {
						if(opponentTeam.uncaughtMonsters.size==2) {
							_commentaryManager.addCommentaryMessage("Uncaught Terra Monster: "+opponentTeam.uncaughtMonsters[BattleConstants.FRONT_INDEX].name+" and "+opponentTeam.uncaughtMonsters[BattleConstants.BOTTOM_INDEX].name,ECommentaryMessageType.StandardMessage,ECommentaryMessagePosition.CenterMessage);
							
						} else {
							if(opponentTeam.uncaughtMonsters.size==3) {
								_commentaryManager.addCommentaryMessage("Uncaught Terra Monster: "+opponentTeam.uncaughtMonsters[BattleConstants.FRONT_INDEX].name+", "+opponentTeam.uncaughtMonsters[BattleConstants.BOTTOM_INDEX].name+" and "+opponentTeam.uncaughtMonsters[BattleConstants.TOP_INDEX].name,ECommentaryMessageType.StandardMessage,ECommentaryMessagePosition.CenterMessage);
								
							}
						}
					}
					
				}
			} else {
				_commentaryManager.addCommentaryMessage("Battle Begins",ECommentaryMessageType.StandardMessage,ECommentaryMessagePosition.CenterMessage);
			}
		//	this.showMovesForMonster(playersTeam.nextUnsetMonster);
		}
		private IEnumerator UnpackTeamsThroughFrames(BattleInit aInitData) {
			yield return null;
			Debug.Log ("Unpacking team 1");
			_teams[0].initFromData(aInitData.teams[0],ETeamPosition.LeftTeam);
			yield return null;
			Debug.Log ("Unpacking team 2");
			_teams[1].initFromData(aInitData.teams[1],ETeamPosition.RightTeam);
			yield return null;
			
		}
	
	
		protected BattleTeam opponentTeam {
			get {
				if(_teams[0].isLocalTeam) {
					return _teams[1];
				} else
				{
					return _teams[0];
				}
			}
		}
		protected GameObject[] opponentsMonsters {
			get {
				if(_teams[0].isLocalTeam) {
					return _teams[1].monsters;
				} else
				{
					return _teams[0].monsters;
				}
			}
		}
		protected BattleTeam playersTeam {
			get {
				if(_teams[0].isLocalTeam) {
					return _teams[0];
				} else
				{
					return _teams[1];
				}
			}
		}
		
		private void handleBattleOver(BattleTeam aDefeatedTeam) {
			if(aDefeatedTeam.isLocalTeam) {
				// Player Has Lost!
			} else {
				// Player Has Won!
				
			}
		}
		
		protected BattleTeam teamFromMonster(BattleMonster aMonster) {
			if(_teams[0].containsMonster(aMonster)) {
				return _teams[0];
			} else {
				return _teams[1];
			}
		}
		protected BattleTeam teamFromPosition(ETeamPosition aPosition) {
			if(aPosition==ETeamPosition.LeftTeam) {
				return _teams[0];
			} else {
				return _teams[1];
			}
		}
		public void AttackAnimationFinish(UnityEngine.Object aAnimation) {
			Destroy ((GameObject) aAnimation);
		}
		
		protected void doAttackHitAnimation(MoveQueueItem aMoveQueue) {
			
			BattleTeam targetTeam = this.teamFromPosition(aMoveQueue.targetTeam);
			BattleMonster targetMonster = targetTeam.monsterFromPosition(aMoveQueue.targetMonster);
			BetterList<BattleMonster> allTargets;
			if(aMoveQueue.moveData.isBoost) {
				allTargets = targetTeam.getBoostTargetsForMove(aMoveQueue.targetMonster,aMoveQueue.moveData,(BattleMonster) aMoveQueue.actioningMonster);
			} else {
			//	allTargets = targetTeam.getTargetsForMove(aMoveQueue.targetMonster,aMoveQueue.moveData);
				allTargets = aMoveQueue.hitMonsters;

			}
			switch(aMoveQueue.moveData.cameraShake) {
				case("No Shake"):break;
				case("Tiny Shake"):this.GetComponent<CameraShake>().TinyShake();break;
				case("Small Shake"):this.GetComponent<CameraShake>().SmallShake();break;
				case("Large Shake"):this.GetComponent<CameraShake>().LargeShake();break;
				case("Massive Shake"):this.GetComponent<CameraShake>().MassiveShake();break;
			}
			bool isLeftMove = true;
			if(aMoveQueue.actioningTeam.teamPosition==ETeamPosition.RightTeam) {
				isLeftMove = false;
			}
			for(int i = 0;i<allTargets.size;i++) {
				if(i==0) {
					//this.setCamera(allTargets[0].gameObject,EMonsterCamPosition.SideCamera,false,false,false,allTargets[0].transform);
				} 
				GameObject animPrefab = aMoveQueue.moveData.attackAnimationHitPrefab;
				if(animPrefab!=null) {
					animPrefab.tag = "ParticleSystems";
					MoveAnimationLibItem anim = aMoveQueue.moveData.attackHitAnimation;
					if((anim.movementType=="Normal")||(anim.movementType=="OnTargetOnly")) {
						animPrefab.transform.position = allTargets[i].gameObject.transform.position;
						
					} else if(anim.movementType=="OriginToTarget") {
						animPrefab.transform.position = aMoveQueue.actioningMonster.SpawnPosition;
						Hashtable h = new Hashtable();
						h.Add("position",allTargets[i].SpawnPosition);
						h.Add ("time",aMoveQueue.moveData.attackAnimation.seconds);
						h.Add ("oncompletetarget",this.gameObject);
						h.Add ("oncomplete","AttackAnimationFinish");
						h.Add ("oncompleteparams",animPrefab);
						h.Add("easetype",iTween.EaseType.easeInQuad);
						iTween.MoveTo(animPrefab,h);
					} else if(anim.movementType=="OnOriginOnly") {
						animPrefab.transform.position = aMoveQueue.actioningMonster.SpawnPosition;
						Hashtable h = new Hashtable();
						h.Add ("time",aMoveQueue.moveData.attackAnimation.seconds);
						h.Add ("position",animPrefab.transform.position);
						h.Add ("oncompletetarget",this.gameObject);
						h.Add ("oncomplete","AttackAnimationFinish");
						h.Add ("oncompleteparams",animPrefab);
						iTween.MoveTo(animPrefab,h);
					}
					if(!isLeftMove&&aMoveQueue.moveData.attackAnimation.leftSideRotation!=0f) {
						animPrefab.transform.rotation = Quaternion.Euler(0f,anim.rightSideRotation,0f);
					} if(isLeftMove&&aMoveQueue.moveData.attackAnimation.rightSideRotation!=0f) {
						animPrefab.transform.rotation = Quaternion.Euler(0f,anim.leftSideRotation,0f);
					}
					adaptAnimPrefabPositionByOffset(animPrefab,isLeftMove,anim);
				} else {
				
				}
			}

			putParticlesInfront();
			
		}
		protected void adaptAnimPrefabPositionByOffset(GameObject aAnimPrefab,bool aIsLeftMove,MoveAnimationLibItem aLibItem) {
			Vector3 pos = aAnimPrefab.transform.localPosition;
			if(aIsLeftMove) {
				pos.x += aLibItem.xOffset;
			} else {
				pos.x -= aLibItem.xOffset;
			}
			pos.y += aLibItem.yOffset;
			aAnimPrefab.transform.localPosition = pos;
		}
		protected IEnumerator doAttackParticlesAnimation(MoveQueueItem aMoveQueue) {

			BattleTeam targetTeam = this.teamFromPosition(aMoveQueue.targetTeam);
			BattleMonster targetMonster = targetTeam.monsterFromPosition(aMoveQueue.targetMonster);
			BetterList<BattleMonster> allTargets;
			if(aMoveQueue.moveData.isBoost) {
				allTargets = targetTeam.getBoostTargetsForMove(aMoveQueue.targetMonster,aMoveQueue.moveData,(BattleMonster) aMoveQueue.actioningMonster);
			} else {
				allTargets = targetTeam.getTargetsForMove(aMoveQueue.targetMonster,aMoveQueue.moveData);
			}
			yield return new WaitForSeconds(0.01f);
			for(int i = 0;i<allTargets.size;i++) {
				
				GameObject animPrefab = aMoveQueue.moveData.attackAnimationPrefab;
				BattleMonster thisTarget = allTargets[i];
				if(thisTarget!=null) {
					aMoveQueue.addTargettedMonster(thisTarget);
					bool isLeftMove = true;
					if(aMoveQueue.actioningTeam.teamPosition==ETeamPosition.RightTeam) {
						isLeftMove = false;
					}
					if(animPrefab!=null) {
				 		animPrefab.tag = "ParticleSystems";
						MoveAnimationLibItem anim = aMoveQueue.moveData.attackAnimation;
						if((anim.movementType=="Normal")||(anim.movementType=="OnTargetOnly")) {
							if(animPrefab==null||animPrefab.transform==null) {
								Debug.Log ("Error here");
							} else
							if(allTargets[i]==null||allTargets[i].transform==null) {
								Debug.Log("Error here1");
							} else
								animPrefab.transform.position = allTargets[i].transform.position;
						} else if(anim.movementType=="OriginToTarget") {
							animPrefab.transform.position = aMoveQueue.actioningMonster.SpawnPosition;
							Hashtable h = new Hashtable();
							h.Add("position",allTargets[i].SpawnPosition);
							h.Add ("time",aMoveQueue.moveData.attackAnimation.seconds);
							h.Add ("oncompletetarget",this.gameObject);
							h.Add ("oncomplete","AttackAnimationFinish");
							h.Add ("oncompleteparams",animPrefab);
							h.Add("easetype",iTween.EaseType.easeInQuad);
							iTween.MoveTo(animPrefab,h);
							this.setCamera(null,EMonsterCamPosition.TVCamera,true,true,false,animPrefab.transform);
						}
						if(!isLeftMove&&aMoveQueue.moveData.attackAnimation.leftSideRotation!=0f) {
							animPrefab.transform.rotation = Quaternion.Euler(0f,anim.rightSideRotation,0f);
							animPrefab.transform.position = aMoveQueue.actioningMonster.SpawnPosition;
						} if(isLeftMove&&aMoveQueue.moveData.attackAnimation.rightSideRotation!=0f) {
							animPrefab.transform.rotation = Quaternion.Euler(0f,anim.leftSideRotation,0f);
							animPrefab.transform.position = aMoveQueue.actioningMonster.SpawnPosition;
						}
						
						adaptAnimPrefabPositionByOffset(animPrefab,isLeftMove,anim);
						
					}

				}
				 else {
					if(aMoveQueue.moveData.isBoost) {
						allTargets = targetTeam.getBoostTargetsForMove(aMoveQueue.targetMonster,aMoveQueue.moveData,(BattleMonster) aMoveQueue.actioningMonster);
					} else {
						allTargets = targetTeam.getTargetsForMove(aMoveQueue.targetMonster,aMoveQueue.moveData);
					}
					break;
				}

			}
			putParticlesInfront();
	//		StartCoroutine(pauseForDefenseAnim(targetMonster,0.01f/*aMoveQueue.moveData.attackAnimation.seconds*0.5f*/));
			StartCoroutine(pauseForAttack(aMoveQueue,aMoveQueue.moveData.attackAnimation.seconds));
		}
		
		
		protected GameObject[] playersMonsters {
			get {
				if(_teams[0].isLocalTeam) {
					return _teams[0].monsters;
				} else
				{
					return _teams[1].monsters;
				}
			}
		}
	}
}

