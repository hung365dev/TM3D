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
using PixelCrushers.DialogueSystem;

[System.Serializable]
public class PlayerStartLocation
{
		public string whenQuestComplete;
		public string musicToPlay;
		public float audioVolume = 1f;
		public Vector2 locateHere;
		public PlayerStartLocation ()
		{
		}
		
		public bool active() {
		if(whenQuestComplete.Length==0) {
			return true;
		}
//		Debug.Log ("<color=white>Finding Location "+whenQuestComplete+" when quest complete: "+DialogueLua.GetQuestField(whenQuestComplete.Replace(" ","_"),"State").AsString+"</color>");
			if(DialogueLua.GetQuestField(whenQuestComplete.Replace(" ","_"),"State").AsString=="success") {
				return true;
			}
			return false;
		}
}
