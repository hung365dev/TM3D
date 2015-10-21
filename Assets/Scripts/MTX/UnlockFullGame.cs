using System;
using UnityEngine;


namespace MTX
{
	public class UnlockFullGame : MonoBehaviour
	{
		public static bool _isInited = false;
		public UnlockFullGameItem[] items;
		
		public UILabel smallPackage;
		public UILabel mediumPackage;
		public UILabel largePackage;
		
		public delegate void OnClose();
		public event OnClose onClosedUnlock;
		
		public UILabel smallPackageLabel;
		public UILabel mediumPackageLabel;
		public UILabel largePackageLabel;
		
		public UIButton smallPackageBtn;
		public UIButton mediumPackageBtn;
		public UIButton largePackageBtn;
		public UnlockFullGame ()
		{
		}
		
		public void onClose() {
			if(this.onClosedUnlock!=null) {
				onClosedUnlock();
			}
			Destroy (this.gameObject);
		}
		
		public void reinit() {
	/*		PurchasableItem backpacker = Unibiller.GetPurchasableItemById("com.socialtitans.terramonsters2.backpacker");
			smallPackage.text = backpacker.localizedPriceString;
			
			PurchasableItem adventurer = Unibiller.GetPurchasableItemById("com.socialtitans.terramonsters2.adventurer");
			mediumPackage.text = adventurer.localizedPriceString;
			
			PurchasableItem rancher = Unibiller.GetPurchasableItemById("com.socialtitans.terramonsters2.rancher");
			largePackage.text = rancher.localizedPriceString;
			
			
			bool backpackerOwned = Unibiller.GetPurchaseCount(backpacker)>0;
			bool adventurerOwned = Unibiller.GetPurchaseCount(adventurer)>0;
			bool rancherOwned = Unibiller.GetPurchaseCount(rancher)>0;
			if(rancherOwned||adventurerOwned||backpackerOwned) {
				smallPackageLabel.text = "OWNED!";
				smallPackageBtn.isEnabled = false;
			}
			if(rancherOwned||adventurerOwned) {
				mediumPackageLabel.text = "OWNED!";
				this.mediumPackageBtn.isEnabled = false;
			}
			if(rancherOwned) {
				largePackageLabel.text = "OWNED!";
				this.largePackageBtn.isEnabled = false;
			}*/
		}
		public void Start()  {
			this.gameObject.name = "UnlockFullGame";
			reinit ();
			
		}
		public void onBuySmallBag() {
		//	Unibiller.initiatePurchase("com.socialtitans.terramonsters2.backpacker");
		}
		public void onBuyBigBag() {
		//	Unibiller.initiatePurchase("com.socialtitans.terramonsters2.adventurer");
		}
		public void onBuyMassiveChest() {
		//	Unibiller.initiatePurchase("com.socialtitans.terramonsters2.rancher");
		}
		
		public void OnDestroy() {
			
		}
			public static bool isInited {
				get {
					return _isInited;
				}
			}
			
		 
			
			
	}
}

