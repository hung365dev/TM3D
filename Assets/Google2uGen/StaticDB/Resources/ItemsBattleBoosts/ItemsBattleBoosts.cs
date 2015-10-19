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
	public class ItemsBattleBoostsRow : IGoogle2uRow
	{
		public int _ID;
		public string _ItemName;
		public string _ItemDescription;
		public string _Sprite;
		public int _SpriteTintR;
		public int _SpriteTintG;
		public int _SpriteTintB;
		public int _SpriteTintA;
		public int _SoftCurrency;
		public int _HardCurrency;
		public string _BoostType;
		public float _BoostPercent;
		public ItemsBattleBoostsRow(string __GOOGLEFU_ID, string __ID, string __ItemName, string __ItemDescription, string __Sprite, string __SpriteTintR, string __SpriteTintG, string __SpriteTintB, string __SpriteTintA, string __SoftCurrency, string __HardCurrency, string __BoostType, string __BoostPercent) 
		{
			{
			int res;
				if(int.TryParse(__ID, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_ID = res;
				else
					Debug.LogError("Failed To Convert _ID string: "+ __ID +" to int");
			}
			_ItemName = __ItemName.Trim();
			_ItemDescription = __ItemDescription.Trim();
			_Sprite = __Sprite.Trim();
			{
			int res;
				if(int.TryParse(__SpriteTintR, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_SpriteTintR = res;
				else
					Debug.LogError("Failed To Convert _SpriteTintR string: "+ __SpriteTintR +" to int");
			}
			{
			int res;
				if(int.TryParse(__SpriteTintG, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_SpriteTintG = res;
				else
					Debug.LogError("Failed To Convert _SpriteTintG string: "+ __SpriteTintG +" to int");
			}
			{
			int res;
				if(int.TryParse(__SpriteTintB, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_SpriteTintB = res;
				else
					Debug.LogError("Failed To Convert _SpriteTintB string: "+ __SpriteTintB +" to int");
			}
			{
			int res;
				if(int.TryParse(__SpriteTintA, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_SpriteTintA = res;
				else
					Debug.LogError("Failed To Convert _SpriteTintA string: "+ __SpriteTintA +" to int");
			}
			{
			int res;
				if(int.TryParse(__SoftCurrency, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_SoftCurrency = res;
				else
					Debug.LogError("Failed To Convert _SoftCurrency string: "+ __SoftCurrency +" to int");
			}
			{
			int res;
				if(int.TryParse(__HardCurrency, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_HardCurrency = res;
				else
					Debug.LogError("Failed To Convert _HardCurrency string: "+ __HardCurrency +" to int");
			}
			_BoostType = __BoostType.Trim();
			{
			float res;
				if(float.TryParse(__BoostPercent, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_BoostPercent = res;
				else
					Debug.LogError("Failed To Convert _BoostPercent string: "+ __BoostPercent +" to float");
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
					ret = _ItemName.ToString();
					break;
				case 2:
					ret = _ItemDescription.ToString();
					break;
				case 3:
					ret = _Sprite.ToString();
					break;
				case 4:
					ret = _SpriteTintR.ToString();
					break;
				case 5:
					ret = _SpriteTintG.ToString();
					break;
				case 6:
					ret = _SpriteTintB.ToString();
					break;
				case 7:
					ret = _SpriteTintA.ToString();
					break;
				case 8:
					ret = _SoftCurrency.ToString();
					break;
				case 9:
					ret = _HardCurrency.ToString();
					break;
				case 10:
					ret = _BoostType.ToString();
					break;
				case 11:
					ret = _BoostPercent.ToString();
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
				case "ItemName":
					ret = _ItemName.ToString();
					break;
				case "ItemDescription":
					ret = _ItemDescription.ToString();
					break;
				case "Sprite":
					ret = _Sprite.ToString();
					break;
				case "SpriteTintR":
					ret = _SpriteTintR.ToString();
					break;
				case "SpriteTintG":
					ret = _SpriteTintG.ToString();
					break;
				case "SpriteTintB":
					ret = _SpriteTintB.ToString();
					break;
				case "SpriteTintA":
					ret = _SpriteTintA.ToString();
					break;
				case "SoftCurrency":
					ret = _SoftCurrency.ToString();
					break;
				case "HardCurrency":
					ret = _HardCurrency.ToString();
					break;
				case "BoostType":
					ret = _BoostType.ToString();
					break;
				case "BoostPercent":
					ret = _BoostPercent.ToString();
					break;
			}

			return ret;
		}
		public override string ToString()
		{
			string ret = System.String.Empty;
			ret += "{" + "ID" + " : " + _ID.ToString() + "} ";
			ret += "{" + "ItemName" + " : " + _ItemName.ToString() + "} ";
			ret += "{" + "ItemDescription" + " : " + _ItemDescription.ToString() + "} ";
			ret += "{" + "Sprite" + " : " + _Sprite.ToString() + "} ";
			ret += "{" + "SpriteTintR" + " : " + _SpriteTintR.ToString() + "} ";
			ret += "{" + "SpriteTintG" + " : " + _SpriteTintG.ToString() + "} ";
			ret += "{" + "SpriteTintB" + " : " + _SpriteTintB.ToString() + "} ";
			ret += "{" + "SpriteTintA" + " : " + _SpriteTintA.ToString() + "} ";
			ret += "{" + "SoftCurrency" + " : " + _SoftCurrency.ToString() + "} ";
			ret += "{" + "HardCurrency" + " : " + _HardCurrency.ToString() + "} ";
			ret += "{" + "BoostType" + " : " + _BoostType.ToString() + "} ";
			ret += "{" + "BoostPercent" + " : " + _BoostPercent.ToString() + "} ";
			return ret;
		}
	}
	public sealed class ItemsBattleBoosts : IGoogle2uDB
	{
		public enum rowIds {
			ITMBOOST_1, ITMBOOST_2, ITMBOOST_3, ITMBOOST_4, ITMBOOST_5, ITMBOOST_6, ITMBOOST_7, ITMBOOST_8
		};
		public string [] rowNames = {
			"ITMBOOST_1", "ITMBOOST_2", "ITMBOOST_3", "ITMBOOST_4", "ITMBOOST_5", "ITMBOOST_6", "ITMBOOST_7", "ITMBOOST_8"
		};
		public System.Collections.Generic.List<ItemsBattleBoostsRow> Rows = new System.Collections.Generic.List<ItemsBattleBoostsRow>();

		public static ItemsBattleBoosts Instance
		{
			get { return NestedItemsBattleBoosts.instance; }
		}

		private class NestedItemsBattleBoosts
		{
			static NestedItemsBattleBoosts() { }
			internal static readonly ItemsBattleBoosts instance = new ItemsBattleBoosts();
		}

		private ItemsBattleBoosts()
		{
			Rows.Add( new ItemsBattleBoostsRow("ITMBOOST_1", "1", "Precision Boost", "Boosts accuracy in battle by double.", "accuracyboost", "0", "0", "0", "0", "100", "0", "BoostAccuracy", "2"));
			Rows.Add( new ItemsBattleBoostsRow("ITMBOOST_2", "2", "Haste Boost", "Boosts speed in battle by double.", "Speedboost", "0", "0", "0", "0", "200", "0", "BoostSpeed", "2"));
			Rows.Add( new ItemsBattleBoostsRow("ITMBOOST_3", "3", "Reflex Boost", "Boosts agility in battle by double.", "AgilityPoster", "0", "0", "0", "0", "200", "0", "BoostAgility", "2"));
			Rows.Add( new ItemsBattleBoostsRow("ITMBOOST_4", "4", "Farsight Boost", "Boosts range attack in battle by double.", "rangeattackboost", "0", "0", "0", "0", "200", "0", "BoostRangeAtck", "2"));
			Rows.Add( new ItemsBattleBoostsRow("ITMBOOST_5", "5", "Protection Boost", "Boosts range defense in battle by double.", "rangedefboost", "0", "0", "0", "0", "150", "0", "BoostRangeDef", "2"));
			Rows.Add( new ItemsBattleBoostsRow("ITMBOOST_6", "6", "Fury Boost", "Boosts melee attack in battle by double.", "meleeattackboost", "0", "0", "0", "0", "200", "0", "BoostMeleeAtck", "2"));
			Rows.Add( new ItemsBattleBoostsRow("ITMBOOST_7", "7", "Ironskin Boost", "Boosts melee defense in battle by double.", "meleedefenceboost", "0", "0", "0", "0", "150", "0", "BoostMeleeDef", "2"));
			Rows.Add( new ItemsBattleBoostsRow("ITMBOOST_8", "8", "Supreme Boost", "Boosts every stat in battle by double.", "supremeboost", "0", "0", "0", "0", "500", "0", "BoostAll", "2"));
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
		public ItemsBattleBoostsRow GetRow(rowIds in_RowID)
		{
			ItemsBattleBoostsRow ret = null;
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
		public ItemsBattleBoostsRow GetRow(string in_RowString)
		{
			ItemsBattleBoostsRow ret = null;
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
