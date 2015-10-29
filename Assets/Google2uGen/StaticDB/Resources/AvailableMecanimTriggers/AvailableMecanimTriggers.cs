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
	public class AvailableMecanimTriggersRow : IGoogle2uRow
	{
		public int _ID;
		public string _MoveAnimations;
		public string _TriggerName;
		public int _AnimState;
		public AvailableMecanimTriggersRow(string __GOOGLEFU_ID, string __ID, string __MoveAnimations, string __TriggerName, string __AnimState) 
		{
			{
			int res;
				if(int.TryParse(__ID, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_ID = res;
				else
					Debug.LogError("Failed To Convert _ID string: "+ __ID +" to int");
			}
			_MoveAnimations = __MoveAnimations.Trim();
			_TriggerName = __TriggerName.Trim();
			{
			int res;
				if(int.TryParse(__AnimState, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_AnimState = res;
				else
					Debug.LogError("Failed To Convert _AnimState string: "+ __AnimState +" to int");
			}
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
					ret = _MoveAnimations.ToString();
					break;
				case 2:
					ret = _TriggerName.ToString();
					break;
				case 3:
					ret = _AnimState.ToString();
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
				case "MoveAnimations":
					ret = _MoveAnimations.ToString();
					break;
				case "TriggerName":
					ret = _TriggerName.ToString();
					break;
				case "AnimState":
					ret = _AnimState.ToString();
					break;
			}

			return ret;
		}
		public override string ToString()
		{
			string ret = System.String.Empty;
			ret += "{" + "ID" + " : " + _ID.ToString() + "} ";
			ret += "{" + "MoveAnimations" + " : " + _MoveAnimations.ToString() + "} ";
			ret += "{" + "TriggerName" + " : " + _TriggerName.ToString() + "} ";
			ret += "{" + "AnimState" + " : " + _AnimState.ToString() + "} ";
			return ret;
		}
	}
	public sealed class AvailableMecanimTriggers : IGoogle2uDB
	{
		public enum rowIds {
			MA_FAINT, MA_HITANIM, MA_HITANIMLARGE, MA_INSTANTFAINT, MA_TACKLERUN, MA_RANGEATTACK, MA_RANGEHIT, MA_SCRATCHATTACK, MA_AGGRESSIVESTANCE1, MA_AGGRESSIVESTANCE2, MA_AGGRESSIVESTANCE3, MA_AGGRESSIVESTANCE4, MA_AGGRESSIVESTANCE5, MA_NOANIM
		};
		public string [] rowNames = {
			"MA_FAINT", "MA_HITANIM", "MA_HITANIMLARGE", "MA_INSTANTFAINT", "MA_TACKLERUN", "MA_RANGEATTACK", "MA_RANGEHIT", "MA_SCRATCHATTACK", "MA_AGGRESSIVESTANCE1", "MA_AGGRESSIVESTANCE2", "MA_AGGRESSIVESTANCE3", "MA_AGGRESSIVESTANCE4", "MA_AGGRESSIVESTANCE5", "MA_NOANIM"
		};
		public System.Collections.Generic.List<AvailableMecanimTriggersRow> Rows = new System.Collections.Generic.List<AvailableMecanimTriggersRow>();

		public static AvailableMecanimTriggers Instance
		{
			get { return NestedAvailableMecanimTriggers.instance; }
		}

		private class NestedAvailableMecanimTriggers
		{
			static NestedAvailableMecanimTriggers() { }
			internal static readonly AvailableMecanimTriggers instance = new AvailableMecanimTriggers();
		}

		private AvailableMecanimTriggers()
		{
			Rows.Add( new AvailableMecanimTriggersRow("MA_FAINT", "1", "Faint", "Faint", "-1"));
			Rows.Add( new AvailableMecanimTriggersRow("MA_HITANIM", "2", "HitAnim", "HitAnim", "-1"));
			Rows.Add( new AvailableMecanimTriggersRow("MA_HITANIMLARGE", "3", "HitAnimLarge", "HitAnimLarge", "-1"));
			Rows.Add( new AvailableMecanimTriggersRow("MA_INSTANTFAINT", "4", "InstantFaint", "InstantFaint", "-1"));
			Rows.Add( new AvailableMecanimTriggersRow("MA_TACKLERUN", "5", "TackleRun", "TackleRun", "-1"));
			Rows.Add( new AvailableMecanimTriggersRow("MA_RANGEATTACK", "6", "RangeAttack", "RangeAttack", "-1"));
			Rows.Add( new AvailableMecanimTriggersRow("MA_RANGEHIT", "7", "RangeHit", "RangeHit", "-1"));
			Rows.Add( new AvailableMecanimTriggersRow("MA_SCRATCHATTACK", "8", "ScratchAttack", "ScratchAttack", "-1"));
			Rows.Add( new AvailableMecanimTriggersRow("MA_AGGRESSIVESTANCE1", "9", "AggressiveStance1", "AggressiveStance1", "-1"));
			Rows.Add( new AvailableMecanimTriggersRow("MA_AGGRESSIVESTANCE2", "10", "AggressiveStance2", "AggressiveStance2", "-1"));
			Rows.Add( new AvailableMecanimTriggersRow("MA_AGGRESSIVESTANCE3", "11", "AggressiveStance3", "AggressiveStance3", "-1"));
			Rows.Add( new AvailableMecanimTriggersRow("MA_AGGRESSIVESTANCE4", "12", "AggressiveStance4", "AggressiveStance4", "-1"));
			Rows.Add( new AvailableMecanimTriggersRow("MA_AGGRESSIVESTANCE5", "13", "AggressiveStance5", "AggressiveStance5", "-1"));
			Rows.Add( new AvailableMecanimTriggersRow("MA_NOANIM", "14", "NoAnim", "NoAnim", "-1"));
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
		public AvailableMecanimTriggersRow GetRow(rowIds in_RowID)
		{
			AvailableMecanimTriggersRow ret = null;
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
		public AvailableMecanimTriggersRow GetRow(string in_RowString)
		{
			AvailableMecanimTriggersRow ret = null;
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
