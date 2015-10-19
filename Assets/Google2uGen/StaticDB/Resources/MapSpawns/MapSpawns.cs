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
	public class MapSpawnsRow : IGoogle2uRow
	{
		public int _ID;
		public string _MapName;
		public int _Trigger;
		public string _MonsterA;
		public int _MonsterLevelA;
		public float _MonsterAFrequency;
		public string _MonsterB;
		public int _MonsterLevelB;
		public float _MonsterBFrequency;
		public string _MonsterC;
		public int _MonsterLevelC;
		public float _MonsterCFrequency;
		public string _MonsterD;
		public int _MonsterLevelD;
		public float _MonsterDFrequency;
		public string _SpawnMapBG;
		public string _SpawnMusic;
		public MapSpawnsRow(string __GOOGLEFU_ID, string __ID, string __MapName, string __Trigger, string __MonsterA, string __MonsterLevelA, string __MonsterAFrequency, string __MonsterB, string __MonsterLevelB, string __MonsterBFrequency, string __MonsterC, string __MonsterLevelC, string __MonsterCFrequency, string __MonsterD, string __MonsterLevelD, string __MonsterDFrequency, string __SpawnMapBG, string __SpawnMusic) 
		{
			{
			int res;
				if(int.TryParse(__ID, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_ID = res;
				else
					Debug.LogError("Failed To Convert _ID string: "+ __ID +" to int");
			}
			_MapName = __MapName.Trim();
			{
			int res;
				if(int.TryParse(__Trigger, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_Trigger = res;
				else
					Debug.LogError("Failed To Convert _Trigger string: "+ __Trigger +" to int");
			}
			_MonsterA = __MonsterA.Trim();
			{
			int res;
				if(int.TryParse(__MonsterLevelA, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_MonsterLevelA = res;
				else
					Debug.LogError("Failed To Convert _MonsterLevelA string: "+ __MonsterLevelA +" to int");
			}
			{
			float res;
				if(float.TryParse(__MonsterAFrequency, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_MonsterAFrequency = res;
				else
					Debug.LogError("Failed To Convert _MonsterAFrequency string: "+ __MonsterAFrequency +" to float");
			}
			_MonsterB = __MonsterB.Trim();
			{
			int res;
				if(int.TryParse(__MonsterLevelB, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_MonsterLevelB = res;
				else
					Debug.LogError("Failed To Convert _MonsterLevelB string: "+ __MonsterLevelB +" to int");
			}
			{
			float res;
				if(float.TryParse(__MonsterBFrequency, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_MonsterBFrequency = res;
				else
					Debug.LogError("Failed To Convert _MonsterBFrequency string: "+ __MonsterBFrequency +" to float");
			}
			_MonsterC = __MonsterC.Trim();
			{
			int res;
				if(int.TryParse(__MonsterLevelC, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_MonsterLevelC = res;
				else
					Debug.LogError("Failed To Convert _MonsterLevelC string: "+ __MonsterLevelC +" to int");
			}
			{
			float res;
				if(float.TryParse(__MonsterCFrequency, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_MonsterCFrequency = res;
				else
					Debug.LogError("Failed To Convert _MonsterCFrequency string: "+ __MonsterCFrequency +" to float");
			}
			_MonsterD = __MonsterD.Trim();
			{
			int res;
				if(int.TryParse(__MonsterLevelD, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_MonsterLevelD = res;
				else
					Debug.LogError("Failed To Convert _MonsterLevelD string: "+ __MonsterLevelD +" to int");
			}
			{
			float res;
				if(float.TryParse(__MonsterDFrequency, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_MonsterDFrequency = res;
				else
					Debug.LogError("Failed To Convert _MonsterDFrequency string: "+ __MonsterDFrequency +" to float");
			}
			_SpawnMapBG = __SpawnMapBG.Trim();
			_SpawnMusic = __SpawnMusic.Trim();
		}

		public int Length { get { return 17; } }

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
					ret = _MapName.ToString();
					break;
				case 2:
					ret = _Trigger.ToString();
					break;
				case 3:
					ret = _MonsterA.ToString();
					break;
				case 4:
					ret = _MonsterLevelA.ToString();
					break;
				case 5:
					ret = _MonsterAFrequency.ToString();
					break;
				case 6:
					ret = _MonsterB.ToString();
					break;
				case 7:
					ret = _MonsterLevelB.ToString();
					break;
				case 8:
					ret = _MonsterBFrequency.ToString();
					break;
				case 9:
					ret = _MonsterC.ToString();
					break;
				case 10:
					ret = _MonsterLevelC.ToString();
					break;
				case 11:
					ret = _MonsterCFrequency.ToString();
					break;
				case 12:
					ret = _MonsterD.ToString();
					break;
				case 13:
					ret = _MonsterLevelD.ToString();
					break;
				case 14:
					ret = _MonsterDFrequency.ToString();
					break;
				case 15:
					ret = _SpawnMapBG.ToString();
					break;
				case 16:
					ret = _SpawnMusic.ToString();
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
				case "MapName":
					ret = _MapName.ToString();
					break;
				case "Trigger":
					ret = _Trigger.ToString();
					break;
				case "MonsterA":
					ret = _MonsterA.ToString();
					break;
				case "MonsterLevelA":
					ret = _MonsterLevelA.ToString();
					break;
				case "MonsterAFrequency":
					ret = _MonsterAFrequency.ToString();
					break;
				case "MonsterB":
					ret = _MonsterB.ToString();
					break;
				case "MonsterLevelB":
					ret = _MonsterLevelB.ToString();
					break;
				case "MonsterBFrequency":
					ret = _MonsterBFrequency.ToString();
					break;
				case "MonsterC":
					ret = _MonsterC.ToString();
					break;
				case "MonsterLevelC":
					ret = _MonsterLevelC.ToString();
					break;
				case "MonsterCFrequency":
					ret = _MonsterCFrequency.ToString();
					break;
				case "MonsterD":
					ret = _MonsterD.ToString();
					break;
				case "MonsterLevelD":
					ret = _MonsterLevelD.ToString();
					break;
				case "MonsterDFrequency":
					ret = _MonsterDFrequency.ToString();
					break;
				case "SpawnMapBG":
					ret = _SpawnMapBG.ToString();
					break;
				case "SpawnMusic":
					ret = _SpawnMusic.ToString();
					break;
			}

			return ret;
		}
		public override string ToString()
		{
			string ret = System.String.Empty;
			ret += "{" + "ID" + " : " + _ID.ToString() + "} ";
			ret += "{" + "MapName" + " : " + _MapName.ToString() + "} ";
			ret += "{" + "Trigger" + " : " + _Trigger.ToString() + "} ";
			ret += "{" + "MonsterA" + " : " + _MonsterA.ToString() + "} ";
			ret += "{" + "MonsterLevelA" + " : " + _MonsterLevelA.ToString() + "} ";
			ret += "{" + "MonsterAFrequency" + " : " + _MonsterAFrequency.ToString() + "} ";
			ret += "{" + "MonsterB" + " : " + _MonsterB.ToString() + "} ";
			ret += "{" + "MonsterLevelB" + " : " + _MonsterLevelB.ToString() + "} ";
			ret += "{" + "MonsterBFrequency" + " : " + _MonsterBFrequency.ToString() + "} ";
			ret += "{" + "MonsterC" + " : " + _MonsterC.ToString() + "} ";
			ret += "{" + "MonsterLevelC" + " : " + _MonsterLevelC.ToString() + "} ";
			ret += "{" + "MonsterCFrequency" + " : " + _MonsterCFrequency.ToString() + "} ";
			ret += "{" + "MonsterD" + " : " + _MonsterD.ToString() + "} ";
			ret += "{" + "MonsterLevelD" + " : " + _MonsterLevelD.ToString() + "} ";
			ret += "{" + "MonsterDFrequency" + " : " + _MonsterDFrequency.ToString() + "} ";
			ret += "{" + "SpawnMapBG" + " : " + _SpawnMapBG.ToString() + "} ";
			ret += "{" + "SpawnMusic" + " : " + _SpawnMusic.ToString() + "} ";
			return ret;
		}
	}
	public sealed class MapSpawns : IGoogle2uDB
	{
		public enum rowIds {
			SPAWN_1, SPAWN_2, SPAWN_3, SPAWN_4, SPAWN_5, SPAWN_6, SPAWN_7, SPAWN_8, SPAWN_9, SPAWN_10, SPAWN_11, SPAWN_12, SPAWN_13, SPAWN_14, SPAWN_15, SPAWN_16, SPAWN_17, SPAWN_18
			, SPAWN_19, SPAWN_20, SPAWN_21, SPAWN_22, SPAWN_23, SPAWN_24, SPAWN_25, SPAWN_26, SPAWN_27, SPAWN_28, SPAWN_29, SPAWN_30, SPAWN_31, SPAWN_32, SPAWN_33, SPAWN_34, SPAWN_35, SPAWN_36, SPAWN_37, SPAWN_38
			, SPAWN_39, SPAWN_40, SPAWN_41, SPAWN_42, SPAWN_43, SPAWN_44, SPAWN_45, SPAWN_46, SPAWN_47, SPAWN_48, SPAWN_49, SPAWN_50, SPAWN_51, SPAWN_52, SPAWN_53, SPAWN_54, SPAWN_55, SPAWN_56, SPAWN_57, SPAWN_58
			, SPAWN_59, SPAWN_60, SPAWN_61, SPAWN_62, SPAWN_63, SPAWN_64, SPAWN_65, SPAWN_66, SPAWN_67, SPAWN_68, SPAWN_69, SPAWN_70, SPAWN_71, SPAWN_72, SPAWN_73, SPAWN_74, SPAWN_75, SPAWN_76, SPAWN_77, SPAWN_78
			, SPAWN_79, SPAWN_80, SPAWN_81, SPAWN_82, SPAWN_83, SPAWN_84, SPAWN_85, SPAWN_86, SPAWN_87, SPAWN_88, SPAWN_89
		};
		public string [] rowNames = {
			"SPAWN_1", "SPAWN_2", "SPAWN_3", "SPAWN_4", "SPAWN_5", "SPAWN_6", "SPAWN_7", "SPAWN_8", "SPAWN_9", "SPAWN_10", "SPAWN_11", "SPAWN_12", "SPAWN_13", "SPAWN_14", "SPAWN_15", "SPAWN_16", "SPAWN_17", "SPAWN_18"
			, "SPAWN_19", "SPAWN_20", "SPAWN_21", "SPAWN_22", "SPAWN_23", "SPAWN_24", "SPAWN_25", "SPAWN_26", "SPAWN_27", "SPAWN_28", "SPAWN_29", "SPAWN_30", "SPAWN_31", "SPAWN_32", "SPAWN_33", "SPAWN_34", "SPAWN_35", "SPAWN_36", "SPAWN_37", "SPAWN_38"
			, "SPAWN_39", "SPAWN_40", "SPAWN_41", "SPAWN_42", "SPAWN_43", "SPAWN_44", "SPAWN_45", "SPAWN_46", "SPAWN_47", "SPAWN_48", "SPAWN_49", "SPAWN_50", "SPAWN_51", "SPAWN_52", "SPAWN_53", "SPAWN_54", "SPAWN_55", "SPAWN_56", "SPAWN_57", "SPAWN_58"
			, "SPAWN_59", "SPAWN_60", "SPAWN_61", "SPAWN_62", "SPAWN_63", "SPAWN_64", "SPAWN_65", "SPAWN_66", "SPAWN_67", "SPAWN_68", "SPAWN_69", "SPAWN_70", "SPAWN_71", "SPAWN_72", "SPAWN_73", "SPAWN_74", "SPAWN_75", "SPAWN_76", "SPAWN_77", "SPAWN_78"
			, "SPAWN_79", "SPAWN_80", "SPAWN_81", "SPAWN_82", "SPAWN_83", "SPAWN_84", "SPAWN_85", "SPAWN_86", "SPAWN_87", "SPAWN_88", "SPAWN_89"
		};
		public System.Collections.Generic.List<MapSpawnsRow> Rows = new System.Collections.Generic.List<MapSpawnsRow>();

		public static MapSpawns Instance
		{
			get { return NestedMapSpawns.instance; }
		}

		private class NestedMapSpawns
		{
			static NestedMapSpawns() { }
			internal static readonly MapSpawns instance = new MapSpawns();
		}

		private MapSpawns()
		{
			Rows.Add( new MapSpawnsRow("SPAWN_1", "1", "Kalomi", "1", "Mothball", "2", "0.05", "Venox", "2", "0.05", "Ignitler", "2", "0.05", "", "2", "0.05", "Town 1", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_2", "2", "Kalomi", "2", "Mothball", "2", "0.05", "Venox", "2", "0.05", "Ignitler", "2", "0.05", "Electrosaurus", "2", "0.05", "Town 1", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_3", "3", "Kalomi", "3", "Lothea", "2", "0.05", "Lotheo", "2", "0.05", "Mothball", "2", "0.05", "", "2", "0.05", "Lake 1", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_4", "4", "Kalomi", "4", "Lothea", "2", "0.05", "Lotheo", "2", "0.05", "Mothball", "2", "0.05", "Alistinker", "2", "0.05", "Lake 1", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_5", "5", "Kalomi", "5", "Mothball", "2", "0.05", "Venox", "2", "0.05", "Tomaling", "2", "0.05", "Electrosaurus", "2", "0.05", "Town 1", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_6", "6", "Mishi", "1", "Racket", "2", "0.05", "Dragonfry", "2", "0.05", "Tomaling", "2", "0.05", "Tortipous", "2", "0.05", "Town 1", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_7", "7", "Mishi", "2", "Racket", "2", "0.05", "Dragonfry", "2", "0.05", "Tomaling", "2", "0.05", "Sappress", "2", "0.05", "Town 1", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_8", "8", "Mishi", "3", "Coralpie", "2", "0.05", "Scuda", "2", "0.05", "Flowgo", "2", "0.05", "Racket", "2", "0.05", "Grass 1 ", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_9", "9", "Mishi", "4", "Coralpie", "2", "0.05", "Scuda", "2", "0.05", "Tuffin", "2", "0.05", "Octicute", "2", "0.05", "Grass 1 ", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_10", "10", "Mishi", "5", "Gazolt", "35", "0.05", "Dozer", "34", "0.05", "Motharch", "37", "0.05", "Hytheo", "36", "0.05", "Town 1", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_11", "11", "Trail 1", "1", "Mothball", "4", "0.05", "Bullibee", "4", "0.05", "Tomaling", "4", "0.05", "Racket", "4", "0.05", "Town 1", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_12", "12", "Trail 1", "2", "Mothball", "4", "0.05", "Equinair", "4", "0.05", "Chibchib", "4", "0.05", "Tomaling", "4", "0.05", "Town 1", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_13", "13", "Trail 1", "3", "Scuda", "4", "0.05", "Mothball", "4", "0.05", "Alistinker", "4", "0.05", "Lotheo", "4", "0.05", "Grass 1 ", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_14", "14", "Trail 1", "4", "Scuda", "4", "0.05", "Alistinker", "4", "0.05", "Tuffin", "4", "0.05", "Lotheo", "4", "0.05", "Grass 1 ", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_15", "15", "Trail 1", "5", "Mothball", "5", "0.05", "Bullibee", "4", "0.05", "Dozer", "4", "0.05", "Alistinker", "4", "0.05", "Town 1", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_16", "16", "Namanja", "1", "Mothball", "6", "0.05", "Bullibee", "6", "0.05", "Tomaling", "6", "0.05", "Racket", "6", "0.05", "Town 1", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_17", "17", "Namanja", "2", "Tortipous", "7", "0.05", "Alistinker", "6", "0.05", "Krabken", "6", "0.05", "Racket", "6", "0.05", "Town 1", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_18", "18", "Namanja", "3", "Snozo", "11", "0.05", "Hoodwink", "12", "0.05", "Oddcat", "10", "0.05", "Equinair", "12", "0.05", "Arcane 1 ", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_19", "19", "Namanja", "4", "Snozo", "13", "0.05", "Snailix", "14", "0.05", "Grynn", "12", "0.05", "Foxpaw", "11", "0.05", "Arcane 1 ", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_20", "20", "Namanja", "5", "Swinx", "12", "0.05", "Joltermite", "12", "0.05", "Wolvus", "13", "0.05", "Moxtail", "14", "0.05", "Town 1", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_21", "21", "Namanja Cave", "1", "Swinx", "13", "0.05", "Joltermite", "14", "0.05", "Flarmian", "14", "0.05", "Wolvus", "14", "0.05", "Cave", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_22", "22", "Namanja Cave", "2", "Swinx", "14", "0.05", "Sootimander", "13", "0.05", "Dozer", "13", "0.05", "Moxtail", "13", "0.05", "Cave", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_23", "23", "Namanja Cave", "3", "Swinx", "15", "0.05", "Joltermite", "15", "0.05", "Wolvus", "15", "0.05", "Moxtail", "15", "0.05", "Cave", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_24", "24", "Namanja Cave", "4", "Sonax", "30", "0.05", "Voltermite", "30", "0.05", "Wolvus", "30", "0.05", "Flarmian", "30", "0.05", "Cave", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_25", "25", "Clearing", "1", "Brak", "15", "0.05", "Venox", "15", "0.05", "Ignitler", "16", "0.05", "Bananteater", "14", "0.05", "Savannah", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_26", "26", "Clearing", "2", "Flarmian", "16", "0.05", "Swinx", "16", "0.05", "Joltermite", "19", "0.05", "Gazolt", "15", "0.05", "Savannah", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_27", "27", "Clearing", "3", "Flaffee", "15", "0.05", "Flarmian", "15", "0.05", "Brak", "18", "0.05", "Bananteater", "16", "0.05", "Savannah", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_28", "28", "Clearing", "4", "Bullibee", "16", "0.05", "Swinx", "16", "0.05", "Flarmian", "15", "0.05", "Bananteater", "15", "0.05", "Savannah", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_29", "29", "Ouadda", "1", "Shriken", "20", "0.05", "Brak", "20", "0.05", "Lothea", "20", "0.05", "Scorchling", "20", "0.05", "Sand 1 ", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_30", "30", "Ouadda", "2", "Shriken", "20", "0.05", "Staria", "20", "0.05", "Brak", "20", "0.05", "Flarmian", "20", "0.05", "Sand 1 ", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_31", "31", "Ouadda", "3", "Gazolt", "20", "0.05", "Wolvus", "20", "0.05", "Swinx", "20", "0.05", "Joltermite", "20", "0.05", "Waste 1 ", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_32", "32", "Ouadda", "4", "Gazolt", "20", "0.05", "Ampint", "20", "0.05", "Electripine", "20", "0.05", "Joltermite", "20", "0.05", "Waste 1 ", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_33", "33", "Ouadda", "5", "Flowgo", "20", "0.05", "Krabken", "20", "0.05", "Soarphin", "20", "0.05", "Alistinker", "20", "0.05", "Oasis", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_34", "34", "Mountain Trail", "1", "Brak", "24", "0.05", "Bananteater", "24", "0.05", "Shriken", "24", "0.05", "Caleaf", "24", "0.05", "Savannah", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_35", "35", "Mountain Trail", "2", "Foxpaw", "24", "0.05", "Snozo", "24", "0.05", "Oddcat", "24", "0.05", "Peachic", "24", "0.05", "Savannah", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_36", "36", "Mountain Trail", "3", "Brak", "24", "0.05", "Riffin", "24", "0.05", "Electripine", "24", "0.05", "Shriken", "24", "0.05", "Savannah", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_37", "37", "Mountain Trail", "4", "Sprew", "24", "0.05", "Oarion", "24", "0.05", "Yeticrab", "24", "0.05", "Snowyrm", "24", "0.05", "Snow 1", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_38", "38", "Mountain Trail", "5", "Sprew", "24", "0.05", "Oarion", "24", "0.05", "Yeticrab", "24", "0.05", "Clovice", "24", "0.05", "Snow 1", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_39", "39", "Jinja", "1", "Snowyrm", "26", "0.05", "Oarion", "26", "0.05", "Sprew", "26", "0.05", "Yeticrab", "26", "0.05", "Snow 1", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_40", "40", "Jinja", "2", "Snowyrm", "26", "0.05", "Clovice", "26", "0.05", "Ursnobal", "26", "0.05", "Oarion", "26", "0.05", "Snow 1", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_41", "41", "Jinja", "3", "Oarion", "26", "0.05", "Turanom", "26", "0.05", "Coralpie", "26", "0.05", "Octicute", "26", "0.05", "Snow 1", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_42", "42", "IceCave", "1", "Yantis", "26", "0.05", "Yeticrab", "26", "0.05", "Ursnobal", "26", "0.05", "Snowyrm", "26", "0.05", "Ice Cave", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_43", "43", "IceCave", "2", "Yantis", "26", "0.05", "Yeticrab", "26", "0.05", "Turanom", "26", "0.05", "Coralpie", "26", "0.05", "Ice Cave", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_44", "44", "IceCave", "3", "Yantis", "26", "0.05", "Glaceleap", "26", "0.05", "Turanom", "26", "0.05", "Brrizard", "26", "0.05", "Ice Cave", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_45", "45", "Lake Nyaza", "1", "Fluster", "26", "0.05", "Tomaling", "26", "0.05", "Dragonfry", "26", "0.05", "Chipmunkey", "26", "0.05", "Town 1", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_46", "46", "Lake Nyaza", "2", "Fluster", "26", "0.05", "Tomaling", "26", "0.05", "Hootenant", "26", "0.05", "Grynn", "26", "0.05", "Town 1", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_47", "47", "Lake Nyaza", "3", "Clovice", "26", "0.05", "Snowyrm", "26", "0.05", "Snozo", "26", "0.05", "Yeticrab", "26", "0.05", "Snow 1", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_48", "48", "Lake Nyaza", "4", "Scuda", "26", "0.05", "Alistinker", "26", "0.05", "Tortipous", "26", "0.05", "Tuffin", "26", "0.05", "Oasis", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_49", "49", "Lake Nyaza", "5", "Bananivore", "24", "0.1", "Alistinker", "24", "0.05", "Dozer", "24", "0.05", "Brak", "24", "0.05", "Savannah", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_50", "50", "Volcano Trail", "1", "Shino", "28", "0.05", "Tomaling", "28", "0.05", "Flaffee", "28", "0.05", "Sootimander", "28", "0.05", "Town 1", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_51", "51", "Volcano Trail", "2", "Vextail", "28", "0.05", "Hootenant", "28", "0.05", "Flaffee", "28", "0.05", "Flarmian", "28", "0.05", "Fire 1 ", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_52", "52", "Volcano Trail", "3", "Vextail", "28", "0.05", "Chicklit", "28", "0.05", "Pyrodilus", "28", "0.05", "Flaffee", "28", "0.05", "Fire 1 ", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_53", "53", "Volcano Trail", "4", "Hoodwink", "28", "0.05", "Dragonflare", "28", "0.05", "Lotis", "28", "0.05", "Tomatopea", "28", "0.05", "Jungle", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_54", "54", "Volcano Trail", "5", "Peamato", "28", "0.05", "Hoodwink", "28", "0.05", "Spoompkin", "28", "0.05", "Tomatopea", "28", "0.05", "Jungle", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_55", "55", "Kismayo", "1", "Yantis", "28", "0.05", "Tomatopea", "28", "0.05", "Peamato", "28", "0.05", "Lotis", "28", "0.05", "Jungle", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_56", "56", "Kismayo", "2", "Brak", "28", "0.05", "Fluster", "28", "0.05", "Alistinker", "28", "0.05", "Caleaf", "28", "0.05", "Town 1", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_57", "57", "Kismayo", "3", "Dozer", "28", "0.05", "Manticub", "28", "0.05", "Grynn", "28", "0.05", "Igniraffe", "28", "0.05", "Waste 1 ", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_58", "58", "Kismayo", "4", "Strutwing", "28", "0.05", "Dozer", "28", "0.05", "Grynn", "28", "0.05", "Pyrodilus", "28", "0.05", "Waste 1 ", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_59", "59", "Kismayo", "5", "Skullywag", "28", "0.05", "Sharkuit", "28", "0.05", "Lotheo", "28", "0.05", "Lothea", "28", "0.05", "Oasis", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_60", "60", "Al Kubra", "1", "Gekowatt", "28", "0.05", "Shriken", "28", "0.05", "Manticub", "28", "0.05", "Shino", "28", "0.05", "Sand 1 ", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_61", "61", "Al Kubra", "2", "Gekowatt", "28", "0.05", "Pyrodilus", "28", "0.05", "Manticub", "28", "0.05", "Shino", "28", "0.05", "Sand 1 ", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_62", "62", "Al Kubra", "3", "Flaffee", "28", "0.05", "Brak", "28", "0.05", "Wolvus", "28", "0.05", "Shino", "28", "0.05", "Sand 1 ", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_63", "63", "Al Kubra", "4", "Scuda", "28", "0.05", "Lotheo", "28", "0.05", "Lothea", "28", "0.05", "Clawbster", "28", "0.05", "Sand 1 ", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_64", "64", "Al Kubra", "5", "Lotheo", "28", "0.05", "Skullywag", "28", "0.05", "Sharkuit", "28", "0.05", "Clawbster", "28", "0.05", "Sand 1 ", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_65", "65", "Kyeroh", "1", "Flaffee", "33", "0.05", "Gekowatt", "33", "0.05", "Manticub", "33", "0.05", "Shino", "33", "0.05", "Sand 1 ", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_66", "66", "Kyeroh", "2", "Gekowatt", "33", "0.05", "Brak", "33", "0.05", "Pyrodilus", "33", "0.05", "Caleaf", "33", "0.05", "Sand 1 ", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_67", "67", "Kyeroh", "3", "Gekowatt", "33", "0.05", "Brak", "33", "0.05", "Pyrodilus", "33", "0.05", "Chibchib", "33", "0.05", "Sand 1 ", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_68", "68", "Kyeroh", "4", "Flaffee", "33", "0.05", "Brak", "33", "0.05", "Caleaf", "33", "0.05", "Ignitler", "33", "0.05", "Savannah", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_69", "69", "Kyeroh", "5", "Skullywag", "33", "0.05", "Sharkuit", "33", "0.05", "Lotheo", "33", "0.05", "Lothea", "33", "0.05", "Savannah", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_70", "70", "Volcano Erta", "1", "Flarmian", "28", "0.05", "Moxtail", "28", "0.05", "Sootimander", "28", "0.05", "Ignitler", "28", "0.05", "Volcano 1", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_71", "71", "Volcano Erta", "2", "Flarmian", "28", "0.05", "Moxtail", "28", "0.05", "Pyrodilus", "28", "0.05", "Shriken", "28", "0.05", "Volcano 1", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_72", "72", "Volcano Erta", "3", "Flarmian", "28", "0.05", "Pyrodilus", "28", "0.05", "Electrosaurus", "28", "0.05", "Dragonflare", "28", "0.05", "Volcano 1", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_73", "73", "Volcano Erta", "4", "Flairmingo", "28", "0.05", "Dragonflare", "28", "0.05", "Magmeleon", "28", "0.05", "Shino", "28", "0.05", "Volcano 1", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_74", "74", "Volcano Erta", "5", "", "28", "0.05", "", "28", "0.05", "", "28", "0.05", "", "28", "0.05", "Volcano 1", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_75", "75", "Mombassi", "1", "Motharch", "28", "0.05", "Gazolt", "28", "0.05", "Caleaf", "28", "0.05", "Brak", "28", "0.05", "Town 1", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_76", "76", "Mombassi", "2", "Motharch", "28", "0.05", "Gazolt", "28", "0.05", "Caleaf", "28", "0.05", "Riffin", "28", "0.05", "Town 1", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_77", "77", "Mombassi", "3", "Strutwing", "28", "0.05", "Flaffee", "28", "0.05", "Shino", "28", "0.05", "Gekowatt", "28", "0.05", "Sand 1 ", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_78", "78", "Mombassi", "4", "Strutwing", "28", "0.05", "Dragonflare", "28", "0.05", "Wolvus", "28", "0.05", "Gekowatt", "28", "0.05", "Sand 1 ", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_79", "79", "Mombassi", "5", "", "28", "0.05", "", "28", "0.05", "", "28", "0.05", "", "28", "0.05", "Cave", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_80", "80", "Guild Land", "1", "Sonax", "50", "0.05", "Voltermite", "50", "0.05", "Flarmian", "45", "0.05", "Dozer", "50", "0.05", "Cave", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_81", "81", "Guild Land", "2", "Megameleon", "45", "0.05", "Rhiyew", "50", "0.05", "Manteri", "42", "0.05", "Cackyll", "65", "0.05", "Cave", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_82", "82", "Guild Land", "3", "Tortitank", "50", "0.05", "Serpquin", "45", "0.05", "Gorillamp", "50", "0.05", "Fouligator", "50", "0.05", "Lake 1", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_83", "83", "Guild Land", "4", "Maulverine", "50", "0.05", "Hytheo", "50", "0.05", "Riffindor", "50", "0.05", "Oaklore", "50", "0.05", "Lake 1", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_84", "84", "Guild Land", "5", "Flairmingo", "50", "0.05", "Pinclaw", "50", "0.05", "Vilewing", "50", "0.05", "Clawlossal", "50", "0.05", "Lake 1", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_85", "85", "Mountain Cave", "1", "Sonax", "50", "0.05", "Voltermite", "50", "0.05", "Flarmian", "50", "0.05", "Dozer", "50", "0.05", "Cave", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_86", "86", "Mountain Cave", "2", "Slizzard", "50", "0.05", "Majestice", "50", "0.05", "Sluggernaught", "50", "0.05", "Narwhalite", "50", "0.05", "Cave", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_87", "87", "Mountain Cave", "3", "Ninevolt", "10", "0.01", "Slizzard", "50", "0.05", "Sluggernaught", "50", "0.05", "Majestice", "50", "0.05", "Cave", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_88", "88", "Mountain Cave", "4", "Viperno", "10", "0.01", "Slizzard", "50", "0.05", "Sluggernaught", "50", "0.05", "Majestice", "50", "0.05", "Cave", "POL-battle-march-long"));
			Rows.Add( new MapSpawnsRow("SPAWN_89", "89", "Mountain Cave", "5", "Freyon", "10", "0.01", "Jagwar", "10", "0.01", "Sluggernaught", "50", "0.05", "Majestice", "50", "0.05", "Cave", "POL-battle-march-long"));
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
		public MapSpawnsRow GetRow(rowIds in_RowID)
		{
			MapSpawnsRow ret = null;
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
		public MapSpawnsRow GetRow(string in_RowString)
		{
			MapSpawnsRow ret = null;
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
