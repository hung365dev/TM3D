﻿using UnityEngine;
using System.Collections;
using Google2u;

[RequireComponent (typeof (UMAMaker))]
public class NPCCharacterBase : MonoBehaviour {


	public string npcName;

	// Use this for initialization
	void Start () {
	
		if (npcName.Length > 0) {
			 
		}
	}

	public static NPCDataRow getRowFromNPCName(string aName) {
		for(int i = 0;i<NPCData.Instance.Rows.Count;i++) {
		
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}


}
