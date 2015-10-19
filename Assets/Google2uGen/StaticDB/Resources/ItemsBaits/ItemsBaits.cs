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
	public class ItemsBaitsRow : IGoogle2uRow
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
		public string _Speciality;
		public float _Strength;
		public ItemsBaitsRow(string __GOOGLEFU_ID, string __ID, string __ItemName, string __ItemDescription, string __Sprite, string __SpriteTintR, string __SpriteTintG, string __SpriteTintB, string __SpriteTintA, string __SoftCurrency, string __HardCurrency, string __Speciality, string __Strength) 
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
			_Speciality = __Speciality.Trim();
			{
			float res;
				if(float.TryParse(__Strength, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_Strength = res;
				else
					Debug.LogError("Failed To Convert _Strength string: "+ __Strength +" to float");
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
					ret = _Speciality.ToString();
					break;
				case 11:
					ret = _Strength.ToString();
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
				case "Speciality":
					ret = _Speciality.ToString();
					break;
				case "Strength":
					ret = _Strength.ToString();
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
			ret += "{" + "Speciality" + " : " + _Speciality.ToString() + "} ";
			ret += "{" + "Strength" + " : " + _Strength.ToString() + "} ";
			return ret;
		}
	}
	public sealed class ItemsBaits : IGoogle2uDB
	{
		public enum rowIds {
			ITMBAIT_1, ITMBAIT_2, ITMBAIT_3, ITMBAIT_4, ITMBAIT_5, ITMBAIT_6, ITMBAIT_7, ITMBAIT_8, ITMBAIT_9
		};
		public string [] rowNames = {
			"ITMBAIT_1", "ITMBAIT_2", "ITMBAIT_3", "ITMBAIT_4", "ITMBAIT_5", "ITMBAIT_6", "ITMBAIT_7", "ITMBAIT_8", "ITMBAIT_9"
		};
		public System.Collections.Generic.List<ItemsBaitsRow> Rows = new System.Collections.Generic.List<ItemsBaitsRow>();

		public static ItemsBaits Instance
		{
			get { return NestedItemsBaits.instance; }
		}

		private class NestedItemsBaits
		{
			static NestedItemsBaits() { }
			internal static readonly ItemsBaits instance = new ItemsBaits();
		}

		private ItemsBaits()
		{
			Rows.Add( new ItemsBaitsRow("ITMBAIT_1", "1", "Weak Bait", "A Cheap Bait, for greatly weakened Terra Monsters", "VeggieBait", "0", "0", "0", "0", "50", "0", "", "1"));
			Rows.Add( new ItemsBaitsRow("ITMBAIT_2", "2", "Ice Bait", "A Bait loved by Ice Terra Monsters.", "icebait", "0", "0", "0", "0", "150", "0", "Ice", "1.5"));
			Rows.Add( new ItemsBaitsRow("ITMBAIT_3", "3", "Earth Bait", "A Bait loved by Earth Terra Monsters.", "earthbait", "0", "0", "0", "0", "150", "0", "Earth", "1.5"));
			Rows.Add( new ItemsBaitsRow("ITMBAIT_4", "4", "Water Bait", "A Bait loved by Water Terra Monsters.", "waterbait", "0", "0", "0", "0", "150", "0", "Water", "1.5"));
			Rows.Add( new ItemsBaitsRow("ITMBAIT_5", "5", "Arcane Bait", "A Bait loved by Arcane Terra Monsters.", "arcanebait", "0", "0", "0", "0", "150", "0", "Arcane", "1.5"));
			Rows.Add( new ItemsBaitsRow("ITMBAIT_6", "6", "Fire Bait", "A Bait loved by Fire Terra Monsters.", "firebait", "0", "0", "0", "0", "150", "0", "Fire", "1.5"));
			Rows.Add( new ItemsBaitsRow("ITMBAIT_7", "7", "Air Bait", "A Bait loved by Air Terra Monsters.", "airbait", "0", "0", "0", "0", "150", "0", "Air", "1.5"));
			Rows.Add( new ItemsBaitsRow("ITMBAIT_8", "8", "Electric Bait", "A Bait loved by Electric Terra Monsters.", "electricbait", "0", "0", "0", "0", "150", "0", "Electric", "1.5"));
			Rows.Add( new ItemsBaitsRow("ITMBAIT_9", "9", "Ultra Bait", "A Bait that is irresistble to all Terra Monsters", "FruityBait", "0", "0", "0", "0", "0", "100", "", "100"));
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
		public ItemsBaitsRow GetRow(rowIds in_RowID)
		{
			ItemsBaitsRow ret = null;
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
		public ItemsBaitsRow GetRow(string in_RowString)
		{
			ItemsBaitsRow ret = null;
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
