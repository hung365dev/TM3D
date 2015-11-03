using System;
using UnityEngine;
using Battles;
using utils;
using PixelCrushers.DialogueSystem;
using Items;

public class PlayerWithMonsters : PlayerBase
{
	private BetterList<MonsterDataMain> _myMonsters = new BetterList<MonsterDataMain>();
	private BetterList<ESeenMonsterStatuss> _seenPets = new BetterList<ESeenMonsterStatuss>();
	public bool allowMonsterSave = true;
	public bool hasBeenSetToClockListen = false;
	
	public float xpBoostAmount;
	public int xpBoostSecondsRemaining;
	public string xpBoostName;
	
	public int repelStrength;
	public int repelSecondsRemaining;
	public string repelName;
	
	public const int MAX_BATTLE_MONSTERS = 3;
	public const int MAX_MONSTER_COUNT = 256;
		public void PlayerDataWithMonsters()
		{
			if(GameTimer.REF==null) {
				new GameTimer();
			}
			if(_seenPets.size<MonsterLibrary.REF.allMonsters.size) {
				for(int i = 0 ; i < MonsterLibrary.REF.allMonsters.size ; i++) {
					_seenPets.Add(ESeenMonsterStatuss.Unseen);
				}
			}
			while(_myMonsters.size<MAX_MONSTER_COUNT) {
				_myMonsters.Add(null);
			}
		}
			
		public int monstersOfBreed(MonsterLibraryRecord aRecord) {
			int c = 0;
			for(int i = 0;i<this._myMonsters.size;i++) {
				if(_myMonsters[i]!=null) {
					if(_myMonsters[i].monsterBreedRef==aRecord) {
						c++;
					}
				}
			}
			return c;
		}
		public bool canUseRanchHeal() {
			for(int i = 0;i<this._myMonsters.size;i++) {
				if(_myMonsters[i]!=null) {
					if(_myMonsters[i].hp<this._myMonsters[i].MaxHP||_myMonsters[i].energy<this._myMonsters[i].MaxEnergy) {
						return true;
					}
				}
			}
			return false;
		}
		public void battleRestToForcedRest() {
			for(int i = 0;i<this._myMonsters.size;i++) {
				if(_myMonsters[i]!=null) {
					if(_myMonsters[i].restingStatus==ERestingStatus.WaitingToRest) {
						_myMonsters[i].restingStatus = ERestingStatus.ForcedRest;
					}
				}
			}
		}
		public void moveMonsterToFront(MonsterDataMain aMonster) {
			_myMonsters.Remove(aMonster);
			_myMonsters.Insert(0,aMonster);
		}
		public void healAll() {
			for(int i = 0;i<this._myMonsters.size;i++) {
				if(_myMonsters[i]!=null)
					_myMonsters[i].fullHeal();
			}
		}
	public void removeMonsterByMonsterMonster(MonsterDataMain aMonster) {
		for(int i = 0;i<this._myMonsters.size;i++) {
			if(_myMonsters[i]!=null) {
				if(_myMonsters[i]==aMonster) {
					_myMonsters[i] = null;
				}
			}
		}
		this.saveMonsters();
	}
		public void removeMonsterByMonsterID(int aMonsterID) {
			for(int i = 0;i<this._myMonsters.size;i++) {
				if(_myMonsters[i]!=null) {
					if(_myMonsters[i].monsterBreedRef.ID==aMonsterID) {
						_myMonsters[i] = null;
					}
				}
			}
			this.saveMonsters();
		}
		public void reorganizeMonsters() {
			
		}
		private void HandleOnTimerTick ()
		{
			
		}
		public void swapMonsters(int aIndex1,int aIndex2) {
			MonsterDataMain m = this._myMonsters[aIndex1];
			this._myMonsters[aIndex1] = _myMonsters[aIndex2];
			this._myMonsters[aIndex2] = m;
			this.saveMonsters();
		}
		public virtual void initForDebug() {
		//	addMonster( 1 , 5 );
		//	addMonster( 15 , 10 );
		//	addMonster( 35 , 15 );
		//string l = "VkZWb05FOUZOVFpYYW1oT1UwaGpkMVJWVW5KTk1scEZXVE53YlZKRlNUUlVWV2d6WkRKYVJWa3pjRzFTUjJRMFdtdFNSbVF3TVVsa2VrcFBVMGhrTTFwclVrTlBSVEZKWkROa2JWSkZTVFJVVldnelpESmFSVkZxYUU1VFNHUXpXbXRTUTA5Rk1VbGtNMlJ0VWtWSk5GUlZhRE5rTWxwRlVXcG9UbE5JWkRSYWExSkRUMFV4ZFdWRk5VNU5NbEY2VjIxMFUxRXdPVVpOVld4clRUSlNkRlZyVmtwT1JsSldZVVJPYTAxc2NFWlZiWEJ2Vkd4T1NWcEVUbUZoTVVwRVZEQlZlRk5YVVhwYVJ6RlRVbFZyTUZaR1ZtOU5NREZZVjJ0V1ZXRnRhRTlXTUdoclRsWndjbFZyVGxCU1ZFWktXa1JPYTJKV1NrWlRWRkpWVmxkbmVscElZemxRV0hoT1ZrVkdNM3hOVTNkNFprUkZjMDVZZDNoTVJFa3hUVE4zZUV4RVJUUT18VkZWb05FOUZOVVZSYW1oT1UwaGtObFJyVWxOUFJUVlZZa1JvVGxOSVpETmFhMUpEVDBVMWNWWnFhRTlsYkVrMFZGWlNRbVF5V2tWV1dHaHRVa1ZKTkZSVmFETmtNbHBGVVdwb1RsTklaRE5hYTFKRFQwVXhTV1F6WkcxU1JVazBWRlZvTTJReVdrVlJhbWhPVTBoa00xcHJVa05QUlRGSlpETmtiVkpGV1RSVVZXZ3paVmRhUmsxWVZtdE5NbEowVld0V1NrNUdVbFpoUkU1clRXeHdSbFZYY0c5VWJFNUpXa1JPWVdFeFNreFVNRlY0WkZkUmVscEhNVk5TVldzd1ZrWldiMDB5VVhsWGExWlNZVzFvVDFVd2FHdE5NWEJ5Vld0T1VGSlVSa3BhUkU1cllsWktSbE5VVWxWV1YyZDZXa1JLWVZKV1JuRmhSVFZVVTBkUmVtWkZNVlZSV0dNOWZFMVRkM2htUkVWelRsaDNlRXhFVWpoTlEzYzl8VkZWb05FOUZNVlZTVkVwdFVrVkpORlJyVWtKT1ZUUjZaSHBPVUZkSVpETmFhMUpEVDBVeFNXUjZTazlYU0dONlZGWm9NMlZGTVVWUmFtaFBaVzEzTkZSVmFETmtNbHBGVVdwb1RsTklaRE5hYTFKRFQwVXhTV1F6WkcxU1JVazBWRlZvTTJReVdrVlJhbWhPVTBoa00xcHJVa05QUlRGSlpETmtiVkpGU1RSVVZtZ3paREphUlZOcWFGVldSVFI2V2xaa1lWSldSbkZoUlRWVVUwZFJlbGR0ZEZOUk1EbEdUVlZzYTAweVVuUlZhMVoyVGtaU1ZWUnFUbXhTTVhCR1ZUSndiMVJzWkVsYVJFNWhZVEZLUkZRd1ZYaFRWMUY2WVVjeFUxSlZhekJXUmxadlRUSlJlVmRyVmxKaGJXaFBWVEJvYTAweGNISlZhMDVRVWxSR1NscEVUbXBRV0hoT1ZrVkdNM3hOVTNkNFprUkZjMDVZZDNoTVJFa3hUVE4zZUV4RVVUMD0=";
		//	   l = "VkZWb05FOUZOVFpYYW1oT1UwaGpkMVJWVW5KTk1scEZXVE53YlZKRlNUUlVWV2d6WkRKYVJWa3pjRzFTUjJRMFdtdFNSbVF3TVVsa2VrcFBVMGhrTTFwclVrTlBSVEZKWkROa2JWSkZTVFJVVldnelpESmFSVkZxYUU1VFNHUXpXbXRTUTA5Rk1VbGtNMlJ0VWtWSk5GUlZhRE5rTWxwRlVXcG9UbE5JWkRSYWExSkRUMFV4ZFdWRk5VNU5NbEY2VjIxMFUxRXdPVVpOVld4clRUSlNkRlZyVmtwT1JsSldZVVJPYTAxc2NFWlZiWEJ2Vkd4T1NWcEVUbUZoTVVwRVZEQlZlRk5YVVhwYVJ6RlRVbFZyTUZaR1ZtOU5NREZZVjJ0V1ZXRnRhRTlXTUdoclRsWndjbFZyVGxCU1ZFWktXa1JPYTJKV1NrWlRWRkpWVmxkbmVscElZemxRV0hoT1ZrVkdNM3hOVTNkNFprUkZjMDVZZDNoTVJFa3hUVE4zZUV4RVJUUT18VkZWb05FOUZOVVZSYW1oT1UwaGtObFJyVWxOUFJUVlZZa1JvVGxOSVpETmFhMUpEVDBVMWNWWnFhRTlsYkVrMFZGWlNRbVF5V2tWV1dHaHRVa1ZKTkZSVmFETmtNbHBGVVdwb1RsTklaRE5hYTFKRFQwVXhTV1F6WkcxU1JVazBWRlZvTTJReVdrVlJhbWhPVTBoa00xcHJVa05QUlRGSlpETmtiVkpGV1RSVVZXZ3paVmRhUmsxWVZtdE5NbEowVld0V1NrNUdVbFpoUkU1clRXeHdSbFZYY0c5VWJFNUpXa1JPWVdFeFNreFVNRlY0WkZkUmVscEhNVk5TVldzd1ZrWldiMDB5VVhsWGExWlNZVzFvVDFVd2FHdE5NWEJ5Vld0T1VGSlVSa3BhUkU1cllsWktSbE5VVWxWV1YyZDZXa1JLWVZKV1JuRmhSVFZVVTBkUmVtWkZNVlZSV0dNOWZFMVRkM2htUkVWelRsaDNlRXhFVWpoTlEzYzl8VkZWb05FOUZNVlZTVkVwdFVrVkpORlJyVWtKT1ZUUjZaSHBPVUZkSVpETmFhMUpEVDBVeFNXUjZTazlYU0dONlZGWm9NMlZGTVVWUmFtaFBaVzEzTkZSVmFETmtNbHBGVVdwb1RsTklaRE5hYTFKRFQwVXhTV1F6WkcxU1JVazBWRlZvTTJReVdrVlJhbWhPVTBoa00xcHJVa05QUlRGSlpETmtiVkpGU1RSVVZtZ3paREphUlZOcWFGVldSVFI2V2xaa1lWSldSbkZoUlRWVVUwZFJlbGR0ZEZOUk1EbEdUVlZzYTAweVVuUlZhMVoyVGtaU1ZWUnFUbXhTTVhCR1ZUSndiMVJzWkVsYVJFNWhZVEZLUkZRd1ZYaFRWMUY2WVVjeFUxSlZhekJXUmxadlRUSlJlVmRyVmxKaGJXaFBWVEJvYTAweGNISlZhMDVRVWxSR1NscEVUbXBRV0hoT1ZrVkdNM3hOVTNkNFprUkZjMDVZZDNoTVJFa3hUVE4zZUV4RVVUMD0=";
		/*
		allowMonsterSave = false;
		loadMonsters(l);
		allowMonsterSave = true;
		this.saveMonsters();
		return;*/
		allowMonsterSave = false;
			for(int i = 0;i<128;i++) {
				int r = (int) UnityEngine.Random.Range(1,200);
				if(MonsterLibrary.REF.getMonster(r)!=null) {
					addMonster (r,(byte) UnityEngine.Random.Range(1,50));
					}
			}
		allowMonsterSave = true;
			this.saveMonsters ();
		}

	public int caughtMonsters
		{
			get {
				int c = 0;
				for(int i = 0 ; i < _seenPets.size ; i++) {
					if((_seenPets[i]&ESeenMonsterStatuss.Owned)==ESeenMonsterStatuss.Owned) {
						c++;
					}
				}
			
				return c;
			}
		}
	public int seenMonsters
	{
		get {
			int c = 0;
			for(int i = 0 ; i < _seenPets.size ; i++) {
				if((_seenPets[i]&ESeenMonsterStatuss.Seen)==ESeenMonsterStatuss.Seen) {
					c++;
				}
			}
			return c;
		}
	}
	
	public MonsterDataMain highMonster {
				get {
						byte highLevel = byte.MinValue;
						MonsterDataMain highMonster = null;
						for (int i = 0; i < this._myMonsters.size; i++) {
							if(_myMonsters[i]!=null)
							if (_myMonsters [i].level > highLevel) {
										highMonster = _myMonsters [i];
										highLevel = _myMonsters [i].level;
								}
						}
					return highMonster;
				}
		}
		
		public BetterList<MonsterDataMain> getMonstersOfType(ElementalType aElementalType)
		{
			BetterList<MonsterDataMain> ret = new BetterList<MonsterDataMain> ();
		
			for(int i = 0;i < _myMonsters.size ; i++)
			{
				MonsterLibraryRecord monsterLib = _myMonsters[i].monsterBreedRef;

				if(monsterLib.PrimaryElement.ID == aElementalType.ID) {
					ret.Add(_myMonsters[i]);
				}
			}
			return ret;
		}
		public bool hasMonstersOfType(ElementalType aElementalType)
		{
			return getMonstersOfType (aElementalType).size > 0;
		}

		
		public BetterList<MonsterDataMain> monsters {
			get {
				return this._myMonsters;
			}
		}
		public bool hasOwnedMonster(MonsterLibraryRecord aMonster)
		{
			return _seenPets[aMonster.ID]==ESeenMonsterStatuss.Owned;
		}
		
		public BetterList<MonsterDataMain> OwnsMonster(MonsterLibraryRecord aMonster)
		{

			BetterList<MonsterDataMain> ret = new BetterList<MonsterDataMain> ();
			for(int i = 0 ; i < this._myMonsters.size ; i++) 
			{
				if(_myMonsters[i]!=null&&_myMonsters[i].monsterBreedRef==aMonster) {
					ret.Add(_myMonsters[i]);
				}
			}
			return ret;
		}
		
		
		public void addMonsterToSeen(int aMonsterID) {
			if (this._seenPets[aMonsterID] == ESeenMonsterStatuss.Unseen) {
				this._seenPets[aMonsterID] =  ESeenMonsterStatuss.Seen;
			}
		}
		public void addMonsterToCaught(int aMonsterID) {
			if((_seenPets[aMonsterID]&ESeenMonsterStatuss.Owned)!=ESeenMonsterStatuss.Owned) {
				this._seenPets[aMonsterID] = ESeenMonsterStatuss.Owned;
			}
		}
		public int seenMonsterCount() {
			int c = 0;
			for (int i = 0; i < this._seenPets.size; i++) {
				if((_seenPets[i]&ESeenMonsterStatuss.Seen)==ESeenMonsterStatuss.Seen) {
					c++;
				}
			}
		return c;
		}

		public int monsterCount
		{ 
			get {
				int c = 0;
				for(int i = 0;i<this._myMonsters.size;i++) {
					if(_myMonsters[i]!=null) {
						c++;
					}
				}
				return c;
			}
		}
		
		public void addWildCreature(MonsterDataMain aMonsterData)	{
			aMonsterData.ownershipStatus = EOwnershipStatus.LocalPlayerOwned;
			addMonster(aMonsterData,true);
			this.saveMonsters();
		}
		
		public bool canBattle() { 
			return true;
		}
		public int getCreaturesCountForBattle(bool aAliveOnly) {
			int c = 0;
			BetterList<MonsterDataMain> m = this.battleMonsters;
			for (int i = 0; i < m.size&&i<3; i++) {
				if(m[i]!=null&&m[i].hp>0&&m[i].energy>0&&m[i].restingStatus==ERestingStatus.Awake) {
					c++;
				}
			}
			return c;
		}
		
		public MonsterDataMain maxLevelBattleMonster {
			get {
				BetterList<MonsterDataMain> ms = this.battleMonsters;
				if(ms.size>0) {
					MonsterDataMain highMonster = ms[0];
					byte highMonsterLev = 0;
					for(byte i = 1;i<ms.size;i++) {
						if(ms[i]!=null&&ms[i].level>highMonsterLev) {
							highMonsterLev = ms[i].level;
							highMonster = ms[i];
						}
					}
					return highMonster;
				}
				return null;
			}
		}
		
		public BetterList<MonsterDataMain> monstersForBox(int aBox) {
			BetterList<MonsterDataMain> ret = new BetterList<MonsterDataMain>();
			const int monstersPerPage = RanchviewController.MONSTERS_PER_PAGE;
			int startPlace = monstersPerPage*aBox+MAX_BATTLE_MONSTERS;
			for(int i = startPlace;i<startPlace+monstersPerPage;i++) {
				ret.Add(this._myMonsters[i]);
			}
			return ret;
		}
		
	public bool monsterIsBattleMonster(MonsterDataMain aMonster) {
		for(int i = 0;i<_myMonsters.size&&i<3;i++) {
			if(_myMonsters[i]==aMonster) {
				return true;
			}
		}
		return false;
	}
	public BetterList<MonsterDataMain> battlePositions
	{
		get {
			BetterList<MonsterDataMain> ret = new BetterList<MonsterDataMain>();
			
			ret.Add(_myMonsters[0]);
			ret.Add(_myMonsters[1]);
			ret.Add(_myMonsters[2]);
			
			return ret;
		}
	}
		public BetterList<MonsterDataMain> battleMonsters
		{
			get {
				BetterList<MonsterDataMain> ret = new BetterList<MonsterDataMain>();
				
				ret.Add(_myMonsters[0]);
				ret.Add(_myMonsters[1]);
				ret.Add(_myMonsters[2]);
				
				for(int i =0;i<ret.size;i++) {
					if(ret[i]!=null&&ret[i].restingStatus!=ERestingStatus.Awake) {
						ret[i] = null;
					}
				}
			/*	bool anyFound = false;
				for(int i = 0 ; i < MAX_BATTLE_MONSTERS ; i++ ) {
					if(_myMonsters[i]!=null) {
						if((i==0)&&(ret[0]==null)) {
							ret[0] = _myMonsters[i];
							anyFound = true;
						}
						if((i==1)&&(ret[1]==null)) {
							ret[1] = _myMonsters[i];
							anyFound = true;
						}
						if((_myMonsters[i].battlePosition==Battles.EMonsterPos.Bottom)&&(ret[2]==null)) {
							ret[2] = _myMonsters[i];
							anyFound = true;
						}
					}
				}
				if(anyFound == false) {
					if(this.monsterCount>0) {
						for(int i = 0;i<this._myMonsters.size&&i<3;i++) {
							if(_myMonsters[i]!=null) {
								switch(i) {
									case(0):_myMonsters[i].battlePosition = EMonsterPos.Middle;break;
									case(1):_myMonsters[i].battlePosition = EMonsterPos.Top;break;
									case(2):_myMonsters[i].battlePosition = EMonsterPos.Bottom;break;
								}
							}
						}
						return this.battleMonsters;
					}
				}*/
				return ret;
			}
		}

		private bool addToNextNull(MonsterDataMain aMonster) {
			for(int i =0;i<this._myMonsters.size;i++) {
				if(_myMonsters[i]==null) {
					_myMonsters[i] = aMonster;
					return true;
				}
			}
			return false;
		}
	
		/// <summary>
		/// adds a monster by pre-existing MonsterDataMain data, not sure if it needs wild creature value here or not anymore
		/// </summary>
		public void addMonster(MonsterDataMain aMonster,bool aIsWildCreature)
		{
			aMonster.ownershipStatus = EOwnershipStatus.LocalPlayerOwned; 
			aMonster.Changed += onMonsterChanged;
			aMonster.ownersName = "";
			this.addMonsterToCaught(aMonster.monsterBreedRef.ID);
			addToNextNull(aMonster);
			aMonster.ListenToClock();
			int c = 0;
			string varName = "CaughtArcane";
			switch(aMonster.elementType.Name) {
				case("Air"):varName = "CaughtAir";break;
				case("Earth"):varName = "CaughtEarth";break;
				case("Electric"):varName = "CaughtElectric";break;
				case("Fire"):varName = "CaughtFire";break;
				case("Ice"):varName = "CaughtIce";break;
				case("Water"):varName = "CaughtWater";break;
			}
			c = monstersOfType(aMonster.elementType);
			DialogueLua.SetVariable(varName,c);
			this.saveMonsters();
			SaveGameUtils.REF.SaveStatsAndQuests();
		}
		
		public int monstersOfType(ElementalType aType) {
			int c = 0;
			for(int i = 0;i<this._myMonsters.size;i++) {
				if(_myMonsters[i]!=null) {
					if(_myMonsters[i].elementType==aType)
						c++;
				}
			}
			return c;
		}
		public void addMonsterAtPosition(MonsterDataMain aMonster,int aIndex,bool aIsWild) {
			aMonster.ownershipStatus = EOwnershipStatus.LocalPlayerOwned; 
			aMonster.Changed += onMonsterChanged;
			
			this.addMonsterToCaught(aMonster.monsterBreedRef.ID);
			this._myMonsters[aIndex] = aMonster;
			
			this.saveMonsters();
		}
		/// <summary>
		/// adds a monster by library ID and a level
		/// </summary>
		public void addMonster(int aMonsterLibID,byte aLevel)
		{
			MonsterDataMain monster = new MonsterDataMain();
			monster.initMonster(aMonsterLibID,aLevel,false);
			monster.ownershipStatus = EOwnershipStatus.LocalPlayerOwned;
			this.addMonster( monster, false );
		}
		
		
	public ESeenMonsterStatuss seenMonster(int aID) {
		int index = 0;
		for(int i = 0 ; i < MonsterLibrary.REF.allMonsters.size;i++) {
			if(MonsterLibrary.REF.allMonsters[i].ID==aID) {
				index = i;
				break;
			}
		}
		return _seenPets[index];
	}
	protected void setLuaMonsterCount() {
		if(monsterCount==0) {
		//	Debug.LogError("Setting Lua Monster Count and monsters count is zero!");
		}
		DialogueLua.SetVariable("MonsterCount",this.monsterCount);
	}
	public void saveMonsters() {
		if(!allowMonsterSave) {
			return;
		}
		string s = "";
		for(int i =0;i<this._myMonsters.size;i++) {
			if(_myMonsters[i]!=null)
				s+=Base64Compressor.Base64Encode(_myMonsters[i].ToString());
			if(i<_myMonsters.size-1) {
				s+= "|";
			}
		}
		s+="%";
		string seenPetString = "";
		for(int i = 0;i<this._seenPets.size;i++) {
			switch(this._seenPets[i]) {
				case(ESeenMonsterStatuss.Owned):seenPetString+='O';break;
				case(ESeenMonsterStatuss.Seen):seenPetString+='S';break;
				case(ESeenMonsterStatuss.Unseen):seenPetString+='U';break;
			}
		}
		s+= seenPetString;
		setLuaMonsterCount();
		SaveGameUtils.REF.saveMonsters(Base64Compressor.Base64Encode(s),this.monsterCount,xpBoostData,repelBoostData);
	}
	
	/*
	
	public float ;
	public int xpBoostSecondsRemaining;
	public string xpBoostName;
	
	public int repelStrength;
	public int repelSecondsRemaining;
	public string repelName;
	
	*/
	
	
	public void loadRepelData(string aRepelData) {
		string[] repelSplit = aRepelData.Split(new char[] {','});
		if(repelSplit.Length==3) {
			repelStrength = Convert.ToInt32(repelSplit[0]);
			repelSecondsRemaining = Convert.ToInt32(repelSplit[1]);
			repelName = repelSplit[2];
		}
	}
	
	public virtual bool consumeItem(ITMItem aItem) {
		switch(aItem.Type()) {
			case(EItemType.PlayerBoost):
				PlayerBoostItem boostItem = (PlayerBoostItem) aItem;
				if(boostItem.boostType==EPlayerBoostType.XPBoost) {
					this.loadXPBoostData(boostItem.itemStrength+","+boostItem.time+","+boostItem.Name());
				} else if(boostItem.boostType==EPlayerBoostType.Repel) {
					this.loadRepelData(boostItem.itemStrength+","+boostItem.time+","+boostItem.Name());
				}
				this.saveMonsters();
				
				return true;
			break;
			default:return false;
		}
	}
	public void loadXPBoostData(string aXPData) {
		string[] xpSplit = aXPData.Split(new char[] {','});
		if(xpSplit.Length==3) {
			if(xpBoostAmount==Convert.ToDouble(xpSplit[0])&&xpBoostAmount>0f) {
				xpBoostAmount = (float) Convert.ToDouble(xpSplit[0]);
				if(xpBoostSecondsRemaining>0)
					xpBoostSecondsRemaining = xpBoostSecondsRemaining+Convert.ToInt32(xpSplit[1]); else 
						xpBoostSecondsRemaining = Convert.ToInt32(xpSplit[1]);
			} else {
				xpBoostAmount = (float) Convert.ToDouble(xpSplit[0]);
				xpBoostSecondsRemaining = Convert.ToInt32(xpSplit[1]);
			}
			xpBoostName = xpSplit[2];
		}
	}
	public string xpBoostData {
		get {
			return Convert.ToString(xpBoostAmount)+","+Convert.ToString(xpBoostSecondsRemaining)+","+xpBoostName;
		}
	}
	public string repelBoostData {
		get {
			return Convert.ToString(repelStrength)+","+Convert.ToString(repelSecondsRemaining)+","+repelName;
		}
	}
	public void loadMonsters(string aMonsters) {
		string s = Base64Compressor.Base64Decode(aMonsters);
		string[] split = s.Split(new char[] { '|' });
		for(int i = 0;i<split.Length;i++) {
			if(split[i].Length==0) {
				
			} else {
				MonsterDataMain m = new MonsterDataMain();
				m.FromString(Base64Compressor.Base64Decode(split[i]));
				this.addMonsterAtPosition(m,i,false);
			}
		}
		
		setLuaMonsterCount();
	}
	public string[] monsterDecompressString(string aMonsters) {
		string s = Base64Compressor.Base64Decode(aMonsters);
		string[] monstersAndSeen = s.Split(new char[] {'%'});
		if(monstersAndSeen.Length>1) {
			for(int i = 0;i<monstersAndSeen[1].Length;i++) {
				switch(monstersAndSeen[1][i]) {
					case('O'):this.addMonsterToCaught(i);break;
					case('S'):this.addMonsterToSeen(i);break;
					case('U'):break;
				}
			}
		}
		return monstersAndSeen[0].Split(new char[] { '|' });
	}
	public void loadMonsterASync(string aMonster,int aIndex) {
		this.allowMonsterSave = false;
		if(aMonster.Length>0) {
			MonsterDataMain m = new MonsterDataMain();
			m.FromString(Base64Compressor.Base64Decode(aMonster));
			if(m.monsterBreedRef.Name!="No Creature") {
				this.addMonsterAtPosition(m,aIndex,false);
			} else {
				Debug.Log ("Monster was no creature!");
			}
		}
		this.allowMonsterSave = true;
	}
	public void makeAllListenToClock() {
		for(int i = 0;i<this._myMonsters.size;i++) {
			if(_myMonsters[i]!=null) {
				_myMonsters[i].ListenToClock();
			}
		}
		GameTimer.MONSTERS_LISTENING = true;
	}
		private void onMonsterChanged(MonsterDataMain aMonster)
		{
			Debug.Log("onMonsterChanged");
			saveMonsters();
		} 
		public void saveAll()
		{
		
		
			this.saveMonsters(); 
			base.saveAll();
		}

}
