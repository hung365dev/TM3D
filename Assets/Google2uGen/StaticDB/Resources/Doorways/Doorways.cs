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
	public class DoorwaysRow : IGoogle2uRow
	{
		public int _ID;
		public string _HostMap;
		public string _TargetMap;
		public int _TriggerID;
		public int _TargetXPos;
		public int _TargetYPos;
		public DoorwaysRow(string __GOOGLEFU_ID, string __ID, string __HostMap, string __TargetMap, string __TriggerID, string __TargetXPos, string __TargetYPos) 
		{
			{
			int res;
				if(int.TryParse(__ID, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_ID = res;
				else
					Debug.LogError("Failed To Convert _ID string: "+ __ID +" to int");
			}
			_HostMap = __HostMap.Trim();
			_TargetMap = __TargetMap.Trim();
			{
			int res;
				if(int.TryParse(__TriggerID, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_TriggerID = res;
				else
					Debug.LogError("Failed To Convert _TriggerID string: "+ __TriggerID +" to int");
			}
			{
			int res;
				if(int.TryParse(__TargetXPos, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_TargetXPos = res;
				else
					Debug.LogError("Failed To Convert _TargetXPos string: "+ __TargetXPos +" to int");
			}
			{
			int res;
				if(int.TryParse(__TargetYPos, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_TargetYPos = res;
				else
					Debug.LogError("Failed To Convert _TargetYPos string: "+ __TargetYPos +" to int");
			}
		}

		public int Length { get { return 6; } }

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
					ret = _HostMap.ToString();
					break;
				case 2:
					ret = _TargetMap.ToString();
					break;
				case 3:
					ret = _TriggerID.ToString();
					break;
				case 4:
					ret = _TargetXPos.ToString();
					break;
				case 5:
					ret = _TargetYPos.ToString();
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
				case "HostMap":
					ret = _HostMap.ToString();
					break;
				case "TargetMap":
					ret = _TargetMap.ToString();
					break;
				case "TriggerID":
					ret = _TriggerID.ToString();
					break;
				case "TargetXPos":
					ret = _TargetXPos.ToString();
					break;
				case "TargetYPos":
					ret = _TargetYPos.ToString();
					break;
			}

			return ret;
		}
		public override string ToString()
		{
			string ret = System.String.Empty;
			ret += "{" + "ID" + " : " + _ID.ToString() + "} ";
			ret += "{" + "HostMap" + " : " + _HostMap.ToString() + "} ";
			ret += "{" + "TargetMap" + " : " + _TargetMap.ToString() + "} ";
			ret += "{" + "TriggerID" + " : " + _TriggerID.ToString() + "} ";
			ret += "{" + "TargetXPos" + " : " + _TargetXPos.ToString() + "} ";
			ret += "{" + "TargetYPos" + " : " + _TargetYPos.ToString() + "} ";
			return ret;
		}
	}
	public sealed class Doorways : IGoogle2uDB
	{
		public enum rowIds {
			DOOR_1, DOOR_2
		};
		public string [] rowNames = {
			"DOOR_1", "DOOR_2"
		};
		public System.Collections.Generic.List<DoorwaysRow> Rows = new System.Collections.Generic.List<DoorwaysRow>();

		public static Doorways Instance
		{
			get { return NestedDoorways.instance; }
		}

		private class NestedDoorways
		{
			static NestedDoorways() { }
			internal static readonly Doorways instance = new Doorways();
		}

		private Doorways()
		{
			Rows.Add( new DoorwaysRow("DOOR_1", "1", "Game Test Map", "Smaller Map", "1", "2", "2"));
			Rows.Add( new DoorwaysRow("DOOR_2", "2", "Smaller Map", "Game Test Map", "1", "4", "4"));
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
		public DoorwaysRow GetRow(rowIds in_RowID)
		{
			DoorwaysRow ret = null;
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
		public DoorwaysRow GetRow(string in_RowString)
		{
			DoorwaysRow ret = null;
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
