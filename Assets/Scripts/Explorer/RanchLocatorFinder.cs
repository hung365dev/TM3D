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

public class RanchLocatorFinder : MonoBehaviour
{
	public PlayerStartLocation[] locations;
	
	public Vector2 correctionValue; 
	public RanchLocatorFinder ()
	{
	}
	
	
	[ContextMenu("correctPositions")]
	void correctPositions() {
		for(int i = 0;i<locations.Length;i++) {
			locations[i].locateHere += correctionValue;
		}
	}
	public Vector2 findLocation() {
		for(int i = 0;i<locations.Length;i++) {
			
			if(i+1==locations.Length&&locations[i].active()) { 
				if(locations[i].musicToPlay.Length>0) {
				//	Jukebox.REF.playTrack(locations[i].musicToPlay,locations[i].audioVolume);
				}
				return locations[i].locateHere;
			} else if(i<locations.Length-1) {
				if(locations[i].active()&&!locations[i+1].active()) {
					if(locations[i].musicToPlay.Length>0) {
					//	if(Jukebox.REF!=null)
					//		Jukebox.REF.playTrack(locations[i].musicToPlay,locations[i].audioVolume);
					}
					return locations[i].locateHere;
				}
			}
		}
		return new Vector2();
	}
}

