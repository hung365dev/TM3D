// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------
using System;
using Google2u;
using UnityEngine;
public class SpawnArea
{
	private byte _trigger;
	private BetterList<SpawnAreaMonster> _monsters = new BetterList<SpawnAreaMonster>();
	private string _battleBG;
	public static float SPAWN_MULTIPLIER = 0.2f;
	public SpawnArea (MapSpawnsRow aInitData)
	{
		_trigger = (byte) aInitData._Trigger;
		_battleBG = aInitData._SpawnMapBG;
		if(aInitData._MonsterA!="") {
			_monsters.Add (new SpawnAreaMonster(aInitData._MonsterA,(byte) aInitData._MonsterLevelA,aInitData._MonsterAFrequency,aInitData._SpawnMusic));
		}
		
		if(aInitData._MonsterB!="") {
			_monsters.Add (new SpawnAreaMonster(aInitData._MonsterB,(byte) aInitData._MonsterLevelB,aInitData._MonsterBFrequency,aInitData._SpawnMusic));
		}
		
		if(aInitData._MonsterC!="") {
			_monsters.Add (new SpawnAreaMonster(aInitData._MonsterC,(byte) aInitData._MonsterLevelC,aInitData._MonsterCFrequency,aInitData._SpawnMusic));
		}
		
		if(aInitData._MonsterD!="") {
			_monsters.Add (new SpawnAreaMonster(aInitData._MonsterD,(byte) aInitData._MonsterLevelD,aInitData._MonsterDFrequency,aInitData._SpawnMusic));
		}
		
	}
	
	public string battleBG {
		get {
			return _battleBG;
		}
	}
	
	public SpawnAreaMonster canProvideBattle() {
		
		for(byte c = 0; c < _monsters.size ; c++) {
			
			float r = UnityEngine.Random.Range(0.0f,1.0f);
			if(r<_monsters[c].percentChance*0.05*SpawnArea.SPAWN_MULTIPLIER) {
				if(_monsters[c].monster!=null)
					return _monsters[c];
			}
		}
		return null;
	}
	public byte trigger {
		get {
			return _trigger;
		}
	}
}
