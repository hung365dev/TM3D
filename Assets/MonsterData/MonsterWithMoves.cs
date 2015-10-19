using System;
using UnityEngine;
using System.Collections;
using utils;
using PixelCrushers.DialogueSystem;


public class MonsterWithMoves : MonsterDataWithPassiveEffects
{
		public const byte MOVEPOINTSPERLEVEL = 1;
		public const byte MAXINUSETREES = 3;
		public const byte MAXSELECTABLEMOVES = 4;
		private BetterList<SelectedMoveData>  _selectedMoves = new BetterList<SelectedMoveData>();
		public MonsterWithMoves ()
		{
			while(_selectedMoves.size<MAXSELECTABLEMOVES) {
				_selectedMoves.Add( new SelectedMoveData() );
			}
		}
		public bool hasEnergyForAMove {
			get {
				int energyVal = (int) this.energy;
				for(int i = 0;i<this._selectedMoves.size;i++) {
					if(_selectedMoves[i]!=null&&_selectedMoves[i].moveData!=null&&_selectedMoves[i].move!=null&&_selectedMoves[i].moveData.getEnergy(_selectedMoves[i].move.currentUnlockLevel)<=energyVal) {
						return true;
					}
				}
				// Set this to false if we don't want to use struggle
				return true;
			}
		}
		public override void FromString(string aString) {
			string[] s = aString.Split(new char[] {'|'});
		
			base.FromString(s[0]);
			string decode = Base64Compressor.Base64Decode(s[1]);
			string[] data = decode.Split (new char[] {'|'});
			for(int i =0;i<data.Length;i++) {
				
				string[] moveData = data[i].Split(new char[] {','});
				if(moveData.Length==2) {
					EMoveUnlockType unlockType = (EMoveUnlockType) Convert.ToInt32(moveData[0]);
					if(moveData[1].Length>0) {
						MoveLibItem libItem = MovesLib.REF.getMove(Convert.ToInt32(moveData[1]));
						if(libItem!=null) {
							if(_moveTreeA.contains(libItem)!=null) {
								this._selectedMoves[i].setMove(unlockType,_moveTreeA.contains(libItem));
							} else if(_moveTreeB.contains(libItem)!=null) {
								this._selectedMoves[i].setMove(unlockType,_moveTreeB.contains(libItem));
							} else if(_moveTreeC!=null&&_moveTreeC.contains(libItem)!=null) {
								this._selectedMoves[i].setMove(unlockType,_moveTreeC.contains(libItem));
							} else if(_moveTreeD!=null&&_moveTreeD.contains(libItem)!=null) {
								this._selectedMoves[i].setMove(unlockType,_moveTreeD.contains(libItem));
							}
						}
					}
				} else {
					Debug.Log ("<color=orange>Error getting move tree data: "+moveData+"</color>");
				}
			}
		}
		public override string ToString ()
		{
			string s = "";
			for(int i = 0;i<_selectedMoves.size;i++) {
				s+=_selectedMoves[i].ToString();
				if(i<_selectedMoves.size-1) {
					s+="|";
				}
			}
			return base.ToString()+"|"+Base64Compressor.Base64Encode(s);
		}
	/*
		public override void initFromSFSObject(SFSObject aInitObject) {
			while(_selectedMoves.size>0) {
				_selectedMoves.Pop();
			}
			SFSArray arr = (SFSArray) aInitObject.GetSFSArray("moves");
			for(int i = 0; i < arr.Size() ; i++) {
				SelectedMoveData md = new SelectedMoveData();
				md.asSFSObject = (SFSObject) arr.GetSFSObject(i);
				_selectedMoves.Add( md );
			}
			base.initFromSFSObject(aInitObject);
		}
		*/
		public bool alreadyEquipped(MoveTreeCompletionDataRow aData) {
			for(int i= 0;i<_selectedMoves.size;i++) {
				if(_selectedMoves[i].move==aData) {
					return true;
				} 
			}
		
		return false;
		}
	
		public BetterList<MoveTreeCompletionData> moveTrees {
			get {
				BetterList<MoveTreeCompletionData> r = new BetterList<MoveTreeCompletionData>();
				if(this._moveTreeA!=null) {
					r.Add(_moveTreeA);
				}
				if(this._moveTreeB!=null) {
					r.Add(_moveTreeB);
				}
				if(this._moveTreeC!=null) {
					r.Add(_moveTreeC);
				}
				if(this._moveTreeD!=null) {
					r.Add(_moveTreeD);
				}
				return r;
			}
		}
		//TODO Reenable when multiplayer
		/*
		public override SFSObject toSFSObject(SFSObject aAddToThis) {
			if(aAddToThis==null) {
				aAddToThis = base.toSFSObject(null);
			} else {
				base.toSFSObject(aAddToThis);
			}
			SFSArray arr = new SFSArray();
			for(byte i = 0;i<_selectedMoves.size;i++) {
				SFSObject move = _selectedMoves[i].asSFSObject;
				arr.AddSFSObject(move);
			}
			aAddToThis.PutSFSArray("moves",arr);
			return aAddToThis;
		}*/
		
		public float getWeaknessStrengthToElement(ElementalType aElementType) {
			if(lingeringEffects.hasElementWeakness(aElementType)!=0.0f) {
				return lingeringEffects.hasElementWeakness(aElementType);
			} else {
				return this.elementType.getWeaknessStrengthToElement(aElementType);
			}
		}
		
		public void addVulnerability(ElementalType aElement,byte aTurns) {
			lingeringEffects.addEffect(aElement,aTurns);
		}
		public override byte level {
			set {

				base.level = value;
			}
			get {
				return base.level;
			}
		}
		protected void initRandomMoves() {
			byte c = 0;
			if(QuestLog.GetQuestState("Save_the_Town")==QuestState.Success) {
				while((this.movesAssigned==0)||(movePointsAvailable>1 && c < 255)) {
					assignMoveAtRandom();
					c++;
				}
			} else {
				if(this.movesAssigned<2) {
					int tree = 0;
					this.assignBasicMoveToTree(moveTrees[0]);
					this.assignBasicMoveToTree(moveTrees[0]);
				}
			}

		}
		protected int movesAssigned {
			get {
				int r = 0;
				if(_moveTreeA!=null) r+= _moveTreeA.pointsUsed;
				if(_moveTreeB!=null) r+= _moveTreeB.pointsUsed;
				if(_moveTreeC!=null) r+= _moveTreeC.pointsUsed;
				if(_moveTreeD!=null) r+= _moveTreeD.pointsUsed;
				return r;
				
			}
		}
		protected void setMoves(EMoveBranch aSelectionBias = EMoveBranch.NoMove,byte aAmountToSet = MAXSELECTABLEMOVES) {
			Debug.Log("Setting Moves Automatic!");
			BetterList<MoveTreeCompletionDataRow> unlockedMoves = allUnlockedMoves;
			//EMoveBranch lastMoveBranch = EMoveBranch.StatusEffectBranch;
			int c = 0;
			for(int i = 0; i<aAmountToSet&&i<_selectedMoves.size&&i<unlockedMoves.size;i++) {
				
			_selectedMoves[i].setMove(EMoveUnlockType.Automatic,unlockedMoves[i]);
			Debug.Log ("Move "+i+" is: "+_selectedMoves[i].moveData.Name);
			//lastMoveBranch = unlockedMoves[c].moveBranch;
			
				c++;
			}
		}
			 
		public void doOverrideMoves(string aMove1,string aMove2,string aMove3,string aMove4) {
			while(_selectedMoves.size>0) {
				_selectedMoves.Pop();
			}
				if(aMove1.Length>0)
				for(int j = 0;j<this.moveTrees.size;j++) {
					if(moveTrees[j]!=null) {
						if(moveTrees[j].contains(MovesLib.REF.getMove(aMove1))!=null) {
					_selectedMoves.Add(moveTrees[j].unlockTreeItemOverride(aMove1));
							}
						}
				}
				if(aMove2.Length>0)
				for(int j = 0;j<this.moveTrees.size;j++) {
					if(moveTrees[j]!=null) {
						if(moveTrees[j].contains(MovesLib.REF.getMove(aMove2))!=null) {
							_selectedMoves.Add(moveTrees[j].unlockTreeItemOverride(aMove2));
						}
					}
				}
		if(aMove3.Length>0)
		for(int j = 0;j<this.moveTrees.size;j++) {
			if(moveTrees[j]!=null) {
				if(moveTrees[j].contains(MovesLib.REF.getMove(aMove3))!=null) {
					_selectedMoves.Add(moveTrees[j].unlockTreeItemOverride(aMove3));
					}
			}
		}
		if(aMove4.Length>0)
		for(int j = 0;j<this.moveTrees.size;j++) {
			if(moveTrees[j]!=null) {
				if(moveTrees[j].contains(MovesLib.REF.getMove(aMove4))!=null) {
					_selectedMoves.Add(moveTrees[j].unlockTreeItemOverride(aMove4));
					}
				}
			}
		}
		public void selectMove(int aIndex,MoveTreeCompletionDataRow aData) {
		
			_selectedMoves[aIndex].setMove(EMoveUnlockType.Manual,aData);
		}
		protected BetterList<MoveTreeCompletionDataRow> allUnlockedMoves {
			get {
				BetterList<MoveTreeCompletionDataRow> r = new BetterList<MoveTreeCompletionDataRow>();
				if(_moveTreeA!=null) {
					_moveTreeA.addUnlockedToList(r);
				}

			if(_moveTreeB!=null) {
					_moveTreeB.addUnlockedToList(r);
				}

			if(_moveTreeC!=null) {
					_moveTreeC.addUnlockedToList(r);
				}

			
			if(_moveTreeD!=null) {
					_moveTreeD.addUnlockedToList(r);
				}
				MovePointsComparison comparer = new MovePointsComparison();
				r.Sort(MonsterWithMoves.SortByMovePoints);

				return r;
			}
	
		}
		

		private static int SortByMovePoints(MoveTreeCompletionDataRow a1, MoveTreeCompletionDataRow a2) {
			if(a1.pointsToUnlock<a2.pointsToUnlock) {
				return 1;
			}
		else
			return -1;
		}
		public int Compare(MoveTreeCompletionDataRow aMove1, MoveTreeCompletionDataRow aMove2)
		{
			if(aMove1.pointsToUnlock<aMove2.pointsToUnlock) {
				return -1;
			} else return 1;
		}

		private void addMovesToList(BetterList<MoveTreeCompletionData> aList,BetterList<MoveTreeCompletionData> aAddThis) {
			for(int i = 0 ; i < aAddThis.size ; i++) {
				aList.Add(aAddThis.Pop());
			}
		}
		public void assignMoveAtRandom() {
			int tree = (int) Math.Floor((double) UnityEngine.Random.Range(0,availableTrees.size));
			assignMoveToTree(availableTrees[tree]);
		}
		private BetterList<MoveTreeCompletionData> availableTrees {
			get {
				BetterList<MoveTreeCompletionData> r = new BetterList<MoveTreeCompletionData>();
				if(_moveTreeA!=null) {
					r.Add(_moveTreeA);
				}
				if(_moveTreeB!=null) {
					r.Add(_moveTreeB);
				}
				if(_moveTreeC!=null) {
					r.Add(_moveTreeC);
				}
				if(_moveTreeD!=null) {
					r.Add(_moveTreeD);
				}
			return r;
		}
	}
		private void assignMoveToTree(MoveTreeCompletionData aMoveTree) {
			aMoveTree.assignMoveAtRandom(this.evolutionLevel,this.level,this.monsterBreedRef.maxEvolutionLevel);
		}
		
	private void assignBasicMoveToTree(MoveTreeCompletionData aMoveTree) {
		aMoveTree.assignBasicMove(this.evolutionLevel,this.level,this.monsterBreedRef.maxEvolutionLevel);
		
	}
	
		public void unlockMove(MoveTreeCompletionDataRow aRow) {
			if(_moveTreeA!=null)
				_moveTreeA.unlockTreeItem(aRow.itemRef.ID,this.evolutionLevel,this.level,this.monsterBreedRef.maxEvolutionLevel);
			if(_moveTreeB!=null)
				_moveTreeB.unlockTreeItem(aRow.itemRef.ID,this.evolutionLevel,this.level,this.monsterBreedRef.maxEvolutionLevel);
			if(_moveTreeC!=null)
				_moveTreeC.unlockTreeItem(aRow.itemRef.ID,this.evolutionLevel,this.level,this.monsterBreedRef.maxEvolutionLevel);
			if(_moveTreeD!=null)
				_moveTreeD.unlockTreeItem(aRow.itemRef.ID,this.evolutionLevel,this.level,this.monsterBreedRef.maxEvolutionLevel);
			PlayerMain.REF.saveMonsters();
		}
		public byte movePointsAvailable {
			get {
				byte pointsUsed = _moveTreeA.pointsUsed;
				if(_moveTreeB!=null) {
					pointsUsed += _moveTreeB.pointsUsed;
				}
				if(_moveTreeC!=null) {
					pointsUsed += _moveTreeC.pointsUsed;
				}
				return (byte) (this.level * MonsterWithMoves.MOVEPOINTSPERLEVEL - pointsUsed);
			}
		}
		
		public BetterList<SelectedMoveData> selectedMoves {
			get {
				return _selectedMoves;
			}
		}

		public BetterList<MoveTreeCompletionDataRow> unlockedMoves {
			get {
				BetterList<MoveTreeCompletionDataRow> r = new BetterList<MoveTreeCompletionDataRow>();
				BetterList<MoveTreeCompletionData> availableTs = this.availableTrees;
				for(int i = 0; i < availableTs.size  ; i++) {
					availableTs[i].addUnlockedToList(r);
				}
				return r;
			}
		}
		private byte movePointsUsed {
			get {
				BetterList<MoveTreeCompletionData> availableTs = this.availableTrees;
				byte r = 0;
				for(int i = 0; i < availableTs.size ; i++) {
					r += availableTs[i].pointsUsed;
				}
			return r;


			}
		}

}

