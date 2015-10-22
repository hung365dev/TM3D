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
using Items;
using System.Collections;


namespace Battles
{
	public class BattleMonster : BattleMonsterWithMoves
	{
		public string ownersName;
		public float hp;
		public BattleMonster()
		{
			
		}
		
		public void applyHPBoostForMove(MoveLibItem aItem,float aSplashPercent,ETeamPosition aTeamPosition,EMonsterPos aPosition) {
			float boostHP = 0f;
			switch(aItem.powerApplicationType) {
				case(EPowerApplicationTypes.Normal):
					//TODO Do normal power formula for boosting this monsters health
				break;
				
				case(EPowerApplicationTypes.PowerIsPercentOfHP):
					boostHP = (aItem.power/100)*this.monster.MaxHP;
				break;
			}
			if(boostHP>0f) {
				this.addHP(boostHP,aTeamPosition,aPosition);
				doCommentaryMessage(this.name+" healed by "+aItem.Name,ECommentaryMessageType.HealMessage);
			}
		}
		public void initMonster(MonsterDataMain aMonsterRef,EMonsterPos aMyPosition) {
			base.initMonster(aMonsterRef,aMyPosition);
			this.ownersName = aMonsterRef.ownersName;
			moveDataRef = new SelectedMoveData[aMonsterRef.selectedMoves.size];
			for(int i = 0;i<aMonsterRef.selectedMoves.size;i++) {
				moveDataRef[i] = aMonsterRef.selectedMoves[i];
			}
		}

		public void Update() {
			hp = this._monsterRef.hp;
		}
		
		public Quaternion rotation {
			set {
				this.gameObject.transform.rotation = value;
			}
			get {
				return gameObject.transform.rotation;
			}
		}
		
	}
}
