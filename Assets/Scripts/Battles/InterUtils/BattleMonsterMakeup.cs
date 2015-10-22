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
using Battles;


public class BattleMonsterMakeup : MonoBehaviour
{
	public UIProgressBar hp;
	public UILabel hpLabel;
	public UIProgressBar energy;
	public UILabel energyLabel;
	
	public UILabel monsterName;
	public bool debug = false;
	private BattleMonster _monsterRef;
	public BattleMonsterMakeup ()
	{
	}
	
	public void init(string aName,byte aLevel,BattleMonster aMonster) {
		monsterName.text = aName+" Lvl: "+aLevel;
		_monsterRef = aMonster;
		
	}
	
	public void Update() {
		if(debug) {
			this.transform.Find("MyPosition").gameObject.GetComponent<UILabel>().text = _monsterRef.myPosition.ToString();
			if(_monsterRef.futureMove!=null) {
				this.transform.Find("FutureMove").gameObject.GetComponent<UILabel>().text = _monsterRef.futureMove.moveData.Name;
				this.transform.Find("MyTarget").gameObject.GetComponent<UILabel>().text = _monsterRef.futureMove.targetMonster.ToString();
				
			} else {
				this.transform.Find("FutureMove").gameObject.GetComponent<UILabel>().text = "No Future Move";
				this.transform.Find("MyTarget").gameObject.GetComponent<UILabel>().text = "";
			}
		}
	}
	
}
