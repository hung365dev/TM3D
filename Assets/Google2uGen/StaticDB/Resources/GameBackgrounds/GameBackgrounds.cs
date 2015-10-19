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
	public class GameBackgroundsRow : IGoogle2uRow
	{
		public int _ID;
		public string _BackgroundName;
		public string _BackgroundFile;
		public string _DefaultBackgroundFor;
		public GameBackgroundsRow(string __GOOGLEFU_ID, string __ID, string __BackgroundName, string __BackgroundFile, string __DefaultBackgroundFor) 
		{
			{
			int res;
				if(int.TryParse(__ID, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_ID = res;
				else
					Debug.LogError("Failed To Convert _ID string: "+ __ID +" to int");
			}
			_BackgroundName = __BackgroundName.Trim();
			_BackgroundFile = __BackgroundFile.Trim();
			_DefaultBackgroundFor = __DefaultBackgroundFor.Trim();
		}

		public int Length { get { return 4; } }

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
					ret = _BackgroundName.ToString();
					break;
				case 2:
					ret = _BackgroundFile.ToString();
					break;
				case 3:
					ret = _DefaultBackgroundFor.ToString();
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
				case "BackgroundName":
					ret = _BackgroundName.ToString();
					break;
				case "BackgroundFile":
					ret = _BackgroundFile.ToString();
					break;
				case "DefaultBackgroundFor":
					ret = _DefaultBackgroundFor.ToString();
					break;
			}

			return ret;
		}
		public override string ToString()
		{
			string ret = System.String.Empty;
			ret += "{" + "ID" + " : " + _ID.ToString() + "} ";
			ret += "{" + "BackgroundName" + " : " + _BackgroundName.ToString() + "} ";
			ret += "{" + "BackgroundFile" + " : " + _BackgroundFile.ToString() + "} ";
			ret += "{" + "DefaultBackgroundFor" + " : " + _DefaultBackgroundFor.ToString() + "} ";
			return ret;
		}
	}
	public sealed class GameBackgrounds : IGoogle2uDB
	{
		public enum rowIds {
			BBG_1, BBG_2, BBG_3, BBG_4, BBG_5, BBG_6, BBG_7, BBG_8, BBG_9, BBG_10, BBG_11, BBG_12, BBG_13, BBG_14, BBG_15, BBG_16, BBG_17, BBG_18
			, BBG_19, BBG_20, BBG_21
		};
		public string [] rowNames = {
			"BBG_1", "BBG_2", "BBG_3", "BBG_4", "BBG_5", "BBG_6", "BBG_7", "BBG_8", "BBG_9", "BBG_10", "BBG_11", "BBG_12", "BBG_13", "BBG_14", "BBG_15", "BBG_16", "BBG_17", "BBG_18"
			, "BBG_19", "BBG_20", "BBG_21"
		};
		public System.Collections.Generic.List<GameBackgroundsRow> Rows = new System.Collections.Generic.List<GameBackgroundsRow>();

		public static GameBackgrounds Instance
		{
			get { return NestedGameBackgrounds.instance; }
		}

		private class NestedGameBackgrounds
		{
			static NestedGameBackgrounds() { }
			internal static readonly GameBackgrounds instance = new GameBackgrounds();
		}

		private GameBackgrounds()
		{
			Rows.Add( new GameBackgroundsRow("BBG_1", "1", "Town 1", "verdaneedit", "Earth"));
			Rows.Add( new GameBackgroundsRow("BBG_2", "2", "Office 1", "inoffice", "Normal"));
			Rows.Add( new GameBackgroundsRow("BBG_3", "3", "Grass 1 ", "grassland", "Normal"));
			Rows.Add( new GameBackgroundsRow("BBG_4", "4", "Lake 1", "grassland", "Normal"));
			Rows.Add( new GameBackgroundsRow("BBG_5", "5", "Sea 1", "beach2", "Water"));
			Rows.Add( new GameBackgroundsRow("BBG_6", "6", "Sand 1 ", "sandbg", "Normal"));
			Rows.Add( new GameBackgroundsRow("BBG_7", "7", "Arcane 1 ", "arcane", "Arcane"));
			Rows.Add( new GameBackgroundsRow("BBG_8", "8", "Colosseum 1 ", "colo", "Normal"));
			Rows.Add( new GameBackgroundsRow("BBG_9", "9", "Fire 1 ", "outsidevol", "Normal"));
			Rows.Add( new GameBackgroundsRow("BBG_10", "10", "Volcano 1", "involcano", "Fire"));
			Rows.Add( new GameBackgroundsRow("BBG_11", "11", "Snow 1", "snowbattle", "Normal"));
			Rows.Add( new GameBackgroundsRow("BBG_12", "12", "Dojo 1 ", "dojo", "Normal"));
			Rows.Add( new GameBackgroundsRow("BBG_13", "13", "Waste 1 ", "wastelandfield", "Electric"));
			Rows.Add( new GameBackgroundsRow("BBG_14", "14", "Cave", "cave", "Normal"));
			Rows.Add( new GameBackgroundsRow("BBG_15", "15", "Power Plant", "powerplant", "Normal"));
			Rows.Add( new GameBackgroundsRow("BBG_16", "16", "Ice Cave", "IceCaev", "Ice"));
			Rows.Add( new GameBackgroundsRow("BBG_17", "17", "Savannah", "savannah", "Normal"));
			Rows.Add( new GameBackgroundsRow("BBG_18", "18", "Jungle", "jungle", "Air"));
			Rows.Add( new GameBackgroundsRow("BBG_19", "19", "Oasis", "sandbattle", "Normal"));
			Rows.Add( new GameBackgroundsRow("BBG_20", "20", "Savannah Sunset", "savannah-evening", "Normal"));
			Rows.Add( new GameBackgroundsRow("BBG_21", "21", "", "", "Normal"));
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
		public GameBackgroundsRow GetRow(rowIds in_RowID)
		{
			GameBackgroundsRow ret = null;
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
		public GameBackgroundsRow GetRow(string in_RowString)
		{
			GameBackgroundsRow ret = null;
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
