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
	public class XPDevelopmentModelsRow : IGoogle2uRow
	{
		public int _ID;
		public string _Name;
		public string _Formula;
		public float _Level2XP;
		public int _Level50XP;
		public XPDevelopmentModelsRow(string __GOOGLEFU_ID, string __ID, string __Name, string __Formula, string __Level2XP, string __Level50XP) 
		{
			{
			int res;
				if(int.TryParse(__ID, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_ID = res;
				else
					Debug.LogError("Failed To Convert _ID string: "+ __ID +" to int");
			}
			_Name = __Name.Trim();
			_Formula = __Formula.Trim();
			{
			float res;
				if(float.TryParse(__Level2XP, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_Level2XP = res;
				else
					Debug.LogError("Failed To Convert _Level2XP string: "+ __Level2XP +" to float");
			}
			{
			int res;
				if(int.TryParse(__Level50XP, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_Level50XP = res;
				else
					Debug.LogError("Failed To Convert _Level50XP string: "+ __Level50XP +" to int");
			}
		}

		public int Length { get { return 5; } }

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
					ret = _Formula.ToString();
					break;
				case 3:
					ret = _Level2XP.ToString();
					break;
				case 4:
					ret = _Level50XP.ToString();
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
				case "Formula":
					ret = _Formula.ToString();
					break;
				case "Level2XP":
					ret = _Level2XP.ToString();
					break;
				case "Level50XP":
					ret = _Level50XP.ToString();
					break;
			}

			return ret;
		}
		public override string ToString()
		{
			string ret = System.String.Empty;
			ret += "{" + "ID" + " : " + _ID.ToString() + "} ";
			ret += "{" + "Name" + " : " + _Name.ToString() + "} ";
			ret += "{" + "Formula" + " : " + _Formula.ToString() + "} ";
			ret += "{" + "Level2XP" + " : " + _Level2XP.ToString() + "} ";
			ret += "{" + "Level50XP" + " : " + _Level50XP.ToString() + "} ";
			return ret;
		}
	}
	public sealed class XPDevelopmentModels : IGoogle2uDB
	{
		public enum rowIds {
			XP_MODELFAST, XP_MODELMEDIUM, XP_MODELSLOW
		};
		public string [] rowNames = {
			"XP_MODELFAST", "XP_MODELMEDIUM", "XP_MODELSLOW"
		};
		public System.Collections.Generic.List<XPDevelopmentModelsRow> Rows = new System.Collections.Generic.List<XPDevelopmentModelsRow>();

		public static XPDevelopmentModels Instance
		{
			get { return NestedXPDevelopmentModels.instance; }
		}

		private class NestedXPDevelopmentModels
		{
			static NestedXPDevelopmentModels() { }
			internal static readonly XPDevelopmentModels instance = new XPDevelopmentModels();
		}

		private XPDevelopmentModels()
		{
			Rows.Add( new XPDevelopmentModelsRow("XP_MODELFAST", "1", "Fast", "4n^3/(5)", "6.4", "100000"));
			Rows.Add( new XPDevelopmentModelsRow("XP_MODELMEDIUM", "2", "Medium", "n^3", "8", "125000"));
			Rows.Add( new XPDevelopmentModelsRow("XP_MODELSLOW", "3", "Slow", "5n^3/(4)", "10", "156250"));
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
		public XPDevelopmentModelsRow GetRow(rowIds in_RowID)
		{
			XPDevelopmentModelsRow ret = null;
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
		public XPDevelopmentModelsRow GetRow(string in_RowString)
		{
			XPDevelopmentModelsRow ret = null;
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
