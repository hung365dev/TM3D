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
using Parse;
using UnityEngine;
using System.Collections.Generic;
using PixelCrushers.DialogueSystem;
using System.Collections;
using Utils;

namespace utils
{
	public class SaveGameUtils : MonoBehaviour
	{
		private List<string> _playerData;
		private List<string> _globalSettings;
		public int USING_SAVE_GAME_INDEX = 0;
		public static SaveGameUtils REF;
		private float _lastCloudUpdate = 0.0f;
		private float _lastDiskUpdate = 0.0f;
		private bool _requireDiskUpdate = false;
		private bool _requireSave = false;
		public float SECONDS_BETWEEN_UPDATE = 10.0f;
		public float SECONDS_BETWEEN_DISK_UPDATE = 1.0f;
		
		private bool _handleCloudRetrieve = false;
		private const string DATA_NAME = "t69";
		private const string SETTINGS_NAME = "s6";
		public string loadingDetails = ""; 
		public ParseObject rankingObject;
		public int myRank = 0;
		public string lastGoodQuestData = "";
		public static string Password = "";
		public DateTime millenium = new DateTime(2000,1,1);
		public SaveGameUtils ()
		{
		}
		public void reset() {
			Password = "";
			_playerData = null;
			USING_SAVE_GAME_INDEX = 0;
			_lastCloudUpdate = 0f;
			_lastDiskUpdate = 0f;
			rankingObject = null;
			lastGoodQuestData = "";
			ParseUser.LogOut();
		}
		public bool pollBalances {
			get {
				try {
					return Convert.ToBoolean(_globalSettings[(int) EGlobalSettings.PollBalances]);
				} catch(Exception e) {
					pollBalances = false;
					return false;
				}
			}
			set {
				_globalSettings[(int) EGlobalSettings.PollBalances] = Convert.ToString(value);
				saveSettings();
			}
		}
		public bool musicOn {
			get {
				return Convert.ToBoolean(_globalSettings[(int) EGlobalSettings.Music]);
			}
			set {
				_globalSettings[(int) EGlobalSettings.Music] = Convert.ToString(value);
			
				saveSettings();
			}
		}
		public bool soundsOn {
			get {
				return Convert.ToBoolean(_globalSettings[(int) EGlobalSettings.Sounds]);
			}
			set {
				_globalSettings[(int) EGlobalSettings.Sounds] = Convert.ToString(value);
				saveSettings();
			}
		}
		public bool offlineUnlocked {
			get {
				return Convert.ToBoolean(_globalSettings[(int) EGlobalSettings.OfflineUnlocked]);
			}
			set {
				_globalSettings[(int) EGlobalSettings.OfflineUnlocked] = Convert.ToString(value);
				saveSettings();
			}
		}
		public bool rateboxRemind {
			get {
				try {
				if(_globalSettings.Count<=(int) EGlobalSettings.RateBox) {
					_globalSettings.Add("false");
				}
				return Convert.ToBoolean(_globalSettings[(int) EGlobalSettings.RateBox]);
				} catch(Exception e) {
					return false;
				}
			}
			set {
				try {
				_globalSettings[(int) EGlobalSettings.RateBox] = Convert.ToString(value);
				saveSettings();
				}
				catch(Exception e) {
				
				}
			}
		}
		public void Awake() {
			REF = this;
			DontDestroyOnLoad(this.gameObject);
			if(ES2.Exists(SETTINGS_NAME)) {
				_globalSettings = ES2.LoadList<string>(SETTINGS_NAME);
			} else {
				_globalSettings = new List<string>(); 
				for(int i = 0;i<(int) EGlobalSettings.MaxSize;i++) {
					_globalSettings.Add("");
				}
				_globalSettings[(int) EGlobalSettings.OfflineUnlocked] = Convert.ToString(false);
				_globalSettings[(int) EGlobalSettings.Music] = Convert.ToString(true);
				_globalSettings[(int) EGlobalSettings.Sounds] = Convert.ToString(true);
				_globalSettings[(int) EGlobalSettings.PollBalances] = Convert.ToString(false);
				_globalSettings[(int) EGlobalSettings.RateBox] = Convert.ToString(true);
				saveSettings();
			}
		}
		
		public void saveSettings() {
			
			ES2.Save(_globalSettings,SETTINGS_NAME);
		}
		public int mpScore {
			get {
				if(rankingObject!=null)
					return rankingObject.Get<int>("score"); else {
						this.AddToScore(0);
						return 0;
					}
			}
		}
		public void incrementLuaStat(string aVariable,int aValue) {
			Lua.Result w = DialogueLua.GetVariable(aVariable);
			int battles = aValue;
			if(w.HasReturnValue) {
				battles = w.AsInt + 1;
			} else {
				
			}
			Debug.Log ("Lua Var: "+aVariable+" is now: "+battles);
			DialogueLua.SetVariable(aVariable,battles);
		}
		public void initGameFromCloudLogin() {
			_handleCloudRetrieve = true;
		}
		public void LoadGame(int aIndex) {
			rankingObject = null;
			if(this.SavedGameExists(aIndex)) {
				USING_SAVE_GAME_INDEX = aIndex;
				_playerData = ES2.LoadList<string>(aIndex+DATA_NAME);
				new PlayerMain();
				PlayerMain.REF.loadMonsters(_playerData[(int) EPlayerArray.Monsters]);
				PlayerMain.REF.itemsFromString(_playerData[(int) EPlayerArray.Items]);
				PlayerMain.REF.multiplayerName = _playerData[(int) EPlayerArray.Name];
				PlayerMain.REF.multiplayerPass = _playerData[(int) EPlayerArray.Password];
				string decompressedQuests = Base64Compressor.Base64Decode(_playerData[(int) EPlayerArray.Quests]);
				if(decompressedQuests.Length>0)
					PersistentDataManager.ApplySaveData(decompressedQuests);
				PlayerMain.REF.doMultiplayerLoginCheck();
			} else {
				Debug.LogError("Trying to Load game when no game exists: "+aIndex);
			}
		}
		
		public IEnumerator LoadGameASync(int aIndex) {
			rankingObject = null;
			if(this.SavedGameExists(aIndex)) {
				USING_SAVE_GAME_INDEX = aIndex;
				GameTimer.GAME_START = true;
				_playerData = ES2.LoadList<string>(aIndex+DATA_NAME);
				new PlayerMain();
				/* Note that all player data info must be given before monsters because monsters calls SavePlayerData() */
				
				string hc = _playerData[(int) EPlayerArray.HardCurrency];
				string sc = _playerData[(int) EPlayerArray.SoftCurrency];
				//	try {
				
				if(hc.Length>0)
					if(hc.StartsWith("h"))
						PlayerMain.REF.hardCurrency = Convert.ToInt32(hc.Substring(1)); else {
							PlayerMain.REF.hardCurrency = Convert.ToInt32(hc);
						}
				if(sc.Length>0)
					if(sc.StartsWith("s"))
						PlayerMain.REF.softCurrency = Convert.ToInt32(sc.Substring(1)); else {
					PlayerMain.REF.softCurrency = Convert.ToInt32(sc);
				}
				yield return new WaitForEndOfFrame();
				string monsters1 = _playerData[(int) EPlayerArray.Monsters];
				string[] monstersSplit1 = monsters1.Split(new char[] {'|'});
				
				string[] allMonsters = PlayerMain.REF.monsterDecompressString(monstersSplit1[0]);
				if(monstersSplit1.Length>1) {
					int minuteLast = Convert.ToInt32(monstersSplit1[1]);
					DateTime milleniumPlus = new DateTime(2000,1,1);
					milleniumPlus = milleniumPlus.AddSeconds(minuteLast);
					
					int secondsSinceMillenium = Convert.ToInt32((DateTime.Now-milleniumPlus).TotalSeconds);
					GameTimer.REF.catchUpSeconds = secondsSinceMillenium;
					Debug.Log ("<color=orange>Minutes I was offline for is: "+secondsSinceMillenium+"</color>");
				}
					
				for(int i = 0;i<allMonsters.Length;i++) {
					if(allMonsters[i].Length>0) {
						PlayerMain.REF.loadMonsterASync(allMonsters[i],i);
						this.loadingDetails = "Loading Monster: "+i;
						if(i%3==0) 
						yield return new WaitForEndOfFrame();
					}
				}
				
				PlayerMain.REF.loadRepelData(_playerData[(int) EPlayerArray.RepelBoostData]);
				PlayerMain.REF.loadXPBoostData(_playerData[(int) EPlayerArray.XPBoostData]);
				
				
				this.loadingDetails = "Loading Inventory";
				yield return new WaitForEndOfFrame();
				
			//	} catch(Exception e) {
			//		PlayerMain.REF.hardCurrency = 0;
			//		PlayerMain.REF.softCurrency = 0;
			//	}
				PlayerMain.REF.itemsFromString(_playerData[(int) EPlayerArray.Items]);
				PlayerMain.REF.futureDoorway = new Doorway(_playerData[(int) EPlayerArray.LastUsedMap]);
			//	PlayerMain.REF.futureDoorway = new Doorway("Mombassi House");
				string decompressedQuests = "";
				yield return new WaitForEndOfFrame();
				try {
					this.loadingDetails = "Loading Quests";
					decompressedQuests = Base64Compressor.Base64Decode(_playerData[(int) EPlayerArray.Quests]);
				} catch(Exception e) {
					sendQuestData(PlayerMain.REF.name,_playerData[(int) EPlayerArray.Quests],"Decompressing");
					AlertGUI.REF.DoGeneralAlert("Error on Decompressing","An error: "+e.Message+" has occurred. Your quest data has been saved. Please contact us at andrewstarnes@socialtitans.com for further assistance");
					 
				}
				yield return new WaitForEndOfFrame();
				try {
					if(decompressedQuests.Length>0) {
						
						this.loadingDetails = "Loading Quests";
						PersistentDataManager.ApplySaveData(decompressedQuests);
					}
				} catch(Exception e) {
					sendQuestData(PlayerMain.REF.name,_playerData[(int) EPlayerArray.Quests],"Loading");
					AlertGUI.REF.DoGeneralAlert("Error on Loading","An error: "+e.Message+" has occurred. Your quest data has been saved. Please contact us at andrewstarnes@socialtitans.com for further assistance");

				}

				if(_playerData[(int) EPlayerArray.Password].Length>0) {
					PlayerMain.REF.multiplayerName = _playerData[(int) EPlayerArray.Name];
					PlayerMain.REF.multiplayerPass = _playerData[(int) EPlayerArray.Password];
					ParseUser.LogInAsync(PlayerMain.REF.multiplayerName,PlayerMain.REF.multiplayerPass);
					
					DialogueLua.SetActorField("Player","Name",PlayerMain.REF.multiplayerName);
				 
				//	PlayerMain.REF.doMultiplayerLoginCheck();
					string rankingText = _playerData[(int) EPlayerArray.RankingObjID];
					if(rankingText!=null&&rankingText.Length>0) {
						ParseQuery<ParseObject> query = ParseObject.GetQuery("TMRank");
						query.GetAsync(rankingText).ContinueWith(t => {
							rankingObject = t.Result;
							Debug.Log ("Ranking Score is: "+rankingObject.Get<int>("score"));
							fetchRank();
						});
					} else { 
						AddToScore(0);
					}
				} else {
				
				}
				Application.LoadLevel("WorldViewer");
				

			} else {
				Debug.LogError("Trying to Load game when no game exists: "+aIndex);
			}
		}
		private IEnumerator sendQuestData(string aName,string aData,string aType) {
			WWW tWWW = new WWW("http://www.blueomega.me/terramonsters/questData.php?name="+aName+"&data="+aData+"&type="+aType);
			while(!tWWW.isDone) {
				yield return new WaitForSeconds(0.1f);
			}
			yield return tWWW;
			//	Debug.Log ("JSON Loaded: "+tWWW.text);
		
		}

		public void fetchRank() {
			Debug.Log ("Fetching Rank!");
			// First set up a callback.
			var query = ParseObject.GetQuery("TMRank");
			var q2 = query.WhereGreaterThan("score", rankingObject.Get<int>("score"));
			q2.CountAsync().ContinueWith(t => {
				var holder = t;
				Debug.Log (holder);
			  	myRank = t.Result+1;
				Debug.Log ("My Rank is: "+myRank);
				
				fetchBestPlayer();
			});
			
		}
		
		public void fetchBestPlayer() {
			Debug.Log ("Fetching best player");
			var query = ParseObject.GetQuery("TMRank");
			query = query.OrderByDescending("score");
			query = query.Limit(1);
			query.FindAsync().ContinueWith(t => {
				var holder = t;
				Debug.Log ("Fetched best player");
				IEnumerable<ParseObject> relatedObjects = t.Result;
				Debug.Log (relatedObjects.ToString());
				foreach (var obj in relatedObjects)
				{
					DialogueLua.SetVariable("BestMultiplayer",obj["name"]);
				}
				Debug.Log ("Best Player is: "+relatedObjects);
				
				//fetchBestPlayer();
			});
		}
		public void AddToScore(double aAmount) {
			AddToScore(Convert.ToInt32(aAmount));
		}
		
		public void AddToScore(int aAmount) {
			Debug.Log ("&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&& AddToScore: "+aAmount+" - "+rankingObject);
			if(rankingObject==null) {
				rankingObject = new ParseObject("TMRank");
				rankingObject["name"] = PlayerMain.REF.multiplayerName;
				rankingObject["score"] = aAmount;
				
			} else {
				int score = rankingObject.Get<int>("score");
				score += aAmount;
				rankingObject["score"] = score;
			}
			rankingObject.SaveAsync().ContinueWith(t =>
			                                       {
				// Now let's update it with some new data.  In this case, only cheatMode
				// and score will get sent to the cloud.  playerName hasn't changed.
				SavePlayerData();
				fetchRank ();
			});
		}
		public bool SavedGameExists(int aIndex) {
			return ES2.Exists(aIndex+DATA_NAME);
		}
		public void saveItems(string aString) {
			playerData[(int) EPlayerArray.Items] = aString;
			if(isCloudGame()) {
				ParseUser u = ParseUser.CurrentUser;
				u["Items"] = aString;
				this._requireSave = true;
			}
			SavePlayerData();
		}
		public void saveMonsters(string aString,int aMonsterCount,string aXPBoostData,string aRepelBoostData) {
			if(aMonsterCount==0&&!isCloudGame()) {
			//	Debug.LogError("Trying to save monsters when monsters is zero!");
			} else {
			int secondsSinceMillenium = Convert.ToInt32((DateTime.Now-millenium).TotalSeconds);
			
			playerData[(int) EPlayerArray.Monsters] = aString+"|"+secondsSinceMillenium;
			playerData[(int) EPlayerArray.MonsterCount] = aMonsterCount.ToString();;
			playerData[(int) EPlayerArray.XPBoostData] = aXPBoostData;
			playerData[(int) EPlayerArray.RepelBoostData] = aRepelBoostData;
			if(isCloudGame()) {
				ParseUser u = ParseUser.CurrentUser;
				u["Monsters"] = aString+"|"+secondsSinceMillenium;
				u["MonsterCount"] = aMonsterCount.ToString();;
				u["RepelData"] = aRepelBoostData;
				u["XPBoostData"] = aXPBoostData;
				this._requireSave = true;
			}
			
			SavePlayerData();
			}
		}
		
		public void saveBoostAndRepelData(string aXPBoostData,string aRepelData) {
			
			playerData[(int) EPlayerArray.XPBoostData] = aXPBoostData;
			playerData[(int) EPlayerArray.RepelBoostData] = aRepelData;
			SavePlayerData();
			if(isCloudGame()) {
				ParseUser u = ParseUser.CurrentUser;
				u["RepelData"] = aRepelData;
				u["XPBoostData"] = aXPBoostData;
				this._requireSave = true;
			}
			
		}
		public void SaveStatsAndQuests() {
			QuestState state = QuestLog.GetQuestState("Select_a_Starter_Monster");
			if(state == QuestState.Success||isCloudGame()) {
			
				try {
					string data = PersistentDataManager.GetSaveData();
					Debug.Log ("Saving data is: "+data);
					Lua.Result r = DialogueLua.GetVariable("NPCBattlesWon");
					
					if(data!=null&&data.Length!=0&&r.AsInt>0) {
						string compressed = Base64Compressor.Base64Encode(data);
						this.lastGoodQuestData = compressed;
						Debug.Log("After compression this data is: "+data);
						playerData[(int) EPlayerArray.Quests] = compressed;
					} else {
						Debug.Log ("Quest Data was no good!");
						throw new Exception("Quest Data was null");
					}
			//	if((compressed.Length<data.Length)||(data.Length<50)) {
				} catch(Exception e) {
					Debug.Log ("Using last good data");
					playerData[(int) EPlayerArray.Quests] = lastGoodQuestData;
				}
				_requireDiskUpdate = true;
			//	} else {
			//		Debug.LogError("Compressing data made it bigger!");
			//	}
				if(isCloudGame()) {
					ParseUser u = ParseUser.CurrentUser;
					u["QuestData"] = lastGoodQuestData;
					this._requireSave = true;
				}
			}
		}
		public List<string> SetCloudData(string aUsername,string aPassword,string aEMail) {
			playerData[(int) EPlayerArray.Name] = aUsername;
			playerData[(int) EPlayerArray.Password] = aPassword;
			playerData[(int) EPlayerArray.EMail] = aEMail;
			SavePlayerData();
			return playerData;
		}
		private void initEmptyPlayerDataArray() {
			_playerData = new List<string>();
			for(int i = 0;i<(int) EPlayerArray.ArrayLength;i++) {
				_playerData.Add("");
			}
		}
		public List<string> playerData {
			get {
				if(_playerData == null ) {
					
					if(SavedGameExists(USING_SAVE_GAME_INDEX)) {
						try {
							_playerData = ES2.LoadList<string>(USING_SAVE_GAME_INDEX+DATA_NAME);
						} catch (Exception e) {
							Debug.Log("Player Data Not loadable: "+e);
							initEmptyPlayerDataArray();
						}
					} else {
						_playerData = new List<string>();
						for(int i = 0;i<(int) EPlayerArray.ArrayLength;i++) {
							_playerData.Add("");
							initEmptyPlayerDataArray();
						}
					}
				}
				while(_playerData.Count<(int) EPlayerArray.ArrayLength) {
					_playerData.Add("");
				}
				return _playerData;
			}
		}
		
		public List<string> getPlayerDataFromIndex(int aIndex) {
			try {
				return ES2.LoadList<string>(aIndex+DATA_NAME);
			} catch (Exception e) {
				return null;
			}	
		}
		public void removePlayerDataFromIndex(int aIndex) {
			try {
				ES2.Delete(aIndex+DATA_NAME);
			} catch(Exception e) {
			
			}
		}
		public bool isCloudGame() {
			return (playerData[(int) EPlayerArray.EMail])!=""&&(ParseUser.CurrentUser!=null);
		}
		public void SavePlayerData() {
			_requireDiskUpdate = true;
			if(PlayerMain.REF!=null) {
				playerData[(int) EPlayerArray.SoftCurrency] = "s"+PlayerMain.REF.softCurrency.ToString();
				playerData[(int) EPlayerArray.HardCurrency] = "h"+PlayerMain.REF.hardCurrency.ToString();
			}
			if(isCloudGame()) {
				DialogueLua.SetVariable("hasCloud",true);
				if(rankingObject!=null) {
					playerData[(int) EPlayerArray.RankingObjID] = rankingObject.ObjectId;
				}
				ParseUser u = ParseUser.CurrentUser;
				u["Gender"] = playerData[(int) EPlayerArray.Gender];
				u["SoftCurrency"] = playerData[(int) EPlayerArray.SoftCurrency];
				u["HardCurrency"] = playerData[(int) EPlayerArray.HardCurrency];
				u["OfflineUnlocked"] = this.offlineUnlocked;
				if(rankingObject!=null&&this.rankingObject.ObjectId.Length>0) {
					u["RankingObj"] = rankingObject.ObjectId;
				}
				_requireSave = true;
			} else {
				DialogueLua.SetVariable("hasCloud",false);
			}
		}
		public string[] PlayerArray(int aIndex) {
			if(SavedGameExists(aIndex)) {
				string[] playerData = ES2.LoadArray<string>(aIndex+DATA_NAME);
				return playerData;
			}
			return null;
		}
		
		
		public void Update() {
			if(this._handleCloudRetrieve) {
				ParseUser u = ParseUser.CurrentUser;
				playerData[(int) EPlayerArray.Name] = u.Username;
				playerData[(int) EPlayerArray.EMail] = u.Email;
				playerData[(int) EPlayerArray.Password] = Password;
				var gender = u["Gender"];
				var hardCurrency = u["HardCurrency"];
				var lastMap = u["LastMap"];
				var monsters = u["Monsters"];
				var quests = u["QuestData"];
				var softCurrency = u["SoftCurrency"];
				var monsterCount = u["MonsterCount"];
				var items = u["Items"];
				var repelData = u["RepelData"];
				var xpBoostData = u["XPBoostData"];
				if(this.offlineUnlocked==false) {
					var offline = u["OfflineUnlocked"];
					this.offlineUnlocked = Convert.ToBoolean(offline);
				}
				playerData[(int) EPlayerArray.Gender] = Convert.ToUInt32(0).ToString();
				playerData[(int) EPlayerArray.HardCurrency] = hardCurrency.ToString();
				playerData[(int) EPlayerArray.SoftCurrency] = softCurrency.ToString();
				playerData[(int) EPlayerArray.RepelBoostData] = repelData.ToString();
				playerData[(int) EPlayerArray.XPBoostData] = xpBoostData.ToString();
				playerData[(int) EPlayerArray.LastUsedMap] = (string) u["LastMap"];
				playerData[(int) EPlayerArray.Monsters] = (string) u["Monsters"];
				playerData[(int) EPlayerArray.MonsterCount] = Convert.ToInt32(monsterCount).ToString();
				playerData[(int) EPlayerArray.Quests] = (string) u["QuestData"];
				playerData[(int) EPlayerArray.Items] = (string) u["Items"];
				if(u.ContainsKey("RankingObj"))
					playerData[(int) EPlayerArray.RankingObjID] = (string) u["RankingObj"];
				_requireDiskUpdate = false;
				ES2.Save(this.playerData,USING_SAVE_GAME_INDEX+DATA_NAME);
				
				_handleCloudRetrieve = false;
				Application.LoadLevel("LoadAGameSplashScreen");
				
			} 
			
			if (PlayerMain.REF == null) {

				return;
			} else {
				if(this.playerData[(int) EPlayerArray.Quests].Length<50&&PlayerMain.REF.monsterCount>0)
					return;
			}
			float timeNow = Time.time;
			if((_requireSave)&&(timeNow-_lastCloudUpdate>SECONDS_BETWEEN_UPDATE)) {
				_requireSave = false;
				ParseUser p = ParseUser.CurrentUser;
				if(p!=null)
					p.SaveAsync();
				_lastCloudUpdate = timeNow;
			}
			if((_requireDiskUpdate)&&(timeNow-_lastDiskUpdate>SECONDS_BETWEEN_DISK_UPDATE)) {
				_requireDiskUpdate = false;
				if(playerData[(int) EPlayerArray.Monsters].Length<5) {
					PlayerMain.REF.saveMonsters();
					_requireDiskUpdate = true;
					return;
				}
				
				if(playerData[(int) EPlayerArray.Items].Length<2&&PlayerMain.REF.hasItems()) {
					PlayerMain.REF.saveInventory();
					_requireDiskUpdate = true;
					return;
				}

				QuestState qs = QuestLog.GetQuestState("Save_the_Town");
				if(qs==QuestState.Success||((this.isCloudGame()&&PlayerMain.REF.monsterCount<=1))) {
					ES2.Save(this.playerData,USING_SAVE_GAME_INDEX+DATA_NAME);
				}
			} 

		}
		public void UpdateLastMap(string aLastMap) {
			playerData[(int) EPlayerArray.LastUsedMap] = aLastMap;
			SavePlayerData();
			if(isCloudGame()) {
				ParseUser u = ParseUser.CurrentUser;
				u["LastMap"] = playerData[(int) EPlayerArray.LastUsedMap];
				this._requireSave = true;
			} 
		}
		
	}
}

