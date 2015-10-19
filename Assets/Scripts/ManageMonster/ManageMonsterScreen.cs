using UnityEngine;
using System.Collections;
using PixelCrushers.DialogueSystem;
using System;
using Utils;

namespace ManageMonster 
{
	public class ManageMonsterScreen : ManageMonsterBase {
	
		public UIButton exitButton;
		public UIProgressBar sceneLoaderBar;
		public static MonsterDataMain changeMoveMonster;
		private AsyncOperation _AO;
		public GameObject restingAnim;
		public GameObject restingAnim2;
		public GameObject arrowToRestBtn;
		// Use this for initialization
		void Start () {
			if(PlayerMain.REF==null) {
				Application.LoadLevel("InitGameScene");
				return;
			}
			if(changeMoveMonster==null) {
				this.initMonster(PlayerMain.REF.monsters[0]);
			} else {
				this.initMonster(changeMoveMonster);
			}
			exitButton.isEnabled = true;
			arrowToRestBtn.gameObject.SetActive(false);
			
			startManageMonsterConversation();
			
			if(exitButton.onClick.Count==0) {
				exitButton.onClick.Add(new EventDelegate(this,"onExitManageMonsters"));
			}
		}
		
		public void releaseMonster() {
			if(PlayerMain.REF.monsterCount>1) {
				if(!PlayerMain.REF.monsterIsBattleMonster(monster)) {
					AlertQuestionWindow aqw = AlertGUI.REF.DoQuestionAlert("Release "+this.monster.name,"Are you sure you want to release "+this.monster.name+". This cannot be undone!","Yes","No");
					aqw.onAnswered += onYesRelease;
					aqw.onLeftAnswer += onNoRelease;
				} else {
					AlertGUI.REF.DoGeneralAlert("Cannot Release","You cannot release a Terra Monster that is in your current battle line-up");
				}
			} else {
				AlertGUI.REF.DoGeneralAlert("Cannot Release","You must have at least one Terra Monster at all times.");
				
			}
		}
		
		private void onYesRelease() {
			PlayerMain.REF.removeMonsterByMonsterMonster(this.monster);
			Application.LoadLevel("RanchOverview");
			
		}
		
		private void onNoRelease() {
		}
		protected void startManageMonsterConversation() {
			if(GameObject.FindGameObjectWithTag("DialogueManager")!=null) {
				ConversationTrigger c = GameObject.FindGameObjectWithTag("UIRoot").GetComponent<ConversationTrigger>();
				c.conversation = "Resting a Monster";
				c.OnUse ();
			}
		}
		
		
		// Update is called once per frame
		void Update () {
			Lua.Result l = DialogueLua.GetQuestField("Resting_your_Monsters","State");
			if(l.AsString=="success"||l.AsString=="done") {
				this.arrowToRestBtn.gameObject.SetActive(false);
			} else {
				this.arrowToRestBtn.gameObject.SetActive(true);
			}
			if(_AO!=null) {
				sceneLoaderBar.gameObject.SetActive(true);
				sceneLoaderBar.value = _AO.progress;
			} else {
				sceneLoaderBar.gameObject.SetActive(false);
			}
			try {
			if(this.leftSide!=null&&this.leftSide.previewMonster!=null&&this.leftSide.previewMonster.monster!=null) {
				if(this.leftSide.previewMonster.monster.restingStatus!=ERestingStatus.Awake) {
					this.restingAnim.gameObject.SetActive(true);
						restingAnim2.gameObject.SetActive(true);
						restingAnim2.tag = "ParticleSystems";
						putParticlesInfront();
						
					this.leftSide.previewMonster.doRestAnimation();
				} else {
						this.restingAnim.gameObject.SetActive(false);
						restingAnim2.gameObject.SetActive(false);
					this.leftSide.previewMonster.doIdleAnimation();
				}
			}
			} catch(Exception e) {
			
			}
		}
		public static void putParticlesInfront() {
			GameObject[] allParticles = GameObject.FindGameObjectsWithTag("ParticleSystems");
			for(int i = 0;i<allParticles.Length;i++) {
				
				allParticles[i].GetComponent<ParticleSystem>().GetComponent<Renderer>().sortingLayerName = "ParticleLayer";
				ParticleSystem[] children = allParticles[i].GetComponentsInChildren<ParticleSystem>();
				for(int j = 0;j<children.Length;j++) {
					children[j].GetComponent<Renderer>().sortingLayerName = "ParticleLayer";
				}
			}
		}
		public void onChangeMoves() {
			changeMoveMonster = this.monster;
			StartCoroutine(loadLevelWithProgress("MoveAssignMoveTree"));
			//Application.LoadLevel("MoveAssignMoveTree");
		}
		
		public IEnumerator loadLevelWithProgress(string aLevelToLoad) {
				_AO = Application.LoadLevelAsync(aLevelToLoad);
				yield return _AO;
			}
			
		public void onRanchView() {
			Debug.Log ("Ranchview");
			loadLevelWithProgress("RanchOverview");
		}	
		public void onBattleLineup() {
			Debug.Log ("Battle Lineup");
		}
		public void onExitManageMonsters() {
			Debug.Log ("Exit Manage Monsters");
			Application.LoadLevel("RanchOverview");
		}
		
		public void onRestMonster() {
			Lua.Result r = DialogueLua.GetQuestField("Resting_your_Monsters","State");
			if(r.AsString=="active") {
				DialogueLua.SetQuestField("Resting_your_Monsters","State","failure");
				this.startManageMonsterConversation();
			}
			if(this.leftSide.previewMonster.monster.restingStatus==ERestingStatus.VoluntaryRest) {
				this.leftSide.previewMonster.monster.restingStatus = ERestingStatus.Awake;
			} else {
				this.leftSide.previewMonster.monster.restingStatus = ERestingStatus.VoluntaryRest;
			}
		}
	}
}