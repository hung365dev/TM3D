using UnityEngine;
using System.Collections;
using Battles;
using Items;
using Utils;
using utils;
using System;

namespace ManageMonster 
{
	public class ManageMonsterLeftSide : MonoBehaviour {
		
		public UILabel monsterName;
		public UILabel monsterEdit;
		public UILabel levelLabel;
		public UISlider healthSliderBar;
		public UISlider staminaSlider;
		public UISlider xpSlider;
		
		public UILabel hpLabel;
		public UILabel staminaLabel;
		public UILabel xpLabel;
		
		public BattleMonster previewMonster;
		private string originalMonsterName;
		private InventoryDisplay _inventory;
		
		public GameObject rightSide;
		// Use this for initialization
		void Start () {
			
		}
		
		

		// Update is called once per frame
		void Update () {
			
			if(this.previewMonster!=null) {
				hpLabel.text = System.Convert.ToInt32(this.previewMonster.monster.hp).ToString()+"/"+this.previewMonster.monster.MaxHP;
				healthSliderBar.value = this.previewMonster.monster.HpAsPercentage;
				
				levelLabel.text = "Lvl "+this.previewMonster.monster.level;;
				xpSlider.value = this.previewMonster.monster.XPAsPercentage;
				this.xpLabel.text = this.previewMonster.monster.XpToNext()+"xp to Next";
				
				this.staminaLabel.text = this.previewMonster.monster.energy+"/"+this.previewMonster.monster.MaxEnergy;
				this.staminaSlider.value = this.previewMonster.monster.energyAsPercentage;
			}
		}
		private void onInventoryClosed() {
			_inventory.onHideInventory -= onInventoryClosed;
			rightSide.gameObject.SetActive(true);
		}
		public void onUseInventory() {
			InventoryDisplay.inventoryType = EInventoryType.Ranchview;
		//	_inventory = AlertGUI.REF.LaunchInventory(previewMonster.monster);
		//	_inventory.onHideInventory += onInventoryClosed;;
			rightSide.gameObject.SetActive(false);
		}
		
		public void saveMonsterName() {
			if(monsterEdit.text.Length==0) {
				monsterName.text = originalMonsterName;
			} else {
				string editText = monsterEdit.text;
				/*if(editText.Contains("Rosebud")) {
					PlayerMain.REF.changeHardCurrency(1000);
				}
				
				if(editText.Contains("dubesoR")) {
					PlayerMain.REF.changeSoftCurrency(1000);
				}
				
				if(editText.Contains("offline")) {
					SaveGameUtils.REF.offlineUnlocked = true;
					AlertGUI.REF.DoGeneralAlert("Offline mode unlocked!","You have now unlocked offline mode :)");
				}*/
				if(editText.ToLower().StartsWith("code_")) {
					if(editText.Substring(5).ToLower()=="multiplayer") {
						AlertGUI.REF.switchOnMultiplayer();
						monsterEdit.text = this.previewMonster.monster.name;
						this.monsterName.text = this.previewMonster.monster.name;
						AlertGUI.REF.DoGeneralAlert("Multiplayer Enabled","Multiplayer has now been enabled for this session");
						return;
					}
					StartCoroutine(getCode(editText.Substring(5)));
					monsterEdit.text = this.previewMonster.monster.name;
				}
				monsterName.text = monsterEdit.text;
				this.previewMonster.monster.name = monsterName.text;
				PlayerMain.REF.saveMonsters();
			
			} 
		}
		
		private IEnumerator getCode(string aCode) {
			WWW tWWW = new WWW("http://www.blueomega.me/terramonsters/getCode.php?code="+aCode);
			while(!tWWW.isDone) {
				yield return new WaitForSeconds(0.1f);
			}
			yield return tWWW;
			//	Debug.Log ("JSON Loaded: "+tWWW.text);
			JSONObject j = new JSONObject(tWWW.text);
			//			Debug.Log (j.ToString());
			accessJSONData(j);
		}
		
		void accessJSONData(JSONObject obj){
			int type = 0;
			int coins = 0;
			int dollars = 0; 
			switch(obj.type){ 
			case JSONObject.Type.OBJECT:
				for(int i = 0; i < obj.list.Count; i++){
					string key = (string)obj.keys[i];
					
					JSONObject j = (JSONObject)obj.list[i];
					//						Debug.Log ("Loaded Key: "+key);
					switch(key) {
					case("voucherType"):type = Convert.ToInt32(j.n);break;
					case("terraCoins"):coins = Convert.ToInt32(j.n);break;
					case("terraDollars"):dollars = Convert.ToInt32(j.n);break;

					}
					//						Debug.Log(key);
					accessJSONData(j);
				}
				break;
			case JSONObject.Type.ARRAY:
				foreach(JSONObject j in obj.list){
					accessJSONData(j);
				}
				break;
			case JSONObject.Type.STRING:
				//			Debug.Log(obj.str);
				break;
			case JSONObject.Type.NUMBER:
				//	Debug.Log(obj.n);
				break;
			case JSONObject.Type.BOOL:
				//					Debug.Log(obj.b);
				break;
			case JSONObject.Type.NULL:
				//	Debug.Log("NULL");
				break;
				
			}
			string voucherResult = "";
			if(type>0) {
				
				voucherResult += "Your Voucher has unlocked offline mode! \n";
				SaveGameUtils.REF.offlineUnlocked = true;
			//	yield return new WaitForSeconds(1f);
				
			}
			if(coins>0) {
				
				
				voucherResult += "Your Voucher has awarded you with "+coins+" Terra Coins. \n";
				PlayerMain.REF.changeSoftCurrency(coins);
			//	yield return new WaitForSeconds(1f);
				
			}
			if(dollars>0) {
				voucherResult += "Your Voucher has awarded you with "+dollars+" Terra Dollars. \n";
				PlayerMain.REF.changeHardCurrency(dollars);
			//	yield return new WaitForSeconds(1f);
				
			}
			if(voucherResult.Length>0)
			AlertGUI.REF.DoGeneralAlert("Voucher",voucherResult);
		}
		
		public void updateMonsterName() {
			Debug.Log(monsterEdit.text);
			if(monsterEdit.text.Length==0) {
				monsterName.text = originalMonsterName;
			} else {
				monsterName.text = monsterEdit.text;
			}
		}
		public void initMonster(MonsterDataMain aMonster) {
			monsterName.text = aMonster.name;
			monsterEdit.text = aMonster.name;
			originalMonsterName = monsterName.text;
			GameObject monster =UnityEngine.Object.Instantiate( aMonster.prefab ) as GameObject;
			initBattleMonsterGameObject(monster,aMonster,1,EMonsterPos.Front);
			
		//	previewMonster = new BattleMonster();
	//		previewMonster.initMonster(aMonster,EMonsterPos.Middle);
			ManageMonsterMoves moves = this.GetComponent<ManageMonsterMoves>();
			moves.initMonster(aMonster,this.previewMonster);
			
			ManageMonsterStats stats = this.GetComponent<ManageMonsterStats>();
			stats.initMonster(aMonster);
			
			
			ManageMonsterPassiveEffect passive = this.GetComponent<ManageMonsterPassiveEffect>();
			passive.initMonster(aMonster);
			
		}
		private void initBattleMonsterGameObject(GameObject aMonster,MonsterDataMain aMonsterData,int aLayerOffset,EMonsterPos aPosition) {
			
			BattleMonster monster = aMonster.GetComponent("BattleMonster") as BattleMonster;
			if(monster==null) {
				aMonster.AddComponent<BattleMonster>();
				BattleConstants.positionMonster(aMonster,ETeamPosition.MonsterPreview,EMonsterPos.Front);
				monster = aMonster.GetComponent("BattleMonster") as BattleMonster;
			}
			monster.initMonster(aMonsterData,aPosition);
			monster.sortingLayer = "MonsterLayer3";
			previewMonster = monster;
			if(monster.monster==null) {
				Debug.LogError("Monster is null");
			}
		}
		
		
	}
}