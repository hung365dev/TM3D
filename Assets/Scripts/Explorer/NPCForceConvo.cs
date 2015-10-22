// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------
using System;
using UnityEngine;
using PixelCrushers.DialogueSystem;

public class NPCForceConvo : MonoBehaviour
{
	public string forceAfterQuest;
	public string forceBeforeQuest;
	public string forceWhileQuestActive;
	public string forceAfterBattle;
	public string forceBeforeBattle;
	public Vector2 dumpOutPosition;
	public string forceBeforeQuestComplete;
	public string whenVariableName;
	public int whenVariableValue;
	public EOperandType variableOperand;
	
	public float chatPositionOffsetY;
	public float chatPositionOffsetX=0;
	
	public string debugOnlyGameObject = "Zina";
	private NPCManager _npcManager;
	// Use this for initialization
	void Start () {
		if(GameObject.FindGameObjectWithTag("NPCManager")!=null) {
			_npcManager = GameObject.FindGameObjectWithTag("NPCManager").GetComponent<NPCManager>();
		//	_npcManager.onConversationEnded += onConversationEnded;
		//	onConversationEnded();
		}
		forceAfterQuest = forceAfterQuest.Replace(" ","_");
		forceBeforeQuest = forceBeforeQuest.Replace(" ","_");
		forceWhileQuestActive = forceWhileQuestActive.Replace(" ","_");
		if(chatPositionOffsetY<=0&&chatPositionOffsetY>-3) {
			chatPositionOffsetY = -2.7f;
		}
	//	forceAfterBattle = forceAfterBattle.Replace(" ","_");
//		forceBeforeBattle = forceBeforeBattle.Replace(" ","_");
	}

	public void OnCollisionEnter2D() {

	}
	public Vector2 location {
		get {
			Vector2 temp = new Vector2(this.gameObject.transform.position.x+chatPositionOffsetX,this.gameObject.transform.position.y+chatPositionOffsetY);
			return temp;
		}
	}
	public bool forceConversation {
		get {
			if(forceBeforeBattle!=null&&forceBeforeBattle.Length>0) {
				Lua.Result r = DialogueLua.GetVariable(forceBeforeBattle);
				
				if(debugOnlyGameObject.Length==0||debugOnlyGameObject==this.gameObject.name)
				Debug.Log("<color=green>Force Conversation battle ("+this.gameObject.name+": "+forceBeforeBattle+" "+r.AsInt+"</color>");
				if((r.AsInt==(int) EBattleStatus.NotAttempted)||(r.AsInt==(int) EBattleStatus.Failed)||(r.AsInt==(int) EBattleStatus.AboutToStart)||(r.AsInt==(int) EBattleStatus.Error)) {
					return true;
				}
				
			} 
			if(forceBeforeQuest!=null&&forceBeforeQuest.Length>0) {
				Lua.Result r = DialogueLua.GetQuestField(forceBeforeQuest,"State");
				if(r.AsString=="unassigned") {
					return true;
				}
			}
			if(forceBeforeQuestComplete!=null&&forceBeforeQuestComplete.Length>0) {
				Lua.Result r = DialogueLua.GetQuestField(forceBeforeQuestComplete,"State");
				if(r.AsString!="success") {
					return true;
				}
			}
			if(forceWhileQuestActive!=null&&forceWhileQuestActive.Length>0) {
				Lua.Result r = DialogueLua.GetQuestField(forceWhileQuestActive,"State");
				if(r.AsString=="active") {
					return true;
				}
			}
			
			if(whenVariableName!=null&&whenVariableName.Length>0) {
				Lua.Result variable = DialogueLua.GetVariable(whenVariableName);
				
				switch(variableOperand) {
				case(EOperandType.EqualTo):if(variable.AsInt==whenVariableValue)
						return true;
					break;
				case(EOperandType.LessThan):if(variable.AsInt<whenVariableValue)
						return true;
					break;
				case(EOperandType.MoreThan):if(variable.AsInt>whenVariableValue)
						return true;

					break;
				case(EOperandType.Not):if(variable.AsInt!=whenVariableValue)
						return true;
					break;
				
				}
			}
			
			return false;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

		
		

