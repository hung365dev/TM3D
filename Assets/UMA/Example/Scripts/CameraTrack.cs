//SmoothLookAt.cs
//Written by Jake Bayer
//Written and uploaded November 18, 2012
//This is a modified C# version of the SmoothLookAt JS script.  Use it the same way as the Javascript version.

using UnityEngine;
using System.Collections;

///<summary>
///Looks at a target
///</summary>
[AddComponentMenu("Camera-Control/Smooth Look At CS")]
public class CameraTrack : MonoBehaviour {
	public Transform target;		//an Object to lock on to
	public float damping = 6.0f;	//to control the rotation 
	public bool smooth = true;
	public float minDistance = 10.0f;	//How far the target is from the camera
	public string property = "";
	public Transform stickTo;
	private Transform oldStickTo;
	private Color color;
	private float alpha = 1.0f;
	private Transform _myTransform;
	
	void Awake() {
		_myTransform = transform;
	}
	
	// Use this for initialization
	void Start () {
		//		if(renderer.material.HasProperty(property)) {
		//			color = renderer.material.GetColor(property);
		//		}
		//		else {
		//			property = "";
		//		}
		//		if(rigidbody) {
		//			rigidbody.freezeRotation = true;
		//		}
		
	}
	
	// Update is called once per frame
	void Update () {
		 
	}

	public void setTarget(Transform aTarget) {
		target = aTarget;
		if(target!=null)
			immediateLook (); 
	}
	public void immediateLook() {
		//damping = 0f;
		smooth = false;
		//_myTransform.LookAt (target.transform.position);
		LateUpdate ();
		smooth = true;
	}
	public void immediateStick() {
		this._myTransform.transform.position = stickTo.transform.position;
	}
	public void LateUpdate() {
		smooth = false;
		if (stickTo) {
			if(stickTo!=oldStickTo) {
				_myTransform.LookAt(target.transform.position);

			}
			Vector3 vel = new Vector3();
			this.transform.position = Vector3.SmoothDamp(this.transform.position,stickTo.transform.position,ref vel,0.05f);
		}
		oldStickTo = stickTo;
		if(target) {
			if(smooth) {
				//Look at and dampen the rotation
				Quaternion rotation = Quaternion.LookRotation(target.position - _myTransform.position);
				_myTransform.rotation = Quaternion.Slerp(_myTransform.rotation, rotation, Time.deltaTime * damping);
			}
			else { //Just look at
				_myTransform.LookAt(target.transform.position);
			}
		}
	}
}