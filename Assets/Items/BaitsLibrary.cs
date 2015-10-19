using UnityEngine;
using System.Collections;
using Items;
using Google2u;
using System.Collections.Generic;

public class BaitsLibrary : GenericLibrary {

	public BaitsLibrary() {
		List<ItemsBaitsRow> rows = ItemsBaits.Instance.Rows;
		for(int i = 0 ; i < rows.Count ; i++ ) {
			_items.Add(new ItemBait(rows[i]));
		}
		_name = "Baits Library"; 
	}
	
	
	
}
