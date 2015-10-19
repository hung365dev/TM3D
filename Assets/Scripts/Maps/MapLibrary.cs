using UnityEngine;
using System.Collections;
using GoogleFu;
using System.Collections.Generic;


public class MapLibrary {
	private static BetterList<Map> _mapList;
	public static BetterList<Map> allMaps {
		get {
			if(_mapList==null) {
				_mapList = new BetterList<Map>();
				List<MapNamesRow> allNames = MapNames.Instance.Rows;
				for(int i = 0;i<allNames.Count;i++) {
					int mapID = allNames[i]._id;
					string name = allNames[i]._name;
					Vector2 startPos = new Vector2(allNames[i]._defaultstartx,allNames[i]._defaultstarty);
					string mapFileName = allNames[i]._filename;
					bool entryMap = allNames[i]._isstartmap;
					_mapList.Add(new Map(mapID,name,startPos,mapFileName,entryMap,allNames[i]._reparentmap));
				}
				
				for(int i = 0;i<_mapList.size;i++) {
					_mapList[i].initDoorways();
					_mapList[i].initSpawns();
				}
			}
			return _mapList;
		}
	}
	public static Doorway getInitDoorway() {
		BetterList<Map> maps = allMaps;
		for(int i = 0;i<maps.size;i++) {
			if(_mapList[i].entryMap) {
				Doorway ret = new Doorway(_mapList[i].name,_mapList[i].defaultStart);
				return ret;
			}
		}
		return null;
	}
	public static Map getMap(int aID) {
		BetterList<Map> maps = allMaps;
		for(int i = 0;i<allMaps.size;i++) {
			if(allMaps[i].id == aID) {
				return allMaps[i];
			}
		}
		return null;
	}
	
	public static Map getMap(string aName) {
		BetterList<Map> maps = allMaps;
		for(int i = 0;i<allMaps.size;i++) {
			if((allMaps[i].name == aName)||(allMaps[i].fileName==aName)) {
				return allMaps[i];
			}
		}
		return null;
	}
	
	
}
