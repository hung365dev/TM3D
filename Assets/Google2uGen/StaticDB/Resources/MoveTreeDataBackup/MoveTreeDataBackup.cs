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
	public class MoveTreeDataBackupRow : IGoogle2uRow
	{
		public int _ID;
		public string _MoveTree;
		public int _PreceedingMoveOnTree;
		public int _LevelToUnlock;
		public string _Move;
		public int _RequiresEvolutionLevel;
		public int _XPosition;
		public int _YPosition;
		public string _Branch;
		public MoveTreeDataBackupRow(string __GOOGLEFU_ID, string __ID, string __MoveTree, string __PreceedingMoveOnTree, string __LevelToUnlock, string __Move, string __RequiresEvolutionLevel, string __XPosition, string __YPosition, string __Branch) 
		{
			{
			int res;
				if(int.TryParse(__ID, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_ID = res;
				else
					Debug.LogError("Failed To Convert _ID string: "+ __ID +" to int");
			}
			_MoveTree = __MoveTree.Trim();
			{
			int res;
				if(int.TryParse(__PreceedingMoveOnTree, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_PreceedingMoveOnTree = res;
				else
					Debug.LogError("Failed To Convert _PreceedingMoveOnTree string: "+ __PreceedingMoveOnTree +" to int");
			}
			{
			int res;
				if(int.TryParse(__LevelToUnlock, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_LevelToUnlock = res;
				else
					Debug.LogError("Failed To Convert _LevelToUnlock string: "+ __LevelToUnlock +" to int");
			}
			_Move = __Move.Trim();
			{
			int res;
				if(int.TryParse(__RequiresEvolutionLevel, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_RequiresEvolutionLevel = res;
				else
					Debug.LogError("Failed To Convert _RequiresEvolutionLevel string: "+ __RequiresEvolutionLevel +" to int");
			}
			{
			int res;
				if(int.TryParse(__XPosition, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_XPosition = res;
				else
					Debug.LogError("Failed To Convert _XPosition string: "+ __XPosition +" to int");
			}
			{
			int res;
				if(int.TryParse(__YPosition, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_YPosition = res;
				else
					Debug.LogError("Failed To Convert _YPosition string: "+ __YPosition +" to int");
			}
			_Branch = __Branch.Trim();
		}

		public int Length { get { return 9; } }

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
					ret = _MoveTree.ToString();
					break;
				case 2:
					ret = _PreceedingMoveOnTree.ToString();
					break;
				case 3:
					ret = _LevelToUnlock.ToString();
					break;
				case 4:
					ret = _Move.ToString();
					break;
				case 5:
					ret = _RequiresEvolutionLevel.ToString();
					break;
				case 6:
					ret = _XPosition.ToString();
					break;
				case 7:
					ret = _YPosition.ToString();
					break;
				case 8:
					ret = _Branch.ToString();
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
				case "MoveTree":
					ret = _MoveTree.ToString();
					break;
				case "PreceedingMoveOnTree":
					ret = _PreceedingMoveOnTree.ToString();
					break;
				case "LevelToUnlock":
					ret = _LevelToUnlock.ToString();
					break;
				case "Move":
					ret = _Move.ToString();
					break;
				case "RequiresEvolutionLevel":
					ret = _RequiresEvolutionLevel.ToString();
					break;
				case "XPosition":
					ret = _XPosition.ToString();
					break;
				case "YPosition":
					ret = _YPosition.ToString();
					break;
				case "Branch":
					ret = _Branch.ToString();
					break;
			}

			return ret;
		}
		public override string ToString()
		{
			string ret = System.String.Empty;
			ret += "{" + "ID" + " : " + _ID.ToString() + "} ";
			ret += "{" + "MoveTree" + " : " + _MoveTree.ToString() + "} ";
			ret += "{" + "PreceedingMoveOnTree" + " : " + _PreceedingMoveOnTree.ToString() + "} ";
			ret += "{" + "LevelToUnlock" + " : " + _LevelToUnlock.ToString() + "} ";
			ret += "{" + "Move" + " : " + _Move.ToString() + "} ";
			ret += "{" + "RequiresEvolutionLevel" + " : " + _RequiresEvolutionLevel.ToString() + "} ";
			ret += "{" + "XPosition" + " : " + _XPosition.ToString() + "} ";
			ret += "{" + "YPosition" + " : " + _YPosition.ToString() + "} ";
			ret += "{" + "Branch" + " : " + _Branch.ToString() + "} ";
			return ret;
		}
	}
	public sealed class MoveTreeDataBackup : IGoogle2uDB
	{
		public enum rowIds {
			MTD_NOMOVE, MTD_NORMAL1, MTD_NORMAL2, MTD_NORMAL3, MTD_NORMAL4, MTD_NORMAL5, MTD_NORMAL6, MTD_NORMAL7, MTD_NORMAL8, MTD_NORMAL9, MTD_NORMAL10, MTD_NORMAL11, MTD_NORMAL12, MTD_NORMAL13, MTD_NORMAL14, MTD_NORMAL15, MTD_NORMAL16, MTD_NORMAL17
			, MTD_NORMAL18, MTD_NORMAL19, MTD_NORMAL20, MTD_NORMAL21, MTD_NORMAL22, MTD_NORMAL23, MTD_NORMAL24, MTD_AIR1, MTD_AIR2, MTD_AIR3, MTD_AIR4, MTD_AIR5, MTD_AIR6, MTD_AIR7, MTD_AIR8, MTD_AIR9, MTD_AIR10, MTD_AIR11, MTD_AIR12, MTD_AIR13
			, MTD_AIR14, MTD_AIR15, MTD_AIR16, MTD_AIR18, MTD_AIR19, MTD_AIR20, MTD_AIR21, MTD_AIR22, MTD_AIR23, MTD_AIR24, MTD_ARCANE1, MTD_ARCANE2, MTD_ARCANE3, MTD_ARCANE4, MTD_ARCANE5, MTD_ARCANE6, MTD_ARCANE7, MTD_ARCANE8, MTD_ARCANE9, MTD_ARCANE10
			, MTD_ARCANE11, MTD_ARCANE12, MTD_ARCANE13, MTD_ARCANE14, MTD_ARCANE15, MTD_ARCANE16, MTD_ARCANE17, MTD_ARCANE18, MTD_ARCANE19, MTD_ARCANE20, MTD_ARCANE21, MTD_ARCANE22, MTD_ARCANE23, MTD_EARTH1, MTD_EARTH2, MTD_EARTH3, MTD_EARTH4, MTD_EARTH5, MTD_EARTH6, MTD_EARTH7
			, MTD_EARTH8, MTD_EARTH11, MTD_EARTH12, MTD_EARTH13, MTD_EARTH14, MTD_EARTH15, MTD_EARTH16, MTD_EARTH17, MTD_EARTH18, MTD_EARTH23, MTD_EARTH24, MTD_EARTH25, MTD_EARTH26, MTD_EARTH27, MTD_EARTH28, MTD_EARTH29, MTD_EARTH30, MTD_ELECTRIC1, MTD_ELECTRIC2, MTD_ELECTRIC3
			, MTD_ELECTRIC4, MTD_ELECTRIC5, MTD_ELECTRIC6, MTD_ELECTRIC7, MTD_ELECTRIC8, MTD_ELECTRIC9, MTD_ELECTRIC10, MTD_ELECTRIC11, MTD_ELECTRIC12, MTD_ELECTRIC13, MTD_ELECTRIC14, MTD_ELECTRIC15, MTD_ELECTRIC16, MTD_ELECTRIC17, MTD_ELECTRIC18, MTD_ELECTRIC19, MTD_ELECTRIC20, MTD_ELECTRIC21, MTD_FIRE1, MTD_FIRE2
			, MTD_FIRE3, MTD_FIRE4, MTD_FIRE5, MTD_FIRE6, MTD_FIRE7, MTD_FIRE8, MTD_FIRE9, MTD_FIRE10, MTD_FIRE11, MTD_FIRE12, MTD_FIRE13, MTD_FIRE14, MTD_FIRE15, MTD_FIRE16, MTD_FIRE17, MTD_FIRE18, MTD_FIRE19, MTD_FIRE20, MTD_FIRE21, MTD_ICE1
			, MTD_ICE2, MTD_ICE3, MTD_ICE4, MTD_ICE5, MTD_ICE6, MTD_ICE7, MTD_ICE8, MTD_ICE9, MTD_ICE10, MTD_ICE11, MTD_ICE12, MTD_ICE13, MTD_ICE14, MTD_ICE16, MTD_ICE17, MTD_ICE18, MTD_ICE19, MTD_ICE20, MTD_ICE21, MTD_ICE22
			, MTD_WATER1, MTD_WATER2, MTD_WATER3, MTD_WATER4, MTD_WATER5, MTD_WATER6, MTD_WATER7, MTD_WATER8, MTD_WATER9, MTD_WATER10, MTD_WATER11, MTD_WATER12, MTD_WATER13, MTD_WATER14, MTD_WATER15, MTD_WATER16, MTD_WATER17, MTD_WATER18, MTD_WATER19, MTD_WATER20
			, MTD_WATER21
		};
		public string [] rowNames = {
			"MTD_NOMOVE", "MTD_NORMAL1", "MTD_NORMAL2", "MTD_NORMAL3", "MTD_NORMAL4", "MTD_NORMAL5", "MTD_NORMAL6", "MTD_NORMAL7", "MTD_NORMAL8", "MTD_NORMAL9", "MTD_NORMAL10", "MTD_NORMAL11", "MTD_NORMAL12", "MTD_NORMAL13", "MTD_NORMAL14", "MTD_NORMAL15", "MTD_NORMAL16", "MTD_NORMAL17"
			, "MTD_NORMAL18", "MTD_NORMAL19", "MTD_NORMAL20", "MTD_NORMAL21", "MTD_NORMAL22", "MTD_NORMAL23", "MTD_NORMAL24", "MTD_AIR1", "MTD_AIR2", "MTD_AIR3", "MTD_AIR4", "MTD_AIR5", "MTD_AIR6", "MTD_AIR7", "MTD_AIR8", "MTD_AIR9", "MTD_AIR10", "MTD_AIR11", "MTD_AIR12", "MTD_AIR13"
			, "MTD_AIR14", "MTD_AIR15", "MTD_AIR16", "MTD_AIR18", "MTD_AIR19", "MTD_AIR20", "MTD_AIR21", "MTD_AIR22", "MTD_AIR23", "MTD_AIR24", "MTD_ARCANE1", "MTD_ARCANE2", "MTD_ARCANE3", "MTD_ARCANE4", "MTD_ARCANE5", "MTD_ARCANE6", "MTD_ARCANE7", "MTD_ARCANE8", "MTD_ARCANE9", "MTD_ARCANE10"
			, "MTD_ARCANE11", "MTD_ARCANE12", "MTD_ARCANE13", "MTD_ARCANE14", "MTD_ARCANE15", "MTD_ARCANE16", "MTD_ARCANE17", "MTD_ARCANE18", "MTD_ARCANE19", "MTD_ARCANE20", "MTD_ARCANE21", "MTD_ARCANE22", "MTD_ARCANE23", "MTD_EARTH1", "MTD_EARTH2", "MTD_EARTH3", "MTD_EARTH4", "MTD_EARTH5", "MTD_EARTH6", "MTD_EARTH7"
			, "MTD_EARTH8", "MTD_EARTH11", "MTD_EARTH12", "MTD_EARTH13", "MTD_EARTH14", "MTD_EARTH15", "MTD_EARTH16", "MTD_EARTH17", "MTD_EARTH18", "MTD_EARTH23", "MTD_EARTH24", "MTD_EARTH25", "MTD_EARTH26", "MTD_EARTH27", "MTD_EARTH28", "MTD_EARTH29", "MTD_EARTH30", "MTD_ELECTRIC1", "MTD_ELECTRIC2", "MTD_ELECTRIC3"
			, "MTD_ELECTRIC4", "MTD_ELECTRIC5", "MTD_ELECTRIC6", "MTD_ELECTRIC7", "MTD_ELECTRIC8", "MTD_ELECTRIC9", "MTD_ELECTRIC10", "MTD_ELECTRIC11", "MTD_ELECTRIC12", "MTD_ELECTRIC13", "MTD_ELECTRIC14", "MTD_ELECTRIC15", "MTD_ELECTRIC16", "MTD_ELECTRIC17", "MTD_ELECTRIC18", "MTD_ELECTRIC19", "MTD_ELECTRIC20", "MTD_ELECTRIC21", "MTD_FIRE1", "MTD_FIRE2"
			, "MTD_FIRE3", "MTD_FIRE4", "MTD_FIRE5", "MTD_FIRE6", "MTD_FIRE7", "MTD_FIRE8", "MTD_FIRE9", "MTD_FIRE10", "MTD_FIRE11", "MTD_FIRE12", "MTD_FIRE13", "MTD_FIRE14", "MTD_FIRE15", "MTD_FIRE16", "MTD_FIRE17", "MTD_FIRE18", "MTD_FIRE19", "MTD_FIRE20", "MTD_FIRE21", "MTD_ICE1"
			, "MTD_ICE2", "MTD_ICE3", "MTD_ICE4", "MTD_ICE5", "MTD_ICE6", "MTD_ICE7", "MTD_ICE8", "MTD_ICE9", "MTD_ICE10", "MTD_ICE11", "MTD_ICE12", "MTD_ICE13", "MTD_ICE14", "MTD_ICE16", "MTD_ICE17", "MTD_ICE18", "MTD_ICE19", "MTD_ICE20", "MTD_ICE21", "MTD_ICE22"
			, "MTD_WATER1", "MTD_WATER2", "MTD_WATER3", "MTD_WATER4", "MTD_WATER5", "MTD_WATER6", "MTD_WATER7", "MTD_WATER8", "MTD_WATER9", "MTD_WATER10", "MTD_WATER11", "MTD_WATER12", "MTD_WATER13", "MTD_WATER14", "MTD_WATER15", "MTD_WATER16", "MTD_WATER17", "MTD_WATER18", "MTD_WATER19", "MTD_WATER20"
			, "MTD_WATER21"
		};
		public System.Collections.Generic.List<MoveTreeDataBackupRow> Rows = new System.Collections.Generic.List<MoveTreeDataBackupRow>();

		public static MoveTreeDataBackup Instance
		{
			get { return NestedMoveTreeDataBackup.instance; }
		}

		private class NestedMoveTreeDataBackup
		{
			static NestedMoveTreeDataBackup() { }
			internal static readonly MoveTreeDataBackup instance = new MoveTreeDataBackup();
		}

		private MoveTreeDataBackup()
		{
			Rows.Add( new MoveTreeDataBackupRow("MTD_NOMOVE", "1", "", "0", "0", "", "0", "0", "0", "Attacking Branch 1"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_NORMAL1", "2", "Normal Move Tree", "0", "1", "Pounce", "0", "0", "0", "Attacking Branch 1"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_NORMAL2", "3", "Normal Move Tree", "2", "8", "Hurl", "0", "0", "0", "Attacking Branch 1"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_NORMAL3", "4", "Normal Move Tree", "3", "11", "Ram", "0", "0", "0", "Attacking Branch 1"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_NORMAL4", "5", "Normal Move Tree", "4", "14", "Lunge", "0", "0", "0", "Attacking Branch 1"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_NORMAL5", "6", "Normal Move Tree", "5", "17", "Charge", "0", "0", "0", "Attacking Branch 1"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_NORMAL6", "7", "Normal Move Tree", "6", "20", "Slam", "0", "0", "0", "Attacking Branch 1"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_NORMAL7", "8", "Normal Move Tree", "7", "23", "Headbutt", "0", "0", "0", "Attacking Branch 1"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_NORMAL8", "9", "Normal Move Tree", "8", "26", "Body Slam", "0", "0", "0", "Attacking Branch 1"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_NORMAL9", "10", "Normal Move Tree", "0", "1", "Scratch", "0", "0", "0", "Attacking Branch 2"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_NORMAL10", "11", "Normal Move Tree", "10", "8", "Bash", "0", "0", "0", "Attacking Branch 2"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_NORMAL11", "12", "Normal Move Tree", "11", "11", "Claw", "0", "0", "0", "Attacking Branch 2"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_NORMAL12", "13", "Normal Move Tree", "12", "14", "Stomp", "0", "0", "0", "Attacking Branch 2"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_NORMAL13", "14", "Normal Move Tree", "13", "17", "Slash", "0", "0", "0", "Attacking Branch 2"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_NORMAL14", "15", "Normal Move Tree", "14", "20", "Thrash", "0", "0", "0", "Attacking Branch 2"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_NORMAL15", "16", "Normal Move Tree", "15", "23", "Maul", "0", "0", "0", "Attacking Branch 2"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_NORMAL16", "17", "Normal Move Tree", "16", "26", "Rampage", "0", "0", "0", "Attacking Branch 2"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_NORMAL17", "18", "Normal Move Tree", "0", "1", "Rally", "0", "0", "0", "Supporting Branch"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_NORMAL18", "19", "Normal Move Tree", "18", "1", "Cover", "0", "0", "0", "Supporting Branch"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_NORMAL19", "20", "Normal Move Tree", "19", "1", "Block", "0", "0", "0", "Supporting Branch"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_NORMAL20", "21", "Normal Move Tree", "20", "8", "Blind", "0", "0", "0", "Supporting Branch"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_NORMAL21", "22", "Normal Move Tree", "21", "11", "Roar", "0", "0", "0", "Supporting Branch"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_NORMAL22", "23", "Normal Move Tree", "22", "14", "Valor", "0", "0", "0", "Supporting Branch"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_NORMAL23", "24", "Normal Move Tree", "23", "17", "Fortify", "0", "0", "0", "Supporting Branch"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_NORMAL24", "25", "Normal Move Tree", "24", "20", "Purge", "0", "0", "0", "Supporting Branch"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_AIR1", "29", "Air Move Tree", "0", "1", "Gale", "0", "0", "0", "Attacking Branch 1"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_AIR2", "30", "Air Move Tree", "29", "8", "Sonar Strike", "0", "0", "0", "Attacking Branch 1"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_AIR3", "31", "Air Move Tree", "30", "11", "Airblast", "0", "0", "0", "Attacking Branch 1"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_AIR4", "32", "Air Move Tree", "31", "14", "Whirlwind", "0", "0", "0", "Attacking Branch 1"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_AIR5", "33", "Air Move Tree", "32", "17", "Jetstream", "0", "0", "0", "Attacking Branch 1"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_AIR6", "34", "Air Move Tree", "33", "20", "Cyclonic Strike", "0", "0", "0", "Attacking Branch 1"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_AIR7", "35", "Air Move Tree", "34", "23", "Tornado", "0", "0", "0", "Attacking Branch 1"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_AIR8", "36", "Air Move Tree", "35", "26", "Typhoon", "0", "0", "0", "Attacking Branch 1"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_AIR9", "37", "Air Move Tree", "0", "1", "Peck", "0", "0", "0", "Attacking Branch 2"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_AIR10", "38", "Air Move Tree", "37", "8", "Spiral Dive", "0", "0", "0", "Attacking Branch 2"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_AIR11", "39", "Air Move Tree", "38", "11", "Divebomb", "0", "0", "0", "Attacking Branch 2"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_AIR12", "40", "Air Move Tree", "39", "14", "Wing Blade", "0", "0", "0", "Attacking Branch 2"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_AIR13", "41", "Air Move Tree", "40", "17", "Talon Slash", "0", "0", "0", "Attacking Branch 2"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_AIR14", "42", "Air Move Tree", "41", "20", "Air Strike", "0", "0", "0", "Attacking Branch 2"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_AIR15", "43", "Air Move Tree", "42", "23", "War Wing", "0", "0", "0", "Attacking Branch 2"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_AIR16", "44", "Air Move Tree", "43", "26", "Sky Hammer", "0", "0", "0", "Attacking Branch 2"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_AIR18", "46", "Air Move Tree", "0", "1", "Windspeed", "0", "0", "0", "Supporting Branch"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_AIR19", "47", "Air Move Tree", "46", "1", "Fog", "0", "0", "0", "Supporting Branch"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_AIR20", "48", "Air Move Tree", "47", "1", "Cloudwall", "0", "0", "0", "Supporting Branch"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_AIR21", "49", "Air Move Tree", "48", "8", "Birdsong", "0", "0", "0", "Supporting Branch"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_AIR22", "50", "Air Move Tree", "49", "11", "Hawkeye", "0", "0", "0", "Supporting Branch"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_AIR23", "51", "Air Move Tree", "50", "14", "Vacuum", "0", "0", "0", "Supporting Branch"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_AIR24", "52", "Air Move Tree", "51", "17", "Soothing Wind", "0", "0", "0", "Supporting Branch"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_ARCANE1", "53", "Arcane Move Tree", "0", "1", "Astral Blast", "0", "0", "0", "Attacking Branch 1"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_ARCANE2", "54", "Arcane Move Tree", "53", "8", "Nausea", "0", "0", "0", "Attacking Branch 1"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_ARCANE3", "55", "Arcane Move Tree", "54", "11", "Shriek", "0", "0", "0", "Attacking Branch 1"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_ARCANE4", "56", "Arcane Move Tree", "55", "14", "Possess", "0", "0", "0", "Attacking Branch 1"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_ARCANE5", "57", "Arcane Move Tree", "56", "17", "Shadowbolt", "0", "0", "0", "Attacking Branch 1"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_ARCANE6", "58", "Arcane Move Tree", "57", "20", "Plaguewave", "0", "0", "0", "Attacking Branch 1"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_ARCANE7", "59", "Arcane Move Tree", "58", "23", "Arcane Missiles", "0", "0", "0", "Attacking Branch 1"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_ARCANE8", "60", "Arcane Move Tree", "59", "26", "Vortex", "0", "0", "0", "Attacking Branch 1"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_ARCANE9", "61", "Arcane Move Tree", "0", "1", "Haunt", "0", "0", "0", "Attacking Branch 2"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_ARCANE10", "62", "Arcane Move Tree", "61", "8", "Vex", "0", "0", "0", "Attacking Branch 2"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_ARCANE11", "63", "Arcane Move Tree", "62", "11", "Dark Bite", "0", "0", "0", "Attacking Branch 2"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_ARCANE12", "64", "Arcane Move Tree", "63", "14", "Shadow Fang", "0", "0", "0", "Attacking Branch 2"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_ARCANE13", "65", "Arcane Move Tree", "64", "17", "Petrify", "0", "0", "0", "Attacking Branch 2"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_ARCANE14", "66", "Arcane Move Tree", "65", "20", "Nightmare", "0", "0", "0", "Attacking Branch 2"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_ARCANE15", "67", "Arcane Move Tree", "66", "23", "Torment", "0", "0", "0", "Attacking Branch 2"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_ARCANE16", "68", "Arcane Move Tree", "67", "26", "Void", "0", "0", "0", "Attacking Branch 2"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_ARCANE17", "69", "Arcane Move Tree", "0", "1", "Illusion", "0", "0", "0", "Supporting Branch"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_ARCANE18", "70", "Arcane Move Tree", "69", "1", "Paroxysm", "0", "0", "0", "Supporting Branch"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_ARCANE19", "71", "Arcane Move Tree", "70", "1", "Frenzy", "0", "0", "0", "Supporting Branch"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_ARCANE20", "72", "Arcane Move Tree", "71", "8", "Flash Heal", "0", "0", "0", "Supporting Branch"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_ARCANE21", "73", "Arcane Move Tree", "72", "11", "Barrier", "0", "0", "0", "Supporting Branch"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_ARCANE22", "74", "Arcane Move Tree", "73", "14", "Sacred Scar", "0", "0", "0", "Supporting Branch"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_ARCANE23", "75", "Arcane Move Tree", "74", "17", "Aurora", "0", "0", "0", "Supporting Branch"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_EARTH1", "77", "Earth Move Tree", "0", "1", "Mudsling", "0", "0", "0", "Attacking Branch 1"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_EARTH2", "78", "Earth Move Tree", "77", "8", "Poison", "0", "0", "0", "Attacking Branch 1"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_EARTH3", "79", "Earth Move Tree", "78", "11", "Leech", "0", "0", "0", "Attacking Branch 1"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_EARTH4", "80", "Earth Move Tree", "79", "14", "Entangle", "0", "0", "0", "Attacking Branch 1"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_EARTH5", "81", "Earth Move Tree", "80", "17", "Mudslide", "0", "0", "0", "Attacking Branch 1"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_EARTH6", "82", "Earth Move Tree", "81", "20", "Sandstorm", "0", "0", "0", "Attacking Branch 1"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_EARTH7", "83", "Earth Move Tree", "82", "23", "Thornstorm", "0", "0", "0", "Attacking Branch 1"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_EARTH8", "84", "Earth Move Tree", "83", "26", "Nature's Fury", "0", "0", "0", "Attacking Branch 1"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_EARTH11", "87", "Earth Move Tree", "0", "1", "Splinter", "0", "0", "0", "Attacking Branch 2"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_EARTH12", "88", "Earth Move Tree", "87", "8", "Whiplash", "0", "0", "0", "Attacking Branch 2"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_EARTH13", "89", "Earth Move Tree", "88", "11", "Rocksmash", "0", "0", "0", "Attacking Branch 2"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_EARTH14", "90", "Earth Move Tree", "89", "14", "Forest Knuckle", "0", "0", "0", "Attacking Branch 2"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_EARTH15", "91", "Earth Move Tree", "90", "17", "Stump Slam", "0", "0", "0", "Attacking Branch 2"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_EARTH16", "92", "Earth Move Tree", "91", "20", "Willowmaker", "0", "0", "0", "Attacking Branch 2"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_EARTH17", "93", "Earth Move Tree", "92", "23", "Stampede", "0", "0", "0", "Attacking Branch 2"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_EARTH18", "94", "Earth Move Tree", "93", "26", "Earthquake", "0", "0", "0", "Attacking Branch 2"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_EARTH23", "99", "Earth Move Tree", "0", "1", "Focus", "0", "0", "0", "Supporting Branch"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_EARTH24", "100", "Earth Move Tree", "99", "1", "Rejuvenate", "0", "0", "0", "Supporting Branch"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_EARTH25", "101", "Earth Move Tree", "100", "1", "Ensnare", "0", "0", "0", "Supporting Branch"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_EARTH26", "102", "Earth Move Tree", "101", "8", "Stonehide", "0", "0", "0", "Supporting Branch"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_EARTH27", "103", "Earth Move Tree", "102", "11", "Vine Graft", "0", "0", "0", "Supporting Branch"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_EARTH28", "104", "Earth Move Tree", "103", "14", "Serenity", "0", "0", "0", "Supporting Branch"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_EARTH29", "105", "Earth Move Tree", "104", "17", "Camouflage", "0", "0", "0", "Supporting Branch"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_EARTH30", "106", "Earth Move Tree", "105", "20", "Healing Pod", "0", "0", "0", "Supporting Branch"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_ELECTRIC1", "107", "Electric Move Tree", "0", "1", "Shock", "0", "0", "0", "Attacking Branch 1"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_ELECTRIC2", "108", "Electric Move Tree", "107", "8", "Spark", "0", "0", "0", "Attacking Branch 1"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_ELECTRIC3", "109", "Electric Move Tree", "108", "11", "Staticblast", "0", "0", "0", "Attacking Branch 1"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_ELECTRIC4", "110", "Electric Move Tree", "109", "14", "Electrocute", "0", "0", "0", "Attacking Branch 1"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_ELECTRIC5", "111", "Electric Move Tree", "110", "17", "Arc Wave", "0", "0", "0", "Attacking Branch 1"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_ELECTRIC6", "112", "Electric Move Tree", "111", "20", "Chain Lightning", "0", "0", "0", "Attacking Branch 1"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_ELECTRIC7", "113", "Electric Move Tree", "112", "23", "Lightning Storm", "0", "0", "0", "Attacking Branch 1"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_ELECTRIC8", "114", "Electric Move Tree", "0", "1", "Jolt", "0", "0", "0", "Attacking Branch 2"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_ELECTRIC9", "115", "Electric Move Tree", "114", "8", "Zap Tackle", "0", "0", "0", "Attacking Branch 2"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_ELECTRIC10", "116", "Electric Move Tree", "115", "11", "Static Charge", "0", "0", "0", "Attacking Branch 2"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_ELECTRIC11", "117", "Electric Move Tree", "116", "14", "Ion Fang", "0", "0", "0", "Attacking Branch 2"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_ELECTRIC12", "118", "Electric Move Tree", "117", "17", "Kinetic Claw", "0", "0", "0", "Attacking Branch 2"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_ELECTRIC13", "119", "Electric Move Tree", "118", "20", "Giga Stomp", "0", "0", "0", "Attacking Branch 2"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_ELECTRIC14", "120", "Electric Move Tree", "119", "23", "Thunder Strike", "0", "0", "0", "Attacking Branch 2"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_ELECTRIC15", "121", "Electric Move Tree", "0", "1", "Flash", "0", "0", "0", "Supporting Branch"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_ELECTRIC16", "122", "Electric Move Tree", "121", "1", "Hyper", "0", "0", "0", "Supporting Branch"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_ELECTRIC17", "123", "Electric Move Tree", "122", "1", "Buzz", "0", "0", "0", "Supporting Branch"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_ELECTRIC18", "124", "Electric Move Tree", "123", "8", "Surge", "0", "0", "0", "Supporting Branch"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_ELECTRIC19", "125", "Electric Move Tree", "124", "11", "Magnetize", "0", "0", "0", "Supporting Branch"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_ELECTRIC20", "126", "Electric Move Tree", "125", "14", "Discharge", "0", "0", "0", "Supporting Branch"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_ELECTRIC21", "127", "Electric Move Tree", "126", "17", "Recharge", "0", "0", "0", "Supporting Branch"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_FIRE1", "128", "Fire Move Tree", "0", "1", "Ignite", "0", "0", "0", "Attacking Branch 1"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_FIRE2", "129", "Fire Move Tree", "128", "8", "Torch", "0", "0", "0", "Attacking Branch 1"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_FIRE3", "130", "Fire Move Tree", "129", "11", "Heatwave", "0", "0", "0", "Attacking Branch 1"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_FIRE4", "131", "Fire Move Tree", "130", "14", "Blaze", "0", "0", "0", "Attacking Branch 1"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_FIRE5", "132", "Fire Move Tree", "131", "17", "Flamethrower", "0", "0", "0", "Attacking Branch 1"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_FIRE6", "133", "Fire Move Tree", "132", "20", "Firestorm", "0", "0", "0", "Attacking Branch 1"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_FIRE7", "134", "Fire Move Tree", "133", "23", "Pyroclasm", "0", "0", "0", "Attacking Branch 1"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_FIRE8", "135", "Fire Move Tree", "0", "1", "Pyroclap", "0", "0", "0", "Attacking Branch 2"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_FIRE9", "136", "Fire Move Tree", "135", "8", "Fire Fang", "0", "0", "0", "Attacking Branch 2"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_FIRE10", "137", "Fire Move Tree", "136", "11", "Pyro Punch", "0", "0", "0", "Attacking Branch 2"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_FIRE11", "138", "Fire Move Tree", "137", "14", "Combustion", "0", "0", "0", "Attacking Branch 2"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_FIRE12", "139", "Fire Move Tree", "138", "17", "Heatstrike", "0", "0", "0", "Attacking Branch 2"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_FIRE13", "140", "Fire Move Tree", "139", "20", "Inferno Charge", "0", "0", "0", "Attacking Branch 2"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_FIRE14", "141", "Fire Move Tree", "140", "23", "Incinerate", "0", "0", "0", "Attacking Branch 2"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_FIRE15", "142", "Fire Move Tree", "0", "1", "Smokescreen", "0", "0", "0", "Supporting Branch"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_FIRE16", "143", "Fire Move Tree", "142", "1", "Smolder", "0", "0", "0", "Supporting Branch"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_FIRE17", "144", "Fire Move Tree", "143", "1", "Fire Brand", "0", "0", "0", "Supporting Branch"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_FIRE18", "145", "Fire Move Tree", "144", "8", "Lava Moat", "0", "0", "0", "Supporting Branch"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_FIRE19", "146", "Fire Move Tree", "145", "11", "Steam", "0", "0", "0", "Supporting Branch"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_FIRE20", "147", "Fire Move Tree", "146", "14", "Molten Shield", "0", "0", "0", "Supporting Branch"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_FIRE21", "148", "Fire Move Tree", "147", "17", "Sauna", "0", "0", "0", "Supporting Branch"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_ICE1", "149", "Ice Move Tree", "0", "1", "Hail", "0", "0", "0", "Attacking Branch 1"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_ICE2", "150", "Ice Move Tree", "149", "8", "Frostbreath", "0", "0", "0", "Attacking Branch 1"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_ICE3", "151", "Ice Move Tree", "150", "11", "Arctic Blast", "0", "0", "0", "Attacking Branch 1"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_ICE4", "152", "Ice Move Tree", "151", "14", "Deep Freeze", "0", "0", "0", "Attacking Branch 1"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_ICE5", "153", "Ice Move Tree", "152", "17", "Tundra Blast", "0", "0", "0", "Attacking Branch 1"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_ICE6", "154", "Ice Move Tree", "153", "20", "Blizzard", "0", "0", "0", "Attacking Branch 1"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_ICE7", "155", "Ice Move Tree", "154", "23", "Avalanche", "0", "0", "0", "Attacking Branch 1"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_ICE8", "156", "Ice Move Tree", "0", "1", "Cold Snap", "0", "0", "0", "Attacking Branch 2"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_ICE9", "157", "Ice Move Tree", "156", "8", "Ice Claw", "0", "0", "0", "Attacking Branch 2"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_ICE10", "158", "Ice Move Tree", "157", "11", "Frost Bite", "0", "0", "0", "Attacking Branch 2"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_ICE11", "159", "Ice Move Tree", "158", "14", "Glacial Slide", "0", "0", "0", "Attacking Branch 2"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_ICE12", "160", "Ice Move Tree", "159", "17", "Ice Smash", "0", "0", "0", "Attacking Branch 2"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_ICE13", "161", "Ice Move Tree", "160", "20", "Frost Fang", "0", "0", "0", "Attacking Branch 2"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_ICE14", "162", "Ice Move Tree", "161", "23", "Ice Drill", "0", "0", "0", "Attacking Branch 2"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_ICE16", "164", "Ice Move Tree", "0", "1", "White Breath", "0", "0", "0", "Supporting Branch"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_ICE17", "165", "Ice Move Tree", "164", "1", "Frost Cloak", "0", "0", "0", "Supporting Branch"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_ICE18", "166", "Ice Move Tree", "165", "1", "Winter's Mark", "0", "0", "0", "Supporting Branch"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_ICE19", "167", "Ice Move Tree", "166", "8", "Cool Down", "0", "0", "0", "Supporting Branch"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_ICE20", "168", "Ice Move Tree", "167", "11", "Ice Shield", "0", "0", "0", "Supporting Branch"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_ICE21", "169", "Ice Move Tree", "168", "14", "Snow Drift", "0", "0", "0", "Supporting Branch"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_ICE22", "170", "Ice Move Tree", "169", "17", "Cold Front", "0", "0", "0", "Supporting Branch"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_WATER1", "171", "Water Move Tree", "0", "1", "Splash", "0", "0", "0", "Attacking Branch 1"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_WATER2", "172", "Water Move Tree", "171", "8", "Riptide", "0", "0", "0", "Attacking Branch 1"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_WATER3", "173", "Water Move Tree", "172", "11", "Waterblast", "0", "0", "0", "Attacking Branch 1"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_WATER4", "174", "Water Move Tree", "173", "14", "Water Cannon", "0", "0", "0", "Attacking Branch 1"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_WATER5", "175", "Water Move Tree", "174", "17", "Whirlpool", "0", "0", "0", "Attacking Branch 1"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_WATER6", "176", "Water Move Tree", "175", "20", "Tidal Wave", "0", "0", "0", "Attacking Branch 1"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_WATER7", "177", "Water Move Tree", "176", "23", "Monsoon", "0", "0", "0", "Attacking Branch 1"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_WATER8", "178", "Water Move Tree", "0", "1", "Dive", "0", "0", "0", "Attacking Branch 2"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_WATER9", "179", "Water Move Tree", "178", "8", "Aqua Slide", "0", "0", "0", "Attacking Branch 2"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_WATER10", "180", "Water Move Tree", "179", "11", "Hydro Fist", "0", "0", "0", "Attacking Branch 2"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_WATER11", "181", "Water Move Tree", "180", "14", "Wipeout", "0", "0", "0", "Attacking Branch 2"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_WATER12", "182", "Water Move Tree", "181", "17", "Wave Breaker", "0", "0", "0", "Attacking Branch 2"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_WATER13", "183", "Water Move Tree", "182", "20", "Tidal Smash", "0", "0", "0", "Attacking Branch 2"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_WATER14", "184", "Water Move Tree", "183", "23", "Tsunami Charge", "0", "0", "0", "Attacking Branch 2"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_WATER15", "185", "Water Move Tree", "0", "1", "Purify", "0", "0", "0", "Supporting Branch"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_WATER16", "186", "Water Move Tree", "185", "1", "Rinse", "0", "0", "0", "Supporting Branch"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_WATER17", "187", "Water Move Tree", "186", "1", "Spirit Water", "0", "0", "0", "Supporting Branch"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_WATER18", "188", "Water Move Tree", "187", "8", "Cleanse", "0", "0", "0", "Supporting Branch"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_WATER19", "189", "Water Move Tree", "188", "11", "Drench", "0", "0", "0", "Supporting Branch"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_WATER20", "190", "Water Move Tree", "189", "14", "Lifeline", "0", "0", "0", "Supporting Branch"));
			Rows.Add( new MoveTreeDataBackupRow("MTD_WATER21", "191", "Water Move Tree", "190", "17", "Healing Well", "0", "0", "0", "Supporting Branch"));
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
		public MoveTreeDataBackupRow GetRow(rowIds in_RowID)
		{
			MoveTreeDataBackupRow ret = null;
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
		public MoveTreeDataBackupRow GetRow(string in_RowString)
		{
			MoveTreeDataBackupRow ret = null;
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
