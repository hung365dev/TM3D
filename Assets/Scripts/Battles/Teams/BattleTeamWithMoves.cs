using System;
using UnityEngine;
using Items;
using monsters;
using Battles;


namespace Battles
{
	public class BattleTeamWithMoves : BattleTeamWithInterfaceUtils
	{
		public BattleTeamWithMoves ()
		{ 
			
		} 
		
		public BetterList<MoveQueueItem> reviveMoveQueue() {
			BetterList<MoveQueueItem> returnList = new BetterList<MoveQueueItem>();
			BetterList<BattleMonster> monsters = this.monstersAsBattleMonster;
			Debug.Log ("Monsters as battle monster was: "+this.monstersAsBattleMonster.size);
			
			for(int i = 0;i<monsters.size;i++) {
				if(monsters[i]!=null) {
					Debug.Log("Monster: "+i+" was "+monsters[i].name);
					monsters[i].monster.restingStatus = ERestingStatus.Awake;
					monsters[i].monster.hp =1f;
					monsters[i].hp = 1f;
					monsters[i].removeAllLingeringEffects();
					///iTween.FadeTo(monsters[i].gameObject,1f,0.5f);
					
					MoveQueueItem mq = new MoveQueueItem(float.MaxValue,MovesLib.REF.getMove("Full Revive"),this.teamPosition,this.positionForMonster(monsters[i]),this.positionForMonster(monsters[i]));
					mq.actioningMonster = (BattleMonsterWithMoves) monsters[i];
					mq.actioningTeam = (BattleTeam) this;
					mq.timesToHit = 1;
					returnList.Add(mq);
				}
			}
			Debug.Log ("Revive Move queue was: "+returnList.size);
			return returnList;
		}
		public void prepareTeamForNextTurn() {
			BetterList<BattleMonster> ms = this.monstersAsBattleMonster;
			for(byte c = 0;c < ms.size ; c++) {
				ms[c].prepareForNextTurn();
			}
			_usingBait = null;
			_baitResult = EMonsterCatchResult.Missed;
			
		}
		public void handleMultiplayerMoveQueue(BetterList<MoveQueueItem> aList) {
			for(int i = 0; i < aList.size ; i++) {
				aList[i].actioningMonster = this.monsterFromPosition(aList[i].actionPosition);
				BattleBase.MultiplayerDebugText("Actioning Monster: "+aList[i].actioningMonster.name+" - Wants to perform: "+aList[i].moveData.Name);
				aList[i].actioningMonster.setFutureMove(aList[i].moveData,aList[i].targetTeam,aList[i].targetMonster,false);
			}
			
		}
		
		public void killExhaustedMonsters() {
			BetterList<BattleMonster> bm = this.monstersAsBattleMonster;
			for(int i = 0;i<bm.size;i++) {
				if(!bm[i].monster.hasEnergyForAMove&&bm[i].monster.restingStatus==ERestingStatus.Awake) {
					this.onMonsterCommentary(bm[i],bm[i].name+" is Exhausted!",ECommentaryMessageType.StandardMessage);
					bm[i].monster.restingStatus = ERestingStatus.WaitingToRest;
					disappearMonster(bm[i],1f);
				}
			}
		}
		
		public void setMovesToUseBait(ItemBait aItem,EMonsterCatchResult aResult) {
			_usingBait = aItem;
			_baitResult = aResult;
			BetterList<BattleMonster> ms = this.monstersAsBattleMonster;
			for(int i = 0;i<ms.size;i++) {
				Debug.Log("Doing ms "+i);
				ms[i].setFutureMove(Byte.MaxValue,ETeamPosition.UnSet,EMonsterPos.Unset,false);
			}
		}
		
		public void setMoveToUseItem(ITMItem aItem,MonsterDataMain aMonster) {
			this._itemsForTurn[this.indexForMonster(aMonster)] = aItem;
			
			BetterList<BattleMonster> ms = this.monstersAsBattleMonster;
			
			for(int i = 0;i<ms.size;i++) {
				if(ms[i]!=null&&ms[i].monster==aMonster) {
					ms[i].setFutureMove(aItem);
				}
			}
		}
		public bool changeMoveIfNeeded(MoveQueueItem aMoveQueueItem) {
			
			MoveLibItem move = aMoveQueueItem.moveData;
			if(containsMonster(aMoveQueueItem.actioningMonster)&&move.changeIfAttackerHasStatusEffects!=0) {
				int effectsExisting = (int) ((int) (aMoveQueueItem.actioningMonster.statusEffects)&move.changeIfAttackerHasStatusEffects);
				if(effectsExisting!=0) {
					aMoveQueueItem.moveData = aMoveQueueItem.moveData.changeToThisIfAttackerHasStatusEffects;
					aMoveQueueItem.status = EMoveQueueItemStatus.Start;
					return true;
				}
			}
			else
			if(!containsMonster(aMoveQueueItem.actioningMonster)&&move.changeIfDefenderHasStatusEffects!=0) {
				
				EMonsterPos target = aMoveQueueItem.targetMonster;
				BetterList<BattleMonster> targets = this.getTargetsForMove(target,aMoveQueueItem.moveData);
				if(targets.size>0) {
					int effectsExisting = (int) (targets[0].statusEffects)&move.changeIfDefenderHasStatusEffects;
					if(effectsExisting!=0) {
						aMoveQueueItem.moveData = aMoveQueueItem.moveData.changeToThisIfDefenderHasStatusEffects;
						aMoveQueueItem.status = Battles.EMoveQueueItemStatus.Start;
						return true;
					}
				}
			}
			return false;
		}
		public float applyStatEffectToTeam(MoveQueueItem aItem,CommentaryManager aCommentary) {
			EStatusEffects allStatusApplied = EStatusEffects.None;
			ESplashRange splash = aItem.moveData.splashRange;
			float splashPrecent = aItem.moveData.splashPercent;
			float delayAmount = 0.0f;
			if(containsMonster(aItem.actioningMonster)) {
				if(boostsMyTeam(splash)) {
					EMonsterPos target = aItem.targetMonster;
					BetterList<BattleMonster> targets = this.getBoostTargetsForMove(target,aItem.moveData,(BattleMonster) aItem.actioningMonster);
					for(byte c = 0;c<targets.size;c++) {
						delayAmount += applyStatEffectsToMonster(targets[c],aItem.moveData,aItem);
					}
				}
			} else {
				EMonsterPos target = aItem.targetMonster;
				BetterList<BattleMonster> targets = this.getTargetsForMove(target,aItem.moveData);
				if(!boostsMyTeam(splash)) {
					targets = aItem.hitMonsters;
					for(byte c = 0;c<targets.size;c++) {
						delayAmount+= applyStatEffectsToMonster(targets[c],aItem.moveData,aItem);
					}
				}
			}
			return delayAmount;
		}
		private float applyStatEffectsToMonster(BattleMonster aMonster,MoveLibItem aMoveData,MoveQueueItem aMoveQueueItem) {
			return aMonster.applyStatEffectsFromMove(aMoveData,aMoveQueueItem);
		}
		private bool boostsMyTeam(ESplashRange aSplashRange) {
			return (aSplashRange==ESplashRange.Boost1)||(aSplashRange==ESplashRange.Boost1AndMe)||(aSplashRange==ESplashRange.Boost2)||(aSplashRange==ESplashRange.BoostAll)||(aSplashRange==ESplashRange.BoostMe);
		}
		public float applyStatusEffectToTeam(MoveQueueItem aItem,CommentaryManager aCommentary) {
			EStatusEffects allStatusApplied = EStatusEffects.None;
			float delay = 0.0f;
			if(containsMonster(aItem.actioningMonster)) {
				
			} else {
				ESplashRange splash = aItem.moveData.splashRange;
				float splashPercent = aItem.moveData.splashPercent;
				
				BetterList<BattleMonster> targets = aItem.hitMonsters;
				
				for(byte c = 0;c<targets.size;c++) {
						EStatusEffects effectsApplied = EStatusEffects.None;
						if(c == 0) {
							delay += applyStatusEffectToMonster(aItem.actioningMonster,aItem.moveData,1.0f,targets[c]);
							
						} else {
							delay += applyStatusEffectToMonster(aItem.actioningMonster,aItem.moveData,splashPercent,targets[c]);
						}
						allStatusApplied = allStatusApplied | effectsApplied;
					}
				}
			return delay;
			}
		
		public bool applyHPStatusBoostsToTeam(MoveQueueItem aItem) {
			return false;
		}
		
		
		// TODO Apply HP Boosts to team?
		public bool applyHPBoostsToTeam(PassiveEffect aEffect,BattleMonster aActioningMonster,MoveQueueItem aMoveQueueItem,ETeamPosition aTeamPosition) {
			if(containsMonster(aActioningMonster)) {
				ESplashRange splash = aEffect.moveRef.splashRange;
				float splashPercent = aEffect.moveRef.splashPercent;
				if(aEffect.applyAt==EWhenToApply.WhenHitByMoveTypeAtEndOfMoveQueue&&((aMoveQueueItem.moveData.elementType==aEffect.whenMoveElementType)||(aEffect.whenMoveElementType==null))) {
				
					EMonsterPos target = positionForMonster(aActioningMonster);
					BetterList<BattleMonster> targets = getBoostTargetsForMove(target,aEffect.moveRef,aActioningMonster);
					
					if(targets.size>0) {
						for(int i =0;i<targets.size;i++) {
							if(i==0)
								targets[i].applyHPBoostForMove(aEffect.moveRef,1.0f,aTeamPosition,positionForMonster(targets[i])); else {
								targets[i].applyHPBoostForMove(aEffect.moveRef,splashPercent,aTeamPosition,positionForMonster(targets[i]));
							}
						}
					} else {
						
					}
				}
			} else {
				
			}
			return false;
		}
		
		public bool applyHPBoostsToTeam(MoveQueueItem aItem,CommentaryManager aCommentary) {
			if(containsMonster(aItem.actioningMonster)) {
				ESplashRange splash = aItem.moveData.splashRange;
				float splashPrecent = aItem.moveData.splashPercent;
				
				EMonsterPos target = aItem.targetMonster;
				
				BetterList<BattleMonster> targets = getBoostTargetsForMove(target,aItem.moveData,(BattleMonster) aItem.actioningMonster);
				if(targets.size>0) {
					for(int i = 0;i<targets.size;i++) {
						applyHPBoostEffectToMonster(aItem.actioningMonster,aItem.moveData,targets[i],aCommentary);
					}
				} else {
					
				}
				return false;
			} else {

			}
			return false;
		}
		
		// From passive effect
		public void applyHPEffectToTeam(PassiveEffect aEffect,BattleMonster aMonster,EMonsterPos aPositions) {
			if(containsMonster(aMonster)) {
				Debug.Log("NO HP Effect to apply");
			} else {
				ESplashRange splash = aEffect.moveRef.splashRange;
				float splashPrecent = aEffect.moveRef.splashPercent;
				
				EMonsterPos target = EMonsterPos.Unset;
				BetterList<BattleMonster> targets = getTargetsForMove(target,aEffect.moveRef);
				
				for(byte c = 0;c<targets.size;c++) {
					if(c == 0) {
						applyHPEffectToMonster(aMonster,aEffect.moveRef,1.0f,targets[c],null,aPositions);
					} else {
						applyHPEffectToMonster(aMonster,aEffect.moveRef,splashPrecent,targets[c],null,aPositions);
					}
				}
			}
			
		}
		
		private bool accuracyShouldHit(MoveLibItem aMove,int aMonsterAccuracy,int aDefendingEvasion) {
			float acc = aMove.accuracy;
			acc = acc*((float) aMonsterAccuracy/(float) aDefendingEvasion);
			if(acc>1f) {
				return true;
			} else {
				float r = BattleRandomizer.random;
				BattleBase.DebugText("Random from accuracy is: "+r+" and acc is: "+acc);
				if(acc>r) {
					return true;
				} else {
					return false;
				}
			}
		}
		public void applyHPEffectToTeam(MoveQueueItem aItem,CommentaryManager aCommentaryManager) {
			// Does this team contain the offensive monster?
			if(containsMonster(aItem.actioningMonster)) {
				if(aItem.moveData.isBoost) {
					//this.applyStatusEffectToMonster(
				}
			} else {
				ESplashRange splash = aItem.moveData.splashRange;
				float splashPrecent = aItem.moveData.splashPercent;
				
				EMonsterPos target = aItem.targetMonster;
				BetterList<BattleMonster> targets = getTargetsForMove(target,aItem.moveData);
				
				
				for(byte c = 0;c<targets.size;c++) {
					if(c == 0) {
						if(accuracyShouldHit(aItem.moveData,aItem.actioningMonster.accuracy,targets[c].agility)) {
							aItem.addHitMonster(targets[c]);
							applyHPEffectToMonster(aItem.actioningMonster,aItem.moveData,1.0f,targets[c],aCommentaryManager,aItem.actionPosition);
						} else {
							targets[c].addMissedMessage(aItem.moveData);
						}
					} else {
						if(accuracyShouldHit(aItem.moveData,aItem.actioningMonster.accuracy,targets[c].agility)) {
							aItem.addHitMonster(targets[c]);
							applyHPEffectToMonster(aItem.actioningMonster,aItem.moveData,splashPrecent,targets[c],aCommentaryManager,aItem.actionPosition);
						} else {
							targets[c].addMissedMessage(aItem.moveData);
						}
					}
				}
			}
		} 
		
		private float applyStatusEffectToMonster(BattleMonsterWithMoves aAttacker,MoveLibItem aMove,float aSplashPercent,BattleMonsterWithMoves aDefending) {
			if(aDefending==null) {
				Debug.Log ("Trying to apply status effect to null");
				return 0f;
			}
			return aDefending.applyStatusEffectsForMove(aMove,aSplashPercent);
			
		}
		private PassiveEffect getDefenderHPHitPassiveEffect(BattleMonster aAttacker,BattleMonster aDefender,MoveLibItem aMove) {
		
			PassiveEffect p = aDefender.monster.hasPassiveEffectForTime(EWhenToApply.WhenAlliesAreType,
									aAttacker.monster.HpAsPercentage,
									aDefender.monster.HpAsPercentage,
									aAttacker.monster.elementType,
									aDefender.monster.elementType,
									this.monstersAsBattleMonster,
									null,
									aMove.rangeStatus,
                                    aAttacker,
                                    aMove.elementType);
			if(p!=null) {
				return p;
			}
			
			p = aDefender.monster.hasPassiveEffectForTime(EWhenToApply.WhenAttackerIsType,
			                                                            aAttacker.monster.HpAsPercentage,
			                                                            aDefender.monster.HpAsPercentage,
			                                                            aAttacker.monster.elementType,
			                                                            aDefender.monster.elementType,
			                                                            this.monstersAsBattleMonster,
			                                                            null,
			                                                            aMove.rangeStatus,
			                                              				aAttacker,
			                                              				aMove.elementType);
			if(p!=null) {
				return p;
			}
			p = aDefender.monster.hasPassiveEffectForTime(EWhenToApply.WhenHit,
			                                                            aAttacker.monster.HpAsPercentage,
			                                                            aDefender.monster.HpAsPercentage,
			                                                            aAttacker.monster.elementType,
			                                                            aDefender.monster.elementType,
			                                                            this.monstersAsBattleMonster,
			                                                            null,
			                                                            aMove.rangeStatus,
			                                             				aAttacker,
			                                              				aMove.elementType);
			if(p!=null) {
				return p;
			}
			p = aDefender.monster.hasPassiveEffectForTime(EWhenToApply.WhenHitByMoveType,
			                                                            aAttacker.monster.HpAsPercentage,
			                                                            aDefender.monster.HpAsPercentage,
			                                                            aAttacker.monster.elementType,
			                                                            aDefender.monster.elementType,
			                                                            this.monstersAsBattleMonster,
			                                                            null,
			                                                            aMove.rangeStatus,
			                                              				aAttacker,
			                                              				aMove.elementType);
			if(p!=null) {
				return p;
			}
			p = aDefender.monster.hasPassiveEffectForTime(EWhenToApply.WhenHitByRangeType,
			                                                            aAttacker.monster.HpAsPercentage,
			                                                            aDefender.monster.HpAsPercentage,
			                                                            aAttacker.monster.elementType,
			                                                            aDefender.monster.elementType,
			                                                            this.monstersAsBattleMonster,
			                                                            null,
			                                                            aMove.rangeStatus,
			                                              				aAttacker,
			                                              				aMove.elementType);
			if(p!=null) {
				return p;
			}
			p = aDefender.monster.hasPassiveEffectForTime(EWhenToApply.WhenMyHPHigherThan,
			                                                            aAttacker.monster.HpAsPercentage,
			                                                            aDefender.monster.HpAsPercentage,
			                                                            aAttacker.monster.elementType,
			                                                            aDefender.monster.elementType,
			                                                            this.monstersAsBattleMonster,
			                                                            null,
			                                                            aMove.rangeStatus,
			                                             				aAttacker,
			                                              				aMove.elementType);
			if(p!=null) {
				return p;
			}
			p = aDefender.monster.hasPassiveEffectForTime(EWhenToApply.WhenMyHPLowerThan,
			                                                            aAttacker.monster.HpAsPercentage,
			                                                            aDefender.monster.HpAsPercentage,
			                                                            aAttacker.monster.elementType,
			                                                            aDefender.monster.elementType,
			                                                            this.monstersAsBattleMonster,
			                                                            null,
			                                                            aMove.rangeStatus,
			                                             				aAttacker,
			                                              				aMove.elementType);
			if(p!=null) {
				return p;
			}
			p = aDefender.monster.hasPassiveEffectForTime(EWhenToApply.WhenStatusEffectsSuffered,
			                                                            aAttacker.monster.HpAsPercentage,
			                                                            aDefender.monster.HpAsPercentage,
			                                                            aAttacker.monster.elementType,
			                                                            aDefender.monster.elementType,
			                                                            this.monstersAsBattleMonster,
			                                                            null,
			                                                            aMove.rangeStatus,
			                                           					aAttacker,
			                                             				aMove.elementType);
			if(p!=null) {
				return p;
			}
			p = aAttacker.monster.hasPassiveEffectForTime(EWhenToApply.WhenMyHPHigherThan,
			                                              aDefender.monster.HpAsPercentage,
			                                              aAttacker.monster.HpAsPercentage,
			                                              aAttacker.monster.elementType,
			                                              aDefender.monster.elementType,
			                                              this.monstersAsBattleMonster,
			                                              null,
			                                              aMove.rangeStatus,
			                                              aAttacker,
			                                              aMove.elementType);
			if(p!=null) {
				return p;
			}
			
			p = aAttacker.monster.hasPassiveEffectForTime(EWhenToApply.WhenMyHPLowerThan,
			                                              aDefender.monster.HpAsPercentage,
			                                              aAttacker.monster.HpAsPercentage,
			                                              aAttacker.monster.elementType,
			                                              aDefender.monster.elementType,
			                                              this.monstersAsBattleMonster,
			                                              null,
			                                              aMove.rangeStatus,
			                                              aAttacker,
			                                              aMove.elementType);
			if(p!=null) {
				return p;
			}
			
			return null;
		}
			
		private PassiveEffect getAttackHPHitPassiveEffect(BattleMonster aAttacker,BattleMonster aDefender,MoveLibItem aMove) {
			PassiveEffect p = aAttacker.monster.hasPassiveEffectForTime(EWhenToApply.WhenAttackingWithMoveType,
			aDefender.monster.HpAsPercentage,
			aAttacker.monster.HpAsPercentage,
			aAttacker.monster.elementType,
			aDefender.monster.elementType,
			this.monstersAsBattleMonster,
			null,
			aMove.rangeStatus,
			aAttacker,
			aMove.elementType);
			
			if(p!=null) {
				return p;
			}
			
			p = aAttacker.monster.hasPassiveEffectForTime(EWhenToApply.WhenMyHPHigherThan,
			                                                            aDefender.monster.HpAsPercentage,
			                                                            aAttacker.monster.HpAsPercentage,
			                                                            aAttacker.monster.elementType,
			                                                            aDefender.monster.elementType,
			                                                            this.monstersAsBattleMonster,
			                                                            null,
			                                                            aMove.rangeStatus,
			                                             				 aAttacker,
			                                             				 aMove.elementType);
			if(p!=null) {
				return p;
			}
			
			p = aAttacker.monster.hasPassiveEffectForTime(EWhenToApply.WhenMyHPLowerThan,
			                                              aDefender.monster.HpAsPercentage,
			                                              aAttacker.monster.HpAsPercentage,
			                                              aAttacker.monster.elementType,
			                                              aDefender.monster.elementType,
			                                              this.monstersAsBattleMonster,
			                                              null,
			                                              aMove.rangeStatus,
			                                              aAttacker,
			                                              aMove.elementType);
			if(p!=null) {
				return p;
			}
			
			p = aAttacker.monster.hasPassiveEffectForTime(EWhenToApply.WhenOpponentHasStatusEffect,
			                                              aDefender.monster.HpAsPercentage,
			                                              aAttacker.monster.HpAsPercentage,
			                                              aAttacker.monster.elementType,
			                                              aDefender.monster.elementType,
			                                              this.monstersAsBattleMonster,
			                                              null,
			                                              aMove.rangeStatus,
			                                              aAttacker,
			                                              aMove.elementType);
			if(p!=null) {
				return p;
			}

			p = aAttacker.monster.hasPassiveEffectForTime(EWhenToApply.WhenStatusEffectsSuffered,
			                                              aDefender.monster.HpAsPercentage,
			                                              aAttacker.monster.HpAsPercentage,
			                                              aAttacker.monster.elementType,
			                                              aDefender.monster.elementType,
			                                              this.monstersAsBattleMonster,
			                                              null,
			                                              aMove.rangeStatus,
			                                              aAttacker,
			                                              aMove.elementType);
			if(p!=null) {
				return p;
			}
			
			
			return null;
		}
		private void applyHPBoostEffectToMonster(BattleMonsterWithMoves aBooster,MoveLibItem aMove,BattleMonsterWithMoves aBoosted,CommentaryManager aCommentaryManagern) {
			
			
			float attackStatPower = aBooster.rangeAttack;
			float defenseStat = aBoosted.rangeDefense;
			if(aMove.rangeStatus == ERangedStatus.Melee) {
				attackStatPower = aBooster.meleeAttack;
				defenseStat = aBoosted.meleeDefense;
			}
			
			
			float dmg = 0;
			float selfHitPercent = aMove.selfInflictPercent;
			bool criticalApplied = false;
			
			
			
			switch(aMove.powerApplicationType) {
			case(EPowerApplicationTypes.Normal):
				float attackPower = aMove.getPower(aBooster.unlockLevelForMove(aMove));;
				
				float stab = 1.0f;
				if(aMove.elementType==aBooster.monster.elementType) {
					stab = 1.5f;
				} else if(aMove.elementType==aBooster.monster.secondaryType) {
					stab = 1.25f;
				}
				
				int random = (int) (BattleRandomizer.random*15)+85;
				if(attackStatPower == 0) {
					
				}

							
				float weaknessStrength = aBoosted.getWeaknessStrengthToElement(aMove.elementType);
				if(attackPower>0) 
					dmg = ((((2 * aBooster.monster.level / 5 + 2) * attackStatPower * attackPower / defenseStat) / 50) + 2) * stab * aBoosted.getWeaknessStrengthToElement(aMove.elementType) * random / 100;
				dmg = (float) Math.Ceiling(dmg*2);
				BattleBase.DebugText("((((2 * "+aBooster.monster.level+" / 5 + 2) * "+attackStatPower+" * "+attackPower+" / "+defenseStat+") / 50) + 2) * "+stab+" * "+aBoosted.getWeaknessStrengthToElement(aMove.elementType)+" * "+random+" / 100");
				
				BattleBase.DebugText("Dmg to apply is: "+dmg);
				break;
			case(EPowerApplicationTypes.PowerIsPercentOfHP):
					dmg = (aMove.power/100)*aBooster.monster.MaxHP;
				break;
				
			}
			
			if(selfHitPercent>0f) {
				float selfDamage = dmg * selfHitPercent;
				aBooster.takeHP((int) selfDamage,otherPosition(),aBooster.myPosition);	
			} else {
				float selfHeal = dmg * selfHitPercent*-1;;
				if(selfHeal>0f)
					aBooster.addHP(selfHeal,otherPosition(),aBooster.myPosition);
			}
			
			EMonsterPos defendingPosition = monsterPositionByMonster(aBoosted as BattleMonster);
			if(dmg>0)
				aBoosted.addHP(dmg,this._position,defendingPosition);
			
			
			this.applyStatusEffectToMonster(aBooster,aMove,1f,aBoosted);
		}
					
					
		private void applyHPEffectToMonster(BattleMonsterWithMoves aAttacker,MoveLibItem aMove,float aSplashPercent,BattleMonsterWithMoves aDefending,CommentaryManager aCommentaryManager,EMonsterPos aAttackersPosition) {
			
			//Damage = ((((2 * Level / 5 + 2) * AttackStat * AttackPower / DefenseStat) / 50) + 2) * STAB * Weakness/Resistance * RandomNumber / 100
			
			BattleBase.DebugText("BattleTeamWithMoves->applyHPEffectToMonster");
			PassiveEffect attackersEffect = getAttackHPHitPassiveEffect((BattleMonster) aAttacker,(BattleMonster) aDefending,aMove);
			PassiveEffect defendersEffect = getDefenderHPHitPassiveEffect((BattleMonster) aAttacker,(BattleMonster) aDefending,aMove);
			
			if(CommentaryManager.REF!=null) {
				CommentaryManager.REF.passiveEffect = attackersEffect;
				CommentaryManager.REF.battleMonster = (BattleMonster) aAttacker;
			}
			
			if((int) aMove.powerOnlyIfTheseStatusEffects>0&&((aDefending.statusEffects&aMove.powerOnlyIfTheseStatusEffects)==EStatusEffects.None)) {
				return;
			}
			
			float attackStatPower = aAttacker.rangeAttack;
			float defenseStat = aDefending.rangeDefense;
			if(aMove.rangeStatus == ERangedStatus.Melee) {
				attackStatPower = aAttacker.meleeAttack;
				defenseStat = aDefending.meleeDefense;
			}
			
			bool criticalHitRandom = BattleRandomizer.random < (aMove.criticalHitChance*aAttacker.criticalHitChanceMultiplier);
			
			float dmg = 0;
			float selfHitPercent = aMove.selfInflictPercent;
			bool criticalApplied = false;
			if(criticalHitRandom) {
				if(aDefending.criticalHitImmune) {
					BattleBase.DebugText("Critical hit immune");
				} else {
					attackStatPower *= 2;
					criticalApplied = true;
					BattleBase.DebugText("Critical hit being applied");
				}
				
			} else {
				
				BattleBase.DebugText("No critical hit");
			}
			
			
			switch(aMove.powerApplicationType) {
				case(EPowerApplicationTypes.Normal):
					float attackPower = aMove.getPower(aAttacker.unlockLevelForMove(aMove));;
					
					float stab = 1.0f;
					if(aMove.elementType==aAttacker.monster.elementType) {
						stab = 1.15f;
					} else if(aMove.elementType==aAttacker.monster.secondaryType) {
						stab = 1.075f;
					}
					
					int random = (int) (BattleRandomizer.random*15)+85;
					if(attackStatPower == 0) {
						
					}
					if(attackersEffect!=null) {
						if(!attackersEffect.applyToSelf) {
							// My attackers effect does something to the opponent.
							attackStatPower = attackStatPower * attackersEffect.getEffectOnAttackPower(aMove.rangeStatus,aMove.elementType);
							selfHitPercent += attackersEffect.moveRef.selfInflictPercent;
						}
						
					}
					BattleBase.DebugText("Defending Monster is: "+aDefending.name+" - Level: "+aDefending.monster.level);
					
					float weaknessStrength = aDefending.getWeaknessStrengthToElement(aMove.elementType);
					if(weaknessStrength>1f)
						this.onMonsterCommentary((BattleMonster) aDefending,"Effective vs. "+aDefending.monster.name,ECommentaryMessageType.DmgEffective); else 
						if(weaknessStrength<1f) {
							this.onMonsterCommentary((BattleMonster) aDefending,"Ineffective vs. "+aDefending.monster.name,ECommentaryMessageType.DmgInEffective); 	
						}
					BattleBase.DebugText("Random in use is: "+random+" - Move element is: "+aMove.elementType.Name+", Move Range: "+aMove.rangeStatus+",Range Defense: "+aDefending.meleeDefense+"  - Melee Defense: "+aDefending.rangeDefense);
					if(attackPower>0) 
						dmg = ((((2 * aAttacker.monster.level / 5 + 2) * attackStatPower * attackPower / defenseStat) / 50) + 2) * stab * aDefending.getWeaknessStrengthToElement(aMove.elementType) * random / 100;
					dmg = (float) Math.Ceiling(dmg*2);
					BattleBase.DebugText("((((2 * "+aAttacker.monster.level+" / 5 + 2) * "+attackStatPower+" * "+attackPower+" / "+defenseStat+") / 50) + 2) * "+stab+" * "+aDefending.getWeaknessStrengthToElement(aMove.elementType)+" * "+random+" / 100");
					
					BattleBase.DebugText("Dmg to apply is: "+dmg);
				break;
				case(EPowerApplicationTypes.PowerIsPercentOfHP):
					dmg = (aMove.power/100)*aDefending.monster.MaxHP;
				break;
						
			}

			if(defendersEffect!=null) {
				if(defendersEffect.applyToSelf) {
					
				} else {
					this.applyStatusEffectToMonster(aDefending,defendersEffect.moveRef,1.0f,aAttacker);
				}
			}
			
			if(aDefending.oneHitKOImmune&&aDefending.hp==aDefending.monster.MaxHP&&dmg>=aDefending.monster.MaxHP) {
				dmg = aDefending.monster.MaxHP-1f;
			}

			EMonsterPos defendingPosition = monsterPositionByMonster(aDefending as BattleMonster);
			if(dmg>0) {
				dmg = dmg*aSplashPercent;
				if(dmg>aDefending.hp) {
					dmg = aDefending.hp;
				}
				
				BattleBase.DebugText("HP before is: "+aDefending.hp);
				aDefending.takeHP(dmg,this._position,defendingPosition,criticalApplied);
				
				BattleBase.DebugText("HP after is: "+aDefending.hp);
				
			}
			if(selfHitPercent>0f&&aSplashPercent==1f) {
				float selfDamage = dmg * selfHitPercent;
				
				BattleBase.DebugText("Self hit damage is "+selfDamage);
				aAttacker.takeHP((int) selfDamage,otherPosition(),aAttackersPosition);	
			} else {
				float selfHeal = dmg * selfHitPercent*-1;;
				if(selfHeal>0f)
					aAttacker.addHP(selfHeal,otherPosition(),aAttackersPosition);
			}
			
			
		}
		
		protected ETeamPosition otherPosition() {
			if(_position==ETeamPosition.LeftTeam) {
				return ETeamPosition.RightTeam;
			}
			return ETeamPosition.LeftTeam;
		}
		protected EMonsterPos monsterPositionByMonster(BattleMonster aMonster) {
			BetterList<BattleMonster> ms = this.monstersAsBattleMonster;
			for(byte c = 0 ; c < ms.size ; c++ ) {
				if(aMonster==ms[c]) {
					switch(c) {
						case(0):return EMonsterPos.Top;break;
						case(1):return EMonsterPos.Front;break;
						case(2):return EMonsterPos.Bottom;break;
					}
				}
			}
			return EMonsterPos.Unset;
		}
		public BetterList<BattleMonster> getBoostTargetsForMove(EMonsterPos aPrimaryTarget,MoveLibItem aMove,BattleMonster aActioningMonster) {
			BetterList<BattleMonster> ms = this.monstersAsBattleMonster;
			BetterList<BattleMonster> r = new BetterList<BattleMonster>();
			if(aMove==null) {
				Debug.LogError ("Move for "+aActioningMonster.name+" was "+aMove+". Monsters passive effect was: "+aActioningMonster.monster.passiveEffect.name);
				return r;
			}
			ESplashRange splashRange = aMove.splashRange;
			int boostInfo = (int) aMove.splashRange;
			if((splashRange&ESplashRange.AllBoosts)==0) {
				return new BetterList<BattleMonster>();
			}
			if(aMove.splashRange==ESplashRange.Boost2) {
				for(int i = 0;i<ms.size;i++) {
					if(ms[i]!=aActioningMonster) {
						r.Add(ms[i]);
					}
				}
				r = cleanReturnTargets(r);
				return r;
			}
			switch(aPrimaryTarget) {
			case(EMonsterPos.Front): {
				r.Add(ms[BattleConstants.FRONT_INDEX]);
				if(aMove.splashRange==ESplashRange.BoostAll/*||aMove.splashRange==ESplashRange.Boost1*/) {
					// Middle monster has no splash range 1, only lessened damage to splashers
					r.Add(ms[BattleConstants.TOP_INDEX]);
					r.Add(ms[BattleConstants.BOTTOM_INDEX]);
				}
			}
				break;
			case(EMonsterPos.Top): {
				r.Add(ms[BattleConstants.TOP_INDEX]);
				if(aMove.splashRange==ESplashRange.BoostAll/*||aMove.splashRange==ESplashRange.Boost1*/) {
					r.Add(ms[BattleConstants.FRONT_INDEX]);
					if(aMove.splashRange==ESplashRange.BoostAll)
						r.Add (ms[BattleConstants.BOTTOM_INDEX]);
				}
			}
				break;
			case(EMonsterPos.Bottom): {
				r.Add(ms[BattleConstants.BOTTOM_INDEX]);
				if(aMove.splashRange==ESplashRange.BoostAll/*||aMove.splashRange==ESplashRange.Boost1*/) {
					// Middle monster has no splash range 1, only lessened damage to splashers
					r.Add(ms[BattleConstants.FRONT_INDEX]);
					if(aMove.splashRange==ESplashRange.BoostAll)
						r.Add (ms[BattleConstants.TOP_INDEX]);
				}
			}
				break;
			}

			
			r = cleanReturnTargets(r);
			
			if(r.size==0&&!this.teamIsDead) {
				// Aim downwards if we can
				switch(aPrimaryTarget) {
					case(EMonsterPos.Top): return getBoostTargetsForMove(EMonsterPos.Front,aMove,aActioningMonster);
					case(EMonsterPos.Front): return getBoostTargetsForMove(EMonsterPos.Bottom,aMove,aActioningMonster);
					case(EMonsterPos.Bottom): return getBoostTargetsForMove(EMonsterPos.Top,aMove,aActioningMonster);
				}
				
			}
			return r;
		}
		
		private BetterList<BattleMonster> cleanReturnTargets(BetterList<BattleMonster> aReturns) {
			
			// Remove those with no HP left
			for(byte c = 0;c<aReturns.size;c++) {
				if(aReturns[c]==null||aReturns[c].monster.restingStatus!=ERestingStatus.Awake) {
					aReturns.RemoveAt(c);
					c--;
				}
			}
			return aReturns;
		}
		public EMonsterPos updatedTargetPosition(EMonsterPos aPosition) {
			BetterList<BattleMonster> ms = this.monstersAsBattleMonster;
			int i = 0;
			switch(aPosition) {
				case(EMonsterPos.Front):if(ms[BattleConstants.FRONT_INDEX]!=null&&ms[BattleConstants.FRONT_INDEX].monster.restingStatus==ERestingStatus.Awake) {
												return aPosition;
											} else {
												return updatedTargetPosition(EMonsterPos.Top);
											}
											break;
				case(EMonsterPos.Top):if(ms[BattleConstants.TOP_INDEX]!=null&&ms[BattleConstants.TOP_INDEX].monster.restingStatus==ERestingStatus.Awake) {
						return aPosition;
					} else {
						return updatedTargetPosition(EMonsterPos.Bottom);
					}
				break;
				case(EMonsterPos.Bottom):if(ms[BattleConstants.BOTTOM_INDEX]!=null&&ms[BattleConstants.BOTTOM_INDEX].monster.restingStatus==ERestingStatus.Awake) {
						return aPosition;
					} else {
						return updatedTargetPosition(EMonsterPos.Front);
					}
				break;						
			}
			return aPosition;
		} 
		public BetterList<BattleMonster> getTargetsForMove(EMonsterPos aPrimaryTarget,MoveLibItem aMove) {
		
	
			if(((aMove.splashRange&ESplashRange.AllHits)==0)&&(aMove.splashRange!=0)) {
				return new BetterList<BattleMonster>();
			}
			BetterList<BattleMonster> ms = this.monstersAsBattleMonster;
			if(ms.size==0) {
				return new BetterList<BattleMonster>();
			}
			int splashRange = (int) aMove.splashRange;
			BetterList<BattleMonster> r = new BetterList<BattleMonster>();
			if(aMove.splashRange==ESplashRange.RandomOpponent) {
				int randomItem = (int) (BattleRandomizer.random*ms.size);
				
				r.Add(ms[randomItem]); 
				return r;
			}
			int primTarget = (int) aPrimaryTarget;
			
			
			switch(aPrimaryTarget) {
				case(EMonsterPos.Front):case(EMonsterPos.Unset): {
					r.Add(ms[BattleConstants.FRONT_INDEX]);
					if(aMove.splashRange==ESplashRange.HitAll||aMove.splashRange==ESplashRange.SplashRange1) {
						// Middle monster has no splash range 1, only lessened damage to splashers
						r.Add(ms[BattleConstants.TOP_INDEX]);
						r.Add(ms[BattleConstants.BOTTOM_INDEX]);
					}
				}
				break;
			case(EMonsterPos.Top): {
				r.Add(ms[BattleConstants.TOP_INDEX]);
				if(aMove.splashRange==ESplashRange.HitAll||aMove.splashRange==ESplashRange.SplashRange1) {
					r.Add(ms[BattleConstants.FRONT_INDEX]);
					if(aMove.splashRange==ESplashRange.HitAll)
						r.Add (ms[BattleConstants.BOTTOM_INDEX]);
				}
			}
			break;
			case(EMonsterPos.Bottom): {
				r.Add(ms[BattleConstants.BOTTOM_INDEX]);
				if(aMove.splashRange==ESplashRange.HitAll||aMove.splashRange==ESplashRange.SplashRange1) {
					// Middle monster has no splash range 1, only lessened damage to splashers
					r.Add(ms[BattleConstants.FRONT_INDEX]);
					if(aMove.splashRange==ESplashRange.HitAll)
						r.Add (ms[BattleConstants.TOP_INDEX]);
				}
			}
			break;
			}
			
			// Remove those with no HP left
			r = cleanReturnTargets(r);
			
			if(r.size==0&&!this.teamIsDead) {
				// Aim downwards if we can
				switch(aPrimaryTarget) {
					case(EMonsterPos.Top): return getTargetsForMove(EMonsterPos.Bottom,aMove);
					case(EMonsterPos.Front): return getTargetsForMove(EMonsterPos.Top,aMove);
					case(EMonsterPos.Bottom): return getTargetsForMove(EMonsterPos.Front,aMove);
				}
				
			}
			
			return r;
		}
		
			
			
	}
}

