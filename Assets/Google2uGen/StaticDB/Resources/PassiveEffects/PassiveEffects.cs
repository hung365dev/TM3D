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
	public class PassiveEffectsRow : IGoogle2uRow
	{
		public int _ID;
		public string _EffectName;
		public string _Description;
		public string _EffectType;
		public string _TakeEffectsFromMove;
		public string _ApplyWhen;
		public string _MoveElementType;
		public string _MoveRangeType;
		public int _StatusEffectSuffered;
		public int _HPPercentage;
		public string _EffectClass;
		public int _Weighting;
		public PassiveEffectsRow(string __GOOGLEFU_ID, string __ID, string __EffectName, string __Description, string __EffectType, string __TakeEffectsFromMove, string __ApplyWhen, string __MoveElementType, string __MoveRangeType, string __StatusEffectSuffered, string __HPPercentage, string __EffectClass, string __Weighting) 
		{
			{
			int res;
				if(int.TryParse(__ID, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_ID = res;
				else
					Debug.LogError("Failed To Convert _ID string: "+ __ID +" to int");
			}
			_EffectName = __EffectName.Trim();
			_Description = __Description.Trim();
			_EffectType = __EffectType.Trim();
			_TakeEffectsFromMove = __TakeEffectsFromMove.Trim();
			_ApplyWhen = __ApplyWhen.Trim();
			_MoveElementType = __MoveElementType.Trim();
			_MoveRangeType = __MoveRangeType.Trim();
			{
			int res;
				if(int.TryParse(__StatusEffectSuffered, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_StatusEffectSuffered = res;
				else
					Debug.LogError("Failed To Convert _StatusEffectSuffered string: "+ __StatusEffectSuffered +" to int");
			}
			{
			int res;
				if(int.TryParse(__HPPercentage, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_HPPercentage = res;
				else
					Debug.LogError("Failed To Convert _HPPercentage string: "+ __HPPercentage +" to int");
			}
			_EffectClass = __EffectClass.Trim();
			{
			int res;
				if(int.TryParse(__Weighting, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_Weighting = res;
				else
					Debug.LogError("Failed To Convert _Weighting string: "+ __Weighting +" to int");
			}
		}

		public int Length { get { return 12; } }

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
					ret = _EffectName.ToString();
					break;
				case 2:
					ret = _Description.ToString();
					break;
				case 3:
					ret = _EffectType.ToString();
					break;
				case 4:
					ret = _TakeEffectsFromMove.ToString();
					break;
				case 5:
					ret = _ApplyWhen.ToString();
					break;
				case 6:
					ret = _MoveElementType.ToString();
					break;
				case 7:
					ret = _MoveRangeType.ToString();
					break;
				case 8:
					ret = _StatusEffectSuffered.ToString();
					break;
				case 9:
					ret = _HPPercentage.ToString();
					break;
				case 10:
					ret = _EffectClass.ToString();
					break;
				case 11:
					ret = _Weighting.ToString();
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
				case "EffectName":
					ret = _EffectName.ToString();
					break;
				case "Description":
					ret = _Description.ToString();
					break;
				case "EffectType":
					ret = _EffectType.ToString();
					break;
				case "TakeEffectsFromMove":
					ret = _TakeEffectsFromMove.ToString();
					break;
				case "ApplyWhen":
					ret = _ApplyWhen.ToString();
					break;
				case "MoveElementType":
					ret = _MoveElementType.ToString();
					break;
				case "MoveRangeType":
					ret = _MoveRangeType.ToString();
					break;
				case "StatusEffectSuffered":
					ret = _StatusEffectSuffered.ToString();
					break;
				case "HPPercentage":
					ret = _HPPercentage.ToString();
					break;
				case "EffectClass":
					ret = _EffectClass.ToString();
					break;
				case "Weighting":
					ret = _Weighting.ToString();
					break;
			}

			return ret;
		}
		public override string ToString()
		{
			string ret = System.String.Empty;
			ret += "{" + "ID" + " : " + _ID.ToString() + "} ";
			ret += "{" + "EffectName" + " : " + _EffectName.ToString() + "} ";
			ret += "{" + "Description" + " : " + _Description.ToString() + "} ";
			ret += "{" + "EffectType" + " : " + _EffectType.ToString() + "} ";
			ret += "{" + "TakeEffectsFromMove" + " : " + _TakeEffectsFromMove.ToString() + "} ";
			ret += "{" + "ApplyWhen" + " : " + _ApplyWhen.ToString() + "} ";
			ret += "{" + "MoveElementType" + " : " + _MoveElementType.ToString() + "} ";
			ret += "{" + "MoveRangeType" + " : " + _MoveRangeType.ToString() + "} ";
			ret += "{" + "StatusEffectSuffered" + " : " + _StatusEffectSuffered.ToString() + "} ";
			ret += "{" + "HPPercentage" + " : " + _HPPercentage.ToString() + "} ";
			ret += "{" + "EffectClass" + " : " + _EffectClass.ToString() + "} ";
			ret += "{" + "Weighting" + " : " + _Weighting.ToString() + "} ";
			return ret;
		}
	}
	public sealed class PassiveEffects : IGoogle2uDB
	{
		public enum rowIds {
			PASSIVE_0, PASSIVE_1, PASSIVE_2, PASSIVE_3, PASSIVE_4, PASSIVE_5, PASSIVE_6, PASSIVE_7, PASSIVE_8, PASSIVE_9, PASSIVE_10, PASSIVE_11, PASSIVE_12, PASSIVE_13, PASSIVE_14, PASSIVE_15, PASSIVE_16, PASSIVE_17
			, PASSIVE_18, PASSIVE_19, PASSIVE_20, PASSIVE_21, PASSIVE_22, PASSIVE_23, PASSIVE_24, PASSIVE_25, PASSIVE_26, PASSIVE_27, PASSIVE_28, PASSIVE_29, PASSIVE_30, PASSIVE_31, PASSIVE_32
		};
		public string [] rowNames = {
			"PASSIVE_0", "PASSIVE_1", "PASSIVE_2", "PASSIVE_3", "PASSIVE_4", "PASSIVE_5", "PASSIVE_6", "PASSIVE_7", "PASSIVE_8", "PASSIVE_9", "PASSIVE_10", "PASSIVE_11", "PASSIVE_12", "PASSIVE_13", "PASSIVE_14", "PASSIVE_15", "PASSIVE_16", "PASSIVE_17"
			, "PASSIVE_18", "PASSIVE_19", "PASSIVE_20", "PASSIVE_21", "PASSIVE_22", "PASSIVE_23", "PASSIVE_24", "PASSIVE_25", "PASSIVE_26", "PASSIVE_27", "PASSIVE_28", "PASSIVE_29", "PASSIVE_30", "PASSIVE_31", "PASSIVE_32"
		};
		public System.Collections.Generic.List<PassiveEffectsRow> Rows = new System.Collections.Generic.List<PassiveEffectsRow>();

		public static PassiveEffects Instance
		{
			get { return NestedPassiveEffects.instance; }
		}

		private class NestedPassiveEffects
		{
			static NestedPassiveEffects() { }
			internal static readonly PassiveEffects instance = new PassiveEffects();
		}

		private PassiveEffects()
		{
			Rows.Add( new PassiveEffectsRow("PASSIVE_0", "0", "None", "", "", "", "", "", "", "0", "0", "Class 1", "0"));
			Rows.Add( new PassiveEffectsRow("PASSIVE_1", "1", "Hot Shot", "Melee Attacks against this Monster may Burn the Attacker", "Fire", "Passive_Hotshot", "When hit by %MOVERANGETYPE%", "", "Melee", "0", "0", "Class 1", "1"));
			Rows.Add( new PassiveEffectsRow("PASSIVE_2", "2", "Enflare", "Fire moves do extra damage when HP Low", "Fire", "Passive_Enflare", "When HP Lower than %HPPERCENTAGE%", "", "", "0", "30", "Class 1", "1"));
			Rows.Add( new PassiveEffectsRow("PASSIVE_3", "3", "Smokey", "Reduces opposing monsters accuracy.", "Fire", "Passive_Smokey", "At battle start", "", "", "0", "0", "Class 1", "1"));
			Rows.Add( new PassiveEffectsRow("PASSIVE_4", "4", "Overdone", "Fire attacks do extra damage but inflict damage against this monster", "Fire", "Passive_Overdone", "When using move of type %FIELDMOVETYPE%", "Fire", "", "0", "0", "Class 1", "1"));
			Rows.Add( new PassiveEffectsRow("PASSIVE_5", "5", "Fresh", "Chance of curing random ally monster of a special condition after each turn", "Water", "Passive_Fresh", "At end of move queue", "", "", "0", "0", "Class 1", "1"));
			Rows.Add( new PassiveEffectsRow("PASSIVE_6", "6", "Free Flowing", "Prevents this monster's Defense stats from being lowered", "Water", "Passive_FreeFlowing", "At battle start", "", "", "0", "0", "Class 1", "1"));
			Rows.Add( new PassiveEffectsRow("PASSIVE_7", "7", "Deathroller", "Does damage to opposing monsters affected by Sleep, Freeze, or Paralyzed after each turn.", "Water", "Passive_Deathroller", "At end of move queue", "", "", "11", "0", "Class 1", "1"));
			Rows.Add( new PassiveEffectsRow("PASSIVE_8", "8", "Absorb", "Restores HP when hit by a Water attack.", "Water", "Passive_Absorb", "When hit by %FIELDMOVETYPE% at end of move queue", "Water", "", "0", "0", "Class 1", "1"));
			Rows.Add( new PassiveEffectsRow("PASSIVE_9", "9", "Durable", "This monster cannot be knocked out in one hit.", "Earth", "Passive_Durable", "At battle start", "", "", "0", "0", "Class 1", "1"));
			Rows.Add( new PassiveEffectsRow("PASSIVE_10", "10", "Spored", "Melee attacks to this monster may paralyze, poison or cause sleep to the attacker.", "Earth", "Passive_Spored", "When hit by %MOVERANGETYPE%", "", "Melee", "0", "0", "Class 1", "1"));
			Rows.Add( new PassiveEffectsRow("PASSIVE_11", "11", "Hardened", "Prevents this monster from receiving Decisive Blows", "Earth", "Passive_Hardened", "At battle start", "", "", "0", "0", "Class 1", "1"));
			Rows.Add( new PassiveEffectsRow("PASSIVE_12", "12", "Immune", "Prevents monster from becoming Poisoned", "Earth", "Passive_Immune", "At battle start", "", "", "0", "0", "Class 1", "1"));
			Rows.Add( new PassiveEffectsRow("PASSIVE_13", "13", "Lightweight", "This monster has increased evasion but lower attack.", "Air", "Passive_Lightweight", "At battle start", "", "", "0", "0", "Class 1", "1"));
			Rows.Add( new PassiveEffectsRow("PASSIVE_14", "14", "Squadmate", "Chance of making all ally Air type monsters have no weakness until end of battle.", "Air", "Passive_SquadMate", "At battle start", "", "", "0", "0", "Class 1", "1"));
			Rows.Add( new PassiveEffectsRow("PASSIVE_15", "15", "Fleetwing", "Raises Evasion each time this monster flinches.", "Air", "Passive_FleetWing", "When %STATUSEFFECTSUFFERED%", "", "", "16", "0", "Class 1", "1"));
			Rows.Add( new PassiveEffectsRow("PASSIVE_16", "16", "Rapid Reflex", "Increases the frequency of multi-hit moves striking opposing monsters.", "Air", "Passive_RapidReflex", "When using move of type %FIELDMOVETYPE%", "Air", "", "0", "0", "Class 1", "1"));
			Rows.Add( new PassiveEffectsRow("PASSIVE_17", "17", "Cold Aura", "This monster doubles opposing monster's energy usage.", "Ice", "Passive_ColdAura", "When hit", "", "", "0", "0", "Class 1", "1"));
			Rows.Add( new PassiveEffectsRow("PASSIVE_18", "18", "Hibernated", "This monster can't be put to sleep.", "Ice", "Passive_Hibernated", "At battle start", "", "", "0", "0", "Class 1", "1"));
			Rows.Add( new PassiveEffectsRow("PASSIVE_19", "19", "Crystalized", "Prevents this monster's stats from being lowered.", "Ice", "Passive_Crystalized", "At battle start", "", "", "0", "0", "Class 1", "1"));
			Rows.Add( new PassiveEffectsRow("PASSIVE_20", "20", "Frostburner", "Chance of causing flinch on random opposing monster after each turn.", "Ice", "Passive_Frostburner", "At end of move queue", "", "", "0", "0", "Class 1", "1"));
			Rows.Add( new PassiveEffectsRow("PASSIVE_21", "21", "Reactor", "Raises Speed each time this monster flinches.", "Electric", "Passive_Reactor", "When %STATUSEFFECTSUFFERED%", "", "", "16", "0", "Class 1", "1"));
			Rows.Add( new PassiveEffectsRow("PASSIVE_22", "22", "Semiconductor", "Raise all allied monster's Ranged Defense if this monster is hit by an Electric type attack.", "Electric", "Passive_Semiconductor", "When hit by %FIELDMOVETYPE%", "Electric", "", "0", "0", "Class 1", "1"));
			Rows.Add( new PassiveEffectsRow("PASSIVE_23", "23", "Shocking", "Ranged attacks against this monster may Paralyze the attacker.", "Electric", "Passive_Shocking", "When hit by %MOVERANGETYPE%", "", "Ranged", "0", "0", "Class 1", "1"));
			Rows.Add( new PassiveEffectsRow("PASSIVE_24", "24", "Grounded", "Restores HP when hit by an Electric attack.", "Electric", "Passive_Grounded", "When hit by %FIELDMOVETYPE%", "Electric", "", "0", "0", "Class 1", "1"));
			Rows.Add( new PassiveEffectsRow("PASSIVE_25", "25", "Supernatural", "This monster isn't affected by Sleep, Freeze, or Poison.", "Arcane", "Passive_Supernatural", "At battle start", "", "", "0", "0", "Class 1", "1"));
			Rows.Add( new PassiveEffectsRow("PASSIVE_26", "26", "Infectious", "When this monster is affected by a special condition, an opponent receives the same condition.", "Arcane", "Passive_Infectious", "When %STATUSEFFECTSUFFERED%", "", "", "0", "0", "Class 1", "1"));
			Rows.Add( new PassiveEffectsRow("PASSIVE_27", "27", "Healer", "Chance of healing random ally monster after each turn.", "Arcane", "Passive_Healer", "At end of move queue", "", "", "0", "0", "Class 1", "1"));
			Rows.Add( new PassiveEffectsRow("PASSIVE_28", "28", "Magical", "Increases the chances of non-damaging move effects.", "Arcane", "Passive_Magical", "At battle start", "", "", "0", "0", "Class 1", "1"));
			Rows.Add( new PassiveEffectsRow("PASSIVE_29", "29", "Sharp", "Damages attacking monsters when struck with a Melee attack.", "Normal", "Passive_Sharp", "When hit by %FIELDMOVETYPE%", "", "Melee", "0", "0", "Class 1", "1"));
			Rows.Add( new PassiveEffectsRow("PASSIVE_30", "30", "Helper", "Chance of this monster's non-damaging move going first.", "Normal", "Passive_Helper", "", "", "", "0", "0", "Class 1", "1"));
			Rows.Add( new PassiveEffectsRow("PASSIVE_31", "31", "Rival", "Raises this monsters attack if it shares a type with an opposing monster.", "Normal", "Passive_Rival", "When one opponent is same as effect owner", "", "", "0", "0", "Class 1", "1"));
			Rows.Add( new PassiveEffectsRow("PASSIVE_32", "32", "Precise", "Raises the chance of decisive blows.", "Normal", "Passive_Precise", "At battle start", "", "", "0", "0", "Class 1", "1"));
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
		public PassiveEffectsRow GetRow(rowIds in_RowID)
		{
			PassiveEffectsRow ret = null;
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
		public PassiveEffectsRow GetRow(string in_RowString)
		{
			PassiveEffectsRow ret = null;
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
