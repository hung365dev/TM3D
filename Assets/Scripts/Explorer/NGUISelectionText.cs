using UnityEngine;
using PixelCrushers.DialogueSystem;

public class NGUISelectionText : MonoBehaviour {
	
	public ProximitySelector proximitySelector; // Assign this!
	public UILabel label; // Assign this!
	public UIWidget mainControl; // Assign this!
	public string defaultActionText = "to talk to";
	private ConversationTrigger _trigger;
	void OnEnable() {
		proximitySelector.SelectedUsableObject += OnSelectedUsable;
		proximitySelector.DeselectedUsableObject += OnDeselectedUsable;
	}
	
	void OnDisable() {
		proximitySelector.SelectedUsableObject -= OnSelectedUsable;
		proximitySelector.DeselectedUsableObject -= OnDeselectedUsable;
	}
	
	void OnSelectedUsable(Usable usable) {
		NGUITools.SetActive(mainControl.gameObject, true);
		if(usable!=null) {
			string actionText = usable.defaultActionText;
		//	iTween.FadeTo(mainControl.gameObject,1.0f,0.25f);
			_trigger = usable.GetComponent<ConversationTrigger>();
				#if UNITY_IPHONE || UNITY_ANDROID
				string output = "Press chat icon "+actionText+" "+usable.GetName();
				label.text = output.ToUpper();
			#else
				string output = "Press Space "+actionText +" "+ usable.GetName();
				label.text = output.ToUpper();
			#endif 
		}
		
	}
	
	public void onClickUse() {
		if(_trigger!=null) 
			_trigger.OnUse();
		
		float nearest = float.MaxValue;
		GameObject nearestNPC = null;
		AvatarMover am = this.GetComponent<AvatarMover>();
		Vector3 pos = am.transform.localPosition;
		GameObject[] npcs = GameObject.FindGameObjectsWithTag("NPC");
		for(int i = 0;i<npcs.Length;i++) {
			float diff = Vector3.Distance(npcs[i].transform.localPosition,pos);
			if(diff<nearest) {
				nearestNPC = npcs[i];
				nearest = diff;
			}
		}
		Debug.Log ("Nearest NPC was: "+nearestNPC+" - Distance away is: "+nearest);
		if(nearestNPC!=null)
			am.setMyDirection(nearestNPC.gameObject.transform.localPosition-pos);
		
		NGUITools.SetActive(mainControl.gameObject, false);
	}
	void OnDeselectedUsable(Usable usable) {
//		Debug.Log ("OnDeselectedUsable: "+usable.gameObject.name);
		if((mainControl!=null)&&(mainControl.gameObject!=null))
			NGUITools.SetActive(mainControl.gameObject, false);
	//	iTween.FadeTo(mainControl.gameObject,0.0f,0.25f);
	}
}