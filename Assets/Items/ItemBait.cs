// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------
using System;
using Google2u;
using UnityEngine;


namespace Items
{
	public class ItemBait : ItemGeneric
	{
		public float ballStrength;
		public ElementalType specialityType;
		public ItemBait (ItemsBaitsRow aRow)
		{
			this._name = aRow._itemname;
			this._description = aRow._itemdescription;
			this._hardCost = (int) aRow._hardcurrency;
			this._softCost = (int) aRow._softcurrency;
			this._spritePrefab = aRow._sprite;
			this._id = (int) aRow._id;
			ballStrength = (float) aRow._strength;
			_itemType = EItemType.Bait;
			this._tintColour = new Color((float) aRow._spritetintr/255f,(float) aRow._spritetintg/255f,(float) aRow._spritetintb/255f,(float) aRow._spritetinta/255f);
		}
		 
	}
}

