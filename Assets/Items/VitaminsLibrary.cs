using UnityEngine;
using System.Collections;
using Items;
using System.Collections.Generic;
using Google2u;
 
public class VitaminsLibrary : GenericLibrary {
	public VitaminsLibrary() {
		List<ItemsVitaminsRow> rows = ItemsVitamins.Instance.Rows;
		for(int i = 0 ; i < rows.Count ; i++ ) {
			_items.Add(new ItemVitamin(rows[i]));
		}
		_name = "Vitamins Library";
	}
}
