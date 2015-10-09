using UnityEngine;
using System.Collections;
using UMA;

/// <summary>
/// Human male DNA converter behaviour.
/// </summary>
/// <remarks>
/// Although intended for Humans this DNA converter includes ranges
/// far outside Human norms and can also be used for other Humanoid charatcers
/// such as Elves, Giants, Halflings, et al.
/// </remarks>
public class GirlMyRaceDNAConverterBehaviour : HumanoidDNAConverterBehaviour
{
	public GirlMyRaceDNAConverterBehaviour()
	{
		this.ApplyDnaAction = UpdateUMAGirlyMyRaceDNABones;
		this.DNAType = typeof(UMADnaHumanoid);
	}

	/// <summary>
	/// Adjusts a skeleton to reflect the DNA values from UMA character data.
	/// </summary>
	/// <remarks>
	/// This will set the postion, rotation, and scale of the various adjustment
	/// bones used by the UMA human rigs to generate a unique character shape.
	/// Also calculates a somewhat realistic mass for the character and the
	/// height and radius of their default collider.
	/// </remarks>
	/// <param name="umaData">UMA data.</param>
	/// <param name="skeleton">Skeleton.</param>
	public static void UpdateUMAGirlyMyRaceDNABones(UMAData umaData, UMASkeleton skeleton)
	{
		var umaDna = umaData.GetDna<UMADnaHumanoid>();
		
		
		skeleton.SetScale(neckAdjustHash, 
		                  new Vector3(
			Mathf.Clamp(1, 0.6f, 2),
			Mathf.Clamp(1 + (umaDna.neckThickness - 0.5f) * 0.80f, 0.5f, 1.6f),
			Mathf.Clamp(1 + (umaDna.neckThickness - 0.5f) * 1.2f, 0.5f, 1.6f)));
		
		skeleton.SetScale(spineAdjustHash, 
		                  new Vector3(
			Mathf.Clamp(1, 0.6f, 2),
			Mathf.Clamp(0.9f + (umaDna.upperWeight - 0.5f) * 0.35f + (umaDna.upperMuscle - 0.5f) * 0.45f, 0.75f, 1.350f),
			Mathf.Clamp(0.8f + (umaDna.upperWeight - 0.5f) * 0.35f + (umaDna.upperMuscle - 0.5f) * 0.25f, 0.75f, 1.350f)));
		

		//umaData.boneList["NeckAdjust"].boneTransform.localScale = new Vector3(
		//Mathf.Clamp(1, 0.6f, 2),
		//Mathf.Clamp(1 + (umaDna.neckThickness - 0.5f) * 0.80f, 0.5f, 1.6f),
		//Mathf.Clamp(1 + (umaDna.neckThickness - 0.5f) * 1.2f, 0.5f, 1.6f));
		
		
	}
	
}
