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
	public class MoveDataRow : IGoogle2uRow
	{
		public int _ID;
		public string _MoveName;
		public float _MoveSpeedMultiplier;
		public bool _IsPassiveEffect;
		public string _PowerApplicationType;
		public string _Description;
		public string _ElementalType;
		public string _MeleeRangedStatus;
		public int _IfMyStatusEffect;
		public string _DoAlternativeMove;
		public int _IfTheirStatusEffect;
		public string _DoAlternativeMove2;
		public int _OnlyApplyPowerIfTheirStatusEffect;
		public float _Effort;
		public int _Power;
		public float _SplashPercent;
		public string _SplashRange;
		public float _Accuracy;
		public string _AttackMecanim;
		public string _AttackParticlesAnimation;
		public string _AttackParticlesAnimationHit;
		public string _HitMecanim;
		public string _CameraShake;
		public float _ParalyzePercent;
		public float _SleepPercent;
		public float _PoisonPercent;
		public float _FreezePercent;
		public float _FlinchPercent;
		public float _ConfusionPercent;
		public float _BurnPercent;
		public float _SpeedStatMultiplier;
		public float _RangeAttackMultiplier;
		public float _MeleeAttackMultiplier;
		public float _RangeDefenseMultiplier;
		public float _MeleeDefenseMultiplier;
		public float _AccuracyMultiplier;
		public float _AgilityMultiplier;
		public int _MinHitsPerTurn;
		public int _MaxHitsPerTurn;
		public int _MinTurns;
		public int _MaxTurns;
		public int _EffectsDuration;
		public float _CriticalHitChance;
		public string _DamageDistribution;
		public string _AddVulnerabilityType;
		public float _PercentChangeOfVulnerability;
		public int _RemovesWeaknessTo;
		public int _AddInvulnerabilityToStatus;
		public int _AddInvulnerabilityToStatChange;
		public int _AddInvulnerabilityToStatLowering;
		public int _AddInvulnerabilityToStatRaising;
		public float _HitMyselfWithThisPercentageOfMove;
		public float _AddsOneHitKOInvulnerability;
		public float _MultihitMultiplier;
		public float _DecisiveBlowsImmunity;
		public float _DecisiveBlowsChanceMultiplier;
		public bool _MirrorStatusEffects;
		public float _NonDamagingMoveMultiplier;
		public float _EnergyUsageMultiplier;
		public string _AlsoApplyThisMove;
		public float _PercentChanceOfFollowOn;
		public byte _MaxUnlockLevel;
		public int _Tested;
		public byte _Struggle;
		public MoveDataRow(string __GOOGLEFU_ID, string __ID, string __MoveName, string __MoveSpeedMultiplier, string __IsPassiveEffect, string __PowerApplicationType, string __Description, string __ElementalType, string __MeleeRangedStatus, string __IfMyStatusEffect, string __DoAlternativeMove, string __IfTheirStatusEffect, string __DoAlternativeMove2, string __OnlyApplyPowerIfTheirStatusEffect, string __Effort, string __Power, string __SplashPercent, string __SplashRange, string __Accuracy, string __AttackMecanim, string __AttackParticlesAnimation, string __AttackParticlesAnimationHit, string __HitMecanim, string __CameraShake, string __ParalyzePercent, string __SleepPercent, string __PoisonPercent, string __FreezePercent, string __FlinchPercent, string __ConfusionPercent, string __BurnPercent, string __SpeedStatMultiplier, string __RangeAttackMultiplier, string __MeleeAttackMultiplier, string __RangeDefenseMultiplier, string __MeleeDefenseMultiplier, string __AccuracyMultiplier, string __AgilityMultiplier, string __MinHitsPerTurn, string __MaxHitsPerTurn, string __MinTurns, string __MaxTurns, string __EffectsDuration, string __CriticalHitChance, string __DamageDistribution, string __AddVulnerabilityType, string __PercentChangeOfVulnerability, string __RemovesWeaknessTo, string __AddInvulnerabilityToStatus, string __AddInvulnerabilityToStatChange, string __AddInvulnerabilityToStatLowering, string __AddInvulnerabilityToStatRaising, string __HitMyselfWithThisPercentageOfMove, string __AddsOneHitKOInvulnerability, string __MultihitMultiplier, string __DecisiveBlowsImmunity, string __DecisiveBlowsChanceMultiplier, string __MirrorStatusEffects, string __NonDamagingMoveMultiplier, string __EnergyUsageMultiplier, string __AlsoApplyThisMove, string __PercentChanceOfFollowOn, string __MaxUnlockLevel, string __Tested, string __Struggle) 
		{
			{
			int res;
				if(int.TryParse(__ID, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_ID = res;
				else
					Debug.LogError("Failed To Convert _ID string: "+ __ID +" to int");
			}
			_MoveName = __MoveName.Trim();
			{
			float res;
				if(float.TryParse(__MoveSpeedMultiplier, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_MoveSpeedMultiplier = res;
				else
					Debug.LogError("Failed To Convert _MoveSpeedMultiplier string: "+ __MoveSpeedMultiplier +" to float");
			}
			{
			bool res;
				if(bool.TryParse(__IsPassiveEffect, out res))
					_IsPassiveEffect = res;
				else
					Debug.LogError("Failed To Convert _IsPassiveEffect string: "+ __IsPassiveEffect +" to bool");
			}
			_PowerApplicationType = __PowerApplicationType.Trim();
			_Description = __Description.Trim();
			_ElementalType = __ElementalType.Trim();
			_MeleeRangedStatus = __MeleeRangedStatus.Trim();
			{
			int res;
				if(int.TryParse(__IfMyStatusEffect, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_IfMyStatusEffect = res;
				else
					Debug.LogError("Failed To Convert _IfMyStatusEffect string: "+ __IfMyStatusEffect +" to int");
			}
			_DoAlternativeMove = __DoAlternativeMove.Trim();
			{
			int res;
				if(int.TryParse(__IfTheirStatusEffect, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_IfTheirStatusEffect = res;
				else
					Debug.LogError("Failed To Convert _IfTheirStatusEffect string: "+ __IfTheirStatusEffect +" to int");
			}
			_DoAlternativeMove2 = __DoAlternativeMove2.Trim();
			{
			int res;
				if(int.TryParse(__OnlyApplyPowerIfTheirStatusEffect, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_OnlyApplyPowerIfTheirStatusEffect = res;
				else
					Debug.LogError("Failed To Convert _OnlyApplyPowerIfTheirStatusEffect string: "+ __OnlyApplyPowerIfTheirStatusEffect +" to int");
			}
			{
			float res;
				if(float.TryParse(__Effort, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_Effort = res;
				else
					Debug.LogError("Failed To Convert _Effort string: "+ __Effort +" to float");
			}
			{
			int res;
				if(int.TryParse(__Power, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_Power = res;
				else
					Debug.LogError("Failed To Convert _Power string: "+ __Power +" to int");
			}
			{
			float res;
				if(float.TryParse(__SplashPercent, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_SplashPercent = res;
				else
					Debug.LogError("Failed To Convert _SplashPercent string: "+ __SplashPercent +" to float");
			}
			_SplashRange = __SplashRange.Trim();
			{
			float res;
				if(float.TryParse(__Accuracy, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_Accuracy = res;
				else
					Debug.LogError("Failed To Convert _Accuracy string: "+ __Accuracy +" to float");
			}
			_AttackMecanim = __AttackMecanim.Trim();
			_AttackParticlesAnimation = __AttackParticlesAnimation.Trim();
			_AttackParticlesAnimationHit = __AttackParticlesAnimationHit.Trim();
			_HitMecanim = __HitMecanim.Trim();
			_CameraShake = __CameraShake.Trim();
			{
			float res;
				if(float.TryParse(__ParalyzePercent, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_ParalyzePercent = res;
				else
					Debug.LogError("Failed To Convert _ParalyzePercent string: "+ __ParalyzePercent +" to float");
			}
			{
			float res;
				if(float.TryParse(__SleepPercent, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_SleepPercent = res;
				else
					Debug.LogError("Failed To Convert _SleepPercent string: "+ __SleepPercent +" to float");
			}
			{
			float res;
				if(float.TryParse(__PoisonPercent, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_PoisonPercent = res;
				else
					Debug.LogError("Failed To Convert _PoisonPercent string: "+ __PoisonPercent +" to float");
			}
			{
			float res;
				if(float.TryParse(__FreezePercent, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_FreezePercent = res;
				else
					Debug.LogError("Failed To Convert _FreezePercent string: "+ __FreezePercent +" to float");
			}
			{
			float res;
				if(float.TryParse(__FlinchPercent, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_FlinchPercent = res;
				else
					Debug.LogError("Failed To Convert _FlinchPercent string: "+ __FlinchPercent +" to float");
			}
			{
			float res;
				if(float.TryParse(__ConfusionPercent, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_ConfusionPercent = res;
				else
					Debug.LogError("Failed To Convert _ConfusionPercent string: "+ __ConfusionPercent +" to float");
			}
			{
			float res;
				if(float.TryParse(__BurnPercent, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_BurnPercent = res;
				else
					Debug.LogError("Failed To Convert _BurnPercent string: "+ __BurnPercent +" to float");
			}
			{
			float res;
				if(float.TryParse(__SpeedStatMultiplier, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_SpeedStatMultiplier = res;
				else
					Debug.LogError("Failed To Convert _SpeedStatMultiplier string: "+ __SpeedStatMultiplier +" to float");
			}
			{
			float res;
				if(float.TryParse(__RangeAttackMultiplier, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_RangeAttackMultiplier = res;
				else
					Debug.LogError("Failed To Convert _RangeAttackMultiplier string: "+ __RangeAttackMultiplier +" to float");
			}
			{
			float res;
				if(float.TryParse(__MeleeAttackMultiplier, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_MeleeAttackMultiplier = res;
				else
					Debug.LogError("Failed To Convert _MeleeAttackMultiplier string: "+ __MeleeAttackMultiplier +" to float");
			}
			{
			float res;
				if(float.TryParse(__RangeDefenseMultiplier, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_RangeDefenseMultiplier = res;
				else
					Debug.LogError("Failed To Convert _RangeDefenseMultiplier string: "+ __RangeDefenseMultiplier +" to float");
			}
			{
			float res;
				if(float.TryParse(__MeleeDefenseMultiplier, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_MeleeDefenseMultiplier = res;
				else
					Debug.LogError("Failed To Convert _MeleeDefenseMultiplier string: "+ __MeleeDefenseMultiplier +" to float");
			}
			{
			float res;
				if(float.TryParse(__AccuracyMultiplier, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_AccuracyMultiplier = res;
				else
					Debug.LogError("Failed To Convert _AccuracyMultiplier string: "+ __AccuracyMultiplier +" to float");
			}
			{
			float res;
				if(float.TryParse(__AgilityMultiplier, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_AgilityMultiplier = res;
				else
					Debug.LogError("Failed To Convert _AgilityMultiplier string: "+ __AgilityMultiplier +" to float");
			}
			{
			int res;
				if(int.TryParse(__MinHitsPerTurn, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_MinHitsPerTurn = res;
				else
					Debug.LogError("Failed To Convert _MinHitsPerTurn string: "+ __MinHitsPerTurn +" to int");
			}
			{
			int res;
				if(int.TryParse(__MaxHitsPerTurn, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_MaxHitsPerTurn = res;
				else
					Debug.LogError("Failed To Convert _MaxHitsPerTurn string: "+ __MaxHitsPerTurn +" to int");
			}
			{
			int res;
				if(int.TryParse(__MinTurns, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_MinTurns = res;
				else
					Debug.LogError("Failed To Convert _MinTurns string: "+ __MinTurns +" to int");
			}
			{
			int res;
				if(int.TryParse(__MaxTurns, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_MaxTurns = res;
				else
					Debug.LogError("Failed To Convert _MaxTurns string: "+ __MaxTurns +" to int");
			}
			{
			int res;
				if(int.TryParse(__EffectsDuration, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_EffectsDuration = res;
				else
					Debug.LogError("Failed To Convert _EffectsDuration string: "+ __EffectsDuration +" to int");
			}
			{
			float res;
				if(float.TryParse(__CriticalHitChance, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_CriticalHitChance = res;
				else
					Debug.LogError("Failed To Convert _CriticalHitChance string: "+ __CriticalHitChance +" to float");
			}
			_DamageDistribution = __DamageDistribution.Trim();
			_AddVulnerabilityType = __AddVulnerabilityType.Trim();
			{
			float res;
				if(float.TryParse(__PercentChangeOfVulnerability, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_PercentChangeOfVulnerability = res;
				else
					Debug.LogError("Failed To Convert _PercentChangeOfVulnerability string: "+ __PercentChangeOfVulnerability +" to float");
			}
			{
			int res;
				if(int.TryParse(__RemovesWeaknessTo, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_RemovesWeaknessTo = res;
				else
					Debug.LogError("Failed To Convert _RemovesWeaknessTo string: "+ __RemovesWeaknessTo +" to int");
			}
			{
			int res;
				if(int.TryParse(__AddInvulnerabilityToStatus, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_AddInvulnerabilityToStatus = res;
				else
					Debug.LogError("Failed To Convert _AddInvulnerabilityToStatus string: "+ __AddInvulnerabilityToStatus +" to int");
			}
			{
			int res;
				if(int.TryParse(__AddInvulnerabilityToStatChange, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_AddInvulnerabilityToStatChange = res;
				else
					Debug.LogError("Failed To Convert _AddInvulnerabilityToStatChange string: "+ __AddInvulnerabilityToStatChange +" to int");
			}
			{
			int res;
				if(int.TryParse(__AddInvulnerabilityToStatLowering, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_AddInvulnerabilityToStatLowering = res;
				else
					Debug.LogError("Failed To Convert _AddInvulnerabilityToStatLowering string: "+ __AddInvulnerabilityToStatLowering +" to int");
			}
			{
			int res;
				if(int.TryParse(__AddInvulnerabilityToStatRaising, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_AddInvulnerabilityToStatRaising = res;
				else
					Debug.LogError("Failed To Convert _AddInvulnerabilityToStatRaising string: "+ __AddInvulnerabilityToStatRaising +" to int");
			}
			{
			float res;
				if(float.TryParse(__HitMyselfWithThisPercentageOfMove, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_HitMyselfWithThisPercentageOfMove = res;
				else
					Debug.LogError("Failed To Convert _HitMyselfWithThisPercentageOfMove string: "+ __HitMyselfWithThisPercentageOfMove +" to float");
			}
			{
			float res;
				if(float.TryParse(__AddsOneHitKOInvulnerability, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_AddsOneHitKOInvulnerability = res;
				else
					Debug.LogError("Failed To Convert _AddsOneHitKOInvulnerability string: "+ __AddsOneHitKOInvulnerability +" to float");
			}
			{
			float res;
				if(float.TryParse(__MultihitMultiplier, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_MultihitMultiplier = res;
				else
					Debug.LogError("Failed To Convert _MultihitMultiplier string: "+ __MultihitMultiplier +" to float");
			}
			{
			float res;
				if(float.TryParse(__DecisiveBlowsImmunity, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_DecisiveBlowsImmunity = res;
				else
					Debug.LogError("Failed To Convert _DecisiveBlowsImmunity string: "+ __DecisiveBlowsImmunity +" to float");
			}
			{
			float res;
				if(float.TryParse(__DecisiveBlowsChanceMultiplier, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_DecisiveBlowsChanceMultiplier = res;
				else
					Debug.LogError("Failed To Convert _DecisiveBlowsChanceMultiplier string: "+ __DecisiveBlowsChanceMultiplier +" to float");
			}
			{
			bool res;
				if(bool.TryParse(__MirrorStatusEffects, out res))
					_MirrorStatusEffects = res;
				else
					Debug.LogError("Failed To Convert _MirrorStatusEffects string: "+ __MirrorStatusEffects +" to bool");
			}
			{
			float res;
				if(float.TryParse(__NonDamagingMoveMultiplier, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_NonDamagingMoveMultiplier = res;
				else
					Debug.LogError("Failed To Convert _NonDamagingMoveMultiplier string: "+ __NonDamagingMoveMultiplier +" to float");
			}
			{
			float res;
				if(float.TryParse(__EnergyUsageMultiplier, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_EnergyUsageMultiplier = res;
				else
					Debug.LogError("Failed To Convert _EnergyUsageMultiplier string: "+ __EnergyUsageMultiplier +" to float");
			}
			_AlsoApplyThisMove = __AlsoApplyThisMove.Trim();
			{
			float res;
				if(float.TryParse(__PercentChanceOfFollowOn, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_PercentChanceOfFollowOn = res;
				else
					Debug.LogError("Failed To Convert _PercentChanceOfFollowOn string: "+ __PercentChanceOfFollowOn +" to float");
			}
			{
			byte res;
				if(byte.TryParse(__MaxUnlockLevel, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_MaxUnlockLevel = res;
				else
					Debug.LogError("Failed To Convert _MaxUnlockLevel string: "+ __MaxUnlockLevel +" to byte");
			}
			{
			int res;
				if(int.TryParse(__Tested, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_Tested = res;
				else
					Debug.LogError("Failed To Convert _Tested string: "+ __Tested +" to int");
			}
			{
			byte res;
				if(byte.TryParse(__Struggle, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_Struggle = res;
				else
					Debug.LogError("Failed To Convert _Struggle string: "+ __Struggle +" to byte");
			}
		}

		public int Length { get { return 64; } }

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
					ret = _MoveName.ToString();
					break;
				case 2:
					ret = _MoveSpeedMultiplier.ToString();
					break;
				case 3:
					ret = _IsPassiveEffect.ToString();
					break;
				case 4:
					ret = _PowerApplicationType.ToString();
					break;
				case 5:
					ret = _Description.ToString();
					break;
				case 6:
					ret = _ElementalType.ToString();
					break;
				case 7:
					ret = _MeleeRangedStatus.ToString();
					break;
				case 8:
					ret = _IfMyStatusEffect.ToString();
					break;
				case 9:
					ret = _DoAlternativeMove.ToString();
					break;
				case 10:
					ret = _IfTheirStatusEffect.ToString();
					break;
				case 11:
					ret = _DoAlternativeMove2.ToString();
					break;
				case 12:
					ret = _OnlyApplyPowerIfTheirStatusEffect.ToString();
					break;
				case 13:
					ret = _Effort.ToString();
					break;
				case 14:
					ret = _Power.ToString();
					break;
				case 15:
					ret = _SplashPercent.ToString();
					break;
				case 16:
					ret = _SplashRange.ToString();
					break;
				case 17:
					ret = _Accuracy.ToString();
					break;
				case 18:
					ret = _AttackMecanim.ToString();
					break;
				case 19:
					ret = _AttackParticlesAnimation.ToString();
					break;
				case 20:
					ret = _AttackParticlesAnimationHit.ToString();
					break;
				case 21:
					ret = _HitMecanim.ToString();
					break;
				case 22:
					ret = _CameraShake.ToString();
					break;
				case 23:
					ret = _ParalyzePercent.ToString();
					break;
				case 24:
					ret = _SleepPercent.ToString();
					break;
				case 25:
					ret = _PoisonPercent.ToString();
					break;
				case 26:
					ret = _FreezePercent.ToString();
					break;
				case 27:
					ret = _FlinchPercent.ToString();
					break;
				case 28:
					ret = _ConfusionPercent.ToString();
					break;
				case 29:
					ret = _BurnPercent.ToString();
					break;
				case 30:
					ret = _SpeedStatMultiplier.ToString();
					break;
				case 31:
					ret = _RangeAttackMultiplier.ToString();
					break;
				case 32:
					ret = _MeleeAttackMultiplier.ToString();
					break;
				case 33:
					ret = _RangeDefenseMultiplier.ToString();
					break;
				case 34:
					ret = _MeleeDefenseMultiplier.ToString();
					break;
				case 35:
					ret = _AccuracyMultiplier.ToString();
					break;
				case 36:
					ret = _AgilityMultiplier.ToString();
					break;
				case 37:
					ret = _MinHitsPerTurn.ToString();
					break;
				case 38:
					ret = _MaxHitsPerTurn.ToString();
					break;
				case 39:
					ret = _MinTurns.ToString();
					break;
				case 40:
					ret = _MaxTurns.ToString();
					break;
				case 41:
					ret = _EffectsDuration.ToString();
					break;
				case 42:
					ret = _CriticalHitChance.ToString();
					break;
				case 43:
					ret = _DamageDistribution.ToString();
					break;
				case 44:
					ret = _AddVulnerabilityType.ToString();
					break;
				case 45:
					ret = _PercentChangeOfVulnerability.ToString();
					break;
				case 46:
					ret = _RemovesWeaknessTo.ToString();
					break;
				case 47:
					ret = _AddInvulnerabilityToStatus.ToString();
					break;
				case 48:
					ret = _AddInvulnerabilityToStatChange.ToString();
					break;
				case 49:
					ret = _AddInvulnerabilityToStatLowering.ToString();
					break;
				case 50:
					ret = _AddInvulnerabilityToStatRaising.ToString();
					break;
				case 51:
					ret = _HitMyselfWithThisPercentageOfMove.ToString();
					break;
				case 52:
					ret = _AddsOneHitKOInvulnerability.ToString();
					break;
				case 53:
					ret = _MultihitMultiplier.ToString();
					break;
				case 54:
					ret = _DecisiveBlowsImmunity.ToString();
					break;
				case 55:
					ret = _DecisiveBlowsChanceMultiplier.ToString();
					break;
				case 56:
					ret = _MirrorStatusEffects.ToString();
					break;
				case 57:
					ret = _NonDamagingMoveMultiplier.ToString();
					break;
				case 58:
					ret = _EnergyUsageMultiplier.ToString();
					break;
				case 59:
					ret = _AlsoApplyThisMove.ToString();
					break;
				case 60:
					ret = _PercentChanceOfFollowOn.ToString();
					break;
				case 61:
					ret = _MaxUnlockLevel.ToString();
					break;
				case 62:
					ret = _Tested.ToString();
					break;
				case 63:
					ret = _Struggle.ToString();
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
				case "MoveName":
					ret = _MoveName.ToString();
					break;
				case "MoveSpeedMultiplier":
					ret = _MoveSpeedMultiplier.ToString();
					break;
				case "IsPassiveEffect":
					ret = _IsPassiveEffect.ToString();
					break;
				case "PowerApplicationType":
					ret = _PowerApplicationType.ToString();
					break;
				case "Description":
					ret = _Description.ToString();
					break;
				case "ElementalType":
					ret = _ElementalType.ToString();
					break;
				case "MeleeRangedStatus":
					ret = _MeleeRangedStatus.ToString();
					break;
				case "IfMyStatusEffect":
					ret = _IfMyStatusEffect.ToString();
					break;
				case "DoAlternativeMove":
					ret = _DoAlternativeMove.ToString();
					break;
				case "IfTheirStatusEffect":
					ret = _IfTheirStatusEffect.ToString();
					break;
				case "DoAlternativeMove2":
					ret = _DoAlternativeMove2.ToString();
					break;
				case "OnlyApplyPowerIfTheirStatusEffect":
					ret = _OnlyApplyPowerIfTheirStatusEffect.ToString();
					break;
				case "Effort":
					ret = _Effort.ToString();
					break;
				case "Power":
					ret = _Power.ToString();
					break;
				case "SplashPercent":
					ret = _SplashPercent.ToString();
					break;
				case "SplashRange":
					ret = _SplashRange.ToString();
					break;
				case "Accuracy":
					ret = _Accuracy.ToString();
					break;
				case "AttackMecanim":
					ret = _AttackMecanim.ToString();
					break;
				case "AttackParticlesAnimation":
					ret = _AttackParticlesAnimation.ToString();
					break;
				case "AttackParticlesAnimationHit":
					ret = _AttackParticlesAnimationHit.ToString();
					break;
				case "HitMecanim":
					ret = _HitMecanim.ToString();
					break;
				case "CameraShake":
					ret = _CameraShake.ToString();
					break;
				case "ParalyzePercent":
					ret = _ParalyzePercent.ToString();
					break;
				case "SleepPercent":
					ret = _SleepPercent.ToString();
					break;
				case "PoisonPercent":
					ret = _PoisonPercent.ToString();
					break;
				case "FreezePercent":
					ret = _FreezePercent.ToString();
					break;
				case "FlinchPercent":
					ret = _FlinchPercent.ToString();
					break;
				case "ConfusionPercent":
					ret = _ConfusionPercent.ToString();
					break;
				case "BurnPercent":
					ret = _BurnPercent.ToString();
					break;
				case "SpeedStatMultiplier":
					ret = _SpeedStatMultiplier.ToString();
					break;
				case "RangeAttackMultiplier":
					ret = _RangeAttackMultiplier.ToString();
					break;
				case "MeleeAttackMultiplier":
					ret = _MeleeAttackMultiplier.ToString();
					break;
				case "RangeDefenseMultiplier":
					ret = _RangeDefenseMultiplier.ToString();
					break;
				case "MeleeDefenseMultiplier":
					ret = _MeleeDefenseMultiplier.ToString();
					break;
				case "AccuracyMultiplier":
					ret = _AccuracyMultiplier.ToString();
					break;
				case "AgilityMultiplier":
					ret = _AgilityMultiplier.ToString();
					break;
				case "MinHitsPerTurn":
					ret = _MinHitsPerTurn.ToString();
					break;
				case "MaxHitsPerTurn":
					ret = _MaxHitsPerTurn.ToString();
					break;
				case "MinTurns":
					ret = _MinTurns.ToString();
					break;
				case "MaxTurns":
					ret = _MaxTurns.ToString();
					break;
				case "EffectsDuration":
					ret = _EffectsDuration.ToString();
					break;
				case "CriticalHitChance":
					ret = _CriticalHitChance.ToString();
					break;
				case "DamageDistribution":
					ret = _DamageDistribution.ToString();
					break;
				case "AddVulnerabilityType":
					ret = _AddVulnerabilityType.ToString();
					break;
				case "PercentChangeOfVulnerability":
					ret = _PercentChangeOfVulnerability.ToString();
					break;
				case "RemovesWeaknessTo":
					ret = _RemovesWeaknessTo.ToString();
					break;
				case "AddInvulnerabilityToStatus":
					ret = _AddInvulnerabilityToStatus.ToString();
					break;
				case "AddInvulnerabilityToStatChange":
					ret = _AddInvulnerabilityToStatChange.ToString();
					break;
				case "AddInvulnerabilityToStatLowering":
					ret = _AddInvulnerabilityToStatLowering.ToString();
					break;
				case "AddInvulnerabilityToStatRaising":
					ret = _AddInvulnerabilityToStatRaising.ToString();
					break;
				case "HitMyselfWithThisPercentageOfMove":
					ret = _HitMyselfWithThisPercentageOfMove.ToString();
					break;
				case "AddsOneHitKOInvulnerability":
					ret = _AddsOneHitKOInvulnerability.ToString();
					break;
				case "MultihitMultiplier":
					ret = _MultihitMultiplier.ToString();
					break;
				case "DecisiveBlowsImmunity":
					ret = _DecisiveBlowsImmunity.ToString();
					break;
				case "DecisiveBlowsChanceMultiplier":
					ret = _DecisiveBlowsChanceMultiplier.ToString();
					break;
				case "MirrorStatusEffects":
					ret = _MirrorStatusEffects.ToString();
					break;
				case "NonDamagingMoveMultiplier":
					ret = _NonDamagingMoveMultiplier.ToString();
					break;
				case "EnergyUsageMultiplier":
					ret = _EnergyUsageMultiplier.ToString();
					break;
				case "AlsoApplyThisMove":
					ret = _AlsoApplyThisMove.ToString();
					break;
				case "PercentChanceOfFollowOn":
					ret = _PercentChanceOfFollowOn.ToString();
					break;
				case "MaxUnlockLevel":
					ret = _MaxUnlockLevel.ToString();
					break;
				case "Tested":
					ret = _Tested.ToString();
					break;
				case "Struggle":
					ret = _Struggle.ToString();
					break;
			}

			return ret;
		}
		public override string ToString()
		{
			string ret = System.String.Empty;
			ret += "{" + "ID" + " : " + _ID.ToString() + "} ";
			ret += "{" + "MoveName" + " : " + _MoveName.ToString() + "} ";
			ret += "{" + "MoveSpeedMultiplier" + " : " + _MoveSpeedMultiplier.ToString() + "} ";
			ret += "{" + "IsPassiveEffect" + " : " + _IsPassiveEffect.ToString() + "} ";
			ret += "{" + "PowerApplicationType" + " : " + _PowerApplicationType.ToString() + "} ";
			ret += "{" + "Description" + " : " + _Description.ToString() + "} ";
			ret += "{" + "ElementalType" + " : " + _ElementalType.ToString() + "} ";
			ret += "{" + "MeleeRangedStatus" + " : " + _MeleeRangedStatus.ToString() + "} ";
			ret += "{" + "IfMyStatusEffect" + " : " + _IfMyStatusEffect.ToString() + "} ";
			ret += "{" + "DoAlternativeMove" + " : " + _DoAlternativeMove.ToString() + "} ";
			ret += "{" + "IfTheirStatusEffect" + " : " + _IfTheirStatusEffect.ToString() + "} ";
			ret += "{" + "DoAlternativeMove2" + " : " + _DoAlternativeMove2.ToString() + "} ";
			ret += "{" + "OnlyApplyPowerIfTheirStatusEffect" + " : " + _OnlyApplyPowerIfTheirStatusEffect.ToString() + "} ";
			ret += "{" + "Effort" + " : " + _Effort.ToString() + "} ";
			ret += "{" + "Power" + " : " + _Power.ToString() + "} ";
			ret += "{" + "SplashPercent" + " : " + _SplashPercent.ToString() + "} ";
			ret += "{" + "SplashRange" + " : " + _SplashRange.ToString() + "} ";
			ret += "{" + "Accuracy" + " : " + _Accuracy.ToString() + "} ";
			ret += "{" + "AttackMecanim" + " : " + _AttackMecanim.ToString() + "} ";
			ret += "{" + "AttackParticlesAnimation" + " : " + _AttackParticlesAnimation.ToString() + "} ";
			ret += "{" + "AttackParticlesAnimationHit" + " : " + _AttackParticlesAnimationHit.ToString() + "} ";
			ret += "{" + "HitMecanim" + " : " + _HitMecanim.ToString() + "} ";
			ret += "{" + "CameraShake" + " : " + _CameraShake.ToString() + "} ";
			ret += "{" + "ParalyzePercent" + " : " + _ParalyzePercent.ToString() + "} ";
			ret += "{" + "SleepPercent" + " : " + _SleepPercent.ToString() + "} ";
			ret += "{" + "PoisonPercent" + " : " + _PoisonPercent.ToString() + "} ";
			ret += "{" + "FreezePercent" + " : " + _FreezePercent.ToString() + "} ";
			ret += "{" + "FlinchPercent" + " : " + _FlinchPercent.ToString() + "} ";
			ret += "{" + "ConfusionPercent" + " : " + _ConfusionPercent.ToString() + "} ";
			ret += "{" + "BurnPercent" + " : " + _BurnPercent.ToString() + "} ";
			ret += "{" + "SpeedStatMultiplier" + " : " + _SpeedStatMultiplier.ToString() + "} ";
			ret += "{" + "RangeAttackMultiplier" + " : " + _RangeAttackMultiplier.ToString() + "} ";
			ret += "{" + "MeleeAttackMultiplier" + " : " + _MeleeAttackMultiplier.ToString() + "} ";
			ret += "{" + "RangeDefenseMultiplier" + " : " + _RangeDefenseMultiplier.ToString() + "} ";
			ret += "{" + "MeleeDefenseMultiplier" + " : " + _MeleeDefenseMultiplier.ToString() + "} ";
			ret += "{" + "AccuracyMultiplier" + " : " + _AccuracyMultiplier.ToString() + "} ";
			ret += "{" + "AgilityMultiplier" + " : " + _AgilityMultiplier.ToString() + "} ";
			ret += "{" + "MinHitsPerTurn" + " : " + _MinHitsPerTurn.ToString() + "} ";
			ret += "{" + "MaxHitsPerTurn" + " : " + _MaxHitsPerTurn.ToString() + "} ";
			ret += "{" + "MinTurns" + " : " + _MinTurns.ToString() + "} ";
			ret += "{" + "MaxTurns" + " : " + _MaxTurns.ToString() + "} ";
			ret += "{" + "EffectsDuration" + " : " + _EffectsDuration.ToString() + "} ";
			ret += "{" + "CriticalHitChance" + " : " + _CriticalHitChance.ToString() + "} ";
			ret += "{" + "DamageDistribution" + " : " + _DamageDistribution.ToString() + "} ";
			ret += "{" + "AddVulnerabilityType" + " : " + _AddVulnerabilityType.ToString() + "} ";
			ret += "{" + "PercentChangeOfVulnerability" + " : " + _PercentChangeOfVulnerability.ToString() + "} ";
			ret += "{" + "RemovesWeaknessTo" + " : " + _RemovesWeaknessTo.ToString() + "} ";
			ret += "{" + "AddInvulnerabilityToStatus" + " : " + _AddInvulnerabilityToStatus.ToString() + "} ";
			ret += "{" + "AddInvulnerabilityToStatChange" + " : " + _AddInvulnerabilityToStatChange.ToString() + "} ";
			ret += "{" + "AddInvulnerabilityToStatLowering" + " : " + _AddInvulnerabilityToStatLowering.ToString() + "} ";
			ret += "{" + "AddInvulnerabilityToStatRaising" + " : " + _AddInvulnerabilityToStatRaising.ToString() + "} ";
			ret += "{" + "HitMyselfWithThisPercentageOfMove" + " : " + _HitMyselfWithThisPercentageOfMove.ToString() + "} ";
			ret += "{" + "AddsOneHitKOInvulnerability" + " : " + _AddsOneHitKOInvulnerability.ToString() + "} ";
			ret += "{" + "MultihitMultiplier" + " : " + _MultihitMultiplier.ToString() + "} ";
			ret += "{" + "DecisiveBlowsImmunity" + " : " + _DecisiveBlowsImmunity.ToString() + "} ";
			ret += "{" + "DecisiveBlowsChanceMultiplier" + " : " + _DecisiveBlowsChanceMultiplier.ToString() + "} ";
			ret += "{" + "MirrorStatusEffects" + " : " + _MirrorStatusEffects.ToString() + "} ";
			ret += "{" + "NonDamagingMoveMultiplier" + " : " + _NonDamagingMoveMultiplier.ToString() + "} ";
			ret += "{" + "EnergyUsageMultiplier" + " : " + _EnergyUsageMultiplier.ToString() + "} ";
			ret += "{" + "AlsoApplyThisMove" + " : " + _AlsoApplyThisMove.ToString() + "} ";
			ret += "{" + "PercentChanceOfFollowOn" + " : " + _PercentChanceOfFollowOn.ToString() + "} ";
			ret += "{" + "MaxUnlockLevel" + " : " + _MaxUnlockLevel.ToString() + "} ";
			ret += "{" + "Tested" + " : " + _Tested.ToString() + "} ";
			ret += "{" + "Struggle" + " : " + _Struggle.ToString() + "} ";
			return ret;
		}
	}
	public sealed class MoveData : IGoogle2uDB
	{
		public enum rowIds {
			MV_HIDDENREVIVE, MV_PASSIVEEFFECTHOTSHOT, MV_PASSIVEEFFECTENFLARE, MV_PASSIVEEFFECTSMOKEY, MV_PASSIVEEFFECTOVERDONE, MV_PASSIVEFRESH, MV_PASSIVEFREEFLOWING, MV_PASSIVEDEATHROLLER, MV_PASSIVEABSORB, MV_DURABLE, MV_SPORED, MV_HARDENED, MV_IMMUNE, MV_PASSIVELIGHTWEIGHT, MV_PASSIVESQUADMATE, MV_PASSIVEFLEETWING, MV_PASSIVERAPIDREFLEX, MV_PASSIVECOLDAURA
			, MV_PASSIVEHIBERNATED, MV_PASSIVECRYSTALLIZED, MV_PASSIVEFROSTBURNER, MV_PASSIVEREACTOR, MV_PASSIVESEMICONDUCTOR, MV_PASSIVESHOCKING, MV_PASSIVEGROUNDED, MV_PASSIVESUPERNATURAL, MV_PASSIVEINFECTIOUS, MV_PASSIVEHEALER, MV_PASSIVEMAGICAL, MV_PASSIVESHARP, MV_PASSIVEHELPER, MV_PASSIVERIVAL, MV_PASSIVEPRECISE, MV_POUNCE, MV_HURL, MV_RAM, MV_LUNGE, MV_CHARGE
			, MV_SLAM, MV_HEADBUTT, MV_BODYSLAM, MV_SCRATCH, MV_BASH, MV_CLAW, MV_STOMP, MV_SLASH, MV_THRASH, MV_MAUL, MV_RAMPAGE, MV_RALLY, MV_COVER, MV_BLOCK, MV_BLIND, MV_ROAR, MV_VALOR, MV_FORTIFY, MV_PURGE, MV_GALE
			, MV_SONARSTRIKE, MV_AIRBLAST, MV_WHIRLWIND, MV_JETSTREAM, MV_CYCLONICSTRIKE, MV_TORNADO, MV_TYPHOON, MV_HIDDENSONARSTRIKE, MV_HIDDENSLIGHTSPEEDBOOST, MV_HIDDENJETSTREAM, MV_HIDDENSLIGHTATTACKBOOST, MV_HIDDENTORNADO, MV_HIDDENTYPHOON, MV_PECK, MV_SPIRALDIVE, MV_DIVEBOMB, MV_WINGBLADE, MV_TALONSLASH, MV_AIRSTRIKE, MV_WARWING
			, MV_SKYHAMMER, MV_HIDDENSPIRALDIVE, MV_HIDDENWINGBLADE, MV_HIDDENSKYHAMMER, MV_WINDSPEED, MV_FOG, MV_CLOUDWALL, MV_BIRDSONG, MV_HAWKEYE, MV_VACUUM, MV_SOOTHINGWIND, MV_HIDDENCLEARALLYSTATUS, MV_ASTRALBLAST, MV_NAUSEA, MV_SHRIEK, MV_POSSESS, MV_SHADOWBOLT, MV_PLAGUEWAVE, MV_ARCANEMISSILES, MV_VORTEX
			, MV_HAUNT, MV_VEX, MV_DARKBITE, MV_SHADOWFANG, MV_PETRIFY, MV_NIGHTMARE, MV_TORMENT, MV_VOID, MV_HIDDENNIGHTMARE, MV_ILLUSION, MV_PAROXYSM, MV_FRENZY, MV_FLASHHEAL, MV_BARRIER, MV_SACREDSCAR, MV_AURORA, MV_MUDSLING, MV_POISON, MV_LEECH, MV_ENTANGLE
			, MV_MUDSLIDE, MV_SANDSTORM, MV_THORNSTORM, MV_NATURESFURY, MV_HIDDENMUDSLIDE, MV_HiDDENNATURESFURY, MV_SPLINTER, MV_WHIPLASH, MV_ROCKSMASH, MV_FORESTKNUCKLE, MV_STUMPSLAM, MV_WILLOWMAKER, MV_STAMPEDE, MV_EARTHQUAKE, MV_FOCUS, MV_REJUVENATE, MV_ENSNARE, MV_STONEHIDE, MV_VINEGRAFT, MV_SERENITY
			, MV_CAMOUFLAGE, MV_HEALINGPOD, MV_SHOCK, MV_SPARK, MV_STATICBLAST, MV_ELECTROCUTE, MV_ARCWAVE, MV_CHAINLIGHTNING, MV_LIGHTNINGSTORM, MV_JOLT, MV_ZAPTACKLE, MV_STATICCHARGE, MV_IONFANG, MV_KINETICCLAW, MV_GIGASTOMP, MV_THUNDERSTRIKE, MV_FLASH, MV_HYPER, MV_BUZZ, MV_SURGE
			, MV_MAGNETIZE, MV_DISCHARGE, MV_RECHARGE, MV_IGNITE, MV_TORCH, MV_HEATWAVE, MV_BLAZE, MV_FLAMETHROWER, MV_FIRESTORM, MV_PYROCLASM, MV_HIDDENRANGEDATTACKBOOST, MV_PYROCLAP, MV_FIREFANG, MV_PYROPUNCH, MV_COMBUSTION, MV_HEATSTRIKE, MV_INFERNOCHARGE, MV_INCINERATE, MV_HIDDENINFERNOCHARGE, MV_HIDDENHEATSTRIKE
			, MV_SMOKESCREEN, MV_SMOLDER, MV_FIREBRAND, MV_LAVAMOAT, MV_STEAM, MV_MOLTENSHIELD, MV_SAUNA, MV_HIDDENMOLTENSHIELD, MV_HAIL, MV_FROSTBREATH, MV_ARCTICBLAST, MV_DEEPFREEZE, MV_TUNDRABLAST, MV_BLIZZARD, MV_AVALANCHE, MV_COLDSNAP, MV_ICECLAW, MV_FROSTBITE, MV_GLACIALSLIDE, MV_ICESMASH
			, MV_FROSTFANG, MV_ICEDRILL, MV_HIDDENGLACIALSLIDE, MV_WHITEBREATH, MV_FROSTCLOAK, MV_WINTERSMARK, MV_COOLDOWN, MV_ICESHIELD, MV_SNOWDRIFT, MV_COLDFRONT, MV_HIDDENSPEEDDEBUFF, MV_SPLASH, MV_RIPTIDE, MV_WATERBLAST, MV_WATERCANNON, MV_WHIRLPOOL, MV_TIDALWAVE, MV_MONSOON, MV_HIDDENWHIRLPOOL, MV_HIDDENMONSOON
			, MV_DIVE, MV_AQUASLIDE, MV_HYDROFIST, MV_WIPEOUT, MV_WAVEBREAKER, MV_TIDALSMASH, MV_TSUNAMICHARGE, MV_HIDDENAQUASLIDE, MV_PURIFY, MV_RINSE, MV_SPIRITWATER, MV_CLEANSE, MV_DRENCH, MV_LIFELINE, MV_HEALINGWELL, MV_HIDDENMELEEATTACKBOOST, MV_HIDDENDECISIVEBLOWBOOST, MV_HIDDENTIREDBLOW, MV_HIDDENRANGEATTACKBOOST
		};
		public string [] rowNames = {
			"MV_HIDDENREVIVE", "MV_PASSIVEEFFECTHOTSHOT", "MV_PASSIVEEFFECTENFLARE", "MV_PASSIVEEFFECTSMOKEY", "MV_PASSIVEEFFECTOVERDONE", "MV_PASSIVEFRESH", "MV_PASSIVEFREEFLOWING", "MV_PASSIVEDEATHROLLER", "MV_PASSIVEABSORB", "MV_DURABLE", "MV_SPORED", "MV_HARDENED", "MV_IMMUNE", "MV_PASSIVELIGHTWEIGHT", "MV_PASSIVESQUADMATE", "MV_PASSIVEFLEETWING", "MV_PASSIVERAPIDREFLEX", "MV_PASSIVECOLDAURA"
			, "MV_PASSIVEHIBERNATED", "MV_PASSIVECRYSTALLIZED", "MV_PASSIVEFROSTBURNER", "MV_PASSIVEREACTOR", "MV_PASSIVESEMICONDUCTOR", "MV_PASSIVESHOCKING", "MV_PASSIVEGROUNDED", "MV_PASSIVESUPERNATURAL", "MV_PASSIVEINFECTIOUS", "MV_PASSIVEHEALER", "MV_PASSIVEMAGICAL", "MV_PASSIVESHARP", "MV_PASSIVEHELPER", "MV_PASSIVERIVAL", "MV_PASSIVEPRECISE", "MV_POUNCE", "MV_HURL", "MV_RAM", "MV_LUNGE", "MV_CHARGE"
			, "MV_SLAM", "MV_HEADBUTT", "MV_BODYSLAM", "MV_SCRATCH", "MV_BASH", "MV_CLAW", "MV_STOMP", "MV_SLASH", "MV_THRASH", "MV_MAUL", "MV_RAMPAGE", "MV_RALLY", "MV_COVER", "MV_BLOCK", "MV_BLIND", "MV_ROAR", "MV_VALOR", "MV_FORTIFY", "MV_PURGE", "MV_GALE"
			, "MV_SONARSTRIKE", "MV_AIRBLAST", "MV_WHIRLWIND", "MV_JETSTREAM", "MV_CYCLONICSTRIKE", "MV_TORNADO", "MV_TYPHOON", "MV_HIDDENSONARSTRIKE", "MV_HIDDENSLIGHTSPEEDBOOST", "MV_HIDDENJETSTREAM", "MV_HIDDENSLIGHTATTACKBOOST", "MV_HIDDENTORNADO", "MV_HIDDENTYPHOON", "MV_PECK", "MV_SPIRALDIVE", "MV_DIVEBOMB", "MV_WINGBLADE", "MV_TALONSLASH", "MV_AIRSTRIKE", "MV_WARWING"
			, "MV_SKYHAMMER", "MV_HIDDENSPIRALDIVE", "MV_HIDDENWINGBLADE", "MV_HIDDENSKYHAMMER", "MV_WINDSPEED", "MV_FOG", "MV_CLOUDWALL", "MV_BIRDSONG", "MV_HAWKEYE", "MV_VACUUM", "MV_SOOTHINGWIND", "MV_HIDDENCLEARALLYSTATUS", "MV_ASTRALBLAST", "MV_NAUSEA", "MV_SHRIEK", "MV_POSSESS", "MV_SHADOWBOLT", "MV_PLAGUEWAVE", "MV_ARCANEMISSILES", "MV_VORTEX"
			, "MV_HAUNT", "MV_VEX", "MV_DARKBITE", "MV_SHADOWFANG", "MV_PETRIFY", "MV_NIGHTMARE", "MV_TORMENT", "MV_VOID", "MV_HIDDENNIGHTMARE", "MV_ILLUSION", "MV_PAROXYSM", "MV_FRENZY", "MV_FLASHHEAL", "MV_BARRIER", "MV_SACREDSCAR", "MV_AURORA", "MV_MUDSLING", "MV_POISON", "MV_LEECH", "MV_ENTANGLE"
			, "MV_MUDSLIDE", "MV_SANDSTORM", "MV_THORNSTORM", "MV_NATURESFURY", "MV_HIDDENMUDSLIDE", "MV_HiDDENNATURESFURY", "MV_SPLINTER", "MV_WHIPLASH", "MV_ROCKSMASH", "MV_FORESTKNUCKLE", "MV_STUMPSLAM", "MV_WILLOWMAKER", "MV_STAMPEDE", "MV_EARTHQUAKE", "MV_FOCUS", "MV_REJUVENATE", "MV_ENSNARE", "MV_STONEHIDE", "MV_VINEGRAFT", "MV_SERENITY"
			, "MV_CAMOUFLAGE", "MV_HEALINGPOD", "MV_SHOCK", "MV_SPARK", "MV_STATICBLAST", "MV_ELECTROCUTE", "MV_ARCWAVE", "MV_CHAINLIGHTNING", "MV_LIGHTNINGSTORM", "MV_JOLT", "MV_ZAPTACKLE", "MV_STATICCHARGE", "MV_IONFANG", "MV_KINETICCLAW", "MV_GIGASTOMP", "MV_THUNDERSTRIKE", "MV_FLASH", "MV_HYPER", "MV_BUZZ", "MV_SURGE"
			, "MV_MAGNETIZE", "MV_DISCHARGE", "MV_RECHARGE", "MV_IGNITE", "MV_TORCH", "MV_HEATWAVE", "MV_BLAZE", "MV_FLAMETHROWER", "MV_FIRESTORM", "MV_PYROCLASM", "MV_HIDDENRANGEDATTACKBOOST", "MV_PYROCLAP", "MV_FIREFANG", "MV_PYROPUNCH", "MV_COMBUSTION", "MV_HEATSTRIKE", "MV_INFERNOCHARGE", "MV_INCINERATE", "MV_HIDDENINFERNOCHARGE", "MV_HIDDENHEATSTRIKE"
			, "MV_SMOKESCREEN", "MV_SMOLDER", "MV_FIREBRAND", "MV_LAVAMOAT", "MV_STEAM", "MV_MOLTENSHIELD", "MV_SAUNA", "MV_HIDDENMOLTENSHIELD", "MV_HAIL", "MV_FROSTBREATH", "MV_ARCTICBLAST", "MV_DEEPFREEZE", "MV_TUNDRABLAST", "MV_BLIZZARD", "MV_AVALANCHE", "MV_COLDSNAP", "MV_ICECLAW", "MV_FROSTBITE", "MV_GLACIALSLIDE", "MV_ICESMASH"
			, "MV_FROSTFANG", "MV_ICEDRILL", "MV_HIDDENGLACIALSLIDE", "MV_WHITEBREATH", "MV_FROSTCLOAK", "MV_WINTERSMARK", "MV_COOLDOWN", "MV_ICESHIELD", "MV_SNOWDRIFT", "MV_COLDFRONT", "MV_HIDDENSPEEDDEBUFF", "MV_SPLASH", "MV_RIPTIDE", "MV_WATERBLAST", "MV_WATERCANNON", "MV_WHIRLPOOL", "MV_TIDALWAVE", "MV_MONSOON", "MV_HIDDENWHIRLPOOL", "MV_HIDDENMONSOON"
			, "MV_DIVE", "MV_AQUASLIDE", "MV_HYDROFIST", "MV_WIPEOUT", "MV_WAVEBREAKER", "MV_TIDALSMASH", "MV_TSUNAMICHARGE", "MV_HIDDENAQUASLIDE", "MV_PURIFY", "MV_RINSE", "MV_SPIRITWATER", "MV_CLEANSE", "MV_DRENCH", "MV_LIFELINE", "MV_HEALINGWELL", "MV_HIDDENMELEEATTACKBOOST", "MV_HIDDENDECISIVEBLOWBOOST", "MV_HIDDENTIREDBLOW", "MV_HIDDENRANGEATTACKBOOST"
		};
		public System.Collections.Generic.List<MoveDataRow> Rows = new System.Collections.Generic.List<MoveDataRow>();

		public static MoveData Instance
		{
			get { return NestedMoveData.instance; }
		}

		private class NestedMoveData
		{
			static NestedMoveData() { }
			internal static readonly MoveData instance = new MoveData();
		}

		private MoveData()
		{
			Rows.Add( new MoveDataRow("MV_HIDDENREVIVE", "320", "Full Revive", "1", "FALSE", "Power is Percentage of HP", "Only used when user decides to cheat at the end of battle", "Normal", "Melee", "0", "", "0", "", "0", "-1000", "100", "0", "Boost Me", "1", "AggressiveStance1", "No Animation", "No Animation", "AggressiveStance2", "Small Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0", "0", "None", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "1", "FALSE", "1", "1", "", "1", "0", "0", "0"));
			Rows.Add( new MoveDataRow("MV_PASSIVEEFFECTHOTSHOT", "288", "Passive_Hotshot", "1", "TRUE", "Normal", "Melee attacks against this Terra Monster may Burn the attacker.", "Fire", "Melee", "0", "", "0", "", "0", "0", "0", "0", "", "1", "AggressiveStance1", "No Animation", "No Animation", "AggressiveStance2", "No Shake", "0", "0", "0", "0", "0", "0", "0.3", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0", "", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "0", "1", "0"));
			Rows.Add( new MoveDataRow("MV_PASSIVEEFFECTENFLARE", "289", "Passive_Enflare", "1", "TRUE", "Normal", "Fire moves do extra damage when HP is low.", "Fire", "Ranged", "0", "", "0", "", "0", "0", "0", "0", "", "1", "AggressiveStance1", "No Animation", "No Animation", "AggressiveStance2", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1.15", "1.15", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0", "", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "0", "1", "0"));
			Rows.Add( new MoveDataRow("MV_PASSIVEEFFECTSMOKEY", "290", "Passive_Smokey", "1", "TRUE", "Normal", "Reduces opposing Terra Monster's accuracy.", "Fire", "Ranged", "0", "", "0", "", "0", "0", "0", "0", "Hit All", "1", "AggressiveStance1", "No Animation", "No Animation", "AggressiveStance2", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "0.95", "1", "1", "1", "1", "1", "0", "0", "", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "0", "1", "0"));
			Rows.Add( new MoveDataRow("MV_PASSIVEEFFECTOVERDONE", "291", "Passive_Overdone", "1", "TRUE", "Normal", "Fire attacks do extra damage but inflict damage against this Terra Monster.", "Fire", "Ranged", "0", "", "0", "", "0", "0", "0", "0", "", "1", "AggressiveStance1", "No Animation", "No Animation", "AggressiveStance2", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1.25", "1.25", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0", "", "None", "0", "0", "0", "0", "0", "0", "0.025", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "0", "1", "0"));
			Rows.Add( new MoveDataRow("MV_PASSIVEFRESH", "292", "Passive_Fresh", "1", "TRUE", "Normal", "Chance of curing a random ally of a special condition after each turn.", "Normal", "Ranged", "0", "", "0", "", "0", "0", "0", "0", "Boost 2", "1", "AggressiveStance1", "No Animation", "No Animation", "AggressiveStance2", "No Shake", "-0.5", "-0.5", "-0.5", "-0.5", "0", "-0.5", "-0.5", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0", "", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "0", "1", "0"));
			Rows.Add( new MoveDataRow("MV_PASSIVEFREEFLOWING", "293", "Passive_FreeFlowing", "1", "TRUE", "Normal", "Prevents this Terra Monster's Defense stats from being lowered.", "Water", "Ranged", "0", "", "0", "", "0", "0", "0", "0", "Boost Me", "1", "AggressiveStance1", "No Animation", "No Animation", "AggressiveStance2", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0", "", "None", "0", "0", "0", "12", "12", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "0", "1", "0"));
			Rows.Add( new MoveDataRow("MV_PASSIVEDEATHROLLER", "294", "Passive_Deathroller", "1", "TRUE", "Power is Percentage of HP", "Does damage to opponents affected by Sleep, Freeze, or Paralyzed after each turn.", "Water", "Ranged", "0", "", "0", "", "11", "0", "2", "1", "Hit All", "1", "AggressiveStance1", "No Animation", "No Animation", "AggressiveStance2", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0", "", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "0", "1", "0"));
			Rows.Add( new MoveDataRow("MV_PASSIVEABSORB", "295", "Passive_Absorb", "1", "TRUE", "Power is Percentage of HP", "Restores HP when hit by a Water attack.", "Water", "Ranged", "0", "", "0", "", "0", "0", "2", "0", "Boost Me", "1", "AggressiveStance1", "No Animation", "No Animation", "AggressiveStance2", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0", "", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "0", "1", "0"));
			Rows.Add( new MoveDataRow("MV_DURABLE", "296", "Passive_Durable", "1", "TRUE", "Normal", "This Terra Monster cannot be knocked out in one hit.", "Earth", "Ranged", "0", "", "0", "", "0", "0", "0", "0", "Boost Me", "1", "AggressiveStance1", "No Animation", "No Animation", "AggressiveStance2", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0", "", "None", "0", "0", "0", "0", "0", "0", "0", "1", "1", "0", "1", "FALSE", "1", "1", "", "1", "0", "1", "0"));
			Rows.Add( new MoveDataRow("MV_SPORED", "297", "Passive_Spored", "1", "TRUE", "Normal", "Melee attacks to this Terra Monster may paralyze, poison or cause sleep to the attacker.", "Earth", "Ranged", "0", "", "0", "", "0", "0", "0", "0", "", "1", "AggressiveStance1", "No Animation", "No Animation", "AggressiveStance2", "No Shake", "0.1", "0.1", "0.1", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0", "", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "0", "1", "0"));
			Rows.Add( new MoveDataRow("MV_HARDENED", "298", "Passive_Hardened", "1", "TRUE", "Normal", "Prevents this Terra Monster from receiving Decisive Blows.", "Earth", "Ranged", "0", "", "0", "", "0", "0", "0", "0", "Boost Me", "1", "AggressiveStance1", "No Animation", "No Animation", "AggressiveStance2", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0", "", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "FALSE", "1", "1", "", "1", "0", "1", "0"));
			Rows.Add( new MoveDataRow("MV_IMMUNE", "299", "Passive_Immune", "1", "TRUE", "Normal", "Prevents Terra Monster from becoming Poisoned.", "Earth", "Ranged", "0", "", "0", "", "0", "0", "0", "0", "Boost Me", "1", "AggressiveStance1", "No Animation", "No Animation", "AggressiveStance2", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0", "", "None", "0", "0", "4", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "0", "1", "0"));
			Rows.Add( new MoveDataRow("MV_PASSIVELIGHTWEIGHT", "300", "Passive_Lightweight", "1", "TRUE", "Normal", "This Terra Monster has increased evasion but lower attack.", "Air", "Ranged", "0", "", "0", "", "0", "0", "0", "0", "Boost Me", "1", "AggressiveStance1", "No Animation", "No Animation", "AggressiveStance2", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "0.9", "0.9", "1", "1", "1", "1.1", "1", "1", "1", "1", "0", "0", "", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "0", "1", "0"));
			Rows.Add( new MoveDataRow("MV_PASSIVESQUADMATE", "301", "Passive_SquadMate", "1", "TRUE", "Normal", "Chance of making all Air-type allies have no weakness until end of battle.", "Air", "Ranged", "0", "", "0", "", "0", "0", "0", "0", "Boost 2", "1", "AggressiveStance1", "No Animation", "No Animation", "AggressiveStance2", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0", "", "None", "0", "255", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "0", "1", "0"));
			Rows.Add( new MoveDataRow("MV_PASSIVEFLEETWING", "302", "Passive_FleetWing", "1", "TRUE", "Normal", "Raises Evasion each time this Terra Monster flinches.", "Air", "Ranged", "0", "", "0", "", "0", "0", "0", "0", "", "1", "AggressiveStance1", "No Animation", "No Animation", "AggressiveStance2", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0", "", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "0", "1", "0"));
			Rows.Add( new MoveDataRow("MV_PASSIVERAPIDREFLEX", "303", "Passive_RapidReflex", "1", "TRUE", "Normal", "Increases the frequency of multi-hit moves for this Terra Monster.", "Air", "Ranged", "0", "", "0", "", "0", "0", "0", "0", "", "1", "AggressiveStance1", "No Animation", "No Animation", "AggressiveStance2", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0", "", "None", "0", "0", "0", "0", "0", "0", "0", "0", "2", "0", "1", "FALSE", "1", "1", "", "1", "0", "1", "0"));
			Rows.Add( new MoveDataRow("MV_PASSIVECOLDAURA", "304", "Passive_ColdAura", "1", "TRUE", "Normal", "Causes the opposing Terra Monster to use double the amount of energy for attacks.", "Ice", "Ranged", "0", "", "0", "", "0", "0", "0", "0", "", "1", "AggressiveStance1", "No Animation", "No Animation", "AggressiveStance2", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0", "", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "2", "", "1", "0", "0", "0"));
			Rows.Add( new MoveDataRow("MV_PASSIVEHIBERNATED", "305", "Passive_Hibernated", "1", "TRUE", "Normal", "This Terra Monster can't be put to sleep.", "Ice", "Ranged", "0", "", "0", "", "0", "0", "0", "0", "Boost Me", "1", "AggressiveStance1", "No Animation", "No Animation", "AggressiveStance2", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0", "", "None", "0", "0", "2", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "0", "1", "0"));
			Rows.Add( new MoveDataRow("MV_PASSIVECRYSTALLIZED", "306", "Passive_Crystalized", "1", "TRUE", "Normal", "Prevents this Terra Monster's stats from being lowered.", "Ice", "Ranged", "0", "", "0", "", "0", "0", "0", "0", "Boost Me", "1", "AggressiveStance1", "No Animation", "No Animation", "AggressiveStance2", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0", "", "None", "0", "0", "0", "255", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "0", "1", "0"));
			Rows.Add( new MoveDataRow("MV_PASSIVEFROSTBURNER", "307", "Passive_Frostburner", "1", "TRUE", "Normal", "Chance of causing flinch on random opposing Terra Monster after each turn.", "Ice", "Ranged", "0", "", "0", "", "0", "0", "0", "0", "Random Opponent", "1", "AggressiveStance1", "No Animation", "No Animation", "AggressiveStance2", "No Shake", "0", "0", "0", "0", "0.2", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0", "", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "0", "1", "0"));
			Rows.Add( new MoveDataRow("MV_PASSIVEREACTOR", "308", "Passive_Reactor", "1", "TRUE", "Normal", "Raises Speed each time this Terra Monster flinches.", "Electric", "Ranged", "0", "", "0", "", "0", "0", "0", "0", "Boost Me", "1", "AggressiveStance1", "No Animation", "No Animation", "AggressiveStance2", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0", "", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "0", "0", "0"));
			Rows.Add( new MoveDataRow("MV_PASSIVESEMICONDUCTOR", "309", "Passive_Semiconductor", "1", "TRUE", "Normal", "Raises ally's Ranged Defense if this Terra Monster is hit by an Electric attack.", "Electric", "Ranged", "0", "", "0", "", "0", "0", "0", "0", "Boost All", "1", "AggressiveStance1", "No Animation", "No Animation", "AggressiveStance2", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1.2", "1", "1", "1", "1", "1", "1", "1", "0", "0", "", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "0", "0", "0"));
			Rows.Add( new MoveDataRow("MV_PASSIVESHOCKING", "310", "Passive_Shocking", "1", "TRUE", "Normal", "Ranged attacks against this Terra Monster may Paralyze the attacker.", "Electric", "Ranged", "0", "", "0", "", "0", "0", "0", "0", "Hit 1 Only", "1", "AggressiveStance1", "No Animation", "No Animation", "AggressiveStance2", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0", "", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "0", "0", "0"));
			Rows.Add( new MoveDataRow("MV_PASSIVEGROUNDED", "311", "Passive_Grounded", "1", "TRUE", "Normal", "Restores HP when hit by an Electric attack.", "Electric", "Ranged", "0", "", "0", "", "0", "0", "0", "0", "Boost Me", "1", "AggressiveStance1", "No Animation", "No Animation", "AggressiveStance2", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0", "", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "0", "0", "0"));
			Rows.Add( new MoveDataRow("MV_PASSIVESUPERNATURAL", "312", "Passive_Supernatural", "1", "TRUE", "Normal", "This Terra Monster isn't affected by Sleep, Freeze, or Poison.", "Arcane", "Ranged", "0", "", "0", "", "0", "0", "0", "0", "Boost Me", "1", "AggressiveStance1", "No Animation", "No Animation", "AggressiveStance2", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0", "", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "0", "0", "0"));
			Rows.Add( new MoveDataRow("MV_PASSIVEINFECTIOUS", "313", "Passive_Infectious", "1", "TRUE", "Normal", "When this Terra Monster is affected by a special condition, an opponent receives the same condition.", "Arcane", "Ranged", "0", "", "0", "", "0", "0", "0", "0", "Boost Me", "1", "AggressiveStance1", "No Animation", "No Animation", "AggressiveStance2", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0", "", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "TRUE", "1", "1", "", "1", "0", "0", "0"));
			Rows.Add( new MoveDataRow("MV_PASSIVEHEALER", "314", "Passive_Healer", "1", "TRUE", "Normal", "Chance of healing random ally Terra Monster after each turn.", "Arcane", "Ranged", "0", "", "0", "", "0", "0", "0", "0", "Boost Me", "1", "AggressiveStance1", "No Animation", "No Animation", "AggressiveStance2", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0", "", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "0", "0", "0"));
			Rows.Add( new MoveDataRow("MV_PASSIVEMAGICAL", "315", "Passive_Magical", "1", "TRUE", "Normal", "Increases the chances of non-damaging move effects.", "Arcane", "Ranged", "0", "", "0", "", "0", "0", "0", "0", "Boost Me", "1", "AggressiveStance1", "No Animation", "No Animation", "AggressiveStance2", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0", "", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "0", "0", "0"));
			Rows.Add( new MoveDataRow("MV_PASSIVESHARP", "316", "Passive_Sharp", "1", "TRUE", "Normal", "Damages attacking Terra Monsters when struck with a Melee attack.", "Normal", "Ranged", "0", "", "0", "", "0", "0", "0", "0", "Boost Me", "1", "AggressiveStance1", "No Animation", "No Animation", "AggressiveStance2", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0", "", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "0", "0", "0"));
			Rows.Add( new MoveDataRow("MV_PASSIVEHELPER", "317", "Passive_Helper", "1", "TRUE", "Normal", "Chance of this Terra Monster's non-damaging move going first.", "Normal", "Ranged", "0", "", "0", "", "0", "0", "0", "0", "Boost Me", "1", "AggressiveStance1", "No Animation", "No Animation", "AggressiveStance2", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0", "", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "0", "0", "0"));
			Rows.Add( new MoveDataRow("MV_PASSIVERIVAL", "318", "Passive_Rival", "1", "TRUE", "Normal", "Raises this Terra Monsters attack if it shares a type with an opposing monster.", "Normal", "Ranged", "0", "", "0", "", "0", "0", "0", "0", "Boost Me", "1", "AggressiveStance1", "No Animation", "No Animation", "AggressiveStance2", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0", "", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "0", "0", "0"));
			Rows.Add( new MoveDataRow("MV_PASSIVEPRECISE", "319", "Passive_Precise", "1", "TRUE", "Normal", "Raises the chance of decisive blows.", "Normal", "Ranged", "0", "", "0", "", "0", "0", "0", "0", "Boost Me", "1", "AggressiveStance1", "No Animation", "No Animation", "AggressiveStance2", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0", "", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "2", "FALSE", "1", "1", "", "1", "0", "0", "0"));
			Rows.Add( new MoveDataRow("MV_POUNCE", "2", "Pounce", "1", "FALSE", "Normal", "A sudden springing attack that leaps across the field.", "Normal", "Ranged", "0", "", "0", "", "0", "10", "50", "1", "Hit 1 Only", "0.95", "TackleRun", "Light Hit Air", "No Animation", "HitAnim", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_HURL", "23", "Hurl", "1", "FALSE", "Normal", "Throws its entire body into an attack, but may Confuse the user.", "Normal", "Ranged", "0", "", "0", "", "0", "15", "60", "1", "Hit 1 Only", "0.95", "TackleRun", "No Animation", "Starry Light Hit", "HitAnim", "No Shake", "0", "0", "0", "0", "0", "-0.1", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_RAM", "321", "Ram", "1", "FALSE", "Normal", "The user lowers it's head and slams into the opponent. Higher chance of Decisive Blow.", "Normal", "Ranged", "0", "", "0", "", "0", "15", "70", "1", "Hit 1 Only", "0.95", "TackleRun", "Ground Rock Hit", "No Animation", "HitAnim", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.4", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_LUNGE", "28", "Lunge", "2", "FALSE", "Normal", "A sudden rush at the opponent that always hits first.", "Normal", "Ranged", "0", "", "0", "", "0", "20", "85", "1", "Hit 1 Only", "0.95", "TackleRun", "Ground Grey Hit", "No Animation", "HitAnim", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_CHARGE", "14", "Charge", "1", "FALSE", "Normal", "A powerful rush at the opponent that lower's its Ranged Defense.", "Normal", "Ranged", "0", "", "0", "", "0", "50", "100", "1", "Hit 1 Only", "0.95", "TackleRun", "Small Arcane Boost", "Small Gravity Hit", "HitAnim", "Small Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "0.8", "1", "1", "1", "1", "1", "1", "1", "0", "0.1", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_SLAM", "13", "Slam", "1", "FALSE", "Normal", "The user throws their weight into a powerful blow that may cause the opponent to Flinch.", "Normal", "Ranged", "0", "", "0", "", "0", "80", "115", "1", "Hit 1 Only", "0.95", "TackleRun", "Light Hit Air", "Light Hit Air", "HitAnim", "No Shake", "0", "0", "0", "0", "0.3", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_HEADBUTT", "11", "Headbutt", "1", "FALSE", "Normal", "A powerful cranial lunge with a high Decisive Blow chance, but it may Confuse the user.", "Normal", "Ranged", "0", "", "0", "", "0", "70", "130", "1", "Hit 1 Only", "0.95", "TackleRun", "Starry Light Hit", "No Animation", "HitAnim", "No Shake", "0", "0", "0", "0", "0", "-0.15", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.25", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_BODYSLAM", "251", "Body Slam", "1", "FALSE", "Normal", "The full force of the user's body smashes the opponent, causing a shockwave that damages other opponents.", "Normal", "Ranged", "0", "", "0", "", "0", "70", "135", "0.2", "Hit All", "0.95", "TackleRun", "Light Hit Air", "Smokey Blue Explosion", "HitAnim", "Large Shake", "0.15", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_SCRATCH", "5", "Scratch", "1", "FALSE", "Normal", "Inflicts a shallow cut.", "Normal", "Melee", "0", "", "0", "", "0", "15", "55", "1", "Hit 1 Only", "0.95", "ScratchAttack", "Small Gravity Hit", "No Animation", "RangeHit", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_BASH", "4", "Bash", "1", "FALSE", "Normal", "Thumps the opponent over the head with a hevy appendage, which may cause it to Flinch.", "Normal", "Melee", "0", "", "0", "", "0", "15", "65", "1", "Hit 1 Only", "0.95", "ScratchAttack", "Small Blue Hit", "No Animation", "RangeHit", "No Shake", "0", "0", "0", "0", "0.05", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "3", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_CLAW", "7", "Claw", "1.2", "FALSE", "Normal", "A swift rake with claws and talons with a higher chance of going first.", "Normal", "Melee", "0", "", "0", "", "0", "20", "75", "1", "Hit 1 Only", "0.95", "ScratchAttack", "No Animation", "No Animation", "RangeHit", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "3", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_STOMP", "252", "Stomp", "1", "FALSE", "Normal", "Mighty feet pound the opponent into the ground, knocking it off balance and lowering it's Melee Attack.", "Normal", "Melee", "0", "", "0", "", "0", "20", "90", "1", "Hit 1 Only", "0.95", "ScratchAttack", "Light Hit Air", "Light Hit Air", "RangeHit", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "0.9", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_SLASH", "9", "Slash", "1", "FALSE", "Normal", "A swift set of sharp slashes that cause severe damage, with a higher chance of Decisive Blow.", "Normal", "Melee", "0", "", "0", "", "0", "30", "40", "1", "Hit 1 Only", "0.95", "ScratchAttack", "Starry Light Hit", "No Animation", "RangeHit", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "2", "3", "1", "1", "0", "0.4", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_THRASH", "22", "Thrash", "1", "FALSE", "Normal", "A violent attack on the opponent and others around it, but deals some damage to the user.", "Normal", "Melee", "0", "", "0", "", "0", "60", "105", "0.25", "Hit All", "0.95", "ScratchAttack", "Light Hit Air", "No Animation", "RangeHit", "Tiny Shake", "0", "0", "0", "0", "0.15", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0.15", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_MAUL", "27", "Maul", "1", "FALSE", "Normal", "A savage attack that rips away at the opponent.", "Normal", "Melee", "0", "", "0", "", "0", "120", "135", "1", "Hit 1 Only", "0.8", "ScratchAttack", "No Animation", "No Animation", "RangeHit", "No Shake", "0", "0", "0", "0", "0.15", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_RAMPAGE", "21", "Rampage", "1", "FALSE", "Normal", "A uncontrolable attack that wildly assaults all opponents, but Confuses the user.", "Normal", "Melee", "0", "", "0", "", "0", "60", "140", "0.3", "Hit All", "0.95", "ScratchAttack", "No Animation", "No Animation", "RangeHit", "Small Shake", "0", "0", "0", "0", "0", "-1", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_RALLY", "253", "Rally", "1", "FALSE", "Normal", "A motivational call to allies to raise Attack and Speed.", "Normal", "Ranged", "0", "", "0", "", "0", "10", "0", "1", "Boost All", "1", "AggressiveStance1", "Powerup Star 2", "Resurrection", "AggressiveStance2", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1.05", "1.25", "1.25", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_COVER", "18", "Cover", "1", "FALSE", "Normal", "A strong defensive move that raises Ranged Defense.", "Normal", "Ranged", "0", "", "0", "", "0", "25", "0", "1", "Boost Me", "1", "AggressiveStance1", "Shield Rays White", "No Animation", "AggressiveStance2", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1.5", "1", "1", "1", "1", "1", "1", "1", "0", "0", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_BLOCK", "19", "Block", "1", "FALSE", "Normal", "A strong defensive move that raises Melee Defense.", "Normal", "Melee", "0", "", "0", "", "0", "25", "0", "1", "Boost Me", "1", "AggressiveStance1", "Shield Rays White", "No Animation", "AggressiveStance2", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1.5", "1", "1", "1", "1", "1", "1", "0", "0", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_BLIND", "33", "Blind", "1", "FALSE", "Normal", "Throws dirt in the opponent's face, lowering Accuracy and Agility.", "Normal", "Ranged", "0", "", "0", "", "0", "20", "0", "1", "Hit 1 Only", "1", "AggressiveStance1", "Sand Attack (Ranged)", "Light Hit Air", "HitAnim", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "0.75", "0.75", "1", "1", "1", "1", "0", "0", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_ROAR", "32", "Roar", "1", "FALSE", "Normal", "A feral roar that scares the opponents, lowering their Attack.", "Normal", "Ranged", "0", "", "0", "", "0", "20", "0", "1", "Hit All", "1", "AggressiveStance1", "Intense Shield Rays", "No Animation", "HitAnim", "Tiny Shake", "0", "0", "0", "0", "0", "0", "0", "1", "0.75", "0.75", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_VALOR", "254", "Valor", "1", "FALSE", "Power is Percentage of HP", "Inspire an ally to new heights by restoring a little of its HP.", "Normal", "Melee", "0", "", "0", "", "0", "40", "20", "0", "Boost 1", "1", "AggressiveStance1", "Heart Pickup", "No Animation", "AggressiveStance2", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_FORTIFY", "25", "Fortify", "1", "FALSE", "Normal", "Skillfully braces all allies for any attack.", "Normal", "Melee", "0", "", "0", "", "0", "30", "0", "1", "Boost All", "1", "AggressiveStance1", "Pickup Diamond", "No Animation", "AggressiveStance2", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1.25", "1.25", "1", "1", "1", "1", "1", "1", "0", "0", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_PURGE", "248", "Purge", "1", "FALSE", "Normal", "Resets the entire field's status conditions to normal, but reduces the user's Defenses.", "Normal", "Ranged", "0", "", "0", "", "0", "15", "0", "1", "Boost All", "1", "AggressiveStance1", "Splash", "Shield Rays White", "AggressiveStance2", "No Shake", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "1", "1", "1", "0.9", "0.9", "1", "1", "1", "1", "1", "1", "0", "0", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_GALE", "156", "Gale", "1", "FALSE", "Normal", "A strong gust of gale force wind.", "Air", "Ranged", "0", "", "0", "", "0", "10", "40", "1", "Hit 1 Only", "0.95", "RangeAttack", "Vortex Tornado", "Starry Light Hit Air", "RangeHit", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_SONARSTRIKE", "151", "Sonar Strike", "1", "FALSE", "Normal", "Sends a shrieking sound wave toward the opponent that may Confuse it. It also slightly raises all allies Accuracy.", "Air", "Ranged", "0", "", "0", "", "0", "20", "50", "1", "Hit 1 Only", "0.95", "RangeAttack", "Light Hit Air", "No Animation", "RangeHit", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "Hidden Sonar Strike", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_AIRBLAST", "158", "Airblast", "1", "FALSE", "Normal", "Sends a strong blast of air into the opponent. It also slightly raises all allies' Speed.", "Air", "Ranged", "0", "", "0", "", "0", "20", "65", "1", "Hit 1 Only", "0.95", "RangeAttack", "Small Cloud Puff", "No Animation", "RangeHit", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "Hidden Slight Speed Boost", "1", "5", "1", "0"));
			Rows.Add( new MoveDataRow("MV_WHIRLWIND", "217", "Whirlwind", "5", "FALSE", "Normal", "A circling rush of wind engulfs all opponents, strikes first, and increases their Energy usage for the turn.", "Air", "Ranged", "0", "", "0", "", "0", "15", "85", "0.1", "Hit All", "0.95", "RangeAttack", "Light Hit Air", "Light Hit Air", "RangeHit", "No Shake", "0", "0", "0", "0", "0.3", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1.3", "", "1", "4", "1", "0"));
			Rows.Add( new MoveDataRow("MV_JETSTREAM", "213", "Jetstream", "1", "FALSE", "Normal", "A jet of wind strikes the opponent, slightly increasing all allies' Speed and Ranged Attack.", "Air", "Ranged", "0", "", "0", "", "0", "40", "100", "1", "Hit 1 Only", "0.95", "RangeAttack", "Arcane Starry Hit", "No Animation", "RangeHit", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "Hidden Jetstream", "1", "5", "1", "0"));
			Rows.Add( new MoveDataRow("MV_CYCLONICSTRIKE", "211", "Cyclonic Strike", "1.5", "FALSE", "Normal", "A storm attack with cyclonic fury hits an opponent multiple times, often goes first, and slightly raises all allies' Attack.", "Air", "Ranged", "0", "", "0", "", "0", "70", "40", "0", "Hit 1 Only", "0.95", "RangeAttack", "Light Hit Air", "No Animation", "RangeHit", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "2", "5", "1", "1", "0", "0.1", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "Hidden Slight Attack Boost", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_TORNADO", "150", "Tornado", "1", "FALSE", "Normal", "A mighty, rotating column of wind that tears through a random opponent. It also slightly raises all allies' chance for a Decisive Blow this turn.", "Air", "Ranged", "0", "", "0", "", "0", "50", "150", "1", "Random Opponent", "0.95", "RangeAttack", "Vortex Tornado", "Vortex Air Blue", "RangeHit", "Small Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "Hidden Tornado", "1", "4", "1", "0"));
			Rows.Add( new MoveDataRow("MV_TYPHOON", "218", "Typhoon", "1", "FALSE", "Normal", "Channels a powerful storm of water, rain and wind, damaging all opponents, but slightly lowers all allies' Defenses.", "Air", "Ranged", "0", "", "0", "", "0", "90", "130", "0.2", "Hit All", "0.8", "RangeAttack", "Vortex Tornado", "Vortex Air Blue", "RangeHit", "Large Shake", "0.3", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "Hidden Typhoon", "1", "5", "1", "0"));
			Rows.Add( new MoveDataRow("MV_HIDDENSONARSTRIKE", "329", "Hidden Sonar Strike", "1", "FALSE", "Normal", "Hidden Move. Used with Sonar Strike only.", "Air", "Ranged", "0", "", "0", "", "0", "0", "0", "1", "Boost All", "1", "NoAnim", "No Animation", "No Animation", "NoAnim", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1.1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_HIDDENSLIGHTSPEEDBOOST", "330", "Hidden Slight Speed Boost", "1", "FALSE", "Normal", "Hidden Move. Generic. Slight 10% Speed boost to all allies.", "Air", "Ranged", "0", "", "0", "", "0", "0", "0", "1", "Boost All", "1", "NoAnim", "No Animation", "No Animation", "NoAnim", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1.1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_HIDDENJETSTREAM", "331", "Hidden Jetstream", "1", "FALSE", "Normal", "Hidden Move. Used with Jetstream only.", "Air", "Ranged", "0", "", "0", "", "0", "0", "0", "1", "Boost All", "1", "NoAnim", "No Animation", "No Animation", "NoAnim", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1.1", "1.1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_HIDDENSLIGHTATTACKBOOST", "332", "Hidden Slight Attack Boost", "1", "FALSE", "Normal", "Hidden Move. Generic. Slight 10% Melee and Ranged Attack boost to all allies.", "Air", "Ranged", "0", "", "0", "", "0", "0", "0", "1", "Boost All", "1", "NoAnim", "No Animation", "No Animation", "NoAnim", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1.1", "1.1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_HIDDENTORNADO", "333", "Hidden Tornado", "1", "FALSE", "Normal", "Hidden Move. Used with Tornado only.", "Air", "Ranged", "0", "", "0", "", "0", "0", "0", "1", "Boost All", "1", "NoAnim", "No Animation", "No Animation", "NoAnim", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1.2", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_HIDDENTYPHOON", "334", "Hidden Typhoon", "1", "FALSE", "Normal", "Hidden Move. Used with Typhoon only.", "Air", "Ranged", "0", "", "0", "", "0", "0", "0", "1", "Boost All", "1", "NoAnim", "No Animation", "No Animation", "NoAnim", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "0.85", "0.85", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_PECK", "212", "Peck", "1", "FALSE", "Normal", "A quick strike with a sharp beak.", "Air", "Melee", "0", "", "0", "", "0", "10", "45", "1", "Hit 1 Only", "0.95", "TackleRun", "No Animation", "Starry Light Hit Air", "HitAnim", "No Shake", "0", "0", "0", "0", "0", "0.4", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_SPIRALDIVE", "152", "Spiral Dive", "1", "FALSE", "Normal", "A spiraling descent, ending in harsh talon and hooked beak, damages the opponent. It also slightly raises all allies' Multi Hit chances this turn.", "Air", "Melee", "0", "", "0", "", "0", "15", "50", "1", "Hit 1 Only", "0.95", "TackleRun", "Vortex Air Blue", "Small Blue Hit", "HitAnim", "Tiny Shake", "0", "0", "0", "0", "0", "0.2", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "Hidden Spiral Dive", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_DIVEBOMB", "155", "Divebomb", "1", "FALSE", "Normal", "The user tucks in its wings and charges from a low altitude, damaging the user as well.", "Air", "Melee", "0", "", "0", "", "0", "20", "80", "1", "Hit 1 Only", "0.95", "TackleRun", "No Animation", "Ground Rock Hit", "HitAnim", "Small Shake", "0", "0", "0", "0", "0", "0", "0", "0.5", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0.2", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_WINGBLADE", "214", "Wing Blade", "1", "FALSE", "Normal", "A sharp wing strike that may cause the opponent to Flinch. It also slightly raises all allies' Attacks. ", "Air", "Melee", "0", "", "0", "", "0", "20", "80", "1", "Hit 1 Only", "0.95", "ScratchAttack", "Blue Sparks", "Light Hit Air", "HitAnim", "No Shake", "0", "0", "0", "0", "0.3", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.25", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "Hidden Wing Blade", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_TALONSLASH", "153", "Talon Slash", "1", "FALSE", "Normal", "An attack that delivers two successive slashes with its talons. It also slightly raises all allies' Speed.", "Air", "Melee", "0", "", "0", "", "0", "30", "50", "1", "Hit 1 Only", "1", "ScratchAttack", "Vortex Tornado", "Vortex Air Blue", "HitAnim", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "2", "2", "1", "1", "0", "0.15", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "Hidden Slight Speed Boost", "1", "4", "1", "0"));
			Rows.Add( new MoveDataRow("MV_AIRSTRIKE", "157", "Air Strike", "1", "FALSE", "Normal", "Utilizes the skies to deliver a series of rapid air attacks to an opponent that often go first, lowering its Agility.", "Air", "Melee", "0", "", "0", "", "0", "40", "50", "1", "Hit 1 Only", "0.95", "TackleRun", "Vortex Tornado", "Light Hit Air", "HitAnim", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "0.9", "2", "5", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "5", "1", "0"));
			Rows.Add( new MoveDataRow("MV_WARWING", "216", "War Wing", "1", "FALSE", "Normal", "The user tries to manuever its allies into position, then cuts through an opponent. It also slightly raises all allies' Attack.", "Air", "Melee", "0", "", "0", "", "0", "40", "130", "1", "Hit 1 Only", "0.95", "ScratchAttack", "Vortex Red", "Starry Light Hit", "HitAnim", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "Hidden Slight Attack Boost", "1", "4", "1", "0"));
			Rows.Add( new MoveDataRow("MV_SKYHAMMER", "154", "Sky Hammer", "1", "FALSE", "Normal", "A sky assault that drops like a hammer on the opponent, lowering its Defense and possibly Paralyzing it. This move does additional damage if the opponent is already Paralyzed.", "Air", "Melee", "0", "", "1", "Hidden Sky Hammer", "0", "100", "100", "1", "Splash Range 1", "0.9", "TackleRun", "Vortex Tornado", "Light Hit Air", "HitAnim", "No Shake", "0.2", "0", "0", "0", "0", "0", "0", "0.5", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "5", "1", "0"));
			Rows.Add( new MoveDataRow("MV_HIDDENSPIRALDIVE", "334", "Hidden Spiral Dive", "1", "FALSE", "Normal", "Hidden Move. Used with Spiral Dive only.", "Air", "Melee", "0", "", "0", "", "0", "0", "0", "1", "Boost All", "1", "NoAnim", "No Animation", "No Animation", "NoAnim", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1.1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_HIDDENWINGBLADE", "335", "Hidden Wing Blade", "1", "FALSE", "Normal", "Hidden Move. Used with Wing Blade only.", "Air", "Melee", "0", "", "0", "", "0", "0", "0", "1", "Boost All", "1", "NoAnim", "No Animation", "No Animation", "NoAnim", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1.1", "1.1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1.1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_HIDDENSKYHAMMER", "336", "Hidden Sky Hammer", "1", "FALSE", "Normal", "Hidden Move. Used with Sky Hammer only.", "Air", "Melee", "0", "", "0", "", "0", "0", "100", "1", "Hit 1 Only", "1", "NoAnim", "No Animation", "No Animation", "NoAnim", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1.1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_WINDSPEED", "261", "Windspeed", "1", "FALSE", "Normal", "Creates a pressure gradient, boosting all allies' Speed.", "Air", "Ranged", "0", "", "0", "", "0", "35", "0", "1", "Boost All", "1", "AggressiveStance1", "Small Cloud Puff", "Fairy Dust (Cold)", "AggressiveStance2", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1.5", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_FOG", "209", "Fog", "1", "FALSE", "Normal", "Fog rolls in to reduce all allies' Accuracy and Ranged Attack.", "Air", "Melee", "0", "", "0", "", "0", "15", "0", "1", "Hit All", "1", "AggressiveStance1", "Smoke Column Red", "Small Cloud Puff", "AggressiveStance2", "No Shake", "0", "0", "0", "0", "0", "0", "0", "0", "0.75", "1", "1", "1", "0.95", "1", "1", "1", "1", "1", "0", "0", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_CLOUDWALL", "215", "Cloudwall", "1", "FALSE", "Normal", "A mist of sight obscuring cloud, which raises all allies' Ranged Defense.", "Air", "Melee", "0", "", "0", "", "0", "15", "0", "1", "Boost All", "1", "AggressiveStance1", "Smoke Column Black", "Smoke Column Red", "AggressiveStance2", "No Shake", "0", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1.5", "1", "1", "1", "1", "1", "1", "1", "0", "0", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_BIRDSONG", "275", "Birdsong", "1", "FALSE", "Normal", "Lures opponent into false sense of security, making the target vulnverable to Air attacks. ", "Air", "Ranged", "0", "", "0", "", "0", "25", "0", "0", "Hit 1 Only", "1", "AggressiveStance1", "Small Blue Hit", "No Animation", "AggressiveStance2", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "3", "0", "Standard", "Air", "1", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_HAWKEYE", "210", "Hawkeye", "1", "FALSE", "Normal", "Improves the attacker's sight, raising Accuracy and Ranged Attack.", "Air", "Ranged", "0", "", "0", "", "0", "15", "0", "1", "Hit 1 Only", "1", "AggressiveStance1", "Power Aura", "No Animation", "AggressiveStance2", "No Shake", "0", "0", "0", "0", "0", "0", "0", "0", "1.25", "1", "1", "1", "1.15", "1", "1", "1", "1", "1", "0", "0", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_VACUUM", "276", "Vacuum", "1", "FALSE", "Normal", "Creates an area of high pressure over allies, extracting all status effects, and protects them against Stat lowering.", "Air", "Ranged", "0", "", "0", "", "0", "25", "0", "0", "Hit All", "1", "AggressiveStance1", "Small Gravity Hit", "Rainbow Soul Escape", "AggressiveStance2", "No Shake", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0", "Standard", "None", "0", "0", "0", "255", "255", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "Hidden Clear Ally Status", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_SOOTHINGWIND", "277", "Soothing Wind", "1", "FALSE", "Power is Percentage of HP", "Cover all allies in soothing wind, which has powers to restore HP.", "Air", "Ranged", "0", "", "0", "", "0", "90", "50", "0", "Boost All", "1", "AggressiveStance1", "Shield Rays White", "Heart Pickup 2", "AggressiveStance2", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_HIDDENCLEARALLYSTATUS", "337", "Hidden Clear Ally Status", "1", "FALSE", "Normal", "Hidden Move. Generic. Removes all ally status effects.", "Air", "Ranged", "0", "", "0", "", "0", "0", "0", "0", "Boost All", "1", "NoAnim", "Shield Rays White", "Heart Pickup 2", "NoAnim", "No Shake", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_ASTRALBLAST", "182", "Astral Blast", "1", "FALSE", "Normal", "A magical blast of cosmic energy.", "Arcane", "Ranged", "0", "", "0", "", "0", "10", "40", "1", "Hit 1 Only", "0.95", "RangeAttack", "Skull Eyes", "Light Hit Air", "RangeHit", "No Shake", "0", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_NAUSEA", "189", "Nausea", "1", "FALSE", "Normal", "A sickening assault on the senses that may Poison the opponent.", "Arcane", "Ranged", "0", "", "0", "", "0", "25", "50", "1", "Hit 1 Only", "0.95", "RangeAttack", "Poison Cloud", "Plain Green Hit", "RangeHit", "No Shake", "0", "0", "0.25", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_SHRIEK", "185", "Shriek", "1", "FALSE", "Normal", "A terrifying spirit attack screams toward the opponents.", "Arcane", "Ranged", "0", "", "0", "", "0", "20", "65", "0.15", "Hit All", "0.95", "RangeAttack", "Bat Escapes", "No Animation", "RangeHit", "No Shake", "0.15", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "4", "1", "0"));
			Rows.Add( new MoveDataRow("MV_POSSESS", "184", "Possess", "1", "FALSE", "Normal", "Channels a dark spirit to attack the opponent, draining some of the user's HP, and possibly Confusing the opponent.", "Arcane", "Ranged", "0", "", "0", "", "0", "30", "80", "1", "Hit 1 Only", "0.95", "RangeAttack", "Skull Eyes", "Soul Escape", "RangeHit", "Small Shake", "0", "0", "0", "0", "0", "0.5", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0.25", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "4", "1", "0"));
			Rows.Add( new MoveDataRow("MV_SHADOWBOLT", "220", "Shadowbolt", "1", "FALSE", "Normal", "A bolt of dark energy that breaks through enemy Defenses.", "Arcane", "Ranged", "0", "", "0", "", "0", "40", "100", "1", "Hit 1 Only", "0.95", "RangeAttack", "Smokey Blue Explosion", "Shield Rays", "RangeHit", "No Shake", "0", "0", "0", "0", "0", "0", "0", "0", "1", "1", "0.9", "0.9", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "5", "1", "0"));
			Rows.Add( new MoveDataRow("MV_PLAGUEWAVE", "187", "Plaguewave", "1", "FALSE", "Normal", "A cloud of sickness attacks all opponents and may Poison and Burn them.", "Arcane", "Ranged", "0", "", "0", "", "0", "60", "40", "1", "Hit All", "0.95", "RangeAttack", "Death Skull Rotate", "Soul Escape 2", "RangeHit", "No Shake", "0", "0", "0.3", "0", "0", "0", "0.3", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "5", "1", "0"));
			Rows.Add( new MoveDataRow("MV_ARCANEMISSILES", "188", "Arcane Missiles", "1", "FALSE", "Normal", "A barrage of spell feuled missiles rocket at the opponent, causing several hits with a high chance of Decisive Blows.", "Arcane", "Ranged", "0", "", "0", "", "0", "140", "40", "1", "Hit 1 Only", "0.95", "RangeAttack", "Death Skull Rotate", "Intense Shield Rays", "RangeHit", "Small Shake", "0", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "3", "5", "1", "1", "0", "0.5", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "5", "1", "0"));
			Rows.Add( new MoveDataRow("MV_VORTEX", "190", "Vortex", "0.1", "FALSE", "Normal", "Sends the opponent into a swirling maelstrom of dark energy that may tear it apart, or release it unscathed.", "Arcane", "Ranged", "0", "", "0", "", "0", "140", "140", "1", "Hit 1 Only", "0.25", "RangeAttack", "Death Skull Rotate", "Vortex Red", "RangeHit", "Small Shake", "0", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "5", "1", "0"));
			Rows.Add( new MoveDataRow("MV_HAUNT", "180", "Haunt", "1", "FALSE", "Normal", "The user surrounds the opponent with its dark and ghostly power.", "Arcane", "Melee", "0", "", "0", "", "0", "10", "45", "1", "Hit 1 Only", "0.95", "RangeAttack", "Smokey Blue Explosion", "Death Ghost", "HitAnim", "No Shake", "0", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_VEX", "181", "Vex", "1", "FALSE", "Normal", "Causes brain splitting mental distress to the opponent and may Confuse it.", "Arcane", "Melee", "0", "", "0", "", "0", "20", "55", "1", "Hit 1 Only", "0.95", "RangeAttack", "Skull Eyes", "Arcane Starry Hit", "HitAnim", "No Shake", "0", "0", "0", "0", "0", "0.25", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_DARKBITE", "257", "Dark Bite", "1", "FALSE", "Normal", "A sinister bite that may Burn the opponent.", "Arcane", "Melee", "0", "", "0", "", "0", "20", "75", "1", "Hit 1 Only", "0.95", "RangeAttack", "Poison Souls Cloud", "No Animation", "HitAnim", "No Shake", "0", "0", "0", "0", "0", "0", "0.25", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "4", "1", "0"));
			Rows.Add( new MoveDataRow("MV_SHADOWFANG", "260", "Shadow Fang", "1", "FALSE", "Normal", "A snarling attack that may cause the opponent to Flinch.", "Arcane", "Melee", "0", "", "0", "", "0", "25", "90", "1", "Hit 1 Only", "0.95", "RangeAttack", "Arcane Starry Hit", "Intense Blue Shield Rays", "HitAnim", "No Shake", "0", "0", "0", "0", "0.15", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "4", "1", "0"));
			Rows.Add( new MoveDataRow("MV_PETRIFY", "221", "Petrify", "1", "FALSE", "Normal", "A deathly scare that frightens the opponent and may Paralyze them.", "Arcane", "Melee", "0", "", "0", "", "0", "70", "80", "1", "Hit 1 Only", "0.95", "RangeAttack", "Small Gravity Hit", "Soul Escape", "HitAnim", "Large Shake", "0.5", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "5", "1", "0"));
			Rows.Add( new MoveDataRow("MV_NIGHTMARE", "223", "Nightmare", "1", "FALSE", "Normal", "Causes a terrifying mental encounter for the opponent that does additional damage if the opponent is Asleep.", "Arcane", "Melee", "0", "", "2", "Hidden Nightmare", "0", "140", "80", "1", "Hit 1 Only", "0.95", "RangeAttack", "Bat Escapes", "Soul Escape", "HitAnim", "No Shake", "0", "0", "0", "0", "0", "0", "0", "0", "0.9", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "5", "1", "0"));
			Rows.Add( new MoveDataRow("MV_TORMENT", "256", "Torment", "1", "FALSE", "Normal", "Causes all opponents severe mental anguish to the point of insanity, possibly causing Confusion.", "Arcane", "Melee", "0", "", "0", "", "0", "120", "120", "0.2", "Hit All", "0.95", "RangeAttack", "Power Aura", "Death Skull Rotate", "HitAnim", "No Shake", "0", "0", "0", "0", "0", "0.33", "0", "1", "1", "1", "1", "1", "1", "1", "1", "5", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "4", "1", "0"));
			Rows.Add( new MoveDataRow("MV_VOID", "191", "Void", "0.9", "FALSE", "Normal", "Powerful dark matter inflicts pain on all opponents, lowering their defense.", "Arcane", "Melee", "0", "", "0", "", "0", "120", "60", "1", "Hit All", "0.95", "RangeAttack", "Vortex Red", "Black Fireball", "HitAnim", "Large Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "0.25", "0.25", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "5", "1", "0"));
			Rows.Add( new MoveDataRow("MV_HIDDENNIGHTMARE", "328", "Hidden Nightmare", "1", "FALSE", "Normal", "Hidden Move. Used with Nightmare only.", "Arcane", "Melee", "0", "", "0", "", "0", "0", "80", "1", "Hit 1 Only", "1", "NoAnim", "Bat Escapes", "Soul Escape", "HitAnim", "No Shake", "0", "0", "0", "0", "0", "0", "0", "0", "0.9", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "5", "1", "0"));
			Rows.Add( new MoveDataRow("MV_ILLUSION", "183", "Illusion", "1", "FALSE", "Normal", "An illusion that raises user's Defense and lowers enemy Accuracy.", "Arcane", "Melee", "0", "", "0", "", "0", "40", "0", "1", "Hit 1 Only", "1", "AggressiveStance1", "Intense Shield Rays", "Shield Rays White", "AggressiveStance2", "No Shake", "0", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1.25", "1", "0.75", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_PAROXYSM", "219", "Paroxysm", "1", "FALSE", "Normal", "Creates a sudden burst of energy, increasing an ally's Speed.", "Arcane", "Melee", "0", "", "0", "", "0", "20", "0", "1", "Boost 1", "1", "AggressiveStance1", "Small Arcane Boost", "No Animation", "AggressiveStance2", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1.25", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_FRENZY", "259", "Frenzy", "1", "FALSE", "Normal", "Places an ally into a frenzied state, increasing its Melee Attack.", "Arcane", "Melee", "0", "", "0", "", "0", "20", "0", "0", "Boost 1", "1", "AggressiveStance1", "Cartoon Fight Sparks", "No Animation", "AggressiveStance2", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1.5", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_FLASHHEAL", "241", "Flash Heal", "2", "FALSE", "Power is Percentage of HP", "A quick healing spell that restores HP. It will go before most moves.", "Arcane", "Ranged", "0", "", "0", "", "0", "40", "25", "1", "Boost 1", "1", "AggressiveStance1", "Flash", "Heart Pickup 3", "AggressiveStance2", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_BARRIER", "243", "Barrier", "2", "FALSE", "Normal", "The user raises a mystic shield that blocks condition changes, one hit defeats, and Decisive Blows. It also raises its Defenses.", "Arcane", "Melee", "0", "", "0", "", "0", "100", "0", "1", "Boost 1", "1", "AggressiveStance1", "Power Aura", "Shield Rays White", "AggressiveStance2", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0.05", "Standard", "None", "0", "0", "127", "255", "0", "0", "0", "1", "1", "1", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_SACREDSCAR", "258", "Sacred Scar", "1.2", "FALSE", "Normal", "Creates an arcane mark on a target, making it vunerable to Arcane attacks.", "Arcane", "Ranged", "0", "", "0", "", "0", "30", "0", "0", "Hit 1 Only", "1", "AggressiveStance1", "Disruptive Force", "No Animation", "AggressiveStance2", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "5", "0.05", "Standard", "Arcane", "1", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "4", "1", "0"));
			Rows.Add( new MoveDataRow("MV_AURORA", "240", "Aurora", "1", "FALSE", "Power is Percentage of HP", "A mystical aura of swirling light surrounds the allies and restores some HP, but drains some from the user. It also removes Paralysis and Confusion from allies.", "Arcane", "Ranged", "0", "", "0", "", "0", "70", "30", "1", "Boost 2", "1", "AggressiveStance1", "Resurrection", "Heart Pickup", "AggressiveStance2", "No Shake", "-1", "0", "0", "0", "0", "-1", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "4", "5", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0.15", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_MUDSLING", "12", "Mudsling", "1", "FALSE", "Normal", "Hurls a chunk of wet earth at the opponent, dirtying them up a bit.", "Earth", "Ranged", "0", "", "0", "", "0", "10", "35", "1", "Hit 1 Only", "0.95", "RangeAttack", "No Animation", "Ground Rock Hit", "RangeHit", "No Shake", "0", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "0.95", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_POISON", "15", "Poison", "1", "FALSE", "Normal", "Inflicts a venomous wound, Poisoning the opponent.", "Earth", "Ranged", "0", "", "0", "", "0", "35", "45", "1", "Hit 1 Only", "0.95", "RangeAttack", "No Animation", "Poison Cloud", "RangeHit", "No Shake", "0", "0", "1", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_LEECH", "26", "Leech", "1", "FALSE", "Normal", "Spores drain the life from the opponent, restoring some HP to the user.", "Earth", "Ranged", "0", "", "0", "", "0", "35", "60", "1", "Hit 1 Only", "0.95", "RangeAttack", "Fairy Dust (Green)", "Plain Green Hit", "RangeHit", "No Shake", "0", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "-0.15", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_ENTANGLE", "136", "Entangle", "1", "FALSE", "Normal", "Ensnares the opponent in a cluster of vines, lowering its Speed as it twists.", "Earth", "Ranged", "0", "", "0", "", "0", "20", "75", "1", "Hit 1 Only", "0.95", "RangeAttack", "Leave Whirlwind", "Leaves Hit Ground", "RangeHit", "No Shake", "0", "0", "0", "0", "0", "0", "0", "0.85", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "0", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_MUDSLIDE", "122", "Mudslide", "1", "FALSE", "Normal", "Channels a muddy torrent at the opponent and may Paralyze it. This move does additional damage if the user is already Paralyzed.", "Earth", "Ranged", "0", "", "0", "", "0", "80", "90", "1", "Hit 1 Only", "0.95", "RangeAttack", "Dirt Ball", "Ground Rock Hit", "RangeHit", "No Shake", "0.2", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "0", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_SANDSTORM", "127", "Sandstorm", "1", "FALSE", "Normal", "Blows a bellowing storm of sand, confounding the enemy, reducing their Accuracy and ability to deliver Decisive Blows.", "Earth", "Ranged", "0", "", "0", "", "0", "100", "110", "1", "Hit 1 Only", "0.95", "RangeAttack", "Ground Rock Hit", "No Animation", "RangeHit", "No Shake", "0", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "0.75", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "0", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_THORNSTORM", "16", "Thornstorm", "1", "FALSE", "Normal", "A storm of sharp thorns assault all opponents, hitting multiple times.", "Earth", "Ranged", "0", "", "0", "", "0", "70", "30", "1", "Hit 1 Only", "0.95", "RangeAttack", "Ground Grey Hit", "No Animation", "RangeHit", "Tiny Shake", "0", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "4", "8", "1", "1", "0", "0.2", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "0", "FALSE", "1", "1", "", "1", "4", "1", "0"));
			Rows.Add( new MoveDataRow("MV_NATURESFURY", "17", "Nature's Fury", "1", "FALSE", "Normal", "Unleashes the forces of nature upon your opponent, ripping all opponents with splinters and bramble. It also boosts the user's Melee Attack and Defense.", "Earth", "Ranged", "0", "", "0", "", "0", "140", "130", "0.2", "Hit All", "0.95", "RangeAttack", "Drill Ground Hit", "Ground Grey Hit", "RangeHit", "Large Shake", "0", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "0", "FALSE", "1", "1", "Hidden Nature's Fury", "1", "4", "1", "0"));
			Rows.Add( new MoveDataRow("MV_HIDDENMUDSLIDE", "327", "Hidden Mudslide", "1", "FALSE", "Normal", "Hidden Move. Used with Mudslide only.", "Earth", "Ranged", "0", "", "0", "", "0", "0", "90", "1", "Hit 1 Only", "1", "RangeAttack", "Ground Rock Hit", "Ground Rock Hit", "NoAnim", "No Shake", "0.2", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "0", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_HiDDENNATURESFURY", "338", "Hidden Nature's Fury", "1", "FALSE", "Normal", "Hidden Move. Used with Nature's Fury only.", "Earth", "Ranged", "0", "", "0", "", "0", "0", "0", "1", "Boost Me", "1", "RangeAttack", "No Animation", "No Animation", "NoAnim", "No Shake", "0", "0", "0", "0", "0", "0", "0", "0", "1.25", "1.25", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "0", "FALSE", "1", "1", "", "1", "4", "1", "0"));
			Rows.Add( new MoveDataRow("MV_SPLINTER", "125", "Splinter", "1", "FALSE", "Normal", "A forest powered strike against the opponent.", "Earth", "Melee", "0", "", "0", "", "0", "10", "40", "1", "Hit 1 Only", "0.95", "ScratchAttack", "Plain Green Hit", "Ground Wood Hit", "HitAnim", "No Shake", "0", "0", "0.3", "0", "0.05", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_WHIPLASH", "139", "Whiplash", "1", "FALSE", "Normal", "A quick lashing attack that hits an opponent multiple times.", "Earth", "Melee", "0", "", "0", "", "0", "15", "20", "1", "Hit 1 Only", "0.95", "TackleRun", "Leaves Thrower", "Plain Green Hit", "HitAnim", "No Shake", "0", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "2", "4", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_ROCKSMASH", "137", "Rocksmash", "1", "FALSE", "Normal", "A crushing, stone-like blow that may cause the opponent to Flinch.", "Earth", "Melee", "0", "", "0", "", "0", "25", "70", "1", "Hit 1 Only", "0.95", "ScratchAttack", "Small Cloud Puff", "Ground Grey Hit", "HitAnim", "Tiny Shake", "0", "0", "0", "0", "0.4", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "-0.1", "0", "1", "0", "0", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_FORESTKNUCKLE", "29", "Forest Knuckle", "1", "FALSE", "Normal", "A powerful strike with earthy knuckles of wood and stone that boosts the user's Melee Attack.", "Earth", "Melee", "0", "", "0", "", "0", "30", "85", "1", "Hit 1 Only", "0.95", "ScratchAttack", "Plain Green Hit", "Leaves Hit Ground", "HitAnim", "Tiny Shake", "0", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "0", "FALSE", "1", "1", "Hidden Melee Attack Boost", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_STUMPSLAM", "132", "Stump Slam", "1", "FALSE", "Normal", "The user pounds the opponent down with heavy blows, with a higher chance of Decisive Blow.", "Earth", "Melee", "0", "", "0", "", "0", "60", "100", "1", "Hit 1 Only", "0.95", "ScratchAttack", "Ground Wood Hit", "Leaves Hit Ground", "HitAnim", "Small Shake", "0", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.4", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "0", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_WILLOWMAKER", "123", "Willowmaker", "1", "FALSE", "Normal", "The sacred power of the woods take hold of the user, raising its future chances at Decisive Blows while it deals damage to the opponent.", "Earth", "Melee", "0", "", "0", "", "0", "70", "120", "1", "Hit 1 Only", "0.95", "ScratchAttack", "Ground Wood Hit", "Leaves Hit Ground", "HitAnim", "Small Shake", "0", "0", "0.6", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.1", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "0", "FALSE", "1", "1", "Hidden Decisive Blow Boost", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_STAMPEDE", "124", "Stampede", "1", "FALSE", "Normal", "A frenzied and stomping rush that rolls over all opponents, but is less accurate.", "Earth", "Melee", "0", "", "0", "", "0", "100", "90", "0.5", "Hit All", "0.75", "ScratchAttack", "Cartoon Fight", "Drill Ground Hit", "HitAnim", "Large Shake", "0", "0", "0", "0", "0", "0", "0", "0", "0.95", "0.95", "1", "0.95", "1", "1", "1", "1", "1", "1", "0", "0.1", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "0", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_EARTHQUAKE", "133", "Earthquake", "0.75", "FALSE", "Normal", "Sends a huge shockwave through the ground, propelling shards of rock skyward, and hitting all opponents. It will often go last.", "Earth", "Melee", "0", "", "0", "", "0", "120", "80", "1", "Hit All", "0.95", "ScratchAttack", "Ground Rock Hit", "Drill Ground Hit", "HitAnim", "Large Shake", "0", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "0.9", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "0", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_FOCUS", "230", "Focus", "1", "FALSE", "Normal", "The silence of the forest let's the user increase an ally's focus, raising its Ranged Attack.", "Earth", "Ranged", "0", "", "0", "", "0", "30", "0", "1", "Boost 1", "1", "AggressiveStance1", "Power Aura", "Light Hit Air", "AggressiveStance2", "No Shake", "0", "0", "0", "0", "0", "0", "0", "0", "1.15", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_REJUVENATE", "130", "Rejuvenate", "1", "FALSE", "Power is Percentage of HP", "Provides an ally a burst of nutrients to regain some HP.", "Earth", "Melee", "0", "", "0", "", "0", "45", "50", "1", "Boost 1", "1", "AggressiveStance1", "No Animation", "No Animation", "AggressiveStance2", "No Shake", "0", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_ENSNARE", "31", "Ensnare", "1", "FALSE", "Normal", "Vines wrap the opponent, lowering its Melee Defense, Speed, and Agility.", "Earth", "Melee", "0", "", "0", "", "0", "15", "0", "1", "Hit 1 Only", "1", "AggressiveStance1", "Resurrection", "No Animation", "HitAnim", "No Shake", "0", "0", "0", "0", "0", "0", "0", "0.5", "1", "1", "1", "0.5", "1", "0.75", "1", "1", "1", "1", "0", "0", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_STONEHIDE", "135", "Stonehide", "1", "FALSE", "Normal", "Toughens the hide to rock-like strength, increasing an ally's Defenses.", "Earth", "Melee", "0", "", "0", "", "0", "25", "0", "1", "Boost 1", "1", "AggressiveStance1", "Ground Rock Hit", "Pickup Diamond", "AggressiveStance2", "No Shake", "0", "0", "0", "0", "0", "0", "0", "0", "1", "1", "2", "2", "1", "1", "1", "1", "1", "1", "0", "0", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_VINEGRAFT", "249", "Vine Graft", "1.2", "FALSE", "Normal", "Target sprouts vines, making it vulnerable to Earth attacks.", "Earth", "Ranged", "0", "", "0", "", "0", "15", "0", "1", "Hit 1 Only", "1", "AggressiveStance1", "Green Firewall", "Leave Whirlwind", "HitAnim", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "Standard", "Earth", "1", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_SERENITY", "246", "Serenity", "1", "FALSE", "Normal", "Channels the power of peaceful quiet of the woods, raising Decisive Blow chances for all allies.", "Earth", "Melee", "0", "", "0", "", "0", "15", "0", "1", "Boost All", "1", "AggressiveStance1", "Resurrection", "Shiny Item", "AggressiveStance2", "No Shake", "0", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "2", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_CAMOUFLAGE", "239", "Camouflage", "1", "FALSE", "Normal", "Vines, leaves and branches rise to surround all allies, increasing their Defenses and removing weakness to Air.", "Earth", "Melee", "0", "", "0", "", "0", "15", "0", "1", "Boost All", "1", "AggressiveStance1", "Falling Leaves", "Light Hit Ground Green", "AggressiveStance2", "No Shake", "0", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1.5", "1.5", "1", "1", "1", "1", "1", "1", "0", "0", "Standard", "None", "0", "8", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_HEALINGPOD", "238", "Healing Pod", "1", "FALSE", "Power is Percentage of HP", "Produces glowing pods that burst, restoring HP to all allies with its nutritious properties.", "Earth", "Ranged", "0", "", "0", "", "0", "75", "30", "1", "Boost All", "1", "AggressiveStance1", "Leaves Hit Air", "Heart Pickup", "AggressiveStance2", "Small Shake", "0", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_SHOCK", "237", "Shock", "1", "FALSE", "Normal", "A shocking spark of electricity that jumps to an additional opponent.", "Electric", "Ranged", "0", "", "0", "", "0", "15", "35", "0.5", "Splash Range 1", "0.95", "RangeAttack", "ElectroSpark", "No Animation", "RangeHit", "No Shake", "0", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "5", "1", "0"));
			Rows.Add( new MoveDataRow("MV_SPARK", "75", "Spark", "1", "FALSE", "Normal", "Emits a spark of electricity that jumps to an additional opponent, and may Paralyze them.", "Electric", "Ranged", "0", "", "0", "", "0", "20", "40", "1", "Splash Range 1", "0.95", "RangeAttack", "Electric Ball", "No Animation", "RangeHit", "No Shake", "0.1", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "5", "1", "0"));
			Rows.Add( new MoveDataRow("MV_STATICBLAST", "269", "Staticblast", "1", "FALSE", "Normal", "A sharp powerful static trail shoots across the ground, shocking all opponents.", "Electric", "Ranged", "0", "", "0", "", "0", "20", "60", "0.3", "Hit All", "0.95", "RangeAttack", "Electric Ball", "ElectroSpark", "RangeHit", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "5", "1", "0"));
			Rows.Add( new MoveDataRow("MV_ELECTROCUTE", "74", "Electrocute", "1", "FALSE", "Normal", "Engulfs the opponent in a ball of electricity with a high chance of Paralysis.", "Electric", "Ranged", "0", "", "0", "", "0", "80", "90", "1", "Hit 1 Only", "0.95", "RangeAttack", "Intense Blue Shield Rays", "ElectroSpark", "RangeHit", "Small Shake", "0.3", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "5", "1", "0"));
			Rows.Add( new MoveDataRow("MV_ARCWAVE", "72", "Arc Wave", "1", "FALSE", "Normal", "Arcs of high voltage tear across the field, hitting two opponents. It also increases the user's Ranged Attack.", "Electric", "Ranged", "0", "", "0", "", "0", "60", "50", "0.5", "Splash Range 1", "0.95", "RangeAttack", "Light Ball B", "ElectroSpark", "RangeHit", "Small Shake", "0", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "2", "2", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "Hidden Range Attack Boost", "1", "5", "1", "0"));
			Rows.Add( new MoveDataRow("MV_CHAINLIGHTNING", "70", "Chain Lightning", "1", "FALSE", "Normal", "Strikes the opponent down with a series of lightning strikes that also hit an adjacent opponent.", "Electric", "Ranged", "0", "", "0", "", "0", "50", "60", "0.5", "Splash Range 1", "0.95", "RangeAttack", "Electric Bolt", "ElectroSpark", "RangeHit", "No Shake", "0", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "2", "3", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_LIGHTNINGSTORM", "71", "Lightning Storm", "1", "FALSE", "Normal", "A super strong electrical blast that hits all opponents, and may Burn and Paralyze them.", "Electric", "Ranged", "0", "", "0", "", "0", "80", "125", "0.3", "Hit All", "0.95", "RangeAttack", "Electric Bolt", "Smoke Column Black", "RangeHit", "Large Shake", "0.1", "0", "0", "0", "0", "0", "0.1", "0", "1", "1", "1", "1", "1", "1", "1", "2", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "5", "1", "0"));
			Rows.Add( new MoveDataRow("MV_JOLT", "73", "Jolt", "1", "FALSE", "Normal", "Targets the opponent with a small electrical strike.", "Electric", "Melee", "0", "", "0", "", "0", "10", "45", "0", "Hit 1 Only", "0.95", "TackleRun", "Spark Far Side", "No Animation", "HitAnim", "No Shake", "0", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "5", "1", "0"));
			Rows.Add( new MoveDataRow("MV_ZAPTACKLE", "232", "Zap Tackle", "1.8", "FALSE", "Normal", "A fast tackle that may Burn the opponent with electricity, and jumps the voltage to an additional opponent. It often goes first.", "Electric", "Melee", "0", "", "0", "", "0", "20", "55", "0.5", "Splash Range 1", "0.95", "TackleRun", "ElectroSpark", "Light Hit Air", "HitAnim", "No Shake", "0", "0", "0", "0", "0", "0", "0.2", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "4", "1", "0"));
			Rows.Add( new MoveDataRow("MV_STATICCHARGE", "76", "Static Charge", "1", "FALSE", "Normal", "A powerful ram infused with static voltage that hits a second opponent. It also boosts the user's Melee Attack.", "Electric", "Melee", "0", "", "0", "", "0", "15", "75", "0.5", "Splash Range 1", "0.95", "TackleRun", "ElectroSpark", "No Animation", "HitAnim", "No Shake", "0", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "Hidden Melee Attack Boost", "1", "5", "1", "0"));
			Rows.Add( new MoveDataRow("MV_IONFANG", "235", "Ion Fang", "1.1", "FALSE", "Normal", "A bite, rippling with current, strikes the opponent and may cause it to Flinch.", "Electric", "Melee", "0", "", "0", "", "0", "40", "95", "0", "Hit 1 Only", "0.95", "TackleRun", "ElectroSpark Ground", "Blue Sparks Ranged", "HitAnim", "Small Shake", "0", "0", "0", "0", "0.3", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.1", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "5", "1", "0"));
			Rows.Add( new MoveDataRow("MV_KINETICCLAW", "270", "Kinetic Claw", "1", "FALSE", "Normal", "The user rakes its crackling claws through the opponent and an ajacent opponent and may Paralyze them.", "Electric", "Melee", "0", "", "0", "", "0", "60", "95", "0.5", "Splash Range 1", "0.95", "TackleRun", "ElectroSpark", "No Animation", "HitAnim", "No Shake", "0.3", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "5", "1", "0"));
			Rows.Add( new MoveDataRow("MV_GIGASTOMP", "236", "Giga Stomp", "1", "FALSE", "Normal", "An electrifying stomp that sends out arcs of electrical power at all opponents, lowering their Accuracy and Agility.", "Electric", "Melee", "0", "", "0", "", "0", "80", "100", "0.3", "Hit All", "0.9", "TackleRun", "Electric Bolt", "ElectroSpark", "HitAnim", "Large Shake", "0", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "0.95", "0.95", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "5", "1", "0"));
			Rows.Add( new MoveDataRow("MV_THUNDERSTRIKE", "78", "Thunder Strike", "1", "FALSE", "Normal", "A powerful electric strike that hits the opponent, causing instant Burn. It also has a slightly higher Decisive Blow chance.", "Electric", "Melee", "0", "", "0", "", "0", "90", "150", "0", "Hit 1 Only", "0.95", "TackleRun", "Electric Bolt", "Flash", "HitAnim", "Small Shake", "0.3", "0", "0", "0", "0", "0", "1", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.2", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "5", "1", "0"));
			Rows.Add( new MoveDataRow("MV_FLASH", "80", "Flash", "1", "FALSE", "Normal", "Produces a blinding flash of electricity to disorient the opponent, lowering Accuracy and utility move effectiveness.", "Electric", "Melee", "0", "", "0", "", "0", "30", "0", "1", "Hit 1 Only", "1", "AggressiveStance1", "Flash", "No Animation", "HitAnim", "No Shake", "0", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "0.9", "1", "1", "1", "1", "1", "0", "0", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "0.85", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_HYPER", "234", "Hyper", "1", "FALSE", "Normal", "Accellerates the electrons to increase the Speed of an ally.", "Electric", "Melee", "0", "", "0", "", "0", "35", "0", "1", "Boost 1", "1", "AggressiveStance1", "Power Aura", "No Animation", "AggressiveStance2", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1.5", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_BUZZ", "231", "Buzz", "1", "FALSE", "Normal", "Emits a small spark of electricity that causes Confusion.", "Electric", "Ranged", "0", "", "0", "", "0", "15", "0", "1", "Hit 1 Only", "1", "AggressiveStance1", "Blue Sparks Ranged", "No Animation", "HitAnim", "No Shake", "0", "0", "0", "0", "0", "0.9", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_SURGE", "287", "Surge", "1", "FALSE", "Normal", "Sends a surge of ions to an ally boosting its Melee Attack and Speed.", "Electric", "Ranged", "0", "", "0", "", "0", "20", "0", "0", "Boost 1", "1", "AggressiveStance1", "ElectroSpark", "No Animation", "AggressiveStance2", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1.25", "1", "1.25", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_MAGNETIZE", "77", "Magnetize", "1", "FALSE", "Normal", "Target is magnetized, making it vulnerable to Electric attacks.", "Electric", "Ranged", "0", "", "0", "", "0", "25", "0", "1", "Hit 1 Only", "1", "AggressiveStance1", "ElectroSpark", "No Animation", "HitAnim", "No Shake", "0", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0", "Standard", "Electric", "1", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_DISCHARGE", "79", "Discharge", "1", "FALSE", "Normal", "Sends a surge of electrons to an ally boosting Ranged Attack and Speed.", "Electric", "Ranged", "0", "", "0", "", "0", "20", "0", "1", "Boost 1", "1", "AggressiveStance1", "Blue Sparks", "No Animation", "AggressiveStance2", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1.25", "1.25", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_RECHARGE", "278", "Recharge", "1", "FALSE", "Power is Percentage of HP", "Recharges the will and strength of an ally restoring some HP. It may cause the user Paralysis.", "Electric", "Ranged", "0", "", "0", "", "0", "30", "40", "0", "Boost 1", "1", "AggressiveStance1", "ElectroSpark", "Heart Pickup", "AggressiveStance2", "No Shake", "-0.15", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_IGNITE", "103", "Ignite", "1", "FALSE", "Normal", "Ignites a small burst of fire that may Burn the opponent.", "Fire", "Ranged", "0", "", "0", "", "0", "15", "45", "1", "Hit 1 Only", "0.95", "RangeAttack", "Fire Hit Air", "No Animation", "", "No Shake", "0", "0", "0", "0", "0", "0", "0.15", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_TORCH", "106", "Torch", "1", "FALSE", "Normal", "Spits forth a tongue of flame at the opponent and an ajacent opponent, but may Burn the user.", "Fire", "Ranged", "0", "", "0", "", "0", "20", "55", "0.1", "Splash Range 1", "0.95", "RangeAttack", "Fire Hit Air", "Smoke Column Red", "", "No Shake", "0", "0", "0", "0", "0", "0", "-0.2", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "5", "1", "0"));
			Rows.Add( new MoveDataRow("MV_HEATWAVE", "272", "Heatwave", "1", "FALSE", "Normal", "Exposes the opponent to heat for an extended period of time making it vulnerable to Fire moves, but also deals damage to the user, overheating.", "Fire", "Ranged", "0", "", "0", "", "0", "25", "75", "1", "Hit 1 Only", "0.95", "RangeAttack", "Firewall", "Light Hit Air", "", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "Fire", "1", "0", "0", "0", "0", "0", "0.1", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "5", "1", "0"));
			Rows.Add( new MoveDataRow("MV_BLAZE", "271", "Blaze", "1", "FALSE", "Normal", "A roaring blast erupts from the ground, damaging all opponents, but also damaging the user, overheating.", "Fire", "Ranged", "0", "", "0", "", "0", "40", "80", "0.25", "Hit All", "0.95", "RangeAttack", "Fire Hit Air", "Small Cloud Puff", "", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0.1", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "5", "1", "0"));
			Rows.Add( new MoveDataRow("MV_FLAMETHROWER", "95", "Flamethrower", "1", "FALSE", "Normal", "Sends a cone of fire at the opponent that grows stronger each turn by raising the user's Ranged Attack.", "Fire", "Ranged", "0", "", "0", "", "0", "40", "100", "1", "Hit 1 Only", "0.95", "RangeAttack", "Moving Fireball", "Fire Hit Air", "", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "0.95", "0.95", "1", "1", "1", "1", "1", "1", "0", "0.2", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "Hidden Ranged Attack Boost", "1", "5", "1", "0"));
			Rows.Add( new MoveDataRow("MV_FIRESTORM", "96", "Firestorm", "1", "FALSE", "Normal", "A wildfire engulfs all opponents and may Burn them. It deals some damage to the user.", "Fire", "Ranged", "0", "", "0", "", "0", "60", "130", "0.25", "Hit All", "0.95", "RangeAttack", "Firewall", "Smoke Column Black", "", "No Shake", "0", "0", "0", "0", "0", "0", "0.3", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0.1", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "5", "1", "0"));
			Rows.Add( new MoveDataRow("MV_PYROCLASM", "100", "Pyroclasm", "1", "FALSE", "Normal", "Fire and brimstone erupts all about the opponents, Burning them. There's also a high chance of Decisive Blow.", "Fire", "Ranged", "0", "", "0", "", "0", "140", "130", "0.25", "Hit All", "0.95", "RangeAttack", "FlameThrower", "Fire Hit Air", "", "Small Shake", "0", "0", "0", "0", "0", "0", "1", "1", "1.2", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.3", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "5", "1", "0"));
			Rows.Add( new MoveDataRow("MV_HIDDENRANGEDATTACKBOOST", "328", "Hidden Ranged Attack Boost", "1", "FALSE", "Normal", "Hidden Move. Generic. Use as any 20% Self Boost.", "Normal", "Ranged", "0", "", "0", "", "0", "0", "0", "1", "Hit 1 Only", "1", "NoAnim", "No Animation", "No Animation", "", "No Shake", "0", "0", "0", "0", "0", "0", "0", "0", "1.2", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "0", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_PYROCLAP", "107", "Pyroclap", "1", "FALSE", "Normal", "A stunning blow with searing palms with a slight chance of causing the opponent to Flinch.", "Fire", "Melee", "0", "", "0", "", "0", "10", "45", "0", "Hit 1 Only", "0.9", "ScratchAttack", "No Animation", "Fire Hit Air", "", "No Shake", "0", "0", "0", "0", "0.05", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_FIREFANG", "273", "Fire Fang", "1", "FALSE", "Normal", "A charring bite that may Burn the opponent.", "Fire", "Melee", "0", "", "0", "", "0", "15", "65", "0", "Hit 1 Only", "0.95", "ScratchAttack", "No Animation", "Fire Hit Air B", "", "No Shake", "0", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_PYROPUNCH", "101", "Pyro Punch", "1", "FALSE", "Normal", "Sends a powerful fiery punch at the opponent, raising the user's Melee Attack, but it may Burn the user.", "Fire", "Melee", "0", "", "0", "", "0", "25", "85", "0", "Hit 1 Only", "0.95", "ScratchAttack", "Firewall", "Fire Hit Air B", "", "Tiny Shake", "0", "0", "0", "0", "0", "0", "-0.2", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "Hidden Melee Attack Boost", "1", "5", "1", "0"));
			Rows.Add( new MoveDataRow("MV_COMBUSTION", "93", "Combustion", "1", "FALSE", "Normal", "A highly explosive attack that also damages an additional opponent and the user.", "Fire", "Melee", "0", "", "0", "", "0", "125", "85", "0.8", "Splash Range 1", "0.95", "ScratchAttack", "No Animation", "Smokey Explosion", "", "Large Shake", "0", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0.7", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "5", "1", "0"));
			Rows.Add( new MoveDataRow("MV_HEATSTRIKE", "104", "Heatstrike", "1.1", "FALSE", "Normal", "The user quickly gets in close and focuses its heat to precision, greatly damaging the opponent but at a cost of its own defense.", "Fire", "Melee", "0", "", "0", "", "0", "40", "120", "0", "Hit 1 Only", "1", "ScratchAttack", "Power Aura", "Double Fireball", "", "Tiny Shake", "0", "0", "0", "0", "0", "0", "0", "0", "1", "1", "0.85", "0.85", "1", "1", "1", "1", "1", "1", "0", "0.1", "Standard", "Fire", "1", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "Hidden Heat Strike", "1", "5", "1", "0"));
			Rows.Add( new MoveDataRow("MV_INFERNOCHARGE", "90", "Inferno Charge", "1", "FALSE", "Normal", "A wildfire surrounds the user as it dashes forward to strike an opponent. It does additional damage and costs less energy if the user is Burned.", "Fire", "Melee", "0", "", "64", "Hidden Inferno Charge", "0", "60", "100", "0", "Hit 1 Only", "0.95", "ScratchAttack", "Firewall", "Double Fireball", "", "No Shake", "0", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.1", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "5", "1", "0"));
			Rows.Add( new MoveDataRow("MV_INCINERATE", "91", "Incinerate", "1", "FALSE", "Normal", "The user strikes the ground, summoning up writhing flames from beneath, damaging and possibly Burning all opponents. It also does some damage to the user.", "Fire", "Melee", "0", "", "0", "", "0", "60", "150", "0.3", "Hit All", "0.95", "ScratchAttack", "Fire Hit Ground", "Smoke Column Black", "", "Large Shake", "0", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.1", "Standard", "None", "0", "0", "0", "0", "0", "0", "0.15", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "5", "1", "0"));
			Rows.Add( new MoveDataRow("MV_HIDDENINFERNOCHARGE", "329", "Hidden Inferno Charge", "1", "FALSE", "Normal", "Hidden Move. Used with Inferno Charge only.", "Fire", "Melee", "0", "", "0", "", "0", "15", "75", "0", "Hit 1 Only", "0.95", "NoAnim", "Firewall", "Double Fireball", "", "No Shake", "0", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.1", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "5", "1", "0"));
			Rows.Add( new MoveDataRow("MV_HIDDENHEATSTRIKE", "337", "Hidden Heat Strike", "1", "FALSE", "Normal", "Hidden Move. Used with Heat Strike only.", "Fire", "Melee", "0", "", "0", "", "0", "0", "0", "0", "Boost Me", "1", "NoAnim", "Firewall", "Double Fireball", "", "No Shake", "0", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.1", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "5", "1", "0"));
			Rows.Add( new MoveDataRow("MV_SMOKESCREEN", "108", "Smokescreen", "1", "FALSE", "Normal", "Sends a blinding plume of smoke to reduce an opponent's Accuracy.", "Fire", "Ranged", "0", "", "0", "", "0", "65", "0", "0", "Hit 1 Only", "1", "AggressiveStance1", "Smoke Column Black", "No Animation", "", "No Shake", "0", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "0.75", "1", "1", "1", "1", "1", "0", "0", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_SMOLDER", "109", "Smolder", "1", "FALSE", "Normal", "With inner heat, increases an ally's Ranged and Melee Defense, but may Burn the user.", "Fire", "Melee", "0", "", "0", "", "0", "30", "0", "0", "Boost 1", "1", "AggressiveStance1", "Fairy Dust (Orange)", "Powerup Star", "", "No Shake", "0", "0", "0", "0", "0", "0", "0", "0", "1.5", "1.5", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_FIREBRAND", "99", "Fire Brand", "1", "FALSE", "Normal", "Target is branded with flame, making it vulnerable to Fire attacks.", "Fire", "Ranged", "0", "", "0", "", "0", "25", "0", "0", "Hit 1 Only", "1", "AggressiveStance1", "No Animation", "Intense Shield Rays", "", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0", "Standard", "Fire", "1", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_LAVAMOAT", "279", "Lava Moat", "1", "FALSE", "Normal", "User creates a moat of lava, increasing all allies' Melee Defense and Melee Attack.", "Fire", "Melee", "0", "", "0", "", "0", "25", "0", "0", "Boost All", "1", "AggressiveStance1", "Firewall", "Intense Shield Rays", "", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1.25", "1", "1.25", "1", "1", "1", "1", "1", "1", "0", "0", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_STEAM", "105", "Steam", "1", "FALSE", "Normal", "Jets of steam erupt around the allies, raising their Ranged Defense and Agility. It also removes their vulnerability to Water.", "Fire", "Melee", "0", "", "0", "", "0", "25", "0", "0", "Boost All", "1", "AggressiveStance1", "Small Cloud Puff", "Small Cloud Puff", "", "No Shake", "0", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1.25", "1", "1", "1.1", "1", "1", "1", "1", "0", "0", "Standard", "None", "0", "2", "0", "0", "0", "0", "0", "0.5", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_MOLTENSHIELD", "244", "Molten Shield", "1", "FALSE", "Normal", "A fiery shield that gives a high Ranged Defense boost, but may Burn the user.", "Fire", "Melee", "0", "", "0", "", "0", "35", "0", "0", "Boost 1", "1", "AggressiveStance1", "Firewall", "Intense Shield Rays", "", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1.75", "1.7", "1", "1", "1", "1", "1", "1", "1", "0", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_SAUNA", "280", "Sauna", "1", "FALSE", "Power is Percentage of HP", "Cover all allies in warm steam, replenishing their HP.", "Fire", "Ranged", "0", "", "0", "", "0", "40", "25", "0", "Boost All", "1", "AggressiveStance1", "Small Cloud Puff", "Heart Pickup", "", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_HIDDENMOLTENSHIELD", "330", "Hidden Molten Shield", "1", "FALSE", "Normal", "Hidden Move. Used with Molten Shield only.", "Fire", "Melee", "0", "", "0", "", "0", "0", "0", "0", "Boost Me", "1", "AggressiveStance1", "Firewall", "Double Fireball", "", "No Shake", "0", "0", "0", "0", "0", "0", "0.2", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.1", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "5", "1", "0"));
			Rows.Add( new MoveDataRow("MV_HAIL", "199", "Hail", "1", "FALSE", "Normal", "Deadly balls of hail pummel the opponent multiple times.", "Ice", "Ranged", "0", "", "0", "", "0", "15", "10", "0", "Hit 1 Only", "0.95", "RangeAttack", "Ice Ball", "No Animation", "", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "5", "1", "0"));
			Rows.Add( new MoveDataRow("MV_FROSTBREATH", "225", "Frostbreath", "1", "FALSE", "Normal", "A waft of white cold drops the opponent's body heat, possibly putting it to Sleep and slightly lowering it's Speed.", "Ice", "Ranged", "0", "", "0", "", "0", "15", "40", "0", "Hit 1 Only", "0.95", "RangeAttack", "Ice Hit Air A", "Fairy Dust (Cold)", "", "No Shake", "0", "0.3", "0", "0", "0", "0", "0", "0.9", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "5", "1", "0"));
			Rows.Add( new MoveDataRow("MV_ARCTICBLAST", "193", "Arctic Blast", "1", "FALSE", "Normal", "A sub-zero blast of cold with a high chance at causing a Decisive Blow. It also slightly lowers the opponent's Speed.", "Ice", "Ranged", "0", "", "0", "", "0", "25", "70", "0", "Hit 1 Only", "0.95", "RangeAttack", "Ice Ball", "Ice Hit Air B", "", "No Shake", "0", "0", "0", "0", "0", "0", "0", "0.9", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.3", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "5", "1", "0"));
			Rows.Add( new MoveDataRow("MV_DEEPFREEZE", "274", "Deep Freeze", "1", "FALSE", "Normal", "Lowers freezing clouds over the opponents, damaging and possibly Freezing them.", "Ice", "Ranged", "0", "", "0", "", "0", "50", "80", "0.1", "Hit All", "0.95", "RangeAttack", "Snow Storm", "No Animation", "", "Tiny Shake", "0", "0", "0", "0.15", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "5", "1", "0"));
			Rows.Add( new MoveDataRow("MV_TUNDRABLAST", "263", "Tundra Blast", "1", "FALSE", "Normal", "An explosion of ice and stone that damages and reduces the opponent's Speed.", "Ice", "Ranged", "0", "", "0", "", "0", "40", "100", "0", "Hit 1 Only", "0.95", "RangeAttack", "Ice Thrower", "No Animation", "", "No Shake", "0", "0", "0", "0", "0", "0", "0", "0.75", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "5", "1", "0"));
			Rows.Add( new MoveDataRow("MV_BLIZZARD", "195", "Blizzard", "1", "FALSE", "Normal", "Swirling ice and snow blinds the opponent, lowering Accuracy, and slightly lowering their Speed.", "Ice", "Ranged", "0", "", "0", "", "0", "90", "120", "0.25", "Hit All", "0.95", "RangeAttack", "Snow Storm", "Ice Ball", "", "Small Shake", "0", "0", "0", "0", "0", "0", "0", "0.9", "1", "1", "1", "1", "1", "0.85", "1", "2", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "5", "1", "0"));
			Rows.Add( new MoveDataRow("MV_AVALANCHE", "194", "Avalanche", "1", "FALSE", "Normal", "Tumbling snowcaps cover the opposing team, which may put them to Sleep, and slightly lowers their Speed.", "Ice", "Ranged", "0", "", "0", "", "0", "80", "140", "0.3", "Hit All", "0.95", "RangeAttack", "Snow Storm", "Ice Hit Ground", "", "Large Shake", "0", "0.3", "0", "0", "0", "0", "0", "0.9", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "5", "1", "0"));
			Rows.Add( new MoveDataRow("MV_COLDSNAP", "226", "Cold Snap", "1", "FALSE", "Normal", "The opponent is bitten with deadly cold jaws.", "Ice", "Melee", "0", "", "0", "", "0", "15", "45", "0", "Hit 1 Only", "0.95", "ScratchAttack", "Ice Hit Ground", "Small Cloud Puff", "", "No Shake", "0", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_ICECLAW", "197", "Ice Claw", "1", "FALSE", "Normal", "A white cold strike with frozen claws that also slightly lowers the opponent's Speed.", "Ice", "Melee", "0", "", "0", "", "0", "15", "60", "0", "Hit 1 Only", "0.95", "ScratchAttack", "Ice Hit Air B", "Small Cloud Puff", "", "No Shake", "0", "0", "0", "0", "0", "0", "0", "0.9", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.1", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_FROSTBITE", "228", "Frost Bite", "1", "FALSE", "Normal", "A chilling bite that may cause the opponent an icy Burn.", "Ice", "Melee", "0", "", "0", "", "0", "20", "75", "0", "Hit 1 Only", "0.95", "ScratchAttack", "Light Hit Air", "Light Hit Air", "", "Tiny Shake", "0", "0", "0", "0", "0", "0", "0.3", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "4", "1", "0"));
			Rows.Add( new MoveDataRow("MV_GLACIALSLIDE", "200", "Glacial Slide", "1", "FALSE", "Normal", "Freezes the floor in front of the user to propel itself into an attack, raising the user's Speed, and lowering the opponent's Speed.", "Ice", "Melee", "0", "", "0", "", "0", "30", "90", "0", "Hit 1 Only", "0.95", "ScratchAttack", "Ice Ball", "Ice Hit Air B", "", "Tiny Shake", "0", "0", "0", "0", "0", "0", "0", "0.75", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "Hidden Glacial Slide", "1", "4", "1", "0"));
			Rows.Add( new MoveDataRow("MV_ICESMASH", "262", "Ice Smash", "1", "FALSE", "Normal", "User freezes a chunk of ice to break over an opponent that may cause it to Freeze.", "Ice", "Melee", "0", "", "0", "", "0", "40", "110", "0", "Hit 1 Only", "0.9", "ScratchAttack", "Light Hit Air", "Light Hit Air", "", "No Shake", "0", "0", "0", "0.05", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "5", "1", "0"));
			Rows.Add( new MoveDataRow("MV_FROSTFANG", "264", "Frost Fang", "1", "FALSE", "Normal", "A bone-chilling bite that can cause the opponent to Flinch. It also slightly lowers the opponent's Speed.", "Ice", "Melee", "0", "", "0", "", "0", "40", "125", "0", "Hit 1 Only", "0.95", "ScratchAttack", "Light Ball", "No Animation", "", "No Shake", "0", "0", "0", "0", "0.3", "0", "0", "0.9", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "4", "1", "0"));
			Rows.Add( new MoveDataRow("MV_ICEDRILL", "268", "Ice Drill", "1", "FALSE", "Normal", "A deep frigid stab runs through the opponent, and one additional opponent, slightly lowering their Speed.", "Ice", "Melee", "0", "", "0", "", "0", "40", "150", "0.5", "Splash Range 1", "0.95", "ScratchAttack", "Ice Thrower", "Blue Sparks", "", "No Shake", "0", "0", "0", "0", "0", "0", "0", "0.9", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "5", "1", "0"));
			Rows.Add( new MoveDataRow("MV_HIDDENGLACIALSLIDE", "331", "Hidden Glacial Slide", "1", "FALSE", "Normal", "Hidden Move. Used with Glacial Slide only.", "Ice", "Melee", "0", "", "0", "", "0", "0", "0", "0", "Boost Me", "1", "ScratchAttack", "No Animation", "No Animation", "", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1.25", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.1", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "5", "1", "0"));
			Rows.Add( new MoveDataRow("MV_WHITEBREATH", "227", "White Breath", "1", "FALSE", "Normal", "Produces a cold waft of air that may lull the opponent to Sleep. It also slightly lowers the opponent's Speed.", "Ice", "Ranged", "0", "", "0", "", "0", "20", "0", "1", "Hit 1 Only", "1", "AggressiveStance1", "Shiny Item", "Fairy Dust (Cold)", "", "No Shake", "0", "0.75", "0", "0", "0", "0", "0", "0.9", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_FROSTCLOAK", "265", "Frost Cloak", "1", "FALSE", "Normal", "An icy fog rises to conceal and raise the Agility of an ally.", "Ice", "Melee", "0", "", "0", "", "0", "20", "0", "1", "Boost 1", "1", "AggressiveStance1", "Shield Rays White", "No Animation", "", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1.15", "1", "1", "1", "1", "0", "0", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_WINTERSMARK", "322", "Winter's Mark", "1", "FALSE", "Normal", "A bone-chilling touch that renders the opponent vulnerable to Ice attacks.", "Ice", "Melee", "0", "", "0", "", "0", "25", "0", "1", "Hit 1 Only", "1", "AggressiveStance1", "Fairy Dust (Cold)", "Pickup Diamond", "", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0", "Standard", "Ice", "1", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_COOLDOWN", "323", "Cool Down", "1", "FALSE", "Normal", "Slightly lowers all opponents' Speed by lowering their body temperatures.", "Ice", "Ranged", "0", "", "0", "", "0", "35", "0", "0", "Hit All", "1", "AggressiveStance1", "Shiny Item", "Shield Rays White", "", "No Shake", "0", "0", "0", "0", "0", "0", "0", "0.9", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_ICESHIELD", "267", "Ice Shield", "1", "FALSE", "Normal", "An icy shield that gives a high Ranged Defense boost, but reduces the target's Speed.", "Ice", "Melee", "0", "", "0", "", "0", "20", "0", "0", "", "1", "AggressiveStance1", "Snow Storm", "No Animation", "", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1.75", "1", "1", "1", "1", "1", "1", "1", "0", "0", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "Hidden Speed Debuff", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_SNOWDRIFT", "202", "Snow Drift", "1", "FALSE", "Normal", "A howling storm of wind and snow that may coax all opponents to Sleep.", "Ice", "Ranged", "0", "", "0", "", "0", "50", "0", "1", "Hit All", "1", "AggressiveStance1", "Light Hit Air", "Light Hit Air", "", "No Shake", "0", "0.25", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_COLDFRONT", "324", "Cold Front", "1", "FALSE", "Normal", "A frigid mass of air that reduces all opponent's Speed.", "Ice", "Melee", "0", "", "0", "", "0", "50", "0", "1", "Hit All", "1", "AggressiveStance1", "Light Hit Air", "Light Hit Air", "", "Small Shake", "0", "0", "0", "0", "0", "0", "0", "0.5", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_HIDDENSPEEDDEBUFF", "333", "Hidden Speed Debuff", "1", "FALSE", "Normal", "Hidden Move. Generic. Use as any -20% Speed drop.", "Normal", "Melee", "0", "", "0", "", "0", "0", "0", "0", "Boost 1", "1", "AggressiveStance1", "No Animation", "No Animation", "", "No Shake", "0", "0", "0", "0", "0", "0", "0", "0.75", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "5", "1", "0"));
			Rows.Add( new MoveDataRow("MV_SPLASH", "207", "Splash", "1", "FALSE", "Normal", "Whips a handfull of water at the opponent.", "Water", "Ranged", "0", "", "0", "", "0", "10", "40", "0", "Hit 1 Only", "0.95", "RangeAttack", "Splash", "Bubbles", "", "No Shake", "0", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "4", "1", "0"));
			Rows.Add( new MoveDataRow("MV_RIPTIDE", "58", "Riptide", "1", "FALSE", "Normal", "Catch an opponent in a riptide. It may Confuse it, and removes its ability to alter its Defense stats.", "Water", "Ranged", "0", "", "0", "", "0", "25", "50", "0", "Hit 1 Only", "0.95", "RangeAttack", "Bubbles Whirl", "No Animation", "", "No Shake", "0", "0", "0", "0", "0", "0.25", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "12", "0", "12", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_WATERBLAST", "208", "Waterblast", "1", "FALSE", "Normal", "Shoots a surge of water at the opponent, removing its ability to alter its Attack stats.", "Water", "Ranged", "0", "", "0", "", "0", "15", "75", "0", "Hit 1 Only", "0.95", "RangeAttack", "Splash", "Splash Drops", "", "Small Shake", "0", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "3", "0", "3", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "5", "1", "0"));
			Rows.Add( new MoveDataRow("MV_WATERCANNON", "205", "Water Cannon", "1", "FALSE", "Normal", "Channels a strong funnel of water at the opponent, with a high Decisive Blow chance.", "Water", "Ranged", "0", "", "0", "", "0", "50", "90", "0", "Hit 1 Only", "0.95", "RangeAttack", "Water Ball", "Bubbles Whirl", "", "Small Shake", "0", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.5", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "5", "1", "0"));
			Rows.Add( new MoveDataRow("MV_WHIRLPOOL", "55", "Whirlpool", "1", "FALSE", "Normal", "Catches the opponent in a roaring swirl of water, and protects the user's stats from being altered.", "Water", "Ranged", "0", "", "0", "", "0", "60", "120", "0", "Hit 1 Only", "0.95", "RangeAttack", "Vortex Air Blue", "Bubbles Whirl", "", "Small Shake", "0", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "255", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "Hidden Whirlpool", "1", "5", "1", "0"));
			Rows.Add( new MoveDataRow("MV_TIDALWAVE", "54", "Tidal Wave", "0.5", "FALSE", "Normal", "A strong flow of cold water hammers the opponents, removing their ability to alter their stats. This move goes last.", "Water", "Ranged", "0", "", "0", "", "0", "100", "120", "0.2", "Hit All", "0.95", "RangeAttack", "Water Ball", "Splash", "", "No Shake", "0", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "2", "4", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "255", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "5", "1", "0"));
			Rows.Add( new MoveDataRow("MV_MONSOON", "56", "Monsoon", "1", "FALSE", "Normal", "Channels a strong storm of water and wind that barrages all opponents, and removes all status conditions from the user.", "Water", "Ranged", "0", "", "0", "", "0", "120", "120", "0.6", "Hit All", "0.95", "RangeAttack", "Rain", "Rain", "", "No Shake", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "Hidden Monsoon", "1", "5", "1", "0"));
			Rows.Add( new MoveDataRow("MV_HIDDENWHIRLPOOL", "334", "Hidden Whirlpool", "1", "FALSE", "Normal", "Hidden Move. Used only with Whirlpool.", "Normal", "Melee", "0", "", "0", "", "0", "0", "0", "0", "Boost Me", "1", "NoAnim", "No Animation", "No Animation", "", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0", "Standard", "None", "0", "0", "0", "0", "255", "255", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "5", "1", "0"));
			Rows.Add( new MoveDataRow("MV_HIDDENMONSOON", "335", "Hidden Monsoon", "1", "FALSE", "Normal", "Hidden Move. Used only with Monsoon.", "Normal", "Melee", "0", "", "0", "", "0", "0", "0", "0", "Boost Me", "1", "NoAnim", "No Animation", "No Animation", "", "No Shake", "-1", "-1", "-1", "-1", "0", "-1", "-1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0", "Standard", "None", "0", "0", "0", "0", "255", "255", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "5", "1", "0"));
			Rows.Add( new MoveDataRow("MV_DIVE", "57", "Dive", "1", "FALSE", "Normal", "The user launches itself through the waves, striking the opponent.", "Water", "Melee", "0", "", "0", "", "0", "10", "40", "1", "Hit 1 Only", "0.95", "TackleRun", "Splash", "No Animation", "", "No Shake", "0", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "4", "1", "0"));
			Rows.Add( new MoveDataRow("MV_AQUASLIDE", "59", "Aqua Slide", "1", "FALSE", "Normal", "The user takes advantage of its deluge and swiftly slides at the opponent, protecting the user from special conditions.", "Water", "Melee", "0", "", "0", "", "0", "15", "50", "1", "Hit 1 Only", "0.95", "TackleRun", "Splash Drops", "No Animation", "", "No Shake", "0", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "Hidden Aqua Slide", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_HYDROFIST", "206", "Hydro Fist", "1", "FALSE", "Normal", "Strikes the opponent with a heavy water-handed hit that may cause it to Flinch.", "Water", "Melee", "0", "", "0", "", "0", "20", "70", "1", "Hit 1 Only", "0.95", "ScratchAttack", "Small Blue Hit", "Light Hit Air", "", "Tiny Shake", "0", "0", "0", "0", "0.2", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "5", "1", "0"));
			Rows.Add( new MoveDataRow("MV_WIPEOUT", "50", "Wipeout", "1", "FALSE", "Normal", "An attack that knocks the opponent off its feet, removing its ability to alter its stats.", "Water", "Melee", "0", "", "0", "", "0", "50", "90", "1", "Hit 1 Only", "0.95", "ScratchAttack", "Bubbles", "Splash Huge", "", "No Shake", "0", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "255", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "5", "1", "0"));
			Rows.Add( new MoveDataRow("MV_WAVEBREAKER", "51", "Wave Breaker", "1", "FALSE", "Normal", "A watery attack that smashes the opponent down with the force of a wave, striking it several times. It also has a better Decisive Blow chance.", "Water", "Melee", "0", "", "0", "", "0", "40", "65", "1", "Hit 1 Only", "0.95", "ScratchAttack", "Water Ball", "Bubbles Whirl", "", "Small Shake", "0", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "2", "3", "1", "1", "0", "0.35", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "5", "1", "0"));
			Rows.Add( new MoveDataRow("MV_TIDALSMASH", "52", "Tidal Smash", "1", "FALSE", "Normal", "A wall of water drives the user forward, damaging all opponents, removing their ability to alter their stats.", "Water", "Melee", "0", "", "0", "", "0", "60", "120", "0.2", "Hit All", "0.95", "ScratchAttack", "Water Ball", "Splash", "", "Small Shake", "0", "0", "0", "0", "0", "0.1", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "255", "255", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "5", "1", "0"));
			Rows.Add( new MoveDataRow("MV_TSUNAMICHARGE", "53", "Tsunami Charge", "1", "FALSE", "Normal", "A powerful hydraulic charge that breaks past all opponents, but removes their Burn or Poison conditions.", "Water", "Melee", "0", "", "0", "", "0", "50", "150", "0.4", "Hit All", "0.95", "ScratchAttack", "Water Ball", "Splash", "", "Large Shake", "0", "0", "-1", "0", "0", "0", "-1", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "5", "1", "0"));
			Rows.Add( new MoveDataRow("MV_HIDDENAQUASLIDE", "336", "Hidden Aqua Slide", "1", "FALSE", "Normal", "Hidden Move. Used only with Aqua Slide.", "Normal", "Melee", "0", "", "0", "", "0", "0", "0", "0", "Boost Me", "1", "NoAnim", "No Animation", "No Animation", "", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0", "Standard", "None", "0", "0", "127", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "5", "1", "0"));
			Rows.Add( new MoveDataRow("MV_PURIFY", "284", "Purify", "1", "FALSE", "Normal", "Cleansing water removes all status effects from an ally.", "Water", "Ranged", "0", "", "0", "", "0", "20", "0", "0", "Boost 1", "1", "AggressiveStance1", "Rain", "Powerup Star", "", "No Shake", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_RINSE", "250", "Rinse", "2", "FALSE", "Normal", "Hard rain pours over the opponent, removing its ability to alter its stats. This move often goes first.", "Water", "Ranged", "0", "", "0", "", "0", "35", "0", "0", "Hit 1 Only", "1", "AggressiveStance1", "Rain", "Splash", "", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "Standard", "None", "0", "0", "0", "0", "255", "255", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_SPIRITWATER", "282", "Spirit Water", "1", "FALSE", "Power is Percentage of HP", "A strong guyser of holy water heals the ally, restoring it's HP.", "Water", "Ranged", "0", "", "0", "", "0", "30", "50", "0", "Boost 1", "1", "AggressiveStance1", "Bubbles", "Heart Pickup", "", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_CLEANSE", "247", "Cleanse", "1", "FALSE", "Normal", "A surge of water cleanses all allies' status conditions and protects them from recieving them.", "Water", "Ranged", "0", "", "0", "", "0", "20", "0", "0", "Boost All", "1", "AggressiveStance1", "Rain", "Bubbles Whirl", "", "No Shake", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0", "Standard", "None", "0", "0", "127", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_DRENCH", "283", "Drench", "1", "FALSE", "Normal", "Soak an opponent through, making it vulnerable to Water attacks.", "Water", "Ranged", "0", "", "0", "", "0", "25", "0", "0", "Hit 1 Only", "1", "AggressiveStance1", "Rain", "No Animation", "", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "3", "0", "Standard", "Water", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_LIFELINE", "285", "Lifeline", "1", "FALSE", "Power is Percentage of HP", "The user reaches out with a tentacle of water, restoring all HP to an ally with soothing bubbles.", "Water", "Ranged", "0", "", "0", "", "0", "150", "100", "0", "Boost 1", "1", "AggressiveStance1", "Bubbles", "No Animation", "", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_HEALINGWELL", "281", "Healing Well", "1", "FALSE", "Power is Percentage of HP", "Sparkling water wells up beneath all allies, restoring HP and protecting them from stat changes.", "Water", "Ranged", "0", "", "0", "", "0", "150", "50", "0", "Boost All", "1", "AggressiveStance1", "Pickup Diamond", "Heart Pickup", "", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0", "Standard", "None", "0", "0", "0", "0", "255", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_HIDDENMELEEATTACKBOOST", "325", "Hidden Melee Attack Boost", "1", "FALSE", "Normal", "Hidden Move. Generic. Use as any 20% Self Boost.", "Normal", "Melee", "0", "", "0", "", "0", "0", "0", "0", "Boost Me", "1", "NoAnim", "No Animation", "No Animation", "", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1.2", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_HIDDENDECISIVEBLOWBOOST", "326", "Hidden Decisive Blow Boost", "1", "FALSE", "Normal", "Hidden Move. Generic. Use as any 20% Self Boost.", "Normal", "Melee", "0", "", "0", "", "0", "0", "0", "0", "Boost Me", "1", "NoAnim", "No Animation", "No Animation", "", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "1.2", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
			Rows.Add( new MoveDataRow("MV_HIDDENTIREDBLOW", "327", "Tired Effort", "0.1", "FALSE", "Normal", "Used only when a Monster has no Energy for a real move.", "Normal", "Melee", "0", "", "0", "", "0", "0", "2", "0", "Hit All", "1", "NoAnim", "Small Cloud Puff", "No Animation", "", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0.05", "Standard", "None", "0", "0", "0", "0", "0", "0", "0.5", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "1"));
			Rows.Add( new MoveDataRow("MV_HIDDENRANGEATTACKBOOST", "328", "Hidden Range Attack Boost", "1", "FALSE", "Normal", "Hidden Move. Generic. Use as any 20% Self Boost.", "Normal", "Melee", "0", "", "0", "", "0", "0", "0", "0", "Boost Me", "1", "NoAnim", "No Animation", "No Animation", "", "No Shake", "0", "0", "0", "0", "0", "0", "0", "1", "1.25", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "0", "Standard", "None", "0", "0", "0", "0", "0", "0", "0", "0", "1", "0", "1", "FALSE", "1", "1", "", "1", "3", "1", "0"));
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
		public MoveDataRow GetRow(rowIds in_RowID)
		{
			MoveDataRow ret = null;
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
		public MoveDataRow GetRow(string in_RowString)
		{
			MoveDataRow ret = null;
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
