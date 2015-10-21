using System;
using Google2u;
using PixelCrushers.DialogueSystem;
using Parse;
using utils;
using UnityEngine;
using System.Collections.Generic;


namespace Battles
{
		public class BattleInit
		{
				public BattleInitTeam[] teams = new BattleInitTeam[2];
				public static BattleInit REF;
				public string battleBackground;
				public string convoNPCName;
				public string forcedConversation;
				public int money = 0;
				public string itemsToAward = "";
				public string orVariableWhenWon;
				public string musicTrack;
				public int valueToOrWhenWon;
				private NPCBattlesRow _npcRef;
				public BattleInit ()
				{
				
					if(REF!=null) {
						REF.cleanUp();
					}
			
					REF = this;
				}
				public BattleInit(NPCBattlesRow aNPCBattle,BetterList<NPCBattleMonstersRow> aNPCMonsters) {
					battleBackground = aNPCBattle._BattleBG;
					if(REF!=null) {
						REF.cleanUp();
					}
					REF = this;
					_npcRef = aNPCBattle;
					this.itemsToAward = aNPCBattle._ItemsReward;
					this.money = aNPCBattle._CashReward;
					teams[0] = new BattleInitTeam();
					teams[0].controlType = ETeamControllerType.SinglePlayerUser;
					Debug.Log("Including NPC Actor: "+aNPCBattle._IncludedNPCActor);
					if(aNPCBattle._IncludedNPCActor!=null&&aNPCBattle._IncludedNPCActor.Length>0) {
						string alliesMonster = DialogueLua.GetActorField(aNPCBattle._IncludedNPCActor,"PrimaryMonster").AsString;
						Debug.Log ("Allies monster is: "+alliesMonster);
						int lev = PlayerMain.REF.highMonster.level;
						MonsterDataMain m = new MonsterDataMain();
						m.initMonster(MonsterLibrary.REF.getMonster(alliesMonster).ID,(byte) lev,true);
						teams[0].addFightingMonster(m,2,aNPCBattle._IncludedNPCActor);
					} 
			
					teams[1] = new BattleInitTeam();
					teams[1].controlType = ETeamControllerType.RegularAI;
					teams[1].initTeamFromBattlesRow(aNPCBattle,aNPCMonsters);;
					forcedConversation = aNPCBattle._ForcedConversation;
					convoNPCName = aNPCBattle._ConversationMainActor;
				}
				
				//TODO Reenable when multiplayer
				/*
				public BattleInit(SFSObject aData) {
					if(REF!=null) {
						REF.cleanUp();
					}
			
					battleBackground = "";//aNPCBattle._BATTLEBG;
					REF = this;
					
					BattleBase.DebugText("BattleInit(SFSObject aData) ->Making Team 1");
					teams[0] = new BattleInitTeam((SFSObject) aData.GetSFSArray("arr").GetSFSObject(0));
					BattleRandomizer.loadFromSFSArray((SFSArray) aData.GetSFSArray("arr").GetSFSObject(0).GetSFSArray("r"));
					
					BattleBase.DebugText("BattleInit(SFSObject aData) ->Making Team 2");
					teams[1] = new BattleInitTeam((SFSObject) aData.GetSFSArray("arr").GetSFSObject(1));
			
					
					
				}
		*/
				public BattleInit(SpawnAreaMonster aSpawnAreaMonster,string aBattleBG) {
					// General Spawn Point
					battleBackground = aBattleBG;
					if(REF!=null) {
						REF.cleanUp();
					}
					REF = this;
	
					teams[0] = new BattleInitTeam();
					teams[0].controlType = ETeamControllerType.SinglePlayerUser;
					
			
					teams[1] = new BattleInitTeam();
					teams[1].controlType = ETeamControllerType.WildAI;
					teams[1].initTeamFromSpawnAreaMonster(aSpawnAreaMonster);;
		

				}
				
				public void setNPCBattleStatus(int aStatus) {
					Debug.Log ("SetNPCBattleStatus: "+aStatus+" - "+_npcRef);
					if(orVariableWhenWon!=null&&orVariableWhenWon.Length>0&&aStatus==1) {
						Lua.Result r = DialogueLua.GetVariable(orVariableWhenWon);
						int newVal = r.AsInt|this.valueToOrWhenWon;
						DialogueLua.SetVariable(orVariableWhenWon,newVal);
					}
					if(_npcRef!=null) {
						DialogueLua.SetVariable(_npcRef._BattleName,aStatus); 
						if(aStatus==2) {
							SaveGameUtils.REF.incrementLuaStat("LossesCount",1);
						} else if(aStatus==1) {
					
							SaveGameUtils.REF.incrementLuaStat("NPCBattlesWon",1);

						}
						
					} else {
						if(aStatus==1) {
							SaveGameUtils.REF.incrementLuaStat("WildBattleWins",1);
						} else {
						}
					}
					if(_npcRef!=null) {

			}
					SaveGameUtils.REF.SaveStatsAndQuests();
					
				}
				public void cleanUp() {
					teams = null;
					REF = null;
					_npcRef = null; 
				}
			
		}
}

