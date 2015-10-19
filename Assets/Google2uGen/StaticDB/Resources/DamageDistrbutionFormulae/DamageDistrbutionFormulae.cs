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
	public class DamageDistrbutionFormulaeRow : IGoogle2uRow
	{
		public int _ID;
		public string _Name;
		public float _FirstTurnPower;
		public float _IncreasePerTurn;
		public DamageDistrbutionFormulaeRow(string __GOOGLEFU_ID, string __ID, string __Name, string __FirstTurnPower, string __IncreasePerTurn) 
		{
			{
			int res;
				if(int.TryParse(__ID, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_ID = res;
				else
					Debug.LogError("Failed To Convert _ID string: "+ __ID +" to int");
			}
			_Name = __Name.Trim();
			{
			float res;
				if(float.TryParse(__FirstTurnPower, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_FirstTurnPower = res;
				else
					Debug.LogError("Failed To Convert _FirstTurnPower string: "+ __FirstTurnPower +" to float");
			}
			{
			float res;
				if(float.TryParse(__IncreasePerTurn, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_IncreasePerTurn = res;
				else
					Debug.LogError("Failed To Convert _IncreasePerTurn string: "+ __IncreasePerTurn +" to float");
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
					ret = _Name.ToString();
					break;
				case 2:
					ret = _FirstTurnPower.ToString();
					break;
				case 3:
					ret = _IncreasePerTurn.ToString();
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
				case "FirstTurnPower":
					ret = _FirstTurnPower.ToString();
					break;
				case "IncreasePerTurn":
					ret = _IncreasePerTurn.ToString();
					break;
			}

			return ret;
		}
		public override string ToString()
		{
			string ret = System.String.Empty;
			ret += "{" + "ID" + " : " + _ID.ToString() + "} ";
			ret += "{" + "Name" + " : " + _Name.ToString() + "} ";
			ret += "{" + "FirstTurnPower" + " : " + _FirstTurnPower.ToString() + "} ";
			ret += "{" + "IncreasePerTurn" + " : " + _IncreasePerTurn.ToString() + "} ";
			return ret;
		}
	}
	public sealed class DamageDistrbutionFormulae : IGoogle2uDB
	{
		public enum rowIds {
			DD_STANDARD
		};
		public string [] rowNames = {
			"DD_STANDARD"
		};
		public System.Collections.Generic.List<DamageDistrbutionFormulaeRow> Rows = new System.Collections.Generic.List<DamageDistrbutionFormulaeRow>();

		public static DamageDistrbutionFormulae Instance
		{
			get { return NestedDamageDistrbutionFormulae.instance; }
		}

		private class NestedDamageDistrbutionFormulae
		{
			static NestedDamageDistrbutionFormulae() { }
			internal static readonly DamageDistrbutionFormulae instance = new DamageDistrbutionFormulae();
		}

		private DamageDistrbutionFormulae()
		{
			Rows.Add( new DamageDistrbutionFormulaeRow("DD_STANDARD", "1", "Standard", "1", "1"));
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
		public DamageDistrbutionFormulaeRow GetRow(rowIds in_RowID)
		{
			DamageDistrbutionFormulaeRow ret = null;
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
		public DamageDistrbutionFormulaeRow GetRow(string in_RowString)
		{
			DamageDistrbutionFormulaeRow ret = null;
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
