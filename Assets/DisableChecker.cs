using UnityEngine;
using System.Collections;

public class DisableChecker : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void OnEnable() {
		Debug.Log ("OnEnable()");
	}
	public void OnDisable() {
		Debug.Log ("Disabled!");
	}
}
