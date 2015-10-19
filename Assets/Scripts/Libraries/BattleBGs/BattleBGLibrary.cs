using UnityEngine;
using System.Collections;
using Google2u;
using System.Collections.Generic;


public class BattleBGLibrary {

	public static GameObject getBattleBG(string aName) {
		List<GameBackgroundsRow> all = GameBackgrounds.Instance.Rows;
		for(int i = 0;i<all.Count;i++)
		{
			Debug.Log ("Loading: "+aName);
			if(all[i]._BackgroundName.Replace(" ","").Equals(aName.Replace(" ",""))||aName==null||aName=="") {
				GameObject prefab = UnityEngine.Object.Instantiate(Resources.Load("Battles/Backgrounds/Prefabs/"+all[i]._BackgroundFile)) as GameObject;;
				prefab.GetComponent<Renderer>().sortingLayerName = "BackgroundLayer";
				prefab.transform.localPosition = new Vector3();
				return (GameObject) prefab;
			}
		}
		return null;
	}
	
	public static GameObject getBGForMonsterType(ElementalType aType) {
		List<GameBackgroundsRow> all = GameBackgrounds.Instance.Rows;
		for(int i = 0;i<all.Count;i++)
		{
			if(all[i]._DefaultBackgroundFor == aType.Name) {
				GameObject prefab = UnityEngine.Object.Instantiate(Resources.Load("Battles/Backgrounds/Prefabs/"+all[i]._BackgroundFile)) as GameObject;
				prefab.GetComponent<Renderer>().sortingLayerName = "BackgroundLayer";
				prefab.transform.localPosition = new Vector3();
				return prefab;
			}
		}
		return null;
	}
}
