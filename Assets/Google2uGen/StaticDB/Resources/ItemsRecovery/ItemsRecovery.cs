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
	public class ItemsRecoveryRow : IGoogle2uRow
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
		public bool _DoesRevive;
		public bool _CanUseInBattle;
		public string _UseableOn;
		public string _ToRecoverA;
		public string _RecoverAType;
		public float _RecoverAValue;
		public string _ToRecoverB;
		public string _RecoverBType;
		public float _RecoverBValue;
		public ItemsRecoveryRow(string __GOOGLEFU_ID, string __ID, string __ItemName, string __ItemDescription, string __Sprite, string __SpriteTintR, string __SpriteTintG, string __SpriteTintB, string __SpriteTintA, string __SoftCurrency, string __HardCurrency, string __DoesRevive, string __CanUseInBattle, string __UseableOn, string __ToRecoverA, string __RecoverAType, string __RecoverAValue, string __ToRecoverB, string __RecoverBType, string __RecoverBValue) 
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
			{
			bool res;
				if(bool.TryParse(__DoesRevive, out res))
					_DoesRevive = res;
				else
					Debug.LogError("Failed To Convert _DoesRevive string: "+ __DoesRevive +" to bool");
			}
			{
			bool res;
				if(bool.TryParse(__CanUseInBattle, out res))
					_CanUseInBattle = res;
				else
					Debug.LogError("Failed To Convert _CanUseInBattle string: "+ __CanUseInBattle +" to bool");
			}
			_UseableOn = __UseableOn.Trim();
			_ToRecoverA = __ToRecoverA.Trim();
			_RecoverAType = __RecoverAType.Trim();
			{
			float res;
				if(float.TryParse(__RecoverAValue, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_RecoverAValue = res;
				else
					Debug.LogError("Failed To Convert _RecoverAValue string: "+ __RecoverAValue +" to float");
			}
			_ToRecoverB = __ToRecoverB.Trim();
			_RecoverBType = __RecoverBType.Trim();
			{
			float res;
				if(float.TryParse(__RecoverBValue, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_RecoverBValue = res;
				else
					Debug.LogError("Failed To Convert _RecoverBValue string: "+ __RecoverBValue +" to float");
			}
		}

		public int Length { get { return 19; } }

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
					ret = _DoesRevive.ToString();
					break;
				case 11:
					ret = _CanUseInBattle.ToString();
					break;
				case 12:
					ret = _UseableOn.ToString();
					break;
				case 13:
					ret = _ToRecoverA.ToString();
					break;
				case 14:
					ret = _RecoverAType.ToString();
					break;
				case 15:
					ret = _RecoverAValue.ToString();
					break;
				case 16:
					ret = _ToRecoverB.ToString();
					break;
				case 17:
					ret = _RecoverBType.ToString();
					break;
				case 18:
					ret = _RecoverBValue.ToString();
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
				case "DoesRevive":
					ret = _DoesRevive.ToString();
					break;
				case "CanUseInBattle":
					ret = _CanUseInBattle.ToString();
					break;
				case "UseableOn":
					ret = _UseableOn.ToString();
					break;
				case "ToRecoverA":
					ret = _ToRecoverA.ToString();
					break;
				case "RecoverAType":
					ret = _RecoverAType.ToString();
					break;
				case "RecoverAValue":
					ret = _RecoverAValue.ToString();
					break;
				case "ToRecoverB":
					ret = _ToRecoverB.ToString();
					break;
				case "RecoverBType":
					ret = _RecoverBType.ToString();
					break;
				case "RecoverBValue":
					ret = _RecoverBValue.ToString();
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
			ret += "{" + "DoesRevive" + " : " + _DoesRevive.ToString() + "} ";
			ret += "{" + "CanUseInBattle" + " : " + _CanUseInBattle.ToString() + "} ";
			ret += "{" + "UseableOn" + " : " + _UseableOn.ToString() + "} ";
			ret += "{" + "ToRecoverA" + " : " + _ToRecoverA.ToString() + "} ";
			ret += "{" + "RecoverAType" + " : " + _RecoverAType.ToString() + "} ";
			ret += "{" + "RecoverAValue" + " : " + _RecoverAValue.ToString() + "} ";
			ret += "{" + "ToRecoverB" + " : " + _ToRecoverB.ToString() + "} ";
			ret += "{" + "RecoverBType" + " : " + _RecoverBType.ToString() + "} ";
			ret += "{" + "RecoverBValue" + " : " + _RecoverBValue.ToString() + "} ";
			return ret;
		}
	}
	public sealed class ItemsRecovery : IGoogle2uDB
	{
		public enum rowIds {
			ITMREC_1, ITMREC_2, ITMREC_3, ITMREC_5, ITMREC_6, ITMREC_7, ITMREC_8, ITMREC_9, ITMREC_10, ITMREC_11, ITMREC_12
		};
		public string [] rowNames = {
			"ITMREC_1", "ITMREC_2", "ITMREC_3", "ITMREC_5", "ITMREC_6", "ITMREC_7", "ITMREC_8", "ITMREC_9", "ITMREC_10", "ITMREC_11", "ITMREC_12"
		};
		public System.Collections.Generic.List<ItemsRecoveryRow> Rows = new System.Collections.Generic.List<ItemsRecoveryRow>();

		public static ItemsRecovery Instance
		{
			get { return NestedItemsRecovery.instance; }
		}

		private class NestedItemsRecovery
		{
			static NestedItemsRecovery() { }
			internal static readonly ItemsRecovery instance = new ItemsRecovery();
		}

		private ItemsRecovery()
		{
			Rows.Add( new ItemsRecoveryRow("ITMREC_1", "1", "Basic Potion", "Heals 60 HP Points on any Terra Monster", "Potion", "0", "0", "0", "0", "100", "0", "FALSE", "TRUE", "", "HP", "HealValue", "60", "", "", "0"));
			Rows.Add( new ItemsRecoveryRow("ITMREC_2", "2", "Medium Potion", "Heals 160 HP Points on any Terra Monster", "StrongPotion", "0", "0", "0", "0", "200", "0", "FALSE", "TRUE", "", "HP", "HealValue", "160", "", "", "0"));
			Rows.Add( new ItemsRecoveryRow("ITMREC_3", "3", "Full Heal", "Completely heals any Terra Monster", "MaxPotion", "0", "0", "0", "0", "0", "5", "FALSE", "TRUE", "", "HP", "HealPercentage", "1", "", "", "0"));
			Rows.Add( new ItemsRecoveryRow("ITMREC_5", "5", "Energy Restore", "Restores 100 Energy Points on any Terra Monster", "GranolaBar", "0", "0", "0", "0", "50", "0", "FALSE", "TRUE", "", "Energy", "HealValue", "100", "", "", "0"));
			Rows.Add( new ItemsRecoveryRow("ITMREC_6", "6", "Burn Heal", "Removes a burn status effect", "burnpotion", "0", "0", "0", "0", "50", "0", "FALSE", "TRUE", "", "Heal Burn", "HealValue", "1", "", "", "0"));
			Rows.Add( new ItemsRecoveryRow("ITMREC_7", "7", "Freeze Heal", "Removes a freeze status effect", "thawpotion", "0", "0", "0", "0", "50", "0", "FALSE", "TRUE", "", "Heal Freeze", "", "0", "", "", "0"));
			Rows.Add( new ItemsRecoveryRow("ITMREC_8", "8", "Paralyze Heal", "Removes a paralyze status effect", "paralyzeheal", "0", "0", "0", "0", "50", "0", "FALSE", "TRUE", "", "Heal Paralyzed", "", "0", "", "", "0"));
			Rows.Add( new ItemsRecoveryRow("ITMREC_9", "9", "Coffee Beans", "Wakes up a Terra Monster from sleep", "coffeebeans", "0", "0", "0", "0", "50", "0", "FALSE", "TRUE", "", "HP", "", "0", "", "", "0"));
			Rows.Add( new ItemsRecoveryRow("ITMREC_10", "10", "Confusion Heal", "Snaps a Terra Monster out of confusion", "confusionpotion", "0", "0", "0", "0", "50", "0", "FALSE", "TRUE", "", "Heal Confusion", "", "0", "", "", "0"));
			Rows.Add( new ItemsRecoveryRow("ITMREC_11", "11", "Poison Heal", "Cures a Terra Monster from any poison effects", "poisonpotion", "0", "0", "0", "0", "50", "0", "FALSE", "TRUE", "", "Heal Poison", "", "0", "", "", "0"));
			Rows.Add( new ItemsRecoveryRow("ITMREC_12", "12", "Status Clear", "Clear any and all status effects", "statusclear", "0", "0", "0", "0", "0", "2", "FALSE", "TRUE", "", "Heal All Status", "", "0", "", "", "0"));
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
		public ItemsRecoveryRow GetRow(rowIds in_RowID)
		{
			ItemsRecoveryRow ret = null;
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
		public ItemsRecoveryRow GetRow(string in_RowString)
		{
			ItemsRecoveryRow ret = null;
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
