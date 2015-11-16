using System;
using UnityEngine;
using Items;
using monsters;


namespace Battles
{
	public class BattleTeamBase : MonoBehaviour
	{
		
		public ETeamPosition _position;
		public GameObject[] _monsters = new GameObject[3];
		
		
		public delegate void OnReadyForNextTurn(BetterList<MoveQueueItem> aMoveList,BattleTeam aTeam);
		public event OnReadyForNextTurn onReadyForNextTurn;
		
		
		public delegate void OnMoveSet(BattleTeam aTeam,BattleMonster aMonster,MoveQueueItem aMove,bool aAutomatic);
		public event OnMoveSet onMoveHasBeenSet;
		
		
		public delegate void OnMonstersIdle();
		public event OnMonstersIdle onAllMonstersIdle;
		
		
		public delegate void OnTeamDead();
		public event OnTeamDead onTeamDead;
		
		public delegate void OnMonsterFainted(BattleTeam aTeam,BattleMonster aMonster);
		public event OnMonsterFainted onMonsterFainted;
		
		
		public delegate void OnTeamCommentaryMessage(string aMessage,ECommentaryMessageType aMessageType,EMonsterPos aPosition,ETeamPosition aTeamPosition);
		public event OnTeamCommentaryMessage onCommentaryMessage;
		
		private const int TOP_LAYER_OFFSET = 0;
		private const int MIDDLE_LAYER_OFFSET = 20;
		private const int BOTTOM_LAYER_OFFSET = 40;
		
		private ETeamControllerType _teamType;
		public string _name;
		
		protected ItemBait _usingBait;
		protected EMonsterCatchResult _baitResult;
		protected ITMItem[] _itemsForTurn = new ITMItem[3];
		public BattleTeamBase ()
		{
		}
		public virtual void cleanUp() {
			onReadyForNextTurn = null;
			onMoveHasBeenSet = null;
			onAllMonstersIdle = null;
			onTeamDead = null;
			onMonsterFainted = null;
			onCommentaryMessage = null;
			for(int i = 0;i<this._monsters.Length;i++) {
				if(monsters[i]!=null) {
					Destroy (monsters[i]);
				}

			}

		}
		public float monsterMaxSpeed {
			get {
				float currentMax = 0;
				BetterList<BattleMonster> ms = this.monstersAsBattleMonster;
				for(int i = 0;i<ms.size;i++) {
					
					if(ms[i].speed>currentMax) {
						currentMax = ms[i].speed;
					}
				}
				return currentMax;
			}
		}
		public bool wild {
			get {
				return this._teamType==ETeamControllerType.WildAI;
			}
		}
		protected byte indexForMonster(MonsterDataMain aMonster) {
			BetterList<BattleMonster> ms = this.monstersAsBattleMonster;
			
			for(byte i = 0;i<ms.size;i++) {
				if(ms[i].monster==aMonster) {
					return i;
				}
			}
			return 255;
		}
		protected byte indexForMonster(BattleMonster aMonster) {
			BetterList<BattleMonster> ms = this.monstersAsBattleMonster;
			
			for(byte i = 0;i<ms.size;i++) {
				if(ms[i]==aMonster) {
					return i;
				}
			}
			return 255;
		}

		public bool containsMonster(BattleMonster aMonster) {
			BetterList<BattleMonster> ms = this.monstersAsBattleMonster;
			for(byte i=0;i<ms.size;i++) {
				if(ms[i]==aMonster) {
					return true;
				}
			}
			return false;
		}
		public string name {
			get {
				return this._name;
			}
			set {
				_name = value;
			}
		}
		public double monstersXPForDefeatingTeam(MonsterDataMain aMyMonster) {
			BetterList<BattleMonster> ms = this.monstersAsBattleMonster;
			double r = 0;
			for(int i = 0;i<ms.size;i++) {
				r += xpForDefeating(aMyMonster,ms[i].monster);
			}
			return r*10;
		}
		public double xpForDefeating(MonsterDataMain aMyMonster,MonsterDataMain aDefeated) {
			// exp = (((a * b * L) / (5 * s)) * ((Math.pow(2L + 10),2)/Math.pow((L+Lp + 10),2)) + 1) * t * e * p
			// a = 1 if wild, 1.5 if trainer, 2 if tournament
			// b = monster experience yield
			// e = 1.5 if monster is holding sp item, otherwise 1
			// f = 1.2 if monster is happy, 1 otherwise
			// L = level of fainted monster
			// Lp = level of victorious monster
			// p = 1, related to Exp. Point Power
			// s = xp share, unused
			// t = 1 if monster is owned by original owner,
			float a = 1f;
			if(teamType==ETeamControllerType.MultiplayerUser) {
				a = 2f;
			} else if(teamType==ETeamControllerType.RegularAI) {
				a = 1.5f;
			}
			int b = aDefeated.monsterBreedRef.baseExperience;
			
			//TODO check if monster is holding an item
			float e = 2.0f;
			//TODO check if monster is happy
			float f = 2;
			byte l = aDefeated.level;
			byte lp = aMyMonster.level;
			//TODO check if monster is owned by original owner
			return ((a * b * l) / 5) * ((Math.Pow(2*l + 10,(double) 2)/Math.Pow((l+lp + 10),(double) 2)) + 1) * e;
			
		}
		
		
		public EMoveFlag combinedMoveFlags {
			get {
				EMoveFlag combiner = EMoveFlag.Idle;
				BetterList<BattleMonster> ms = this.monstersAsBattleMonster;
				for(byte c = 0;c<ms.size;c++) {
					combiner = combiner | ms[c].moveFlags;
				}
				return combiner;
			}
		}
		public virtual void initFromData(BattleInitTeam aTeamInit,ETeamPosition aPosition) {
			_teamType = aTeamInit.controlType;
		}
		
		public ETeamControllerType teamType {
			get {
				return _teamType;
			}
			set {
				_teamType = value;
			}
		}
		public BetterList<MoveQueueItem> futureMoveQueue {
			get {
				BetterList<MoveQueueItem> r = new BetterList<MoveQueueItem>();
				BetterList<BattleMonster> m = this.monstersAsBattleMonster;
				if(this._usingBait!=null) {
					r.Add(new MoveQueueItem(_usingBait,this._baitResult));
				}
				
				for(byte i = 0 ; i < m.size ; i++) {
					if(m[i].futureMove!=null) {
						r.Add(m[i].futureMove);
						if(r[r.size-1]==null) {
							Debug.Log("How did this happen?");
						}
						r[r.size-1].actioningTeam = this as BattleTeam;
					}
				}
				return r;
			}
		}
		public EReadyForNextTurnStatus nextTurnReady {
			get {
				if(monsterCount==0) {
					return EReadyForNextTurnStatus.NoMonsters;
				}
				
				if(allMonstersHaveMoves) {
					return EReadyForNextTurnStatus.Ready;
				} else {
					// TODO - Maybe monsters can't have their moves set.
					return EReadyForNextTurnStatus.MovesUnset;
				}
			}
		}
		
		public BattleMonster nextUnsetMonster {
			get {
				BetterList<BattleMonster> monsters = monstersAsBattleMonster;
				for(int i = 0;i<monsters.size;i++) {
					if(monsters[i].futureMove==null&&monsters[i].hp>0&&monsters[i].monster.hasEnergyForAMove&&monsters[i].monster.restingStatus==ERestingStatus.Awake) {
						return monsters[i];
					}
				}
				return null;
			}
		}
		
		public byte monsterCount {
			get {
				byte r = 0;
				BetterList<BattleMonster> monsters = monstersAsBattleMonster;
				for(byte i = 0;i<monsters.size;i++) {
					if(monsters[i]!=null) {
						if(monsters[i].monster.restingStatus==ERestingStatus.Awake) {
							r++;
						}
					}
				}
				return r;
			}
		}
		public void declareReadyForNextTurn() {
			if(allMonstersHaveMoves) {
				if(this.onReadyForNextTurn!=null) {
					this.onReadyForNextTurn(this.movesForTurn,this as BattleTeam);
				}
			}
		}
		
		public void clearMoves() {
			BetterList<BattleMonster> ms = this.monstersAsBattleMonster;
			for(int i = 0;i<ms.size;i++) {
				if(ms[i]!=null&&ms[i].monster.restingStatus==ERestingStatus.Awake) {
					ms[i].prepareForNextTurn();
				}
			}
		}
		protected virtual void onMonsterMoveSet(BattleMonster aMonster,MoveLibItem aMove,bool aAutomatic) {
			

/*

			*/
			if(this.onMoveHasBeenSet!=null) {
					
				this.onMoveHasBeenSet(this as BattleTeam,aMonster,aMonster.futureMove,aAutomatic);
			} else {
			}
		}
		public bool allMonstersHaveMoves {
			get {
				BetterList<BattleMonster> ms = this.monstersAsBattleMonster;
				for(byte i = 0;i<ms.size;i++) {
					if(ms[i]!=null) {
						if(ms[i].monster.restingStatus==ERestingStatus.Awake&&ms[i].futureMove==null&&ms[i].monster.hasEnergyForAMove) {
							Debug.Log("index: "+i+" futureMove is null!");
							return false;
						} else {
						}
					}
				}
				return true;
			}
		}
		
		public ETeamPosition teamPosition {
			get {
				return _position;
			}
		}
		
		
		protected BetterList<MoveQueueItem> movesForTurn {
			get {
				BetterList<MoveQueueItem> ret = new BetterList<MoveQueueItem>();
				BetterList<BattleMonster> monsters = monstersAsBattleMonster;

				for(byte i = 0;i < this.monsters.Length ; i++) {
					if(monsters[i]!=null&&monsters[i].futureMove!=null&&monsters[i].futureMove.moveData!=null) 
						ret.Add(monsters[i].futureMove);
				}
				return ret;
			}
		}
		
		
		public GameObject[] monsters {
			get {
				return _monsters;
			}
		}
					
		public BetterList<BattleMonster> monstersAsBattleMonster {
			get {
				BetterList<BattleMonster> ret = new BetterList<BattleMonster>();
				for(byte i = 0;i<_monsters.Length;i++) {
					if(_monsters[i]!=null) {
						BattleMonster monster = _monsters[i].GetComponent("BattleMonster") as BattleMonster;
						if(monster!=null) {
							ret.Add(monster);
						}
					}
				}
				return ret;
			}
		}
					
		protected void findSpaceForMonster(BetterList<MonsterDataMain> aMonsters) {
			// Can place monster in the middle first?
			if(_monsters[BattleConstants.FRONT_INDEX]==null&&aMonsters.size>BattleConstants.FRONT_INDEX&&aMonsters[BattleConstants.FRONT_INDEX]!=null) {
				GameObject monster =UnityEngine.Object.Instantiate( aMonsters[BattleConstants.FRONT_INDEX].prefab ) as GameObject;
				this.initBattleMonsterGameObject(monster,aMonsters[BattleConstants.FRONT_INDEX],MIDDLE_LAYER_OFFSET,EMonsterPos.Front);
				_monsters[BattleConstants.FRONT_INDEX] = monster;
			} 
			// Can place monster at bottom?
			if(_monsters[BattleConstants.BOTTOM_INDEX]==null&&aMonsters.size>BattleConstants.BOTTOM_INDEX&&aMonsters[BattleConstants.BOTTOM_INDEX]!=null) {
				GameObject monster =UnityEngine.Object.Instantiate( aMonsters[BattleConstants.BOTTOM_INDEX].prefab ) as GameObject;
				this.initBattleMonsterGameObject(monster,aMonsters[BattleConstants.BOTTOM_INDEX],BOTTOM_LAYER_OFFSET,EMonsterPos.Top);
				_monsters[BattleConstants.BOTTOM_INDEX] = monster;
			
			}
			// Can place monster at top
			if(_monsters[BattleConstants.TOP_INDEX]==null&&aMonsters.size>BattleConstants.TOP_INDEX&&aMonsters[BattleConstants.TOP_INDEX]!=null) {
				GameObject monster =UnityEngine.Object.Instantiate( aMonsters[BattleConstants.TOP_INDEX].prefab ) as GameObject;
				this.initBattleMonsterGameObject(monster,aMonsters[BattleConstants.TOP_INDEX],TOP_LAYER_OFFSET,EMonsterPos.Bottom);
				_monsters[BattleConstants.TOP_INDEX] = monster;
		
			}
			
		}

		protected bool containsMonster(BattleMonsterWithMoves aMonster) {
			BetterList<BattleMonster> ms = this.monstersAsBattleMonster;
			for(byte c = 0;c<ms.size;c++) {
					if(ms[c]==aMonster) {
						return true;
					}
				}
				return false;
		}
		
		private void initBattleMonsterGameObject(GameObject aMonster,MonsterDataMain aMonsterData,int aLayerOffset,EMonsterPos aPosition) {
			BattleMonster monster = aMonster.GetComponent("BattleMonster") as BattleMonster;
			if(monster==null) {
				aMonster.AddComponent<BattleMonster>();
				BattleConstants.positionMonster(aMonster,this._position,positionForMonster(aMonster),GameObject.Find("BattleSetup").transform.position);
				monster = aMonster.GetComponent("BattleMonster") as BattleMonster;
			}
			monster.initMonster(aMonsterData,aPosition);
			
			monster.onFaintComplete += onFaintComplete;
			monster.onFainting += onFainting;
			monster.onIdle += onMonsterIdle;
			monster.onCommentaryMessage += onMonsterCommentary;
			monster.transform.parent = this.gameObject.transform;
			if(monster.monster==null) {
				Debug.LogError("Monster is null");
			}
		}
		
		protected void onMonsterCommentary(BattleMonster aMonster,string aMessage,ECommentaryMessageType aMessageType) {
			if(onCommentaryMessage!=null) {
				EMonsterPos monsterPosition = positionForMonster(aMonster);
				if(aMessageType==ECommentaryMessageType.StandardMessage) {
					this.onCommentaryMessage(aMonster.monster.ownersName+"'s "+aMessage,aMessageType,monsterPosition,this._position);
				} else {
					this.onCommentaryMessage(aMessage,aMessageType,monsterPosition,this._position);
				}
			}
		}
		private void onMonsterIdle() {
			BetterList<BattleMonster> ms = this.monstersAsBattleMonster;
			for(byte c = 0;c<ms.size;c++) {
				if(ms[c].moveFlags!=EMoveFlag.Idle&&ms[c].monster.restingStatus==ERestingStatus.Awake) {
					return;
				}
			}
			if(onAllMonstersIdle!=null) {
				onAllMonstersIdle();
			}
			
			
		}
		private void onFainting() {
			Debug.Log("Monster Has begun Fainting");
		}
		private void onFaintComplete(BattleMonster aMonster) {
			Debug.Log("Monster Has finished Fainting");
			if(this.onMonsterFainted!=null) {
				this.onMonsterFainted(this as BattleTeam,aMonster);
			}
		}
		public bool teamIsDead {
			get {
				BetterList<BattleMonster> m = this.monstersAsBattleMonster;
				for(byte c = 0;c<m.size;c++) {
					if(m[c].monster.hp==0f) {
						m[c].monster.restingStatus = ERestingStatus.ForcedRest;
					}
					if(m[c].monster.restingStatus==ERestingStatus.Awake) {
						if(m[c].hasBeenCaught) {
							return true;
						}
						return false;
					}
				}
				return true;
				
			}
		}
		
		public BattleMonster monsterFromPosition(EMonsterPos aPosition) {
			
			BetterList<BattleMonster> ms = this.monstersAsBattleMonster;
			if(aPosition==EMonsterPos.Top&&ms[BattleConstants.TOP_INDEX]!=null) {
				return ms[BattleConstants.TOP_INDEX];
			}
			if(aPosition==EMonsterPos.Front&&ms[BattleConstants.FRONT_INDEX]!=null) {
				return ms[BattleConstants.FRONT_INDEX];
			}
			if(aPosition==EMonsterPos.Bottom&&ms[BattleConstants.BOTTOM_INDEX]!=null) {
				return ms[BattleConstants.BOTTOM_INDEX];
			}
			for(int i =0;i<ms.size;i++) {
				if(ms[i]!=null) {
					return ms[i];
				}
			}
			return null;
		}
		public EMonsterPos positionForMonster(GameObject aMonster) {
		
			if(_monsters.Length>BattleConstants.FRONT_INDEX&&_monsters[BattleConstants.FRONT_INDEX]!=null&&_monsters[BattleConstants.FRONT_INDEX].Equals(aMonster)) {
				return EMonsterPos.Front;
			}
			if(_monsters.Length>BattleConstants.BOTTOM_INDEX&&_monsters[BattleConstants.BOTTOM_INDEX]!=null&&_monsters[BattleConstants.BOTTOM_INDEX].Equals(aMonster)) {
				return EMonsterPos.Bottom;
			}
			if(_monsters.Length>BattleConstants.TOP_INDEX&&_monsters[BattleConstants.TOP_INDEX]!=null&&_monsters[BattleConstants.TOP_INDEX].Equals(aMonster)) {
				return EMonsterPos.Top;
			}
			return EMonsterPos.Unset;
		} 
		public EMonsterPos positionForMonster(BattleMonster aMonster) {
			BetterList<BattleMonster> ms = this.monstersAsBattleMonster;
			if(ms.size>BattleConstants.FRONT_INDEX&&ms[BattleConstants.FRONT_INDEX]==aMonster) {
				return EMonsterPos.Front;
			}
			if(ms.size>BattleConstants.BOTTOM_INDEX&&ms[BattleConstants.BOTTOM_INDEX]==aMonster) {
				return EMonsterPos.Bottom;
			}
			if(ms.size>BattleConstants.TOP_INDEX&&ms[BattleConstants.TOP_INDEX]==aMonster) {
				return EMonsterPos.Top;
			}
			return EMonsterPos.Unset;
		}
		public bool isLocalTeam {
			get {
				return this._teamType == ETeamControllerType.SinglePlayerUser;
			}
		}
		
	}
}

