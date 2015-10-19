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


namespace Battles
{
	public class BattleMonsterWithStatusEffects : BattleMonsterWithBattleEffects
	{
		public const float BURN_PERCENT = 0.083f;
		public const float POISON_PERCENT = 0.09f;
		public BattleMonsterWithStatusEffects ()
		{
		}
		public override void initMonster(MonsterDataMain aMonsterRef,EMonsterPos aMyPosition) {
			base.initMonster(aMonsterRef,aMyPosition);
			this._monsterRef.onStatusEffectAdded += onNewStatusEffect;
			this._monsterRef.onStatusEffectRemoved += onRemoveStatusEffect;
			this._monsterRef.onStatusEffectsHPByPercentage += onStatusEffectsHP;
			this._monsterRef.onStatusEffectsHPWithMove += onStatusEffectsHP;
		}
		
		public EStatusEffects statusEffects {
			get {
				return _monsterRef.StatusEffects;
			}
		}
		public void postMoveStatusEffects(MoveQueueItem aMoveQueue) {
			StartCoroutine(postMoveStatusEffectsDelayed(aMoveQueue));
		}
		private IEnumerator postMoveStatusEffectsDelayed(MoveQueueItem aMoveQueue) {
			float dmg = 0;
			float totalWaitRequired = 0.0f;

			if (!aMoveQueue.followOnMove) {
				moveFlags = moveFlags | EMoveFlag.AnyStatusEffecting;
				if (this._monsterRef.lingeringEffects.hasEffect (EStatusEffects.Burn)) {
					// Do Burn Effects
				
					moveFlags = moveFlags | EMoveFlag.HealthChanging;
					dmg = (int)(_monsterRef.MaxHP * BURN_PERCENT);
					if (dmg > this._monsterRef.hp) {
						dmg = this._monsterRef.hp;
					}
					this.doDefenseAnimation ();
					this.hp -= dmg;
				
					StartCoroutine (doneHPChange ());
					this.doCommentaryMessage (this.name + " is hurt by it's Burn", ECommentaryMessageType.StandardMessage);
					this.doCommentaryMessage (dmg + "", ECommentaryMessageType.DamageMessage);
					this.showStatusEffect (EStatusEffects.Burn);
					totalWaitRequired += 0.1f;
					yield return new WaitForSeconds (1.5f);
				
				}
				if (this._monsterRef.lingeringEffects.hasEffect (EStatusEffects.Poison)) {
					moveFlags |= EMoveFlag.HealthChanging;
					dmg = (int)(_monsterRef.MaxHP * POISON_PERCENT);
					if (dmg > this._monsterRef.hp) {
						dmg = this._monsterRef.hp;
					}
					this.doDefenseAnimation ();
					this.hp -= dmg;
				
					StartCoroutine (doneHPChange ());
					MoveLibItem responsibleForPoison = this._monsterRef.lingeringEffects.responsibleForPoison;
					if (responsibleForPoison != null)
						this.doCommentaryMessage (this.name + " is Poisoned. " + this.name + " was poisoned due to " + responsibleForPoison.moveOrPassiveEffectString + " " + responsibleForPoison.Name, ECommentaryMessageType.StandardMessage);
					else {
						this.doCommentaryMessage (this.name + " is Poisoned.", ECommentaryMessageType.StandardMessage);
						
					}
					this.doCommentaryMessage (dmg + "", ECommentaryMessageType.DamageMessage);
					totalWaitRequired += 0.1f;
				
					this.showStatusEffect (EStatusEffects.Poison);
					yield return new WaitForSeconds (1.5f);
				
				
				
				}
			
				yield return new WaitForSeconds (totalWaitRequired + 0.1f);
			
			
				moveFlags = moveFlags & ~EMoveFlag.AnyStatusEffecting;
			}
			aMoveQueue.advanceMoveQueueFromState(EMoveQueueItemStatus.InflictMyEffects);
			aMoveQueue = null;
		}
		protected IEnumerator doneHPChange() {
			yield return new WaitForSeconds(0.5f);
			moveFlags = moveFlags & ~EMoveFlag.HealthChanging;
		}
		
		protected IEnumerator doneEnergyChange() {
			yield return new WaitForSeconds(0.5f);
			moveFlags = moveFlags & ~EMoveFlag.EnergyChanging;
		}
		
		public override void cleanUp() {
			this._monsterRef.onStatusEffectAdded -= onNewStatusEffect;
			this._monsterRef.onStatusEffectRemoved -= onRemoveStatusEffect;
			this._monsterRef.onStatusEffectsHPByPercentage -= onStatusEffectsHP;
			this._monsterRef.onStatusEffectsHPWithMove -= onStatusEffectsHP;
		}
		private void onNewStatusEffect(EStatusEffects aStatusEffect) {
			switch(aStatusEffect) {
				case(EStatusEffects.Burn):
					base.doCommentaryMessage(this.name+" has been Burned!",ECommentaryMessageType.StandardMessage);
					this.showStatusEffect(EStatusEffects.Burn);
				
				break;
			case(EStatusEffects.Confusion):
				this.doCommentaryMessage(this.name+" became Confused!",ECommentaryMessageType.StandardMessage);
				this.showStatusEffect(EStatusEffects.Confusion);
				break;
			case(EStatusEffects.Freeze):
				this.doCommentaryMessage(this.name+" was Frozen!",ECommentaryMessageType.StandardMessage);
				this.showStatusEffect(EStatusEffects.Freeze);
				
				break;
			case(EStatusEffects.Paralyze):
				this.doCommentaryMessage(this.name+" is Paralyzed!",ECommentaryMessageType.StandardMessage);
				this.showStatusEffect(EStatusEffects.Paralyze);
				
				break;
			case(EStatusEffects.Poison):
				this.doCommentaryMessage(this.name+" was Poisoned!",ECommentaryMessageType.StandardMessage);
				this.showStatusEffect(EStatusEffects.Poison);
				break;
			case(EStatusEffects.Sleep):
				this.doCommentaryMessage(this.name+" fell Asleep!",ECommentaryMessageType.StandardMessage);
				this.showStatusEffect(EStatusEffects.Sleep);
				break;
			}
		}
		
		private void onRemoveStatusEffect(EStatusEffects aStatusEffect) {
			switch(aStatusEffect) {
			case(EStatusEffects.Burn):
				base.doCommentaryMessage(this.name+" Burn has been healed!",ECommentaryMessageType.StandardMessage);
				break;
			case(EStatusEffects.Confusion):
				base.doCommentaryMessage(this.name+" is no longer Confused!",ECommentaryMessageType.StandardMessage);
				break;
			case(EStatusEffects.Freeze):
				base.doCommentaryMessage(this.name+" has Thawed!",ECommentaryMessageType.StandardMessage);
				break;
			case(EStatusEffects.Paralyze):
				base.doCommentaryMessage(this.name+" Paralysis has worn off!",ECommentaryMessageType.StandardMessage);
				break;
			case(EStatusEffects.Poison):
				base.doCommentaryMessage(this.name+" is cured of it's Poison!",ECommentaryMessageType.StandardMessage);
				break;
			case(EStatusEffects.Sleep):
				this.doIdleAnimation();
				base.doCommentaryMessage(this.name+" Awoke!",ECommentaryMessageType.StandardMessage);
				break;
			}
		}
		
		private void onStatusEffectsHP(float aPercentage) {
			
		}
		
		private void onStatusEffectsHP(int aMovePower) {
			
		}
		public EStatusEffects lingeringEffectsAllowMove() {
			return this._monsterRef.lingeringEffects.lingeringAllowsMove();
		}
		public MoveLibItem reasonForLastNoMove() {
			return this._monsterRef.lingeringEffects.lastReasonForNoMove;
		}
		protected void doBurn(MoveLibItem aCause) {
			this._monsterRef.addLingeringEffect(EStatusEffects.Burn,aCause);
		}
		protected void healBurn() {
			this._monsterRef.removeLingeringEffect(EStatusEffects.Burn);
		}
		protected void doConfusion(MoveLibItem aCause) {
			if(!this._monsterRef.hasStatusEffect(EStatusEffects.Confusion)) {
				this.showStatusEffect(EStatusEffects.Confusion);
			}
			this._monsterRef.addLingeringEffect(EStatusEffects.Confusion,aCause);
		}
		protected void doFlinch(MoveLibItem aCause) {
			this._monsterRef.addLingeringEffect(EStatusEffects.Flinch,aCause);
		}
		protected void doFreeze(MoveLibItem aCause) {
			
			this._monsterRef.addLingeringEffect(EStatusEffects.Freeze,aCause);
			
		}
		protected void doParalyze(MoveLibItem aCause) {
			
			this._monsterRef.addLingeringEffect(EStatusEffects.Paralyze,aCause);
			
		}
		protected void doPoison(MoveLibItem aCause) {
			
			this._monsterRef.addLingeringEffect(EStatusEffects.Poison,aCause);
			
		}
		protected void doSleep(MoveLibItem aCause) {
			
			this._monsterRef.addLingeringEffect(EStatusEffects.Sleep,aCause);
			
		}
	}
}

