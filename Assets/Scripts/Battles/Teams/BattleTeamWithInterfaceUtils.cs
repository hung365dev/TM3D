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
using System.Collections;
using UnityEngine;


namespace Battles
{
	public class BattleTeamWithInterfaceUtils : BattleTeamBase
	{
		private MoveQueueItem _opponentsTargettingMove;
		
		public delegate void OnTargetFound(MoveQueueItem aMoveQueueItem);
		public event OnTargetFound onTargetFound;
		
		
		public BattleTeamWithInterfaceUtils ()
		{
		}
		public bool healthBars {
			set {
				BetterList<BattleMonster> ms = this.monstersAsBattleMonster;
				for(byte c = 0 ; c<ms.size;c++) {
					if(value==true) {
						if(ms[c].monster.restingStatus==ERestingStatus.Awake)
							ms[c].healthBar.SetActive(value);
					} else 
					{
						ms[c].healthBar.SetActive(value);
					}
				}
			}
		}

		
		public void findTargetForMove(MoveQueueItem aMoveInit) {
			_opponentsTargettingMove = aMoveInit;
			if(aMoveInit!=null) {
			aMoveInit.targetMonster = EMonsterPos.Unset;
			MoveLibItem move = aMoveInit.moveData;
			if(aMoveInit.actioningMonster.energy<aMoveInit.moveData.getEnergy(aMoveInit.actioningMonster.unlockLevelForMove(aMoveInit.moveData))) {
				move = MovesLib.REF.struggleMove;
			}
			BetterList<BattleMonster> ms = this.monstersAsBattleMonster;
			Debug.Log(move.splashRange);
			if(move.splashRange==ESplashRange.BoostAll||move.splashRange==ESplashRange.HitAll) {
				if(move.splashPercent==1.0f||move.splashPercent==0.0f) {
					aMoveInit.targetMonster = EMonsterPos.Front;
					onMonsterClicked(ms[BattleConstants.FRONT_INDEX]);
					return;
				}
			}
			for(byte c = 0;c < ms.size;c++) {
				ms[c].showTargetOption();
				ms[c].onClicked += onMonsterClicked;
			}
			highlightTargettedMonsters();
			}
		}
		public void onMonsterClicked(BattleMonster aMonster) {
			if(_opponentsTargettingMove!=null) {
				int posMonster = (int) positionForMonster(aMonster);
				EMonsterPos position = positionForMonster(aMonster);
				_opponentsTargettingMove.targetMonster = position;
				highlightTargettedMonsters();
				if(this.onTargetFound!=null) {
					
					removeMouseListeners();
					this.onTargetFound(this._opponentsTargettingMove);
					_opponentsTargettingMove = null;
				}
			}
		}
		
		private void removeMouseListeners() { 
			BetterList<BattleMonster> ms = this.monstersAsBattleMonster;
			for(byte c = 0;c < ms.size;c++) {
				ms[c].removeTargetOption();
				ms[c].onClicked -= onMonsterClicked;
			}
		}
		
		private void highlightTargettedMonsters() {
			
			BetterList<BattleMonster> ms = this.monstersAsBattleMonster;
			byte highlightPosition = 255;
			if(_opponentsTargettingMove.targetMonster==EMonsterPos.Top){
				highlightPosition = 0;
			} else
			if(_opponentsTargettingMove.targetMonster==EMonsterPos.Front) {
				highlightPosition = 1;
			} else if(_opponentsTargettingMove.targetMonster==EMonsterPos.Bottom) {
				highlightPosition = 2;
			}
			for(byte c = 0;c<ms.size;c++) {
			/*	if(c!=highlightPosition) {
					iTween.ColorTo(ms[c].gameObject,new UnityEngine.Color(0.5f,0.5f,0.5f),0.25f);
				
				} else {*/
					if(ms[c]!=null&&ms[c].monster.restingStatus==ERestingStatus.Awake)
						iTween.ColorTo(ms[c].gameObject,new UnityEngine.Color(1.0f,1.0f,1.0f),0.25f);
				//}
			}
			
		}
		
		public void unfadeAllMonsters() {
			BetterList<BattleMonster> ms = this.monstersAsBattleMonster;
			for(byte c = 0;c<ms.size;c++) {
				if(ms[c].monster.restingStatus==ERestingStatus.Awake) {
					iTween.ColorTo(ms[c].gameObject,new UnityEngine.Color(1.0f,1.0f,1.0f),0.25f);
				}
			}
		}
		public void disappearMonster(BattleMonster aMonster,float aFadeTime) {
			aMonster.doRestAnimation();
			iTween.ColorTo(aMonster.gameObject,new UnityEngine.Color(0.1f,0.1f,0.1f),1.00f);
		}
		public void bringMonsterToFront(BattleMonster aMonster) {
			EMonsterPos pos = this.positionForMonster(aMonster);
			switch(pos) {
			case(EMonsterPos.Top):aMonster.sortingLayer = "OnTopMonsterLayer1";break;
			case(EMonsterPos.Front):aMonster.sortingLayer = "OnTopMonsterLayer2";break;
			case(EMonsterPos.Bottom):aMonster.sortingLayer = "OnTopMonsterLayer3";break;
			}
			if(aMonster!=null&&aMonster.GetComponent<Collider2D>()!=null)
				aMonster.GetComponent<Collider2D>().enabled = true;
		}
		public void allMonstersBackInPlace() {
			BetterList<BattleMonster> ms = this.monstersAsBattleMonster;
			for(byte c = 0;c<ms.size;c++) {
				monsterBackInPlace(ms[c]);
			}
		}
		public void monsterBackInPlace(BattleMonster aMonster) {
			EMonsterPos pos = this.positionForMonster(aMonster);
			switch(pos) {
			case(EMonsterPos.Top):aMonster.sortingLayer = "MonsterLayer1";break;
			case(EMonsterPos.Front):aMonster.sortingLayer = "MonsterLayer2";break;
			case(EMonsterPos.Bottom):aMonster.sortingLayer = "MonsterLayer3";break;
			}
			if(aMonster.GetComponent<Collider2D>()!=null)
				aMonster.GetComponent<Collider2D>().enabled = false;
		}
		
		
		
	}
}

