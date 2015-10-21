using UnityEngine;
using System.Collections;
using Google2u;
using Battles;
using System;

[System.Serializable]
public class MoveLibItem {

	private int _id;
	public string _name;
	private float _moveSpeedMultiplier;
	private EPowerApplicationTypes _powerApplicationType;
	private string _description;
	private ElementalType _elementalType;
	private ERangedStatus _meleeRangedStatus;
	private float _effort;
	private int _power;
	private float _splashpercent;
	private ESplashRange _splashRange;
	private float _accuracy;
	private MoveAnimationLibItem _animation;
	private MoveAnimationLibItem _hitAnimation;
	private float _paralyzePercent;
	private float _sleepPercent;
	private float _poisonPercent;
	private float _freezePercent;
	private float _flinchPercent;
	private float _confusionPercent;
	private float _burnPercent;
	private float _speedMutliplier;
	
	
	private float _rangeAttackMultiplier;
	private float _meleeAttackMultiplier;
	private float _rangeDefenseMultiplier;
	private float _meleeDefenseMultiplier;
	private float _speedStatMultiplier;
	private float _accuracyMultiplier;
	private int _minHitsPerTurn;
	
	private int _maxHitsPerTurn;
	private int _minTurns;
	private int _maxTurns;


	public string cameraShake;
	private int _effectsDuration;
	private float _criticalHitChance;

	private EDamageDistributionTypes _damageDistribution;
	private ElementalType _addsVulnerability;


	private byte _maxUnlockLevel;
	
	private int _changeIfIHaveStatusEffects;
	private string _changeToThisIfIHaveStatusEffects;
	
	
	private EMonsterStat _addsInvulnerabilityStatTo;
	private int _changeIfTheyHaveStatusEffects;
	private string _changeToThisIfTheyHaveStatusEffects;
	private float _chanceOfAddVulnerability;
	private float _selfHitPercent;
	
	public EStatusEffects powerOnlyIfTheseStatusEffects;
	
	public float oneHitKillInvulnerable = 0f;
	public float decisiveBlowsImmunity = 0f;
	public EStatusEffects _addsInvulnerabilityToStatus;
	
	public float agilityMultiplier =1f;
	
	public float decisiveBlowsChangeMultiplier = 1f;
	public int removesWeaknessesTo = 0;
	public MoveLibItem alsoApplyThis;
	public string alsoApplyThisString;
	public float percentChanceOfFollowOn;
	
	public bool isPassiveEffect;
	public bool mirrorStatusEffects = false;
	
	public bool isStruggleMove = false;
	public MoveLibItem(MoveDataRow aInitData) {
		 
	
		this._id = aInitData._ID;
		this._name = aInitData._MoveName;
		this._moveSpeedMultiplier = aInitData._MoveSpeedMultiplier;

		switch (aInitData._PowerApplicationType) {
			case("Normal"):this._powerApplicationType = EPowerApplicationTypes.Normal;break;
			case("Power is HP"): this._powerApplicationType = EPowerApplicationTypes.PowerIsHP;break;
			case("Power is Percentage of HP"): this._powerApplicationType = EPowerApplicationTypes.PowerIsPercentOfHP;break;
		}
		this._description = aInitData._Description;
		oneHitKillInvulnerable = aInitData._AddsOneHitKOInvulnerability;
		decisiveBlowsImmunity = aInitData._DecisiveBlowsImmunity;
		
		this._elementalType = ElementalLibrary.REF.getElement (aInitData._ElementalType);
		switch (aInitData._MeleeRangedStatus) {
			case("Melee"):this._meleeRangedStatus = ERangedStatus.Melee;break;
			case("Ranged"):this._meleeRangedStatus = ERangedStatus.Ranged;break;
		}

		this._effort = aInitData._Effort;
		this._power = aInitData._Power;
		this._splashpercent = aInitData._SplashPercent;
		cameraShake = aInitData._CameraShake;
		switch (aInitData._SplashRange) {
			case("Hit 1 Only"):this._splashRange = ESplashRange.Hit1Only;break;
			case("Hit All"):this._splashRange = ESplashRange.HitAll;break;		
			case("Splash Range 1"):this._splashRange = ESplashRange.SplashRange1;break;
			case("Boost Me"):this._splashRange = ESplashRange.BoostMe;break;	
			case("Boost 1"):this._splashRange = ESplashRange.Boost1;break;	
			case("Boost 1 And Me"):this._splashRange = ESplashRange.Boost1AndMe;break;
			case("Boost All"):this._splashRange = ESplashRange.BoostAll;break;
			case("Boost 2"):this._splashRange = ESplashRange.Boost2;break;
			case("Boost whole Field"):this._splashRange = ESplashRange.BoostWholeField;break;
			case("Random Opponent"):this._splashRange = ESplashRange.RandomOpponent;break;
		}
		this._accuracy = aInitData._Accuracy;
		this._animation = MovesAnimationLib.REF.getAnimation(aInitData._AttackAnimation);
		_hitAnimation = MovesAnimationLib.REF.getAnimation(aInitData._AttackAnimationHit);
		this._paralyzePercent = aInitData._ParalyzePercent;
		this._sleepPercent = aInitData._SleepPercent;
		this._poisonPercent = aInitData._PoisonPercent;
		this._freezePercent = aInitData._FreezePercent;
		this._flinchPercent = aInitData._FlinchPercent;
		this._confusionPercent = aInitData._ConfusionPercent;
		this._burnPercent = aInitData._BurnPercent;
		this._rangeAttackMultiplier = aInitData._RangeAttackMultiplier;
		this._meleeAttackMultiplier = aInitData._MeleeAttackMultiplier;
		this._rangeDefenseMultiplier = aInitData._RangeDefenseMultiplier;
		this._meleeDefenseMultiplier = aInitData._MeleeDefenseMultiplier;
		this._speedStatMultiplier = aInitData._SpeedStatMultiplier;
		this.agilityMultiplier = aInitData._AgilityMultiplier;
		this._accuracyMultiplier = aInitData._AccuracyMultiplier;
		this._minHitsPerTurn = aInitData._MinHitsPerTurn;
		this._maxHitsPerTurn = aInitData._MaxHitsPerTurn;
		this._minTurns = aInitData._MinTurns;
		this._maxTurns = aInitData._MaxTurns;
		this._effectsDuration = aInitData._EffectsDuration;
		this._criticalHitChance = aInitData._CriticalHitChance;
		this.powerOnlyIfTheseStatusEffects = (EStatusEffects) aInitData._OnlyApplyPowerIfTheirStatusEffect;
		switch (aInitData._DamageDistribution) {
			case("Standard"):default:this._damageDistribution = EDamageDistributionTypes.Standard;break;		
		}
		this._addsVulnerability = ElementalLibrary.REF.getElement (aInitData._AddVulnerabilityType);
		this._changeIfIHaveStatusEffects = aInitData._IfMyStatusEffect;
		this._changeToThisIfIHaveStatusEffects = aInitData._DoAlternativeMove;
		this._changeIfTheyHaveStatusEffects = aInitData._IfTheirStatusEffect;
		this._changeToThisIfIHaveStatusEffects = aInitData._DoAlternativeMove;
		this._maxUnlockLevel = (byte) aInitData._MaxUnlockLevel;
		this._chanceOfAddVulnerability = aInitData._PercentChangeOfVulnerability;
		this._addsInvulnerabilityStatTo = (EMonsterStat) aInitData._AddInvulnerabilityToStatChange;
		this._addsInvulnerabilityToStatus = (EStatusEffects) aInitData._AddInvulnerabilityToStatus;
		this.isPassiveEffect = aInitData._IsPassiveEffect;
		this.decisiveBlowsChangeMultiplier = aInitData._DecisiveBlowsChanceMultiplier;
		_selfHitPercent = aInitData._HitMyselfWithThisPercentageOfMove;
		removesWeaknessesTo = aInitData._RemovesWeaknessTo;
		
		mirrorStatusEffects = aInitData._MirrorStatusEffects;
		this.alsoApplyThisString = aInitData._AlsoApplyThisMove;
		this.percentChanceOfFollowOn = aInitData._PercentChanceOfFollowOn;
		
		if(aInitData._Struggle==1) {
			isStruggleMove = true;
		}
//		this.removesWeaknessesTo = aInitData._
	//	this.agilityMultiplier = aInitData.A
	}
	public byte effectsDuration {
		get {
			return Convert.ToByte(this._effectsDuration); 
		}
	}     
	public float accuracy {
		get {
			return _accuracy;
		}
	}
	
	public string moveOrPassiveEffectString {
		get {
			if(isPassiveEffect) {
				return "Passive Effect";
			} else {
				return "Move";
			}
		}
	}
	public float getPower(byte aUnlockLevel) {
		float powerLevel = this.power;
		switch(aUnlockLevel) {
			case(1):default: return this.power;break;
			case(2): return this.power*1.035f;break;
			case(3): return this.power*1.05f;break;
			case(4): return this.power*1.1f;break;
			case(5): return this.power*1.2f;break;
		}
		return powerLevel;
	}
	
	public float getEnergy(byte aUnlockLevel) {
		float energyLevel = this.energy;
		for(byte i = 0;i<aUnlockLevel;i++) {
			energyLevel *= 0.95f;
		}
		return energyLevel;
	}
	public int energy {
		get {
			return (int) this._effort;
		}
		set {
			_effort = value;
		}
	}
	public byte minHitsPerTurn {
		get {
			return (byte) this._minHitsPerTurn;
		}
		
	}
	
	public byte maxHitsPerTurn {
		get {
			return (byte) this._maxHitsPerTurn;
		}
	}
	public EStatusEffects addsInvulnerabilityToStatus {
		get {
			return this._addsInvulnerabilityToStatus;
		}
	}
	public float criticalHitChance {
		get {
			return this._criticalHitChance;
		}
	}
	public string moveDescription {
		get {
			return this._description;
		}
	}
	
	public EMonsterStat addsInvulnerabilityStatTo {
		get {
			return _addsInvulnerabilityStatTo;
		}
	}
	public float selfInflictPercent {
		get {
			return this._selfHitPercent;
		}
		
	}
	public EPowerApplicationTypes powerApplicationType {
		get {
			return _powerApplicationType;
		}
	}
	public bool isBoost {
		get {
			return this._splashRange==ESplashRange.Boost1||this._splashRange==ESplashRange.Boost1AndMe||this._splashRange==ESplashRange.Boost2||this._splashRange==ESplashRange.BoostAll||this._splashRange==ESplashRange.BoostMe||this._splashRange==ESplashRange.BoostWholeField;
		}
	}
	public GameObject attackAnimationHitPrefab {
		get {
			if(this._hitAnimation!=null)
			return this._hitAnimation.prefab; else {
				return null;
			}
		}
	}
	
	public MoveAnimationLibItem attackHitAnimation {
		get {
			return this._hitAnimation;
		}
	}
	
	public GameObject attackAnimationPrefab {
		get {
			return this._animation.prefab;
		}
	}
	
	public MoveAnimationLibItem attackAnimation {
		get {
			return this._animation;
		}
	}
	public int id {
		get {
			return _id;
		}
	}
	
	public ElementalType addsWeaknessTo {
		get {
			return this._addsVulnerability;
		}
	}
	public float chanceOfAddVulnerability {
		get {
			return this._chanceOfAddVulnerability;
		}
	}
	public int changeIfAttackerHasStatusEffects {
		get {
			return this._changeIfIHaveStatusEffects;
		}
	}
	
	public int changeIfDefenderHasStatusEffects {
		get {
			return this._changeIfTheyHaveStatusEffects;;
		}
	}
	
	public MoveLibItem changeToThisIfAttackerHasStatusEffects {
		get {
			return MovesLib.REF.getMove(this._changeToThisIfIHaveStatusEffects);
		}
	}
	public MoveLibItem changeToThisIfDefenderHasStatusEffects {
		get {
			return MovesLib.REF.getMove(this._changeToThisIfTheyHaveStatusEffects);
		}
	}
	public ElementalType elementType {
		get {
			return this._elementalType;
		}
	}
	
	/*
	
	private float _paralyzePercent;
	private float _sleepPercent;
	private float _poisonPercent;
	private float _freezePercent;
	private float _flinchPercent;
	private float _confusionPercent;
	private float _burnPercent;
	*/
	public float paralyzePercent {
		get {
			return _paralyzePercent;
		}
	}
	
	
	public BetterList<string> effects {
		get {
			BetterList<string> toReturn = new BetterList<string>();
			if(sleepPercent>0f) {
				toReturn.Add("Sleep");
			}
			if(poisonPercent>0f) {
				toReturn.Add("Poison");
			}
			if(freezePercent>0f) {
				toReturn.Add("Freeze");
			}
			if(flinchPercent>0f) {
				toReturn.Add ("Flinch");
			}
			if(confusionPercent>0f) {
				toReturn.Add ("Confusion");
			}
			if(burnPercent>0f) {
				toReturn.Add ("Burn");
			}
			return toReturn;
		}
	}
	public string effectsString {
		get {
			string r = "";
			BetterList<string> str = effects;
			for(int i = 0;i<str.size;i++) {
				r = str[i];
				if(i<str.size-1) {
					r += ", ";
				}
			}
			return r;
		}
	}
	public float sleepPercent {
		get {
			return _sleepPercent;
		}
	}
	public float poisonPercent {
		get {
			return _poisonPercent;
		}
	}
	public float freezePercent {
		get {
			return _freezePercent;
		}
	}
	
	public float flinchPercent {
		get {
			return _flinchPercent;
		}
	}
	
	public float confusionPercent {
		get {
			return _confusionPercent;
		}
	}
	
	public float burnPercent {
		get {
			return _burnPercent;
		}
	}
	
	public float accuracyMultiplier {
		get {
			return _accuracyMultiplier;
		}
	}
	public float rangeAttackMultiplier {
		get {
			return _rangeAttackMultiplier;
		}
	}
	public float meleeAttackMultiplier {
		get {
			return _meleeAttackMultiplier;
		}
	}
	public float rangeDefenseMultiplier {
		get {
			return _rangeDefenseMultiplier;
		}
	}
	public float meleeDefenseMultiplier {
		get {
			return _meleeDefenseMultiplier;
		}
	}
	public float speedChangeMultiplier {
		get {
			return this._speedStatMultiplier;
		}
	}
	
	public BetterList<string> drains {
		get {
			BetterList<string> toReturn = new BetterList<string>();
			if(accuracyMultiplier<1f) {
				toReturn.Add("Accuracy");
			}
			if(rangeAttackMultiplier<1f) {
				toReturn.Add("Range Attack");
			}
			if(meleeAttackMultiplier<1f) {
				toReturn.Add("Melee Attack");
			}
			if(rangeDefenseMultiplier<1f) {
				toReturn.Add ("Range Defense");
			}
			if(meleeDefenseMultiplier<1f) {
				toReturn.Add ("Melee Defense");
			}
			if(speedChangeMultiplier<1f) {
				toReturn.Add ("Speed");
			}
			return toReturn;
		}
	}
	public string drainsString {
		get {
			string r = "";
			BetterList<string> str = drains;
			for(int i = 0;i<str.size;i++) {
				r = str[i];
				if(i<str.size-1) {
					r += ", ";
				}
			}
			if(drains.size == 0) {
				r = "None";
			}
			return r;
		}
	}
	
	public BetterList<string> boosts {
		get {
			BetterList<string> toReturn = new BetterList<string>();
			if(accuracyMultiplier>1f) {
				toReturn.Add("Accuracy");
			}
			if(rangeAttackMultiplier>1f) {
				toReturn.Add("Range Attack");
			}
			if(meleeAttackMultiplier>1f) {
				toReturn.Add("Melee Attack");
			}
			if(rangeDefenseMultiplier>1f) {
				toReturn.Add ("Range Defense");
			}
			if(meleeDefenseMultiplier>1f) {
				toReturn.Add ("Melee Defense");
			}
			if(speedChangeMultiplier>1f) {
				toReturn.Add ("Speed");
			}
			return toReturn;
		}
	}
	public string boostsString {
		get {
			string r = "";
			BetterList<string> str = boosts;
			for(int i = 0;i<str.size;i++) {
				r = str[i];
				if(i<str.size-1) {
					r += ", ";
				}
			}
			if(str.size==0) {
				r = "None";
			}
			return r;
		}
	}
	
	public float power {
		get {
			return this._power;
		}
		set {
			this._power = (int) value;
		}
	}
	
	public ERangedStatus rangeStatus {
		get {
			return this._meleeRangedStatus;
		}
	}
	public ESplashRange splashRange {
		get {
			return this._splashRange;
		}
	}
	
	public float splashPercent {
		get {
			return this._splashpercent;
		}
	}
	public float moveSpeedMultiplier {
		get {
			return this._moveSpeedMultiplier;
		}
	}
	public string plainName {
		get {
			return _name;		
		}
	}
	public string Name {
		get {
			if(_name!=null&&_name.StartsWith("Passive_")) {
				return _name.Substring(8);
			}
			return _name;		
		}
	}
}
