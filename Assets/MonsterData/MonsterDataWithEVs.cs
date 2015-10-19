using System;
using UnityEngine;
public class MonsterDataWithEVs : MonsterDataBase
{

	public const float MAX_EV_PER_LEVEL = 10f;
	public MonsterDataWithEVs ()
	{
	}

	public bool boostMonsterWithVitamin(EBoostableArea aArea,int aValue,bool aFullConsume) {
		bool anyImproved = false;
		if((aArea&EBoostableArea.BoostAccuracy)==EBoostableArea.BoostAccuracy) {
			if(canBoostAccuracyEV((float) aValue,aFullConsume)) {
				anyImproved = true;
			}
		}
		if((aArea&EBoostableArea.BoostAgility)==EBoostableArea.BoostAgility) {
			if(canBoostAgilityEV((float) aValue,aFullConsume)) {
				anyImproved = true;
			}
		}
		if((aArea&EBoostableArea.BoostMeleeAtck)==EBoostableArea.BoostMeleeAtck) {
			if(canBoostMeleeAtckEV((float) aValue,aFullConsume)) {
				anyImproved = true;
			}
		}
		if((aArea&EBoostableArea.BoostMeleeDef)==EBoostableArea.BoostMeleeDef) {
			if(canBoostMeleeDefEV((float) aValue,aFullConsume)) {
				anyImproved = true;
			}
		}
		if((aArea&EBoostableArea.BoostRangeAtck)==EBoostableArea.BoostRangeAtck) {
			if(canBoostRangeAtckEV((float) aValue,aFullConsume)) {
				anyImproved = true;
			}
		}
		if((aArea&EBoostableArea.BoostRangeDef)==EBoostableArea.BoostRangeDef) {
			if(canBoostRangeDefEV((float) aValue,aFullConsume)) {
				anyImproved = true;
			}
		}
		if((aArea&EBoostableArea.BoostSpeed)==EBoostableArea.BoostSpeed) {
			if(canBoostSpeedEV((float) aValue,aFullConsume)) {
				anyImproved = true;
			}
		}
		if((aArea&EBoostableArea.BoostXP)==EBoostableArea.BoostXP) {
			if(canBoostXP(aValue,aFullConsume)) {
				anyImproved = true;
			}
		}
		return anyImproved;
	}
	
	public bool canBoostAccuracyEV(float aValue,bool aFullConsume) {
		if(this._accuracyEVInLevel<MAX_EV_PER_LEVEL) {
			if(aFullConsume) {
				this._accuracyEVInLevel += aValue;
				this._accuracyEV += aValue;
			}
			return true;
		}
		return false;
	}
	
	public bool canBoostAgilityEV(float aValue,bool aFullConsume) {
		if(this._agilityEVInLevel<MAX_EV_PER_LEVEL) {
			if(aFullConsume) {
				this._agilityEVInLevel += aValue;
				this._agilityEV += aValue;
			}
			return true;
		}
		return false;
	}
	
	public bool canBoostMeleeAtckEV(float aValue,bool aFullConsume) {
		if(this._meleeAttackEVInLevel<MAX_EV_PER_LEVEL) {
			if(aFullConsume) {
				this._meleeAttackEVInLevel += aValue;
				this._meleeAttackEV += aValue;
			}
			return true;
		}
		return false;
	}
	public bool canBoostMeleeDefEV(float aValue,bool aFullConsume) {
		if(this._meleeDefenseEVInLevel<MAX_EV_PER_LEVEL) {
			if(aFullConsume) {
				this._meleeDefenseEVInLevel += aValue;
				this._meleeDefenseEV += aValue;
			}
			return true;
		}
		return false;
	}
	public bool canBoostRangeAtckEV(float aValue,bool aFullConsume) {
		if(this._rangeAttackEVInLevel<MAX_EV_PER_LEVEL) {
			if(aFullConsume) {
				this._rangeAttackEVInLevel += aValue;
				this._rangeAttackEV += aValue;
			}
			return true;
		}
		return false;
	}
	public bool canBoostRangeDefEV(float aValue,bool aFullConsume) {
		if(this._rangeDefenseEVInLevel<MAX_EV_PER_LEVEL) {
			if(aFullConsume) {
				this._rangeDefenseEVInLevel += aValue;
				this._rangeDefenseEV += aValue;
			}
			return true;
		}
		return false;
	}
	
	private bool canBoostXP(int aValue,bool aFullConsume) {
		if(this.level<100) {
			if(aFullConsume) {
				this.addXP((float) this.XpToNext()+1);
			}
			return true;
		}
		return false;
	}
	public bool canBoostSpeedEV(float aValue,bool aFullConsume) {
		if(this._speedEVInLevel<MAX_EV_PER_LEVEL) {
			if(aFullConsume) {
				this._speedEVInLevel += aValue;
				this._speedEV += aValue;
			}
			return true;
		}
		return false;
	}
	
	
}

