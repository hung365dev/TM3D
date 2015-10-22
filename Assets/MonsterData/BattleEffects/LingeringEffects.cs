// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------
using UnityEngine;
using Battles;
using System;


public class LingeringEffects
{
	private EStatusEffects _currentStatusEffects = EStatusEffects.None;
	
	private int _turnsOfConfusion = 0;
	private int _turnsOfSleep = 0;
	
	private MoveLibItem _reasonForBurn;
	private MoveLibItem _reasonForConfusion;
	private MoveLibItem _reasonForFlinch;
	private MoveLibItem _reasonForParalyze;
	private MoveLibItem _reasonForSleep;
	private MoveLibItem _reasonForPoison;
	private MoveLibItem _reasonForFreeze;
	private BetterList<AdditionalWeaknesses> _extraWeaknesses = new BetterList<AdditionalWeaknesses>();
	public const int CHANCE_OF_CONFUSION_HURT = 50;
	public const int POWER_OF_CONFUSION_MOVE = 40;
	public const int CHANCE_TO_LOSE_FREEZE = 20;
	public const int MAX_TURNS_OF_SLEEP = 5;
	public const int MAX_TURNS_OF_CONFUSION = 5;
	
	public const int PARALYSIS_MOVE_CHANCE = 75;
	public delegate void OnStatusEffectAdded(EStatusEffects aEffect);
	public event OnStatusEffectAdded onStatusEffectAdded;
	
	public delegate void OnStatusEffectRemoved(EStatusEffects aEffect);
	public event OnStatusEffectRemoved onStatusEffectRemoved;
	
	public delegate void OnStatusEffectsHPWithMove(int aPowerOfMove);
	public event OnStatusEffectsHPWithMove onStatusEffectsHPWithMove;
	
	public delegate void OnStatusEffectsHPByPercentage(float aPercentageOfHP);
	public event OnStatusEffectsHPByPercentage onStatusEffectsHPByPercentage;
	
	public MoveLibItem lastReasonForNoMove;
	
	
	public LingeringEffects ()
	{
	}
	
	public EStatusEffects StatusEffects
	{
		set {
			if(this._currentStatusEffects!=value) {
				this._currentStatusEffects = value;
				
			}
		}
		get {
			return _currentStatusEffects;
		}
	}
	public BetterList<EStatusEffects> StatusEffectsAsList() {
		BetterList<EStatusEffects> r = new BetterList<EStatusEffects> ();
		if ((this._currentStatusEffects & EStatusEffects.Burn) == EStatusEffects.Burn) {
			r.Add(EStatusEffects.Burn);
		}
		if ((this._currentStatusEffects & EStatusEffects.Confusion) == EStatusEffects.Confusion) {
			r.Add(EStatusEffects.Confusion);
		}
		if ((this._currentStatusEffects & EStatusEffects.Flinch) == EStatusEffects.Flinch) {
			r.Add(EStatusEffects.Flinch);
		}
		if ((this._currentStatusEffects & EStatusEffects.Freeze) == EStatusEffects.Freeze) {
			r.Add(EStatusEffects.Freeze);
		}
		if ((this._currentStatusEffects & EStatusEffects.Paralyze) == EStatusEffects.Paralyze) {
			r.Add(EStatusEffects.Paralyze);
		}
		if ((this._currentStatusEffects & EStatusEffects.Poison) == EStatusEffects.Poison) {
			r.Add(EStatusEffects.Poison);
		}
		if ((this._currentStatusEffects & EStatusEffects.Sleep) == EStatusEffects.Sleep) {
			r.Add(EStatusEffects.Sleep);
		}
		return r;
	}
	
	
	public void removeAllEffects() {
		this._currentStatusEffects = EStatusEffects.None;
		_turnsOfSleep = 0;
		_turnsOfConfusion = 0;
	}
	
	public override string ToString() {
		int effects = (int) _currentStatusEffects;
		return effects.ToString();
	}
	public void FromString(string aString) {
		int effects = Convert.ToInt32(aString);
		_currentStatusEffects = (EStatusEffects) effects;
	}
	public float hasElementWeakness(ElementalType aElement) {
		for(byte c = 0;c<_extraWeaknesses.size;c++) {
			_extraWeaknesses[c].turnsRemaining--;
			if(_extraWeaknesses[c].turnsRemaining<0) {
				_extraWeaknesses.RemoveAt(c);
				c--;
			}
		}
		for(byte c = 0;c<_extraWeaknesses.size;c++) {
			if(_extraWeaknesses[c].type.ID==aElement.ID) {
				return 2f;
			}
		}
		return 0.0f;
	}
	
	private void setResponsibleMove(EStatusEffects aEffects,MoveLibItem aMove) {
		if((aEffects&EStatusEffects.Burn)==EStatusEffects.Burn) {
			_reasonForBurn = aMove;
		}
		if((aEffects&EStatusEffects.Confusion)==EStatusEffects.Confusion) {
			_reasonForConfusion = aMove;
		}
		if((aEffects&EStatusEffects.Flinch)==EStatusEffects.Flinch) {
			_reasonForFlinch = aMove;
		}
		if((aEffects&EStatusEffects.Freeze)==EStatusEffects.Freeze) {
			_reasonForFreeze = aMove;
		}
		if((aEffects&EStatusEffects.Paralyze)==EStatusEffects.Paralyze) {
			_reasonForParalyze = aMove;
		}
		if((aEffects&EStatusEffects.Poison)==EStatusEffects.Poison) {
			_reasonForPoison = aMove;
		}
		if((aEffects&EStatusEffects.Sleep)==EStatusEffects.Sleep) {
			_reasonForSleep = aMove;
		}
	}
	public void addEffect(EStatusEffects aEffect,MoveLibItem aMove) {
		if(!hasEffect(aEffect)) {
			_currentStatusEffects = _currentStatusEffects | aEffect;
			setResponsibleMove(aEffect,aMove);
			if((EStatusEffects.Confusion & aEffect) == EStatusEffects.Confusion) {
				_turnsOfConfusion = 1+(int) (BattleRandomizer.random*MAX_TURNS_OF_CONFUSION);//(1,MAX_TURNS_OF_CONFUSION);
			}
			if((EStatusEffects.Sleep & aEffect) == EStatusEffects.Sleep) {
				_turnsOfSleep = 1+(int) (BattleRandomizer.random*MAX_TURNS_OF_SLEEP);;
			}
			if(onStatusEffectAdded!=null) {
				onStatusEffectAdded(aEffect);
			}
		}
	}
	
	public void addEffect(ElementalType aElementType,byte aTurns) {
		if(aTurns==0) {
			aTurns = 255;
		}
		for(byte c = 0;c < this._extraWeaknesses.size;c++) {
			if(_extraWeaknesses[c].type.ID==aElementType.ID) {
				if(_extraWeaknesses[c].turnsRemaining<aTurns) {
					_extraWeaknesses[c].turnsRemaining = aTurns;
				
				}
				return;
			}
		}
		_extraWeaknesses.Add(new AdditionalWeaknesses(aElementType,aTurns));
	}
	public void removeEffect(EStatusEffects aEffect) {
		if(hasEffect(aEffect)) {
			_currentStatusEffects = _currentStatusEffects & ~aEffect;
			if((EStatusEffects.Confusion & aEffect) == EStatusEffects.Confusion) {
				_turnsOfConfusion = 0;
			}
			if(onStatusEffectRemoved!=null) {
				onStatusEffectRemoved(aEffect);
			}
		}
	}
	
	
	public void removePostBattleStatusEffects() {
		removeEffect(EStatusEffects.Confusion);
		removeEffect(EStatusEffects.Paralyze);
		removeEffect(EStatusEffects.Freeze);
		removeEffect(EStatusEffects.Sleep);
		removeEffect(EStatusEffects.Flinch);
	}
	
	public MoveLibItem responsibleForPoison {
		get {
			return this._reasonForPoison;
		}
	}
	public MoveLibItem responsibleForBurn {
		get {
			return this._reasonForBurn;
		}
	}
	public MoveLibItem reasonForConfusion {
		get {
			return this._reasonForConfusion;
		}
	}
	public MoveLibItem reasonForFlinch {
		get {
			return this._reasonForFlinch;
		}
	}
	public MoveLibItem reasonForFreeze {
		get {
			return this._reasonForFreeze;
		}
	}
	public MoveLibItem reasonForParalyzed {
		get {
			return this._reasonForParalyze;
		}
	}
	public MoveLibItem reasonForSleep {
		get {
			return this._reasonForSleep;
		}
	}
	private void removeResponsibleMove(EStatusEffects aEffects) {
		if((aEffects&EStatusEffects.Burn)==EStatusEffects.Burn) {
			_reasonForBurn = null;
		}
		if((aEffects&EStatusEffects.Confusion)==EStatusEffects.Confusion) {
			_reasonForConfusion = null;
		}
		if((aEffects&EStatusEffects.Flinch)==EStatusEffects.Flinch) {
			_reasonForFlinch = null;
		}
		if((aEffects&EStatusEffects.Freeze)==EStatusEffects.Freeze) {
			_reasonForFreeze = null;
		}
		if((aEffects&EStatusEffects.Paralyze)==EStatusEffects.Paralyze) {
			_reasonForParalyze = null;
		}
		if((aEffects&EStatusEffects.Poison)==EStatusEffects.Poison) {
			_reasonForPoison = null;
		}
		if((aEffects&EStatusEffects.Sleep)==EStatusEffects.Sleep) {
			_reasonForSleep = null;
		}
	}
	
	public bool hasEffect(EStatusEffects aEffect) {
		if((aEffect & _currentStatusEffects) == aEffect) {
			return true;
		}
		return false;
	}
	public EStatusEffects lingeringAllowsMove() {
		// Snap out of flinch if we're flinching.
		if((_currentStatusEffects&EStatusEffects.Flinch)==EStatusEffects.Flinch) {
			removeEffect (EStatusEffects.Flinch);
			return EStatusEffects.Flinch;
		}
		int r = (int) Convert.ToInt32(BattleRandomizer.random*100);
		if(hasEffect(EStatusEffects.Confusion)) {
			this._turnsOfConfusion--;
			if(_turnsOfConfusion<=0) {
				this.removeEffect(EStatusEffects.Confusion);
			} else 
			if(r<CHANCE_OF_CONFUSION_HURT) {
				if(this.onStatusEffectsHPWithMove!=null) {
					this.onStatusEffectsHPWithMove(POWER_OF_CONFUSION_MOVE);
				}
				lastReasonForNoMove = this._reasonForConfusion;
				return EStatusEffects.Confusion;
			}
		}
		if(hasEffect(EStatusEffects.Freeze)) {
			if(r<CHANCE_TO_LOSE_FREEZE) {
				this.removeEffect(EStatusEffects.Freeze);
			} else {
				lastReasonForNoMove = this._reasonForFreeze;
				return EStatusEffects.Freeze;
			}
		}
		r = (int) BattleRandomizer.random*100;
		if(hasEffect(EStatusEffects.Paralyze)) {
			if(r<PARALYSIS_MOVE_CHANCE) {
				
			} else {
				lastReasonForNoMove = this._reasonForParalyze;
				return EStatusEffects.Paralyze;
			}
		}
		r = (int) BattleRandomizer.random*100;
		if(hasEffect(EStatusEffects.Sleep)) {
			this._turnsOfSleep--;
			if(this._turnsOfSleep<=0) {
				this.removeEffect(EStatusEffects.Sleep);
			} else {
				lastReasonForNoMove = _reasonForSleep;
				return EStatusEffects.Sleep;
			}
		}
		return EStatusEffects.None;
		
	}
}

