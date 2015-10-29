using System;
using UnityEngine;
using System.Collections;
using Items;


namespace Battles
{
	public class BattleMonsterBase : MonoBehaviour
	{
		protected MonsterDataMain _monsterRef;
		protected ETeamPosition _targetTeam;
		protected EMonsterPos _targetMonster;
		protected BattleMonsterMakeup _monsterMakeup;
		
		protected Animator _anim;
		
		public delegate void OnFaintStarted();
		public event OnFaintStarted onFainting;
		
		public delegate void OnFaintComplete(BattleMonster aMonster);
		public event OnFaintComplete onFaintComplete;
		
		protected bool _makeupFaded = false;
		public delegate void OnReturnToIdle();
		public event OnReturnToIdle onIdle;
		
		public delegate void OnClicked(BattleMonster aMonster);
		public event OnClicked onClicked;
		
		
		public delegate void OnRequestCommentaryMessage(BattleMonster aMonster,string aMessage,ECommentaryMessageType aType);
		public event OnRequestCommentaryMessage onCommentaryMessage;
		
		public bool hasBeenCaught = false;
		private EMonsterPos _myPosition;
		private EMoveFlag _moveFlags = EMoveFlag.Idle;
		private int _sortingLayerOffset = 0;
		public EMoveFlag moveFlagPublic = EMoveFlag.Idle;
		private Vector2 _originalColliderCenter;
		public bool oneHitKOImmune = false;
		public bool criticalHitImmune = false;
		protected Collider _collider; 
		
		public float minMultihitMultiplier = 1.0f;
		public BetterList<ElementalType> removedWeaknesses = new BetterList<ElementalType>();
		public EStatusEffects immuneToStatuses = EStatusEffects.None;

		public BattleMonsterBase ()
		{

		}
		
		public void removeAllLingeringEffects() {
			this._monsterRef.lingeringEffects.removeAllEffects();
		}
		public void convertToWild() {
			this._monsterRef.convertToWild();
			
		}
		public bool addRemovedWeakness(ElementalType aElementalType) {
			for(int i = 0;i<removedWeaknesses.size;i++) {
				if(removedWeaknesses[i]==aElementalType) {
					return false;
				}
			}
			removedWeaknesses.Add(aElementalType);
			return true;
		}
		public float getWeaknessStrengthToElement(ElementalType aElementalType) {
			float defaultValue = this.monster.getWeaknessStrengthToElement(aElementalType);
			if(defaultValue<=1.0f) {
				return defaultValue;
			} else {
				for(int i= 0;i<this.removedWeaknesses.size;i++) {
					if(removedWeaknesses[i]==aElementalType) {
						return 1.0f;
					}
				}
				return defaultValue;
			}
		}
		public void awake() {

		}
		

		public Vector3 SpawnPosition {
			get {
				return new Vector3(this.transform.position.x,this.transform.position.y,this.transform.position.z);
			}
		}
		public Vector3 ConfuseSpawnPosition {
			get {
				
				if(this.transform!=null)
					return new Vector3(this.transform.position.x,this.transform.position.y,this.transform.position.z); else return new Vector3();
			}
		} 
		
		public void Start() {
			Debug.Log(this.name);
			_collider = (Collider) this.GetComponent<Collider>();
			if(_collider==null) { 
				Debug.LogError("Monster: "+this.name+" has no collider");
			}
		}
		public void OnDisable() {
			if(_monsterMakeup!=null)
				Destroy (_monsterMakeup.gameObject);
		}
		protected void doCommentaryMessage(string aMessage,ECommentaryMessageType aMessageType) {
			if(onCommentaryMessage!=null) {
				onCommentaryMessage(this as BattleMonster,aMessage,aMessageType);
			}
		}
		public EMoveFlag moveFlags {
			get {
				return _moveFlags;
			}
			set {
				bool wasIdle = _moveFlags!=EMoveFlag.Idle;
				if((value & EMoveFlag.Fainting)==EMoveFlag.Fainting) {
					Debug.Log ("Fainting");
				}
				if((int) value>(int) 2091752) {
					Debug.Log ("How?");
					if((value & EMoveFlag.AnyStatusEffecting)==EMoveFlag.AnyStatusEffecting) {
						Debug.Log ("Has Any Status Effecting");
					}
					if((value & EMoveFlag.BeingBaited)==EMoveFlag.BeingBaited) {
						Debug.Log ("Has Being Baited");
					}
					if((value & EMoveFlag.BeingBurned)==EMoveFlag.BeingBurned) {
						Debug.Log ("Has Being Burned");
					}
					if((value & EMoveFlag.BeingCaught)==EMoveFlag.BeingCaught) {
						Debug.Log ("Has Being Caught");
					}
					if((value & EMoveFlag.BeingConfused)==EMoveFlag.BeingConfused) {
						Debug.Log ("Has Being Confused");
					}
					
					if((value & EMoveFlag.BeingFrozen)==EMoveFlag.BeingFrozen) {
						Debug.Log ("Has Being Frozen");
					}
					if((value & EMoveFlag.BeingHit)==EMoveFlag.BeingHit) {
						Debug.Log ("Has Being Hit");
					}
					if((value & EMoveFlag.BeingParalyzed)==EMoveFlag.BeingParalyzed) {
						Debug.Log ("Has Being Paralyzed");
					}
					if((value & EMoveFlag.BeingPoisoned)==EMoveFlag.BeingPoisoned) {
						Debug.Log ("Has Being Poisoned");
					}
					if((value & EMoveFlag.BeingSeeded)==EMoveFlag.BeingSeeded) {
						Debug.Log ("Has Being Seeded");
					}
					if((value & EMoveFlag.BeingSwapped)==EMoveFlag.BeingSwapped) {
						Debug.Log ("Has Being Swapped");
					}
					if((value & EMoveFlag.EnergyChanging)==EMoveFlag.EnergyChanging) {
						Debug.Log ("Energy Changing");
					}
					
					
					if((value & EMoveFlag.EnviroEffecting)==EMoveFlag.EnviroEffecting) {
						Debug.Log ("Enviro EFfecting");
					}
					
					if((value & EMoveFlag.FadingIn)==EMoveFlag.FadingIn) {
						Debug.Log ("Fading In");
					}

					
					if((value & EMoveFlag.FallingAsleep)==EMoveFlag.FallingAsleep) {
						Debug.Log ("Falling Asleep");
					}
					
					if((value & EMoveFlag.GainingXP)==EMoveFlag.GainingXP) {
						Debug.Log ("Gaining XP");
					}
					if((value & EMoveFlag.HealthChanging)==EMoveFlag.HealthChanging) {
						Debug.Log ("Health Changing");
					}
					
					if((value & EMoveFlag.Idle)==EMoveFlag.Idle) {
						Debug.Log ("Idle");
					}
					if((value & EMoveFlag.Moving)==EMoveFlag.Moving) {
						Debug.Log ("Moving");
					}
					if((value & EMoveFlag.ResistanceChanging)==EMoveFlag.ResistanceChanging) {
						Debug.Log ("ResistanceChanging");
					}
					if((value & EMoveFlag.StatsFalling)==EMoveFlag.StatsFalling) {
						Debug.Log ("StatsFalling");
					}
					if((value & EMoveFlag.StatsRaising)==EMoveFlag.StatsRaising) {
						Debug.Log ("StatsRaising");
					}
					
				}
				_moveFlags = value;
				moveFlagPublic = value;
				if(_moveFlags==EMoveFlag.Idle) {
					if(onIdle!=null) {
						onIdle();
					}
				}
			}
		}
		
		public string name
		{
			get {
				if(this._monsterRef!=null)
					return this._monsterRef.name; else {
					return "Test";
				}
			}	
		}
		
		public virtual void cleanUp() {
			
		}
		
		public void OnMouseDown() {
			if(this._monsterRef!=null)
			Debug.Log (this._monsterRef.name+" has been clicked");
			if(this.onClicked!=null) {
				this.onClicked(this as BattleMonster);
			}
		}
		public EMonsterPos myPosition {
			get {
				return this._myPosition;
			}
			set {
				this._myPosition = value;
			}
		}
		public virtual void initMonster(MonsterDataMain aMonsterRef,EMonsterPos aMyPosition) {
 			_monsterRef = aMonsterRef;
 			if(aMonsterRef==null) {
 				Debug.LogError("Trying to init monster to null monster");
 			}
			_myPosition = aMyPosition;
			createHealthBar();
		}
		public float energy {
			get {
				return this._monsterRef.energy;
			}
			set {
				bool wasExhausted = this._monsterRef.energy==0;
				if(value>_monsterRef.MaxEnergy) {
					value = _monsterRef.MaxEnergy;
				}
				if(_monsterMakeup!=null) {
					this._monsterMakeup.energy.value = value / _monsterRef.MaxEnergy;
				}
				this._monsterRef.energy = value;
				int energyInt = (int) value;
				if(_monsterMakeup!=null) {
					this._monsterMakeup.energy.value = value / _monsterRef.MaxEnergy;
					this._monsterRef.energy = value;
					_monsterMakeup.energyLabel.text = energyInt.ToString()+"/"+_monsterRef.MaxEnergy;;
					
				}
				
				_monsterMakeup.energyLabel.text = energyInt.ToString()+"/"+_monsterRef.MaxEnergy;;
				if(value == 0&&!wasExhausted) {
					StartCoroutine(startFaint());
				}
			}
		}
			
		public float hp {
			get {
				return this._monsterRef.hp;
			}
			set {
				bool wasFainted = this._monsterRef.hp==0;
				if(value>_monsterRef.MaxHP) {
					value = _monsterRef.MaxHP;
				}
				if(_monsterMakeup!=null) {
					this._monsterMakeup.hp.value = value / _monsterRef.MaxHP;
					this._monsterRef.hp = value;
					int hpInt = (int) value;
					_monsterMakeup.hpLabel.text = hpInt.ToString()+"/"+_monsterRef.MaxHP;;

				}
				if(value == 0&&!wasFainted) {
					StartCoroutine(startFaint());
				}
			}
		}
		
		
		public void doRestAnimation() {
			if(this._monsterRef.restingStatus!=ERestingStatus.Awake&&!_makeupFaded&&_monsterMakeup!=null) {
			//	iTween.FadeTo(this._monsterMakeup.gameObject,0f,1f);
				_makeupFaded = true;
			}
			_anim.SetInteger("AnimState",(int) EMonsterAnimations.Rest);
			
		} 
		
		
		
		IEnumerator startFaint() {
			moveFlags |= EMoveFlag.Fainting;
			
			this._monsterRef.restingStatus = ERestingStatus.WaitingToRest;
			if(this.onFainting!=null) {
				this.onFainting();
			}
			float duration = 1.0f;
			float t = 0.0f;
			yield return new WaitForSeconds(1.0f);
		//	cleanUpDisplay();
			if(this.onFaintComplete!=null) {
				this.onFaintComplete(this as BattleMonster);
			}
			this.doRestAnimation();
			moveFlags =  moveFlags & ~EMoveFlag.Fainting;
		}
	
		private void createHealthBar() {

			BattleControllerMain bControl = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<BattleControllerMain>();
			
			if(bControl!=null) {
				GameObject uiRoot = GameObject.FindGameObjectWithTag("UIRoot");
				GameObject prefab = NGUITools.AddChild(uiRoot,BattleControllerMain.REF.monstersDataMakeup);
				
				_monsterMakeup = prefab.GetComponent<BattleMonsterMakeup>() as BattleMonsterMakeup;
				_monsterMakeup.init(this._monsterRef.name,this._monsterRef.level,(BattleMonster) this);

			//	prefab.transform.parent = uiRoot.transform;
				UIFollowTarget followTarget = prefab.GetComponent("UIFollowTarget") as UIFollowTarget;
				followTarget.initTarget(gameObject.transform);
				followTarget.gameCamera = bControl.GlobalCamera;
				followTarget.uiCamera = bControl.UICamera;
				if(this.myPosition==EMonsterPos.Bottom) {
					followTarget.heightOffset = 115;
				} else if(this.myPosition==EMonsterPos.Top) {
					
					followTarget.heightOffset = 70;
				} else {
					followTarget.heightOffset = 70;
				}
				
				hp = this._monsterRef.hp;
				energy = this._monsterRef.energy;
				prefab.transform.localScale = new Vector3(1.0f,1.0f,1.0f);
				Resources.UnloadUnusedAssets();
			}
		}
		public GameObject healthBar {
			get {
				if(_monsterMakeup==null) {
					createHealthBar();
				}
				return _monsterMakeup.gameObject;
			}
		}
		public bool healthBarEnabled {
			set {
				if(this._monsterRef.hp==0) value = false;
				if(this._monsterMakeup!=null)
					_monsterMakeup.gameObject.SetActive(value);
			}
		}
		
		public string sortingLayer {
			set {
				Renderer[] allRenderers = this.GetComponentsInChildren<Renderer>();

				for(int i = 0;i<allRenderers.Length;i++) {
					if(allRenderers[i].gameObject.name.ToLower().Contains("shadow")) {
						allRenderers[i].sortingLayerName = "BackgroundLayer";
						allRenderers[i].sortingOrder = 2;
					} else
						allRenderers[i].sortingLayerName = value;
				}
			}
		}
		
		public void initTargetDefaults(ETeamPosition aMyTeam,EMonsterPos aMyPosition) {
			switch (aMyTeam) {
				default:_targetTeam = ETeamPosition.LeftTeam;break;
				case(ETeamPosition.LeftTeam):_targetTeam = ETeamPosition.RightTeam;break;
			}
			this._targetMonster = aMyPosition;
		}
		
		public ETeamPosition targetTeam {
			get {
				return this._targetTeam;
			}
			set {
				this._targetTeam = value;
			}
		}
		
		public EMonsterPos targetMonster {
			get {
				return this._targetMonster;
			}
			set {
				this._targetMonster = value;
			}
		}
		public virtual float speed {
			get {
				return this._monsterRef.speed;
			}
		}
		public virtual int agility {
			get {
				return (int) this._monsterRef.agility;
			}
		}
		public virtual int rangeAttack {
			get {
				return (int) this._monsterRef.rangeAttack;
			}
		}
		
		public virtual int rangeDefense {
			get {
				return (int) this._monsterRef.rangeDefense;
			}
		}
		
		public virtual int meleeDefense {
			get {
				return (int) this._monsterRef.meleeDefense;
			}
		}
		
		public virtual int meleeAttack {
			get {
				return (int) this._monsterRef.meleeAttack;
			}
		}
		
		public virtual int accuracy {
			get {
				return (int) this._monsterRef.accuracy;
			}
		}
		
			
		public MonsterDataMain monster {
			get { 
				return _monsterRef;
			}
		}
		public void offsetLayers(int aOffsetAmount) {
			addOffsetToChild(this.gameObject.transform,aOffsetAmount);
		}
		
		private void addOffsetToChild(Transform aChild,int aOffset) {
			SpriteRenderer sprite = aChild.gameObject.GetComponent<SpriteRenderer>();
			if (sprite) {
				sprite.sortingOrder += aOffset;
			}
			
			foreach (Transform child in aChild.transform) {
				addOffsetToChild(child,aOffset);
			}
		}

	}
}

