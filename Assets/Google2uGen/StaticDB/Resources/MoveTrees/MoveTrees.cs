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
	public class MoveTreesRow : IGoogle2uRow
	{
		public int _ID;
		public string _Name;
		public string _DisplayName;
		public MoveTreesRow(string __GOOGLEFU_ID, string __ID, string __Name, string __DisplayName) 
		{
			{
			int res;
				if(int.TryParse(__ID, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_ID = res;
				else
					Debug.LogError("Failed To Convert _ID string: "+ __ID +" to int");
			}
			_Name = __Name.Trim();
			_DisplayName = __DisplayName.Trim();
		}

		public int Length { get { return 3; } }

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
					ret = _DisplayName.ToString();
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
				case "DisplayName":
					ret = _DisplayName.ToString();
					break;
			}

			return ret;
		}
		public override string ToString()
		{
			string ret = System.String.Empty;
			ret += "{" + "ID" + " : " + _ID.ToString() + "} ";
			ret += "{" + "Name" + " : " + _Name.ToString() + "} ";
			ret += "{" + "DisplayName" + " : " + _DisplayName.ToString() + "} ";
			return ret;
		}
	}
	public sealed class MoveTrees : IGoogle2uDB
	{
		public enum rowIds {
			MTO_NORMAL, MTO_AIR, MTO_ARCANE, MTO_EARTH, MTO_ELECTRIC, MTO_FIRE, MTO_ICE, MTO_WATER
		};
		public string [] rowNames = {
			"MTO_NORMAL", "MTO_AIR", "MTO_ARCANE", "MTO_EARTH", "MTO_ELECTRIC", "MTO_FIRE", "MTO_ICE", "MTO_WATER"
		};
		public System.Collections.Generic.List<MoveTreesRow> Rows = new System.Collections.Generic.List<MoveTreesRow>();

		public static MoveTrees Instance
		{
			get { return NestedMoveTrees.instance; }
		}

		private class NestedMoveTrees
		{
			static NestedMoveTrees() { }
			internal static readonly MoveTrees instance = new MoveTrees();
		}

		private MoveTrees()
		{
			Rows.Add( new MoveTreesRow("MTO_NORMAL", "1", "Normal Move Tree", "Normal"));
			Rows.Add( new MoveTreesRow("MTO_AIR", "2", "Air Move Tree", "Air"));
			Rows.Add( new MoveTreesRow("MTO_ARCANE", "3", "Arcane Move Tree", "Arcane"));
			Rows.Add( new MoveTreesRow("MTO_EARTH", "4", "Earth Move Tree", "Earth"));
			Rows.Add( new MoveTreesRow("MTO_ELECTRIC", "5", "Electric Move Tree", "Electric"));
			Rows.Add( new MoveTreesRow("MTO_FIRE", "6", "Fire Move Tree", "Fire"));
			Rows.Add( new MoveTreesRow("MTO_ICE", "7", "Ice Move Tree", "Ice"));
			Rows.Add( new MoveTreesRow("MTO_WATER", "8", "Water Move Tree", "Water"));
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
		public MoveTreesRow GetRow(rowIds in_RowID)
		{
			MoveTreesRow ret = null;
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
		public MoveTreesRow GetRow(string in_RowString)
		{
			MoveTreesRow ret = null;
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
