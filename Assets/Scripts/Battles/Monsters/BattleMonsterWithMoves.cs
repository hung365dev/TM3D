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
using Items;


namespace Battles
{
	public class BattleMonsterWithMoves : BattleMonsterWithStatusEffects
	{
		private MoveQueueItem _futureMoveInfo;
		
		public delegate void OnMoveSet(BattleMonster aMonster,MoveLibItem aMove,bool aAutomatic);
		public event OnMoveSet onMoveSet;
		public SelectedMoveData[] moveDataRef;
		private string _lastMoveNameString = "";
		public BattleMonsterWithMoves ()
		{
		}

		public void setAnimation(string aAnimation) {
			this._anim.SetTrigger (aAnimation);
		}
		public void setAnimation(EMonsterAnimations aAnimation) {
			this._anim.SetInteger ("AnimState", (int) aAnimation);
		}
		public IEnumerator consumeItem(ITMItem aItem,MoveQueueItem aMoveQueue) {
			yield return new WaitForSeconds(0.5f);
			float hpBefore = this._monsterRef.hp;
			float energyBefore = this._monsterRef.energy;
			this._monsterRef.consumeItem(aItem,true);
			if(aItem.Type()==EItemType.BattleBoost) {
				this.applyStatEffectsFromMove((BattleBoostItem) aItem,aMoveQueue);
			}
			float hpNow = this._monsterRef.hp;
			float hpDiff = hpNow - hpBefore;
			this._monsterRef.hp -= hpDiff;
			if(hpDiff>0) {
					this.addHP(hpDiff,aMoveQueue.actioningTeam.teamPosition,aMoveQueue.actionPosition);
					
				}
			float energyNow = this._monsterRef.energy;
			float energyDiff = energyNow-energyBefore;
			if(energyDiff>0) {
				this.addEnergy(energyDiff,aMoveQueue.actioningTeam.teamPosition,aMoveQueue.actionPosition);
			}
			yield return new WaitForSeconds(0.5f);
			aMoveQueue.skipToFinish();
		}
		public byte unlockLevelForMove(MoveLibItem aMove) {
			for(int i = 0;i<monster.selectedMoves.size;i++) {
				if(monster.selectedMoves[i]._forcedMove==aMove) {
					return (byte) monster.selectedMoves[i].forcedMoveUnlockLevel;
				}
			}
			BetterList<MoveTreeCompletionDataRow> row = this._monsterRef.unlockedMoves;
			for(int i = 0;i<row.size;i++) {
				if(row[i].moveData==aMove) {
					return row[i].currentUnlockLevel;
				}
			}
			return 0;
		}
		public void prepareForNextTurn() {
			_futureMoveInfo = null;
		}

		public float applyStatusEffectsForMove(MoveLibItem aMove,float aSplashPercent,PassiveEffect aEffect) {
			return applyStatusEffectsForMove(aMove,aSplashPercent);
		}
		
		public bool invulnerableToBurn {
			get {
				return (this.immuneToStatuses&EStatusEffects.Burn)==EStatusEffects.Burn;
			}
		}
		
		public bool invulnerableToConfusion {
			get {
				return (this.immuneToStatuses&EStatusEffects.Confusion)==EStatusEffects.Confusion;
			}
		}
		
		public bool invulnerableToFreeze {
			get {
				return (this.immuneToStatuses&EStatusEffects.Freeze)==EStatusEffects.Freeze;
			}
		}
		public bool invulnerableToParalyzed {
			get {
				return (this.immuneToStatuses&EStatusEffects.Paralyze)==EStatusEffects.Paralyze;
			}
		}
		public bool invulnerableToPoison {
			get {
				return (this.immuneToStatuses&EStatusEffects.Poison)==EStatusEffects.Poison;
			}
		}
		public bool invulnerableToSleep {
			get {
				return (this.immuneToStatuses&EStatusEffects.Sleep)==EStatusEffects.Sleep;
			}
		}
		public float applyStatusEffectsForMove(MoveLibItem aMove,float aSplashPercent) {
			EStatusEffects effectsApplied = EStatusEffects.None;
			float delayToAdd = 0.0f;
			const float delayPerEffect = 1.5f;
			int invulnerableInt = (int) aMove.addsInvulnerabilityToStatus;
			int currentImmunity = (int) aMove.addsInvulnerabilityToStatus;
	//		int leftSide = (int) aMove.addsInvulnerabilityToStatus&this.immuneToStatuses;
			if((aMove.addsInvulnerabilityToStatus|this.immuneToStatuses)!=this.immuneToStatuses) {
				if(((aMove.addsInvulnerabilityToStatus&EStatusEffects.Burn)==EStatusEffects.Burn)&&(!this.invulnerableToBurn)) {
					this.immuneToStatuses = this.immuneToStatuses | EStatusEffects.Burn;
					base.doCommentaryMessage(this.name+ " became invulnerable to Burns!",ECommentaryMessageType.StandardMessage);
				}
				if(((aMove.addsInvulnerabilityToStatus&EStatusEffects.Confusion)==EStatusEffects.Confusion)&&(!this.invulnerableToConfusion)) {
					this.immuneToStatuses = this.immuneToStatuses | EStatusEffects.Confusion;
					base.doCommentaryMessage(this.name+ " became invulnerable to Confusion!",ECommentaryMessageType.StandardMessage);
				}
				if(((aMove.addsInvulnerabilityToStatus&EStatusEffects.Freeze)==EStatusEffects.Freeze)&&(!this.invulnerableToFreeze)) {
					this.immuneToStatuses = this.immuneToStatuses | EStatusEffects.Freeze;
					base.doCommentaryMessage(this.name+ " became invulnerable to being Frozen!",ECommentaryMessageType.StandardMessage);
				}
				if(((aMove.addsInvulnerabilityToStatus&EStatusEffects.Paralyze)==EStatusEffects.Paralyze)&&(!this.invulnerableToParalyzed)) {
					this.immuneToStatuses = this.immuneToStatuses | EStatusEffects.Paralyze;
					base.doCommentaryMessage(this.name+ " became invulnerable to being Paralyzed!",ECommentaryMessageType.StandardMessage);
				}
				if(((aMove.addsInvulnerabilityToStatus&EStatusEffects.Poison)==EStatusEffects.Poison)&&(!this.invulnerableToPoison)) {
					this.immuneToStatuses = this.immuneToStatuses | EStatusEffects.Poison;
					base.doCommentaryMessage(this.name+ " became invulnerable to Poison!",ECommentaryMessageType.StandardMessage);
				}
				if(((aMove.addsInvulnerabilityToStatus&EStatusEffects.Sleep)==EStatusEffects.Sleep)&&(!this.invulnerableToSleep)) {
					this.immuneToStatuses = this.immuneToStatuses | EStatusEffects.Sleep;
					base.doCommentaryMessage(this.name+ " became invulnerable to being put to Sleep!",ECommentaryMessageType.StandardMessage);
				}
			}
			PassiveEffect statusPassiveEffect = null;
			if(aMove.burnPercent<0&&(aMove.burnPercent*-1)*aSplashPercent>BattleRandomizer.random&&this._monsterRef.hasStatusEffect(EStatusEffects.Burn)) {
				delayToAdd += delayPerEffect;
				this.monster.removeLingeringEffect(EStatusEffects.Burn);
			} else
			if(aMove.burnPercent*aSplashPercent>BattleRandomizer.random&&!this._monsterRef.hasStatusEffect(EStatusEffects.Burn)) {
				if(this.invulnerableToBurn) {
					doBurn(aMove);
					effectsApplied = effectsApplied | EStatusEffects.Burn;
					delayToAdd += delayPerEffect;
					statusPassiveEffect = this.monster.hasPassiveEffectForTime(EWhenToApply.WhenStatusEffectsSuffered,0f,this.monster.HpAsPercentage,ElementalLibrary.REF.getElement("Normal"),this.monster.elementType,null,null,aMove.rangeStatus,(BattleMonster) this,aMove.elementType,EStatusEffects.Burn);
				}
			}
			if(aMove.confusionPercent<0&&(aMove.confusionPercent*-1)*aSplashPercent>BattleRandomizer.random&&this._monsterRef.hasStatusEffect(EStatusEffects.Confusion)) {
				delayToAdd += delayPerEffect;
				this.monster.removeLingeringEffect(EStatusEffects.Confusion);
			} else
			if(aMove.confusionPercent*aSplashPercent>BattleRandomizer.random&&!this._monsterRef.hasStatusEffect(EStatusEffects.Confusion)) {
				if(this.invulnerableToConfusion) {
					doConfusion(aMove);
					effectsApplied = effectsApplied | EStatusEffects.Confusion;
					delayToAdd += delayPerEffect;
					statusPassiveEffect = this.monster.hasPassiveEffectForTime(EWhenToApply.WhenStatusEffectsSuffered,0f,this.monster.HpAsPercentage,ElementalLibrary.REF.getElement("Normal"),this.monster.elementType,null,null,aMove.rangeStatus,(BattleMonster) this,aMove.elementType,EStatusEffects.Confusion);
				}
			}	
			
			if(aMove.flinchPercent*aSplashPercent>BattleRandomizer.random&&!this._monsterRef.hasStatusEffect(EStatusEffects.Flinch)) {
				doFlinch(aMove);
				effectsApplied = effectsApplied | EStatusEffects.Flinch;
				delayToAdd += delayPerEffect;
				
				statusPassiveEffect = this.monster.hasPassiveEffectForTime(EWhenToApply.WhenStatusEffectsSuffered,0f,this.monster.HpAsPercentage,ElementalLibrary.REF.getElement("Normal"),this.monster.elementType,null,null,aMove.rangeStatus,(BattleMonster) this,aMove.elementType,EStatusEffects.Flinch);
			}
			if(aMove.freezePercent<0&&(aMove.freezePercent*-1)*aSplashPercent>BattleRandomizer.random&&this._monsterRef.hasStatusEffect(EStatusEffects.Freeze)) {
				delayToAdd += delayPerEffect;
				this.monster.removeLingeringEffect(EStatusEffects.Freeze);
			} else
			if(aMove.freezePercent*aSplashPercent>BattleRandomizer.random&&!this._monsterRef.hasStatusEffect(EStatusEffects.Freeze)) {
				if(!this.invulnerableToFreeze) {
					doFreeze(aMove);
					effectsApplied = effectsApplied | EStatusEffects.Freeze;
					delayToAdd += delayPerEffect;
					
					statusPassiveEffect = this.monster.hasPassiveEffectForTime(EWhenToApply.WhenStatusEffectsSuffered,0f,this.monster.HpAsPercentage,ElementalLibrary.REF.getElement("Normal"),this.monster.elementType,null,null,aMove.rangeStatus,(BattleMonster) this,aMove.elementType,EStatusEffects.Freeze);
				}
			}
			if(aMove.paralyzePercent<0&&(aMove.paralyzePercent*-1)*aSplashPercent>BattleRandomizer.random&&this._monsterRef.hasStatusEffect(EStatusEffects.Paralyze)) {
				delayToAdd += delayPerEffect;
				this.monster.removeLingeringEffect(EStatusEffects.Paralyze);
			} else
			if(aMove.paralyzePercent*aSplashPercent>BattleRandomizer.random&&!this._monsterRef.hasStatusEffect(EStatusEffects.Paralyze)) {
				if(!this.invulnerableToParalyzed) {
					doParalyze(aMove);
					effectsApplied = effectsApplied | EStatusEffects.Paralyze;
					delayToAdd += delayPerEffect;
					
					statusPassiveEffect = this.monster.hasPassiveEffectForTime(EWhenToApply.WhenStatusEffectsSuffered,0f,this.monster.HpAsPercentage,ElementalLibrary.REF.getElement("Normal"),this.monster.elementType,null,null,aMove.rangeStatus,(BattleMonster) this,aMove.elementType,EStatusEffects.Paralyze);
				}
			}
			if(aMove.poisonPercent<0&&(aMove.poisonPercent*-1)*aSplashPercent>BattleRandomizer.random&&this._monsterRef.hasStatusEffect(EStatusEffects.Poison)) {
				delayToAdd += delayPerEffect;
				this.monster.removeLingeringEffect(EStatusEffects.Poison);
			} else
			if(aMove.poisonPercent*aSplashPercent>BattleRandomizer.random&&!this._monsterRef.hasStatusEffect(EStatusEffects.Poison)) {
				if(!this.invulnerableToPoison) {
					doPoison(aMove);
					effectsApplied = effectsApplied | EStatusEffects.Poison;
					delayToAdd += delayPerEffect;
					
					statusPassiveEffect = this.monster.hasPassiveEffectForTime(EWhenToApply.WhenStatusEffectsSuffered,0f,this.monster.HpAsPercentage,ElementalLibrary.REF.getElement("Normal"),this.monster.elementType,null,null,aMove.rangeStatus,(BattleMonster) this,aMove.elementType,EStatusEffects.Poison);
				}
			}
			if(aMove.sleepPercent<0&&(aMove.sleepPercent*-1)*aSplashPercent>BattleRandomizer.random&&this._monsterRef.hasStatusEffect(EStatusEffects.Sleep)) {
				delayToAdd += delayPerEffect;
				this.monster.removeLingeringEffect(EStatusEffects.Sleep);
			} else
			if(aMove.sleepPercent*aSplashPercent>BattleRandomizer.random&&!this._monsterRef.hasStatusEffect(EStatusEffects.Sleep)) {
				if(!this.invulnerableToSleep) {
					doSleep(aMove);
					this.doRestAnimation();
					effectsApplied = effectsApplied | EStatusEffects.Sleep;
					delayToAdd += delayPerEffect;
					
					statusPassiveEffect = this.monster.hasPassiveEffectForTime(EWhenToApply.WhenStatusEffectsSuffered,0f,this.monster.HpAsPercentage,ElementalLibrary.REF.getElement("Normal"),this.monster.elementType,null,null,aMove.rangeStatus,(BattleMonster) this,aMove.elementType,EStatusEffects.Sleep);
				}
			}
			
			if(statusPassiveEffect!=null) {
				CommentaryManager.REF.passiveEffect = statusPassiveEffect;
				CommentaryManager.REF.battleMonster = (BattleMonster) this;
				
				this.applyStatEffectsFromMove(statusPassiveEffect.moveRef,null);
				
				CommentaryManager.REF.passiveEffect = null;
				CommentaryManager.REF.battleMonster = null;
				
			}
			if(aMove.addsWeaknessTo!=null) {
				if(BattleRandomizer.random<aMove.chanceOfAddVulnerability) {
					byte duration = aMove.effectsDuration;
					if(aMove.effectsDuration==0) {
						duration = (byte) ((BattleRandomizer.random*3)+1);
					}
					this._monsterRef.addVulnerability(aMove.addsWeaknessTo,duration);
					base.doCommentaryMessage(this.name+ " became vulnerable to "+aMove.addsWeaknessTo.Name+" Moves for "+duration+" Turns!",ECommentaryMessageType.StandardMessage);
					
				}
			}
			
			return delayToAdd;
			
		}
		public void addMissedMessage(MoveLibItem aItem) {
			
			this.doCommentaryMessage(aItem.Name+" Missed!",ECommentaryMessageType.DamageMessage);
		}
		public void addHP(float aHeal,ETeamPosition aTeamPosition,EMonsterPos aMonsterPosition) {

			if(aHeal>0f) {
				
				this.doCommentaryMessage(aHeal+"",ECommentaryMessageType.HealMessage);this.hp += aHeal;
				moveFlags = moveFlags | EMoveFlag.HealthChanging;
				
				StartCoroutine(doneHPChange());
				GameObject restore = getEffect("RestoreHealth");
				if(restore!=null)
					restore.transform.position = this.SpawnPosition;
				this.doCommentaryMessage(aHeal+"",ECommentaryMessageType.HealMessage);
			}
			
		}

		public void addEnergy(float aEnergy,ETeamPosition aTeamPosition,EMonsterPos aMonsterPosition) {
			if(aEnergy>0f) {
				moveFlags = moveFlags | EMoveFlag.EnergyChanging;
				
				this.energy += aEnergy;
				GameObject restore = getEffect("RestoreEnergy");
				if(restore!=null)
					restore.transform.position = this.SpawnPosition;
				StartCoroutine(doneEnergyChange());
				this.doCommentaryMessage(aEnergy+"",ECommentaryMessageType.HealMessage);
			}
		}
		public void takeHP(float aDamage,ETeamPosition aTeamPosition,EMonsterPos aMonsterPosition,bool aCriticalApplied = false) {
			
			moveFlags = moveFlags | EMoveFlag.HealthChanging;
			if(aDamage>this._monsterRef.hp) {
				aDamage = this._monsterRef.hp;
			}
			this.hp -= aDamage;
			
			StartCoroutine(doneHPChange());
			this.doCommentaryMessage(Convert.ToInt32(aDamage).ToString()+"",ECommentaryMessageType.DamageMessage);
			if(aCriticalApplied) {
				this.doCommentaryMessage("Decisive Blow on "+this.name,ECommentaryMessageType.DmgCritical);
			}
			
		}
		public void setAIFutureMove(ETeamPosition aMyTeamPosition) {
			bool moveAllowed = false;
			int c = 10;
			while(c>=0&&!moveAllowed) {
				c--;
				byte move = (byte) (BattleRandomizer.random*this.moves.size);
				SelectedMoveData moveData = moves[move];
				while(moveData==null||moveData.moveData==null) {
					move = (byte) (BattleRandomizer.random*this.moves.size);
					moveData = moves[move];

				}
				if((moveData.move!=null&&moveData.move.itemRef!=null&&moveData.move.itemRef.moveData!=null)&&_lastMoveNameString==moveData.move.itemRef.moveData.Name) {
					moveAllowed = false;
				} else {
					moveAllowed = true;
				} 
				if(moveAllowed) {
					if(moveData.move!=null&&moveData.move.moveBranch!=null&&moveData.move.moveBranch==EMoveBranch.SupportingBranch) {
						_lastMoveNameString = moveData.move.itemRef.moveData.Name;
					} else {
						_lastMoveNameString = "";
					}
					if(_futureMoveInfo!=null) {
						_futureMoveInfo.cleanUp();
						_futureMoveInfo =null; 
					}
					
					if(moveData.moveData.isBoost) {
						_futureMoveInfo = new MoveQueueItem(this.speed,moveData,aMyTeamPosition,this._targetMonster,this,this.myPosition);
					} else 
						_futureMoveInfo = new MoveQueueItem(this.speed,moveData,this._targetTeam,this._targetMonster,this,this.myPosition);
					if(onMoveSet!=null) {
						onMoveSet(this as BattleMonster,this._futureMoveInfo.moveData,true);
					}
				}
				
			}
			

		}
		
		public void setFutureMove(ITMItem aItem) {
			
			SelectedMoveData moveData = new SelectedMoveData(aItem);
			
			if(_futureMoveInfo!=null) {
				_futureMoveInfo.cleanUp();
				_futureMoveInfo =null;
			}
			_futureMoveInfo = new MoveQueueItem(aItem,this);
			if(onMoveSet!=null) {
				Debug.Log("Setting Future Move From Item: "+aItem.Name());
				onMoveSet(this as BattleMonster,this._futureMoveInfo.moveData,false);
			}
			
		}
		
		public void setFutureMove(byte aMoveIndex,ETeamPosition aTargetTeam,EMonsterPos aTargetMonster,bool aAutomatic) {
			
			SelectedMoveData moveData = null;
			if(aMoveIndex<moves.size) 
				moveData = moves[aMoveIndex]; else {
					moveData = new SelectedMoveData();
				}
			if(_futureMoveInfo!=null) {
				_futureMoveInfo.cleanUp();
				_futureMoveInfo =null;
			}
			_futureMoveInfo = new MoveQueueItem(this.speed,moveData,aTargetTeam,aTargetMonster,this,this.myPosition);
			if(onMoveSet!=null) {
				onMoveSet(this as BattleMonster,this._futureMoveInfo.moveData,aAutomatic);
			}
			
		}
		public void setFutureMove(MoveLibItem aMoveData,ETeamPosition aTargetTeam,EMonsterPos aTargetMonster,bool aAutomatic) {
			for(byte i = 0;i<moves.size;i++) {
				
				if(moves[i]!=null&&moves[i].moveData!=null&&moves[i].moveData.Name==aMoveData.Name) {
					setFutureMove (i,aTargetTeam,aTargetMonster,aAutomatic);
					return;
				}
			}
			
			
		}
		
		public MoveQueueItem futureMove {
			get {
				return _futureMoveInfo;
			}
		}
		public BetterList<SelectedMoveData> moves {
			get {
				return this.monster.selectedMoves;
			}
		}
	}
}

