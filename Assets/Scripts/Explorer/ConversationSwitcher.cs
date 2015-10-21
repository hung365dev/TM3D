using UnityEngine;
using System.Collections;
using PixelCrushers.DialogueSystem;

public class ConversationSwitcher : MonoBehaviour {
	
	public string variableName;
	public bool isAnd;
	public bool isOr;
	public string justCheckThisBattle;
	public int value;
	public string newConversation;
	public bool removeBattleStart = true;
	private NPCManager _npcManager;
	// Use this for initialization
	void Start () {
		if(GameObject.FindGameObjectWithTag("NPCManager")!=null) {
			_npcManager = GameObject.FindGameObjectWithTag("NPCManager").GetComponent<NPCManager>();
			_npcManager.onConversationEnded += onConversationEnded;
			onConversationEnded(true);

		}
		this.gameObject.tag = "NPC";
	}
	void OnDestroy() {
		if(_npcManager!=null)
			_npcManager.onConversationEnded -= onConversationEnded;
	}
	// Update is called once per frame
	private void doRemoveBattle() {
		SendMessageOnDialogueEvent msg = this.GetComponent<SendMessageOnDialogueEvent>();
		for(int i = 0;i<msg.onEnd.Length;i++) {
			if(msg.onEnd[i].methodName=="battleStart") {
				msg.onEnd[i].methodName = "";
				msg.onEnd[i].parameter = "";
			}
		}
	}
	public void onConversationEnded(bool aFirstTurn) {
		if(variableName.Length==0||newConversation.Length==0) {
			this.enabled = false;
		}
		Lua.Result r = DialogueLua.GetVariable(variableName);
		if(isAnd) {
			if((r.AsInt&value)==value) {
				this.GetComponent<ConversationTrigger>().conversation = newConversation;
				if(removeBattleStart) {
					doRemoveBattle();
				}
				this.enabled = false;

			}
		} else
		if(isOr) {
			if((r.AsInt|value)==value) {
				this.GetComponent<ConversationTrigger>().conversation = newConversation;
				if(removeBattleStart) {
					
					doRemoveBattle();
				}
				this.enabled = false;
			}
		}
	}
	void Update () {

	}
}
