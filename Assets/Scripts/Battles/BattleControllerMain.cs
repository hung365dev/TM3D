using UnityEngine;
using System.Collections;
using Battles;
using Items;
using monsters;
using Utils;
using PixelCrushers.DialogueSystem;
using utils;

namespace Battles {
	
	public class BattleControllerMain : BattleControllerWithMoveQueue {
		public bool debug = true;
		public bool multiplayer;
		
		public GameObject smokePuffPrefab;
		public GameObject monstersDataMakeup;
		public static BattleControllerMain REF;
		public bool allowSendingOfMultiplayerTeam = true;
		public AlertQuestionWindow buyMoreTDsBtn;
		public AlertQuestionWindow cancelEvolves;
		// Use this for initialization
		public void OnEnable () {

			
			this.topLabel.gameObject.SetActive(false);
			DialogueLua.SetVariable("AutoSelectMove",-1);
			BattleConstants.controllerRef = this;
			REF = this;
			this.onBattleCompleted += onBattleComplete;


			if(this.battleOverScreen!=null)
				this.battleOverScreen.gameObject.SetActive(false);
			this.commentaryEngine.gameObject.SetActive(false);
			if(BattleInit.REF!=null)
				StartCoroutine(delayToInitBattle()); else {
				
			//	Application.LoadLevel("InitGameScene");
			}
			putParticlesInfront();
			InitMoveQueue ();
			base.InitTeams();
		}

		public void OnDisable() {
			
			this.onBattleCompleted -= onBattleComplete;
		}
		private IEnumerator delayToExit() {
			yield return new WaitForSeconds(1f);
			
			this.onExitBattle();
		}
		
		public void onPaidToRevive() {
			if(PlayerMain.REF.changeHardCurrency(BattleBase.COST_TO_CONTINUE*-1)) {
				this.continueBattleScreen.gameObject.SetActive(false);
				
				this.onMoveQueueGenerated += onMoveQueueCreated;
				this.onMonstersIdle += onMonstersIdled;
				onMoveQueueCreated(this.playersTeam.reviveMoveQueue());
			} else {
		//		AlertQuestionWindow aqw = AlertGUI.REF.DoQuestionAlert("More Terra Dollars Needed","You need at least "+BattleBase.COST_TO_CONTINUE+" Terra Dollars to Revive your monsters","Buy More","Cancel");
		//		aqw.onAnswered += onBuyMore;
		//		aqw.onLeftAnswer += onDidntRevive;
		//		buyMoreTDsBtn = aqw;
				
			}
		}
		public void cleanQuestionWindow() {
			if(buyMoreTDsBtn!=null) {
				buyMoreTDsBtn.onAnswered -= onBuyMore;
				buyMoreTDsBtn.onLeftAnswer -= onDidntRevive;
				buyMoreTDsBtn = null;
			}
			
		}
		public void onBuyMore() {
			cleanQuestionWindow();
	//		AlertGUI.REF.BuyMoreTerraDollars("","");
		}
		public void onDidntRevive() {
			cleanQuestionWindow();
			this.continueBattleScreen.gameObject.SetActive(false);
			doEndBattle();
		}
		public void onTryFleeBattle() {
			if(opponentTeam.wild) {
				bool canFlea = false;
				if(playersTeam.monsterMaxSpeed>opponentTeam.monsterMaxSpeed) {
					canFlea = true;
				}
				if(!canFlea) {
					if(BattleRandomizer.random>0.5) {
						canFlea = true;
					}
				}
				if(canFlea) {
					this._commentaryManager.addCommentaryMessage(playersTeam.name+" Fled from Battle",ECommentaryMessageType.StandardMessage,ECommentaryMessagePosition.CenterMessage);
					StartCoroutine(delayToExit());
				}
			} else {
				AlertGUI.REF.DoGeneralAlert("Cannot Escape","You can only try running from Wild Battles");
			}
		}
		private IEnumerator delayToInitBattle() {
			
			yield return new WaitForSeconds(0.2f);
			this.commentaryEngine.gameObject.SetActive(true);
			this.teamACameraPath.gameObject.SetActive (false);
			this.teamBCameraPath.gameObject.SetActive (false);
			BattleInit initData = BattleInit.REF;
			baseCreate();
			this.unpackTeam1();
			this.barController.show = false;
			yield return new WaitForEndOfFrame();
			this.unpackTeam2();
			
			this.barController.show = false;
			yield return new WaitForEndOfFrame();
			
			this.opponentTeam.healthBars = true;
			this.playersTeam.healthBars = true;
			this.GetComponent<CameraTrack> ().setTarget (this.opponentTeam.monstersAsBattleMonster [0].transform);
			_teams[0].initBattleStartPassiveEffects(_teams[1]);
			_teams[1].initBattleStartPassiveEffects(_teams[0]);
			if(initData!=null) {
				unpackInitData();
			}
			this.barController.show = false;
			yield return new WaitForSeconds(6f);
			this.playersTeam.bringMonsterToFront(playersTeam.nextUnsetMonster);
			this.showMovesForMonster (playersTeam.nextUnsetMonster);
			this.topLabel.gameObject.SetActive(true);
			iTween.FadeFrom(this.topLabel.gameObject,0f,0.25f);
	//		if(multiplayer&&SmartfoxHandler.REF!=null&&allowSendingOfMultiplayerTeam) {
			//
	//		} else {
				if(this.countdownTimer!=null&&!multiplayer)
					this.countdownTimer.gameObject.SetActive(false);
				topLabel.text = PlayerMain.REF.name+" vs "+this.opponentTeam.displayName;
	//		}
			 
			
			 
			
			
			yield return new WaitForEndOfFrame();
			if(smokePuffPrefab!=null)
				NGUITools.AddChild(null,this.smokePuffPrefab);
			
		}
		
		private void onLostConnection() {
	//		SmartfoxHandler.REF.fullDisconnect();
			this.StopAllCoroutines();
			this.cancelMoveQueue();
			this.barController.show = false;
	//		SmartfoxHandler.REF.onMoveQueuePrepared -= onMultiplayerMoveQueueReceived;
	//		SmartfoxHandler.REF.onConnectionLost -= onLostConnection;
	//		SmartfoxHandler.REF.OutputHandlersStatus();
			AlertGUI.REF.DoGeneralAlert("Connection Lost","You have lost connection to the server, please check your connection and reconnect");
			
			cleanInventoryListeners();
		}
		public void onContinueEvolving() {
			if (cancelEvolves != null) {
				cancelEvolves.onLeftAnswer -= onCancelEvolution;
				cancelEvolves.onAnswered -= onContinueEvolving;
				cancelEvolves = null;
			}
			battleOverScreen.consumeEvolves ();
		}

		public void onCancelEvolution() {
			battleOverScreen.cancelCurrentEvolve ();/*
			SmartfoxHandler.REF.onMoveQueuePrepared -= onMultiplayerMoveQueueReceived;
			SmartfoxHandler.REF.onConnectionLost -= onLostConnection;
			SmartfoxHandler.REF.OutputHandlersStatus();
			BattleInit.REF = null;
			SplashScreenManager.ADTIME = EAdTime.BattleEnd;
			Application.LoadLevel("MapChangeSplashScreen");
			if (cancelEvolves != null) {
				cancelEvolves.onLeftAnswer -= onCancelEvolution;
				cancelEvolves.onAnswered -= onContinueEvolving;
				cancelEvolves = null;
			}*/
		}

		public override void cleanUpBattle() {
			base.cleanUpBattle ();
			
			this.battleOverScreen.onExitBattle -= this.onExitBattle;
		}
		public void onExitBattle() {
			cleanUpBattle ();
			if (battleOverScreen != null) {
				if(battleOverScreen.evolutionsToConsume) {
					BattleMonster monsterEvolving = battleOverScreen.monsterEvolving;
		/*			AlertQuestionWindow aqw = AlertGUI.REF.DoQuestionAlert("Terra Monsters are Evolving!","Your "+monsterEvolving.name+" is trying to Evolve! It can only evolve when it has levelled up during battle. Are you sure you want to "+monsterEvolving.name+" from Evolving?","Allow Evolution","Cancel Evolution");
					aqw.onLeftAnswer += onCancelEvolution;
					aqw.onAnswered += onContinueEvolving;
					cancelEvolves = aqw;*/
					battleOverScreen.pauseCurrentEvolution();
					return;
				}
			}
		//	SmartfoxHandler.REF.onMoveQueuePrepared -= onMultiplayerMoveQueueReceived;
		//	SmartfoxHandler.REF.onConnectionLost -= onLostConnection;
		//	SmartfoxHandler.REF.OutputHandlersStatus();
			BattleInit.REF = null;
		//	SplashScreenManager.ADTIME = EAdTime.BattleEnd;
			WorldExplorer.REF.exitBattle();
		}
		//TODO Reenable when multiplayer
		
		public void goMultiplayerBattle() {
			allowSendingOfMultiplayerTeam = false;
			StartCoroutine(delayToInitBattle());
		//	SmartfoxHandler.REF.onMoveQueuePrepared += onMultiplayerMoveQueueReceived;
		}
		
		public void useBait() {
			if(moveQueueActive) {
				return;
			}
		//	if(this.opponentTeam.teamType==ETeamControllerType.WildAI) {
				if(opponentTeam.monsterCount==1) {
					this.barController.show = false;
					BetterList<BattleMonster> ms = opponentTeam.monstersAsBattleMonster;
					BattleMonster b = ms[BattleConstants.FRONT_INDEX];
					for(int i = 0;i<ms.size;i++) { 
						if(ms[i]!=null&&ms[i].monster.restingStatus==ERestingStatus.Awake) {
							b = ms[i];
						}
					}
					MonsterDataMain m = (MonsterDataMain) b.monster;
					m.onMonsterCaughtAttempt += onMonsterCaughtResult;
					createInventoryForBaits(m);
				} else {
					AlertGUI.REF.DoGeneralAlert("Cannot Use Bait","You cannot use baits when there is more than one wild monster!");
				}
		//	}
		}
		
		public void createInventoryForBaits(MonsterDataMain aMonster) {
			if(!moveQueueActive&&opponentTeam.monsterCount==1) {
			//	InventoryDisplay i = AlertGUI.REF.LaunchInventory(EInventoryType.BaitView);
			//	InventoryDisplay.setInventoryTarget(aMonster);
			//	i.createBaitsTable();
			//	i.onHideInventory += this.onHideInventory;
			//	_inventory = i;
			} else { 
				if(opponentTeam.monsterCount>1) {
					AlertGUI.REF.DoGeneralAlert("Cannot Use Bait","You cannot use baits when there is more than one wild monster!");
				}
			}
			
		}
		public void useInventory() {
			if(moveQueueActive) {
				return;
			}

			this.barController.show = false;
			InventoryDisplay.setInventoryTarget(this.barController.currentMonster); 
			createBattleInventory();
	
		}
		
		
		private void createBattleInventory() {
	//		this._inventory = AlertGUI.REF.LaunchInventory(EInventoryType.Battleview);
			_inventory.createBattleItemsTable();
			_inventory.onItemSelected += onItemSelected;
			
			_inventory.onHideInventory += this.onHideInventory;
		}
		private void onItemSelected(ITMItem aItem) {
			Debug.Log ("On Item Selected!");
			this.playersTeam.setMoveToUseItem(aItem,this.barController.currentMonster);
			this.cleanInventoryListeners();
			
		}
		
		protected override void cleanInventoryListeners() {
			if(_inventory!=null) {
				_inventory.onItemSelected -= onItemSelected;
				base.cleanInventoryListeners();
			}
		}
		protected override void onMonsterCaughtResult(ItemBait aItem,EMonsterCatchResult aResult) {
			base.onMonsterCaughtResult(aItem,aResult);
			
			BetterList<BattleMonster> ms = opponentTeam.monstersAsBattleMonster;
			BattleMonster b = ms[BattleConstants.FRONT_INDEX];
			for(int i = 0;i<ms.size;i++) { 
				if(ms[i].monster.restingStatus==ERestingStatus.Awake) {
					b = ms[i];
				}
			}
			MonsterDataMain m = (MonsterDataMain) b.monster;
			m.onMonsterCaughtAttempt -= onMonsterCaughtResult;
			Debug.Log ("onMonsterCaughtResult: "+aResult);
		}
		private void onBattleComplete(BattleTeam aWinning,BattleTeam aLosing) {
			Debug.Log ("onBattleComplete");
			this.transform.eulerAngles = new Vector3 (0f, 166.64f, 0f);
			this.hideExtraButtons();
			this.movesBar.SetActive(false);
			this.topLabel.gameObject.SetActive(false);
			this.barController.hintLabel.gameObject.SetActive(false);
			_battleComplete = true;
			this.GetComponent<CameraTrack> ().setTarget (null);
			if(aWinning==this.playersTeam) {
				
				this._battleTurn = -10;
				this.startConversation();
				if(aLosing.monstersAsBattleMonster.size>0) {
					if(aLosing.caughtMonster!=null) {
						initMonsterCaughtScreen();
					
						PlayerMain.REF.addMonster(aLosing.caughtMonster.monster,true);
						BattleInit.REF.cleanUp();
						BattleInit.REF = null;
						return;
					}
				}
				Debug.Log ("Players Team Won, Updating ID");
				BattleInit.REF.setNPCBattleStatus(1);
				initPostBattleScreen(true);
			} else {
				
				this._battleTurn = -20;
				this.startConversation();
				initPostBattleScreen(false);
				BattleInit.REF.setNPCBattleStatus(2);
			}
			BattleInit.REF.cleanUp();
			BattleInit.REF = null;
		}
		private IEnumerator delayToBattleStart() {
			yield return new WaitForSeconds(0.5f);
			if(_battlesConversation!=null&&_battlesConversation.Length>0) {
				startConversation();
			}
			GameObject g = GameObject.Find ("BattleEstablishingPath");
			CameraPathAnimator cp = g.GetComponent<CameraPathAnimator> ();
			cp.Seek (0f);
			cp.Play ();
			cp.orientationTarget = this.opponentTeam.monstersAsBattleMonster [0].transform;
			cp.orientationMode = CameraPathAnimator.orientationModes.target;
			yield return new WaitForSeconds(4.5f);
			cp.enabled = false;
			this.showMovesForMonster(playersTeam.nextUnsetMonster);
			
		}
		protected override void unpackInitData() {
			base.unpackInitData();
			this.barController.gameObject.SetActive (false);
			if(this.playersTeam.nextUnsetMonster==null) {
				// Go straight to being a loser
				this.onBattleComplete(this.opponentTeam,this.playersTeam);
				return;
			}
			StartCoroutine(delayToBattleStart());
			if(this.countdownTimer!=null) {
				this.countdownTimer.preLabel = "Select Moves: ";
				this.countdownTimer.startStandardTimer();
				this.countdownTimer.onStandardTimerExpired += onAutoSelectMoves;
				this.countdownTimer.onLongTimerExpired += onFailoverToAI;
			}

			if(CommentaryManager.REF!=null) {
				CommentaryManager.REF.battleMonster = null;
				CommentaryManager.REF.passiveEffect = null;
			}
		}
		// Update is called once per frame
		void Update () {
			if(_convertToWild) {
				_convertToWild = false;
				this.opponentTeam.convertToWild();
			}
			
			//if(lookAtObject!=null) {
				//this.camera.transform.LookAt(lookAtObject.gameObject.transform.position);
				
			
			//else this.camera.transform.LookAt (Vector3.zero);
			
		}
		
		private void onFailoverToAI() {
			this._commentaryManager.addCommentaryMessage("AI Takes Control of "+this.opponentTeam.name,ECommentaryMessageType.StandardMessage,ECommentaryMessagePosition.CenterMessage);
			this.countdownTimer.stop();
			this.opponentTeam.turnIntoAI();
			this.opponentTeam.selectAIMoves();
			this.playersTeam.unfadeAllMonsters();
			this.opponentTeam.unfadeAllMonsters();
			this.opponentTeam.allMonstersBackInPlace();
			this.playersTeam.allMonstersBackInPlace();
			this.playersTeam.healthBars = true;
			this.opponentTeam.healthBars = true;
	//		SmartfoxHandler.REF.stopListeningForBattles();
		}
		private void initMonsterCaughtScreen() {
			this.battleOverScreen.init (this.opponentTeam.caughtMonster);
			this.battleOverScreen.onExitBattle += onExitBattle;
		}
		
		public void OnDestroy() {
			if(countdownTimer!=null) {
				countdownTimer.stop();
				this.countdownTimer.onStandardTimerExpired -= onAutoSelectMoves;
				this.countdownTimer.onLongTimerExpired -= onFailoverToAI; 
			}
	/*		if(SmartfoxHandler.REF!=null) {
				SmartfoxHandler.REF.stopListeningForBattles();
				SmartfoxHandler.REF.onMoveQueuePrepared -=  onMultiplayerMoveQueueReceived;
				SmartfoxHandler.REF.OutputHandlersStatus();
			}*/
			if(PlayerMain.REF!=null) {
				PlayerMain.REF.allowMonsterSave = true;
		//	SaveGameUtils.REF.SaveStatsAndQuests();
				PlayerMain.REF.saveMonsters();
			}
			
		}
		
		private void initPostBattleScreen(bool aWon) {
			BetterList<BattleMonster> m = playersTeam.monstersAsBattleMonster;

			this.opponentTeam.fadeOutTeam();
		//	this.playersTeam.fadeOutTeam();
			this.battleOverScreen.init(playersTeam,opponentTeam,aWon);
			this.battleOverScreen.onExitBattle += this.onExitBattle;
			
		}
	}
}
 