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
namespace Items
{
	public class RecoveryTriplet
	{
		public EItemRecoveryType recoveryType;
		public EItemRecoveryArea recoveryArea;
		public float healAmount = 0.0f;
		public RecoveryTriplet (string aRecoverArea,string aRecoverType,float aValue)
		{
			/*
			HP,Energy,Heal All Status,Heal Burn,Heal Freeze,Heal Confusion,Heal Paralyzed,Heal Poison
			*/
			switch(aRecoverArea) {
				case("HP"):recoveryArea = EItemRecoveryArea.HP;break;
				case("Energy"):recoveryArea = EItemRecoveryArea.Energy;break;
				case("Heal All Status"):recoveryArea = EItemRecoveryArea.HealAllStatus;break;
				case("Heal Burn"):recoveryArea = EItemRecoveryArea.Burn;break;
				case("Heal Freeze"):recoveryArea = EItemRecoveryArea.Freeze;break;
				case("Heal Confusion"):recoveryArea = EItemRecoveryArea.Confusion;break;
				case("Heal Paralyzed"):recoveryArea = EItemRecoveryArea.Paralyzed;break;
				case("Heal Poisoned"):recoveryArea = EItemRecoveryArea.Poison;break;
			}
			
			switch(aRecoverType) {
				
				case("HealValue"):recoveryType = EItemRecoveryType.HealValue;break;
				case("HealPercentage"):recoveryType = EItemRecoveryType.HealPercentage;break;
				case("DamagePercentage"):recoveryType = EItemRecoveryType.DamagePercentage;break;
				case("DamageValue"):recoveryType = EItemRecoveryType.DamageValue;break;
			}
			healAmount = aValue;
		}
	}
}

