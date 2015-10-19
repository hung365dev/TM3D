using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using GoogleFu;
public class MovesAnimationLib {
	
	private BetterList<MoveAnimationLibItem> animations = new BetterList<MoveAnimationLibItem>();
	
	public static MovesAnimationLib REF = new MovesAnimationLib();
	public MovesAnimationLib() {
		List<MoveAnimationNamesRow> moveAnimRow = MoveAnimationNames.Instance.Rows;
		for (int i = 0; i < moveAnimRow.Count; i++) {
			MoveAnimationLibItem moveLibItem = new MoveAnimationLibItem(moveAnimRow[i]);
			animations.Add(moveLibItem);
		}
	}
	public BetterList<MoveAnimationLibItem> items {
		get {
			return animations;
		}
	}
	public MoveAnimationLibItem getAnimation(string aName) {
		for(int i = 0; i < animations.size ; i++) {
			if(animations[i].name==aName) {
				return animations[i];
			}
		}
		return null;
	}
}
