using UnityEngine;
using System.Collections;
using Items;
using Google2u;
using System.Collections.Generic;


public class PlayerBoostsLibrary : GenericLibrary {
	
	public PlayerBoostsLibrary() {
		List<ItemsPlayerBoostsRow> rows = ItemsPlayerBoosts.Instance.Rows;
		for(int i = 0 ; i < rows.Count ; i++ ) {
			_items.Add(new PlayerBoostItem(rows[i]));
		}
		_name = "Player Boosts Library";
	}
	
}
