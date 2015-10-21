using UnityEngine;
using System.Collections;
public class CameraShake : MonoBehaviour
{
	private Vector3 originPosition;
	private Quaternion originRotation;
	public float shake_decay;
	public float shake_intensity;
	
	void Update (){
		if (shake_intensity > 0){
			transform.position = originPosition + Random.insideUnitSphere * shake_intensity;
			transform.rotation = new Quaternion(
				originRotation.x + Random.Range (-shake_intensity,shake_intensity) * .2f,
				originRotation.y + Random.Range (-shake_intensity,shake_intensity) * .2f,
				originRotation.z + Random.Range (-shake_intensity,shake_intensity) * .2f,
				originRotation.w + Random.Range (-shake_intensity,shake_intensity) * .2f);
			shake_intensity -= shake_decay;
		}
	}
	[ContextMenu("TinyShake!")]
	public void TinyShake(){
		originPosition = transform.position;
		originRotation = transform.rotation;
		shake_intensity = .01f;
		shake_decay = 0.002f;
	}
	
	[ContextMenu("SmallShake!")]
	public void SmallShake(){
		originPosition = transform.position;
		originRotation = transform.rotation;
		shake_intensity = .03f;
		shake_decay = 0.002f;
	}
	
	[ContextMenu("LargeShake!")]
	public void LargeShake(){
		originPosition = transform.position;
		originRotation = transform.rotation;
		shake_intensity = .1f;
		shake_decay = 0.002f;
	}
	[ContextMenu("Massive Shake!")]
	public void MassiveShake(){
		originPosition = transform.position;
		originRotation = transform.rotation;
		shake_intensity = .3f;
		shake_decay = 0.002f;
	}
}