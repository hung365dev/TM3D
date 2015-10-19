using UnityEngine;
using System.Collections;
using GoogleFu;
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
		 
	
		this._id = aInitData._id;
		this._name = aInitData._movename;
		this._moveSpeedMultiplier = aInitData._movespeedmultiplier;

		switch (aInitData._powerapplicationtype) {
			case("Normal"):this._powerApplicationType = EPowerApplicationTypes.Normal;break;
			case("Power is HP"): this._powerApplicationType = EPowerApplicationTypes.PowerIsHP;break;
			case("Power is Percentage of HP"): this._powerApplicationType = EPowerApplicationTypes.PowerIsPercentOfHP;break;
		}
		this._description = aInitData._description;
		oneHitKillInvulnerable = aInitData._addsonehitkoinvulnerability;
		decisiveBlowsImmunity = aInitData._decisiveblowsimmunity;
		
		this._elementalType = ElementalLibrary.REF.getElement (aInitData._elementaltype);
		switch (aInitData._meleerangedstatus) {
			case("Melee"):this._meleeRangedStatus = ERangedStatus.Melee;break;
			case("Ranged"):this._meleeRangedStatus = ERangedStatus.Ranged;break;
		}

		this._effort = aInitData._effort;
		this._power = aInitData._power;
		this._splashpercent = aInitData._splashpercent;
		cameraShake = aInitData._camerashake;
		switch (aInitData._splashrange) {
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
		this._accuracy = aInitData._accuracy;
		this._animation = MovesAnimationLib.REF.getAnimation(aInitData._attackanimation);
		_hitAnimation = MovesAnimationLib.REF.getAnimation(aInitData._attackanimationhit);
		this._paralyzePercent = aInitData._paralyzepercent;
		this._sleepPercent = aInitData._sleeppercent;
		this._poisonPercent = aInitData._poisonpercent;
		this._freezePercent = aInitData._freezepercent;
		this._flinchPercent = aInitData._flinchpercent;
		this._confusionPercent = aInitData._confusionpercent;
		this._burnPercent = aInitData._burnpercent;
		this._rangeAttackMultiplier = aInitData._rangeattackmultiplier;
		this._meleeAttackMultiplier = aInitData._meleeattackmultiplier;
		this._rangeDefenseMultiplier = aInitData._rangedefensemultiplier;
		this._meleeDefenseMultiplier = aInitData._meleedefensemultiplier;
		this._speedStatMultiplier = aInitData._speedstatmultiplier;
		this.agilityMultiplier = aInitData._agilitymultiplier;
		this._accuracyMultiplier = aInitData._accuracymultiplier;
		this._minHitsPerTurn = aInitData._minhitsperturn;
		this._maxHitsPerTurn = aInitData._maxhitsperturn;
		this._minTurns = aInitData._minturns;
		this._maxTurns = aInitData._maxturns;
		this._effectsDuration = aInitData._effectsduration;
		this._criticalHitChance = aInitData._criticalhitchance;
		this.powerOnlyIfTheseStatusEffects = (EStatusEffects) aInitData._onlyapplypoweriftheirstatuseffect;
		switch (aInitData._damagedistribution) {
			case("Standard"):default:this._damageDistribution = EDamageDistributionTypes.Standard;break;		
		}
		this._addsVulnerability = ElementalLibrary.REF.getElement (aInitData._addvulnerabilitytype);
		this._changeIfIHaveStatusEffects = aInitData._ifmystatuseffect;
		this._changeToThisIfIHaveStatusEffects = aInitData._doalternativemove;
		this._changeIfTheyHaveStatusEffects = aInitData._iftheirstatuseffect;
		this._changeToThisIfIHaveStatusEffects = aInitData._doalternativemove2;
		this._maxUnlockLevel = (byte) aInitData._maxunlocklevel;
		this._chanceOfAddVulnerability = aInitData._percentchangeofvulnerability;
		this._addsInvulnerabilityStatTo = (EMonsterStat) aInitData._addinvulnerabilitytostatchange;
		this._addsInvulnerabilityToStatus = (EStatusEffects) aInitData._addinvulnerabilitytostatus;
		this.isPassiveEffect = aInitData._ispassiveeffect;
		this.decisiveBlowsChangeMultiplier = aInitData._decisiveblowschancemultiplier;
		_selfHitPercent = aInitData._hitmyselfwiththispercentageofmove;
		removesWeaknessesTo = aInitData._removesweaknessto;
		
		mirrorStatusEffects = aInitData._mirrorstatuseffects;
		this.alsoApplyThisString = aInitData._alsoapplythismove;
		this.percentChanceOfFollowOn = aInitData._percentchanceoffollowon;
		
		if(aInitData._struggle==1) {
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
