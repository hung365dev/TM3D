using System;
using Battles;
using Player;
using UnityEngine;


public class PlayerWithMultiplayer : PlayerWithInventory
{
	private string _multiplayerName = "";
	private string _multiplayerPass = "";
	public PlayerWithMultiplayer ()
	{
		base.PlayerDataWithMonsters();
	}
	
	public string multiplayerName {
		get {
			return _multiplayerName;
		}
		set {
			_multiplayerName = value;
		}
	}
	public string multiplayerPass {
		get {
			return _multiplayerPass;
		}
		set {
			_multiplayerPass = value;
		}
	}
	
	public void doMultiplayerLoginCheck() {
		Debug.Log("*!*!*!*!*!*!**!*!*!*!*!*! Doing Multiplayer login check: "+_multiplayerName+","+_multiplayerPass);
		//SmartfoxHandlerConnectForCheckOnly.REF.ConnectForCheck();
	}
	/*public SFSObject multiplayerBattleTeam {
		get {
			SFSObject obj = new SFSObject();
			obj.PutUtfString("name",this._multiplayerName);
			obj.PutInt("id",SmartfoxHandler.REF.userID);
			BetterList<MonsterDataMain> monsters = this.battleMonsters;
			SFSArray ms = new SFSArray();
			for(int i = 0;i<monsters.size;i++) {
				if(monsters[i]!=null) {
					ms.AddSFSObject(monsters[i].toSFSObject(null));
				} else {
					ms.AddSFSObject(new SFSObject());
				}
			}
			obj.PutSFSArray("monsters",ms);
			SmartfoxHandler.REF.addRandomsToObj(obj);
			return obj;
		} 
	}*/
	///Initialises Player Data with some debug data, 3 monsters and a basic inventory
	public virtual void initForDebug() {
		base.initForDebug();
	}
	
	public virtual void saveAll() {
		
	}
	
	
}

