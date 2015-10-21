using UnityEngine;
using System.Collections;
using PixelCrushers.DialogueSystem;
using PixelCrushers.DialogueSystem.ChatMapper;
using utils;
using System;


public class WorldExplorerBase : MonoBehaviour {
	
	public string mapToLoad;
	public DialogueSystemController dialogue;
	protected Map _mapRef;
	public NPCManager npcManager;
	public GameObject attentionGrabber;
	private byte _doorwaysLayer;
	private byte _collidersLayer;
	public UILabel mapName;
	public QuestLogWindow logWindow;
	public static bool VARS_INITED = false;
	public static bool CHECKED_MULTIPLAYER_ACCOUNT = false;
	public RanchLocatorFinder locator;
	public GameObject allMap;
	public static bool DisableMultiplayer = false;
	public UILabel xpBoostLabel;
	public UILabel repellantLabel;
	public UILabel ranchInfoLabel;
	public GameObject ranchInfoObject;
	private int _timeToNextSave = 10;
	private int _updatesToListenToClock = 100;
	public GameObject selectedAvatar;
	public GameObject ranchLocationUpdater;
	public static string MAP_NAME;
	// Use this for initialization
	void Start () {
		if(PlayerMain.REF==null) {
			Application.LoadLevel("InitGameScene");
			return;
		}
		
		//Tile.SetCamera ();
		
		this.xpBoostLabel.gameObject.SetActive(false);
		ranchInfoLabel.gameObject.SetActive(false);
		ranchInfoObject.gameObject.SetActive(false);
		this.repellantLabel.gameObject.SetActive(false);
		PlayerMain player = PlayerMain.REF;
		if(PlayerMain.REF.futureDoorway==null) {
		
		}
		
		_mapRef = PlayerMain.REF.futureDoorway.targetMap;
	//	_mapRef = MapLibrary.getMap("GameTestMap");
		if(_mapRef!=null) {
			mapToLoad = _mapRef.fileName;
		}
		MAP_NAME = PlayerMain.REF.futureDoorway.targetMap.fileName;

		if(this.mapToLoad.Length>0) {
			_mapRef = MapLibrary.getMap(mapToLoad);
		}
		if(MAP_NAME.Contains("Home")&&PlayerMain.REF.futureDoorway.targetXY.x==0f&&PlayerMain.REF.futureDoorway.targetXY.y==0f) {
			_mapRef = _mapRef.reparentMap;
			mapToLoad = _mapRef.name;
		} 
		StartCoroutine(delayedSavingThings(mapToLoad));
		
		this.mapName.text = _mapRef.name;
		GameObject map;
		if(mapToLoad.Contains("Guild")) {
			map = UnityEngine.Object.Instantiate(Resources.Load("Maps/Indoors/Guilds/"+mapToLoad) as GameObject) as GameObject;
		} else if(mapToLoad.Contains ("Home")) {
			map = UnityEngine.Object.Instantiate(Resources.Load("Maps/Indoors/HomeInteriors/"+mapToLoad) as GameObject) as GameObject;
		} else if(mapToLoad.Contains ("HQ")) {
			map = UnityEngine.Object.Instantiate(Resources.Load("Maps/Indoors/HQs/"+mapToLoad) as GameObject) as GameObject;
		}
		else map = UnityEngine.Object.Instantiate(Resources.Load("Maps/"+mapToLoad) as GameObject) as GameObject;
		allMap = map;
		locator = map.GetComponentInChildren<RanchLocatorFinder>();

		
		
		if (QuestLog.GetQuestState ("Save_the_Town") == QuestState.Success) {
			Destroy (attentionGrabber);
		}
		putParticlesInfront();
		GameTimer.REF.OnTimerTick += onSecondTimer;
		StartCoroutine(UpdateTrackerAfterOneFrame(mapToLoad,map));
	 }
	 
	public void changeScene(string aNewScene) {
		StartCoroutine(getReadyToChangeScene(aNewScene));
	}
	void OnDisable() {
		if(GameTimer.REF!=null)
			GameTimer.REF.OnTimerTick -= onSecondTimer;
	}
	private void onSecondTimer() {
		bool anyRanchNotes = false;
		this.ranchInfoLabel.text = "";
		if(MonsterWithClock.monstersAtRanch.size>0) {
			string s = "Return to Ranch for: ";
			for(int i = 0;i<MonsterWithClock.monstersAtRanch.size;i++) {
				s+= MonsterWithClock.monstersAtRanch[i].name;
				if(i<MonsterWithClock.monstersAtRanch.size-1) {
					s+= ", ";
				}
			}
			this.ranchInfoLabel.text = s;
			anyRanchNotes = true;
		}
		if(MonsterWithClock.monstersAtRanchResting.size>0) {
			string s = "\n";
			for(int i = 0;i<MonsterWithClock.monstersAtRanchResting.size;i++) {
				s+= MonsterWithClock.monstersAtRanchResting[i].name;
				if(i<MonsterWithClock.monstersAtRanchResting.size-1) {
					s+= ", ";
				}
			}
			if(MonsterWithClock.monstersAtRanchResting.size==1) {
				s+= " is Recovering at Ranch";
			} else
			s+= " are Recovering at Ranch";
			this.ranchInfoLabel.text += s;
			anyRanchNotes = true;
		}
		if(!anyRanchNotes) {
			this.ranchInfoObject.SetActive(false);
			ranchInfoLabel.gameObject.SetActive(false);
		} else {
			this.ranchInfoObject.SetActive(true);
			ranchInfoLabel.gameObject.SetActive(true);
		}
		
		if(PlayerMain.REF.repelSecondsRemaining>0) {
			TimeSpan t = TimeSpan.FromSeconds( PlayerMain.REF.repelSecondsRemaining );
			
			string answer = string.Format("{0:D1}h:{1:D2}m:{2:D2}s", 
			                              t.Hours, 
			                              t.Minutes, 
			                              t.Seconds, 
			                              t.Milliseconds);
			this.repellantLabel.text = PlayerMain.REF.repelName+": "+answer;
			PlayerMain.REF.repelSecondsRemaining--;
			this.repellantLabel.gameObject.SetActive(true);
			if(PlayerMain.REF.repelSecondsRemaining==0) {
				PlayerMain.REF.loadRepelData("0,0,");
			} else {
				_timeToNextSave--;
			}
		} else {
			this.repellantLabel.gameObject.SetActive(false);
		}
		if(PlayerMain.REF.xpBoostSecondsRemaining>0) {
			TimeSpan t = TimeSpan.FromSeconds( PlayerMain.REF.xpBoostSecondsRemaining );
			
			string answer = string.Format("{0:D1}h:{1:D2}m:{2:D2}s", 
			                              t.Hours, 
			                              t.Minutes, 
			                              t.Seconds, 
			                              t.Milliseconds);
			this.xpBoostLabel.text = PlayerMain.REF.xpBoostName+": "+answer;
			PlayerMain.REF.xpBoostSecondsRemaining--;
			if(PlayerMain.REF.xpBoostSecondsRemaining==0) {
				PlayerMain.REF.loadXPBoostData("0,0,");
			} else {
				_timeToNextSave--;
			}
			this.xpBoostLabel.gameObject.SetActive(true);
		} else {
			
			this.xpBoostLabel.gameObject.SetActive(false);
		}
		if(_timeToNextSave<0) {
			_timeToNextSave = 20;
			SaveGameUtils.REF.saveBoostAndRepelData(PlayerMain.REF.xpBoostData,PlayerMain.REF.repelBoostData);
		}
	}
	
	private IEnumerator getReadyToChangeScene(string aNewScene) {
		yield return new WaitForSeconds(1f);
		Application.LoadLevel(aNewScene);
	}
	
		private IEnumerator delayedSavingThings(string aMapToSave) {
			initVariables();
			yield return new WaitForSeconds(1f);
			SaveGameUtils.REF.UpdateLastMap(aMapToSave);
			yield return new WaitForSeconds(2.5f);
		
		}
		private IEnumerator UpdateTrackerAfterOneFrame(string aMapToLoad,GameObject aMap) {
		if(PlayerMain.REF.monsterCount==0) {
			// Start of game forced convo
			Debug.Log ("My monster count is zero");
			npcManager.initNpcsForMap(aMapToLoad,this as WorldExplorer,selectedAvatar,"ZinaPreSelectMonster",aMap);
			
		} else 
		if(PlayerMain.REF.futureDoorway!=null&&PlayerMain.REF.futureDoorway.futureNPCChat!=null) {
			npcManager.initNpcsForMap(aMapToLoad,this as WorldExplorer,selectedAvatar,PlayerMain.REF.futureDoorway.futureNPCChat,aMap);
		} else {
			npcManager.initNpcsForMap(aMapToLoad,this as WorldExplorer,selectedAvatar,aMap);
			
		}
		
		yield return null;


			ranchLocationUpdate();

			yield return null;

		
			}
			
		
	//	tk2dTileMap tileMap = Resources.Load() as tk2dTileMap;
	//	Tile.LoadLevel(_mapRef.tileData);
	public void ranchLocationUpdate() {
		if(ranchLocationUpdater==null) {
			ranchLocationUpdater = UnityEngine.Object.Instantiate(Resources.Load("Maps/RanchLocationDisplay") as GameObject) as GameObject;
			
			putParticlesInfront();
		}
		if(locator!=null) {
			Vector2 vec = locator.findLocation();
			ranchLocationUpdater.transform.position = new Vector3(vec.x,vec.y);
		}
	}
	public void initVariables() {
		if(!VARS_INITED) {
			if(dialogue==null) {
				GameObject go = GameObject.FindGameObjectWithTag("DialogueManager");
				if(!UnityEngine.Object.ReferenceEquals(go,null))
					dialogue = go.GetComponent<DialogueSystemController>();
			}
			if(dialogue!=null) {
				VARS_INITED = true;
				NPCBattlesLibrary.initNPCBattleVariables(dialogue.MasterDatabase);
			}
		}
	}



	public bool transitionManagersActive {
		get {
			return false;
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
		
		allParticles = GameObject.FindGameObjectsWithTag("ParticlesUnderPlayer");
		for(int i = 0;i<allParticles.Length;i++) {
			
			if(allParticles[i].GetComponent<ParticleSystem>()!=null) {
				allParticles[i].GetComponent<ParticleSystem>().GetComponent<Renderer>().sortingLayerName = "ParticlesUnderPlayer";
			ParticleSystem[] children = allParticles[i].GetComponentsInChildren<ParticleSystem>();
			for(int j = 0;j<children.Length;j++) {
				children[j].GetComponent<Renderer>().sortingLayerName = "ParticlesUnderPlayer";
			}
			}
		}
		allParticles = GameObject.FindGameObjectsWithTag("ParticlesUnderBuildings");
		for(int i = 0;i<allParticles.Length;i++) {
			if(allParticles[i].GetComponent<ParticleSystem>()!=null) {
				allParticles[i].GetComponent<ParticleSystem>().GetComponent<Renderer>().sortingLayerName = "PlayerLower";
				ParticleSystem[] children = allParticles[i].GetComponentsInChildren<ParticleSystem>();
				for(int j = 0;j<children.Length;j++) {
					children[j].GetComponent<Renderer>().sortingLayerName = "PlayerLower";
				}
			}
		}
		
		//,
	}
	
	public Map map {
		get {
			return _mapRef;
		}
	}
	// Update is called once per frame
	public virtual void Update () {
		if(_updatesToListenToClock>0) 
			this._updatesToListenToClock--; else {
				if(_updatesToListenToClock==0)  {
					PlayerMain.REF.makeAllListenToClock();
					_updatesToListenToClock = -1;
				}
			}
		if(!VARS_INITED) {
			initVariables();
		}
		if(Input.GetKeyDown(KeyCode.Q)) {
			Debug.Log ("Toggle Quest");
			this.logWindow.Open();
		}
	}
	
}
