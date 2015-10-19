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


namespace MTX
{
	public class BuyMoreTerraDollars : MonoBehaviour
	{
		public UILabel handfulPrice;
		public UILabel smallBagPrice;
		public UILabel bigBagPrice;
		public UILabel massiveChestPrice;
		public delegate void OnClosedEvent();
		
		
		public event OnClosedEvent onClosed; 
		public BuyMoreTerraDollars ()
		{
		}
		
		public void Start() {
			this.gameObject.name = "BuyMoreTerraDollars";
			PurchasableItem handful = Unibiller.GetPurchasableItemById("com.socialtitans.terramonsters2.handful");
			handfulPrice.text = handful.localizedPriceString;
			
			PurchasableItem smallBag = Unibiller.GetPurchasableItemById("com.socialtitans.terramonsters2.smallbag");
			smallBagPrice.text = smallBag.localizedPriceString;

			PurchasableItem bigBag = Unibiller.GetPurchasableItemById("com.socialtitans.terramonsters2.bigbag");
			bigBagPrice.text = bigBag.localizedPriceString;
			
			PurchasableItem massiveChest = Unibiller.GetPurchasableItemById("com.socialtitans.terramonsters2.massivechest");
			massiveChestPrice.text = massiveChest.localizedPriceString;
			
			
		/*	UM_InAppProduct handful = UM_InAppPurchaseManager.instance.GetProductById("Handful");
			Debug.Log(handful.AndroidId+" - "+handful.Price);
			if(handful!=null) {
				handfulPrice.text = handful.Price;
				
			}
			
			UM_InAppProduct smallBag = UM_InAppPurchaseManager.instance.GetProductById("Small Bag");
			if(smallBag!=null)
				smallBagPrice.text = smallBag.Price;

			UM_InAppProduct bigBag = UM_InAppPurchaseManager.instance.GetProductById("Big Bag");
			if(bigBag!=null)
				bigBagPrice.text = bigBag.Price;
			
			UM_InAppProduct massiveChest = UM_InAppPurchaseManager.instance.GetProductById("Massive Chest");
			if(massiveChest!=null)
				massiveChestPrice.text = massiveChest.Price;*/
			
		}
		public void restorePurchasesClick() {
			Unibiller.restoreTransactions();
		}
		public void OnClose() {
			if(this.onClosed!=null) {
				onClosed();
			}
			Destroy(this.gameObject);
		}
		public void onBuyHandful() {
			Unibiller.initiatePurchase("com.socialtitans.terramonsters2.handful");
		}
		public void onBuySmallBag() {
			
			Unibiller.initiatePurchase("com.socialtitans.terramonsters2.smallbag");
		}
		public void onBuyBigBag() {
			
			Unibiller.initiatePurchase("com.socialtitans.terramonsters2.bigbag");
		}
		public void onBuyMassiveChest() {
			
			Unibiller.initiatePurchase("com.socialtitans.terramonsters2.massivechest");
			
		}
	}
}

