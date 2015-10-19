using System;
[Flags]
public enum EOwnershipStatus
{
	Wild = 0x01,
	LocalPlayerOwned = 0x02,
	NPCOwned = 0x04,
	ForeignPlayerOwned = 0x08,
}