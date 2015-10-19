using System;
using Items;
using monsters;
using UnityEngine;


public class MonsterDataItemConsumer : MonsterWithClock
{
	public MonsterDataItemConsumer ()
	{
	}
	
	public delegate void OnMonsterCaughtResult(ItemBait aItem,EMonsterCatchResult aResult);
	public event OnMonsterCaughtResult onMonsterCaughtAttempt; 
	

	
	public EItemUsageType consumeItem(ITMItem aItem,bool aFullConsume) {
		switch(aItem.Type()) {
		case(EItemType.Bait):return useBaitOnMonster(aItem,aFullConsume);
		case(EItemType.BattleBoost):return useBattleBoostOnMonster(aItem,aFullConsume);
		case(EItemType.Collar):return useCollarOnMonster(aItem,aFullConsume);
		case(EItemType.Recovery):return useRecoveryItemOnMonster((ItemRecoveryItem) aItem,aFullConsume);
		case(EItemType.Quest):return useQuestItemOnMonster(aItem,aFullConsume);
		case(EItemType.Vitamin):return useVitaminOnMonster((ItemVitamin) aItem,aFullConsume);
		}
		return EItemUsageType.UseFailed;
	}
	public EItemUsageType useVitaminOnMonster(ItemVitamin aItem,bool aFullConsume) {
		
		if(this.boostMonsterWithVitamin(aItem.boostArea,aItem.boostValue,aFullConsume)) {
			if(aFullConsume) 
			return EItemUsageType.Consumed; else {
				return EItemUsageType.CouldUse;
			}
		} else {
			return EItemUsageType.UseFailed;
		}
		
	}
	public EItemUsageType useBaitOnMonster(ITMItem aItem,bool fullConsume) {
		if(onMonsterCaughtAttempt!=null) {
			if(this._isWild) {
				if(!fullConsume) {
					return EItemUsageType.CouldUse;
				}
				byte catchRate = this.modifiedCatchRate((ItemBait) aItem);
				byte rand = (byte) UnityEngine.Random.Range (0,255);
				if(rand<catchRate) {
					onMonsterCaughtAttempt((ItemBait) aItem,EMonsterCatchResult.Caught);
				} else {
					if(catchRate>200) {
						onMonsterCaughtAttempt((ItemBait) aItem,EMonsterCatchResult.Close);
					} else if(catchRate>100) {
						onMonsterCaughtAttempt((ItemBait) aItem,EMonsterCatchResult.NotClose);
					}
					else {
						onMonsterCaughtAttempt((ItemBait) aItem,EMonsterCatchResult.Missed);
					}
				}
				return EItemUsageType.Consumed;
			}
		}
		return EItemUsageType.UseFailed;
	}
	
	public EItemUsageType useCollarOnMonster(ITMItem aItem,bool aFullConsume) {
		return EItemUsageType.UseFailed;
	
	}
	public EItemUsageType useBattleBoostOnMonster(ITMItem aItem,bool aFullConsume) {
		EItemUsageType usageType = EItemUsageType.UseFailed;
		if(!aFullConsume)
			return EItemUsageType.CouldUse; else 
				return EItemUsageType.Consumed;
	}
	public EItemUsageType useRecoveryItemOnMonster(ItemRecoveryItem aItem,bool aFullConsume) {
		EItemUsageType returnVal = EItemUsageType.UseFailed;
		if((this.lingeringEffects.hasEffect(EStatusEffects.Burn))&&(aItem.healsBurn!=null)) {
			if(aFullConsume) {
				this.lingeringEffects.removeEffect(EStatusEffects.Burn);
				returnVal = EItemUsageType.Consumed;
			} else {
				returnVal = EItemUsageType.CouldUse;
			}
		}
		if((this.lingeringEffects.hasEffect(EStatusEffects.Confusion))&&(aItem.healsConfusion!=null)) {
			if(aFullConsume) {
				this.lingeringEffects.removeEffect(EStatusEffects.Confusion);
				returnVal = EItemUsageType.Consumed;
			} else {
				returnVal = EItemUsageType.CouldUse;
			}
		}
		
		if((this.lingeringEffects.hasEffect(EStatusEffects.Freeze))&&(aItem.healsFreeze!=null)) {
			if(aFullConsume) {
				this.lingeringEffects.removeEffect(EStatusEffects.Freeze);
				returnVal = EItemUsageType.Consumed;
			} else {
				returnVal = EItemUsageType.CouldUse;
			}
		}
		
		if((this.lingeringEffects.hasEffect(EStatusEffects.Paralyze))&&(aItem.healsParalysis!=null)) {
			if(aFullConsume) {
				this.lingeringEffects.removeEffect(EStatusEffects.Paralyze);
				returnVal = EItemUsageType.Consumed;
			} else {
				returnVal = EItemUsageType.CouldUse;
			}
		}
		if((this.lingeringEffects.hasEffect(EStatusEffects.Poison))&&(aItem.healsPoison!=null)) {
			if(aFullConsume) {
				this.lingeringEffects.removeEffect(EStatusEffects.Poison);
				returnVal = EItemUsageType.Consumed;
			} else {
				returnVal = EItemUsageType.CouldUse;
			}
		}
		
		if(aItem.healsHP!=null) {
			if(this.hp<this.MaxHP) {
				if(aFullConsume) {
					int amountToHeal = 0;
					switch(aItem.healsHP.recoveryType) {
						case(EItemRecoveryType.HealPercentage):amountToHeal = (int) aItem.healsHP.healAmount*this.MaxHP;break;
						default:amountToHeal = (int) aItem.healsHP.healAmount;break;
					}
					this.hp += amountToHeal;
					returnVal = EItemUsageType.Consumed;
				} else {
					returnVal = EItemUsageType.CouldUse;
				}
	
	
			}
		}
		if(aItem.restoresEnergy!=null) {
			if(this.energy<this.MaxEnergy) {

				if(aFullConsume) {
					int energyToRecover = 0;
					switch(aItem.restoresEnergy.recoveryType) {
						case(EItemRecoveryType.HealPercentage):energyToRecover = (int) aItem.restoresEnergy.healAmount*this.MaxEnergy;break;
						default:energyToRecover = (int) aItem.restoresEnergy.healAmount;break;
					}
					this.energy += energyToRecover;
					returnVal = EItemUsageType.Consumed;
				} else {
					returnVal = EItemUsageType.CouldUse;
				}
				
			}
		}
		
		return returnVal;
	}
	public EItemUsageType useQuestItemOnMonster(ITMItem aItem,bool aFullConsume) {
		return EItemUsageType.UseFailed;
	}
}

