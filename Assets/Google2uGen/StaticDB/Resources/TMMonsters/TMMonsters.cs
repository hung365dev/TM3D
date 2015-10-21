//----------------------------------------------
//    Google2u: Google Doc Unity integration
//         Copyright © 2015 Litteratus
//
//        This file has been auto-generated
//              Do not manually edit
//----------------------------------------------

using UnityEngine;
using System.Globalization;

namespace Google2u
{
	[System.Serializable]
	public class TMMonstersRow : IGoogle2uRow
	{
		public int _ID;
		public string _Name;
		public string _Description;
		public string _EvolvesTo;
		public string _PrimaryElement;
		public string _SecondaryElement;
		public byte _EvolvesAt;
		public float _HP;
		public float _HPPerLevel;
		public float _HPAt50;
		public float _HPAt100;
		public float _Energy;
		public float _EnergyPerLevel;
		public float _EnergyAt50;
		public float _EnergyAt100;
		public float _MeleeAttack;
		public float _MeleeDefense;
		public float _RangeAttack;
		public float _RangeDefense;
		public float _Speed;
		public float _Resistance;
		public float _Accuracy;
		public float _Agility;
		public float _MeleeAttackPerLevel;
		public float _MeleeAttackAt50;
		public float _MeleeDefensePerLevel;
		public float _MeleeDefenseAt50;
		public float _RangeAttackPerLevel;
		public float _RangeAttackAt50;
		public float _RangeDefensePerLevel;
		public float _AccuracyPerLevel;
		public float _RangeDefenseAt50;
		public float _SpeedPerLevel;
		public float _SpeedAt50;
		public string _MoveTree1;
		public string _MoveTree2;
		public string _MoveTree3;
		public string _MoveTree4;
		public string _XPDevModel;
		public int _CatchRate;
		public int _PassiveEffectClasses;
		public int _CurrentlyWorking;
		public int _BaseExperienceYield;
		public int _IsStarterMonster;
		public string _CompanionA;
		public int _CompanionALevelDiff;
		public string _CompanionB;
		public int _CompanionBLevelDiff;
		public TMMonstersRow(string __ve, string __ID, string __Name, string __Description, string __EvolvesTo, string __PrimaryElement, string __SecondaryElement, string __EvolvesAt, string __HP, string __HPPerLevel, string __HPAt50, string __HPAt100, string __Energy, string __EnergyPerLevel, string __EnergyAt50, string __EnergyAt100, string __MeleeAttack, string __MeleeDefense, string __RangeAttack, string __RangeDefense, string __Speed, string __Resistance, string __Accuracy, string __Agility, string __MeleeAttackPerLevel, string __MeleeAttackAt50, string __MeleeDefensePerLevel, string __MeleeDefenseAt50, string __RangeAttackPerLevel, string __RangeAttackAt50, string __RangeDefensePerLevel, string __AccuracyPerLevel, string __RangeDefenseAt50, string __SpeedPerLevel, string __SpeedAt50, string __MoveTree1, string __MoveTree2, string __MoveTree3, string __MoveTree4, string __XPDevModel, string __CatchRate, string __PassiveEffectClasses, string __CurrentlyWorking, string __BaseExperienceYield, string __IsStarterMonster, string __CompanionA, string __CompanionALevelDiff, string __CompanionB, string __CompanionBLevelDiff) 
		{
			{
			int res;
				if(int.TryParse(__ID, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_ID = res;
				else
					Debug.LogError("Failed To Convert _ID string: "+ __ID +" to int");
			}
			_Name = __Name.Trim();
			_Description = __Description.Trim();
			_EvolvesTo = __EvolvesTo.Trim();
			_PrimaryElement = __PrimaryElement.Trim();
			_SecondaryElement = __SecondaryElement.Trim();
			{
			byte res;
				if(byte.TryParse(__EvolvesAt, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_EvolvesAt = res;
				else
					Debug.LogError("Failed To Convert _EvolvesAt string: "+ __EvolvesAt +" to byte");
			}
			{
			float res;
				if(float.TryParse(__HP, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_HP = res;
				else
					Debug.LogError("Failed To Convert _HP string: "+ __HP +" to float");
			}
			{
			float res;
				if(float.TryParse(__HPPerLevel, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_HPPerLevel = res;
				else
					Debug.LogError("Failed To Convert _HPPerLevel string: "+ __HPPerLevel +" to float");
			}
			{
			float res;
				if(float.TryParse(__HPAt50, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_HPAt50 = res;
				else
					Debug.LogError("Failed To Convert _HPAt50 string: "+ __HPAt50 +" to float");
			}
			{
			float res;
				if(float.TryParse(__HPAt100, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_HPAt100 = res;
				else
					Debug.LogError("Failed To Convert _HPAt100 string: "+ __HPAt100 +" to float");
			}
			{
			float res;
				if(float.TryParse(__Energy, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_Energy = res;
				else
					Debug.LogError("Failed To Convert _Energy string: "+ __Energy +" to float");
			}
			{
			float res;
				if(float.TryParse(__EnergyPerLevel, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_EnergyPerLevel = res;
				else
					Debug.LogError("Failed To Convert _EnergyPerLevel string: "+ __EnergyPerLevel +" to float");
			}
			{
			float res;
				if(float.TryParse(__EnergyAt50, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_EnergyAt50 = res;
				else
					Debug.LogError("Failed To Convert _EnergyAt50 string: "+ __EnergyAt50 +" to float");
			}
			{
			float res;
				if(float.TryParse(__EnergyAt100, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_EnergyAt100 = res;
				else
					Debug.LogError("Failed To Convert _EnergyAt100 string: "+ __EnergyAt100 +" to float");
			}
			{
			float res;
				if(float.TryParse(__MeleeAttack, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_MeleeAttack = res;
				else
					Debug.LogError("Failed To Convert _MeleeAttack string: "+ __MeleeAttack +" to float");
			}
			{
			float res;
				if(float.TryParse(__MeleeDefense, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_MeleeDefense = res;
				else
					Debug.LogError("Failed To Convert _MeleeDefense string: "+ __MeleeDefense +" to float");
			}
			{
			float res;
				if(float.TryParse(__RangeAttack, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_RangeAttack = res;
				else
					Debug.LogError("Failed To Convert _RangeAttack string: "+ __RangeAttack +" to float");
			}
			{
			float res;
				if(float.TryParse(__RangeDefense, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_RangeDefense = res;
				else
					Debug.LogError("Failed To Convert _RangeDefense string: "+ __RangeDefense +" to float");
			}
			{
			float res;
				if(float.TryParse(__Speed, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_Speed = res;
				else
					Debug.LogError("Failed To Convert _Speed string: "+ __Speed +" to float");
			}
			{
			float res;
				if(float.TryParse(__Resistance, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_Resistance = res;
				else
					Debug.LogError("Failed To Convert _Resistance string: "+ __Resistance +" to float");
			}
			{
			float res;
				if(float.TryParse(__Accuracy, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_Accuracy = res;
				else
					Debug.LogError("Failed To Convert _Accuracy string: "+ __Accuracy +" to float");
			}
			{
			float res;
				if(float.TryParse(__Agility, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_Agility = res;
				else
					Debug.LogError("Failed To Convert _Agility string: "+ __Agility +" to float");
			}
			{
			float res;
				if(float.TryParse(__MeleeAttackPerLevel, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_MeleeAttackPerLevel = res;
				else
					Debug.LogError("Failed To Convert _MeleeAttackPerLevel string: "+ __MeleeAttackPerLevel +" to float");
			}
			{
			float res;
				if(float.TryParse(__MeleeAttackAt50, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_MeleeAttackAt50 = res;
				else
					Debug.LogError("Failed To Convert _MeleeAttackAt50 string: "+ __MeleeAttackAt50 +" to float");
			}
			{
			float res;
				if(float.TryParse(__MeleeDefensePerLevel, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_MeleeDefensePerLevel = res;
				else
					Debug.LogError("Failed To Convert _MeleeDefensePerLevel string: "+ __MeleeDefensePerLevel +" to float");
			}
			{
			float res;
				if(float.TryParse(__MeleeDefenseAt50, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_MeleeDefenseAt50 = res;
				else
					Debug.LogError("Failed To Convert _MeleeDefenseAt50 string: "+ __MeleeDefenseAt50 +" to float");
			}
			{
			float res;
				if(float.TryParse(__RangeAttackPerLevel, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_RangeAttackPerLevel = res;
				else
					Debug.LogError("Failed To Convert _RangeAttackPerLevel string: "+ __RangeAttackPerLevel +" to float");
			}
			{
			float res;
				if(float.TryParse(__RangeAttackAt50, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_RangeAttackAt50 = res;
				else
					Debug.LogError("Failed To Convert _RangeAttackAt50 string: "+ __RangeAttackAt50 +" to float");
			}
			{
			float res;
				if(float.TryParse(__RangeDefensePerLevel, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_RangeDefensePerLevel = res;
				else
					Debug.LogError("Failed To Convert _RangeDefensePerLevel string: "+ __RangeDefensePerLevel +" to float");
			}
			{
			float res;
				if(float.TryParse(__AccuracyPerLevel, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_AccuracyPerLevel = res;
				else
					Debug.LogError("Failed To Convert _AccuracyPerLevel string: "+ __AccuracyPerLevel +" to float");
			}
			{
			float res;
				if(float.TryParse(__RangeDefenseAt50, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_RangeDefenseAt50 = res;
				else
					Debug.LogError("Failed To Convert _RangeDefenseAt50 string: "+ __RangeDefenseAt50 +" to float");
			}
			{
			float res;
				if(float.TryParse(__SpeedPerLevel, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_SpeedPerLevel = res;
				else
					Debug.LogError("Failed To Convert _SpeedPerLevel string: "+ __SpeedPerLevel +" to float");
			}
			{
			float res;
				if(float.TryParse(__SpeedAt50, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_SpeedAt50 = res;
				else
					Debug.LogError("Failed To Convert _SpeedAt50 string: "+ __SpeedAt50 +" to float");
			}
			_MoveTree1 = __MoveTree1.Trim();
			_MoveTree2 = __MoveTree2.Trim();
			_MoveTree3 = __MoveTree3.Trim();
			_MoveTree4 = __MoveTree4.Trim();
			_XPDevModel = __XPDevModel.Trim();
			{
			int res;
				if(int.TryParse(__CatchRate, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_CatchRate = res;
				else
					Debug.LogError("Failed To Convert _CatchRate string: "+ __CatchRate +" to int");
			}
			{
			int res;
				if(int.TryParse(__PassiveEffectClasses, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_PassiveEffectClasses = res;
				else
					Debug.LogError("Failed To Convert _PassiveEffectClasses string: "+ __PassiveEffectClasses +" to int");
			}
			{
			int res;
				if(int.TryParse(__CurrentlyWorking, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_CurrentlyWorking = res;
				else
					Debug.LogError("Failed To Convert _CurrentlyWorking string: "+ __CurrentlyWorking +" to int");
			}
			{
			int res;
				if(int.TryParse(__BaseExperienceYield, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_BaseExperienceYield = res;
				else
					Debug.LogError("Failed To Convert _BaseExperienceYield string: "+ __BaseExperienceYield +" to int");
			}
			{
			int res;
				if(int.TryParse(__IsStarterMonster, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_IsStarterMonster = res;
				else
					Debug.LogError("Failed To Convert _IsStarterMonster string: "+ __IsStarterMonster +" to int");
			}
			_CompanionA = __CompanionA.Trim();
			{
			int res;
				if(int.TryParse(__CompanionALevelDiff, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_CompanionALevelDiff = res;
				else
					Debug.LogError("Failed To Convert _CompanionALevelDiff string: "+ __CompanionALevelDiff +" to int");
			}
			_CompanionB = __CompanionB.Trim();
			{
			int res;
				if(int.TryParse(__CompanionBLevelDiff, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_CompanionBLevelDiff = res;
				else
					Debug.LogError("Failed To Convert _CompanionBLevelDiff string: "+ __CompanionBLevelDiff +" to int");
			}
		}

		public int Length { get { return 48; } }

		public string this[int i]
		{
		    get
		    {
		        return GetStringDataByIndex(i);
		    }
		}

		public string GetStringDataByIndex( int index )
		{
			string ret = System.String.Empty;
			switch( index )
			{
				case 0:
					ret = _ID.ToString();
					break;
				case 1:
					ret = _Name.ToString();
					break;
				case 2:
					ret = _Description.ToString();
					break;
				case 3:
					ret = _EvolvesTo.ToString();
					break;
				case 4:
					ret = _PrimaryElement.ToString();
					break;
				case 5:
					ret = _SecondaryElement.ToString();
					break;
				case 6:
					ret = _EvolvesAt.ToString();
					break;
				case 7:
					ret = _HP.ToString();
					break;
				case 8:
					ret = _HPPerLevel.ToString();
					break;
				case 9:
					ret = _HPAt50.ToString();
					break;
				case 10:
					ret = _HPAt100.ToString();
					break;
				case 11:
					ret = _Energy.ToString();
					break;
				case 12:
					ret = _EnergyPerLevel.ToString();
					break;
				case 13:
					ret = _EnergyAt50.ToString();
					break;
				case 14:
					ret = _EnergyAt100.ToString();
					break;
				case 15:
					ret = _MeleeAttack.ToString();
					break;
				case 16:
					ret = _MeleeDefense.ToString();
					break;
				case 17:
					ret = _RangeAttack.ToString();
					break;
				case 18:
					ret = _RangeDefense.ToString();
					break;
				case 19:
					ret = _Speed.ToString();
					break;
				case 20:
					ret = _Resistance.ToString();
					break;
				case 21:
					ret = _Accuracy.ToString();
					break;
				case 22:
					ret = _Agility.ToString();
					break;
				case 23:
					ret = _MeleeAttackPerLevel.ToString();
					break;
				case 24:
					ret = _MeleeAttackAt50.ToString();
					break;
				case 25:
					ret = _MeleeDefensePerLevel.ToString();
					break;
				case 26:
					ret = _MeleeDefenseAt50.ToString();
					break;
				case 27:
					ret = _RangeAttackPerLevel.ToString();
					break;
				case 28:
					ret = _RangeAttackAt50.ToString();
					break;
				case 29:
					ret = _RangeDefensePerLevel.ToString();
					break;
				case 30:
					ret = _AccuracyPerLevel.ToString();
					break;
				case 31:
					ret = _RangeDefenseAt50.ToString();
					break;
				case 32:
					ret = _SpeedPerLevel.ToString();
					break;
				case 33:
					ret = _SpeedAt50.ToString();
					break;
				case 34:
					ret = _MoveTree1.ToString();
					break;
				case 35:
					ret = _MoveTree2.ToString();
					break;
				case 36:
					ret = _MoveTree3.ToString();
					break;
				case 37:
					ret = _MoveTree4.ToString();
					break;
				case 38:
					ret = _XPDevModel.ToString();
					break;
				case 39:
					ret = _CatchRate.ToString();
					break;
				case 40:
					ret = _PassiveEffectClasses.ToString();
					break;
				case 41:
					ret = _CurrentlyWorking.ToString();
					break;
				case 42:
					ret = _BaseExperienceYield.ToString();
					break;
				case 43:
					ret = _IsStarterMonster.ToString();
					break;
				case 44:
					ret = _CompanionA.ToString();
					break;
				case 45:
					ret = _CompanionALevelDiff.ToString();
					break;
				case 46:
					ret = _CompanionB.ToString();
					break;
				case 47:
					ret = _CompanionBLevelDiff.ToString();
					break;
			}

			return ret;
		}

		public string GetStringData( string colID )
		{
			var ret = System.String.Empty;
			switch( colID )
			{
				case "ID":
					ret = _ID.ToString();
					break;
				case "Name":
					ret = _Name.ToString();
					break;
				case "Description":
					ret = _Description.ToString();
					break;
				case "EvolvesTo":
					ret = _EvolvesTo.ToString();
					break;
				case "PrimaryElement":
					ret = _PrimaryElement.ToString();
					break;
				case "SecondaryElement":
					ret = _SecondaryElement.ToString();
					break;
				case "EvolvesAt":
					ret = _EvolvesAt.ToString();
					break;
				case "HP":
					ret = _HP.ToString();
					break;
				case "HPPerLevel":
					ret = _HPPerLevel.ToString();
					break;
				case "HPAt50":
					ret = _HPAt50.ToString();
					break;
				case "HPAt100":
					ret = _HPAt100.ToString();
					break;
				case "Energy":
					ret = _Energy.ToString();
					break;
				case "EnergyPerLevel":
					ret = _EnergyPerLevel.ToString();
					break;
				case "EnergyAt50":
					ret = _EnergyAt50.ToString();
					break;
				case "EnergyAt100":
					ret = _EnergyAt100.ToString();
					break;
				case "MeleeAttack":
					ret = _MeleeAttack.ToString();
					break;
				case "MeleeDefense":
					ret = _MeleeDefense.ToString();
					break;
				case "RangeAttack":
					ret = _RangeAttack.ToString();
					break;
				case "RangeDefense":
					ret = _RangeDefense.ToString();
					break;
				case "Speed":
					ret = _Speed.ToString();
					break;
				case "Resistance":
					ret = _Resistance.ToString();
					break;
				case "Accuracy":
					ret = _Accuracy.ToString();
					break;
				case "Agility":
					ret = _Agility.ToString();
					break;
				case "MeleeAttackPerLevel":
					ret = _MeleeAttackPerLevel.ToString();
					break;
				case "MeleeAttackAt50":
					ret = _MeleeAttackAt50.ToString();
					break;
				case "MeleeDefensePerLevel":
					ret = _MeleeDefensePerLevel.ToString();
					break;
				case "MeleeDefenseAt50":
					ret = _MeleeDefenseAt50.ToString();
					break;
				case "RangeAttackPerLevel":
					ret = _RangeAttackPerLevel.ToString();
					break;
				case "RangeAttackAt50":
					ret = _RangeAttackAt50.ToString();
					break;
				case "RangeDefensePerLevel":
					ret = _RangeDefensePerLevel.ToString();
					break;
				case "AccuracyPerLevel":
					ret = _AccuracyPerLevel.ToString();
					break;
				case "RangeDefenseAt50":
					ret = _RangeDefenseAt50.ToString();
					break;
				case "SpeedPerLevel":
					ret = _SpeedPerLevel.ToString();
					break;
				case "SpeedAt50":
					ret = _SpeedAt50.ToString();
					break;
				case "MoveTree1":
					ret = _MoveTree1.ToString();
					break;
				case "MoveTree2":
					ret = _MoveTree2.ToString();
					break;
				case "MoveTree3":
					ret = _MoveTree3.ToString();
					break;
				case "MoveTree4":
					ret = _MoveTree4.ToString();
					break;
				case "XPDevModel":
					ret = _XPDevModel.ToString();
					break;
				case "CatchRate":
					ret = _CatchRate.ToString();
					break;
				case "PassiveEffectClasses":
					ret = _PassiveEffectClasses.ToString();
					break;
				case "CurrentlyWorking":
					ret = _CurrentlyWorking.ToString();
					break;
				case "BaseExperienceYield":
					ret = _BaseExperienceYield.ToString();
					break;
				case "IsStarterMonster":
					ret = _IsStarterMonster.ToString();
					break;
				case "CompanionA":
					ret = _CompanionA.ToString();
					break;
				case "CompanionALevelDiff":
					ret = _CompanionALevelDiff.ToString();
					break;
				case "CompanionB":
					ret = _CompanionB.ToString();
					break;
				case "CompanionBLevelDiff":
					ret = _CompanionBLevelDiff.ToString();
					break;
			}

			return ret;
		}
		public override string ToString()
		{
			string ret = System.String.Empty;
			ret += "{" + "ID" + " : " + _ID.ToString() + "} ";
			ret += "{" + "Name" + " : " + _Name.ToString() + "} ";
			ret += "{" + "Description" + " : " + _Description.ToString() + "} ";
			ret += "{" + "EvolvesTo" + " : " + _EvolvesTo.ToString() + "} ";
			ret += "{" + "PrimaryElement" + " : " + _PrimaryElement.ToString() + "} ";
			ret += "{" + "SecondaryElement" + " : " + _SecondaryElement.ToString() + "} ";
			ret += "{" + "EvolvesAt" + " : " + _EvolvesAt.ToString() + "} ";
			ret += "{" + "HP" + " : " + _HP.ToString() + "} ";
			ret += "{" + "HPPerLevel" + " : " + _HPPerLevel.ToString() + "} ";
			ret += "{" + "HPAt50" + " : " + _HPAt50.ToString() + "} ";
			ret += "{" + "HPAt100" + " : " + _HPAt100.ToString() + "} ";
			ret += "{" + "Energy" + " : " + _Energy.ToString() + "} ";
			ret += "{" + "EnergyPerLevel" + " : " + _EnergyPerLevel.ToString() + "} ";
			ret += "{" + "EnergyAt50" + " : " + _EnergyAt50.ToString() + "} ";
			ret += "{" + "EnergyAt100" + " : " + _EnergyAt100.ToString() + "} ";
			ret += "{" + "MeleeAttack" + " : " + _MeleeAttack.ToString() + "} ";
			ret += "{" + "MeleeDefense" + " : " + _MeleeDefense.ToString() + "} ";
			ret += "{" + "RangeAttack" + " : " + _RangeAttack.ToString() + "} ";
			ret += "{" + "RangeDefense" + " : " + _RangeDefense.ToString() + "} ";
			ret += "{" + "Speed" + " : " + _Speed.ToString() + "} ";
			ret += "{" + "Resistance" + " : " + _Resistance.ToString() + "} ";
			ret += "{" + "Accuracy" + " : " + _Accuracy.ToString() + "} ";
			ret += "{" + "Agility" + " : " + _Agility.ToString() + "} ";
			ret += "{" + "MeleeAttackPerLevel" + " : " + _MeleeAttackPerLevel.ToString() + "} ";
			ret += "{" + "MeleeAttackAt50" + " : " + _MeleeAttackAt50.ToString() + "} ";
			ret += "{" + "MeleeDefensePerLevel" + " : " + _MeleeDefensePerLevel.ToString() + "} ";
			ret += "{" + "MeleeDefenseAt50" + " : " + _MeleeDefenseAt50.ToString() + "} ";
			ret += "{" + "RangeAttackPerLevel" + " : " + _RangeAttackPerLevel.ToString() + "} ";
			ret += "{" + "RangeAttackAt50" + " : " + _RangeAttackAt50.ToString() + "} ";
			ret += "{" + "RangeDefensePerLevel" + " : " + _RangeDefensePerLevel.ToString() + "} ";
			ret += "{" + "AccuracyPerLevel" + " : " + _AccuracyPerLevel.ToString() + "} ";
			ret += "{" + "RangeDefenseAt50" + " : " + _RangeDefenseAt50.ToString() + "} ";
			ret += "{" + "SpeedPerLevel" + " : " + _SpeedPerLevel.ToString() + "} ";
			ret += "{" + "SpeedAt50" + " : " + _SpeedAt50.ToString() + "} ";
			ret += "{" + "MoveTree1" + " : " + _MoveTree1.ToString() + "} ";
			ret += "{" + "MoveTree2" + " : " + _MoveTree2.ToString() + "} ";
			ret += "{" + "MoveTree3" + " : " + _MoveTree3.ToString() + "} ";
			ret += "{" + "MoveTree4" + " : " + _MoveTree4.ToString() + "} ";
			ret += "{" + "XPDevModel" + " : " + _XPDevModel.ToString() + "} ";
			ret += "{" + "CatchRate" + " : " + _CatchRate.ToString() + "} ";
			ret += "{" + "PassiveEffectClasses" + " : " + _PassiveEffectClasses.ToString() + "} ";
			ret += "{" + "CurrentlyWorking" + " : " + _CurrentlyWorking.ToString() + "} ";
			ret += "{" + "BaseExperienceYield" + " : " + _BaseExperienceYield.ToString() + "} ";
			ret += "{" + "IsStarterMonster" + " : " + _IsStarterMonster.ToString() + "} ";
			ret += "{" + "CompanionA" + " : " + _CompanionA.ToString() + "} ";
			ret += "{" + "CompanionALevelDiff" + " : " + _CompanionALevelDiff.ToString() + "} ";
			ret += "{" + "CompanionB" + " : " + _CompanionB.ToString() + "} ";
			ret += "{" + "CompanionBLevelDiff" + " : " + _CompanionBLevelDiff.ToString() + "} ";
			return ret;
		}
	}
	public sealed class TMMonsters : IGoogle2uDB
	{
		public enum rowIds {
			TM_NOCREATURE, TM_NINEVOLT, TM_DIREVOLT, TM_WEREVOLT, TM_VIPERNO, TM_PYROLISK, TM_BLAZILISK, TM_FREYON, TM_LYONYCE, TM_DIAMANE, TM_JAGWAR, TM_JAGROAR, TM_JAGGOON, TM_RACKET, TM_RATCHET, TM_RACRUEL, TM_CHIPMUNKEY, TM_MOXTAIL
			, TM_VEXTAIL, TM_THRASHTAIL, TM_TOMALING, TM_TOMAHAWK, TM_DRAGONFRY, TM_DRAGONFLARE, TM_LOTIS, TM_MANTISLASH, TM_MOTHBALL, TM_FLUSTER, TM_MOTHARCH, TM_EQUINAIR, TM_EQUINESS, TM_GLACELEAP, TM_FROSTSAUT, TM_SCUDA, TM_PREDACUDA, TM_LEVIACUDA, TM_ALISTINKER, TM_FOULIGATOR
			, TM_CHIBCHIB, TM_CHIBKEN, TM_CHIBMERA, TM_SNOZO, TM_SERPQUIN, TM_COBROZO, TM_CHICKLIT, TM_CALEAF, TM_BISOAK, TM_SPREW, TM_SHROZEN, TM_STRUTWING, TM_STRUTWIND, TM_BANANTEATER, TM_BANANIVORE, TM_BRAK, TM_BUFFLOW, TM_PEAMATO, TM_MONSTROSIPEA, TM_TOMATOPEA
			, TM_RIPEMARE, TM_WOLVUS, TM_MAULVERINE, TM_CORALPIE, TM_TIDALHORN, TM_TORTIPOUS, TM_TORTITANK, TM_KRABKEN, TM_CLAWBSTER, TM_CLAWLOSSAL, TM_LOTHEO, TM_HYTHEO, TM_LOTHEA, TM_HYTHEA, TM_FLOWGO, TM_FLOATANGO, TM_FLAIRMINGO, TM_FLARMIAN, TM_FIRMITAUR, TM_FIRENAUGHT
			, TM_SOOTIMANDER, TM_SOOTIRAPTOR, TM_SOOTRAGON, TM_FLAFFEE, TM_IGNIRAFFE, TM_SCORCHLING, TM_CINDUCK, TM_IGNITLER, TM_FLAMOOSE, TM_MANTICUB, TM_MANTERI, TM_AMPEROR, TM_AMPINT, TM_GORILLAMP, TM_JOLTERMITE, TM_VOLTERMITE, TM_GEKOWATT, TM_GAZOLT, TM_VOLTEER, TM_SHADOWVOLT
			, TM_RIFFIN, TM_RIFFINDOR, TM_SHINO, TM_RHIYEW, TM_SAPPRESS, TM_OAKLORE, TM_SWINX, TM_SONAX, TM_SHRIKEN, TM_JASTRIKE, TM_HOODWINK, TM_ROBBINGHOOD, TM_VILEWING, TM_YANTIS, TM_BUNTIS, TM_HOOTENANT, TM_GENEROWL, TM_SOARPHIN, TM_HALOPHIN, TM_SNOWYRM
			, TM_RAGEWYRM, TM_OARION, TM_URSNOBAL, TM_URSICLE, TM_URSTORM, TM_YETICRAB, TM_YETICLAW, TM_YETIKING, TM_TURANOM, TM_PENDRILL, TM_CHILLBEAK, TM_OCTICUTE, TM_TENTAPULSE, TM_ODDCAT, TM_PINCLAW, TM_QUIRKAT, TM_GRYNN, TM_HECKYLL, TM_CACKYLL, TM_STARIA
			, TM_CELESTAIL, TM_CELESTROAH, TM_SPOOMPKIN, TM_FOXPAW, TM_PRANKTAIL, TM_JESTAR, TM_PEACHIC, TM_PEACANE, TM_PEAQUEEN, TM_DOZER, TM_PYRODILUS, TM_ELECTROSAURUS, TM_GALAVANNIS, TM_SHARKUIT, TM_SHARKBYTE, TM_MAKOWATT, TM_ELECTRIPINE, TM_SPORKUPINE, TM_TORQUPINE, TM_MAGMELEON
			, TM_MEGAMELEON, TM_MAGMAMELEON, TM_DANDYLION, TM_PURRPETAL, TM_VIONESS, TM_FLOFOX, TM_WINTAIL, TM_CYCLONINE, TM_PANDEMITE, TM_PANDORA, TM_PANDORUM, TM_NIPTUNE, TM_AQUANINE, TM_CARNIVICE, TM_VENOX, TM_RAPTOX, TM_VELOCIRAX, TM_BULLIBEE, TM_TARGABEE, TM_MISSILBEE
			, TM_SKULLYWAG, TM_SHARPOON, TM_VILLIANEARD, TM_TUFFIN, TM_ARMOTIDE, TM_OCEANITE, TM_BRRIZARD, TM_SLIZZARD, TM_GLACIAGON, TM_CLOVICE, TM_LUMINEER, TM_MAJESTICE, TM_SNAILIX, TM_EXOLLUSK, TM_SLUGGERNAUGHT, TM_NARWHALITE, TM_TAURYSOS, TM_SKELINOTH, TM_GALYNX, TM_SQUALLAN
			, TM_INFERRAM, TM_GLACIOLIN, TM_AQUARIN, TM_TERRY
		};
		public string [] rowNames = {
			"TM_NOCREATURE", "TM_NINEVOLT", "TM_DIREVOLT", "TM_WEREVOLT", "TM_VIPERNO", "TM_PYROLISK", "TM_BLAZILISK", "TM_FREYON", "TM_LYONYCE", "TM_DIAMANE", "TM_JAGWAR", "TM_JAGROAR", "TM_JAGGOON", "TM_RACKET", "TM_RATCHET", "TM_RACRUEL", "TM_CHIPMUNKEY", "TM_MOXTAIL"
			, "TM_VEXTAIL", "TM_THRASHTAIL", "TM_TOMALING", "TM_TOMAHAWK", "TM_DRAGONFRY", "TM_DRAGONFLARE", "TM_LOTIS", "TM_MANTISLASH", "TM_MOTHBALL", "TM_FLUSTER", "TM_MOTHARCH", "TM_EQUINAIR", "TM_EQUINESS", "TM_GLACELEAP", "TM_FROSTSAUT", "TM_SCUDA", "TM_PREDACUDA", "TM_LEVIACUDA", "TM_ALISTINKER", "TM_FOULIGATOR"
			, "TM_CHIBCHIB", "TM_CHIBKEN", "TM_CHIBMERA", "TM_SNOZO", "TM_SERPQUIN", "TM_COBROZO", "TM_CHICKLIT", "TM_CALEAF", "TM_BISOAK", "TM_SPREW", "TM_SHROZEN", "TM_STRUTWING", "TM_STRUTWIND", "TM_BANANTEATER", "TM_BANANIVORE", "TM_BRAK", "TM_BUFFLOW", "TM_PEAMATO", "TM_MONSTROSIPEA", "TM_TOMATOPEA"
			, "TM_RIPEMARE", "TM_WOLVUS", "TM_MAULVERINE", "TM_CORALPIE", "TM_TIDALHORN", "TM_TORTIPOUS", "TM_TORTITANK", "TM_KRABKEN", "TM_CLAWBSTER", "TM_CLAWLOSSAL", "TM_LOTHEO", "TM_HYTHEO", "TM_LOTHEA", "TM_HYTHEA", "TM_FLOWGO", "TM_FLOATANGO", "TM_FLAIRMINGO", "TM_FLARMIAN", "TM_FIRMITAUR", "TM_FIRENAUGHT"
			, "TM_SOOTIMANDER", "TM_SOOTIRAPTOR", "TM_SOOTRAGON", "TM_FLAFFEE", "TM_IGNIRAFFE", "TM_SCORCHLING", "TM_CINDUCK", "TM_IGNITLER", "TM_FLAMOOSE", "TM_MANTICUB", "TM_MANTERI", "TM_AMPEROR", "TM_AMPINT", "TM_GORILLAMP", "TM_JOLTERMITE", "TM_VOLTERMITE", "TM_GEKOWATT", "TM_GAZOLT", "TM_VOLTEER", "TM_SHADOWVOLT"
			, "TM_RIFFIN", "TM_RIFFINDOR", "TM_SHINO", "TM_RHIYEW", "TM_SAPPRESS", "TM_OAKLORE", "TM_SWINX", "TM_SONAX", "TM_SHRIKEN", "TM_JASTRIKE", "TM_HOODWINK", "TM_ROBBINGHOOD", "TM_VILEWING", "TM_YANTIS", "TM_BUNTIS", "TM_HOOTENANT", "TM_GENEROWL", "TM_SOARPHIN", "TM_HALOPHIN", "TM_SNOWYRM"
			, "TM_RAGEWYRM", "TM_OARION", "TM_URSNOBAL", "TM_URSICLE", "TM_URSTORM", "TM_YETICRAB", "TM_YETICLAW", "TM_YETIKING", "TM_TURANOM", "TM_PENDRILL", "TM_CHILLBEAK", "TM_OCTICUTE", "TM_TENTAPULSE", "TM_ODDCAT", "TM_PINCLAW", "TM_QUIRKAT", "TM_GRYNN", "TM_HECKYLL", "TM_CACKYLL", "TM_STARIA"
			, "TM_CELESTAIL", "TM_CELESTROAH", "TM_SPOOMPKIN", "TM_FOXPAW", "TM_PRANKTAIL", "TM_JESTAR", "TM_PEACHIC", "TM_PEACANE", "TM_PEAQUEEN", "TM_DOZER", "TM_PYRODILUS", "TM_ELECTROSAURUS", "TM_GALAVANNIS", "TM_SHARKUIT", "TM_SHARKBYTE", "TM_MAKOWATT", "TM_ELECTRIPINE", "TM_SPORKUPINE", "TM_TORQUPINE", "TM_MAGMELEON"
			, "TM_MEGAMELEON", "TM_MAGMAMELEON", "TM_DANDYLION", "TM_PURRPETAL", "TM_VIONESS", "TM_FLOFOX", "TM_WINTAIL", "TM_CYCLONINE", "TM_PANDEMITE", "TM_PANDORA", "TM_PANDORUM", "TM_NIPTUNE", "TM_AQUANINE", "TM_CARNIVICE", "TM_VENOX", "TM_RAPTOX", "TM_VELOCIRAX", "TM_BULLIBEE", "TM_TARGABEE", "TM_MISSILBEE"
			, "TM_SKULLYWAG", "TM_SHARPOON", "TM_VILLIANEARD", "TM_TUFFIN", "TM_ARMOTIDE", "TM_OCEANITE", "TM_BRRIZARD", "TM_SLIZZARD", "TM_GLACIAGON", "TM_CLOVICE", "TM_LUMINEER", "TM_MAJESTICE", "TM_SNAILIX", "TM_EXOLLUSK", "TM_SLUGGERNAUGHT", "TM_NARWHALITE", "TM_TAURYSOS", "TM_SKELINOTH", "TM_GALYNX", "TM_SQUALLAN"
			, "TM_INFERRAM", "TM_GLACIOLIN", "TM_AQUARIN", "TM_TERRY"
		};
		public System.Collections.Generic.List<TMMonstersRow> Rows = new System.Collections.Generic.List<TMMonstersRow>();

		public static TMMonsters Instance
		{
			get { return NestedTMMonsters.instance; }
		}

		private class NestedTMMonsters
		{
			static NestedTMMonsters() { }
			internal static readonly TMMonsters instance = new TMMonsters();
		}

		private TMMonsters()
		{
			Rows.Add( new TMMonstersRow("TM_NOCREATURE", "0", "No Creature", "Oy! This should never be seen...", "No Creature", "Earth", "", "0", "20", "9", "470", "900", "200", "4.5", "425", "650", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "2", "0", "0", "0", "Normal Move Tree", "", "", "", "Medium", "128", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_NINEVOLT", "1", "Ninevolt", "The fur of a Ninevolt generates small amounts of static electricity. One should be very careful when petting one. (Electric)", "Direvolt", "Electric", "", "15", "36", "9.3", "501", "945", "200", "4.5", "425", "650", "40", "28", "35", "30", "55", "30", "37", "43", "3.3", "165", "3.3", "165", "3.3", "165", "3.3", "2", "165", "3.5", "175", "Normal Move Tree", "Electric Move Tree", "", "", "Medium", "10", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_DIREVOLT", "2", "Direvolt", "There is a light-reflecting layer on Direvolt's eyes that contributes to its superior night vision. This layer also causes the eyes to glow when contacted by light in the dark. (Electric)", "Werevolt", "Electric", "", "37", "57", "9.3", "522", "967", "265", "4", "465", "665", "55", "40", "53", "41", "72", "50", "40", "49", "3.3", "165", "3.3", "165", "3.3", "165", "3.3", "2", "165", "3.4", "170", "Normal Move Tree", "Electric Move Tree", "", "", "Medium", "128", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_WEREVOLT", "3", "Werevolt", "A Werevolt's howl is often mistaken as the crash of thunder. It is so loud that it can temporarily impair hearing or cause permanent hearing loss in rare cases. (Electric)", "No Creature", "Electric", "", "1", "78", "9.3", "543", "931", "335", "3.5", "510", "685", "78", "55", "76", "50", "85", "50", "55", "70", "3.3", "165", "3.3", "165", "3.3", "165", "3.3", "2", "165", "3.3", "165", "Normal Move Tree", "Electric Move Tree", "", "", "Medium", "128", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_VIPERNO", "4", "Viperno", "Viperno has two hollowed fangs that emit small flames when it strikes, causing searing pain. (Fire)", "Pyrolisk", "Fire", "", "15", "39", "9.3", "504", "945", "200", "4.5", "425", "650", "29", "28", "48", "42", "38", "30", "38", "39", "3.3", "165", "3.3", "165", "3.3", "165", "3.3", "2", "165", "3.5", "175", "Normal Move Tree", "Fire Move Tree", "", "", "Medium", "10", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_PYROLISK", "5", "Pyrolisk", "Pyrolisk has a confident deamenor and a fiery temper. It often antagonize others into a fight. There is nothing it loves more than a good fight. (Fire) ", "Blazilisk", "Fire", "", "36", "60", "9.3", "525", "966", "265", "4", "465", "665", "40", "38", "70", "55", "51", "50", "40", "51", "3.3", "165", "3.3", "165", "3.3", "165", "3.3", "2", "165", "3.4", "170", "Normal Move Tree", "Fire Move Tree", "", "", "Medium", "128", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_BLAZILISK", "6", "Blazilisk", "Ancient civilizations revered and worshipped Blazilisks for their strength and grace. They mistakingly took them for dragons of legend when they flew over towns at night. (Fire) ", "No Creature", "Fire", "", "1", "75", "9.3", "540", "931", "335", "3.5", "510", "685", "60", "48", "97", "70", "57", "80", "45", "60", "3.3", "165", "3.3", "165", "3.3", "165", "3.3", "2", "165", "3.3", "165", "Normal Move Tree", "Fire Move Tree", "Air Move Tree", "", "Medium", "128", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_FREYON", "7", "Freyon", "No two Freyon share the same shaped tail. However, as it grows and crystalize, the tail becomes indentical to others.", "Lyonyce", "Ice", "", "15", "45", "9.3", "510", "945", "200", "4.5", "425", "650", "45", "40", "30", "40", "30", "30", "38", "42", "3.3", "165", "3.3", "165", "3.3", "165", "3.3", "2", "165", "3.5", "175", "Normal Move Tree", "Ice Move Tree", "", "", "Medium", "10", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_LYONYCE", "8", "Lyonyce", "A Lyonyce will often use its crystalized tail as another mean of attack. One in which it uses with deadly accuracy. (Ice) ", "Diamane", "Ice", "", "35", "75", "9.3", "540", "965", "265", "4", "465", "665", "65", "50", "42", "58", "40", "50", "40", "43", "3.3", "165", "3.3", "165", "3.3", "165", "3.3", "2", "165", "3.4", "170", "Normal Move Tree", "Ice Move Tree", "", "", "Medium", "128", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_DIAMANE", "9", "Diamane", "Diamane's claws are one of the strongest materials in Terrarium. Although extremely rare, its claws can break during battle. A few broken pieces have turned up in the black market. (Ice)", "No Creature", "Ice", "", "1", "90", "9.3", "555", "931", "335", "3.5", "510", "685", "86", "62", "65", "77", "50", "49", "50", "44", "3.3", "165", "3.3", "165", "3.3", "165", "3.3", "2", "165", "3.3", "165", "Normal Move Tree", "Ice Move Tree", "", "", "Medium", "128", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_JAGWAR", "10", "Jagwar", "Jagwar is born with a heavy head piece. It must gain its strength quickly to stablize its balance. (Earth)", "Jagroar", "Earth", "", "15", "42", "9.3", "507", "945", "200", "4.5", "425", "650", "34", "50", "27", "40", "35", "30", "42", "38", "3.3", "165", "3.3", "165", "3.3", "165", "3.3", "2", "165", "3.5", "175", "Normal Move Tree", "Earth Move Tree", "", "", "Medium", "10", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_JAGROAR", "11", "Jagroar", "Jagroar is very agile and stealthy despite its bulky appearance. It can stalk a prey for long periods of time without being noticed. (Earth)", "Jaggoon", "Earth", "", "36", "63", "9.3", "528", "966", "265", "4", "465", "665", "45", "65", "45", "56", "48", "44", "42", "45", "3.3", "165", "3.3", "165", "3.3", "165", "3.3", "2", "165", "3.4", "170", "Normal Move Tree", "Earth Move Tree", "", "", "Medium", "128", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_JAGGOON", "12", "Jaggoon", "Jaggoon is quite fond of sleeping. It is uncommon to see Jaggoon basking in the sun on the side of mountain for hours. (Earth)", "No Creature", "Earth", "", "1", "81", "9.3", "546", "931", "335", "3.5", "510", "685", "64", "80", "64", "70", "65", "54", "54", "57", "3.3", "165", "3.3", "165", "3.3", "165", "3.3", "2", "165", "3.3", "165", "Normal Move Tree", "Earth Move Tree", "", "", "Medium", "128", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_RACKET", "13", "Racket", "Racket tends to curl up in a ball to camouflage itself in the undergrowth. (Earth)", "Ratchet", "Earth", "", "16", "30", "9", "480", "916", "180", "4.3", "395", "610", "25", "23", "26", "22", "23", "20", "22", "24", "3", "150", "3", "150", "3", "150", "3", "2", "150", "3.3", "165", "Normal Move Tree", "Earth Move Tree", "", "", "Medium", "140", "7", "1", "1", "1", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_RATCHET", "14", "Ratchet", "Despite their tough demeanor, Rachet can not hide its infatuation for apple seeds. (Earth)", "Racruel", "Earth", "", "35", "36", "9", "486", "935", "200", "4", "400", "600", "40", "45", "32", "31", "32", "30", "31", "33", "3", "150", "3", "150", "3", "150", "3", "2", "150", "3.2", "160", "Normal Move Tree", "Earth Move Tree", "", "", "Medium", "20", "7", "1", "1", "0", "Racket", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_RACRUEL", "15", "Racruel", "Racruel is known for its tenacity and spirit. It can also be quite unkind to others, earning the nickname \"Bully of the Forest\". (Earth)", "No Creature", "Earth", "", "1", "65", "9", "515", "901", "220", "3.7", "405", "590", "68", "58", "48", "42", "39", "43", "46", "54", "3.3", "165", "3", "150", "3", "150", "3", "2", "150", "3.1", "155", "Normal Move Tree", "Earth Move Tree", "", "", "Medium", "20", "7", "1", "1", "0", "Racket", "-1", "Racket", "-1"));
			Rows.Add( new TMMonstersRow("TM_CHIPMUNKEY", "16", "Chipmunkey", "Chipmunkey has a superb sense of balance, timing and lightning quick reflexes. It is difficult for a for to judge its upcoming attack. (Earth)", "No Creature", "Earth", "", "23", "31", "9", "481", "923", "210", "4", "410", "610", "34", "36", "10", "15", "38", "20", "37", "42", "3.3", "165", "3.2", "160", "3.2", "160", "3.1", "2", "155", "3.2", "160", "Normal Move Tree", "Earth Move Tree", "", "", "Medium", "80", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_MOXTAIL", "17", "Moxtail", "Moxtails are notoriously mischievous. They are not shy of human contact and often cause trouble around towns. (Fire)", "Vextail", "Fire", "", "24", "22", "9", "472", "924", "180", "4", "380", "580", "26", "25", "22", "22", "40", "5", "30", "35", "3", "150", "3", "150", "3", "150", "3", "2", "150", "3.2", "160", "Normal Move Tree", "Fire Move Tree", "", "", "Medium", "255", "7", "1", "1", "1", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_VEXTAIL", "18", "Vextail", "Vextails are powerful and versatile Terra Monsters. Don't let their stature fool you, they are remarkably strong for their size. (Fire)", "Thrashtail", "Fire", "", "39", "38", "9", "488", "939", "200", "3.7", "385", "570", "38", "39", "33", "35", "50", "30", "42", "38", "3", "150", "3", "150", "3.2", "160", "3", "2", "150", "3.1", "155", "Normal Move Tree", "Fire Move Tree", "", "", "Medium", "128", "7", "1", "1", "0", "Flarmian", "0", "Flarmian", "0"));
			Rows.Add( new TMMonstersRow("TM_THRASHTAIL", "19", "Thrashtail", "Be sure not to upset a Thrashtail. They're notorious for their short fuses and volatile temper. (Fire)", "No Creature", "Fire", "", "1", "55", "10", "555", "1001", "230", "3.5", "405", "580", "48", "46", "44", "44", "59", "56", "50", "54", "3", "150", "3", "150", "3.2", "160", "3", "2", "150", "3", "150", "Normal Move Tree", "Fire Move Tree", "", "", "Medium", "128", "7", "1", "1", "0", "Moxtail", "-1", "Moxtail", "-1"));
			Rows.Add( new TMMonstersRow("TM_TOMALING", "20", "Tomaling", "Tomaling's feathers are bright to attract a mate. The more vibrant a Tomaling's feathers, the stronger it is said to be. (Air)", "Tomahawk", "Air", "", "20", "32", "9", "482", "920", "190", "4", "390", "590", "26", "38", "24", "25", "34", "6", "31", "32", "1.9", "95", "2.8", "140", "3.4", "170", "3.4", "2", "170", "3.3", "165", "Normal Move Tree", "Air Move Tree", "", "", "Medium", "255", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_TOMAHAWK", "21", "Tomahawk", "Tomahawk's strength and size is evident through its claws. It is uncommon for it to break bones when it clamp down on its foe. (Air)", "No Creature", "Air", "", "1", "42", "9", "492", "901", "220", "3.7", "405", "590", "37", "47", "38", "39", "48", "40", "34", "42", "3.2", "160", "2.8", "140", "3.4", "170", "3.5", "2", "175", "3.2", "160", "Normal Move Tree", "Air Move Tree", "", "", "Medium", "20", "7", "1", "1", "0", "Tortipous", "0", "No Creature", "0"));
			Rows.Add( new TMMonstersRow("TM_DRAGONFRY", "22", "Dragonfry", "A male Dragonfry has a bigger bulb than a female. It is used to attract mates. During mating season, clusters of fireballs can be seen in the night skies. (Fire / Air)", "Dragonflare", "Fire", "Air", "15", "20", "9", "470", "915", "200", "4", "400", "600", "20", "31", "20", "30", "32", "30", "31", "35", "1.9", "95", "2.8", "140", "3.3", "165", "3.5", "2", "175", "3.3", "165", "Normal Move Tree", "Fire Move Tree", "Air Move Tree", "", "Medium", "140", "7", "1", "1", "1", "Tomaling", "-1", "Tomaling", "-1"));
			Rows.Add( new TMMonstersRow("TM_DRAGONFLARE", "23", "Dragonflare", "Dragonflare will store its flame inside its bulb to maintain a comfortable body temperature while it is sleeping. (Fire / Air)", "No Creature", "Fire", "Air", "1", "31", "9", "481", "901", "240", "3.6", "420", "600", "22", "45", "42", "34", "63", "40", "45", "55", "1.8", "90", "2.8", "140", "3.3", "165", "3.5", "2", "175", "3.3", "165", "Normal Move Tree", "Fire Move Tree", "Air Move Tree", "", "Medium", "128", "7", "1", "1", "0", "Dragonfry", "-2", "Dragonfry", "-2"));
			Rows.Add( new TMMonstersRow("TM_LOTIS", "24", "Lotis", "Lotis' beauty is highly adored in Terrarium. A festival is thrown in its honor during Spring solstice. Having one land on you is a sign of an approaching blessing. (Earth / Air)", "Mantislash", "Earth", "Air", "33", "16", "9", "466", "933", "230", "4", "430", "630", "10", "14", "35", "32", "21", "16", "31", "16", "1.7", "85", "2.8", "140", "3.4", "170", "3.5", "2", "175", "3.5", "175", "Normal Move Tree", "Earth Move Tree", "Air Move Tree", "", "Medium", "80", "7", "1", "1", "0", "Dragonfry", "-1", "Dragonfry", "-1"));
			Rows.Add( new TMMonstersRow("TM_MANTISLASH", "25", "Mantislash", "As Mantislash's petals begin to dull from use, they will naturally fall off and replace themselves with a new set of sharp ones. (Earth / Air)", "No Creature", "Earth", "Air", "1", "68", "9", "518", "901", "260", "3.7", "445", "630", "50", "44", "36", "34", "77", "50", "44", "67", "1.8", "90", "2.8", "140", "3.4", "170", "3.5", "2", "175", "3.4", "170", "Normal Move Tree", "Earth Move Tree", "Air Move Tree", "", "Medium", "128", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_MOTHBALL", "26", "Mothball", "Mothball hides near trees to avoid trouble, blending in with the spring bloom. (Earth)", "Fluster", "Earth", "", "8", "18", "9", "468", "908", "200", "4", "400", "600", "10", "5", "10", "10", "5", "5", "40", "8", "1.8", "90", "2.8", "140", "2.8", "140", "2.8", "2", "140", "3", "150", "Normal Move Tree", "Earth Move Tree", "", "", "Medium", "200", "7", "1", "1", "1", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_FLUSTER", "27", "Fluster", "This Terra Monster doesn't seem to do much but crawl about. It is perfectly content waiting to evolve. (Earth)", "Motharch", "Earth", "", "12", "25", "9", "475", "912", "220", "3.5", "395", "570", "18", "19", "26", "19", "25", "10", "42", "26", "1.7", "85", "2.8", "140", "2.9", "145", "2.8", "2", "140", "3", "150", "Normal Move Tree", "Earth Move Tree", "", "", "Medium", "128", "7", "1", "1", "0", "Venox", "-1", "No Creature", "0"));
			Rows.Add( new TMMonstersRow("TM_MOTHARCH", "28", "Motharch", "Motharch can flap its golden wings up to 80 times per second. Each Motharch has its own unique pattern. (Air / Earth)", "No Creature", "Air", "", "1", "65", "9", "515", "901", "250", "3.2", "410", "570", "55", "45", "70", "55", "77", "50", "68", "75", "1.9", "95", "3", "150", "3.2", "160", "3.5", "2", "175", "3.4", "170", "Normal Move Tree", "Earth Move Tree", "Air Move Tree", "", "Medium", "128", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_EQUINAIR", "29", "Equinair", "Equinair is highly skittish when it is first born. It will bolt at the tiniest sound. (Air)", "Equiness", "Air", "", "28", "31", "9", "481", "928", "200", "3.8", "390", "580", "32", "31", "40", "35", "41", "32", "41", "50", "1.9", "95", "3.1", "155", "3.2", "160", "3.1", "2", "155", "3.3", "165", "Normal Move Tree", "Air Move Tree", "", "", "Medium", "128", "7", "1", "1", "0", "Mothball", "-2", "Fluster", "-1"));
			Rows.Add( new TMMonstersRow("TM_EQUINESS", "30", "Equiness", "Equiness' cloud-like mane is weightless and can be rearranged during flight to make it more aerodynamic.(Air)", "No Creature", "Air", "", "0", "55", "9", "505", "900", "220", "3.5", "395", "570", "52", "44", "50", "45", "76", "45", "52", "61", "1.9", "95", "3.1", "155", "3.2", "160", "3.1", "2", "155", "3.2", "160", "Normal Move Tree", "Air Move Tree", "", "", "Medium", "20", "7", "1", "1", "0", "Tomaling", "1", "Tomaling", "1"));
			Rows.Add( new TMMonstersRow("TM_GLACELEAP", "31", "Glaceleap", "Glaceleaps tongue is so cold that anything it touches instantly turns to ice. (Ice)", "Frostsaut", "Ice", "", "26", "28", "9", "478", "926", "220", "3.7", "405", "590", "50", "47", "52", "43", "79", "47", "47", "40", "1.9", "95", "2.7", "135", "3.4", "170", "3.2", "2", "160", "3.3", "165", "Normal Move Tree", "Ice Move Tree", "", "", "Medium", "128", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_FROSTSAUT", "32", "Frostsaut", "Frostsauts sometimes don't move for days. They're said to be the most patient hunters in Terrarium. (Ice)", "No Creature", "Ice", "", "1", "55", "9", "505", "901", "250", "3.3", "415", "580", "50", "46", "54", "57", "68", "45", "59", "51", "1.8", "90", "2.7", "135", "3.4", "170", "3.3", "2", "165", "3.2", "160", "Normal Move Tree", "Ice Move Tree", "Arcane Move Tree", "", "Medium", "20", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_SCUDA", "33", "Scuda", "Scudas rely on surprise and short bursts of speed to overtake their opponent. They can often be seen in large schools. (Water)", "Predacuda", "Water", "", "12", "22", "9", "472", "912", "190", "3.8", "380", "570", "19", "15", "10", "13", "18", "20", "24", "10", "3", "150", "3", "150", "3", "150", "3", "2", "150", "3.3", "165", "Normal Move Tree", "Water Move Tree", "", "", "Medium", "140", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_PREDACUDA", "34", "Predacuda", "There is one Predacuda for every school of Scuda. The larger the school, the stronger the Predacuda.  (Water)", "Leviacuda", "Water", "", "36", "55", "9", "505", "936", "220", "3.3", "385", "550", "35", "50", "35", "30", "30", "30", "32", "31", "3.5", "175", "3", "150", "3", "150", "3", "2", "150", "3.2", "160", "Normal Move Tree", "Water Move Tree", "", "", "Medium", "20", "7", "1", "1", "0", "Scuda", "-1", "Scuda", "-1"));
			Rows.Add( new TMMonstersRow("TM_LEVIACUDA", "35", "Leviacuda", "Leviacuda has no natural predators. It is the apex predator of the seas. (Water)", "No Creature", "Water", "", "26", "107", "9", "557", "926", "235", "3", "385", "535", "76", "72", "59", "67", "46", "70", "51", "52", "3.5", "175", "3", "150", "3.3", "165", "3.4", "2", "170", "3.1", "155", "Normal Move Tree", "Water Move Tree", "", "", "Medium", "10", "7", "1", "1", "0", "Scuda", "-1", "Scuda", "-1"));
			Rows.Add( new TMMonstersRow("TM_ALISTINKER", "36", "Alistinker", "Alistinker enjoy swampy areas, where it acquires its legendary stench. It is said that each Alistinker has its unique smell and will never lose its odor. (Earth / Water)", "Fouligator", "Earth", "Water", "16", "27", "9.3", "492", "946", "180", "3.8", "370", "560", "20", "23", "24", "26", "15", "20", "25", "26", "3.2", "160", "3.1", "155", "3.1", "155", "2.7", "2", "135", "3", "150", "Normal Move Tree", "Water Move Tree", "Earth Move Tree", "", "Medium", "128", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_FOULIGATOR", "37", "Fouligator", "Fouligator’s stench is weakened after evolving because it no longer depends on its smell to defend itself. However it can still cause significant irritation to one's senses. (Earth/Water)", "No Creature", "Earth", "Water", "1", "50", "10", "550", "1001", "240", "3.3", "405", "570", "58", "59", "34", "56", "20", "43", "48", "41", "3.2", "160", "3.1", "155", "3.1", "155", "2.7", "2", "135", "2.8", "140", "Normal Move Tree", "Water Move Tree", "Earth Move Tree", "", "Medium", "20", "7", "1", "1", "0", "Lothea", "0", "Lotheo", "0"));
			Rows.Add( new TMMonstersRow("TM_CHIBCHIB", "38", "Chibchib", "Chibchibs are said to be the most curious Terra Monsters. So much so that they are often intrigued up until the very moment they're hit. (Air)", "Chibken", "Air", "", "22", "20", "9", "470", "922", "180", "3.9", "375", "570", "18", "19", "26", "27", "14", "40", "31", "28", "3", "150", "3.1", "155", "3", "150", "3", "2", "150", "3.1", "155", "Normal Move Tree", "Air Move Tree", "", "", "Medium", "120", "7", "1", "1", "0", "Alistinker", "-1", "Alistinker", "-1"));
			Rows.Add( new TMMonstersRow("TM_CHIBKEN", "39", "Chibken", "A Chibken evolves when it finally works out that other Terra Monsters are intentionally attacking it. This makes Chibken angry which triggers the evolution. (Air)", "Chibmera", "Air", "", "35", "35", "9", "485", "935", "200", "3.6", "380", "560", "34", "30", "42", "41", "42", "55", "35", "41", "3", "150", "3", "150", "3.3", "165", "3", "2", "150", "3", "150", "Normal Move Tree", "Air Move Tree", "", "", "Medium", "128", "7", "1", "1", "0", "Mothball", "1", "Mothball", "1"));
			Rows.Add( new TMMonstersRow("TM_CHIBMERA", "40", "Chibmera", "After a lifetime of not understanding why it has been attacked Chibmera trusts nothing and will attack at the earliest sign of danger. (Air)", "No Creature", "Air", "", "1", "61", "9", "511", "901", "240", "3.3", "405", "570", "65", "45", "65", "61", "55", "90", "55", "55", "3", "150", "3.2", "160", "3.5", "175", "3.3", "2", "165", "2.9", "145", "Normal Move Tree", "Air Move Tree", "", "", "Medium", "126", "7", "1", "1", "0", "Chibchib", "-1", "Chibchib", "-1"));
			Rows.Add( new TMMonstersRow("TM_SNOZO", "41", "Snozo", "Though their patterns are laughable, Snozo's bite is anything but funny. (Arcane)", "Serpquin", "Arcane", "", "24", "12", "8.8", "452", "904", "220", "3.9", "415", "610", "21", "13", "21", "13", "10", "31", "26", "18", "2", "100", "2.7", "135", "2.7", "135", "2.7", "2", "135", "3.3", "165", "Normal Move Tree", "Arcane Move Tree", "", "", "Medium", "70", "7", "1", "1", "0", "No Creature", "-1", "No Creature", "-1"));
			Rows.Add( new TMMonstersRow("TM_SERPQUIN", "42", "Serpquin", "After making humorous drawings in dirt and sand, Serpquins will hide nearby to ambush their prey. (Arcane)", "Cobrozo", "Arcane", "", "36", "27", "9", "477", "936", "240", "3.5", "415", "590", "32", "23", "30", "25", "25", "41", "37", "41", "3.1", "155", "2.8", "140", "3.3", "165", "3.3", "2", "165", "3.2", "160", "Normal Move Tree", "Arcane Move Tree", "", "", "Medium", "80", "7", "1", "1", "0", "Tortipous", "0", "Alistinker", "0"));
			Rows.Add( new TMMonstersRow("TM_COBROZO", "43", "Cobrozo", "The terrifying Cobrozo can be found in the wild doing hypnotic tricks and death defying balancing acts. (Arcane)", "No Creature", "Arcane", "", "1", "49", "9", "499", "901", "260", "3.3", "425", "590", "41", "38", "39", "40", "45", "51", "50", "48", "3.1", "155", "2.8", "140", "3.4", "170", "3.4", "2", "170", "3.1", "155", "Normal Move Tree", "Arcane Move Tree", "", "", "Medium", "20", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_CHICKLIT", "44", "Chicklit", "Chicklits are annoyingly enthusiastic about everything, other Terra Monsters tend to ignore Chicklit which makes Chicklits annoying behaviour even worse. (Fire)", "No Creature", "Fire", "", "20", "32", "9", "482", "920", "220", "3.8", "410", "600", "27", "36", "27", "28", "25", "10", "34", "28", "3", "150", "2.7", "135", "3.3", "165", "3.3", "2", "165", "3.4", "170", "Normal Move Tree", "Fire Move Tree", "", "", "Medium", "255", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_CALEAF", "45", "Caleaf", "Caleafs joints are so awkard at and early age that it looks like it's walking on stilts. (Earth)", "Bisoak", "Earth", "", "32", "34", "9", "484", "932", "200", "3.8", "390", "580", "35", "36", "32", "33", "20", "25", "32", "5", "3.2", "160", "3.6", "180", "1.8", "90", "2.7", "2", "135", "3.2", "160", "Normal Move Tree", "Earth Move Tree", "", "", "Medium", "128", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_BISOAK", "46", "Bisoak", "Bisoaks stores a lot of energy in its horns. It's believed that is where Bisoaks gets its powerful range abilities from. (Earth)", "No Creature", "Earth", "", "1", "76", "9", "526", "901", "230", "3.5", "405", "580", "52", "65", "45", "55", "34", "51", "45", "31", "3.2", "160", "3.6", "180", "1.7", "85", "2.7", "2", "135", "3.1", "155", "Normal Move Tree", "Earth Move Tree", "", "", "Medium", "128", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_SPREW", "47", "Sprew", "Not much is known about this Terra Monster. They reveal themselves to those they wish to frighten. (Ice) ", "Shrozen", "Ice", "Arcane", "40", "16", "9", "466", "940", "220", "4.2", "430", "640", "10", "14", "35", "32", "21", "16", "31", "16", "1.8", "90", "2.5", "125", "3.5", "175", "3.3", "2", "165", "2.8", "140", "Normal Move Tree", "Ice Move Tree", "Arcane Move Tree", "", "Medium", "80", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_SHROZEN", "48", "Shrozen", "Shrozen are often said to be ice spirits in fairy tales. They disappear as quickly as one's breath in the frigid cold. (Ice)", "No Creature", "Ice", "Arcane", "1", "68", "9", "518", "901", "250", "4", "450", "650", "50", "44", "36", "34", "77", "50", "44", "67", "1.8", "90", "2.7", "135", "3.5", "175", "3.4", "2", "170", "3.4", "170", "Normal Move Tree", "Ice Move Tree", "Arcane Move Tree", "", "Medium", "128", "7", "1", "1", "0", "Sprew", "0", "Sprew", "0"));
			Rows.Add( new TMMonstersRow("TM_STRUTWING", "49", "Strutwing", "Strutwings compensate for their inability to fly with remarkable agility on land. (Air)", "Strutwind", "Air", "", "51", "20", "9", "470", "951", "220", "4.3", "435", "650", "20", "25", "24", "26", "33", "30", "28", "44", "1.8", "90", "2.6", "130", "3.3", "165", "3.2", "2", "160", "3.3", "165", "Normal Move Tree", "Earth Move Tree", "Air Move Tree", "", "Medium", "80", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_STRUTWIND", "50", "Strutwind", "Strutwinds have excellent eyesight and hearing. They can sense danger from miles away. This makes them virtually impossible to be sneaked up upon. (Air)", "No Creature", "Air", "", "1", "35", "9", "485", "901", "260", "4", "460", "660", "29", "33", "46", "35", "78", "42", "46", "75", "1.9", "95", "2.6", "130", "3.3", "165", "3.2", "2", "160", "3.3", "165", "Normal Move Tree", "Earth Move Tree", "Air Move Tree", "", "Medium", "20", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_BANANTEATER", "51", "Bananteater", "Bananteater uses its long tongue to drink sweet nectar from wild flowers it encounters, and pick fruits. (Earth)", "Bananivore", "Earth", "", "31", "20", "9", "470", "931", "220", "4.5", "445", "670", "15", "22", "28", "24", "17", "22", "32", "20", "1.9", "95", "2.8", "140", "3.3", "165", "3.3", "2", "165", "3.2", "160", "Normal Move Tree", "Earth Move Tree", "", "", "Medium", "90", "7", "1", "1", "0", "Strutwing", "-1", "Strutwing", "-1"));
			Rows.Add( new TMMonstersRow("TM_BANANIVORE", "52", "Bananivore", "After evolution, the Bananivore's diet changes completely. It's docile nature is replaced by a hunger for meat. (Earth)", "No Creature", "Earth", "", "1", "42", "9", "492", "901", "260", "4", "460", "660", "33", "34", "38", "34", "25", "45", "43", "25", "3", "150", "3", "150", "3.3", "165", "3.3", "2", "165", "3.2", "160", "Normal Move Tree", "Earth Move Tree", "", "", "Medium", "128", "7", "1", "1", "0", "Venox", "0", "Brak", "0"));
			Rows.Add( new TMMonstersRow("TM_BRAK", "53", "Brak", "Brak's leafy exterior gives it excellent camoflauge in dense foilage. (Earth)", "Bufflow", "Earth", "", "32", "46", "9.1", "501", "942", "180", "3.8", "370", "560", "41", "42", "10", "15", "18", "20", "27", "6", "3.3", "165", "3.6", "180", "1.8", "90", "2.7", "2", "135", "3", "150", "Normal Move Tree", "Earth Move Tree", "", "", "Medium", "128", "7", "1", "1", "0", "Bananteater", "-1", "Bananteater", "-1"));
			Rows.Add( new TMMonstersRow("TM_BUFFLOW", "54", "Bufflow", "A Bufflow gain significant advantages joing a herd. When they all blend together, it is hard for foes to judge its true size.  (Earth)", "No Creature", "Earth", "", "1", "86", "9", "536", "901", "220", "3.5", "395", "570", "52", "76", "25", "40", "28", "50", "53", "15", "3.3", "165", "3.6", "180", "1.8", "90", "2.7", "2", "135", "2.9", "145", "Normal Move Tree", "Earth Move Tree", "", "", "Medium", "128", "7", "1", "1", "0", "Shriken", "0", "Shriken", "0"));
			Rows.Add( new TMMonstersRow("TM_PEAMATO", "55", "Peamato", "Peamato has an intense rivalry with Tomatopea, at an early age they often have to fight against one another for survival. (Earth)", "Monstrosipea", "Earth", "", "48", "25", "9", "475", "948", "200", "4.5", "425", "650", "18", "19", "26", "19", "25", "10", "42", "26", "1.8", "90", "2.6", "130", "3.4", "170", "3.3", "2", "165", "2.8", "140", "Normal Move Tree", "Earth Move Tree", "", "", "Medium", "128", "7", "1", "1", "0", "Brak", "-1", "Brak", "-1"));
			Rows.Add( new TMMonstersRow("TM_MONSTROSIPEA", "56", "Monstrosipea", "Evolution is said to happen when 5 or 6 Peamatos come together under the leadership of the Alphapea. They do this to gain protection against Tomatopeas. (Earth)", "No Creature", "Earth", "", "1", "65", "8.9", "510", "891", "260", "4", "460", "660", "55", "45", "70", "55", "77", "50", "68", "75", "1.8", "90", "2.6", "130", "3.4", "170", "3.3", "2", "165", "3.3", "165", "Normal Move Tree", "Earth Move Tree", "Arcane Move Tree", "", "Medium", "128", "7", "1", "1", "0", "Peamato", "0", "Peamato", "0"));
			Rows.Add( new TMMonstersRow("TM_TOMATOPEA", "57", "Tomatopea", "Tomatopeas compete with Peamatos from an early age. To become stronger Tomatopeas eat each other. (Earth)", "Ripemare", "Earth", "", "49", "25", "9", "475", "949", "220", "4.5", "445", "670", "18", "19", "26", "19", "25", "10", "42", "26", "1.8", "90", "2.6", "130", "3.4", "170", "3.3", "2", "165", "3.2", "160", "Normal Move Tree", "Earth Move Tree", "", "", "Medium", "128", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_RIPEMARE", "58", "Ripemare", "A Ripemare is a Tomatopea that has eaten at least 10 other Tomatopeas. The Tomatopeas souls join together to form one nightmarish consciousness. (Earth)", "No Creature", "Earth", "", "1", "65", "8.8", "505", "881", "260", "4", "460", "660", "55", "45", "70", "55", "77", "50", "68", "75", "1.9", "95", "2.6", "130", "3.5", "175", "2.6", "2", "130", "3.3", "165", "Normal Move Tree", "Earth Move Tree", "Arcane Move Tree", "", "Medium", "128", "7", "1", "1", "0", "Tomatopea", "0", "Tomatopea", "0"));
			Rows.Add( new TMMonstersRow("TM_WOLVUS", "59", "Wolvus", "Its spark is worse than its bite. Wolvus \"never back down\" attitude makes it a formidable opponent despite its small stature. (Electric)", "Maulverine", "Electric", "", "30", "31", "9", "481", "930", "220", "4.2", "430", "640", "44", "38", "15", "25", "35", "20", "32", "51", "3", "150", "3.2", "160", "3", "150", "3.2", "2", "160", "3.1", "155", "Normal Move Tree", "Electric Move Tree", "", "", "Medium", "50", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_MAULVERINE", "60", "Maulverine", "Maulverines fangs generate enough electricity to power a kettle for 10 years. (Electric)", "No Creature", "Electric", "", "1", "59", "9", "509", "901", "260", "3.8", "450", "640", "65", "56", "45", "37", "59", "40", "54", "73", "3.5", "175", "3.2", "160", "3.2", "160", "3.2", "2", "160", "3", "150", "Normal Move Tree", "Electric Move Tree", "", "", "Medium", "20", "7", "1", "1", "0", "Joltermite", "0", "Joltermite", "0"));
			Rows.Add( new TMMonstersRow("TM_CORALPIE", "61", "Coralpie", "Coralpie is a herbivore. Its diet consists of various species of seaweed and algae. (Water)", "Tidalhorn", "Water", "", "19", "22", "9", "472", "919", "240", "4.5", "465", "690", "28", "25", "27", "25", "23", "20", "28", "27", "3.3", "165", "3", "150", "3", "150", "3", "2", "150", "2.9", "145", "Normal Move Tree", "Water Move Tree", "", "", "Medium", "140", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_TIDALHORN", "62", "Tidalhorn", "Tidalhorns are master amphibians. Their anatomy allows them to sustain long periods of time in or out of water. (Water)", "No Creature", "Water", "Earth", "1", "38", "9", "488", "901", "260", "4", "460", "660", "38", "35", "48", "35", "35", "42", "30", "36", "3.2", "160", "3", "150", "3", "150", "2.9", "2", "145", "3.2", "160", "Normal Move Tree", "Water Move Tree", "Earth Move Tree", "", "Medium", "20", "7", "1", "1", "0", "Scuda", "-2", "Scuda", "-2"));
			Rows.Add( new TMMonstersRow("TM_TORTIPOUS", "63", "Tortipous", "When frightened, Tortipous will hide in its shell and propels itself away from danger with its tail. (Water)", "Tortitank", "Water", "Earth", "26", "55", "9.4", "525", "966", "170", "4.2", "380", "590", "25", "50", "35", "50", "15", "34", "35", "15", "3.2", "160", "3.6", "180", "1.7", "85", "2.7", "2", "135", "3", "150", "Normal Move Tree", "Water Move Tree", "Earth Move Tree", "", "Medium", "70", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_TORTITANK", "64", "Tortitank", "The tough exoskeleton of Tortitank weighs it down, but provides formidable protection during battle. (Water)", "No Creature", "Water", "Earth", "1", "85", "9.4", "555", "941", "220", "3.8", "410", "600", "48", "92", "60", "85", "25", "90", "46", "19", "3.2", "160", "3.6", "180", "1.7", "85", "2.7", "2", "135", "2.8", "140", "Normal Move Tree", "Water Move Tree", "Earth Move Tree", "", "Medium", "20", "7", "1", "1", "0", "Tomaling", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_KRABKEN", "65", "Krabken", "It is rumored that if you roll a Krabken over, it will not be able to roll back up-right because of the weight of its helmet-like shell. (Water)", "Clawbster", "Water", "", "18", "31", "9", "481", "918", "170", "4", "370", "570", "31", "40", "22", "10", "22", "20", "25", "23", "3.2", "160", "3.6", "180", "1.8", "90", "2.7", "2", "135", "2.7", "135", "Normal Move Tree", "Water Move Tree", "", "", "Medium", "128", "7", "1", "1", "0", "Tortipous", "-1", "Tortipous", "-1"));
			Rows.Add( new TMMonstersRow("TM_CLAWBSTER", "66", "Clawbster", "Clawbster's shell is nearly impenetrable. It provides Clawbster an unrivaled form of defense. (Water)", "Clawlossal", "Water", "", "32", "42", "9", "492", "932", "200", "3.8", "390", "580", "41", "47", "32", "43", "25", "50", "35", "25", "3.2", "160", "3.6", "180", "1.8", "90", "2.7", "2", "135", "2.7", "135", "Normal Move Tree", "Water Move Tree", "", "", "Medium", "128", "7", "1", "1", "0", "Tortipous", "0", "Alistinker", "0"));
			Rows.Add( new TMMonstersRow("TM_CLAWLOSSAL", "67", "Clawlossal", "Although rare, a pinch from a Clawlossal can result in blood poisoning, if it doesn't crush your hand completely. (Water)", "No Creature", "Water", "", "1", "82", "9", "532", "901", "230", "3.5", "405", "580", "64", "75", "52", "64", "30", "100", "55", "28", "3.2", "160", "3.6", "180", "1.7", "85", "2.8", "2", "140", "2.6", "130", "Normal Move Tree", "Water Move Tree", "", "", "Medium", "20", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_LOTHEO", "68", "Lotheo", "Lotheo is known for its large ears. They provide Lotheo with an excellent sense of hearing and also act as rudders, allowing rapid change in direction. (Water)", "Hytheo", "Water", "", "36", "28", "9", "478", "936", "220", "4.5", "445", "670", "27", "26", "20", "16", "28", "25", "25", "40", "1.8", "90", "2.8", "140", "3.3", "165", "3.4", "2", "170", "3.4", "170", "Normal Move Tree", "Water Move Tree", "", "", "Medium", "120", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_HYTHEO", "69", "Hytheo", "Once upright and evolved, Hytheo becomes a fierce warrior of the sea. (Water)", "No Creature", "Water", "", "1", "60", "9", "510", "901", "240", "4", "440", "640", "46", "40", "30", "35", "56", "35", "50", "52", "1.7", "85", "2.8", "140", "3.3", "165", "3.4", "2", "170", "3.2", "160", "Normal Move Tree", "Water Move Tree", "", "", "Medium", "20", "7", "1", "1", "0", "Lothea", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_LOTHEA", "70", "Lothea", "Adorable Lothea love to splash and play on the beach all year long. (Water)", "Hythea", "Water", "", "36", "25", "9", "475", "936", "220", "4.5", "445", "670", "20", "24", "16", "14", "20", "25", "25", "34", "1.8", "90", "2.8", "140", "3.3", "165", "3.5", "2", "175", "3.4", "170", "Normal Move Tree", "Water Move Tree", "", "", "Medium", "120", "7", "1", "1", "0", "Lotheo", "-1", "Lothea", "-1"));
			Rows.Add( new TMMonstersRow("TM_HYTHEA", "71", "Hythea", "Once evolved, Hythea develop a deep motherly instinct and is fiercely protective of her youngs. (Water)", "No Creature", "Water", "", "1", "54", "9", "504", "901", "240", "4", "440", "640", "43", "38", "32", "33", "59", "35", "50", "55", "1.9", "95", "2.7", "135", "3.4", "170", "3.5", "2", "175", "3.3", "165", "Normal Move Tree", "Water Move Tree", "", "", "Medium", "20", "7", "1", "1", "0", "Lotheo", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_FLOWGO", "72", "Flowgo", "Flowgo pointy beak is sharp enough to pierce through small shells. (Water)", "Floatango", "Water", "", "14", "22", "9", "472", "914", "230", "4.5", "455", "680", "26", "25", "22", "22", "30", "15", "30", "35", "1.8", "90", "2.7", "135", "3.3", "165", "3.3", "2", "165", "3.3", "165", "Normal Move Tree", "Water Move Tree", "", "", "Medium", "140", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_FLOATANGO", "73", "Floatango", "Floatango's darkened feathers is coated with a special membrane that make it flame resistant. (Water)", "Flairmingo", "Water", "", "32", "38", "9", "488", "932", "250", "4", "450", "650", "38", "38", "33", "35", "50", "30", "42", "38", "1.9", "95", "2.7", "135", "3.3", "165", "3.3", "2", "165", "3.2", "160", "Normal Move Tree", "Water Move Tree", "", "", "Medium", "128", "7", "1", "1", "0", "Coralpie", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_FLAIRMINGO", "74", "Flairmingo", "Flairmingo's main weapon is it's long sharp beak. Tests have shown it can break 3 inch thick metal armor. (Water)", "No Creature", "Water", "", "1", "55", "10", "555", "1001", "270", "3.8", "460", "650", "48", "46", "44", "44", "59", "56", "50", "54", "1.8", "90", "2.8", "140", "3.4", "170", "3.4", "2", "170", "3.1", "155", "Normal Move Tree", "Water Move Tree", "", "", "Medium", "128", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_FLARMIAN", "75", "Flarmian", "A Flarmian colony will nest in moist soil next to a warm heat source. They will not attack unless provoked. (Fire)", "Firmitaur", "Fire", "", "26", "12", "9", "462", "926", "230", "4.2", "440", "650", "17", "15", "15", "12", "24", "40", "15", "20", "1.9", "95", "2.9", "145", "3.3", "165", "3.3", "2", "165", "3.3", "165", "Normal Move Tree", "Fire Move Tree", "", "", "Medium", "80", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_FIRMITAUR", "76", "Firmitaur", "After evolving,  Firmitaur will leave the colony. The extra strength it develops allows it to venture out alone. (Fire)", "Firenaught", "Fire", "", "42", "22", "9", "472", "942", "260", "3.8", "450", "640", "27", "25", "25", "22", "34", "40", "25", "30", "1.8", "90", "2.9", "145", "3.3", "165", "3.3", "2", "165", "3.2", "160", "Normal Move Tree", "Fire Move Tree", "", "", "Medium", "80", "7", "1", "1", "0", "Flarmian", "0", "Flarmian", "0"));
			Rows.Add( new TMMonstersRow("TM_FIRENAUGHT", "77", "Firenaught", "Firenaught's carapace thickens significantly and wings sprout after evolution. It has come a long way since it vunerable days as a Flarmian. (Fire)", "No Creature", "Fire", "Air", "1", "70", "9", "520", "901", "270", "3.5", "445", "620", "52", "78", "55", "75", "44", "80", "48", "38", "1.9", "95", "2.9", "145", "3.3", "165", "3.4", "2", "170", "3.1", "155", "Normal Move Tree", "Fire Move Tree", "Air Move Tree", "", "Medium", "128", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_SOOTIMANDER", "78", "Sootimander", "A Sootimander will curl into a ball and roll with the flames still alight to protect itself from larger opponents. (Fire)", "Sootiraptor", "Fire", "", "25", "26", "9", "476", "925", "180", "4.4", "400", "620", "35", "22", "29", "27", "18", "45", "29", "19", "3", "150", "3", "150", "3", "150", "3.1", "2", "155", "3.3", "165", "Normal Move Tree", "Fire Move Tree", "", "", "Medium", "80", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_SOOTIRAPTOR", "79", "Sootiraptor", "Its speed, size and furiosity allows it to take on much bigger foes. Sootiraptor goes into a frenzied state when it sense it is close to victory. (Fire)", "Sootragon", "Fire", "", "43", "56", "9", "506", "943", "200", "4", "400", "600", "57", "57", "47", "48", "38", "40", "39", "28", "3", "150", "3", "150", "3", "150", "3.1", "2", "155", "3.2", "160", "Normal Move Tree", "Fire Move Tree", "", "", "Medium", "128", "7", "1", "1", "0", "Swinx", "3", "Swinx", "3"));
			Rows.Add( new TMMonstersRow("TM_SOOTRAGON", "80", "Sootragon", "Sootragon is the king of the fire lizards. Its flames are blazing hot, and its tail and feet are capable of pounding stone to gravel. (Fire)", "No Creature", "Fire", "", "1", "105", "9.1", "560", "911", "230", "3.5", "405", "580", "75", "63", "55", "53", "45", "90", "60", "40", "3.1", "155", "3.2", "160", "3.2", "160", "3.1", "2", "155", "3.1", "155", "Normal Move Tree", "Fire Move Tree", "", "", "Medium", "128", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_FLAFFEE", "81", "Flaffee", "Flaffee stores heat in its tail and ears before transfering the heat to it's neck to generate a fire attack. (Fire)", "Igniraffe", "Fire", "", "24", "32", "9", "482", "924", "220", "4.5", "445", "670", "18", "18", "41", "42", "20", "34", "28", "22", "3", "150", "2.7", "135", "3.2", "160", "3", "2", "150", "3.2", "160", "Normal Move Tree", "Fire Move Tree", "", "", "Medium", "100", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_IGNIRAFFE", "82", "Igniraffe", "Igniraffe's long neck allows more oxygen to combust with the fire during an attack. This propels the temperature of its attacks to the high hundreds. (Fire)", "No Creature", "Fire", "", "1", "45", "9", "495", "901", "240", "4", "440", "640", "33", "34", "52", "51", "44", "60", "35", "15", "3.1", "155", "2.7", "135", "3.3", "165", "3", "2", "150", "3.1", "155", "Normal Move Tree", "Fire Move Tree", "", "", "Medium", "20", "7", "1", "1", "0", "Gazolt", "4", "Gazolt", "2"));
			Rows.Add( new TMMonstersRow("TM_SCORCHLING", "83", "Scorchling", "Scorchlings love to swim in lava. Their feathers are so adapted to heat that if they come into contact with water they can turn to ash. (Fire)", "Cinduck", "Fire", "Water", "36", "28", "9", "478", "936", "220", "4.5", "445", "670", "27", "26", "20", "16", "28", "25", "25", "40", "1.8", "90", "2.8", "140", "3.4", "170", "3.2", "2", "160", "3.3", "165", "Normal Move Tree", "Fire Move Tree", "Water Move Tree", "", "Medium", "120", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_CINDUCK", "84", "Cinduck", "Cinduck constantly migrates to warmer weather. A telltale sign of Cinduck migration routes are the ashes that it leaves in its wake fleeing from the cold.  (Fire)", "No Creature", "Fire", "Water", "1", "60", "9", "510", "901", "260", "4", "460", "660", "46", "40", "30", "35", "56", "35", "50", "52", "1.9", "95", "2.8", "140", "3.2", "160", "3.2", "2", "160", "3.1", "155", "Normal Move Tree", "Fire Move Tree", "Water Move Tree", "", "Medium", "20", "7", "1", "1", "0", "Flowgo", "0", "Scorchling", "0"));
			Rows.Add( new TMMonstersRow("TM_IGNITLER", "85", "Ignitler", "A newborn Ignitler is scared of their new flamed horns, but quickly adjust. The height of the flames are an indicator of its feelings. (Fire)", "Flamoose", "Fire", "", "20", "34", "9.1", "489", "930", "180", "4", "380", "580", "25", "24", "32", "31", "24", "34", "28", "22", "3.2", "160", "3.4", "170", "1.8", "90", "2.7", "2", "135", "3", "150", "Normal Move Tree", "Fire Move Tree", "", "", "Medium", "100", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_FLAMOOSE", "86", "Flamoose", "Rivaling Flamooses will flare their flamed horns in an attempt to intimidate opponents. Disputes are settled by this show of force to avoid injuries. (Fire)", "No Creature", "Fire", "", "1", "45", "9.1", "500", "911", "200", "3.8", "390", "580", "45", "45", "42", "42", "44", "50", "42", "10", "3.3", "165", "3.4", "170", "1.8", "90", "2.7", "2", "135", "3", "150", "Normal Move Tree", "Fire Move Tree", "", "", "Medium", "20", "7", "1", "1", "0", "Mothball", "-1", "", "0"));
			Rows.Add( new TMMonstersRow("TM_MANTICUB", "87", "Manticub", "Manticub tails contain both poison and electrical glands. These are used to disable their prey before eating them. (Electric)", "Manteri", "Electric", "", "43", "35", "9", "485", "943", "230", "4.2", "440", "650", "37", "26", "46", "39", "43", "42", "29", "45", "1.9", "95", "3", "150", "3", "150", "3.3", "2", "165", "3.3", "165", "Normal Move Tree", "Electric Move Tree", "", "", "Medium", "70", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_MANTERI", "88", "Manteri", "The bulb on Manteri's tail is used to distract its opponents before it strikes. (Electric)", "Amperor", "Electric", "", "57", "52", "9", "502", "957", "240", "3.8", "430", "620", "47", "39", "58", "46", "54", "50", "39", "55", "1.9", "95", "3.2", "160", "3", "150", "3.3", "2", "165", "3.2", "160", "Normal Move Tree", "Electric Move Tree", "", "", "Medium", "1", "7", "1", "1", "0", "Grynn", "0", "Grynn", "0"));
			Rows.Add( new TMMonstersRow("TM_AMPEROR", "89", "Amperor", "Amperor will often use its pincers to hold down an opponent before sending a devastating electric blast. (Electric)", "No Creature", "Electric", "", "1", "67", "9", "517", "901", "250", "3.5", "425", "600", "56", "47", "68", "59", "62", "100", "49", "65", "3.2", "160", "3.3", "165", "3", "150", "3.4", "2", "170", "3.1", "155", "Normal Move Tree", "Electric Move Tree", "Air Move Tree", "", "Medium", "40", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_AMPINT", "90", "Ampint", "Because of its size, Ampint does not climb trees often. It spends less than 5% of its time up treetops (Electric)", "Gorillamp", "Electric", "", "50", "43", "9.1", "498", "960", "190", "4.2", "400", "610", "42", "41", "20", "18", "20", "30", "31", "51", "3.2", "160", "3.3", "165", "1.9", "95", "2.9", "2", "145", "3", "150", "Normal Move Tree", "Electric Move Tree", "", "", "Medium", "80", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_GORILLAMP", "91", "Gorillamp", "Gorillamp will beat its chest, generating waves of electricity in the process, as a warning before attacking. (Electric)", "No Creature", "Electric", "", "1", "88", "9.5", "563", "951", "220", "3.7", "405", "590", "81", "84", "28", "36", "35", "40", "47", "61", "3.3", "165", "3.2", "160", "1.9", "95", "2.9", "2", "145", "2.9", "145", "Normal Move Tree", "Electric Move Tree", "", "", "Medium", "100", "7", "1", "1", "0", "Gazolt", "0", "Riffin", "0"));
			Rows.Add( new TMMonstersRow("TM_JOLTERMITE", "92", "Joltermite", "A colony of Joltermites will produce static storm clouds to confuse its opponents. Often, human gadgets short circuit when exposed to these static storms. (Electric)", "Voltermite", "Electric", "", "25", "16", "9", "466", "925", "240", "4.8", "480", "720", "16", "21", "26", "21", "40", "10", "36", "35", "1.8", "90", "2.7", "135", "3.1", "155", "3.4", "2", "170", "3.5", "175", "Normal Move Tree", "Electric Move Tree", "", "", "Medium", "128", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_VOLTERMITE", "93", "Voltermite", "The windows on Voltermite shells reveal its electric inner core. When angry, electrical flares erupt from these ports. (Electric)", "No Creature", "Electric", "", "1", "32", "9", "482", "901", "270", "4.5", "495", "720", "30", "32", "35", "25", "59", "50", "47", "55", "1.9", "95", "2.7", "135", "3.1", "155", "3.5", "2", "175", "3.3", "165", "Normal Move Tree", "Electric Move Tree", "", "", "Medium", "128", "7", "1", "1", "0", "Joltermite", "0", "Joltermite", "0"));
			Rows.Add( new TMMonstersRow("TM_GEKOWATT", "94", "Gekowatt", "Gekowatts are so small cunning and fast that you can only see them if they want to be seen. (Electric)", "No Creature", "Electric", "", "1", "30", "9.1", "485", "911", "240", "4.2", "450", "660", "30", "40", "55", "40", "55", "60", "70", "71", "1.7", "85", "3.2", "160", "3.2", "160", "3.2", "2", "160", "3.2", "160", "Normal Move Tree", "Electric Move Tree", "", "", "Medium", "40", "7", "1", "1", "0", "Joltermite", "-1", "Joltermite", "-1"));
			Rows.Add( new TMMonstersRow("TM_GAZOLT", "95", "Gazolt", "In addition to leaping and running, Gazolts leave tiny electric jolts in the path behind them to deter predators from chasing it. (Electric)", "Volteer", "Electric", "", "38", "31", "9", "481", "938", "230", "4.5", "455", "680", "18", "18", "27", "27", "34", "42", "29", "33", "1.9", "95", "2.9", "145", "3.2", "160", "3.2", "2", "160", "3.5", "175", "Normal Move Tree", "Electric Move Tree", "", "", "Medium", "80", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_VOLTEER", "96", "Volteer", "Volteers are charged so full of electricity that their streaks glow blue. The brightness of the blue is dependent on their mood. (Electric)", "Shadowvolt", "Electric", "", "48", "37", "9", "487", "948", "260", "4.3", "475", "690", "28", "33", "40", "36", "48", "42", "38", "35", "1.9", "95", "2.9", "145", "3.2", "160", "3.3", "2", "165", "3.4", "170", "Normal Move Tree", "Electric Move Tree", "", "", "Medium", "40", "7", "1", "1", "0", "Brak", "0", "Bananteater", "0"));
			Rows.Add( new TMMonstersRow("TM_SHADOWVOLT", "97", "Shadowvolt", "Shadowvolt was originally categorized as an Arcane type because Scientists were so convinced that its speed was supernatural. (Electricity)", "No Creature", "Electric", "", "1", "80", "9.5", "555", "951", "290", "4.1", "495", "700", "50", "44", "55", "53", "70", "90", "60", "60", "3.1", "155", "3", "150", "3.3", "165", "3.3", "2", "165", "3.3", "165", "Normal Move Tree", "Electric Move Tree", "", "", "Medium", "128", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_RIFFIN", "98", "Riffin", "Riffin has a very inquisitive nature. It is uncommon to see Riffin interact with Humans, making it one of the most beloved Terram Monsters. (Electric)", "Riffindor", "Electric", "Air", "31", "25", "9", "475", "931", "180", "4", "380", "580", "20", "25", "24", "26", "33", "30", "31", "44", "1.9", "95", "3", "150", "3", "150", "3.2", "2", "160", "3.4", "170", "Normal Move Tree", "Electric Move Tree", "Air Move Tree", "", "Medium", "80", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_RIFFINDOR", "99", "Riffindor", "Despite its size, Riffindor are excellent flyers. Its speed and agilty will surprise most of its foes. (Electric)", "No Creature", "Electric", "Air", "1", "35", "9", "485", "901", "200", "3.7", "385", "570", "42", "41", "43", "49", "75", "42", "34", "71", "1.9", "95", "3", "150", "3.2", "160", "3.3", "2", "165", "3.3", "165", "Normal Move Tree", "Electric Move Tree", "Air Move Tree", "", "Medium", "20", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_SHINO", "100", "Shino", "Shino's horn is made of keratin, the same type of protein that makes up hair and fingernails. (Earth)", "Rhiyew", "Earth", "", "26", "50", "9", "500", "926", "170", "3.8", "360", "550", "50", "48", "15", "30", "50", "20", "35", "5", "3.4", "170", "3.5", "175", "1.8", "90", "2.8", "2", "140", "2.8", "140", "Normal Move Tree", "Earth Move Tree", "", "", "Medium", "90", "7", "1", "1", "0", "Electripine", "0", "Brak", "0"));
			Rows.Add( new TMMonstersRow("TM_RHIYEW", "101", "Rhiyew", "Rhiyew's bad temper makes it very unpredictable. It is prone to charge at the slightly sign of danger. (Earth)", "No Creature", "Earth", "", "1", "105", "9", "555", "901", "220", "3.3", "385", "550", "67", "69", "26", "52", "64", "50", "49", "18", "3.5", "175", "3.5", "175", "1.8", "90", "2.8", "2", "140", "2.7", "135", "Normal Move Tree", "Earth Move Tree", "", "", "Medium", "128", "7", "1", "1", "0", "Riffin", "-1", "Riffin", "-1"));
			Rows.Add( new TMMonstersRow("TM_SAPPRESS", "102", "Sappress", "A common misconception is that Sapress will lose its leaves when there is a change seasons. Its leaves will just simply change colors. (Earth) ", "Oaklore", "Earth", "", "24", "35", "9.3", "500", "954", "180", "3.9", "375", "570", "42", "60", "25", "45", "9", "20", "35", "9", "3.5", "175", "3.4", "170", "1.8", "90", "2.7", "2", "135", "2.5", "125", "Normal Move Tree", "Earth Move Tree", "", "", "Medium", "80", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_OAKLORE", "103", "Oaklore", "Oaklore possesses a spiritual link to Nature. It is sensitive to any abrupt changes to the seasons. (Earth)", "No Creature", "Earth", "Arcane", "1", "50", "9.3", "515", "931", "220", "3.3", "385", "550", "42", "60", "25", "45", "5", "40", "35", "5", "3.4", "170", "3.4", "170", "1.8", "90", "2.7", "2", "135", "2.2", "110", "Normal Move Tree", "Earth Move Tree", "Arcane Move Tree", "", "Medium", "20", "7", "1", "1", "0", "Racket", "0", "Racket", "0"));
			Rows.Add( new TMMonstersRow("TM_SWINX", "104", "Swinx", "Swinx does not flap their entire forelimbs, as birds do, but instead flap their spread-out digits, which are very long and covered with a thin membrane. (Air)", "Sonax", "Air", "Arcane", "30", "18", "9", "468", "930", "200", "4.3", "415", "630", "19", "20", "16", "12", "24", "34", "29", "22", "3.2", "160", "2.7", "135", "3.2", "160", "3.3", "2", "165", "3.5", "175", "Normal Move Tree", "Arcane Move Tree", "Air Move Tree", "", "Medium", "100", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_SONAX", "105", "Sonax", "Sonax is a master of echolocation. It produces ultrasonic sounds to pinpoint its opponents. At 130 decibels, Sonax's calls are some of the most intense sounds in Terrarium. (Air)", "No Creature", "Air", "Arcane", "1", "36", "9", "486", "901", "240", "4", "440", "640", "26", "38", "38", "30", "43", "46", "45", "44", "3.2", "160", "2.7", "135", "3.3", "165", "3.4", "2", "170", "3.3", "165", "Normal Move Tree", "Arcane Move Tree", "Air Move Tree", "", "Medium", "20", "7", "1", "1", "0", "Swinx", "0", "Swinx", "0"));
			Rows.Add( new TMMonstersRow("TM_SHRIKEN", "106", "Shriken", "Shriken is incredibly stealthy. An opponent won't know when Shriken is attacking until it's too late. (Air)", "Jastrike", "Air", "", "32", "34", "9", "484", "932", "220", "4", "420", "620", "23", "39", "32", "30", "38", "34", "32", "38", "3", "150", "3", "150", "3", "150", "3", "2", "150", "3", "150", "Normal Move Tree", "Air Move Tree", "", "", "Medium", "80", "7", "1", "1", "0", "Swinx", "-1", "Swinx", "-1"));
			Rows.Add( new TMMonstersRow("TM_JASTRIKE", "107", "Jastrike", "After evolving, a Jastrike becomes less stealthy but will gain more armor and attack strength as compensation. (Air)", "No Creature", "Air", "", "1", "45", "9", "495", "901", "240", "3.9", "435", "630", "31", "52", "41", "40", "48", "60", "44", "49", "3", "150", "3", "150", "3.2", "160", "3", "2", "150", "2.9", "145", "Normal Move Tree", "Air Move Tree", "", "", "Medium", "128", "7", "1", "1", "0", "Brak", "0", "Shriken", "0"));
			Rows.Add( new TMMonstersRow("TM_HOODWINK", "108", "Hoodwink", "Hoodwink shows remarkable intelligence. It can often be seen tricking its way to an easy meal. (Air)", "Robbinghood", "Air", "Arcane", "23", "21", "9", "471", "923", "180", "4.5", "405", "630", "19", "29", "22", "28", "32", "30", "30", "24", "3", "150", "2.8", "140", "3", "150", "3.3", "2", "165", "2.9", "145", "Normal Move Tree", "Air Move Tree", "Arcane Move Tree", "", "Medium", "80", "7", "1", "1", "0", "Shriken", "-1", "Shriken", "-1"));
			Rows.Add( new TMMonstersRow("TM_ROBBINGHOOD", "109", "Robbinghood", "Robbinghood have a natural tendency to burglarize smaller Terra Monsters for their food. Terra Ranchers have also reported cases of Robbinghoods snatching shiny trinkets. (Air)", "Vilewing", "Air", "Arcane", "37", "38", "9", "488", "937", "200", "4", "400", "600", "21", "41", "25", "39", "49", "50", "40", "42", "3", "150", "2.7", "135", "3.3", "165", "3.3", "2", "165", "2.8", "140", "Normal Move Tree", "Air Move Tree", "Arcane Move Tree", "", "Medium", "128", "7", "1", "1", "0", "Hoodwink", "0", "Hoodwink", "0"));
			Rows.Add( new TMMonstersRow("TM_VILEWING", "110", "Vilewing", "With its dark hood and mysterious nature, Vilewing is known as the \"Executioner of The Skies\". (Air)", "No Creature", "Air", "Arcane", "1", "52", "9", "502", "901", "240", "3.8", "430", "620", "42", "66", "49", "62", "60", "60", "62", "53", "3", "150", "2.7", "135", "3.4", "170", "3.3", "2", "165", "2.7", "135", "Normal Move Tree", "Air Move Tree", "Arcane Move Tree", "", "Medium", "19", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_YANTIS", "111", "Yantis", "How Yantis' little wings support its heavy weight is still a mystery. Yantis has been trained in Skyward City to be their air transportation. (Air)", "Buntis", "Air", "", "39", "55", "9", "505", "939", "180", "3.9", "375", "570", "32", "52", "20", "50", "16", "33", "39", "16", "3.5", "175", "3.6", "180", "1.7", "85", "2.7", "2", "135", "2.8", "140", "Normal Move Tree", "Air Move Tree", "", "", "Medium", "70", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_BUNTIS", "112", "Buntis", "Buntis is the heaviest flying Terra Monster in Terrarium. Despite its weight, Buntis can effortlessly take off and land without exerting much energy. (Air)", "No Creature", "Air", "", "1", "105", "9", "555", "901", "220", "3.5", "395", "570", "48", "76", "41", "68", "24", "50", "49", "25", "3.5", "175", "3.6", "180", "1.7", "85", "2.7", "2", "135", "2.7", "135", "Normal Move Tree", "Air Move Tree", "", "", "Medium", "128", "7", "1", "1", "0", "Yantis", "-2", "Yantis", "2"));
			Rows.Add( new TMMonstersRow("TM_HOOTENANT", "113", "Hootenant", "Hootenant is cunning and analytical. It never attacks without a plan already mapped out in its head. (Air)", "Generowl", "Air", "", "42", "28", "9", "478", "942", "220", "4.4", "440", "660", "14", "24", "16", "14", "20", "45", "45", "34", "3.2", "160", "3.1", "155", "3.2", "160", "2.9", "2", "145", "3", "150", "Normal Move Tree", "Air Move Tree", "", "", "Medium", "70", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_GENEROWL", "114", "Generowl", "Generowl is a minds are keen, and full of both tactical and strategic advice for those who are willing to pay attention. (Air)", "No Creature", "Air", "", "1", "48", "10", "548", "1001", "240", "4.2", "450", "660", "74", "55", "26", "45", "35", "50", "72", "45", "3.2", "160", "3.1", "155", "3.2", "160", "2.9", "2", "145", "2.9", "145", "Normal Move Tree", "Air Move Tree", "", "", "Medium", "128", "7", "1", "1", "0", "Tomahawk", "0", "Hoodwink", "0"));
			Rows.Add( new TMMonstersRow("TM_SOARPHIN", "115", "Soarphin", "Soarphins spend most of their time in water. When they gather enough speed they can jump out of the water and gain altitude. (Water / Air)", "Halophin", "Water", "Air", "35", "30", "9", "480", "935", "240", "4.6", "470", "700", "32", "31", "37", "36", "40", "34", "41", "41", "1.8", "90", "2.7", "135", "3.3", "165", "3.3", "2", "165", "3.6", "180", "Normal Move Tree", "Air Move Tree", "Water Move Tree", "", "Medium", "128", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_HALOPHIN", "116", "Halophin", "Halophins wings are so big and powerful that they can spend longer in the sky than Soarphins, however they must return to water to breath. (Water / Air)", "No Creature", "Water", "Air", "1", "55", "9", "505", "901", "260", "4.2", "470", "680", "52", "44", "50", "45", "76", "45", "52", "61", "1.8", "90", "2.7", "135", "3.2", "160", "3.3", "2", "165", "3.4", "170", "Normal Move Tree", "Air Move Tree", "Water Move Tree", "", "Medium", "20", "7", "1", "1", "0", "Krabken", "5", "Krabken", "5"));
			Rows.Add( new TMMonstersRow("TM_SNOWYRM", "117", "Snowyrm", "Snowyrm digs beneath the crust to the powdered snow with its two sharp mandibles. There, it lies in wait for prey. (Ice)", "Ragewyrm", "Ice", "", "43", "20", "9", "470", "943", "150", "5", "400", "650", "15", "20", "15", "20", "18", "100", "20", "22", "1.8", "90", "2.8", "140", "1.8", "90", "3.2", "2", "160", "3", "150", "Normal Move Tree", "Ice Move Tree", "", "", "Medium", "50", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_RAGEWYRM", "118", "Ragewyrm", "The reknowned Ragewyrm is elusive and very dangerous. If you find signs of its mighty coils in the snow, its already too late. (Ice)", "No Creature", "Ice", "Air", "1", "85", "9", "535", "901", "180", "3", "330", "480", "83", "67", "83", "63", "62", "300", "57", "70", "3.4", "170", "3.5", "175", "3.4", "170", "3.4", "2", "170", "2.8", "140", "Normal Move Tree", "Ice Move Tree", "Air Move Tree", "", "Medium", "1", "7", "1", "1", "0", "Snowyrm", "0", "Oarion", "0"));
			Rows.Add( new TMMonstersRow("TM_OARION", "119", "Oarion", "Despite its size and shape, Oarion can swim eight times faster than anything its size. (Ice)", "No Creature", "Ice", "", "1", "40", "9", "490", "901", "200", "3.9", "395", "590", "35", "34", "45", "36", "29", "48", "40", "41", "3.2", "160", "3.2", "160", "3.2", "160", "2.8", "2", "140", "3.1", "155", "Normal Move Tree", "Ice Move Tree", "", "", "Medium", "80", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_URSNOBAL", "120", "Ursnobal", "Ursnobal sense of smell is so strong that it can smell an Alistinker from anywhere in Terrarium. (Ice)", "Ursicle", "Ice", "", "36", "50", "9", "500", "936", "180", "4.3", "395", "610", "45", "59", "39", "54", "28", "40", "50", "30", "3.3", "165", "3.1", "155", "3.1", "155", "2.9", "2", "145", "3.2", "160", "Normal Move Tree", "Ice Move Tree", "", "", "Medium", "75", "7", "1", "1", "0", "Oarion", "0", "Sprew", "0"));
			Rows.Add( new TMMonstersRow("TM_URSICLE", "121", "Ursicle", "Ursicle's head is so hard that they can ram through most icebergs. (Ice)", "Urstorm", "Ice", "", "52", "68", "9", "518", "952", "200", "4", "400", "600", "68", "65", "58", "55", "35", "32", "58", "38", "3.3", "165", "3.1", "155", "3.1", "155", "3.1", "2", "155", "3.1", "155", "Normal Move Tree", "Ice Move Tree", "", "", "Medium", "30", "7", "1", "1", "0", "Oarion", "10", "Oarion", "5"));
			Rows.Add( new TMMonstersRow("TM_URSTORM", "122", "Urstorm", "Urstorm is a solitary Terra Monster, choosing to roam the Artic alone. Once a year it will reconvene with other Urstorms to breed. (Ice)", "No Creature", "Ice", "", "1", "78", "9", "528", "901", "240", "3.8", "430", "620", "79", "75", "68", "70", "45", "100", "68", "42", "3.3", "165", "3.2", "160", "3.3", "165", "3.3", "2", "165", "3", "150", "Normal Move Tree", "Ice Move Tree", "", "", "Medium", "50", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_YETICRAB", "123", "Yeticrab", "During warmer weather when ice floes break and foraging is impossible, Yeticrab will hibernate until the next Winter season. Waking up a Yeticrab during hibernation is not advised. (Ice)", "Yeticlaw", "Ice", "", "44", "48", "9", "498", "944", "180", "4.4", "400", "620", "49", "43", "31", "33", "21", "45", "31", "14", "3.4", "170", "3.2", "160", "1.7", "85", "3.3", "2", "165", "3.2", "160", "Normal Move Tree", "Ice Move Tree", "", "", "Medium", "60", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_YETICLAW", "124", "Yeticlaw", "After evolving, a Yeticlaw will shed most of its blubber, allowing it to travel to warmer environments without fear of overheating. (Ice)", "Yetiking", "Ice", "", "57", "58", "9", "508", "957", "200", "3.9", "395", "590", "61", "52", "41", "43", "31", "45", "45", "24", "3.4", "170", "3.3", "165", "1.8", "90", "3", "2", "150", "3.1", "155", "Normal Move Tree", "Ice Move Tree", "", "", "Medium", "20", "7", "1", "1", "0", "Krabken", "0", "Ursnobal", "0"));
			Rows.Add( new TMMonstersRow("TM_YETIKING", "125", "Yetiking", "Many of the legends about abomidable snowmen come from Yetiking's wandering of the frozen wastelands. (Ice)", "No Creature", "Ice", "", "1", "85", "9", "535", "901", "240", "3.5", "415", "590", "75", "62", "61", "53", "35", "80", "56", "23", "3.4", "170", "3.4", "170", "1.8", "90", "3", "2", "150", "3", "150", "Normal Move Tree", "Ice Move Tree", "", "", "Medium", "70", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_TURANOM", "126", "Turanom", "Turanoms huddles together for warmth during harsh winter storms. They shimmy back and forth to generate heat. (Ice)", "Pendrill", "Ice", "", "41", "32", "9", "482", "941", "200", "4.6", "430", "660", "37", "32", "23", "27", "10", "40", "24", "20", "3.2", "160", "2.8", "140", "3.2", "160", "3.1", "2", "155", "3", "150", "Normal Move Tree", "Ice Move Tree", "", "", "Medium", "80", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_PENDRILL", "127", "Pendrill", "Pendrill is an expert ice fisher. It will drill a hole through the ice and peck out fish as they swim by. (Ice) ", "Chillbeak", "Ice", "", "53", "43", "9", "493", "953", "220", "4.2", "430", "640", "52", "50", "40", "46", "22", "50", "40", "37", "3.3", "165", "3", "150", "3.3", "165", "3.2", "2", "160", "2.9", "145", "Normal Move Tree", "Ice Move Tree", "", "", "Medium", "40", "7", "1", "1", "0", "Coralpie", "0", "Octicute", "0"));
			Rows.Add( new TMMonstersRow("TM_CHILLBEAK", "128", "Chillbeak", "The material on Chillbeak's drills are yet to be identified. It is believed that the drill freezes the material it comes in contact with making it easier to pierce. (Ice)", "No Creature", "Ice", "", "1", "73", "9", "523", "901", "260", "3.8", "450", "640", "66", "70", "52", "52", "28", "80", "44", "57", "3.2", "160", "3.3", "165", "3.4", "170", "3.3", "2", "165", "2.8", "140", "Normal Move Tree", "Ice Move Tree", "", "", "Medium", "1", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_OCTICUTE", "129", "Octicute", "Octicute draws in its prey with the bright glow from its head. A milisecond before Octicutes strike the glow flashes red. (Ice)", "Tentapulse", "Ice", "Electric", "26", "31", "9", "481", "926", "230", "4.8", "470", "710", "44", "38", "15", "18", "49", "22", "33", "51", "1.8", "90", "2.5", "125", "3.4", "170", "3.5", "2", "175", "3.3", "165", "Normal Move Tree", "Ice Move Tree", "Electric Move Tree", "", "Medium", "50", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_TENTAPULSE", "130", "Tentapulse", "When Tentapulse's heart beat, it discharges electricity in a 2 meter radius. (Ice)", "No Creature", "Ice", "Electric", "1", "59", "9", "509", "901", "260", "4.5", "485", "710", "65", "56", "45", "37", "59", "40", "54", "72", "1.8", "90", "2.5", "125", "3.5", "175", "3.5", "2", "175", "3.2", "160", "Normal Move Tree", "Ice Move Tree", "Electric Move Tree", "", "Medium", "20", "7", "1", "1", "0", "Scuda", "0", "Scuda", "0"));
			Rows.Add( new TMMonstersRow("TM_ODDCAT", "131", "Oddcat", "Is it alive or undead? Stuffed or full of living tissue? Terrarium scientists have yet to uncover the mystery. (Arcane)", "Pinclaw", "Arcane", "", "21", "15", "9", "465", "921", "220", "4.7", "455", "690", "9", "51", "12", "29", "10", "20", "24", "10", "1.7", "85", "2.7", "135", "3.4", "170", "3.4", "2", "170", "3.1", "155", "Normal Move Tree", "Arcane Move Tree", "", "", "Medium", "80", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_PINCLAW", "132", "Pinclaw", "Pinclaws lumber about, often in the dead of night, terrorizing children. They also have been seen in dreams and nightmares. (Arcane)", "Quirkat", "Arcane", "", "39", "28", "9", "478", "939", "240", "4.5", "465", "690", "20", "75", "32", "50", "24", "60", "40", "31", "1.7", "85", "2.7", "135", "3.4", "170", "3.4", "2", "170", "3", "150", "Normal Move Tree", "Arcane Move Tree", "", "", "Medium", "1", "7", "1", "1", "0", "Snozo", "0", "Snozo", "0"));
			Rows.Add( new TMMonstersRow("TM_QUIRKAT", "133", "Quirkat", "The third eye of the Quirkat is said to bestow supernatural powers on it, allowing it to posess others. (Arcane)", "No Creature", "Arcane", "", "1", "46", "9", "496", "901", "270", "4.2", "480", "690", "38", "96", "68", "70", "37", "55", "51", "44", "1.8", "90", "2.7", "135", "3.5", "175", "3.5", "2", "175", "2.9", "145", "Normal Move Tree", "Arcane Move Tree", "", "", "Medium", "128", "7", "1", "1", "0", "Oddcat", "-1", "Oddcat", "-1"));
			Rows.Add( new TMMonstersRow("TM_GRYNN", "134", "Grynn", "Grynn's bubbly appearance mask the dark demeanor it possesses. (Arcane)", "Heckyll", "Arcane", "", "40", "20", "9", "470", "940", "180", "4", "380", "580", "26", "19", "29", "16", "32", "40", "22", "43", "3.4", "170", "3.4", "170", "1.9", "95", "2.8", "2", "140", "3.3", "165", "Normal Move Tree", "Arcane Move Tree", "", "", "Medium", "70", "7", "1", "0", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_HECKYLL", "135", "Heckyll", "The dark fur continues to corrupt the Heckyll's coat after it evolves. It's said its heart grows darker as well. (Arcane)", "Cackyll", "Arcane", "", "53", "36", "9", "486", "953", "200", "3.8", "390", "580", "39", "29", "42", "29", "43", "50", "28", "49", "3.3", "165", "3.5", "175", "1.9", "95", "3", "2", "150", "3.2", "160", "Normal Move Tree", "Arcane Move Tree", "", "", "Medium", "128", "7", "1", "1", "0", "Hoodwink", "2", "Hoodwink", "2"));
			Rows.Add( new TMMonstersRow("TM_CACKYLL", "136", "Cackyll", "Wild and vicious, Cackylls are expert stalkers that blend effortlessly into the shadows. (Arcane)", "No Creature", "Arcane", "", "1", "90", "9", "540", "901", "240", "3.5", "415", "590", "57", "53", "61", "56", "67", "100", "39", "62", "3.4", "170", "3.5", "175", "3.2", "160", "3.2", "2", "160", "3.1", "155", "Normal Move Tree", "Arcane Move Tree", "", "", "Medium", "128", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_STARIA", "137", "Staria", "In ancient times, Staria was worshipped as a diety that bestowed its followers with arcane powers. (Arcane)", "Celestail", "Arcane", "", "30", "28", "9", "478", "930", "210", "4.5", "435", "660", "20", "20", "36", "36", "34", "45", "29", "32", "1.8", "90", "2.7", "135", "3.3", "165", "3.3", "2", "165", "3.2", "160", "Normal Move Tree", "Arcane Move Tree", "", "", "Medium", "80", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_CELESTAIL", "138", "Celestail", "Celestail has an incredibly flexible backbone which allows it to orient itself in midair. It will always land on feets unless knocked unconscious. (Arcane)", "Celestroah", "Arcane", "", "44", "40", "9", "490", "944", "230", "4", "430", "630", "31", "32", "53", "57", "48", "55", "38", "43", "1.8", "90", "2.7", "135", "3.3", "165", "3.3", "2", "165", "3.1", "155", "Normal Move Tree", "Arcane Move Tree", "", "", "Medium", "80", "7", "1", "1", "0", "Shriken", "8", "Shriken", "8"));
			Rows.Add( new TMMonstersRow("TM_CELESTROAH", "139", "Celestroah", "Celestroah spends a majority of their time grooming itself. It is immaculately clean for a Terra Monster. (Arcane)", "No Creature", "Arcane", "", "1", "85", "9", "535", "901", "250", "3.6", "430", "610", "44", "47", "76", "72", "53", "70", "49", "54", "1.8", "90", "2.7", "135", "3.4", "170", "3.4", "2", "170", "3", "150", "Normal Move Tree", "Arcane Move Tree", "", "", "Medium", "128", "7", "1", "1", "0", "Staria", "-1", "Staria", "-1"));
			Rows.Add( new TMMonstersRow("TM_SPOOMPKIN", "140", "Spoompkin", "Spoompkin floats around aimlessly, or so it would have us believe... (Arcane)", "No Creature", "Arcane", "", "1", "30", "10", "530", "1001", "220", "3.7", "405", "590", "15", "45", "15", "35", "30", "20", "70", "30", "3.2", "160", "3.2", "160", "3.2", "160", "3.2", "2", "160", "3.2", "160", "Normal Move Tree", "Arcane Move Tree", "", "", "Medium", "70", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_FOXPAW", "141", "Foxpaw", "Foxpaws are full of mischief, and surrounded by tales of magic, mystery and mayhem. Terra Ranchers who've caught one are often said to be super lucky. (Arcane)", "Pranktail", "Arcane", "", "26", "20", "9", "470", "926", "220", "4.6", "450", "680", "18", "24", "20", "25", "25", "40", "28", "40", "1.8", "90", "2.8", "140", "3.4", "170", "3.4", "2", "170", "3.4", "170", "Normal Move Tree", "Arcane Move Tree", "", "", "Medium", "50", "7", "1", "1", "0", "Hoodwink", "10", "Hoodwink", "15"));
			Rows.Add( new TMMonstersRow("TM_PRANKTAIL", "142", "Pranktail", "Old stories say that Pranktails were once single tailed and simple. It was the gods of pranks and mischief that gave it the extra tail and its mysterious powers--just to see what would happen. (Arcane)", "Jestar", "Arcane", "", "38", "34", "9", "484", "938", "240", "4.2", "450", "660", "22", "26", "30", "35", "45", "80", "41", "67", "1.8", "90", "2.8", "140", "3.4", "170", "3.4", "2", "170", "3.3", "165", "Normal Move Tree", "Arcane Move Tree", "", "", "Medium", "1", "7", "1", "1", "0", "Oddcat", "3", "Oddcat", "2"));
			Rows.Add( new TMMonstersRow("TM_JESTAR", "143", "Jestar", "The prank-loving Jestars are so nimble, legend says they often teleport around the forest at night, driving their pursuers mad. (Arcane)", "No Creature", "Arcane", "", "1", "48", "9", "498", "901", "260", "3.8", "450", "640", "34", "32", "43", "41", "55", "200", "60", "87", "1.8", "90", "2.8", "140", "3.5", "175", "3.5", "2", "175", "3.1", "155", "Normal Move Tree", "Arcane Move Tree", "", "", "Medium", "1", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_PEACHIC", "144", "Peachic", "Peachic tend to stay very close to its mother. While it can read the thoughts of others, it can't defend itself physically. (Arcane)", "Peacane", "Arcane", "", "44", "15", "9", "465", "944", "220", "4.7", "455", "690", "14", "40", "20", "21", "10", "40", "21", "25", "1.9", "95", "2.6", "130", "3.4", "170", "3.4", "2", "170", "3.4", "170", "Normal Move Tree", "Arcane Move Tree", "", "", "Medium", "80", "7", "0", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_PEACANE", "145", "Peacane", "Peacane is said to be able to tap into the bonding network between a Terra Rancher and its Terra Monster. (Arcane)", "Peaqueen", "Arcane", "", "54", "28", "9", "478", "954", "230", "4.5", "455", "680", "34", "43", "51", "56", "24", "80", "45", "41", "1.9", "95", "2.6", "130", "3.4", "170", "3.4", "2", "170", "3.3", "165", "Normal Move Tree", "Arcane Move Tree", "", "", "Medium", "1", "7", "0", "1", "0", "Dozer", "0", "Peachic", "0"));
			Rows.Add( new TMMonstersRow("TM_PEAQUEEN", "146", "Peaqueen", "Peaqueen is able to block the mental bond a Terra Rancher has with its Terra Monster. This leaves its Terra Monster stunned and disoriented (Arcane)", "No Creature", "Arcane", "", "1", "51", "9.1", "506", "911", "240", "4.2", "450", "660", "42", "61", "78", "60", "45", "120", "51", "44", "1.9", "95", "2.6", "130", "3.5", "175", "3.4", "2", "170", "3.2", "160", "Normal Move Tree", "Arcane Move Tree", "", "", "Medium", "128", "7", "0", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_DOZER", "147", "Dozer", "Dozer is named after its love of napping and ability to dig. There's only one thing that Dozer loves more than napping: sleeping. (Earth)", "No Creature", "Earth", "", "1", "50", "10", "550", "1001", "180", "3.8", "370", "560", "45", "85", "20", "85", "5", "47", "25", "10", "3.4", "170", "3.5", "175", "1.5", "75", "2.7", "2", "135", "2.5", "125", "Normal Move Tree", "Earth Move Tree", "", "", "Medium", "50", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_PYRODILUS", "148", "Pyrodilus", "Pyrodilus inner core is completely revealed. It is only protected by its armored skin. It's anatomy is unique and mesmerizing. (Fire)", "No Creature", "Fire", "", "1", "81", "10", "581", "1001", "190", "3.8", "380", "570", "51", "82", "34", "36", "20", "71", "41", "20", "3.4", "170", "3.6", "180", "1.8", "90", "3", "2", "150", "2.5", "125", "Normal Move Tree", "Fire Move Tree", "", "", "Medium", "20", "7", "1", "1", "0", "Moxtail", "3", "Wolvus", "3"));
			Rows.Add( new TMMonstersRow("TM_ELECTROSAURUS", "149", "Electrosaurus", "Electrosaurus has one of the most unique heads in Terrarium. Scientists are still unsure if it serves any purpose. (Electric / Earth)", "Galavannis", "Electric", "", "23", "35", "9", "485", "923", "180", "4", "380", "580", "42", "60", "25", "45", "9", "20", "35", "9", "3.3", "165", "3.2", "160", "3.2", "160", "3.2", "2", "160", "3", "150", "Normal Move Tree", "Electric Move Tree", "", "", "Medium", "80", "7", "1", "1", "0", "Strutwind", "0", "Tortitank", "0"));
			Rows.Add( new TMMonstersRow("TM_GALAVANNIS", "150", "Galavannis", "Galavannis are highly active in the day time. The glowing streaks on its body are huge disadvantages during the night. (Electric / Earth)", "No Creature", "Electric", "", "1", "71", "9", "521", "901", "220", "3.5", "395", "570", "72", "71", "61", "62", "61", "71", "62", "71", "3.2", "160", "3.4", "170", "3.5", "175", "3.4", "2", "170", "2.8", "140", "Normal Move Tree", "Electric Move Tree", "", "", "Medium", "1", "7", "1", "1", "0", "No Creature", "0", "Ignitler", "5"));
			Rows.Add( new TMMonstersRow("TM_SHARKUIT", "151", "Sharkuit", "Sharkuits are one of the most powerful and cowardly Terra Monsters, even though they have vast strength they will want to run from any battle. (Water / Electric)", "Sharkbyte", "Water", "Electric", "51", "31", "9.2", "491", "971", "180", "4.5", "405", "630", "33", "25", "40", "28", "37", "31", "34", "32", "3.1", "155", "3.3", "165", "3.3", "165", "3.3", "2", "165", "3.3", "165", "Normal Move Tree", "Electric Move Tree", "Water Move Tree", "", "Medium", "128", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_SHARKBYTE", "152", "Sharkbyte", "Once a Sharkuit realises its strength it evolves into Sharkbyte. Sharkbyte loves to destroy its opponents in battle. (Water / Electric)", "Makowatt", "Water", "Electric", "62", "42", "9.2", "502", "982", "200", "4", "400", "600", "45", "45", "41", "42", "41", "51", "51", "42", "3.2", "160", "3.3", "165", "3.4", "170", "3.3", "2", "165", "3.2", "160", "Normal Move Tree", "Electric Move Tree", "Water Move Tree", "", "Medium", "128", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_MAKOWATT", "153", "Makowatt", "Makowatts have a psychotic lust to battle. If Makowatt isn't battling it is thinking about battling. It lives to battle. (Water / Electric)", "No Creature", "Water", "Electric", "1", "67", "10", "567", "1001", "240", "3.5", "415", "590", "71", "72", "65", "65", "52", "71", "56", "56", "3.2", "160", "3.3", "165", "3.5", "175", "3.3", "2", "165", "3", "150", "Normal Move Tree", "Electric Move Tree", "Water Move Tree", "", "Medium", "1", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_ELECTRIPINE", "154", "Electripine", "Not only do Electripine's quills have barbs, but they also produce tiny jolts of electricity even after being detaching. (Electric)", "Sporkupine", "Electric", "", "31", "29", "9.2", "489", "951", "200", "4.3", "415", "630", "24", "25", "13", "20", "15", "40", "16", "28", "1.8", "90", "3.3", "165", "3.3", "165", "3.3", "2", "165", "3.2", "160", "Normal Move Tree", "Electric Move Tree", "", "", "Medium", "80", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_SPORKUPINE", "155", "Sporkupine", "Sporkupines have been known to invade campsites to look for batteries and other power supplies--a food they consider a delicacy. (Electric)", "Torqupine", "Electric", "", "45", "43", "9.2", "503", "965", "240", "3.8", "430", "620", "30", "32", "39", "38", "23", "50", "25", "30", "1.8", "90", "3.3", "165", "3.3", "165", "3.4", "2", "170", "3.1", "155", "Normal Move Tree", "Electric Move Tree", "", "", "Medium", "128", "7", "1", "1", "0", "Bananteater", "0", "Riffin", "0"));
			Rows.Add( new TMMonstersRow("TM_TORQUPINE", "156", "Torqupine", "Because their eyesight is weak, the massive Torqupine detects its surroundings with an internal electrostatic radar and its keen sense of smell. (Electric)", "No Creature", "Electric", "", "1", "59", "9.2", "519", "921", "260", "3.5", "435", "610", "45", "42", "59", "50", "20", "90", "35", "30", "3.1", "155", "3.2", "160", "3.4", "170", "3.5", "2", "175", "3", "150", "Normal Move Tree", "Electric Move Tree", "", "", "Medium", "1", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_MAGMELEON", "157", "Magmeleon", "Magmeleons love dark and warm places, its not uncommon for a Magmeleon to never see any sunlight. (Fire)", "Megameleon", "Fire", "", "45", "36", "9", "486", "945", "180", "4.5", "405", "630", "37", "40", "30", "35", "30", "30", "25", "30", "3.1", "155", "3.3", "165", "3.3", "165", "3.3", "2", "165", "3.3", "165", "Normal Move Tree", "Fire Move Tree", "", "", "Medium", "128", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_MEGAMELEON", "158", "Megameleon", "Megameleon's back cracks open upon evolving creating craters that produces hot steam. (Fire)", "Magmameleon", "Fire", "", "58", "46", "9", "496", "958", "220", "4", "420", "620", "43", "56", "41", "65", "35", "52", "40", "32", "3.2", "160", "3.3", "165", "3.3", "165", "3.3", "2", "165", "3.2", "160", "Normal Move Tree", "Fire Move Tree", "", "", "Medium", "128", "7", "1", "1", "0", "Flarmian", "0", "Dragonflare", "0"));
			Rows.Add( new TMMonstersRow("TM_MAGMAMELEON", "159", "Magmameleon", "It is still unclear how the molten lava in Magmameleon's craters does not spill out during battle.  (Fire)", "No Creature", "Fire", "", "1", "80", "10", "580", "1001", "240", "3.5", "415", "590", "52", "80", "40", "70", "42", "55", "55", "51", "3.2", "160", "3.3", "165", "3.3", "165", "3.3", "2", "165", "3.1", "155", "Normal Move Tree", "Fire Move Tree", "", "", "Medium", "128", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_DANDYLION", "160", "Dandylion", "The longer Dandylion spends in the sun the bigger the flower on its tail grows. (Earth)", "Purrpetal", "Earth", "", "15", "30", "9", "480", "915", "200", "4.5", "425", "650", "40", "23", "23", "41", "36", "30", "34", "32", "3", "150", "3.2", "160", "3.2", "160", "3.2", "2", "160", "3.4", "170", "Normal Move Tree", "Earth Move Tree", "", "", "Medium", "128", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_PURRPETAL", "161", "Purrpetal", "The thorns on Purrpetal's tail become a formidable defense mechanism. (Earth)", "Vioness", "Earth", "", "37", "41", "9", "491", "937", "220", "4", "420", "620", "56", "28", "28", "55", "53", "50", "40", "49", "3.3", "165", "3.2", "160", "3.2", "160", "3.2", "2", "160", "3.3", "165", "Normal Move Tree", "Earth Move Tree", "", "", "Medium", "128", "7", "1", "1", "0", "Brak", "10", "Brak", "10"));
			Rows.Add( new TMMonstersRow("TM_VIONESS", "162", "Vioness", "With its deadly thorns and silent stalking, Vioness is known to be Terrarium's most stealthy hunter. (Earth)", "No Creature", "Earth", "", "1", "64", "9", "514", "901", "240", "3.5", "415", "590", "63", "37", "36", "56", "72", "50", "55", "70", "3.3", "165", "3.2", "160", "3.2", "160", "3.2", "2", "160", "3.2", "160", "Normal Move Tree", "Earth Move Tree", "", "", "Medium", "128", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_FLOFOX", "163", "Flofox", "Flofox utilizes the air to propel itself into battle. What Flofox lacks in size, it makes up in agility and cunningness. (Air)", "Wintail", "Air", "", "15", "31", "9", "481", "915", "200", "4.5", "425", "650", "33", "25", "40", "28", "37", "30", "34", "31", "3", "150", "3.2", "160", "3.2", "160", "3.2", "2", "160", "3.4", "170", "Normal Move Tree", "Air Move Tree", "", "", "Medium", "128", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_WINTAIL", "164", "Wintail", "Wintail can harness the wind, which it channels like an ethereal force. (Air)", "Cyclonine", "Air", "", "36", "40", "9", "490", "936", "220", "4", "420", "620", "43", "37", "51", "37", "51", "50", "40", "51", "3.3", "165", "3.2", "160", "3.2", "160", "3.2", "2", "160", "3.3", "165", "Normal Move Tree", "Air Move Tree", "", "", "Medium", "128", "7", "1", "1", "0", "Tomahawk", "20", "Tomahawk", "20"));
			Rows.Add( new TMMonstersRow("TM_CYCLONINE", "165", "Cyclonine", "Cyclonine is overfond of it wings, but uses them to fly very high into the stratosphere. It's horn guides it with an internal instinct. (Air)", "No Creature", "Air", "", "1", "62", "9", "512", "901", "240", "3.5", "415", "590", "51", "48", "70", "57", "57", "80", "45", "60", "3.3", "165", "3.2", "160", "3.2", "160", "3.2", "2", "160", "3.2", "160", "Normal Move Tree", "Air Move Tree", "", "", "Medium", "128", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_PANDEMITE", "166", "Pandemite", "Pandemite drinks lava shortly after birth, giving its fire abilities an explosive punch. (Fire)", "Pandora", "Fire", "", "15", "36", "9", "486", "915", "200", "4.5", "425", "650", "37", "40", "30", "33", "30", "30", "28", "25", "3", "150", "3.2", "160", "3.2", "160", "3.2", "2", "160", "3.4", "170", "Normal Move Tree", "Fire Move Tree", "", "", "Medium", "128", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_PANDORA", "167", "Pandora", "Pandora is a sleeping giant of a monster. It is filled with a fiery surprise when its slow temper finally erupts. (Fire)", "Pandorum", "Fire", "", "35", "46", "10", "546", "1035", "220", "4", "420", "620", "43", "60", "35", "59", "35", "50", "40", "32", "3.3", "165", "3.2", "160", "3.2", "160", "3.2", "2", "160", "3.3", "165", "Normal Move Tree", "Fire Move Tree", "", "", "Medium", "128", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_PANDORUM", "168", "Pandorum", "It takes over one hundred pounds of lava rock to satisfy a Pandorum's daily nourishment. The more it eats, the hotter its fire gets. (Fire)", "No Creature", "Fire", "", "1", "80", "10", "580", "1001", "240", "3.5", "415", "590", "52", "80", "40", "66", "41", "49", "50", "44", "3.3", "165", "3.2", "160", "3.2", "160", "3.2", "2", "160", "3.2", "160", "Normal Move Tree", "Fire Move Tree", "", "", "Medium", "128", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_NIPTUNE", "169", "Niptune", "Niptune is a seawolf-like Terra Monsters who's roar can cause tidal waves. It is said that a ferocious rainstorm is the result of a Niptune being born into Terrarium. (Water)", "Aquanine", "Water", "", "15", "37", "9", "487", "915", "200", "4.5", "425", "650", "39", "26", "35", "30", "35", "30", "32", "30", "3", "150", "3.2", "160", "3.2", "160", "3.2", "2", "160", "3.4", "170", "Normal Move Tree", "Water Move Tree", "", "", "Medium", "128", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_AQUANINE", "170", "Aquanine", "Aquanine are legendary for their ability to communicate with their pack by howling, both on land and underwater. (Water)", "Carnivice", "Water", "", "36", "44", "9", "494", "936", "220", "4", "420", "620", "49", "44", "39", "43", "44", "44", "42", "45", "3.3", "165", "3.2", "160", "3.2", "160", "3.2", "2", "160", "3.3", "165", "Normal Move Tree", "Water Move Tree", "", "", "Medium", "128", "7", "1", "1", "0", "Yeticrab", "30", "", "0"));
			Rows.Add( new TMMonstersRow("TM_CARNIVICE", "171", "Carnivice", "Carnivice's body can defy sub-zero temperatures and withstand crushing sea depths. Its bite can create instant frostbite. (Ice / Water)", "No Creature", "Ice", "Water", "1", "62", "9", "512", "901", "240", "3.5", "415", "590", "59", "57", "50", "58", "56", "54", "54", "57", "3.3", "165", "3.2", "160", "3.2", "160", "3.2", "2", "160", "3.2", "160", "Normal Move Tree", "Water Move Tree", "Ice Move Tree", "", "Medium", "128", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_VENOX", "172", "Venox", "Venox's saliva contains small traces of poison. It is wise to quickly disinfect any bites from it. (Earth)", "Raptox", "Earth", "", "15", "15", "9.1", "470", "925", "200", "4.3", "415", "630", "9", "51", "12", "29", "10", "20", "24", "10", "1.9", "95", "2.8", "140", "3.2", "160", "3.4", "2", "170", "3.3", "165", "Normal Move Tree", "Earth Move Tree", "", "", "Medium", "80", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_RAPTOX", "173", "Raptox", "Raptox's legs are much stronger than its arms. It prefers to hold down its foe under its feet while its uses its claws to slash away. (Earth)", "Velocirax", "Earth", "", "39", "28", "10", "528", "1039", "220", "4", "420", "620", "20", "75", "32", "50", "24", "60", "40", "31", "3.1", "155", "3", "150", "3.3", "165", "3.4", "2", "170", "3.2", "160", "Normal Move Tree", "Earth Move Tree", "", "", "Medium", "1", "7", "1", "1", "0", "Venox", "-2", "Venox", "-2"));
			Rows.Add( new TMMonstersRow("TM_VELOCIRAX", "174", "Velocirax", "Because of its size, it is slow to turn. Upon evolving it develops monstrous claws to protect itself from this deficiency in rotational speed. (Earth)", "No Creature", "Earth", "", "1", "46", "10", "546", "1001", "240", "3.8", "430", "620", "38", "96", "68", "70", "37", "55", "51", "44", "3.1", "155", "3.2", "160", "3.3", "165", "3.5", "2", "175", "3.1", "155", "Normal Move Tree", "Earth Move Tree", "", "", "Medium", "128", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_BULLIBEE", "175", "Bullibee", "Bullibee antennes are extremely effective at picking up electric currents of other Terra Monsters. It can sense another's location before it can see it. (Air)", "Targabee", "Air", "", "17", "22", "9", "472", "917", "220", "4.8", "460", "700", "19", "15", "10", "13", "18", "20", "24", "10", "3.2", "160", "2.7", "135", "3.4", "170", "3.5", "2", "175", "3.5", "175", "Normal Move Tree", "Air Move Tree", "", "", "Medium", "140", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_TARGABEE", "176", "Targabee", "Targabee uses its stinger mainly for defensive purposes. It contains a small amount of poison to paralyze a foe in case it needs to flee. (Air) ", "Missilbee", "Air", "", "31", "55", "9", "505", "931", "240", "4.2", "450", "660", "35", "50", "35", "30", "30", "30", "32", "31", "3.3", "165", "2.7", "135", "3.4", "170", "3.5", "2", "175", "3.3", "165", "Normal Move Tree", "Air Move Tree", "", "", "Medium", "20", "7", "1", "1", "0", "Bullibee", "1", "Bullibee", "-1"));
			Rows.Add( new TMMonstersRow("TM_MISSILBEE", "177", "Missilbee", "Missilebee leaves its colony shortly after evolving. There is not enough nectar to feed its increasing appetite. (Air) ", "No Creature", "Air", "", "1", "107", "9", "557", "901", "260", "4", "460", "660", "76", "72", "59", "67", "46", "70", "51", "52", "3.2", "160", "3", "150", "3.5", "175", "3.6", "2", "180", "3.2", "160", "Normal Move Tree", "Air Move Tree", "Electric Move Tree", "", "Medium", "10", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_SKULLYWAG", "178", "Skullywag", "Skullywag inhabits shallow coastal regions and often comes into contact with humans. It is quite playful and friendly despite its intimidating features and makes a great companion. (Water)", "Sharpoon", "Water", "", "20", "32", "9.1", "487", "930", "180", "4", "380", "580", "17", "15", "15", "12", "24", "40", "15", "20", "3.2", "160", "3.3", "165", "3.3", "165", "3.3", "2", "165", "3.5", "175", "Normal Move Tree", "Water Move Tree", "", "", "Medium", "80", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_SHARPOON", "179", "Sharpoon", "The intensity of the red stripes on its tail are a good indicator of how close Sharpoon is to evolving. (Water)", "Villianeard", "Water", "", "33", "22", "9", "472", "933", "200", "3.8", "390", "580", "27", "25", "25", "22", "34", "40", "25", "30", "3.2", "160", "3.4", "170", "3.3", "165", "3.3", "2", "165", "3.2", "160", "Normal Move Tree", "Water Move Tree", "", "", "Medium", "80", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_VILLIANEARD", "180", "Villianeard", "Villianeard is highly skilled at amphibious attacks. Its claws are perfectly suited for combat in or out of water and his dark coloring allows it to lie in wait, then strike.  (Water) ", "No Creature", "Water", "Arcane", "1", "70", "9", "520", "901", "240", "3.5", "415", "590", "52", "78", "55", "75", "44", "80", "48", "38", "3.2", "160", "3.4", "170", "3.3", "165", "3.5", "2", "175", "3.1", "155", "Normal Move Tree", "Water Move Tree", "Arcane Move Tree", "", "Medium", "128", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_TUFFIN", "181", "Tuffin", "Tuffin wings allow it to \"fly\" through water. It is said to be the fastest living thing in the ocean. (Water)", "Armotide", "Water", "", "18", "25", "9", "475", "918", "220", "4.5", "445", "670", "20", "24", "16", "14", "40", "25", "25", "34", "1.8", "90", "2.7", "135", "3.4", "170", "3.5", "2", "175", "3.4", "170", "Normal Move Tree", "Water Move Tree", "", "", "Medium", "120", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_ARMOTIDE", "182", "Armotide", "If you stare into Armotide's eyes for too long you eventually be put into an inescapable trance. (Water)", "Oceanite", "Water", "", "28", "54", "9", "504", "928", "240", "4.3", "455", "670", "43", "38", "32", "33", "75", "35", "50", "55", "1.8", "90", "2.7", "135", "3.5", "175", "3.6", "2", "180", "3.2", "160", "Normal Move Tree", "Water Move Tree", "", "", "Medium", "20", "7", "1", "1", "0", "Coralpie", "3", "Scuda", "-1"));
			Rows.Add( new TMMonstersRow("TM_OCEANITE", "183", "Oceanite", "Oceanite is not fond of humans. It is often observed slicing through fishing nets, hence its nickname \"Defender of The Seas\". (Water)", "No Creature", "Water", "", "1", "53", "9", "503", "901", "260", "4", "460", "660", "43", "38", "32", "33", "75", "35", "50", "55", "1.9", "95", "2.7", "135", "3.5", "175", "3.7", "2", "185", "3.1", "155", "Normal Move Tree", "Water Move Tree", "", "", "Medium", "20", "7", "1", "2", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_BRRIZARD", "184", "Brrizard", "A sleeping Brizzard is devoid of any color. A clever camouflage technique as it is often mistaken as stone during this defenseless state. (Ice)", "Slizzard", "Ice", "", "33", "26", "9.1", "481", "943", "180", "4.5", "405", "630", "35", "22", "29", "27", "18", "45", "29", "19", "3.2", "160", "3.2", "160", "3.3", "165", "3.2", "2", "160", "3.3", "165", "Normal Move Tree", "Ice Move Tree", "", "", "Medium", "80", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_SLIZZARD", "185", "Slizzard", "Slizzard is one of the most active Ice Terra Monsters, making it wildly unpopular with the other Ice Terra Monsters who prefer a slower pace of life. (Ice)", "Glaciagon", "Ice", "", "49", "56", "9", "506", "949", "200", "4", "400", "600", "57", "57", "47", "48", "38", "40", "39", "28", "3.1", "155", "3.2", "160", "3.3", "165", "3.3", "2", "165", "3.2", "160", "Normal Move Tree", "Ice Move Tree", "", "", "Medium", "128", "7", "1", "1", "0", "Sprew", "20", "Snowyrm", "-1"));
			Rows.Add( new TMMonstersRow("TM_GLACIAGON", "186", "Glaciagon", "Glaciagon dislikes warm places. It will release a blast of cold air through the slits on its torso to regulate its body temperature when it gets too hot. (Ice) ", "No Creature", "Ice", "", "1", "105", "9.1", "560", "911", "220", "3.7", "405", "590", "75", "63", "55", "53", "45", "90", "60", "40", "3.1", "155", "3.3", "165", "3.4", "170", "3.3", "2", "165", "3.1", "155", "Normal Move Tree", "Ice Move Tree", "", "", "Medium", "128", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_CLOVICE", "187", "Clovice", "Clovice's fur is soft as snow and provides ample warmth during the coldest of winters. (Ice) ", "Lumineer", "Ice", "", "32", "35", "9", "485", "932", "200", "4.5", "425", "650", "37", "26", "46", "39", "43", "42", "29", "45", "1.8", "90", "2.9", "145", "3.4", "170", "3.2", "2", "160", "3.2", "160", "Normal Move Tree", "Ice Move Tree", "", "", "Medium", "70", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_LUMINEER", "188", "Lumineer", "Lumineer sheds its antlers every winter. The antlers will regrow larger unless Lumineer is unhealthy. (Ice) ", "Majestice", "Ice", "", "45", "52", "9", "502", "945", "240", "4", "440", "640", "47", "39", "58", "46", "54", "50", "39", "55", "1.9", "95", "3", "150", "3.4", "170", "3.3", "2", "165", "3.1", "155", "Normal Move Tree", "Ice Move Tree", "", "", "Medium", "1", "7", "1", "1", "0", "Sprew", "10", "Sprew", "10"));
			Rows.Add( new TMMonstersRow("TM_MAJESTICE", "189", "Majestice", "Majestice is a highly seclusive Terra Monster. Seeing one is not only rare but considered a good omen by many. (Ice) ", "No Creature", "Ice", "", "1", "67", "9", "517", "901", "270", "3.9", "465", "660", "56", "47", "68", "59", "62", "100", "49", "65", "1.8", "90", "3", "150", "3.4", "170", "3.5", "2", "175", "3", "150", "Normal Move Tree", "Ice Move Tree", "", "", "Medium", "40", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_SNAILIX", "190", "Snailix", "Snailix will retreat inside its shell and emit a noxious gas in an attempt to repel its attacker when in danger. (Arcane) ", "Exollusk", "Arcane", "", "30", "35", "9", "485", "930", "180", "4.2", "390", "600", "37", "26", "46", "39", "43", "42", "29", "45", "2.8", "140", "3.5", "175", "1.8", "90", "2.8", "2", "140", "3", "150", "Normal Move Tree", "Arcane Move Tree", "", "", "Medium", "70", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_EXOLLUSK", "191", "Exollusk", "Exollusk supplements it short arms with a skull as hard as its exoskelleton shell. Its headbutt can crack stones. (Arcane) ", "Sluggernaught", "Arcane", "", "45", "52", "9", "502", "945", "200", "3.8", "390", "580", "47", "39", "58", "46", "54", "50", "39", "55", "3.3", "165", "3.5", "175", "1.8", "90", "2.9", "2", "145", "2.9", "145", "Normal Move Tree", "Arcane Move Tree", "", "", "Medium", "1", "7", "1", "1", "0", "Tortipous", "4", "Snozo", "0"));
			Rows.Add( new TMMonstersRow("TM_SLUGGERNAUGHT", "192", "Sluggernaught", "Despite its brutish exterior, Sluggernaut possess exceptional intelligence. However, as it refuses to be studied, its full mental capacity is unknown. (Arcane)", "No Creature", "Arcane", "", "1", "67", "9", "517", "901", "220", "3.5", "395", "570", "56", "47", "68", "59", "62", "100", "49", "65", "3.5", "175", "3.6", "180", "1.8", "90", "3", "2", "150", "2.8", "140", "Normal Move Tree", "Arcane Move Tree", "", "", "Medium", "40", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_NARWHALITE", "193", "Narwhalite", "This peculiar Terra Monster is a favorite amongst young children. Narwhalite is comical features and passive temperament makes it a great companion, but a poor candidate for battle.", "No Creature", "Water", "", "0", "67", "9", "517", "900", "220", "3.8", "410", "600", "56", "47", "68", "59", "62", "100", "49", "65", "3.3", "165", "3.3", "165", "3.2", "160", "3.2", "2", "160", "2.7", "135", "Normal Move Tree", "Water Move Tree", "", "", "Medium", "40", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_TAURYSOS", "194", "Taurysos", "Taurysos was the symbol of fertility in grain and herd in ancient folklore. Farmers made offerings to shrines of it before the start of growing season in forms of fruits and vegetables in hopes of a bountiful harvest. (Earth)", "No Creature", "Earth", "", "0", "67", "9", "517", "900", "220", "3.8", "410", "600", "56", "47", "68", "59", "62", "100", "49", "65", "3.3", "165", "3.3", "165", "3.2", "160", "3.2", "2", "160", "2.7", "135", "Normal Move Tree", "Earth Move Tree", "", "", "Medium", "40", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_SKELINOTH", "195", "Skelinoth", "Skelinoth was known as the Warden of the Dead. It was believed that when one appeared, a series of three deaths would soon to follow. (Arcane)", "No Creature", "Arcane", "", "0", "67", "9", "517", "900", "220", "3.8", "410", "600", "56", "47", "68", "59", "62", "100", "49", "65", "3.3", "165", "3.3", "165", "3.2", "160", "3.2", "2", "160", "2.7", "135", "Normal Move Tree", "Arcane Move Tree", "", "", "Medium", "40", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_GALYNX", "196", "Galaynx", "Galaynx was thought to be the physical manisfestation of Air and Wind because of its elegant yet powerful movements. It was also the most elusive of the Ancient Kirins with the fewest verified sightings. (Air)", "No Creature", "Air", "", "0", "67", "9", "517", "900", "220", "3.8", "410", "600", "56", "47", "68", "59", "62", "100", "49", "65", "3.3", "165", "3.3", "165", "3.2", "160", "3.2", "2", "160", "2.7", "135", "Normal Move Tree", "Air Move Tree", "", "", "Medium", "40", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_SQUALLAN", "197", "Squallan", "Squallan is consider to be the oldest of the Ancient Kirins, bestowing knowledge to the others. (Electric)", "No Creature", "Electric", "", "0", "67", "9", "517", "900", "220", "3.8", "410", "600", "56", "47", "68", "59", "62", "100", "49", "65", "3.3", "165", "3.3", "165", "3.2", "160", "3.2", "2", "160", "2.7", "135", "Normal Move Tree", "Electric Move Tree", "", "", "Medium", "40", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_INFERRAM", "198", "Inferram", "The true color of Inferram's horns are unknown, as it is completely engulfed in flames at all times. The scientific community is also unable to confirm the material of its horns, although many believe it to be made of keratin. (Fire)", "No Creature", "Fire", "", "0", "67", "9", "517", "900", "220", "3.8", "410", "600", "56", "47", "68", "59", "62", "100", "49", "65", "3.3", "165", "3.3", "165", "3.2", "160", "3.2", "2", "160", "2.7", "135", "Normal Move Tree", "Fire Move Tree", "", "", "Medium", "40", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_GLACIOLIN", "199", "Glaciolin", "It was once believed that angering Glaciolin would result in a long and harsh winter. It became an inauspicious sign of upcoming hardship. (Ice)", "No Creature", "Ice", "", "0", "67", "9", "517", "900", "220", "3.8", "410", "600", "56", "47", "68", "59", "62", "100", "49", "65", "3.3", "165", "3.3", "165", "3.2", "160", "3.2", "2", "160", "2.7", "135", "Normal Move Tree", "Ice Move Tree", "", "", "Medium", "40", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_AQUARIN", "200", "Aquarin", "It is customary for sailors to have a small feast in honor of Aquarin before setting sail. Fish and seaweed dishes are offered in exchange for safe passage during their journey. (Water)", "No Creature", "Water", "", "0", "67", "9", "517", "900", "220", "3.8", "410", "600", "56", "47", "68", "59", "62", "100", "49", "65", "3.3", "165", "3.3", "165", "3.2", "160", "3.2", "2", "160", "2.7", "135", "Normal Move Tree", "Water Move Tree", "", "", "Medium", "40", "7", "1", "1", "0", "", "0", "", "0"));
			Rows.Add( new TMMonstersRow("TM_TERRY", "201", "Rubiclawn", "Not much is known about this Ancient Terra Monster. It is rarely seen let alone studied. (Earth/Ice) ", "No Creature", "Earth", "Ice", "0", "67", "9", "517", "900", "220", "3.8", "410", "600", "56", "47", "68", "59", "62", "100", "49", "65", "3.3", "165", "3.3", "165", "3.2", "160", "3.2", "2", "160", "2.7", "135", "Arcane Move Tree", "Air Move Tree", "Ice Move Tree", "", "Medium", "40", "7", "1", "1", "0", "", "0", "", "0"));
		}
		public IGoogle2uRow GetGenRow(string in_RowString)
		{
			IGoogle2uRow ret = null;
			try
			{
				ret = Rows[(int)System.Enum.Parse(typeof(rowIds), in_RowString)];
			}
			catch(System.ArgumentException) {
				Debug.LogError( in_RowString + " is not a member of the rowIds enumeration.");
			}
			return ret;
		}
		public IGoogle2uRow GetGenRow(rowIds in_RowID)
		{
			IGoogle2uRow ret = null;
			try
			{
				ret = Rows[(int)in_RowID];
			}
			catch( System.Collections.Generic.KeyNotFoundException ex )
			{
				Debug.LogError( in_RowID + " not found: " + ex.Message );
			}
			return ret;
		}
		public TMMonstersRow GetRow(rowIds in_RowID)
		{
			TMMonstersRow ret = null;
			try
			{
				ret = Rows[(int)in_RowID];
			}
			catch( System.Collections.Generic.KeyNotFoundException ex )
			{
				Debug.LogError( in_RowID + " not found: " + ex.Message );
			}
			return ret;
		}
		public TMMonstersRow GetRow(string in_RowString)
		{
			TMMonstersRow ret = null;
			try
			{
				ret = Rows[(int)System.Enum.Parse(typeof(rowIds), in_RowString)];
			}
			catch(System.ArgumentException) {
				Debug.LogError( in_RowString + " is not a member of the rowIds enumeration.");
			}
			return ret;
		}

	}

}
