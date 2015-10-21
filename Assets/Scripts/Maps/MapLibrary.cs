using UnityEngine;
using System.Collections;
using Google2u;
using System.Collections.Generic;


public class MapLibrary {
	private static BetterList<Map> _mapList;
	public static BetterList<Map> allMaps {
		get {
			if(_mapList==null) {
				_mapList = new BetterList<Map>();
				List<MapNamesRow> allNames = MapNames.Instance.Rows;
				for(int i = 0;i<allNames.Count;i++) {
					int mapID = allNames[i]._ID;
					string name = allNames[i]._Name;
					Vector2 startPos = new Vector2(allNames[i]._DefaultStartX,allNames[i]._DefaultStartY);
					string mapFileName = allNames[i]._FileName;
					bool entryMap = allNames[i]._IsStartMap;
					_mapList.Add(new Map(mapID,name,startPos,mapFileName,entryMap,allNames[i]._ReparentMap));
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
