using UnityEngine;
using System.Collections;
using GoogleFu;

[System.Serializable]
public class MoveTreeItem {

	private int _id;
	private MoveTreeItem _preceedingMove;
	private int _preceedingMoveID = 0;
	private byte _levelToUnlock;
	public MoveLibItem _move;
	private byte _requiresEvolutionLevel;
	private EMoveBranch _moveBranch;
	const byte MAXUNLOCKLEVELS = 3;
	public MoveTreeItem(MoveTreeDataRow aInitData) {
		_id = aInitData._id;
		_preceedingMoveID = aInitData._preceedingmoveontree;
		_levelToUnlock = (byte) aInitData._leveltounlock;
		_move = MovesLib.REF.getMove (aInitData._move);
		_requiresEvolutionLevel = (byte) aInitData._requiresevolutionlevel;
		switch(aInitData._branch) {
		case("Attacking Branch 1"):_moveBranch = EMoveBranch.AttackingBranch1;break;
		case("Attacking Branch 2"):_moveBranch = EMoveBranch.AttackingBranch2;break;
		case("Status Effect Branch"):_moveBranch = EMoveBranch.StatusEffectBranch;break;
		case("Supporting Branch"):_moveBranch = EMoveBranch.StatusEffectBranch;break;
		}

	}
	public EMoveBranch moveBranch {
		get {
			return _moveBranch;
		}
	}
	public int ID {
		get {
			return this._id;
		}
	}

	public MoveLibItem moveData {
		get {
			return _move;
		}
	}
	public MoveTreeItem PreceedingMove {
		get {
			return _preceedingMove;
		}
	}

	
	public byte LevelToUnlock {
		get {
			return _levelToUnlock;
		}
	}
	public byte RequiresEvolutionLevel {
		get {
			return _requiresEvolutionLevel;
		}
	}
	public void initPreceedingMove(BetterList<MoveTreeItem> aOtherItems) {
		_preceedingMove = null;
		if (_preceedingMoveID > 0) {
			for(int i = 0;i < aOtherItems.size ; i++) {
				if(aOtherItems[i].ID==_preceedingMoveID) {
					_preceedingMove = aOtherItems[i];
				}
			}
		}
	}
}
