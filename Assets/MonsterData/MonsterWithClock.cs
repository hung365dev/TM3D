// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------
using System;
using System.Timers;
using UnityEngine;
using PixelCrushers.DialogueSystem;


		public class MonsterWithClock : MonsterWithMoves
		{
			public bool listeningToClock = false;
			public static BetterList<string> returningToPartyMonsters = new BetterList<string>();
			public static BetterList<MonsterDataMain> monstersAtRanch = new BetterList<MonsterDataMain>();
			public static BetterList<MonsterDataMain> monstersAtRanchResting = new BetterList<MonsterDataMain>();
			public static float HEAL_RATE = 1f;
		public MonsterWithClock () {
			}
			
			public void ListenToClock() {
				if(!listeningToClock) {
			//		GameTimer.REF.OnTimerTick += onMonsterTick;
					GameObject timer = GameObject.FindGameObjectWithTag("Timer");
					if(timer!=null) {
						GameTimer gt = timer.GetComponent<GameTimer>();
						if(gt!=null) {
							GameTimer.monstersListening++;
							gt.OnTimerTick += onMonsterTick;
							listeningToClock = true;
						}
					}
				}
			}

			public void onMonsterTick() {
				if((_resting!=ERestingStatus.Awake&&_resting!=ERestingStatus.WaitingToRest)||(GameTimer.WAKE_ON_HEALED)||(Application.loadedLevelName=="RanchOverview")||(Application.loadedLevelName=="ManageMonster")||(Application.loadedLevelName=="MoveAssignMoveTree")) {
					if(this._resting==ERestingStatus.Awake) {
					//	Debug.Log ("Resting even though I'm awake :)");
					}
					this.lingeringEffects.removeAllEffects();
					bool change = false;
					if(this.hp<this.MaxHP) { 
						this.hp+=HEAL_RATE*GameTimer.REST_MULTIPLIER;
						change = true;
					}
					if(this.energy<this.MaxEnergy) {
						this.energy+=10f*GameTimer.REST_MULTIPLIER;
						if(this.energy>this.MaxEnergy) {
							this.energy = this.MaxEnergy;
						}
						change = true;
						if(!monstersAtRanchResting.Contains((MonsterDataMain) this)) {
							monstersAtRanchResting.Add((MonsterDataMain) this);
						}
				   }
					if(this.hp==this.MaxHP&&this.energy==this.MaxEnergy) {
						monstersAtRanchResting.Remove((MonsterDataMain) this);
						if((Application.loadedLevelName!="WorldViewer"&&Application.loadedLevelName!="MapChangeSplashScreen"&&Application.loadedLevelName!="BattleSceneA")||GameTimer.WAKE_ON_HEALED) {
							if(_resting!=ERestingStatus.Awake) {
								_resting = ERestingStatus.Awake;
								if(PlayerMain.REF.monsterIsBattleMonster((MonsterDataMain) this))
									returningToPartyMonsters.Add(this.name);
							}
						} else {
							_resting = ERestingStatus.VoluntaryRest;
							if(!monstersAtRanch.Contains((MonsterDataMain) this)) {
								monstersAtRanch.Add((MonsterDataMain) this);
							}
						}
				
					} else
						GameTimer.REF.requestMonsterSave = true;
				} else {
					monstersAtRanch.Remove((MonsterDataMain) this);
					monstersAtRanchResting.Remove((MonsterDataMain) this);
				}
			}

		}

