using System;
using Google2u;
using System.Collections.Generic;
using System.Collections;
using UnityEngine;


public class MoveTreeLibrary : MonoBehaviour
{
	private BetterList<MoveTree> list = new BetterList<MoveTree>();
	public static MoveTreeLibrary REF;
	public void Awake ()
	{
		if(REF==null) {
			REF = this;
			DontDestroyOnLoad(this);
		} else {
			Destroy(this);
		}
	}
	public void initMoveTrees() {
		List<MoveTreesRow> moveTrees = MoveTrees.Instance.Rows;
		for (int i = 0; i < moveTrees.Count; i++) {
			list.Add(new MoveTree(moveTrees[i]));
		}
	}
	public MoveTree GetMoveTree(string aName) {
		for (int i = 0; i < list.size; i++) {
			if(list[i].Name == aName) {
				return list[i];
			}
		}
		return null;
	}
}

 