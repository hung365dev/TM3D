using System;
using UnityEngine;
using System.Collections.Generic;
using Utils;
using utils;
using System.Collections;


namespace MTX
{
	public class MTXManager : MonoBehaviour
	{
		public static MTXManager REF;
		public MTXManager ()
		{
		}

		
		public void Start() {
			if(REF!=null) {
				return; 
			}
			StartCoroutine(delayToInitUnibill());
			REF = this;
			DontDestroyOnLoad(this);
		}
		/// <summary>
		/// This will be called after a call to Unibiller.restoreTransactions().
		/// </summary>
		private IEnumerator delayToInitUnibill() {
			yield return new WaitForSeconds(0.25f); 
		
		}
		public bool ownsOffline() {

		
			return false;
		}

		public bool ownsBackpacker() {
			return false;
		}
		public bool ownsRancher() {
			return false;
		}
		public bool ownsAdventurer() {
			return false;
		}
		public bool ownsRoboHeckyll() {
		/*
			bool handfulOwned = Unibiller.GetPurchaseCount(handful)>0;
			bool smallBagOwned = Unibiller.GetPurchaseCount(smallBag)>0;
			bool bigBagOwned = Unibiller.GetPurchaseCount(bigBag)>0;
			if(handfulOwned||smallBagOwned||bigBagOwned) {
				smallPackageLabel.text = "OWNED!";
				smallPackageBtn.isEnabled = false;
			}
			if(smallBagOwned||bigBagOwned) {
				mediumPackageLabel.text = "OWNED!";
				this.mediumPackageBtn.isEnabled = false;
			}
			if(bigBagOwned) {
				largePackageLabel.text = "OWNED!";
				this.largePackageBtn.isEnabled = false;
			}
		*/

			return false;
		}
		private void onTransactionsRestored (bool success) {

		}
		/// <summary>
		/// This will be called if a user opts to cancel a purchase
		/// after going to the billing system's purchase menu.
		/// </summary>
	/*	private void onCancelled(PurchasableItem item) {
			Debug.Log("Purchase cancelled: " + item.Id);
		}

		public void consumeStoredCurrency() {
			
			decimal d = Unibiller.GetCurrencyBalance("TerraDollars");
			if(d>0) {
				if(PlayerMain.REF!=null) {
					PlayerMain.REF.changeHardCurrency(Convert.ToInt32(d));
					Unibiller.DebitBalance("TerraDollars",d);
				}
			}
			d = Unibiller.GetCurrencyBalance("TerraCoins");
			if(d>0) {
				if(PlayerMain.REF!=null) {
					PlayerMain.REF.changeSoftCurrency(Convert.ToInt32(d));
					Unibiller.DebitBalance("TerraCoins",d);
				}
			}
		}
		/// <summary>
		/// This will be called when a purchase completes.
		/// </summary>
		private void onPurchased(PurchaseEvent e) {
			Debug.Log("Purchase OK: " + e.PurchasedItem.Id);
			Debug.Log ("Receipt: " + e.Receipt);
			consumeStoredCurrency();
			Debug.Log(string.Format ("{0} has now been purchased {1} times.",
			                         e.PurchasedItem.name,
			                         Unibiller.GetPurchaseCount(e.PurchasedItem)));
				
		
			switch(e.PurchasedItem.name.ToLower()) {
				default:
				AlertGUI.REF.DoGeneralAlert(e.PurchasedItem.name+" Purchased!","You have bought: "+e.PurchasedItem.name+" this will now be added to your account");
				break;
				case("backpacker"):
					SaveGameUtils.REF.offlineUnlocked = true;
					AlertGUI.REF.DoGeneralAlert(e.PurchasedItem.name+" Purchased!","Congratulations, you are now a Backpacker! This package will be stored permanently to your account.");
				
					Unibiller.CreditBalance("TerraCoins",1000);
				break; 
				case("adventurer"):
					SaveGameUtils.REF.offlineUnlocked = true;
					Unibiller.CreditBalance("TerraDollars",1000);
					Unibiller.CreditBalance("TerraCoins",2000);
					SaveGameUtils.REF.pollBalances = true;
					AlertGUI.REF.DoGeneralAlert(e.PurchasedItem.name+" Purchased!","Congratulations, you are now an Adventurer! This package will be stored permanently to your account.");
				
				
				break;
				case("rancher"):
					SaveGameUtils.REF.offlineUnlocked = true;
					Unibiller.CreditBalance("TerraDollars",4000);
					Unibiller.CreditBalance("TerraCoins",10000);
					SaveGameUtils.REF.pollBalances = true;
					AlertGUI.REF.DoGeneralAlert(e.PurchasedItem.name+" Purchased!","Congratulations, you are now a Rancher! This package will be stored permanently to your account.");
				break;
			}
			
			GameObject g= GameObject.Find("UnlockFullGame");
			if(g!=null) {
				UnlockFullGame ufg = g.GetComponent<UnlockFullGame>();
				ufg.reinit();
			}
			
			try { 
				
				UnityAnalytics.Transaction(e.PurchasedItem.Id, e.PurchasedItem.localizedPrice, e.PurchasedItem.isoCurrencySymbol, e.PurchasedItem.receipt, null);
			} catch(Exception err) {
			}
		}
		
		private void onBillerReady(UnibillState aState) {
			Debug.Log ("UniBiller State now: "+aState.ToString());
			billingAvailable = aState;
		}	
		*/
		
	}
}

