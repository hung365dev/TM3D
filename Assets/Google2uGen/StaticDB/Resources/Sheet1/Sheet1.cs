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
	public class Sheet1Row : IGoogle2uRow
	{
		public int _ID;
		public string _Name;
		public string _UMAData;
		public Sheet1Row(string __GOOGLEFU_ID, string __ID, string __Name, string __UMAData) 
		{
			{
			int res;
				if(int.TryParse(__ID, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_ID = res;
				else
					Debug.LogError("Failed To Convert _ID string: "+ __ID +" to int");
			}
			_Name = __Name.Trim();
			_UMAData = __UMAData.Trim();
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
					ret = _UMAData.ToString();
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
				case "UMAData":
					ret = _UMAData.ToString();
					break;
			}

			return ret;
		}
		public override string ToString()
		{
			string ret = System.String.Empty;
			ret += "{" + "ID" + " : " + _ID.ToString() + "} ";
			ret += "{" + "Name" + " : " + _Name.ToString() + "} ";
			ret += "{" + "UMAData" + " : " + _UMAData.ToString() + "} ";
			return ret;
		}
	}
	public sealed class Sheet1 : IGoogle2uDB
	{
		public enum rowIds {
			NPC_1
		};
		public string [] rowNames = {
			"NPC_1"
		};
		public System.Collections.Generic.List<Sheet1Row> Rows = new System.Collections.Generic.List<Sheet1Row>();

		public static Sheet1 Instance
		{
			get { return NestedSheet1.instance; }
		}

		private class NestedSheet1
		{
			static NestedSheet1() { }
			internal static readonly Sheet1 instance = new Sheet1();
		}

		private Sheet1()
		{
			Rows.Add( new Sheet1Row("NPC_1", "1", "MarketKeeper", "{\"version\":2,\"packedSlotDataList\":null,\"slotsV2\":[{\"id\":\"Torso\",\"scale\":100,\"copyIdx\":-1,\"overlays\":[{\"id\":\"DefaultOverlay\",\"colorIdx\":0,\"rect\":[0,0,0,0]}]},{\"id\":\"Arms\",\"scale\":100,\"copyIdx\":0,\"overlays\":null},{\"id\":\"Feet\",\"scale\":100,\"copyIdx\":0,\"overlays\":null},{\"id\":\"Head\",\"scale\":100,\"copyIdx\":0,\"overlays\":null},{\"id\":\"Legs\",\"scale\":100,\"copyIdx\":0,\"overlays\":null},{\"id\":\"Pelvis\",\"scale\":100,\"copyIdx\":0,\"overlays\":null},{\"id\":\"ChibiBody_Head\",\"scale\":100,\"copyIdx\":0,\"overlays\":null},{\"id\":\"Eyes\",\"scale\":100,\"copyIdx\":-1,\"overlays\":[{\"id\":\"EyesOverlay\",\"colorIdx\":0,\"rect\":[0,0,0,0]}]},null,null,null,null,null,null,null,null,null,null,null,null],\"colors\":null,\"fColors\":[{\"name\":null,\"colors\":[255,255,255,255,0,0,0,0]}],\"sharedColorCount\":0,\"race\":\"BoyRace\",\"umaDna\":{},\"packedDna\":[{\"dnaType\":\"UMADnaHumanoid\",\"packedDna\":\"{\\\"height\\\":208,\\\"headSize\\\":94,\\\"headWidth\\\":0,\\\"neckThickness\\\":255,\\\"armLength\\\":117,\\\"forearmLength\\\":176,\\\"armWidth\\\":128,\\\"forearmWidth\\\":128,\\\"handsSize\\\":114,\\\"feetSize\\\":190,\\\"legSeparation\\\":0,\\\"upperMuscle\\\":128,\\\"lowerMuscle\\\":128,\\\"upperWeight\\\":104,\\\"lowerWeight\\\":128,\\\"legsSize\\\":70,\\\"belly\\\":255,\\\"waist\\\":255,\\\"gluteusSize\\\":255,\\\"earsSize\\\":255,\\\"earsPosition\\\":255,\\\"earsRotation\\\":255,\\\"noseSize\\\":255,\\\"noseCurve\\\":255,\\\"noseWidth\\\":255,\\\"noseInclination\\\":255,\\\"nosePosition\\\":255,\\\"nosePronounced\\\":255,\\\"noseFlatten\\\":0,\\\"chinSize\\\":255,\\\"chinPronounced\\\":255,\\\"chinPosition\\\":255,\\\"mandibleSize\\\":255,\\\"jawsSize\\\":0,\\\"jawsPosition\\\":0,\\\"cheekSize\\\":255,\\\"cheekPosition\\\":255,\\\"lowCheekPronounced\\\":154,\\\"lowCheekPosition\\\":114,\\\"foreheadSize\\\":0,\\\"foreheadPosition\\\":0,\\\"lipsSize\\\":255,\\\"mouthSize\\\":255,\\\"eyeRotation\\\":255,\\\"eyeSize\\\":0,\\\"breastSize\\\":255}\"}]}"));
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
		public Sheet1Row GetRow(rowIds in_RowID)
		{
			Sheet1Row ret = null;
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
		public Sheet1Row GetRow(string in_RowString)
		{
			Sheet1Row ret = null;
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
