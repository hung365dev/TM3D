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
using System.Collections;
using Battles;

	public class LibraryManager : MonoBehaviour
	{
		public MovesLib moves;
		public PassiveEffectLibrary passives;
		public MoveTreeLibrary moveTreeLib;
		public MonsterLibrary monsterLib;
		public ElementalLibrary elementalLib;
		public void Awake()
		{
			Debug.Log ("Turn on Lib Manager");
			StartCoroutine(initLibs());
			
			
		}
		
		
		private IEnumerator initLibs() {
			elementalLib.init();
			yield return new WaitForEndOfFrame();
			moves.init();
			yield return new WaitForEndOfFrame();
			passives.init();
			yield return new WaitForEndOfFrame();
			moveTreeLib.initMoveTrees ();
			yield return new WaitForEndOfFrame();
			monsterLib.initLib();
			new PlayerMain ();
			SpawnAreaMonster m = new SpawnAreaMonster ("Cyclonine", 20, 1f, "");
			
			PlayerMain.REF.initForDebug ();
			new BattleInit (m,""); 
			Application.LoadLevel ("BattleSceneA");
		}
	}


