using UnityEngine;
using System.Collections;
using PixelCrushers.DialogueSystem;
using Battles;

using PixelCrushers.DialogueSystem.NGUI;
using utils;
using System;


public class NPCManager : MonoBehaviour {

	private WorldExplorer _explorer;
	private GameObject _avatar;
	private GameObject _npcs;
	public delegate void OnConversationEnded(bool aFirstFrame);
	public event OnConversationEnded onConversationEnded; 
	private bool _checkVars;
	private Vector2 _dumpOutPosition;
	public static NPCManager REF;
	public bool changingScene = false;
	public static bool CONVO_OPEN = false;
	private BetterList<BoxCollider2D> _collidersToRenable = new BetterList<BoxCollider2D>();
	// Use this for initialization
	void Start () {
		REF = this;
		CONVO_OPEN = false;
	}
	public void initNpcsForMap(WorldExplorer aExplorer,GameObject aAvatar) {
		_explorer = aExplorer;
		_avatar = aAvatar;
		DialogueManager.AllowLuaExceptions = true;
		SendMessageOnDialogueEvent[] allSendMessages = FindObjectsOfType<SendMessageOnDialogueEvent>(); 
		
		for(int i = 0;i<allSendMessages.Length;i++) {
			SendMessageOnDialogueEvent.SendMessageAction[] onConversationEnds = allSendMessages[i].onEnd;
			for(int j = 0;j<onConversationEnds.Length;j++) {
				SendMessageOnDialogueEvent.SendMessageAction end = onConversationEnds[j];
				end.target = this.gameObject.transform;
				
				
			}
			SendMessageOnDialogueEvent.SendMessageAction[] onConversationStarts = allSendMessages[i].onStart;
			for(int j = 0;j<onConversationStarts.Length;j++) {
				SendMessageOnDialogueEvent.SendMessageAction start = onConversationStarts[j];
				start.target = this.gameObject.transform;
				
				
			} 
			
		}
		doTriggerMovers(true);
	}
	public void initNpcsForMap(WorldExplorer aExplorer,GameObject aAvatar,string aConversationToTrigger) {
		this.initNpcsForMap(aExplorer,aAvatar);
		StartCoroutine(waitToTriggerMapStartConvo(aAvatar,aConversationToTrigger));
		
	}
	private IEnumerator waitToTriggerMapStartConvo(GameObject aAvatar,string aConversationToTrigger) {
		yield return new WaitForSeconds(0.8f);
		triggerConversation(aConversationToTrigger,aAvatar.transform);
	}
	
	public void triggerConversation(string aName,Transform aActor) {
		ConversationTrigger[] c = this._npcs.GetComponentsInChildren<ConversationTrigger>();
		for(int i = 0;i<c.Length;i++) {
			ConversationTrigger t = c[i];
			if(t.name == aName) {
				this.preChatVariablesCheck();
				AvatarMover.setJoystickActive(true);
				_explorer.showInterface(true);
				if(!changingScene)
				t.OnUse();
			}
		}
		
	}
	public void destroyQuestArrows() {
		this._explorer.deleteQuestArrows();
	}
	
	public void createQuestArrows() {
		
		this._explorer.createQuestArrows();
	}
	public void saveQuests() {
		SaveGameUtils.REF.SaveStatsAndQuests();
	}
	public void debugMessage(string aMessage) {
		
		string[] data = aMessage.Split(',');
		Lua.Result r = DialogueLua.GetVariable(data[0]);
		Debug.Log("Variable: "+data[0]+" is: "+r.AsInt);
	}
	
	
	public void initialiseCaughtVariable(string aVariable) {
		
		string[] data = aVariable.Split(',');
		if(data.Length==2) {
			string variableName = data[0];
			string monsterName = data[1];
			MonsterLibraryRecord mlr = MonsterLibrary.REF.getMonster(monsterName);
			if(mlr!=null) {
				int val = PlayerMain.REF.monstersOfBreed(mlr);
				DialogueLua.SetVariable(variableName,val);
			}
		}
		
	}
	public void battleStart(string aBattleAndNPC) {
		string[] data = aBattleAndNPC.Split(',');
		if(data.Length>0) {

		Lua.Result l = DialogueLua.GetVariable(data[0]);
		if(l.AsInt==10) {
			Debug.Log("Battle start: "+data[0]+" "+l);
			Vector3 pos = _avatar.transform.position;
			NPCBattlesLibrary.getNPCBattleData(data[0]);
			if(BattleInit.REF!=null) {
				if(data.Length==4) {
					BattleInit.REF.orVariableWhenWon = data[2];
					BattleInit.REF.valueToOrWhenWon = Convert.ToInt32(data[3]);
				}
			}
			PlayerMain.REF.futureDoorway = new Doorway(this._explorer.map.name,new Vector2(pos.x,pos.y));
			PlayerMain.REF.futureDoorway.futureNPCChat = data[1];
			StopAllCoroutines();
				changingScene = true;

			this._explorer.changeScene("MapChangeSplashScreen");
		} else {
			Debug.Log("Not Starting battle variable was: "+l.ToString()+" ("+data[0]+")");
		}
		}
	}
	// Update is called once per frame
	void Update () {
		if(_checkVars==true) {
			Lua.Result preconvo = DialogueLua.GetVariable("PreConvoMovers");
			if(preconvo.AsString.Length>0) {
				GameObject g = GameObject.Find(preconvo.AsString);
				if(g!=null) {
					if(g.GetComponent<NPCMover>()) {
						g.GetComponent<NPCMover>().enabled = true;
					}
				}
				DialogueLua.SetVariable("PreConvoMovers","");
			}
			Lua.Result moveInConv = DialogueLua.GetVariable("ForcePlayerWalk");
			if(moveInConv.AsString.Length>0) {
				AvatarMover am = GameObject.FindWithTag("Player").GetComponent<AvatarMover>();
				string[] split = moveInConv.AsString.Split(new char[] {'|'});
				if(split.Length==2) {
					am.directRouteTo(new Vector2((float) Convert.ToDouble(split[0]),(float) Convert.ToDouble(split[1])));
				}
				
				DialogueLua.SetVariable("ForcePlayerWalk","");
			}
			
			Lua.Result objectsToEnable = DialogueLua.GetVariable("GameObjectsToEnable");
			if(objectsToEnable.AsString.Length>0) {
			
				Debug.Log ("Trying to enable objects: "+objectsToEnable.AsString);
				string[] split = objectsToEnable.AsString.Split (new char[] {'|'});
				for(int i = 0;i<split.Length;i++){
					GameObject g = GameObject.Find(split[i]);
					if(g!=null) {
						g.gameObject.SetActive(true);

					}
				}
				
				DialogueLua.SetVariable("GameObjectsToEnable","");
			}
			WorldExplorerBase.putParticlesInfront();
		}
		
	}
	public void preChatVariablesCheck() {
		AvatarMover.setJoystickActive(false);
		_explorer.showInterface(false);
		CONVO_OPEN = true;
		_checkVars = true;
		float nearest = float.MaxValue;
		GameObject nearestNPC = null;
		GameObject player = GameObject.FindGameObjectWithTag("Player");
		Vector3 pos = player.transform.localPosition;
		GameObject[] npcs = GameObject.FindGameObjectsWithTag("NPC");
		for(int i = 0;i<npcs.Length;i++) {
			float diff = Vector3.Distance(npcs[i].transform.localPosition,pos);
			if(diff<nearest) {
				nearestNPC = npcs[i];
				nearest = diff;
			}
			BoxCollider2D[] bc2d = npcs[i].GetComponents<BoxCollider2D>();
			for(int j=0;j<bc2d.Length;j++) {
				if(bc2d[j].isTrigger) {
					bc2d[j].enabled = false;
					_collidersToRenable.Add(bc2d[j]);
				}
			}
		}
	/*	if(nearestNPC!=null)
			am.setMyDirection(nearestNPC.gameObject.transform.localPosition-pos);*/
		StartCoroutine(restartCollidersIn(0.5f));
	}
	
	public void orValueToVariable(string aValue) {
		
		string[] data = aValue.Split(',');
		int value = Convert.ToInt32(data[0]);
		string varName = data[1];
		int current = DialogueLua.GetVariable(varName).AsInt;
		current = current | value;
		DialogueLua.SetVariable(varName,current);
		if(this.GetComponent<ConversationSwitcher>()) {
			this.GetComponent<ConversationSwitcher>().onConversationEnded(false);
		}
		
	}
	
	public void setDumpOut(Vector2 aNewDumpout) {
		Debug.Log("<color=yellow>New dumpout set: "+aNewDumpout+"</color>");
		this._dumpOutPosition = aNewDumpout;
	}
	public void resetDumpout() {
		this._dumpOutPosition = new Vector2(0f,0f);
	}
	
	private IEnumerator reEnableControlAfter(float aTime) {
		yield return new WaitForSeconds(aTime);
		
		_explorer.showInterface(true);
		AvatarMover.setJoystickActive(true);
		postChatVariablesCheck();
	}
	public void postChatVariablesCheck() {

		_checkVars = false;
		Lua.Result animState = DialogueLua.GetVariable("SetPlayerAnimStateAndPause");
		if(animState.AsInt>0) {
			this._avatar.GetComponent<AvatarMover>().doAnimState(animState.AsInt);
			
			_explorer.showInterface(false);
			AvatarMover.setJoystickActive(false);
			StartCoroutine(reEnableControlAfter(3f));
			DialogueLua.SetVariable("SetPlayerAnimStateAndPause",0);
			return;
		} else {
			
			_explorer.showInterface(true);
			AvatarMover.setJoystickActive(true);
		}
		Lua.Result cutscene = DialogueLua.GetVariable("Cutscene");
		if(cutscene.AsString.Length>0||false) {
			switch(cutscene.AsString) {
			case("End"):
				Application.LoadLevel("CreditsMainMenu");
				
				break;
			}
			
			DialogueLua.SetVariable("Cutscene","");
		}
		
		Lua.Result cameraShake = DialogueLua.GetVariable("CameraShake");
		if(cameraShake.AsString.Length>0) {
			switch(cameraShake.AsString) {
				case("Massive"):
					this._explorer.GetComponent<CameraShake>().MassiveShake();
				break;
				case("Large"):
					this._explorer.GetComponent<CameraShake>().LargeShake();
				break;
			}
			
			DialogueLua.SetVariable("CameraShake","");
		}
		Lua.Result terrapedia = DialogueLua.GetVariable("LookupTerrapedia");
		if(terrapedia.AsInt>0) {
			PlayerMain.REF.addMonsterToSeen(terrapedia.AsInt);
			int terrapediaVal = terrapedia.AsInt;
			this._explorer.onTerrapediaClicked();
			this._explorer.openChatOnTerrapediaClose = true;
			DialogueLua.SetVariable("LookupTerrapedia",0);
		}
		if(!changingScene)
			this._explorer.ranchLocationUpdate();
		Lua.Result item = DialogueLua.GetVariable("itemToAward");
		
		if(item.AsString.Length>0) {
			
			PlayerMain.REF.addToInventory(item.AsString);
			DialogueLua.SetVariable("itemToAward","");
			
		}
		Lua.Result toRemove = DialogueLua.GetVariable("MonsterToRemove");
		if(toRemove.AsInt>0) {
			PlayerMain.REF.removeMonsterByMonsterID(toRemove.AsInt);
			DialogueLua.SetVariable("MonsterToRemove",0);
		}
		
		Lua.Result addmonster = DialogueLua.GetVariable("AddMonster");
		if(addmonster.AsInt>0) {
			MonsterLibraryRecord ml = MonsterLibrary.REF.getMonster(addmonster.AsInt);
			MonsterDataMain m = new MonsterDataMain();
			m.initMonster(ml.ID,(byte) (DialogueLua.GetVariable("AddMonsterLevel").AsInt-1),false);
			if(PlayerMain.REF.monsterCount==0) {
				m.energy = m.MaxEnergy/2;
			}
			PlayerMain.REF.addMonster(m,false);
			DialogueLua.SetVariable("AddMonster",0);
		}
		if(onConversationEnded!=null) {
			onConversationEnded(false);
		}
		
		if(DialogueLua.GetVariable("Alert").AsString.Length>0) {
			DialogueManager.ShowAlert(DialogueLua.GetVariable("Alert").AsString);
			DialogueLua.SetVariable("Alert","");
		}
		GameObject player = GameObject.FindGameObjectWithTag("Player");
		if(player!=null) {
			AvatarMover am = player.GetComponent<AvatarMover>();
			ProximitySelector ps = player.GetComponent<ProximitySelector>();
			if(ps.CurrentUsable!=null) {
				NPCForceConvo npc = ps.CurrentUsable.GetComponent<NPCForceConvo>();
				if(npc!=null) {
					am.directRouteTo(new Vector2(npc.dumpOutPosition.x,npc.dumpOutPosition.y));
				}
			}
		}
		
		
		Lua.Result addTriggers = DialogueLua.GetVariable("AddMoverTriggers");
		Lua.Result triggerMovers = DialogueLua.GetVariable("TriggerMoversInNPCS");
		BetterList<string> newList = new BetterList<string>();
		if(addTriggers.AsString.Length>0) {
			string[] data = addTriggers.AsString.Split('|');
			string[] existing = triggerMovers.AsString.Split('|');
			for(int i =0;i<existing.Length;i++) {
				newList.Add(existing[i]);
			}
			for(int i = 0;i<data.Length;i++) {
				bool found = false;
				for(int c = 0;c<existing.Length;c++) {
					if(data[i].Equals(existing[c])) {
						found = true;
					}
				}
				if(!found) {
					newList.Add(data[i]);
				}
			}
			string newListAsString = "";
			for(int i =0;i<newList.size;i++) {
				newListAsString = newListAsString+newList[i];
				if(i<newList.size-1) {
					newListAsString = newListAsString + "|";
				}
			}
			DialogueLua.SetVariable("AddMoverTriggers","");
			DialogueLua.SetVariable("TriggerMoversInNPCS",newListAsString);
			doTriggerMovers(false);
		}
		
		Lua.Result autoStartConvo = DialogueLua.GetVariable("AutoStartNewConvo");
		if(autoStartConvo.AsString.Length>0) {
			ConversationTrigger[] ct = GameObject.FindObjectsOfType<ConversationTrigger>();
			for(int i = 0;i<ct.Length;i++) {
				if(ct[i].conversation == autoStartConvo.AsString) {
					if(!changingScene)
						ct[i].OnUse();
					DialogueLua.SetVariable("AutoStartNewConvo","");
					break;
				}
			}
			
			DialogueLua.SetVariable("AutoStartNewConvo","");
		}
		if(_collidersToRenable.size>0)
			StartCoroutine(restartCollidersIn(0.5f));
			
		CONVO_OPEN = false;
		SaveGameUtils.REF.SaveStatsAndQuests();
		
	}
	
	private IEnumerator restartCollidersIn(float aTime) {
		yield return new WaitForSeconds(aTime);
		for(int i = 0;i<_collidersToRenable.size;i++) {
			if(_collidersToRenable[i]!=null) {
				_collidersToRenable[i].enabled = true;
			}
			
		}
		_collidersToRenable.Clear();
	}
	public void doTriggerMovers(bool aFirstTurn) {
		Lua.Result triggerMovers = DialogueLua.GetVariable("TriggerMoversInNPCS");
		if(triggerMovers.AsString.Length>0) {
			
			string[] data = triggerMovers.AsString.Split('|');
			for(int i = 0;i<data.Length;i++) {
				GameObject g = GameObject.Find(data[i]);
				if(g!=null&&g.GetComponent<NPCMover>()!=null) {
					g.GetComponent<NPCMover>().firstUpdate = aFirstTurn;
					g.GetComponent<NPCMover>().enabled = true;
				}
			}
			
		}
	}
	
}
