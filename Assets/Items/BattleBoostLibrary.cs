using UnityEngine;
using System.Collections;
using Items;
using Google2u;
using System.Collections.Generic;


public class BattleBoostLibrary : GenericLibrary {
	public BattleBoostLibrary() {
		List<ItemsBattleBoostsRow> rows = ItemsBattleBoosts.Instance.Rows;
		for(int i = 0 ; i < rows.Count ; i++ ) {
			_items.Add(new BattleBoostItem(rows[i]));
		}
		_name = "Battle Boost Library";
	}
	 
}
