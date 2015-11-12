using System;
using System.Collections;
using PixelCrushers.DialogueSystem;
using UnityEngine;
using MTX;
using Utils;
using utils;
using Battles;


public class WorldExplorer : WorldExplorerWithButtons
{
	public GameObject QuestArrowPrefab;
	public UIRoot uiRoot;
	public UMAMaker umaAvatar;
	public GameObject mountTransitionGraphic;
	public static bool MOUNTED = false;
	public static WorldExplorer REF;
	public GameObject battleMakeup;
	public Camera battleCamera;
	public Light worldLight;
	public WorldExplorer ()
	{
	}
	
	
	public void Awake() {
		Lua.Result maleStatus = DialogueLua.GetActorField("Player","UMA");
		// TODO Make UMA here!
		REF = this;
	//	worldLight = this.GetComponentInChildren<Light> ();
		StartCoroutine(createArrowsAfter1Frame());
	}
	public void onLaunchSettings() {

	}
	public void onMountSwap() {
		if(MTXManager.REF.ownsRoboHeckyll()) { 
			MOUNTED =!MOUNTED;
			Vector3 pos = this.selectedAvatar.transform.localPosition;
			GameObject t = NGUITools.AddChild(null,mountTransitionGraphic);
			t.tag = "ParticlesUnderPlayer";
			t.transform.localPosition = pos;
			putParticlesInfront();
			AvatarMover am = this.selectedAvatar.GetComponent<AvatarMover>();
			am.swapToMount();
		} else { 

		}
	} 

	public void StartBattle(SpawnMonsterOnMap aMonster) {
		Debug.Log ("Starting a Battle");
		worldLight.gameObject.SetActive (false);
		SpawnAreaMonster sm = new SpawnAreaMonster (aMonster.name, aMonster.level, 1f, "");
		new BattleInit (sm, "");
		Light l = this.GetComponentInChildren<Light> ();
	
		this.gameObject.SetActive (false);
		this.battleCamera.gameObject.SetActive (true);
this.uiRoot.gameObject.SetActive(false);
		battleMakeup.gameObject.SetActive (true); 
	}
	private IEnumerator createArrowsAfter1Frame() {
		yield return new WaitForEndOfFrame();
		createQuestArrows();
		GameObject go = GameObject.FindGameObjectWithTag("MultiplayerController");
		if(go!=null) {
		
		}
		this.showInterface(true);
			
			yield return new WaitForSeconds(1f);
			
			//Destroy (transitionIn.gameObject);
	}
	public void deleteQuestArrows() {
		GameObject[] g = GameObject.FindGameObjectsWithTag("QuestArrow");
		for(int i = 0;i<g.Length;i++) {
			Destroy(g[i]);
		}
	}
	private IEnumerator delayToDoArrows() {
		yield return new WaitForSeconds(0.25f);
		deleteQuestArrows();
		string[] quests = QuestLog.GetAllQuests(QuestState.Active);
		yield return new WaitForEndOfFrame();
		for(int i = 0;i<quests.Length;i++) {
			if(QuestLog.IsQuestTrackingEnabled(quests[i])) {
				int entryCount = QuestLog.GetQuestEntryCount(quests[i]);
				bool isComplete = true;
				for(int j = 0;j<entryCount;j++) {
					
					GameObject arrow = NGUITools.AddChild(this.uiRoot.gameObject,QuestArrowPrefab);
				//	QuestArrow qa = arrow.GetComponent<QuestArrow>();
				/*	if(qa.initFromQuest(quests[i],j,this._mapRef.name,this._mapRef.fileName,this)) {
						isComplete = false;
					} else {
						Destroy (arrow);
					}*/
				}
				if(isComplete) {
					Lua.Result npcName = DialogueLua.GetQuestField(quests[i],"CompletionNPC");
					
					string[] allNPCs = npcName.AsString.Split(new char[] { '|' }); 
					
					for(int c = 0;c<allNPCs.Length;c++) {
						GameObject arrow = NGUITools.AddChild(this.uiRoot.gameObject,QuestArrowPrefab);
					/*	QuestArrow qa = arrow.GetComponent<QuestArrow>();
						if(qa.initForCompletion(quests[i],allNPCs[c],this._mapRef)) {
							
						} else {
							Destroy (qa.gameObject);
						}*/
					}
					
				}
				yield return new WaitForEndOfFrame();
			}
		}
	}
	public void createQuestArrows() {
		showInterface(true);
		StartCoroutine(delayToDoArrows());
		
	}
}
