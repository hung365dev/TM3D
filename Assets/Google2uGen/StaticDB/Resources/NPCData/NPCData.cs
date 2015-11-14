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
	public class NPCDataRow : IGoogle2uRow
	{
		public int _ID;
		public string _Name;
		public string _UMAData;
		public NPCDataRow(string __GOOGLEFU_ID, string __ID, string __Name, string __UMAData) 
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
	public sealed class NPCData : IGoogle2uDB
	{
		public enum rowIds {
			NPC_1
		};
		public string [] rowNames = {
			"NPC_1"
		};
		public System.Collections.Generic.List<NPCDataRow> Rows = new System.Collections.Generic.List<NPCDataRow>();

		public static NPCData Instance
		{
			get { return NestedNPCData.instance; }
		}

		private class NestedNPCData
		{
			static NestedNPCData() { }
			internal static readonly NPCData instance = new NPCData();
		}

		private NPCData()
		{
			Rows.Add( new NPCDataRow("NPC_1", "1", "MarketKeeper", "{\"version\":2,\"packedSlotDataList\":null,\"slotsV2\":[{\"id\":\"ChibiBody_Head\",\"scale\":100,\"copyIdx\":-1,\"overlays\":[{\"id\":\"DefaultOverlay\",\"colorIdx\":0,\"rect\":[0,0,0,0]}]},{\"id\":\"Arms\",\"scale\":100,\"copyIdx\":-1,\"overlays\":[]},{\"id\":\"Feet\",\"scale\":100,\"copyIdx\":-1,\"overlays\":[]},{\"id\":\"Head\",\"scale\":100,\"copyIdx\":-1,\"overlays\":[]},{\"id\":\"Legs\",\"scale\":100,\"copyIdx\":-1,\"overlays\":[]},{\"id\":\"Pelvis\",\"scale\":100,\"copyIdx\":-1,\"overlays\":[]},{\"id\":\"Eyes\",\"scale\":100,\"copyIdx\":-1,\"overlays\":[{\"id\":\"EyesOverlay\",\"colorIdx\":0,\"rect\":[0,0,0,0]}]},{\"id\":\"BoyHair1\",\"scale\":100,\"copyIdx\":-1,\"overlays\":[{\"id\":\"BoyHair\",\"colorIdx\":0,\"rect\":[0,0,0,0]}]},{\"id\":\"Jacket_Hoodie\",\"scale\":100,\"copyIdx\":-1,\"overlays\":[{\"id\":\"JacketOverlay\",\"colorIdx\":1,\"rect\":[0,0,0,0]}]},{\"id\":\"Jeans\",\"scale\":100,\"copyIdx\":-1,\"overlays\":[{\"id\":\"JeansOverlay\",\"colorIdx\":0,\"rect\":[0,0,0,0]}]},null,null,null,null,null,null,null,null,null,null],\"colors\":null,\"fColors\":[{\"name\":null,\"colors\":[255,255,255,255,0,0,0,0]},{\"name\":null,\"colors\":[0,255,0,255,0,0,0,0]}],\"sharedColorCount\":0,\"race\":\"BoyRace\",\"umaDna\":{},\"packedDna\":[{\"dnaType\":\"UMADnaHumanoid\",\"packedDna\":\"{\\\"height\\\":147,\\\"headSize\\\":89,\\\"headWidth\\\":0,\\\"neckThickness\\\":128,\\\"armLength\\\":165,\\\"forearmLength\\\":128,\\\"armWidth\\\":128,\\\"forearmWidth\\\":128,\\\"handsSize\\\":128,\\\"feetSize\\\":128,\\\"legSeparation\\\":128,\\\"upperMuscle\\\":128,\\\"lowerMuscle\\\":128,\\\"upperWeight\\\":255,\\\"lowerWeight\\\":128,\\\"legsSize\\\":176,\\\"belly\\\":128,\\\"waist\\\":128,\\\"gluteusSize\\\":255,\\\"earsSize\\\":255,\\\"earsPosition\\\":255,\\\"earsRotation\\\":128,\\\"noseSize\\\":128,\\\"noseCurve\\\":128,\\\"noseWidth\\\":128,\\\"noseInclination\\\":128,\\\"nosePosition\\\":128,\\\"nosePronounced\\\":128,\\\"noseFlatten\\\":128,\\\"chinSize\\\":255,\\\"chinPronounced\\\":255,\\\"chinPosition\\\":255,\\\"mandibleSize\\\":128,\\\"jawsSize\\\":128,\\\"jawsPosition\\\":128,\\\"cheekSize\\\":255,\\\"cheekPosition\\\":255,\\\"lowCheekPronounced\\\":128,\\\"lowCheekPosition\\\":255,\\\"foreheadSize\\\":128,\\\"foreheadPosition\\\":255,\\\"lipsSize\\\":255,\\\"mouthSize\\\":0,\\\"eyeRotation\\\":255,\\\"eyeSize\\\":255,\\\"breastSize\\\":255}\"},{\"dnaType\":\"UMADnaTutorial\",\"packedDna\":\"{\\\"eyeSpacing\\\":128}\"}]}"));
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
		public NPCDataRow GetRow(rowIds in_RowID)
		{
			NPCDataRow ret = null;
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
		public NPCDataRow GetRow(string in_RowString)
		{
			NPCDataRow ret = null;
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
