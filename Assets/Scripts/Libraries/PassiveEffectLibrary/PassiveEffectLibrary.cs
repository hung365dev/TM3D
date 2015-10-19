using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Google2u;
public class PassiveEffectLibrary : MonoBehaviour {
	
	private BetterList<PassiveEffect> effects = new BetterList<PassiveEffect>();
	
	public static PassiveEffectLibrary REF;
	public PassiveEffectLibrary() {
	

	}
	public void init() {
		List<PassiveEffectsRow> passiveDataRow = PassiveEffects.Instance.Rows;
		if(effects.size==0) {
			for (int i = 0; i < passiveDataRow.Count; i++) {
				PassiveEffect passiveItem = new PassiveEffect(passiveDataRow[i]);
				effects.Add(passiveItem);
			}
		}
	}
	public void Awake() {
		if(REF==null) {
			DontDestroyOnLoad(this);
			REF = this;
		} else {
			Destroy (this);
		}
	}
	public PassiveEffect getPassiveEffect(int aID) {
		for(int i = 0; i < effects.size ; i++) {
			if(effects[i].id==aID) {
				return effects[i];
			}
		}
		return null;
	}
	
	public PassiveEffect getPassiveEffect(int aClass,ElementalType aType1,ElementalType aType2) {
		BetterList<PassiveEffect> selectionList = new BetterList<PassiveEffect>();
		for(int i = 0;i<effects.size;i++) {
			if(effects[i].elementType==aType1||effects[i].elementType==aType2) {
				if((effects[i].effectClass&aClass)==effects[i].effectClass) {
					for(int c = 0;c<effects[i].weighting;c++) {
						selectionList.Add(effects[i]);
					}
				}
			}
		}
		int random = Random.Range(0,selectionList.size);
		return selectionList[random];
	}
	public PassiveEffect getPassiveEffect(string aName) {
		for(int i = 0; i < effects.size ; i++) {
			if(effects[i].name==aName) {
				return effects[i];
			}
		}
		return null;
	}
}
