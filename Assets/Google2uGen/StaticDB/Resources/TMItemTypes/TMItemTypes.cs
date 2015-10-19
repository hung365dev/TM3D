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
	public class TMItemTypesRow : IGoogle2uRow
	{
		public int _ID;
		public string _Name;
		public TMItemTypesRow(string __GOOGLEFU_ID, string __ID, string __Name) 
		{
			{
			int res;
				if(int.TryParse(__ID, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_ID = res;
				else
					Debug.LogError("Failed To Convert _ID string: "+ __ID +" to int");
			}
			_Name = __Name.Trim();
		}

		public int Length { get { return 2; } }

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
			}

			return ret;
		}
		public override string ToString()
		{
			string ret = System.String.Empty;
			ret += "{" + "ID" + " : " + _ID.ToString() + "} ";
			ret += "{" + "Name" + " : " + _Name.ToString() + "} ";
			return ret;
		}
	}
	public sealed class TMItemTypes : IGoogle2uDB
	{
		public enum rowIds {
			IT_CRYSTAL, IT_POTION, IT_BAIT, IT_BOOST, IT_XPBOOST
		};
		public string [] rowNames = {
			"IT_CRYSTAL", "IT_POTION", "IT_BAIT", "IT_BOOST", "IT_XPBOOST"
		};
		public System.Collections.Generic.List<TMItemTypesRow> Rows = new System.Collections.Generic.List<TMItemTypesRow>();

		public static TMItemTypes Instance
		{
			get { return NestedTMItemTypes.instance; }
		}

		private class NestedTMItemTypes
		{
			static NestedTMItemTypes() { }
			internal static readonly TMItemTypes instance = new TMItemTypes();
		}

		private TMItemTypes()
		{
			Rows.Add( new TMItemTypesRow("IT_CRYSTAL", "1", "Crystal"));
			Rows.Add( new TMItemTypesRow("IT_POTION", "2", "Potion"));
			Rows.Add( new TMItemTypesRow("IT_BAIT", "4", "Bait"));
			Rows.Add( new TMItemTypesRow("IT_BOOST", "8", "Boost"));
			Rows.Add( new TMItemTypesRow("IT_XPBOOST", "16", "XPBoost"));
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
		public TMItemTypesRow GetRow(rowIds in_RowID)
		{
			TMItemTypesRow ret = null;
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
		public TMItemTypesRow GetRow(string in_RowString)
		{
			TMItemTypesRow ret = null;
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
