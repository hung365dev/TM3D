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
	[Flags]
	public enum EItemRecoveryArea
	{
		HP = 0x01,
		Energy = 0x02,
		Burn = 0x04,
		Freeze = 0x08,
		Confusion =0x16,
		Paralyzed = 0x32,
		Poison = 0x64,
		XP = 0x128,
		HealAllStatus = Poison|Paralyzed|Confusion|Freeze|Burn,
	}
}
