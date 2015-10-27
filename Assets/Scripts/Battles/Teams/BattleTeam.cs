using System;
using UnityEngine;
using Google2u;
using System.Collections;


namespace Battles
{
	public class BattleTeam : BattleTeamWithAI
	{
	
		public BattleTeam ()
		{
		}
		public void convertToWild() {
			BetterList<BattleMonster> bm = this.monstersAsBattleMonster;
			for(int i = 0;i<bm.size;i++) {
				bm[i].convertToWild();
			}
			this.teamType = ETeamControllerType.WildAI;
		}
		
		public BattleMonster getClosestMonsterTo(Vector3 aPosition) {
			BetterList<BattleMonster> ms = this.monstersAsBattleMonster;
			float closestDist = float.MaxValue;
			BattleMonster closestMonster = null;
			for(int i = 0;i<ms.size;i++) {
				if(Vector3.Distance(aPosition,ms[i].transform.position)<closestDist) {
					closestDist = Vector3.Distance(aPosition,ms[i].transform.position);
					closestMonster = ms[i];
				}
			}
			return closestMonster;
		}
		public float bestMeleeAtck {
			get {
				BetterList<BattleMonster> bm = this.monstersAsBattleMonster;
				float best = float.MinValue;
				for(int i = 0;i<bm.size;i++) {
					if(bm[i]!=null&&(float) bm[i].meleeAttack>best) {
						best = bm[i].meleeAttack;
					}
				}
				return best;
			}
		}
		
		public float bestMeleeDef {
			get {
				BetterList<BattleMonster> bm = this.monstersAsBattleMonster;
				float best = float.MinValue;
				for(int i = 0;i<bm.size;i++) {
					if(bm[i]!=null&&(float) bm[i].meleeDefense>best) {
						best = bm[i].meleeDefense;
					}
				}
				return best;
			}
		}
		public float bestRangeDef {
			get {
				BetterList<BattleMonster> bm = this.monstersAsBattleMonster;
				float best = float.MinValue;
				for(int i = 0;i<bm.size;i++) {
					if(bm[i]!=null&&(float) bm[i].rangeDefense>best) {
						best = bm[i].rangeDefense;
					}
				}
				return best;
			}
		}
		public float bestRangeAtck {
			get {
				BetterList<BattleMonster> bm = this.monstersAsBattleMonster;
				float best = float.MinValue;
				for(int i = 0;i<bm.size;i++) {
					if(bm[i]!=null&&(float) bm[i].rangeAttack>best) {
						best = bm[i].rangeAttack;
					}
				}
				return best;
			}
		}
		public float bestAgility {
			get {
				BetterList<BattleMonster> bm = this.monstersAsBattleMonster;
				float best = float.MinValue;
				for(int i = 0;i<bm.size;i++) {
					if(bm[i]!=null&&(float) bm[i].agility>best) {
						best = bm[i].agility;
					}
				}
				return best;
			}
		}
		public float bestAccuracy {
			get {
				BetterList<BattleMonster> bm = this.monstersAsBattleMonster;
				float best = float.MinValue;
				for(int i = 0;i<bm.size;i++) {
					if(bm[i]!=null&&(float) bm[i].accuracy>best) {
						best = bm[i].accuracy;
					}
				}
				return best;
			}
		}
		public float bestSpeed {
			get {
				BetterList<BattleMonster> bm = this.monstersAsBattleMonster;
				float best = float.MinValue;
				for(int i = 0;i<bm.size;i++) {
					if(bm[i]!=null&&(float) bm[i].speed>best) {
						best = bm[i].speed;
					}
				}
				return best;
			}
		}
		
		public BattleMonster caughtMonster {
			get {
				BetterList<BattleMonster> bm = this.monstersAsBattleMonster;
				for(int i = 0;i<bm.size;i++) {
					if(bm[i].hasBeenCaught) {
						return bm[i];
					}
				}
				return null;
			}
		}
		public string monsterNameList {
			get {
				string s = "";
				BetterList<BattleMonster> ms = this.monstersAsBattleMonster;
				BetterList<BattleMonster> notNulls = new BetterList<BattleMonster>();
				for(int i = 0;i<ms.size;i++) {
					if(ms[i]!=null) {
						notNulls.Add(ms[i]);
					}
				}
				for(int i = 0;i<notNulls.size;i++) {
					s+= notNulls[i].name;
					if(i<notNulls.size-1) {
						s+=", ";
					}
				}
				return s;
			}
		}
		public string displayName {
			get {
				if(this.name.ToLower()=="wild") {
					this.convertToWild();
				}
				if(this.teamType==ETeamControllerType.WildAI) {
					return "Wild "+this.monsterNameList;
				} else {
					return this.name;
				}
			}
		}
		public BetterList<MonsterDataMain> uncaughtMonsters {
			get {
				BetterList<BattleMonster> ms = this.monstersAsBattleMonster;
				BetterList<MonsterDataMain> r = new BetterList<MonsterDataMain>();
				for(int i = 0;i<ms.size;i++) {
					if(PlayerMain.REF.seenMonster(ms[i].monster.monsterBreedRef.ID)!=ESeenMonsterStatuss.Owned) {
						r.Add(ms[i].monster);
					}
				}
				return r;
			}
		}
		public void initFromData(BattleInitTeam aTeamInit,ETeamPosition aPosition) {
			_position = aPosition;
			BetterList<MonsterDataMain> monsters = aTeamInit.monsters;
			
			this.name = aTeamInit.name;
			//setMiddleMonster(monsters);
			//setTopMonster(monsters);
			//setBottomMonster(monsters);
				findSpaceForMonster(monsters);
			for(byte i = 0;i<this._monsters.Length;i++) {
				if(_monsters[i]!=null) {
					BattleConstants.positionMonster(_monsters[i],this._position,positionForMonster(_monsters[i]));
					BattleMonster monster = _monsters[i].GetComponent("BattleMonster") as BattleMonster;
				//	monster.myPosition = positionForMonster(_monsters[i]);
					
					if(monster!=null) {
						monster.onMoveSet += onMonsterMoveSet;
					}
					if(aTeamInit.controlType==Battles.ETeamControllerType.WildAI) {
						monster.monster.ownershipStatus = EOwnershipStatus.Wild;
					}
				}
			}
			base.initFromData(aTeamInit,aPosition);
		}
		

		
		public void fadeTeam(float aFinalAlpha) {
			for(int i = 0;i<this._monsters.Length;i++) {
				if(_monsters[i]!=null) {
					iTween.FadeTo(_monsters[i],aFinalAlpha,0.5f);
				}
			}
			this.healthBars = false;
		}
		public void fadeOutTeam() {
			fadeTeam(0f);
		}
		
		public void initBattleStartPassiveEffects(BattleTeam aOpponent) {
			BetterList<BattleMonster> ms = this.monstersAsBattleMonster;
			for(int i = 0 ;i<ms.size;i++) {
				PassiveEffect effect = ms[i].monster.hasPassiveEffectForTime(EWhenToApply.BattleStart,
				0f,
				0f,
				ms[i].monster.elementType,
				null,
				monstersApartFrom(ms[i]),
             	aOpponent.monstersAsBattleMonster,
             	ERangedStatus.MeleeAndRanged,
             	ms[i],
             	ElementalLibrary.REF.getElement("Normal"));
             	
             	if(effect!=null) {
					if(CommentaryManager.REF!=null) {
						CommentaryManager.REF.passiveEffect = effect;
						CommentaryManager.REF.battleMonster = (BattleMonster) ms[i];
					}
             		applyPassiveEffectToMonsters(EWhenToApply.BattleStart,effect,ms[i],positionForMonster(ms[i]),null);
					aOpponent.applyPassiveEffectToMonsters(EWhenToApply.BattleStart,effect,ms[i],positionForMonster(ms[i]),null);
             	}
             	
				effect = ms[i].monster.hasPassiveEffectForTime(EWhenToApply.WhenOneOpponentisSameAsEffectOwner,
				                                                             0f,
				                                                             0f,
				                                                             ms[i].monster.elementType,
				                                                             null,
				                                                             monstersApartFrom(ms[i]),
				                                                             aOpponent.monstersAsBattleMonster,
				                                                             ERangedStatus.MeleeAndRanged,
				                                                             ms[i],
				                                                             ElementalLibrary.REF.getElement("Normal"));
				
				if(effect!=null) {
					CommentaryManager.REF.passiveEffect = effect;
					CommentaryManager.REF.battleMonster = ms[i];
					
					
					applyPassiveEffectToMonsters(EWhenToApply.WhenOneOpponentisSameAsEffectOwner,effect,ms[i],positionForMonster(ms[i]),null);
					aOpponent.applyPassiveEffectToMonsters(EWhenToApply.WhenOneOpponentisType,effect,ms[i],positionForMonster(ms[i]),null);
					CommentaryManager.REF.passiveEffect = null;
					CommentaryManager.REF.battleMonster = null;
					
				}
				
			}
		}
		
		public float applyPassiveEffectToMonsters(EWhenToApply aWhen,PassiveEffect aEffect,BattleMonster aPassiveEffectOwner,EMonsterPos aEffectOwnerPosition,MoveQueueItem aMoveQueueItem) {
			float delayAmount = 0f;
			if(aEffect.applyAt==aWhen) {
				if(this.containsMonster(aPassiveEffectOwner)) {
						// Check Splash on this passive effect
						BetterList<BattleMonster> monsters = new BetterList<BattleMonster>();
						if(aMoveQueueItem!=null) 
							monsters = this.getBoostTargetsForMove(positionForMonster(aPassiveEffectOwner),aEffect.moveRef,(BattleMonster) aMoveQueueItem.actioningMonster); else 
								monsters = this.getBoostTargetsForMove(positionForMonster(aPassiveEffectOwner),aEffect.moveRef,aPassiveEffectOwner);
						
						if(aEffect.moveRef==null) {
							Debug.LogError("Passive effect for: "+aPassiveEffectOwner.name+" is "+aEffect.moveRef+" passive effect is: "+aPassiveEffectOwner.monster.passiveEffect.name);
							return 0f;
						}
						if(aEffect.moveRef.elementType!=ElementalLibrary.REF.getElement("Normal")) {
							// This passive effect can only be applied to monsters of type: aEffect.moveRef.elementType
							for(int i = 0;i<monsters.size;i++) {
								if(monsters[i].monster.elementType!=aEffect.moveRef.elementType) {
									monsters.RemoveAt(i);
									i--;
								}
							}
					
						for(int i = 0;i<monsters.size;i++) {
							monsters[i].applyStatEffectsFromMove(aEffect.moveRef,null,aEffect);
							delayAmount += monsters[i].applyStatusEffectsForMove(aEffect.moveRef,1,aEffect);
							this.applyHPBoostsToTeam(aEffect,aPassiveEffectOwner,aMoveQueueItem,this._position);
							if(aEffect.moveRef.decisiveBlowsImmunity>0f) {
								monsters[i].criticalHitImmune = true;
							}
							if(aEffect.moveRef.oneHitKillInvulnerable>0f) {
								monsters[i].oneHitKOImmune = true;
							}
						}
					} 
				} else {
					BetterList<BattleMonster> monsters = this.getTargetsForMove(EMonsterPos.Unset,aEffect.moveRef);
					for(int i = 0;i<monsters.size;i++) {
						monsters[i].applyStatEffectsFromMove(aEffect.moveRef,null,aEffect);
						delayAmount += monsters[i].applyStatusEffectsForMove(aEffect.moveRef,1,aEffect);
						applyHPEffectToTeam(aEffect,aPassiveEffectOwner,aEffectOwnerPosition);
					}
				}
			}
			return delayAmount;
		}

		public BetterList<BattleMonster> monstersApartFrom(BattleMonster aMonster) {
			BetterList<BattleMonster> r = new BetterList<BattleMonster>();
			BetterList<BattleMonster> ms = this.monstersAsBattleMonster;
			
			for(int i = 0;i<ms.size;i++) {
				if(ms[i]!=aMonster) {
					r.Add(ms[i]);
				}
			}
			return r;
		}
		protected void onMonsterMoveSet(BattleMonster aMonster,MoveLibItem aMove,bool aAutomatic) {
			base.onMonsterMoveSet(aMonster,aMove,aAutomatic);
		}
	}
}

