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
using Utils;
using Items;


namespace Battles
{
	public class BattleCompleteMonster : MonoBehaviour
	{
		public UIProgressBar health;
		public UIProgressBar xpBar;
		public UIProgressBar energyBar;
		public UILabel xpGained;
		public UILabel monsterName;
		public UILabel levelUpLabel;
		public UILabel levelLabel;
		public UILabel xpBarLabel;
		public UILabel movePointsAvailableText;
		public UILabel hpBarLabel;
		public UILabel energyBarLabel;
		public bool needsEvolve;
		private BattleMonster _monsterRef;
		private int _xpToAdd = 0;
		private byte _lastLevel = 0;
		public GameObject movePointsBtn;
		public GameObject movePointsGameObject;
		public UILabel movePointsLabel;
		public const bool EVOLVE_DEBUG = false;
		private InventoryDisplay _inventoryRef;
		public UILabel xpBoostedLabel;
		public const float EV_ADDER_DIVIDER = 20f;
		public static float XP_MULTIPLIER = 0.8f;
		public BattleCompleteMonster ()
		{
		}
		
		public void init(BattleMonster aMonster,int aXPToAdd,double aDelayToAdd,float aBestMeleeAtck,float aBestMeleeDef,float aBestRangeAtck,float aBestRangeDef,float aBestSpeed,float aBestAccuracy,float aBestAgility) {
			aMonster.healthBarEnabled = false;
			_xpToAdd = (int) Convert.ToInt32((float) aXPToAdd * XP_MULTIPLIER);
			_monsterRef = aMonster;
			levelUpLabel.gameObject.SetActive(false);
			xpGained.text = "";
			xpBar.value = _monsterRef.monster.XPAsPercentage;
			this.monsterName.text = aMonster.name;
			StartCoroutine(delayedStartToAddXP(aDelayToAdd));
			xpBarLabel.text = _monsterRef.monster.XpToNext().ToString()+" XP To Next";
			hpBarLabel.text = _monsterRef.monster.hp.ToString()+" / "+_monsterRef.monster.MaxHP.ToString();
			health.value = _monsterRef.monster.HpAsPercentage;
			_lastLevel = _monsterRef.monster.level;

			this.transform.FindChild("MovesBtn").FindChild("Glow").gameObject.tag = "ParticlesUnderPlayer";
			Transform t = this.transform.FindChild("MovesBtn").FindChild("Glow");
			ParticleSystem[] p = t.GetComponentsInChildren<ParticleSystem>();
			for(int i =0;i<p.Length;i++) {
				p[i].gameObject.tag = "ParticlesUnderPlayer";
				p[i].gameObject.layer =  14;
			}
			GameObject[] allParticles = GameObject.FindGameObjectsWithTag("ParticlesUnderPlayer");
			for(int i = 0;i<allParticles.Length;i++) {
				allParticles[i].GetComponent<ParticleSystem>().GetComponent<Renderer>().sortingLayerName = "ParticlesUnderPlayer";
				ParticleSystem[] children = allParticles[i].GetComponentsInChildren<ParticleSystem>();
				for(int j = 0;j<children.Length;j++) {
					children[j].GetComponent<Renderer>().sortingLayerName = "ParticlesUnderPlayer";
				}
			}

			checkAvailableMovePoints();
			if(aMonster.ownersName!=PlayerMain.REF.name) {
				Destroy (this.gameObject);
				return;
			}
			
			// Do the ev's where appropriat
			
			if(this._monsterRef.monster.accuracy<aBestAccuracy) {
				this._monsterRef.monster.canBoostAccuracyEV((aBestAccuracy-this._monsterRef.monster.accuracy)/EV_ADDER_DIVIDER,true);
			}
			if(this._monsterRef.monster.agility<aBestAgility) {
				this._monsterRef.monster.canBoostAgilityEV((aBestAgility-this._monsterRef.monster.agility)/EV_ADDER_DIVIDER,true);
			}
			if(this._monsterRef.monster.meleeAttack<aBestMeleeAtck) {
				this._monsterRef.monster.canBoostMeleeAtckEV((aBestMeleeAtck-this._monsterRef.monster.meleeAttack)/EV_ADDER_DIVIDER,true);
			}
			if(this._monsterRef.monster.rangeAttack<aBestRangeAtck) {
				this._monsterRef.monster.canBoostRangeAtckEV((aBestRangeAtck-this._monsterRef.monster.rangeAttack)/EV_ADDER_DIVIDER,true);
			}
			if(this._monsterRef.monster.meleeDefense<aBestMeleeDef) {
				this._monsterRef.monster.canBoostMeleeDefEV((aBestMeleeDef-this._monsterRef.monster.meleeDefense)/EV_ADDER_DIVIDER,true);
			}
			if(this._monsterRef.monster.rangeDefense<aBestRangeDef) {
				this._monsterRef.monster.canBoostMeleeDefEV((aBestRangeDef-this._monsterRef.monster.rangeDefense)/EV_ADDER_DIVIDER,true);
			}
			if(this._monsterRef.monster.speed<aBestSpeed) {
				this._monsterRef.monster.canBoostMeleeDefEV((aBestSpeed-this._monsterRef.monster.speed)/EV_ADDER_DIVIDER,true);
			}
		}
		
		
		public void prepareForEvolve() {
			this.transform.FindChild("MovesBtn").FindChild("Glow").gameObject.SetActive(false);
		}
		public void onInventoryClicked() {
	/*		InventoryDisplay i = AlertGUI.REF.LaunchInventory(this._monsterRef.monster);
			i.onItemSelected += onItemSelected;
			i.onHideInventory += onHideInventory;
			_inventoryRef = i; */
		}
		private void onHideInventory() {
			_inventoryRef.onItemSelected -= onItemSelected;
			_inventoryRef.onHideInventory -= onHideInventory;
			Destroy(_inventoryRef.gameObject);
			_inventoryRef = null;
		}
		private void onItemSelected(ITMItem aItem) {
			this._monsterRef.monster.consumeItem(aItem,true);
			onHideInventory();
			
		}
		public void onMovePointsClicked() {
		//	AlertGUI.REF.LaunchMonsterMoveTree(this._monsterRef);
		}
		
		private void checkAvailableMovePoints() {
			if(this._monsterRef.monster.movePointsAvailable>0&&this._monsterRef.ownersName==PlayerMain.REF.name) {
				movePointsBtn.gameObject.SetActive(true);
				movePointsBtn.layer = 14;
				movePointsGameObject.gameObject.SetActive(true);
				movePointsLabel.text = Convert.ToString(this._monsterRef.monster.movePointsAvailable);
				movePointsAvailableText.gameObject.SetActive(true);
			} else {
				
				movePointsBtn.layer = 14;
				movePointsBtn.gameObject.SetActive(false);
				movePointsAvailableText.gameObject.SetActive(false);
				movePointsGameObject.gameObject.SetActive(false);
			}
		}
		public void doNextEvolve() {
		
		}
		public void Update() {
			if(this.health!=null&&this._monsterRef!=null) {
				this.health.value = this._monsterRef.monster.HpAsPercentage;
				xpBarLabel.text = _monsterRef.monster.XpToNext().ToString()+" XP To Next";
				hpBarLabel.text = _monsterRef.monster.hp.ToString()+" / "+_monsterRef.monster.MaxHP.ToString();
				this.xpBar.value = this._monsterRef.monster.XPAsPercentage;
				this.energyBar.value = this._monsterRef.monster.energyAsPercentage;
				this.energyBarLabel.text = _monsterRef.monster.energy.ToString()+" / "+_monsterRef.monster.MaxEnergy.ToString();
				checkAvailableMovePoints();
				if(_monsterRef!=null&&_monsterRef.monster!=null) {
					xpBar.value = _monsterRef.monster.XPAsPercentage;
					xpBarLabel.text = _monsterRef.monster.XpToNext().ToString()+" XP To Next";
					hpBarLabel.text = _monsterRef.monster.hp.ToString()+" / "+_monsterRef.monster.MaxHP.ToString();
					health.value = _monsterRef.monster.HpAsPercentage;
					bool levelChanged = false;
					if(_monsterRef.monster.level!=_lastLevel) {
						checkAvailableMovePoints();
						_lastLevel = _monsterRef.monster.level;
						this.levelUpLabel.gameObject.SetActive(true);
						Vector3 currentPos = levelUpLabel.gameObject.transform.position;
						TweenPosition.Begin(this.levelUpLabel.gameObject,0.75f,new Vector3(currentPos.x,currentPos.y+43.0f));
						levelChanged = true;
					}
					if(((_monsterRef.monster.monsterBreedRef.evolvesAt<=_lastLevel)&&(levelChanged))||(EVOLVE_DEBUG)) {
						if((this._monsterRef.monster.monsterBreedRef.evolvesTo!=null)&&(_monsterRef.monster.monsterBreedRef.evolvesTo.Name!="No Creature"))
							this.needsEvolve = true;
					}
					this.levelLabel.text = "Lvl "+this._monsterRef.monster.level.ToString();
				}
			}
		}
		private IEnumerator delayedStartToAddXP(double aSecondsToWait) {
			yield return new WaitForSeconds((float) aSecondsToWait);
			this.xpGained.text = "+"+_xpToAdd.ToString()+"xp";;
			Vector3 currentPos = xpGained.gameObject.transform.position;
			TweenPosition.Begin(this.xpGained.gameObject,0.5f,new Vector3(currentPos.x,currentPos.y+2.0f));
			if(PlayerMain.REF.xpBoostAmount>0f) {
				int xp = Convert.ToInt32((float) _xpToAdd*PlayerMain.REF.xpBoostAmount);
				xpBoostedLabel.text = "+"+xp+"xp";
				
				currentPos = xpBoostedLabel.gameObject.transform.position;
				TweenPosition.Begin(this.xpBoostedLabel.gameObject,0.5f,new Vector3(currentPos.x,currentPos.y+2.0f));
				
				_monsterRef.addXP(_xpToAdd+xp);
				
			} else {
				xpBoostedLabel.gameObject.SetActive(false);
				_monsterRef.addXP(_xpToAdd);
			}
			
			
			

			
		
		}
	}
}
