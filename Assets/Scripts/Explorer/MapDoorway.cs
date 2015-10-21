using System;
using UnityEngine;

public class MapDoorway : MonoBehaviour
{
	public string targetDoorway;
	public Vector2 targetXY;
	public string futureNPCChat;
	public GameObject doorwayPrefab;
	public MapDoorway(string aTargetMap,Vector2 aTargetPos) {
		targetDoorway = aTargetMap;
		targetXY = aTargetPos;
	}
	public MapDoorway ()
	{
	
	}

	public void Start() {
			if(doorwayPrefab==null) {
				doorwayPrefab = UnityEngine.Object.Instantiate(Resources.Load("Maps/DoorwayDisplay") as GameObject) as GameObject;
				doorwayPrefab.transform.localPosition = this.transform.localPosition;
			}
	}
	public string dataString() {
		Vector3 myPos = this.transform.localPosition;
		Vector3 entryPosition = this.transform.FindChild ("EntryPosition").transform.localPosition;
		Vector3 combined = myPos + entryPosition;
		string s = this.name + " (from: " + targetDoorway + ") Map Entry Position = " + combined;
		return s;
	}
}

