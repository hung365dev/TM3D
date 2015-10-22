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
using UnityEngine;
using Google2u;
using System.Collections.Generic;
public class Map
{
	/*					int mapID = allNames[i]._ID;
					string name = allNames[i]._NAME;
					Vector2 startPos = new Vector2(allNames[i]._DEFAULTSTARTX,allNames[i]._DEFAULTSTARTY);
					string mapFileName = allNames[i]._FILENAME;
					*/
	private int _mapID;
	private string _name;
	private string _reparentMap;
	private Vector2 _defaultStart;
	private string _fileName;
	private BetterList<Doorway> _doorways = new BetterList<Doorway>();
	private bool _entryMap;
	private BetterList<SpawnArea> _spawnAreas = new BetterList<SpawnArea>();
	public Map (int aID,string aName,Vector2 aDefaultStart,string aFilename,bool aIsEntryMap,string aReparentMap) {
		_mapID = aID;
		_name = aName;
		_defaultStart = aDefaultStart;
		_fileName = aFilename;
		_entryMap = aIsEntryMap;
		_reparentMap = aReparentMap;

	}
	
	public Map reparentMap {
		get {
			if(_reparentMap.Length>0) {
				return MapLibrary.getMap(_reparentMap);
			} else {
				return null;
			}
		}
	}
	public int id {
		get {
			return this._mapID;
		}
	}
	public string fileName {
		get {
			return _fileName;
		}
	}
	public void initDoorways() {
		/*List<DoorwaysRow> allDoors = Doorways.Instance.Rows;
		for(int i = 0; i<allDoors.Count;i++) {
			if(allDoors[i]._HOSTMAP==_name) {
				_doorways.Add (new Doorway(allDoors[i]._TARGETMAP,(byte) allDoors[i]._TRIGGERID,new Vector2(allDoors[i]._TARGETXPOS,allDoors[i]._TARGETYPOS)));
			}
		}*/
	}
	
	public void initSpawns() {
		List<MapSpawnsRow> allSpawns = MapSpawns.Instance.Rows;
		for(int i = 0;i<allSpawns.Count;i++) {
			if(allSpawns[i]._MapName==_name) {
				_spawnAreas.Add(new SpawnArea(allSpawns[i]));
			}
		}
	}
	
	public Vector2 defaultStart {
		get {
			return _defaultStart;
		}
	}
	
	public bool entryMap {
		get {
			return _entryMap;
		}
	}
	public Doorway getDoorwayForTrigger(byte aTriggerID) {
		for(byte i = 0;i<_doorways.size;i++) {
			if(_doorways[i].trigger==aTriggerID) {
				return _doorways[i];
			}
		}
		return null;
	}
	public SpawnArea getSpawnForTrigger(byte aTriggerID) {
		for(byte i = 0;i<_spawnAreas.size;i++) {
			if(_spawnAreas[i].trigger==aTriggerID) {
				return _spawnAreas[i];
			}
		}
		return null;
	}
	public string name {
		get {
			return _name;
		}
	}
	

	
	
	
}
