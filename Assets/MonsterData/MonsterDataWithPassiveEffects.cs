
using System;
using Battles;
using UnityEngine;
using utils;


public class MonsterDataWithPassiveEffects : MonsterDataWithStatusEffects
{
	public MonsterDataWithPassiveEffects ()
	{
		
	//	Debug.Log(_effects.ToString());
	}
	public void removePassiveEffects() {
		//_effects.Pop();
	}
	public override void FromString(string aString) {
		string decode1 = Base64Compressor.Base64Decode(aString);
		string[] split = decode1.Split(new char[] {'|'});
		
		base.FromString(split[0]);
		if(split.Length>1) {
			string decode = Base64Compressor.Base64Decode(split[1]);
			_effects.Add(PassiveEffectLibrary.REF.getPassiveEffect(decode));
		//	_effects.Add(PassiveEffectLibrary.REF.getPassiveEffect("Smokey"));
			
			}
	}
	
	public override string ToString ()
	{
		string s = passiveEffect.name;
		string r = base.ToString()+"|"+Base64Compressor.Base64Encode(s);
		return Base64Compressor.Base64Encode(r);
	}
	public PassiveEffect passiveEffect {
		get {
			if(_effects.size>0) {		
				return _effects[0];
			} else {
				_effects.Add(PassiveEffectLibrary.REF.getPassiveEffect(this.monsterBreedRef.passiveClass,this.elementType,this.secondaryType));
				 return passiveEffect;           
			}
		}
	}
	public PassiveEffect hasPassiveEffectForTime(EWhenToApply aTimeToApply,float aTargetHPVal,float aMyHP,ElementalType aAttackerType,ElementalType aDefendentType,BetterList<BattleMonster> aAllies,BetterList<BattleMonster> aOpponents,ERangedStatus aRange,BattleMonster aAttacker,ElementalType aAttackingMoveElement,EStatusEffects aStatusEffectInduced = EStatusEffects.None) {
		for(int i = 0;i<_effects.size;i++) {
			if(_effects[i].applyAt==aTimeToApply) {
				
				if((_effects[i].applyAt==EWhenToApply.AtEndOfMoveQueue)||
				   (_effects[i].applyAt==EWhenToApply.BattleStart)||
				   (_effects[i].applyAt==EWhenToApply.WhenHit)
				) {
					return _effects[i];
				}
				if((_effects[i].applyAt==EWhenToApply.WhenAttackingWithMoveType)&&(aAttackingMoveElement==_effects[i].whenMoveElementType)) {
					return _effects[i];
				}
				if((_effects[i].applyAt==EWhenToApply.WhenTheirHPHigherThan)&&(aTargetHPVal>_effects[i].HPPercentage)) {
					return _effects[i];
				}
				if((_effects[i].applyAt==EWhenToApply.WhenTheirHPLowerThan)&&(aTargetHPVal<_effects[i].HPPercentage)) {
					return _effects[i];
				}
				if((_effects[i].applyAt==EWhenToApply.WhenMyHPHigherThan)&&(aMyHP>(1/_effects[i].HPPercentage))) {
					return _effects[i];
				}
				if((_effects[i].applyAt==EWhenToApply.WhenMyHPLowerThan)&&(aMyHP<(1/_effects[i].HPPercentage))) {
					return _effects[i];
				}
				if((_effects[i].applyAt==EWhenToApply.WhenAttackerIsType)&&(aAttackerType==_effects[i].whenMoveElementType)) {
					return _effects[i];
				}
				if((_effects[i].applyAt==EWhenToApply.WhenDefendentIsType)&&(aDefendentType==_effects[i].whenMoveElementType)) {
					return _effects[i];
				}
				if((_effects[i].applyAt==EWhenToApply.WhenAlliesAreType)&&(listContainsElement(_effects[i].whenMoveElementType,aAllies).size>0)) {
					return _effects[i];
				}
				if((_effects[i].applyAt==EWhenToApply.WhenDefendentIsType)&&(listContainsElement(_effects[i].whenMoveElementType,aOpponents).size>0)) {
					return _effects[i];
				}
				if((_effects[i].applyAt==EWhenToApply.WhenOneOpponentisSameAsEffectOwner)&&(listContainsElement(aAttackerType,aOpponents).size>0)) {
					return _effects[i];
				}
				if((_effects[i].applyAt==EWhenToApply.WhenHitByMoveType)&&(aAttackerType==_effects[i].whenMoveElementType)) {
					return _effects[i];
				}
				if((_effects[i].applyAt==EWhenToApply.WhenHitByRangeType)&&(aRange==_effects[i].whenRangeType)) {
					return _effects[i];
				}
				if((_effects[i].applyAt==EWhenToApply.WhenOpponentHasStatusEffect)&&(listContainsStatusEffect(_effects[i].whenStatusEffects,aOpponents).size>0)) {
					return _effects[i];
				}
				if((_effects[i].applyAt==EWhenToApply.WhenStatusEffectsSuffered)&&((_effects[i].whenStatusEffects&aAttacker.statusEffects)!=EStatusEffects.None)) {
					return _effects[i];
				}
				
				if((_effects[i].applyAt==EWhenToApply.WhenHitByMoveTypeAtEndOfMoveQueue)&&(_effects[i].whenMoveElementType==aAttackingMoveElement)) {
					return _effects[i];
				}
			}
		}
		return null;
	}
	
	public BetterList<BattleMonster> listContainsStatusEffect(EStatusEffects aStatusEffect,BetterList<BattleMonster> aMonster) {
		BetterList<BattleMonster> r = new BetterList<BattleMonster>();
		for(int i = 0;i<aMonster.size;i++) {
			if((aMonster[i].statusEffects&aStatusEffect)!=0) {
				r.Add(aMonster[i]);
			}
		}
		return r;
	}
	public BetterList<BattleMonster> listContainsElement(ElementalType aElement,BetterList<BattleMonster> aMonster) {
		BetterList<BattleMonster> r = new BetterList<BattleMonster>();
		for(int i = 0;i<aMonster.size;i++) {
			if(aElement == aMonster[i].monster.elementType) {
				r.Add(aMonster[i]);
			}
		}
		return r;
	}
}

