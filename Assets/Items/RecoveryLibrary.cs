using UnityEngine;
using System.Collections;
using Items;
using Google2u;
using System.Collections.Generic;


public class RecoveryLibrary : GenericLibrary {
	
	public RecoveryLibrary() {
		List<ItemsRecoveryRow> rows = ItemsRecovery.Instance.Rows;
		for(int i = 0 ; i < rows.Count ; i++ ) {
			_items.Add(new ItemRecoveryItem(rows[i]));
		}
		_name = "Recovery Library";
	}

}
