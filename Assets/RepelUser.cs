using UnityEngine;
using System.Collections;

public class RepelUser : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision aOther) {
		Debug.Log ("Here's a collision!");
	}
	void OnCollisionStay(Collision collisionInfo) {
		foreach (ContactPoint contact in collisionInfo.contacts) {
			Debug.DrawRay(contact.point, contact.normal * 10, Color.white);
		}
	}

}
