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
	public class ItemsQuestRow : IGoogle2uRow
	{
		public int _ID;
		public string _ItemName;
		public string _ItemDescription;
		public string _Sprite;
		public int _SpriteTintR;
		public int _SpriteTintG;
		public int _SpriteTintB;
		public int _SpriteTintA;
		public ItemsQuestRow(string __GOOGLEFU_ID, string __ID, string __ItemName, string __ItemDescription, string __Sprite, string __SpriteTintR, string __SpriteTintG, string __SpriteTintB, string __SpriteTintA) 
		{
			{
			int res;
				if(int.TryParse(__ID, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_ID = res;
				else
					Debug.LogError("Failed To Convert _ID string: "+ __ID +" to int");
			}
			_ItemName = __ItemName.Trim();
			_ItemDescription = __ItemDescription.Trim();
			_Sprite = __Sprite.Trim();
			{
			int res;
				if(int.TryParse(__SpriteTintR, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_SpriteTintR = res;
				else
					Debug.LogError("Failed To Convert _SpriteTintR string: "+ __SpriteTintR +" to int");
			}
			{
			int res;
				if(int.TryParse(__SpriteTintG, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_SpriteTintG = res;
				else
					Debug.LogError("Failed To Convert _SpriteTintG string: "+ __SpriteTintG +" to int");
			}
			{
			int res;
				if(int.TryParse(__SpriteTintB, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_SpriteTintB = res;
				else
					Debug.LogError("Failed To Convert _SpriteTintB string: "+ __SpriteTintB +" to int");
			}
			{
			int res;
				if(int.TryParse(__SpriteTintA, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_SpriteTintA = res;
				else
					Debug.LogError("Failed To Convert _SpriteTintA string: "+ __SpriteTintA +" to int");
			}
		}

		public int Length { get { return 8; } }

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
					ret = _ItemName.ToString();
					break;
				case 2:
					ret = _ItemDescription.ToString();
					break;
				case 3:
					ret = _Sprite.ToString();
					break;
				case 4:
					ret = _SpriteTintR.ToString();
					break;
				case 5:
					ret = _SpriteTintG.ToString();
					break;
				case 6:
					ret = _SpriteTintB.ToString();
					break;
				case 7:
					ret = _SpriteTintA.ToString();
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
				case "ItemName":
					ret = _ItemName.ToString();
					break;
				case "ItemDescription":
					ret = _ItemDescription.ToString();
					break;
				case "Sprite":
					ret = _Sprite.ToString();
					break;
				case "SpriteTintR":
					ret = _SpriteTintR.ToString();
					break;
				case "SpriteTintG":
					ret = _SpriteTintG.ToString();
					break;
				case "SpriteTintB":
					ret = _SpriteTintB.ToString();
					break;
				case "SpriteTintA":
					ret = _SpriteTintA.ToString();
					break;
			}

			return ret;
		}
		public override string ToString()
		{
			string ret = System.String.Empty;
			ret += "{" + "ID" + " : " + _ID.ToString() + "} ";
			ret += "{" + "ItemName" + " : " + _ItemName.ToString() + "} ";
			ret += "{" + "ItemDescription" + " : " + _ItemDescription.ToString() + "} ";
			ret += "{" + "Sprite" + " : " + _Sprite.ToString() + "} ";
			ret += "{" + "SpriteTintR" + " : " + _SpriteTintR.ToString() + "} ";
			ret += "{" + "SpriteTintG" + " : " + _SpriteTintG.ToString() + "} ";
			ret += "{" + "SpriteTintB" + " : " + _SpriteTintB.ToString() + "} ";
			ret += "{" + "SpriteTintA" + " : " + _SpriteTintA.ToString() + "} ";
			return ret;
		}
	}
	public sealed class ItemsQuest : IGoogle2uDB
	{
		public enum rowIds {
			ITMQUEST_1, ITMQUEST_2, ITMQUEST_3, ITMQUEST_4, ITMQUEST_5, ITMQUEST_6, ITMQUEST_7, ITMQUEST_8
		};
		public string [] rowNames = {
			"ITMQUEST_1", "ITMQUEST_2", "ITMQUEST_3", "ITMQUEST_4", "ITMQUEST_5", "ITMQUEST_6", "ITMQUEST_7", "ITMQUEST_8"
		};
		public System.Collections.Generic.List<ItemsQuestRow> Rows = new System.Collections.Generic.List<ItemsQuestRow>();

		public static ItemsQuest Instance
		{
			get { return NestedItemsQuest.instance; }
		}

		private class NestedItemsQuest
		{
			static NestedItemsQuest() { }
			internal static readonly ItemsQuest instance = new ItemsQuest();
		}

		private ItemsQuest()
		{
			Rows.Add( new ItemsQuestRow("ITMQUEST_1", "1", "Letter for Santa", "Because there's always letters to be delivered", "Package", "0", "0", "0", "0"));
			Rows.Add( new ItemsQuestRow("ITMQUEST_2", "2", "Mishi Badge", "Proof that you are a member of the Mishi Guild", "earthbadge", "0", "0", "0", "0"));
			Rows.Add( new ItemsQuestRow("ITMQUEST_3", "3", "Namanja Badge", "Proof that you are a member of the Namanja Guild", "waterbadge", "0", "0", "0", "0"));
			Rows.Add( new ItemsQuestRow("ITMQUEST_4", "4", "Ouadda Badge", "Proof that you are a member of the Ouadda Guild", "electricbadge", "0", "0", "0", "0"));
			Rows.Add( new ItemsQuestRow("ITMQUEST_5", "5", "Jinja Badge", "Proof that you are a member of the Jinja Guild", "icebadge", "0", "0", "0", "0"));
			Rows.Add( new ItemsQuestRow("ITMQUEST_6", "6", "Kismayo Badge", "Proof that you are a member of the Kismayo Guild", "firebadge", "0", "0", "0", "0"));
			Rows.Add( new ItemsQuestRow("ITMQUEST_7", "7", "Mombassi Badge", "Proof that you are a member of the Mombassi Guild", "airbadge", "0", "0", "0", "0"));
			Rows.Add( new ItemsQuestRow("ITMQUEST_8", "8", "Arcane Badge", "Proof that you are a member of the Arcane Guild", "arcanebadge", "0", "0", "0", "0"));
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
		public ItemsQuestRow GetRow(rowIds in_RowID)
		{
			ItemsQuestRow ret = null;
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
		public ItemsQuestRow GetRow(string in_RowString)
		{
			ItemsQuestRow ret = null;
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
