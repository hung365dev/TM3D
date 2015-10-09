using UnityEngine;
using System.Collections;
using UMA;

public class AvatarCreatorBase : MonoBehaviour {


	public UISlider bodyHeight;
	public UMAMaker myUMA;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		onAnyValueChange ();
	}

	public void onAnyValueChange() {
		myUMA.height = bodyHeight.value;


	}
}
