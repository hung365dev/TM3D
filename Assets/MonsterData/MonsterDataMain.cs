using UnityEngine;
public class MonsterDataMain : MonsterDataItemConsumer
{
		public MonsterDataMain ()
		{
		}

		public void initMonster(int aMonsterLibID,byte aLevel,bool aInitMoves) {
			this.monsterBreedRef = MonsterLibrary.REF.getMonster(aMonsterLibID);
			this.level = aLevel;
			if(monsterBreedRef == null) {
				Debug.LogError("Monster ID: "+aMonsterLibID+" Could not be found!");
			} else {
			}
			this.initRandomMoves();
			this.setMoves();
			this.hp = this.MaxHP;
			this.energy = this.MaxEnergy;
		}
			
		public void fullHeal() {
		
			this.hp = this.MaxHP;
			this.healAllStatusEffects();
			this.energy = this.MaxEnergy;
			this.restingStatus = ERestingStatus.Awake;
		}

}
