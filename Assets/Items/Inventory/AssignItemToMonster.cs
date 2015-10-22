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
using UnityEngine;

using System.Collections;
using Ranchview;


namespace Items
{
	public class AssignItemToMonster : MonoBehaviour
	{
		public RanchviewMonsterItem[] monsterItems;
		public InventoryItem item;
		public bool listening = false; 
		public AssignItemToMonster ()
		{
		
		}
		public void onCloseClick() {
			this.gameObject.SetActive(false);
		}
		
		public void OnDisable() {
			Debug.Log ("OnDisable()");
			PlayerMain.REF.onInventoryChanged -= onInventoryChanged;
			listening = false;
		}
		public void OnEnable() {
			Debug.Log ("OnEnable()");
			if(!listening) {
				PlayerMain.REF.onInventoryChanged += onInventoryChanged;
				listening = true;
			}
		}
		
		private void onInventoryChanged(InventoryItem aItem) {
			if(item.count==0) {
				this.gameObject.SetActive(false);
			}
		}
		public void initFromList(BetterList<MonsterDataMain> aList,InventoryItem aItem) {
			Debug.Log ("AssignItemToMonster->initFromList");
			this.gameObject.SetActive(true);
			item = aItem;
			for(int i = 0;i<monsterItems.Length;i++) {
				monsterItems[i].gameObject.SetActive(false);
			}
			
			for(int i = 0;i<aList.size;i++) {
				if(aList[i]!=null) {
					monsterItems[i].init(aList[i],aItem);
					monsterItems[i].gameObject.SetActive(true);
				}
			}
			if(item.count==0) {
				
				this.gameObject.SetActive(false);
			}
			
		}
		
	}
}
