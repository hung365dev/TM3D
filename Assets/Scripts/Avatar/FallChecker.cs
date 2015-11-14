using UnityEngine;
using System.Collections;

public class FallChecker : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnCollisionEnter(Collision aCollision) {
		Debug.Log ("OnCollisionEnter!");
	}
	public void OnTriggerEnter(Collider aCollision) {
		Debug.Log ("OnCollisionEnter!");
	}

	void OnCollisionStay(Collision collisionInfo) {
		Debug.Log ("OnCollisionStay");
	}
	// Applies an upwards force to all rigidbodies that enter the trigger.
	void OnTriggerStay(Collider other) {
		Debug.Log ("OnTriggerStay");     
	}

}
