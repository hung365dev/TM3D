using UnityEngine;
using System.Collections;
using Google2u;

[RequireComponent (typeof (UMAMaker))]
public class NPCCharacterBase : MonoBehaviour {


	public string npcName;

	// Use this for initialization
	void Start () {
	
		if (npcName.Length > 0) {
			NPCDataRow r = NPCCharacterBase.getRowFromNPCName(npcName);
			this.GetComponent<UMAMaker>().SaveString = r._UMAData;
			this.GetComponent<UMAMaker>().load = true;
			this.GetComponent<UMAMaker>().GenerateUMA();
		}
	}
	 
	public static NPCDataRow getRowFromNPCName(string aName) {
		for(int i = 0;i<NPCData.Instance.Rows.Count;i++) {
				if(NPCData.Instance.Rows[i]._Name==aName) {
					return NPCData.Instance.Rows[i];
				}
		}
		return null;
	}
	
	// Update is called once per frame
	void Update () {
	
	}


}
