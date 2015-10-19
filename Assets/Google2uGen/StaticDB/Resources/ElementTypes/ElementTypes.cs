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
	public class ElementTypesRow : IGoogle2uRow
	{
		public int _ID;
		public string _ElementName;
		public int _ElementFlag;
		public string _Description;
		public float _StrengthVsEarth;
		public float _StrengthVsWater;
		public float _StrengthVsIce;
		public float _StrengthVsAir;
		public float _StrengthVsFire;
		public float _StrengthVsArcane;
		public float _StrengthVsElectric;
		public float _StrengthVsNormal;
		public int _ElementalColorRed;
		public int _ElementalColorGreen;
		public int _ElementalColorBlue;
		public ElementTypesRow(string __GOOGLEFU_ID, string __ID, string __ElementName, string __ElementFlag, string __Description, string __StrengthVsEarth, string __StrengthVsWater, string __StrengthVsIce, string __StrengthVsAir, string __StrengthVsFire, string __StrengthVsArcane, string __StrengthVsElectric, string __StrengthVsNormal, string __ElementalColorRed, string __ElementalColorGreen, string __ElementalColorBlue) 
		{
			{
			int res;
				if(int.TryParse(__ID, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_ID = res;
				else
					Debug.LogError("Failed To Convert _ID string: "+ __ID +" to int");
			}
			_ElementName = __ElementName.Trim();
			{
			int res;
				if(int.TryParse(__ElementFlag, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_ElementFlag = res;
				else
					Debug.LogError("Failed To Convert _ElementFlag string: "+ __ElementFlag +" to int");
			}
			_Description = __Description.Trim();
			{
			float res;
				if(float.TryParse(__StrengthVsEarth, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_StrengthVsEarth = res;
				else
					Debug.LogError("Failed To Convert _StrengthVsEarth string: "+ __StrengthVsEarth +" to float");
			}
			{
			float res;
				if(float.TryParse(__StrengthVsWater, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_StrengthVsWater = res;
				else
					Debug.LogError("Failed To Convert _StrengthVsWater string: "+ __StrengthVsWater +" to float");
			}
			{
			float res;
				if(float.TryParse(__StrengthVsIce, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_StrengthVsIce = res;
				else
					Debug.LogError("Failed To Convert _StrengthVsIce string: "+ __StrengthVsIce +" to float");
			}
			{
			float res;
				if(float.TryParse(__StrengthVsAir, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_StrengthVsAir = res;
				else
					Debug.LogError("Failed To Convert _StrengthVsAir string: "+ __StrengthVsAir +" to float");
			}
			{
			float res;
				if(float.TryParse(__StrengthVsFire, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_StrengthVsFire = res;
				else
					Debug.LogError("Failed To Convert _StrengthVsFire string: "+ __StrengthVsFire +" to float");
			}
			{
			float res;
				if(float.TryParse(__StrengthVsArcane, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_StrengthVsArcane = res;
				else
					Debug.LogError("Failed To Convert _StrengthVsArcane string: "+ __StrengthVsArcane +" to float");
			}
			{
			float res;
				if(float.TryParse(__StrengthVsElectric, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_StrengthVsElectric = res;
				else
					Debug.LogError("Failed To Convert _StrengthVsElectric string: "+ __StrengthVsElectric +" to float");
			}
			{
			float res;
				if(float.TryParse(__StrengthVsNormal, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_StrengthVsNormal = res;
				else
					Debug.LogError("Failed To Convert _StrengthVsNormal string: "+ __StrengthVsNormal +" to float");
			}
			{
			int res;
				if(int.TryParse(__ElementalColorRed, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_ElementalColorRed = res;
				else
					Debug.LogError("Failed To Convert _ElementalColorRed string: "+ __ElementalColorRed +" to int");
			}
			{
			int res;
				if(int.TryParse(__ElementalColorGreen, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_ElementalColorGreen = res;
				else
					Debug.LogError("Failed To Convert _ElementalColorGreen string: "+ __ElementalColorGreen +" to int");
			}
			{
			int res;
				if(int.TryParse(__ElementalColorBlue, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_ElementalColorBlue = res;
				else
					Debug.LogError("Failed To Convert _ElementalColorBlue string: "+ __ElementalColorBlue +" to int");
			}
		}

		public int Length { get { return 15; } }

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
					ret = _ElementName.ToString();
					break;
				case 2:
					ret = _ElementFlag.ToString();
					break;
				case 3:
					ret = _Description.ToString();
					break;
				case 4:
					ret = _StrengthVsEarth.ToString();
					break;
				case 5:
					ret = _StrengthVsWater.ToString();
					break;
				case 6:
					ret = _StrengthVsIce.ToString();
					break;
				case 7:
					ret = _StrengthVsAir.ToString();
					break;
				case 8:
					ret = _StrengthVsFire.ToString();
					break;
				case 9:
					ret = _StrengthVsArcane.ToString();
					break;
				case 10:
					ret = _StrengthVsElectric.ToString();
					break;
				case 11:
					ret = _StrengthVsNormal.ToString();
					break;
				case 12:
					ret = _ElementalColorRed.ToString();
					break;
				case 13:
					ret = _ElementalColorGreen.ToString();
					break;
				case 14:
					ret = _ElementalColorBlue.ToString();
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
				case "ElementName":
					ret = _ElementName.ToString();
					break;
				case "ElementFlag":
					ret = _ElementFlag.ToString();
					break;
				case "Description":
					ret = _Description.ToString();
					break;
				case "StrengthVsEarth":
					ret = _StrengthVsEarth.ToString();
					break;
				case "StrengthVsWater":
					ret = _StrengthVsWater.ToString();
					break;
				case "StrengthVsIce":
					ret = _StrengthVsIce.ToString();
					break;
				case "StrengthVsAir":
					ret = _StrengthVsAir.ToString();
					break;
				case "StrengthVsFire":
					ret = _StrengthVsFire.ToString();
					break;
				case "StrengthVsArcane":
					ret = _StrengthVsArcane.ToString();
					break;
				case "StrengthVsElectric":
					ret = _StrengthVsElectric.ToString();
					break;
				case "StrengthVsNormal":
					ret = _StrengthVsNormal.ToString();
					break;
				case "ElementalColorRed":
					ret = _ElementalColorRed.ToString();
					break;
				case "ElementalColorGreen":
					ret = _ElementalColorGreen.ToString();
					break;
				case "ElementalColorBlue":
					ret = _ElementalColorBlue.ToString();
					break;
			}

			return ret;
		}
		public override string ToString()
		{
			string ret = System.String.Empty;
			ret += "{" + "ID" + " : " + _ID.ToString() + "} ";
			ret += "{" + "ElementName" + " : " + _ElementName.ToString() + "} ";
			ret += "{" + "ElementFlag" + " : " + _ElementFlag.ToString() + "} ";
			ret += "{" + "Description" + " : " + _Description.ToString() + "} ";
			ret += "{" + "StrengthVsEarth" + " : " + _StrengthVsEarth.ToString() + "} ";
			ret += "{" + "StrengthVsWater" + " : " + _StrengthVsWater.ToString() + "} ";
			ret += "{" + "StrengthVsIce" + " : " + _StrengthVsIce.ToString() + "} ";
			ret += "{" + "StrengthVsAir" + " : " + _StrengthVsAir.ToString() + "} ";
			ret += "{" + "StrengthVsFire" + " : " + _StrengthVsFire.ToString() + "} ";
			ret += "{" + "StrengthVsArcane" + " : " + _StrengthVsArcane.ToString() + "} ";
			ret += "{" + "StrengthVsElectric" + " : " + _StrengthVsElectric.ToString() + "} ";
			ret += "{" + "StrengthVsNormal" + " : " + _StrengthVsNormal.ToString() + "} ";
			ret += "{" + "ElementalColorRed" + " : " + _ElementalColorRed.ToString() + "} ";
			ret += "{" + "ElementalColorGreen" + " : " + _ElementalColorGreen.ToString() + "} ";
			ret += "{" + "ElementalColorBlue" + " : " + _ElementalColorBlue.ToString() + "} ";
			return ret;
		}
	}
	public sealed class ElementTypes : IGoogle2uDB
	{
		public enum rowIds {
			ET_EARTH, ET_WATER, ET_ICE, ET_AIR, ET_FIRE, ET_ARCANE, ET_ELECTRIC, ET_NORMAL
		};
		public string [] rowNames = {
			"ET_EARTH", "ET_WATER", "ET_ICE", "ET_AIR", "ET_FIRE", "ET_ARCANE", "ET_ELECTRIC", "ET_NORMAL"
		};
		public System.Collections.Generic.List<ElementTypesRow> Rows = new System.Collections.Generic.List<ElementTypesRow>();

		public static ElementTypes Instance
		{
			get { return NestedElementTypes.instance; }
		}

		private class NestedElementTypes
		{
			static NestedElementTypes() { }
			internal static readonly ElementTypes instance = new ElementTypes();
		}

		private ElementTypes()
		{
			Rows.Add( new ElementTypesRow("ET_EARTH", "1", "Earth", "1", "", "0.5", "1", "1.5", "0.5", "1.5", "1", "1", "1", "39", "174", "96"));
			Rows.Add( new ElementTypesRow("ET_WATER", "2", "Water", "2", "", "1", "0.5", "1", "1.5", "0.5", "0.5", "1.5", "1", "41", "128", "185"));
			Rows.Add( new ElementTypesRow("ET_ICE", "3", "Ice", "4", "", "0.5", "1", "0.5", "1.5", "1.5", "1", "1.5", "1", "242", "251", "250"));
			Rows.Add( new ElementTypesRow("ET_AIR", "4", "Air", "8", "", "1.5", "0.5", "0.5", "0.5", "1", "1.5", "0.5", "1", "216", "206", "244"));
			Rows.Add( new ElementTypesRow("ET_FIRE", "5", "Fire", "16", "", "0.5", "1.5", "0.5", "1", "0.5", "0.5", "0.5", "1", "211", "84", "0"));
			Rows.Add( new ElementTypesRow("ET_ARCANE", "6", "Arcane", "32", "", "1", "1.5", "1.5", "0.5", "1", "0.5", "1", "1", "142", "68", "173"));
			Rows.Add( new ElementTypesRow("ET_ELECTRIC", "7", "Electric", "64", "", "1.5", "0.5", "1", "1", "0.5", "1.5", "0.5", "1", "243", "156", "18"));
			Rows.Add( new ElementTypesRow("ET_NORMAL", "8", "Normal", "128", "", "1", "1", "1", "1", "1", "1", "1", "1", "28", "179", "225"));
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
		public ElementTypesRow GetRow(rowIds in_RowID)
		{
			ElementTypesRow ret = null;
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
		public ElementTypesRow GetRow(string in_RowString)
		{
			ElementTypesRow ret = null;
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
