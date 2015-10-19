using UnityEngine;
using System.Collections;
using PixelCrushers.DialogueSystem;

public class HintController : MonoBehaviour {

	private TweenPosition positionTweener;
	private TweenAlpha alphaTweener;
	// Use this for initialization
	
	public Vector3 defaultPosition;
	public Vector3 position1;
	public Vector3 position2;
	public Vector3 position3;
	public float widthSize;
	public GameObject pointingAtObject;
	void Start () {
		positionTweener = this.GetComponent<TweenPosition>();
		alphaTweener = this.GetComponent<TweenAlpha>();
		alphaTweener.enabled = false;

		if(this.name=="SelectMoveLabel") {
			if(QuestLog.GetQuestState("Find_the_Elders")==QuestState.Success) {
				this.enabled = false;
			}
		}

	}
	

	public void PointAtGameObject(GameObject aObject) {
	
		pointingAtObject = aObject;
		Vector3 thisPos = aObject.transform.localPosition;
		thisPos.y = thisPos.y+5f;
		TweenPosition tp = this.GetComponent<TweenPosition>();
		tp.from = new Vector3(thisPos.x,thisPos.y);
		tp.to = new Vector3(thisPos.x,thisPos.y-100f);
	}
	
	public void PointAtGameObjects(GameObject[] aObjects) {
		if(widthSize==0) {
			for(int i = 0;i<aObjects.Length;i++) {
				if(aObjects[i].GetComponent<UIWidget>().width>0) {
					widthSize = aObjects[0].GetComponent<UIWidget>().width;
				}
			}
		}
		Vector3 pos = new Vector3();
		for(int i = 0;i<aObjects.Length;i++) {
			
			pos.x += aObjects[i].transform.localPosition.x;
			pos.y += aObjects[i].transform.localPosition.y;
			
		}
		pos.x = (pos.x / aObjects.Length)-widthSize/2;
		pos.y = (pos.y / aObjects.Length);
		
		TweenPosition tp = this.GetComponent<TweenPosition>();
		tp.from = new Vector3(pos.x,pos.y);
		tp.to = new Vector3(pos.x,pos.y-100f);
		
	}
	
	public bool enabled {
		get {
			return base.enabled;
		}
		set {
			if(this.name=="SelectMoveLabel") {
				if(QuestLog.GetQuestState("Find_the_Elders")==QuestState.Success) {
					value = false;
				}
			}
			this.gameObject.SetActive(value);
			base.enabled = value;


		}
	}
	public bool tweener {
		set {
			TweenPosition tween = this.GetComponent<TweenPosition>();
			tween.enabled = false;
		}
		get {
			TweenPosition tween = this.GetComponent<TweenPosition>();
			return tween.enabled;
		}
		
	}
	public string text {
		set {
			UILabel thisLabel = this.GetComponent<UILabel>();
			thisLabel.text = value;
		}
		get {
			UILabel thisLabel = this.GetComponent<UILabel>();
			return thisLabel.text;
		}
	}
	public void FadeIn(GameObject aPointHere) {
		if(alphaTweener!=null) {
			alphaTweener.enabled = true;
			alphaTweener.to = 1;
			alphaTweener.from = 0;
			}

		//PointAtGameObject(aPointHere);
	}
	public void FadeAway() {
		if(alphaTweener!=null) {
			alphaTweener.enabled = true;
			
			alphaTweener.to = 0;
			alphaTweener.from = 1;
			}
	}
}
