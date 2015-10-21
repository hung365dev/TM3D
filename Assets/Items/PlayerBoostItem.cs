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
	public class PlayerBoostItem : ItemGeneric
	{
		public float itemStrength;
		public EPlayerBoostType boostType;
		public int time;
		public PlayerBoostItem (ItemsPlayerBoostsRow aRow)
		{
			this._name = aRow._ItemName;
			this._description = aRow._ItemDescription;
			this._hardCost = (int) aRow._HardCurrency;
			this._softCost = (int) aRow._SoftCurrency;
			this._spritePrefab = aRow._Sprite;
			this._id = (int) aRow._ID;
			
			this.itemStrength = (float) aRow._Strength;
			switch(aRow._Type) {
				case("BoostXP"):boostType = EPlayerBoostType.XPBoost;break;
				case("Repel"):boostType = EPlayerBoostType.Repel;break;
			}
			time = aRow._Seconds;
			_itemType = EItemType.PlayerBoost;
			this._tintColour = new Color((float) aRow._SpriteTintR/255f,(float) aRow._SpriteTintG/255f,(float) aRow._SpriteTintB/255f,(float) aRow._SpriteTintA/255f);
		}
		
	}
}

