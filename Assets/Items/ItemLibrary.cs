using UnityEngine;
using System.Collections;
using Google2u;
using Items;


public class ItemLibrary {
	public static ItemLibrary REF = new ItemLibrary();
	
	public VitaminsLibrary vitLibrary = new VitaminsLibrary();
	public RecoveryLibrary recoveryLibrary = new RecoveryLibrary();
	public BaitsLibrary baitsLibrary = new BaitsLibrary();
	public BattleBoostLibrary boostLibrary = new BattleBoostLibrary();
	public PlayerBoostsLibrary playerBoostsLibrary = new PlayerBoostsLibrary();
	public ItemLibrary() {
		
	}
	public ITMItem getItemFromName(string aName) {
		if(vitLibrary.itemByName(aName)!=null) {
			return vitLibrary.itemByName(aName);
		}
		
		if(recoveryLibrary.itemByName(aName)!=null) {
			return recoveryLibrary.itemByName(aName);
		}
		
		if(baitsLibrary.itemByName(aName)!=null) {
			return baitsLibrary.itemByName(aName);
		}
		
		if(boostLibrary.itemByName(aName)!=null) {
			return boostLibrary.itemByName(aName);
		}
		
		if(playerBoostsLibrary.itemByName(aName)!=null) {
			return playerBoostsLibrary.itemByName(aName);
		}
		return null;
		
	}
	public ITMItem getItemFromTypeAndID(EItemType aType,int aID) {
		switch(aType) {
			case(EItemType.Vitamin):return vitLibrary.itemByID(aID);
			case(EItemType.Recovery):return recoveryLibrary.itemByID(aID);
			case(EItemType.Bait):return baitsLibrary.itemByID(aID);
			case(EItemType.BattleBoost):return boostLibrary.itemByID(aID);
			case(EItemType.PlayerBoost):return playerBoostsLibrary.itemByID(aID);
		}
		return null;
	}
	public BetterList<ITMItem> getRandomItems(int aItemCount) {
		BetterList<ITMItem> r = new BetterList<ITMItem>();
		while(aItemCount>0) {
			r.Add(randomLibrary().randomItem());
			aItemCount--;
		}
		return r;
	}
	
	public BetterList<ITMItem> allItems {
		get {
			BetterList<ITMItem> r = new BetterList<ITMItem>();
			vitLibrary.addItemsTo(r);
			recoveryLibrary.addItemsTo(r);
			baitsLibrary.addItemsTo(r);
			boostLibrary.addItemsTo(r);
			playerBoostsLibrary.addItemsTo(r);
			return r;
		}
	}
	public ITMItemLibrary randomLibrary() {
		int rand = Random.Range(0,3);
		switch(rand) {
			case(0):default:
						return vitLibrary;
			case(1):
					return recoveryLibrary;
			case(2):
					return baitsLibrary;
			case(3):
					return boostLibrary;
		}
	}
}
