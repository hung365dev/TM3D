using UnityEngine;
using System.Collections;
using PixelCrushers.DialogueSystem;

public class NPCDisappearer : MonoBehaviour {

	public string appearAfter;
	public string disappearAfter;
	public string activateWalkerAfter;
	public string activateWalkerWhenActive;
	public string appearWhenVariable;
	public int appearWhenVariableValue;
	public string disappearWhenActive;
	public string disappearWhenVariable;
	public int disappearWhenVariableValue;
	
	public bool awaitingTagIn;
	public NPCMover mover;
	private NPCManager _npcManager;
	// Use this for initialization
	void Start () {
		this.tag = "NPC";
		SpriteRenderer[] sr = this.GetComponentsInChildren<SpriteRenderer>();
		for(int i = 0;i<sr.Length;i++) {
			sr[i].sortingLayerName = "MainPlayer";
		}
		if(GameObject.FindGameObjectWithTag("NPCManager")!=null) {
			_npcManager = GameObject.FindGameObjectWithTag("NPCManager").GetComponent<NPCManager>();
			_npcManager.onConversationEnded += onConversationEnded;
			onConversationEnded(true);
		}
		if(mover!=null) {
			if(mover.enabled==false) {
			//	mover.enabled = true;
				mover.walkInDirection(new Vector3(0f,-0.01f,0f));
			//	mover.enabled = false;
			}
		}
		
	}
	public void OnDisable() {
	//	Debug.Log ("OnDisableNPC!");
	}
	public void OnDestroy() {
		if(_npcManager!=null) 
			_npcManager.onConversationEnded -= onConversationEnded;
		_npcManager = null;
	}
	
	public void getTaggedIn() {
		Debug.Log("Tag, I'm IT: "+this.gameObject.name);
		this.awaitingTagIn = false;
		this.onConversationEnded();
		/*
		iTween.FadeTo(this.gameObject,1f,0.1f);
		if(this.GetComponent<BoxCollider2D>()!=null)
			this.GetComponent<BoxCollider2D>().enabled = true;*/
	}
	
	private void disappearObject(float aFadeTime) {
		if(this.GetComponent<BoxCollider2D>()!=null) {
			this.GetComponent<BoxCollider2D>().enabled = false;
		} else {
			this.gameObject.SetActive(false);
		}
		GameObject avatar = GameObject.FindGameObjectWithTag("Player");
		ProximitySelector ps = avatar.GetComponent<ProximitySelector>();
		ps.CheckTriggerExit(this.gameObject);
	}
	private void appearObject(float aFadeTime) {
		if(this.GetComponent<BoxCollider2D>()!=null) {
			this.GetComponent<BoxCollider2D>().enabled = true;
		} else {
			this.gameObject.SetActive(true);
		}
		GameObject avatar = GameObject.FindGameObjectWithTag("Player");
		ProximitySelector ps = avatar.GetComponent<ProximitySelector>();
		ps.CheckTriggerExit(this.gameObject);
	}
	
	private void onConversationEnded(bool aFirstTurn = false) {
	
		float fadeTime = 1f;
		if(aFirstTurn) {
			fadeTime = 0f;
		}
		if(this.appearWhenVariable.Length>0) {
			Lua.Result r = DialogueLua.GetVariable(appearWhenVariable);
			if(r.AsInt==appearWhenVariableValue) {
				appearObject(fadeTime);
			} else {
				this.disappearObject(fadeTime);
			}
		}
		
		if(appearAfter.Length>0) {
			if(!awaitingTagIn) {
				Lua.Result r = DialogueLua.GetQuestField(appearAfter,"State");
				
				if(r.AsString=="success"||r.AsString=="done") {
					appearObject(fadeTime);
					
				} else {
					if(this.GetComponent<BoxCollider2D>()!=null)
						this.GetComponent<BoxCollider2D>().enabled = false;
					GameObject avatar = GameObject.FindGameObjectWithTag("Player");
					ProximitySelector ps = avatar.GetComponent<ProximitySelector>();
					ps.CheckTriggerExit(this.gameObject);
				}
			} else {
				disappearObject(fadeTime);
			}
		}	

		if(disappearAfter.Length>0) {
			Lua.Result r = DialogueLua.GetQuestField(disappearAfter,"State");
			if(r.AsString=="success"||r.AsString=="done") {
				disappearObject(fadeTime);
			}
		}
		if(activateWalkerWhenActive.Length>0) {
			Debug.Log ("Activate walker when active: "+activateWalkerWhenActive);
			Lua.Result r = DialogueLua.GetQuestField(activateWalkerWhenActive,"State");
			
			Debug.Log ("Quest state is: "+r.AsString);
			if(r.AsString=="active") {
				Debug.Log ("Setting quest to active!");
				mover.enabled = true;
				if(this.GetComponent<BoxCollider2D>()!=null) {
					this.GetComponent<BoxCollider2D>().enabled = false;
				} else {
			//		this.gameObject.SetActive(false);
				}
				
				GameObject avatar = GameObject.FindGameObjectWithTag("Player");
				ProximitySelector ps = avatar.GetComponent<ProximitySelector>();
				ps.CheckTriggerExit(this.gameObject);
			} else {
				
				Debug.Log (r.AsString+" - DeActivating NPC Mover");
				mover.enabled = false;
			}
		}
		if(activateWalkerAfter.Length>0) {
			Lua.Result r = DialogueLua.GetQuestField(activateWalkerAfter,"State");
			if(r.AsString=="success"||r.AsString=="done") {
				mover.enabled = true;
				if(this.GetComponent<BoxCollider2D>()!=null) {
					this.GetComponent<BoxCollider2D>().enabled = false;
				} else {
					//this.gameObject.SetActive(false);
				}
				
				GameObject avatar = GameObject.FindGameObjectWithTag("Player");
				ProximitySelector ps = avatar.GetComponent<ProximitySelector>();
				ps.CheckTriggerExit(this.gameObject);
			} else {
				Debug.Log (r.AsString+" Deactivating npcmover at: "+activateWalkerAfter);
				mover.enabled = false;
			}
		}
		if(disappearWhenActive.Length>0) {
			Lua.Result r = DialogueLua.GetQuestField(disappearWhenActive,"State");
			
			Debug.Log ("Quest state is: "+r.AsString);
			if(r.AsString=="active") {
				this.disappearObject(fadeTime);
			}
		}

		if(disappearWhenVariable.Length>0) {
			Lua.Result r = DialogueLua.GetVariable(disappearWhenVariable);
			if(r.AsInt==disappearWhenVariableValue) {
				disappearObject(fadeTime);
			}
		}
		
	}
	// Update is called once per frame
	void Update () {
		
	}
}
