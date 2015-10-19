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
	public class ItemsVitaminsRow : IGoogle2uRow
	{
		public int _ID;
		public string _ItemName;
		public string _ItemDescription;
		public int _SoftCurrency;
		public int _HardCurrency;
		public string _Sprite;
		public int _SpriteTintR;
		public int _SpriteTintG;
		public int _SpriteTintB;
		public int _SpriteTintA;
		public string _BoostArea;
		public int _BoostValue;
		public ItemsVitaminsRow(string __GOOGLEFU_ID, string __ID, string __ItemName, string __ItemDescription, string __SoftCurrency, string __HardCurrency, string __Sprite, string __SpriteTintR, string __SpriteTintG, string __SpriteTintB, string __SpriteTintA, string __BoostArea, string __BoostValue) 
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
			_BoostArea = __BoostArea.Trim();
			{
			int res;
				if(int.TryParse(__BoostValue, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_BoostValue = res;
				else
					Debug.LogError("Failed To Convert _BoostValue string: "+ __BoostValue +" to int");
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
					ret = _SoftCurrency.ToString();
					break;
				case 4:
					ret = _HardCurrency.ToString();
					break;
				case 5:
					ret = _Sprite.ToString();
					break;
				case 6:
					ret = _SpriteTintR.ToString();
					break;
				case 7:
					ret = _SpriteTintG.ToString();
					break;
				case 8:
					ret = _SpriteTintB.ToString();
					break;
				case 9:
					ret = _SpriteTintA.ToString();
					break;
				case 10:
					ret = _BoostArea.ToString();
					break;
				case 11:
					ret = _BoostValue.ToString();
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
				case "SoftCurrency":
					ret = _SoftCurrency.ToString();
					break;
				case "HardCurrency":
					ret = _HardCurrency.ToString();
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
				case "BoostArea":
					ret = _BoostArea.ToString();
					break;
				case "BoostValue":
					ret = _BoostValue.ToString();
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
			ret += "{" + "SoftCurrency" + " : " + _SoftCurrency.ToString() + "} ";
			ret += "{" + "HardCurrency" + " : " + _HardCurrency.ToString() + "} ";
			ret += "{" + "Sprite" + " : " + _Sprite.ToString() + "} ";
			ret += "{" + "SpriteTintR" + " : " + _SpriteTintR.ToString() + "} ";
			ret += "{" + "SpriteTintG" + " : " + _SpriteTintG.ToString() + "} ";
			ret += "{" + "SpriteTintB" + " : " + _SpriteTintB.ToString() + "} ";
			ret += "{" + "SpriteTintA" + " : " + _SpriteTintA.ToString() + "} ";
			ret += "{" + "BoostArea" + " : " + _BoostArea.ToString() + "} ";
			ret += "{" + "BoostValue" + " : " + _BoostValue.ToString() + "} ";
			return ret;
		}
	}
	public sealed class ItemsVitamins : IGoogle2uDB
	{
		public enum rowIds {
			ITMVIT_1, ITMVIT_2, ITMVIT_3
		};
		public string [] rowNames = {
			"ITMVIT_1", "ITMVIT_2", "ITMVIT_3"
		};
		public System.Collections.Generic.List<ItemsVitaminsRow> Rows = new System.Collections.Generic.List<ItemsVitaminsRow>();

		public static ItemsVitamins Instance
		{
			get { return NestedItemsVitamins.instance; }
		}

		private class NestedItemsVitamins
		{
			static NestedItemsVitamins() { }
			internal static readonly ItemsVitamins instance = new ItemsVitamins();
		}

		private ItemsVitamins()
		{
			Rows.Add( new ItemsVitaminsRow("ITMVIT_1", "1", "Train Attack", "Raises the Melee Atck Stat of a Monster", "0", "20", "trainrangeattack", "0", "0", "0", "0", "BoostMeleeAtck", "10"));
			Rows.Add( new ItemsVitaminsRow("ITMVIT_2", "2", "Train Defence", "Raises the Melee Def Stat of a Monster", "0", "20", "trainmeleedefence", "0", "0", "0", "0", "BoostMeleeDef", "10"));
			Rows.Add( new ItemsVitaminsRow("ITMVIT_3", "3", "Level Boost", "Boosts the level of your monster by 1", "0", "40", "Package", "0", "0", "0", "0", "BoostLevel", "1"));
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
		public ItemsVitaminsRow GetRow(rowIds in_RowID)
		{
			ItemsVitaminsRow ret = null;
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
		public ItemsVitaminsRow GetRow(string in_RowString)
		{
			ItemsVitaminsRow ret = null;
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
