using UnityEngine;
using System.Collections;
using ManageMonster;
using Battles;

public class ManageMonsterRightInit : MonoBehaviour {

	// Use this for initialization
	public delegate void OnCloseInfo();
	public event OnCloseInfo onClose;
	void Start () {
	
	}
	public void init(MonsterDataMain aMonster,BattleMonster aBattleMonster) {
		this.GetComponent<ManageMonsterStats>().initMonster(aMonster);
		this.GetComponent<ManageMonsterMoves>().initMonster(aMonster,aBattleMonster);
		this.GetComponent<ManageMonsterPassiveEffect>().initMonster(aMonster);
	}
	// Update is called once per frame
	void Update () {
	 
	}
	
	public void onCloseInfo() {
		if(onClose!=null) {
			onClose();
		}
		Destroy (this.gameObject);
	}
}
