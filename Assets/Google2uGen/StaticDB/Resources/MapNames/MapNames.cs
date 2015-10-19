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
	public class MapNamesRow : IGoogle2uRow
	{
		public int _ID;
		public string _Name;
		public string _FileName;
		public float _DefaultStartX;
		public float _DefaultStartY;
		public string _ReparentMap;
		public bool _IsStartMap;
		public MapNamesRow(string __GOOGLEFU_ID, string __ID, string __Name, string __FileName, string __DefaultStartX, string __DefaultStartY, string __ReparentMap, string __IsStartMap) 
		{
			{
			int res;
				if(int.TryParse(__ID, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_ID = res;
				else
					Debug.LogError("Failed To Convert _ID string: "+ __ID +" to int");
			}
			_Name = __Name.Trim();
			_FileName = __FileName.Trim();
			{
			float res;
				if(float.TryParse(__DefaultStartX, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_DefaultStartX = res;
				else
					Debug.LogError("Failed To Convert _DefaultStartX string: "+ __DefaultStartX +" to float");
			}
			{
			float res;
				if(float.TryParse(__DefaultStartY, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_DefaultStartY = res;
				else
					Debug.LogError("Failed To Convert _DefaultStartY string: "+ __DefaultStartY +" to float");
			}
			_ReparentMap = __ReparentMap.Trim();
			{
			bool res;
				if(bool.TryParse(__IsStartMap, out res))
					_IsStartMap = res;
				else
					Debug.LogError("Failed To Convert _IsStartMap string: "+ __IsStartMap +" to bool");
			}
		}

		public int Length { get { return 7; } }

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
					ret = _FileName.ToString();
					break;
				case 3:
					ret = _DefaultStartX.ToString();
					break;
				case 4:
					ret = _DefaultStartY.ToString();
					break;
				case 5:
					ret = _ReparentMap.ToString();
					break;
				case 6:
					ret = _IsStartMap.ToString();
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
				case "FileName":
					ret = _FileName.ToString();
					break;
				case "DefaultStartX":
					ret = _DefaultStartX.ToString();
					break;
				case "DefaultStartY":
					ret = _DefaultStartY.ToString();
					break;
				case "ReparentMap":
					ret = _ReparentMap.ToString();
					break;
				case "IsStartMap":
					ret = _IsStartMap.ToString();
					break;
			}

			return ret;
		}
		public override string ToString()
		{
			string ret = System.String.Empty;
			ret += "{" + "ID" + " : " + _ID.ToString() + "} ";
			ret += "{" + "Name" + " : " + _Name.ToString() + "} ";
			ret += "{" + "FileName" + " : " + _FileName.ToString() + "} ";
			ret += "{" + "DefaultStartX" + " : " + _DefaultStartX.ToString() + "} ";
			ret += "{" + "DefaultStartY" + " : " + _DefaultStartY.ToString() + "} ";
			ret += "{" + "ReparentMap" + " : " + _ReparentMap.ToString() + "} ";
			ret += "{" + "IsStartMap" + " : " + _IsStartMap.ToString() + "} ";
			return ret;
		}
	}
	public sealed class MapNames : IGoogle2uDB
	{
		public enum rowIds {
			MAP_TEST, MAP_SMALL, MAP_MISHI, MAP_KIOSHI, MAP_ROUTE1, MAP_NAMANJA, MAP_NAMANJAHQ, MAP_NAMANJACAVE, MAP_CLEARING, MAP_MISHIHQ, MAP_OUADDAHQ, MAP_JINJAHQ, MAP_KISMAYOHQ, MAP_MOMBASSIHQ, MAP_ARCANEGUILD, MAP_JINJAGUILD, MAP_KISMAYOGUILD, MAP_MISHIGUILD
			, MAP_MOMBASSIGUILD, MAP_NAMANJAGUILD, MAP_OUADDAGUILD, MAP_KALOMIHOMES, MAP_KISMAYOHOMES, MAP_KYEROHHOME, MAP_MISHIHOME, MAP_MOMBASSIHOME, MAP_NAMANJAHOME, MAP_OUADDAHOME, MAP_OUADDA, MAP_POWERPLANT, MAP_JINJA, MAP_TRAIL4, MAP_JINJAREBELBASE, MAP_LAKENYAZA, MAP_TRAIL5, MAP_VOLCANO, MAP_KISMAYO, MAP_MOMBASSI
			, MAP_ALKUBRA, MAP_ALKUBRACAVE, MAP_ICECAVE, MAP_KYEROH, MAP_KYEROHPRISON, MAP_GUILDLAND, MAP_TAURYSOSCAVE
		};
		public string [] rowNames = {
			"MAP_TEST", "MAP_SMALL", "MAP_MISHI", "MAP_KIOSHI", "MAP_ROUTE1", "MAP_NAMANJA", "MAP_NAMANJAHQ", "MAP_NAMANJACAVE", "MAP_CLEARING", "MAP_MISHIHQ", "MAP_OUADDAHQ", "MAP_JINJAHQ", "MAP_KISMAYOHQ", "MAP_MOMBASSIHQ", "MAP_ARCANEGUILD", "MAP_JINJAGUILD", "MAP_KISMAYOGUILD", "MAP_MISHIGUILD"
			, "MAP_MOMBASSIGUILD", "MAP_NAMANJAGUILD", "MAP_OUADDAGUILD", "MAP_KALOMIHOMES", "MAP_KISMAYOHOMES", "MAP_KYEROHHOME", "MAP_MISHIHOME", "MAP_MOMBASSIHOME", "MAP_NAMANJAHOME", "MAP_OUADDAHOME", "MAP_OUADDA", "MAP_POWERPLANT", "MAP_JINJA", "MAP_TRAIL4", "MAP_JINJAREBELBASE", "MAP_LAKENYAZA", "MAP_TRAIL5", "MAP_VOLCANO", "MAP_KISMAYO", "MAP_MOMBASSI"
			, "MAP_ALKUBRA", "MAP_ALKUBRACAVE", "MAP_ICECAVE", "MAP_KYEROH", "MAP_KYEROHPRISON", "MAP_GUILDLAND", "MAP_TAURYSOSCAVE"
		};
		public System.Collections.Generic.List<MapNamesRow> Rows = new System.Collections.Generic.List<MapNamesRow>();

		public static MapNames Instance
		{
			get { return NestedMapNames.instance; }
		}

		private class NestedMapNames
		{
			static NestedMapNames() { }
			internal static readonly MapNames instance = new MapNames();
		}

		private MapNames()
		{
			Rows.Add( new MapNamesRow("MAP_TEST", "1", "Game Test Map", "GameTestMap", "39", "39", "", "FALSE"));
			Rows.Add( new MapNamesRow("MAP_SMALL", "2", "Smaller Map", "SmallerMap1", "3", "3", "", "FALSE"));
			Rows.Add( new MapNamesRow("MAP_MISHI", "3", "Mishi", "MishiMap", "8", "8", "", "FALSE"));
			Rows.Add( new MapNamesRow("MAP_KIOSHI", "4", "Kalomi", "KalomiMap", "31", "38", "", "TRUE"));
			Rows.Add( new MapNamesRow("MAP_ROUTE1", "5", "Trail 1", "Trail1", "10", "240", "", "FALSE"));
			Rows.Add( new MapNamesRow("MAP_NAMANJA", "6", "Namanja", "NamanjaMap", "28", "247.11", "", "FALSE"));
			Rows.Add( new MapNamesRow("MAP_NAMANJAHQ", "7", "Namanja HQ", "NamanjaHQ", "63.553", "105.11", "", "FALSE"));
			Rows.Add( new MapNamesRow("MAP_NAMANJACAVE", "8", "Namanja Cave", "Trail2", "77", "30.3", "", "FALSE"));
			Rows.Add( new MapNamesRow("MAP_CLEARING", "9", "Clearing", "Trail3", "20.9", "12.3", "", "FALSE"));
			Rows.Add( new MapNamesRow("MAP_MISHIHQ", "10", "Mishi HQ", "MishiHQ", "63.553", "105.11", "", "FALSE"));
			Rows.Add( new MapNamesRow("MAP_OUADDAHQ", "11", "Ouadda HQ", "OuaddaHQ", "63.553", "105.11", "", "FALSE"));
			Rows.Add( new MapNamesRow("MAP_JINJAHQ", "12", "Jinja HQ", "JinjaHQ", "63.553", "105.11", "", "FALSE"));
			Rows.Add( new MapNamesRow("MAP_KISMAYOHQ", "13", "Kismayo HQ", "KismayoHQ", "63.553", "105.11", "", "FALSE"));
			Rows.Add( new MapNamesRow("MAP_MOMBASSIHQ", "14", "Crystal Corp HQ", "MombassiHQ", "109.6", "26.5", "", "FALSE"));
			Rows.Add( new MapNamesRow("MAP_ARCANEGUILD", "15", "Arcane Guild", "ArcaneGuild", "60.7", "117", "", "FALSE"));
			Rows.Add( new MapNamesRow("MAP_JINJAGUILD", "16", "Jinja Guild", "JinjaGuild", "60.7", "117", "", "FALSE"));
			Rows.Add( new MapNamesRow("MAP_KISMAYOGUILD", "17", "Kismayo Guild", "KismayoGuild", "60.7", "117", "", "FALSE"));
			Rows.Add( new MapNamesRow("MAP_MISHIGUILD", "18", "Mishi Guild", "MishiGuild", "57.5", "120.6", "", "FALSE"));
			Rows.Add( new MapNamesRow("MAP_MOMBASSIGUILD", "19", "Mombassi Guild", "MombassiGuild", "60.7", "117", "", "FALSE"));
			Rows.Add( new MapNamesRow("MAP_NAMANJAGUILD", "20", "Namanja Guild", "NamanjaGuild", "60.7", "117", "", "FALSE"));
			Rows.Add( new MapNamesRow("MAP_OUADDAGUILD", "21", "Ouadda Guild", "OuaddaGuild", "60.7", "117", "", "FALSE"));
			Rows.Add( new MapNamesRow("MAP_KALOMIHOMES", "22", "Kalomi House", "KalomiHomes", "0", "0", "KalomiMap", "FALSE"));
			Rows.Add( new MapNamesRow("MAP_KISMAYOHOMES", "23", "Kismayo House", "KismayoHomes", "0", "0", "Kismayo", "FALSE"));
			Rows.Add( new MapNamesRow("MAP_KYEROHHOME", "24", "Kyeroh House", "KyerohHome", "0", "0", "Kyeroh", "FALSE"));
			Rows.Add( new MapNamesRow("MAP_MISHIHOME", "25", "Mishi House", "MishiHome", "0", "0", "Mishi", "FALSE"));
			Rows.Add( new MapNamesRow("MAP_MOMBASSIHOME", "26", "Mombassi House", "MombassiHomes", "0", "0", "Mombassi", "FALSE"));
			Rows.Add( new MapNamesRow("MAP_NAMANJAHOME", "27", "Namanja House", "NamanjaHome", "0", "0", "Namanja", "FALSE"));
			Rows.Add( new MapNamesRow("MAP_OUADDAHOME", "28", "Ouadda House", "OuaddaHome", "0", "0", "Ouadda", "FALSE"));
			Rows.Add( new MapNamesRow("MAP_OUADDA", "29", "Ouadda", "Ouadda", "16", "19", "", "FALSE"));
			Rows.Add( new MapNamesRow("MAP_POWERPLANT", "30", "Power Plant", "PowerPlant", "61.504", "79.665", "", "FALSE"));
			Rows.Add( new MapNamesRow("MAP_JINJA", "31", "Jinja", "Jinja", "236", "154", "", "FALSE"));
			Rows.Add( new MapNamesRow("MAP_TRAIL4", "32", "Mountain Trail", "Trail4", "128.7", "7", "", "FALSE"));
			Rows.Add( new MapNamesRow("MAP_JINJAREBELBASE", "33", "Rebel Base", "JinjaRebelBase", "63.7", "104.5", "", "FALSE"));
			Rows.Add( new MapNamesRow("MAP_LAKENYAZA", "34", "Lake Nyaza", "LakeNyaza", "245", "128", "", "FALSE"));
			Rows.Add( new MapNamesRow("MAP_TRAIL5", "35", "Volcano Trail", "Trail5", "44.4", "196.8", "", "FALSE"));
			Rows.Add( new MapNamesRow("MAP_VOLCANO", "36", "Volcano Erta", "Volcano Erta", "102", "4", "", "FALSE"));
			Rows.Add( new MapNamesRow("MAP_KISMAYO", "37", "Kismayo", "Kismayo", "9.1", "14", "", "FALSE"));
			Rows.Add( new MapNamesRow("MAP_MOMBASSI", "38", "Mombassi", "Mombassi", "250", "78", "", "FALSE"));
			Rows.Add( new MapNamesRow("MAP_ALKUBRA", "39", "Al Kubra", "Al Kubra", "133", "7", "", "FALSE"));
			Rows.Add( new MapNamesRow("MAP_ALKUBRACAVE", "40", "Al Kubra Cave", "Al Kubra Cave", "75", "4", "", "FALSE"));
			Rows.Add( new MapNamesRow("MAP_ICECAVE", "41", "IceCave", "IceCave", "72.5", "5.3", "", "FALSE"));
			Rows.Add( new MapNamesRow("MAP_KYEROH", "42", "Kyeroh", "Kyeroh", "121", "8", "", "FALSE"));
			Rows.Add( new MapNamesRow("MAP_KYEROHPRISON", "43", "Kyeroh Prison", "KyeRohPrison", "101", "31", "", "FALSE"));
			Rows.Add( new MapNamesRow("MAP_GUILDLAND", "44", "Guild Land", "Mishi Cave", "60", "11", "", "FALSE"));
			Rows.Add( new MapNamesRow("MAP_TAURYSOSCAVE", "45", "Mountain Cave", "Mountain Cave", "128.5", "7", "", "FALSE"));
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
		public MapNamesRow GetRow(rowIds in_RowID)
		{
			MapNamesRow ret = null;
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
		public MapNamesRow GetRow(string in_RowString)
		{
			MapNamesRow ret = null;
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
