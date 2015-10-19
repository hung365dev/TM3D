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
	public class ItemsPlayerBoostsRow : IGoogle2uRow
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
		public string _Type;
		public string _Speciality;
		public float _Strength;
		public int _Seconds;
		public ItemsPlayerBoostsRow(string __GOOGLEFU_ID, string __ID, string __ItemName, string __ItemDescription, string __Sprite, string __SpriteTintR, string __SpriteTintG, string __SpriteTintB, string __SpriteTintA, string __SoftCurrency, string __HardCurrency, string __Type, string __Speciality, string __Strength, string __Seconds) 
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
			_Type = __Type.Trim();
			_Speciality = __Speciality.Trim();
			{
			float res;
				if(float.TryParse(__Strength, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_Strength = res;
				else
					Debug.LogError("Failed To Convert _Strength string: "+ __Strength +" to float");
			}
			{
			int res;
				if(int.TryParse(__Seconds, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_Seconds = res;
				else
					Debug.LogError("Failed To Convert _Seconds string: "+ __Seconds +" to int");
			}
		}

		public int Length { get { return 14; } }

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
					ret = _Type.ToString();
					break;
				case 11:
					ret = _Speciality.ToString();
					break;
				case 12:
					ret = _Strength.ToString();
					break;
				case 13:
					ret = _Seconds.ToString();
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
				case "Type":
					ret = _Type.ToString();
					break;
				case "Speciality":
					ret = _Speciality.ToString();
					break;
				case "Strength":
					ret = _Strength.ToString();
					break;
				case "Seconds":
					ret = _Seconds.ToString();
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
			ret += "{" + "Type" + " : " + _Type.ToString() + "} ";
			ret += "{" + "Speciality" + " : " + _Speciality.ToString() + "} ";
			ret += "{" + "Strength" + " : " + _Strength.ToString() + "} ";
			ret += "{" + "Seconds" + " : " + _Seconds.ToString() + "} ";
			return ret;
		}
	}
	public sealed class ItemsPlayerBoosts : IGoogle2uDB
	{
		public enum rowIds {
			PLAYERBOOST_1, PLAYERBOOST_2, PLAYERBOOST_3
		};
		public string [] rowNames = {
			"PLAYERBOOST_1", "PLAYERBOOST_2", "PLAYERBOOST_3"
		};
		public System.Collections.Generic.List<ItemsPlayerBoostsRow> Rows = new System.Collections.Generic.List<ItemsPlayerBoostsRow>();

		public static ItemsPlayerBoosts Instance
		{
			get { return NestedItemsPlayerBoosts.instance; }
		}

		private class NestedItemsPlayerBoosts
		{
			static NestedItemsPlayerBoosts() { }
			internal static readonly ItemsPlayerBoosts instance = new ItemsPlayerBoosts();
		}

		private ItemsPlayerBoosts()
		{
			Rows.Add( new ItemsPlayerBoostsRow("PLAYERBOOST_1", "1", "Repellant", "Provides a resistance to low level wild monsters for 10 minutes", "MaxRepellant", "0", "0", "0", "0", "50", "0", "Repel", "Normal", "10", "600"));
			Rows.Add( new ItemsPlayerBoostsRow("PLAYERBOOST_2", "2", "Booster", "Boosts XP your Terra Monsters gain by 50% for 10 minutes", "XPBooster", "0", "0", "0", "0", "0", "10", "BoostXP", "Normal", "0.5", "600"));
			Rows.Add( new ItemsPlayerBoostsRow("PLAYERBOOST_3", "3", "Super Booster", "Gives your monsters a 200% XP Boost for 10 minutes", "superboosterxp", "0", "0", "0", "0", "0", "50", "BoostXP", "Normal", "2", "600"));
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
		public ItemsPlayerBoostsRow GetRow(rowIds in_RowID)
		{
			ItemsPlayerBoostsRow ret = null;
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
		public ItemsPlayerBoostsRow GetRow(string in_RowString)
		{
			ItemsPlayerBoostsRow ret = null;
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
