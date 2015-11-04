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
		public ESceneToLoad sceneToLoad;
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
			
			PlayerMain.REF.initForDebug ();
		//	Application.LoadLevel ("Greenaway");
			switch (sceneToLoad) {
				case(ESceneToLoad.Greenaway):
					Application.LoadLevel ("Greenaway");
				break;
				case(ESceneToLoad.ThreeV1Battle):
					SpawnAreaMonster m = new SpawnAreaMonster ("Dandylion",50, 1f, "");
					new BattleInit (m,""); 
					Application.LoadLevel ("BattleSceneA");
				break;
			}
		}
	}


