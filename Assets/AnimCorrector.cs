using UnityEngine;
using System.Collections;
using UnityEditor;

[ExecuteInEditMode]
public class AnimCorrector : MonoBehaviour {
	public Animator anim; 
	public AnimationClip defaultClip;
	public GameObject childToAnimate;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		#if (UNITY_EDITOR)
		
		if(!EditorApplication.isPlaying) {
			
			if(anim!=null) {
				AnimationMode.BeginSampling();
				AnimationMode.SampleAnimationClip(childToAnimate, this.defaultClip,1f);
				AnimationMode.EndSampling();
				
				SceneView.RepaintAll();
			}
			Debug.Log ("Animator is: "+anim);
		} else {
			anim.enabled = true;
			Destroy(this);
		}
		#else
		anim.enabled = true; 
		#endif 
	}
}
