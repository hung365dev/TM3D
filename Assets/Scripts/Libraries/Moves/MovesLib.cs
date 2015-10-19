using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Google2u;
using System;


public class MovesLib : MonoBehaviour{

	private BetterList<MoveLibItem> moves = new BetterList<MoveLibItem>();

	public static MovesLib REF;
	private int _cachedMax = int.MinValue;

	public void Awake() {
		if(REF==null) {
			DontDestroyOnLoad(this);
			REF = this;

		}
	}
	public MoveLibItem struggleMove {
		get {
			for(int i = 0;i<moves.size;i++) {
				if(moves[i].isStruggleMove) {
					return moves[i];
				}
			}
			return null;
		}
	}
	public float energyMultiplier {
		set {
			for(int i = 0;i<moves.size;i++) {
				moves[i].energy = Convert.ToInt32(moves[i].energy*value);
			}
		}
	}
	public float powerMultiplier {
		set {
			for(int i = 0;i<moves.size;i++) {
				moves[i].power = Convert.ToInt32(moves[i].power*value);
			}
		}
	}
	
	public void init() {
		List<MoveDataRow> moveDataRow = MoveData.Instance.Rows;
		for (int i = 0; i < moveDataRow.Count; i++) {
			MoveLibItem moveLibItem = new MoveLibItem(moveDataRow[i]);
			moves.Add(moveLibItem);
		}
		for(int i = 0;i<moves.size;i++) {
			if(moves[i].alsoApplyThisString!=null&&moves[i].alsoApplyThisString.Length!=0) {
				moves[i].alsoApplyThis = getMove(moves[i].alsoApplyThisString);
			}
		}
	}
	public int maxMoveEnergy {
		get {
			if(_cachedMax!=int.MinValue) {
				return _cachedMax;
			}
			int currentMax = int.MinValue;
			for(int i = 0;i<this.moves.size;i++) {
				if(moves[i].energy>currentMax) {
					currentMax = moves[i].energy;
				}
			}
			_cachedMax = currentMax;
			return _cachedMax;

		}
	}
			    
	public MoveLibItem getMove(int aID) {
		for(int i = 0; i < moves.size ; i++) {
			if(moves[i].id==aID) {
				return moves[i];
			}
		}
		return null;
	}
	public MoveLibItem getMove(string aName) {
		for(int i = 0; i < moves.size ; i++) {
			if(moves[i].plainName==aName) {
				return moves[i];
			}
		}
		return null;
	}
}
