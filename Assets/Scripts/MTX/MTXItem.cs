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
namespace MTX
{
	[System.Serializable]
	public class MTXItem
	{
		public string name;
		public int gameUnlock;
		public int monsterID;
		public int softCurrency;
		public int hardCurrency;
		
		
		public void apply() {
			if(PlayerMain.REF!=null) {
				PlayerMain.REF.changeHardCurrency(hardCurrency);
				PlayerMain.REF.changeSoftCurrency(softCurrency);
				
			}
		}
		
	}
}
