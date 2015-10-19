//----------------------------------------------
//    Google2u: Google Doc Unity integration
//         Copyright © 2015 Litteratus
//
//        This file has been auto-generated
//              Do not manually edit
//----------------------------------------------

using UnityEngine;
using System.Globalization;

namespace Google2u
{
	[System.Serializable]
	public class MoveAnimationNamesRow : IGoogle2uRow
	{
		public int _ID;
		public string _MoveAnimations;
		public string _AnimType;
		public string _PrefabName;
		public float _MoveOnSeconds;
		public string _MovementType;
		public float _XOffset;
		public float _YOffset;
		public float _YRotationForLeftMove;
		public float _YRotationForRightMove;
		public MoveAnimationNamesRow(string __GOOGLEFU_ID, string __ID, string __MoveAnimations, string __AnimType, string __PrefabName, string __MoveOnSeconds, string __MovementType, string __XOffset, string __YOffset, string __YRotationForLeftMove, string __YRotationForRightMove) 
		{
			{
			int res;
				if(int.TryParse(__ID, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_ID = res;
				else
					Debug.LogError("Failed To Convert _ID string: "+ __ID +" to int");
			}
			_MoveAnimations = __MoveAnimations.Trim();
			_AnimType = __AnimType.Trim();
			_PrefabName = __PrefabName.Trim();
			{
			float res;
				if(float.TryParse(__MoveOnSeconds, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_MoveOnSeconds = res;
				else
					Debug.LogError("Failed To Convert _MoveOnSeconds string: "+ __MoveOnSeconds +" to float");
			}
			_MovementType = __MovementType.Trim();
			{
			float res;
				if(float.TryParse(__XOffset, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_XOffset = res;
				else
					Debug.LogError("Failed To Convert _XOffset string: "+ __XOffset +" to float");
			}
			{
			float res;
				if(float.TryParse(__YOffset, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_YOffset = res;
				else
					Debug.LogError("Failed To Convert _YOffset string: "+ __YOffset +" to float");
			}
			{
			float res;
				if(float.TryParse(__YRotationForLeftMove, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_YRotationForLeftMove = res;
				else
					Debug.LogError("Failed To Convert _YRotationForLeftMove string: "+ __YRotationForLeftMove +" to float");
			}
			{
			float res;
				if(float.TryParse(__YRotationForRightMove, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_YRotationForRightMove = res;
				else
					Debug.LogError("Failed To Convert _YRotationForRightMove string: "+ __YRotationForRightMove +" to float");
			}
		}

		public int Length { get { return 10; } }

		public string this[int i]
		{
		    get
		    {
		        return GetStringDataByIndex(i);
		    }
		}

		public string GetStringDataByIndex( int index )
		{
			string ret = System.String.Empty;
			switch( index )
			{
				case 0:
					ret = _ID.ToString();
					break;
				case 1:
					ret = _MoveAnimations.ToString();
					break;
				case 2:
					ret = _AnimType.ToString();
					break;
				case 3:
					ret = _PrefabName.ToString();
					break;
				case 4:
					ret = _MoveOnSeconds.ToString();
					break;
				case 5:
					ret = _MovementType.ToString();
					break;
				case 6:
					ret = _XOffset.ToString();
					break;
				case 7:
					ret = _YOffset.ToString();
					break;
				case 8:
					ret = _YRotationForLeftMove.ToString();
					break;
				case 9:
					ret = _YRotationForRightMove.ToString();
					break;
			}

			return ret;
		}

		public string GetStringData( string colID )
		{
			var ret = System.String.Empty;
			switch( colID )
			{
				case "ID":
					ret = _ID.ToString();
					break;
				case "MoveAnimations":
					ret = _MoveAnimations.ToString();
					break;
				case "AnimType":
					ret = _AnimType.ToString();
					break;
				case "PrefabName":
					ret = _PrefabName.ToString();
					break;
				case "MoveOnSeconds":
					ret = _MoveOnSeconds.ToString();
					break;
				case "MovementType":
					ret = _MovementType.ToString();
					break;
				case "XOffset":
					ret = _XOffset.ToString();
					break;
				case "YOffset":
					ret = _YOffset.ToString();
					break;
				case "YRotationForLeftMove":
					ret = _YRotationForLeftMove.ToString();
					break;
				case "YRotationForRightMove":
					ret = _YRotationForRightMove.ToString();
					break;
			}

			return ret;
		}
		public override string ToString()
		{
			string ret = System.String.Empty;
			ret += "{" + "ID" + " : " + _ID.ToString() + "} ";
			ret += "{" + "MoveAnimations" + " : " + _MoveAnimations.ToString() + "} ";
			ret += "{" + "AnimType" + " : " + _AnimType.ToString() + "} ";
			ret += "{" + "PrefabName" + " : " + _PrefabName.ToString() + "} ";
			ret += "{" + "MoveOnSeconds" + " : " + _MoveOnSeconds.ToString() + "} ";
			ret += "{" + "MovementType" + " : " + _MovementType.ToString() + "} ";
			ret += "{" + "XOffset" + " : " + _XOffset.ToString() + "} ";
			ret += "{" + "YOffset" + " : " + _YOffset.ToString() + "} ";
			ret += "{" + "YRotationForLeftMove" + " : " + _YRotationForLeftMove.ToString() + "} ";
			ret += "{" + "YRotationForRightMove" + " : " + _YRotationForRightMove.ToString() + "} ";
			return ret;
		}
	}
	public sealed class MoveAnimationNames : IGoogle2uDB
	{
		public enum rowIds {
			AT_NONE, AT_GROUNDHITBROWN, AT_GROUNDHITGREY, AT_GROUNDHITWOOD, AT_SPARKSBLUE, AT_WWExplosion, AT_WWExplosionBlue, AT_PickupHeart, AT_PickupHeart2, AT_PickupHeart3, AT_PickupSkull, AT_PickupStar, AT_PickupStar2, AT_CartoonFight, AT_CartoonFight2, AT_PowerAura, AT_ShinyItem, AT_DeathSkull
			, AT_DeathGhost, AT_SkullEyes, AT_SkullRotate, AT_ArcaneSkull, AT_SoulEscape, AT_RedSoulEscape, AT_GoldenSkull, AT_PoisonSkull, AT_PoisonSkullGround, AT_SplashDrop, AT_FireBall1, AT_FireBallPurple, AT_BlackFireBall, AT_FireWall, AT_GreenFireWall, AT_BlackFireWall, AT_PowerupDiamond, AT_BatsEscape, AT_PoisonCloud, AT_HeartBreak
			, AT_SoulsEscape2, AT_RainbowSoulsEscape, AT_SoulGasCloud, AT_FallingLeaves, AT_FallingLeavesBrown, AT_FireBall2, AT_FireRain1, AT_ElectricSpark1, AT_ElectricSparkGround, AT_FireHit, AT_FireHitGround, AT_FireHitB, AT_FireHitGroundB, AT_IceHitA, AT_IceHitB, AT_IceHitGround, AT_LeavesHitAir, AT_LeavesHitGround, AT_LightHit, AT_GreenLightHit
			, AT_StarryLightHit, AT_StarryArcaneHit, AT_StarryLightHitAir, AT_GreenMiscHit, AT_SmallBlueHit, AT_SmallGravityHit, AT_SmallArcaneBoost, AT_SmallCloudPuff, AT_IceBall, AT_LightBall, AT_LightBallB, AT_Resurrection, AT_LeaveWhirlwind, AT_ShieldRays, AT_ShieldRaysWhite, AT_ShieldRaysIntense, AT_ShieldRaysIntenseBlue, AT_SmokeColumn, AT_RedSmokeColumn, AT_VortexAir
			, AT_VortexTornado, AT_SparkFarSideOnly, AT_Flash, AT_Splash, AT_BubblesChoke, AT_SplashHuge, AT_FairyDust1, AT_FairyDust2, AT_FairyDust3, AT_DrillGroundHit, AT_DistruptiveForce, AT_BubblesWhirl, AT_Snowstorm, AT_ElectricBall1, AT_ElectricityBolt, AT_BlueSparksRanged, AT_VortextRed, AT_SandAttack, AT_SandAttack2, AT_FlameThrower
			, AT_IceThrower, AT_RainStorm, AT_WaterBall, AT_DirtBall, AT_FairyDust4
		};
		public string [] rowNames = {
			"AT_NONE", "AT_GROUNDHITBROWN", "AT_GROUNDHITGREY", "AT_GROUNDHITWOOD", "AT_SPARKSBLUE", "AT_WWExplosion", "AT_WWExplosionBlue", "AT_PickupHeart", "AT_PickupHeart2", "AT_PickupHeart3", "AT_PickupSkull", "AT_PickupStar", "AT_PickupStar2", "AT_CartoonFight", "AT_CartoonFight2", "AT_PowerAura", "AT_ShinyItem", "AT_DeathSkull"
			, "AT_DeathGhost", "AT_SkullEyes", "AT_SkullRotate", "AT_ArcaneSkull", "AT_SoulEscape", "AT_RedSoulEscape", "AT_GoldenSkull", "AT_PoisonSkull", "AT_PoisonSkullGround", "AT_SplashDrop", "AT_FireBall1", "AT_FireBallPurple", "AT_BlackFireBall", "AT_FireWall", "AT_GreenFireWall", "AT_BlackFireWall", "AT_PowerupDiamond", "AT_BatsEscape", "AT_PoisonCloud", "AT_HeartBreak"
			, "AT_SoulsEscape2", "AT_RainbowSoulsEscape", "AT_SoulGasCloud", "AT_FallingLeaves", "AT_FallingLeavesBrown", "AT_FireBall2", "AT_FireRain1", "AT_ElectricSpark1", "AT_ElectricSparkGround", "AT_FireHit", "AT_FireHitGround", "AT_FireHitB", "AT_FireHitGroundB", "AT_IceHitA", "AT_IceHitB", "AT_IceHitGround", "AT_LeavesHitAir", "AT_LeavesHitGround", "AT_LightHit", "AT_GreenLightHit"
			, "AT_StarryLightHit", "AT_StarryArcaneHit", "AT_StarryLightHitAir", "AT_GreenMiscHit", "AT_SmallBlueHit", "AT_SmallGravityHit", "AT_SmallArcaneBoost", "AT_SmallCloudPuff", "AT_IceBall", "AT_LightBall", "AT_LightBallB", "AT_Resurrection", "AT_LeaveWhirlwind", "AT_ShieldRays", "AT_ShieldRaysWhite", "AT_ShieldRaysIntense", "AT_ShieldRaysIntenseBlue", "AT_SmokeColumn", "AT_RedSmokeColumn", "AT_VortexAir"
			, "AT_VortexTornado", "AT_SparkFarSideOnly", "AT_Flash", "AT_Splash", "AT_BubblesChoke", "AT_SplashHuge", "AT_FairyDust1", "AT_FairyDust2", "AT_FairyDust3", "AT_DrillGroundHit", "AT_DistruptiveForce", "AT_BubblesWhirl", "AT_Snowstorm", "AT_ElectricBall1", "AT_ElectricityBolt", "AT_BlueSparksRanged", "AT_VortextRed", "AT_SandAttack", "AT_SandAttack2", "AT_FlameThrower"
			, "AT_IceThrower", "AT_RainStorm", "AT_WaterBall", "AT_DirtBall", "AT_FairyDust4"
		};
		public System.Collections.Generic.List<MoveAnimationNamesRow> Rows = new System.Collections.Generic.List<MoveAnimationNamesRow>();

		public static MoveAnimationNames Instance
		{
			get { return NestedMoveAnimationNames.instance; }
		}

		private class NestedMoveAnimationNames
		{
			static NestedMoveAnimationNames() { }
			internal static readonly MoveAnimationNames instance = new MoveAnimationNames();
		}

		private MoveAnimationNames()
		{
			Rows.Add( new MoveAnimationNamesRow("AT_NONE", "1", "No Animation", "Generic", "none", "0", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_GROUNDHITBROWN", "2", "Ground Rock Hit", "Hits", "CFXM2_GroundRockHit Brown", "0.2", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_GROUNDHITGREY", "3", "Ground Grey Hit", "Hits", "CFXM2_GroundRockHit Gray", "0.2", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_GROUNDHITWOOD", "4", "Ground Wood Hit", "Hits", "CFXM2_GroundWoodHit", "0.2", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_SPARKSBLUE", "5", "Blue Sparks", "Electric", "CFXM2_SparksHit Blue", "0.1", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_WWExplosion", "6", "Smokey Explosion", "Generic", "CFXM2_WWExplosion", "0.25", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_WWExplosionBlue", "7", "Smokey Blue Explosion", "Generic", "CFXM2_WWExplosion NoTrail Blue", "0.25", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_PickupHeart", "8", "Heart Pickup", "Generic", "CFXM2_PickupHeart", "0.1", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_PickupHeart2", "9", "Heart Pickup 2", "Generic", "CFXM2_PickupHeart2", "0.1", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_PickupHeart3", "10", "Heart Pickup 3", "Generic", "CFXM2_PickupHeart3", "0.1", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_PickupSkull", "11", "Skull Pickup 1", "Arcane", "CFXM2_PickupSkull", "0.1", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_PickupStar", "12", "Powerup Star", "Generic", "CFXM2_PickupStar", "0.1", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_PickupStar2", "13", "Powerup Star 2", "Generic", "CFXM2_PickupStar2", "0.1", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_CartoonFight", "14", "Cartoon Fight", "Generic", "CFXM2_CartoonFight", "0.5", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_CartoonFight2", "15", "Cartoon Fight Sparks", "Generic", "CFXM2_CartoonFightGround Alt Smoke", "0.5", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_PowerAura", "16", "Power Aura", "Generic", "CFXM2_PowerAura", "1", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_ShinyItem", "17", "Shiny Item", "Generic", "CFXM2_ShinyItem", "1", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_DeathSkull", "18", "Poison Skull", "Generic", "CFXM2_EnemyDeathSkull", "0.5", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_DeathGhost", "19", "Death Ghost", "Generic", "CFXM2_EnemyDeathGhost_Ground", "0.5", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_SkullEyes", "20", "Skull Eyes", "Arcane", "CFXM2_SkullEyes", "0.2", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_SkullRotate", "21", "Death Skull Rotate", "Arcane", "CFXM2_SkullRotate", "0.2", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_ArcaneSkull", "22", "Arcane Skull", "Arcane", "CFXM2_SkullResonance", "0.2", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_SoulEscape", "23", "Soul Escape", "Arcane", "CFXM2_Soul", "0.1", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_RedSoulEscape", "24", "Red Soul Escape", "Arcane", "CFXM2_Soul Red", "0.1", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_GoldenSkull", "25", "Golden Skull", "Arcane", "CFXM2_SkullEyes Yellow", "0.1", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_PoisonSkull", "26", "Poison Skull", "Generic", "CFXM2_EnemyDeathSkull_Ground Green", "0.1", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_PoisonSkullGround", "27", "Poison Skull Ground", "Generic", "CFXM2_EnemyDeathSkull_Ground Green", "0.1", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_SplashDrop", "28", "Splash Drops", "Water", "CFXM2_Splash_Drops", "0.2", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_FireBall1", "29", "Double Fireball", "Fire", "CFXM2_DoubleFireBall A", "1.5", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_FireBallPurple", "30", "Purple Fireball", "Fire", "CFXM2_DoubleFireBall B Purple", "0.5", "OriginToTarget", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_BlackFireBall", "31", "Black Fireball", "Fire", "CFXM2_DoubleFireBall C Black", "0.5", "OriginToTarget", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_FireWall", "32", "Firewall", "Fire", "CFXM2_DoubleFireWall B", "0.5", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_GreenFireWall", "33", "Green Firewall", "Fire", "CFXM2_DoubleFireWall C Green", "0.5", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_BlackFireWall", "34", "Black Firewall", "Fire", "CFXM2_DoubleFireWall A Black", "0.5", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_PowerupDiamond", "35", "Pickup Diamond", "Generic", "CFXM2_PickupDiamond", "0.5", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_BatsEscape", "36", "Bat Escapes", "Arcane", "CFXM2_BatsCloud", "1", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_PoisonCloud", "37", "Poison Cloud", "Generic", "CFXM2_PoisonCloud", "1", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_HeartBreak", "38", "Heart Break", "Generic", "CFXM2_BrokenHeart", "1", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_SoulsEscape2", "39", "Soul Escape 2", "Arcane", "CFXM2_SoulsEscape", "1", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_RainbowSoulsEscape", "40", "Rainbow Soul Escape", "Arcane", "CFXM2_SoulsEscape Rainbow", "1", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_SoulGasCloud", "41", "Poison Souls Cloud", "Arcane", "CFXM2_PoisonCloud Orange", "1", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_FallingLeaves", "42", "Falling Leaves", "Earth", "CFXM3_FallingLeaves", "3", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_FallingLeavesBrown", "43", "Leaves Thrower", "Earth", "CFXM3_FallingLeaves_Large (Brown)", "3", "OnOriginOnly", "0", "0", "90", "-90"));
			Rows.Add( new MoveAnimationNamesRow("AT_FireBall2", "44", "Moving Fireball", "Fire", "CFXM3_Fireball_A", "1", "OriginToTarget", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_FireRain1", "45", "Fire Rain", "Fire", "CFXM3_FireRain", "2", "Normal", "0", "12", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_ElectricSpark1", "46", "ElectroSpark", "Electric", "CFXM3_Hit_Electric_A_Air", "0.2", "Normal", "0", "0.5", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_ElectricSparkGround", "47", "ElectroSpark Ground", "Electric", "CFXM3_Hit_Electric_A_Ground", "0.3", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_FireHit", "48", "Fire Hit Air", "Hits", "CFXM3_Hit_Fire_A_Air", "0.2", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_FireHitGround", "49", "Fire Hit Ground", "Hits", "CFXM3_Hit_Fire_A_Ground", "0.2", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_FireHitB", "50", "Fire Hit Air B", "Hits", "CFXM3_Hit_Fire_B_Air", "0.2", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_FireHitGroundB", "51", "Fire Hit Ground B", "Hits", "CFXM3_Hit_Fire_B_Ground", "0.2", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_IceHitA", "52", "Ice Hit Air A", "Hits", "CFXM3_Hit_Ice_A_Air", "0.1", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_IceHitB", "53", "Ice Hit Air B", "Hits", "CFXM3_Hit_Ice_B_Air", "0.1", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_IceHitGround", "54", "Ice Hit Ground", "Hits", "CFXM3_Hit_Ice_B_Ground", "0.1", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_LeavesHitAir", "55", "Leaves Hit Air", "Hits", "CFXM3_Hit_Leaves_A_Air", "0.2", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_LeavesHitGround", "56", "Leaves Hit Ground", "Hits", "CFXM3_Hit_Leaves_A_Ground", "0.2", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_LightHit", "57", "Light Hit Air", "Hits", "CFXM3_Hit_Light_A_Air", "0.2", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_GreenLightHit", "58", "Light Hit Ground Green", "Hits", "CFXM3_Hit_Light_A_Ground (Green)", "0.2", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_StarryLightHit", "59", "Starry Light Hit", "Hits", "CFXM3_Hit_Light_B_Air", "0.2", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_StarryArcaneHit", "60", "Arcane Starry Hit", "Hits", "CFXM3_Hit_Light_B_Ground (Purple)", "0.2", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_StarryLightHitAir", "61", "Starry Light Hit Air", "Hits", "CFXM3_Hit_Light_C_Air", "0.2", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_GreenMiscHit", "62", "Plain Green Hit", "Hits", "CFXM3_Hit_Misc_A (Green)", "0.1", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_SmallBlueHit", "63", "Small Blue Hit", "Hits", "CFXM3_Hit_Misc_B (Blue)", "0.1", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_SmallGravityHit", "64", "Small Gravity Hit", "Hits", "CFXM3_Hit_Misc_B_Gravity", "0.1", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_SmallArcaneBoost", "65", "Small Arcane Boost", "Hits", "CFXM3_Hit_Misc_C", "0.1", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_SmallCloudPuff", "66", "Small Cloud Puff", "Hits", "CFXM3_Hit_SmokePuff", "0.1", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_IceBall", "67", "Ice Ball", "Ice", "CFXM3_IceBall_A", "0.4", "OriginToTarget", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_LightBall", "68", "Light Ball", "Generic", "CFXM3_LightBall_A", "0.4", "OriginToTarget", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_LightBallB", "69", "Light Ball B", "Generic", "CFXM3_LightBall_B", "0.4", "OriginToTarget", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_Resurrection", "70", "Resurrection", "Generic", "CFXM3_ResurrectionLight_Circle", "1", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_LeaveWhirlwind", "71", "Leave Whirlwind", "Earth", "CFXM3_Shield_Leaves", "1.2", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_ShieldRays", "72", "Shield Rays", "Generic", "CFXM3_Shield_Rays", "0.5", "Normal", "0", "1", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_ShieldRaysWhite", "73", "Shield Rays White", "Generic", "CFXM3_Shield_Rays (White)", "1", "Normal", "0", "1", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_ShieldRaysIntense", "74", "Intense Shield Rays", "Generic", "CFXM3_Shield_Rays_Intense", "0.5", "Normal", "0", "1", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_ShieldRaysIntenseBlue", "75", "Intense Blue Shield Rays", "Generic", "CFXM3_Shield_Rays_Intense (Blue)", "0.5", "Normal", "0", "1", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_SmokeColumn", "76", "Smoke Column Black", "Fire", "CFXM3_SmokeColumn_Wind_Black (Prewarm)", "0.01", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_RedSmokeColumn", "77", "Smoke Column Red", "Fire", "CFXM3_SmokeColumn_Wind_Red (Prewarm)", "0.01", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_VortexAir", "78", "Vortex Air Blue", "Air", "CFXM3_Vortex_Air (Blue)", "1", "Normal", "0", "2", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_VortexTornado", "79", "Vortex Tornado", "Air", "CFXM3_VortexTornado", "2", "OriginToTarget", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_SparkFarSideOnly", "80", "Spark Far Side", "Electric", "CFXM3_Hit_Electric_A_Ground", "0.1", "OnTargetOnly", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_Flash", "81", "Flash", "Electric", "CFXM_Flash", "0.5", "OnTargetOnly", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_Splash", "82", "Splash", "Water", "CFXM_Splash", "0.5", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_BubblesChoke", "83", "Bubbles", "Water", "CFXM4 Bubbles Choke", "1", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_SplashHuge", "84", "Splash Huge", "Water", "CFXM4 Splash Huge", "1.3", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_FairyDust1", "85", "Fairy Dust", "Air", "CFXM4 Fairy Dust", "1.9", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_FairyDust2", "86", "Fairy Dust (Green)", "Air", "CFXM4 Fairy Dust (Green)", "1.9", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_FairyDust3", "87", "Fairy Dust (Orange)", "Air", "CFXM4 Fairy Dust (Orange)", "1.9", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_DrillGroundHit", "88", "Drill Ground Hit", "Hits", "CFXM4 Drill Ground Hit (NO COLLISION)", "0.5", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_DistruptiveForce", "89", "Disruptive Force", "Air", "CFXM4 Disruptive Force", "1", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_BubblesWhirl", "90", "Bubbles Whirl", "Water", "CFXM4 Bubbles Whirl", "1", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_Snowstorm", "91", "Snow Storm", "Ice", "Snowstorm", "2.8", "Normal", "0", "12", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_ElectricBall1", "92", "Electric Ball", "Electric", "CFXM_ElectricityBall_Alt", "0.5", "OriginToTarget", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_ElectricityBolt", "93", "Electric Bolt", "Electric", "CFXM_ElectricityBolt", "0.4", "OnOriginOnly", "0", "0", "-90", "90"));
			Rows.Add( new MoveAnimationNamesRow("AT_BlueSparksRanged", "94", "Blue Sparks Ranged", "Electric", "CFXM2_SparksHit Blue", "0.2", "OnTargetOnly", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_VortextRed", "95", "Vortex Red", "Air", "CFXM3_Vortex_Air (Red)", "0.9", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_SandAttack", "96", "Sand Attack (Ranged)", "Generic", "CFXM_SandAttack", "0.7", "OnTargetOnly", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_SandAttack2", "97", "Sand Attack (Melee)", "Generic", "CFXM_SandAttack", "0.7", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_FlameThrower", "98", "FlameThrower", "Fire", "CFXM_FlameThrow", "1.1", "OnOriginOnly", "1.5", "0", "90", "-90"));
			Rows.Add( new MoveAnimationNamesRow("AT_IceThrower", "99", "Ice Thrower", "Ice", "CFXM_IceThrower", "1.1", "OnOriginOnly", "1.5", "0", "90", "-90"));
			Rows.Add( new MoveAnimationNamesRow("AT_RainStorm", "100", "Rain", "Water", "CFXM2_RainHeavy", "2.4", "Normal", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_WaterBall", "101", "Water Ball", "Water", "CFXM3_Waterball_A", "0.75", "OriginToTarget", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_DirtBall", "102", "Dirt Ball", "Earth", "CFXM3_DirtBall", "0.5", "OriginToTarget", "0", "0", "0", "0"));
			Rows.Add( new MoveAnimationNamesRow("AT_FairyDust4", "103", "Fairy Dust (Cold)", "Air", "CFXM4 Fairy Dust (Cold)", "1.9", "Normal", "0", "0", "0", "0"));
		}
		public IGoogle2uRow GetGenRow(string in_RowString)
		{
			IGoogle2uRow ret = null;
			try
			{
				ret = Rows[(int)System.Enum.Parse(typeof(rowIds), in_RowString)];
			}
			catch(System.ArgumentException) {
				Debug.LogError( in_RowString + " is not a member of the rowIds enumeration.");
			}
			return ret;
		}
		public IGoogle2uRow GetGenRow(rowIds in_RowID)
		{
			IGoogle2uRow ret = null;
			try
			{
				ret = Rows[(int)in_RowID];
			}
			catch( System.Collections.Generic.KeyNotFoundException ex )
			{
				Debug.LogError( in_RowID + " not found: " + ex.Message );
			}
			return ret;
		}
		public MoveAnimationNamesRow GetRow(rowIds in_RowID)
		{
			MoveAnimationNamesRow ret = null;
			try
			{
				ret = Rows[(int)in_RowID];
			}
			catch( System.Collections.Generic.KeyNotFoundException ex )
			{
				Debug.LogError( in_RowID + " not found: " + ex.Message );
			}
			return ret;
		}
		public MoveAnimationNamesRow GetRow(string in_RowString)
		{
			MoveAnimationNamesRow ret = null;
			try
			{
				ret = Rows[(int)System.Enum.Parse(typeof(rowIds), in_RowString)];
			}
			catch(System.ArgumentException) {
				Debug.LogError( in_RowString + " is not a member of the rowIds enumeration.");
			}
			return ret;
		}

	}

}
