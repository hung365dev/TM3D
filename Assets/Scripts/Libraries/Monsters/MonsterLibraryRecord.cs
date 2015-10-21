using UnityEngine;
using System.Collections;
using Google2u;
using System;


public class MonsterLibraryRecord {

	/*
	 * 		public int _ID;
		public string _NAME;
		public string _DESCRIPTION;
		public string _EVOLVESTO;
		public string _PRIMARYELEMENT;
		public string _SECONDARYELEMENT;
		public int _EVOLVESAT;
		public int _HP;
		public float _HPPERLEVEL;
		public int _MELEEATTACK;
		public int _MELEEDEFENSE;
		public int _RANGEATTACK;
		public int _RANGEDEFENSE;
		public int _SPEED;
		public int _RESISTANCE;
		public float _ACCURACY;
		public float _AGILITY;
		public float _MELEEATTACKPERLEVEL;
		public float _MELEEDEFENSEPERLEVEL;
		public float _RANGEATTACKPERLEVEL;
		public float _RANGEDEFENSEPERLEVEL;
		public float _SPEEDPERLEVEL;
		*/
	private int _id;
	private string _name;
	private string _description;
	private MonsterLibraryRecord _evolvesTo;
	private string _evolvesToID;
	private ElementalType _primaryElement;
	private ElementalType _secondaryElement;
	private byte _evolvesAt;
	private float _hp;
	private int _expVal;
	private float _hpPerLevel;
	private float _meleeAttack;
	private float _meleeDefense;
	private float _rangeAttack;
	private float _rangeDefense;
	private float _energy;
	private float _energyPerLevel;
	private float _speed;
	private float _resistance;
	private float _accuracy;
	private float _agility;
	private float _meleeAttackPerLevel;
	private float _meleeDefensePerLevel;
	private float _rangeAttackPerLevel;
	private float _rangeDefensePerLevel;
	private float _accuracyPerLevel;
	private float _speedPerLevel;
	private float _support;
	private float _supportPerLevel;
	private float _agilityPerLevel;
	private MoveTree _moveTree1;
	private MoveTree _moveTree2;
	private MoveTree _moveTree3;
	private MoveTree _moveTree4;
	private XPDevModel _xpDevModel;
	private int _catchRate;
	
	public string companionAString;
	public string companionBString;
	public int companionALevelDiff;
	public int companionBLevelDiff;
	
	public int passiveClass;
	public MonsterLibraryRecord(TMMonstersRow aInitData) {
		_id = aInitData._ID;
		_name = aInitData._Name;
		_description = aInitData._Description;
		_evolvesToID = aInitData._EvolvesTo;
		_primaryElement = ElementalLibrary.REF.getElement (aInitData._PrimaryElement);
		_secondaryElement = ElementalLibrary.REF.getElement (aInitData._SecondaryElement);
		_evolvesAt = Convert.ToByte( aInitData._EvolvesAt);
		_hp = aInitData._HP;
		_hpPerLevel = aInitData._HPPerLevel;
		_meleeAttack = aInitData._MeleeAttack;
		_meleeDefense = aInitData._MeleeDefense;
		_rangeAttack = aInitData._RangeAttack;
		_rangeDefense = aInitData._RangeDefense;
		_speed = aInitData._Speed;
	//	_resistance = aInitData._resistance;
		_accuracy = aInitData._Accuracy;
		_agility = aInitData._Agility;
		_meleeAttackPerLevel = aInitData._MeleeAttackPerLevel;
		_meleeDefensePerLevel = aInitData._MeleeDefensePerLevel;
		_rangeAttackPerLevel = aInitData._RangeAttackPerLevel;
		_rangeDefensePerLevel = aInitData._RangeDefensePerLevel;
		_energy = aInitData._Energy;
		_energyPerLevel = aInitData._EnergyPerLevel;
		this._accuracyPerLevel = aInitData._AccuracyPerLevel;
		_speedPerLevel = aInitData._SpeedPerLevel;
		_catchRate = aInitData._CatchRate;
		_moveTree1 = MoveTreeLibrary.REF.GetMoveTree (aInitData._MoveTree1);
		_moveTree2 = MoveTreeLibrary.REF.GetMoveTree (aInitData._MoveTree2);
		_moveTree3 = MoveTreeLibrary.REF.GetMoveTree (aInitData._MoveTree3);
		_moveTree4 = MoveTreeLibrary.REF.GetMoveTree (aInitData._MoveTree4);
		passiveClass = aInitData._PassiveEffectClasses;
		_expVal = aInitData._BaseExperienceYield;
		_xpDevModel = XPDevModelLib.REF.getXPDevModel (aInitData._XPDevModel);
		
		this.companionAString = aInitData._CompanionA;
		this.companionBString = aInitData._CompanionB;
		this.companionALevelDiff = aInitData._CompanionALevelDiff;
		this.companionBLevelDiff = aInitData._CompanionBLevelDiff;
	}
	public int companionA {
		get {
			if(companionAString!=null&&companionAString.Length>0) {
				return MonsterLibrary.REF.getMonster (companionAString).ID;
			}
			return 0;
		}
	}
	public int companionB {
		get {
			if(companionBString!=null&&companionBString.Length>0) {
				return MonsterLibrary.REF.getMonster (companionBString).ID;
			}
			return 0;
		}
	}
	public float meleeAttackPerLevel {
		get {
			return _meleeAttackPerLevel;
		}
	}
	public float meleeDefensePerLevel {
		get {
			return _meleeDefensePerLevel;
		}
	}
	public float rangeAttackPerLevel {
		get {
			return this._rangeAttackPerLevel;;
		}
	}
	public float rangeDefensePerLevel {
		get {
			return this._rangeDefensePerLevel;
		}
	}
	public float speedPerLevel {
		get {
			return this._speedPerLevel;
		}
	}
	public float accuracyPerLevel {
		get {
			return this._accuracyPerLevel;
		}
	}
	public float agilityPerLevel {
		get {
			return this._agilityPerLevel;
		}
	}
	public int baseExperience {
		get {
			return _expVal;
		}
	}
	public int catchRate {
		get {
			return this._catchRate;
		}
	}
	public string description {
		get {
			return this._description;
		}
	}
	public int ID {
		get {
				
			return this._id;
		}
	}
	public MoveTree moveTreeA {
		get {		
			return _moveTree1;
		}
	}
	public MoveTree moveTreeB {
		get {
			return _moveTree2;
		}
	}
	
	public MoveTree moveTreeC {
		get {
			return _moveTree3;
		}
	}
	public MoveTree moveTreeD {
		get {
			return _moveTree4;
		}
	}
	public string Name {
		get {
			return _name;		
		}
	}

	public ElementalType PrimaryElement {
		get {
			return this._primaryElement;
		}
	}
	
	
	public ElementalType SecondaryElement {
		get {
			return this._secondaryElement;
		}
	}
	
	public int EnergyAtLevel(byte aLevel) {
		return (int) (this._energy + (int) (this._energyPerLevel * aLevel));
	}
	public int HpAtLevel(byte aLevel) {
		return (int) (this._hp + (int) (this._hpPerLevel * aLevel));
	}
	public int MeleeAttackAtLevel(byte aLevel) {
		return (int) (this._meleeAttack + (int) (this._meleeAttackPerLevel * aLevel));
	}
	public int MeleeDefenseAtLevel(byte aLevel) {
		return (int) (this._meleeDefense + (int) (this._meleeDefensePerLevel * aLevel));
	}
	public int RangeAttackAtLevel(byte aLevel) {
		return (int) (this._rangeAttack + (int) (this._rangeAttackPerLevel * aLevel));
	}
	public int RangeDefenseAtLevel(byte aLevel) {
		return (int) (this._rangeDefense + (int) (this._rangeDefensePerLevel * aLevel));
	}
	public int SpeedAtLevel(byte aLevel) {
		return (int) (this._speed + (int) (this._speedPerLevel * aLevel));
	}
	
	public int SupportAtLevel(byte aLevel) {
		return (int) (this._support + (int) (this._supportPerLevel * aLevel));
	}
	public int AccuracyAtLevel(byte aLevel) {
		return (int) (this._accuracy + (int) (this._accuracyPerLevel * aLevel));
	}
	public int AgilityAtLevel(byte aLevel) {
		return (int) (this._agility + (int) (this._agilityPerLevel * aLevel));
	}
	public XPDevModel xpDevModel {
		get {
			return _xpDevModel;		
		}
	}
	public byte evolvesAt {
		get {
			return this._evolvesAt;
		}
	}
	public byte evolutionLevel {
		get {
			return MonsterLibrary.REF.getMonsterEvolutionLevel(this.ID);
		}
	}
	public byte maxEvolutionLevel {
		get {
			byte r = evolutionLevel;
			if(this._evolvesTo!=null&&this._evolvesAt>0&&this._evolvesTo.ID>1)
				r+=1;
				MonsterLibraryRecord mlr = this._evolvesTo;
				if(mlr._evolvesTo!=null&&mlr._evolvesAt>0&&mlr._evolvesTo.ID>1) {
					r+=1;
				}
			
			return r;
		}
	}
	
	public MonsterLibraryRecord evolvesTo {
		get {
			return _evolvesTo;
		}
	}
	public void initEvolvesTo() {
		if (_evolvesToID !=  "") {
			_evolvesTo = MonsterLibrary.REF.getMonster(_evolvesToID);		
		}
	}
}
