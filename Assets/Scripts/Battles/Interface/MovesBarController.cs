using UnityEngine;
using System.Collections;
using Battles;
using PixelCrushers.DialogueSystem;


namespace Battles {

	public class MovesBarController : MonoBehaviour {
	
		public static int COUNT = 0;
		public MoveButtonScript[] moveButtons;
		public UISprite moveHolder;
		public UIButton escapeButton;
//		public delegate void OnMoveSelected(bool aAutomatic);
	//	public event OnMoveSelected onMoveSelected;
		public HintController hintLabel;
		public GameObject baitButtonHint;
		public delegate void OnEscapeBattle();
		public event OnEscapeBattle onEscapeBattle;
		public bool allowFullDisable = true;
		private EFadingEnum _hideShowBar = EFadingEnum.None;
		private TweenAlpha _hideShowTween;
		private BattleMonster _monsterRef;
		private bool _show = false;
		private bool _allowClicks = false;
		private int _autoSelectMove = 0;
		public GameObject inventoryBtn;
		// Use this for initialization
		void Start () {
			hintLabel.gameObject.SetActive(false);
			this.gameObject.SetActive(false);
			if(escapeButton!=null)
				escapeButton.isEnabled = true;
		}
		
		public void onInventoryClick() {
		
		}
		
		
		public MonsterDataMain currentMonster {
			get {
				return _monsterRef.monster;
			}
		}
		// Update is called once per frame
		void Update () {
		/*	if(_hideShowBar==EFadingEnum.FadingIn) {
				if(this.moveHolder.enabled == false) {
					this.moveHolder.enabled = true;
				}
				if(this.moveHolder!=null) {
				this.moveHolder.alpha += 0.05f;
				
				
				if(this.moveHolder.alpha>=1.0f) {
					_hideShowBar = EFadingEnum.None;
					if(_autoSelectMove!=5)
						TweenAlpha.Begin(inventoryBtn,0f,1f);
					for(int i = 0;i<moveButtons.Length;i++)
						if(_autoSelectMove!=i)
							TweenAlpha.Begin (moveButtons[i].gameObject,0f,1f);
				} 
				

				}
				
			} else if(_hideShowBar==EFadingEnum.FadingOut) {
				if(this.moveHolder!=null) {
					this.moveHolder.alpha -= 0.05f;
					if(this.moveHolder.alpha<=0.05f) {
						_hideShowBar = EFadingEnum.None;
						this.moveHolder.enabled = false;
					} 
				}
			}*/
		}
		
		private IEnumerator turnOffGameObjectIn(GameObject aObject,float aTime) {
			yield return new WaitForSeconds(aTime);
			aObject.SetActive(false);
		}
		public void AutoSelectMove(int aMoveIndex) {
			_autoSelectMove = aMoveIndex;
			this.gameObject.SetActive(true);
			this.baitButtonHint.gameObject.SetActive(false);
			for(int i = 0;i<this.moveButtons.Length;i++) {
				if(i!=aMoveIndex&&aMoveIndex>-1) {
					Debug.Log ("Fading out button");
					moveButtons[i].handleAutoSelect(false);
					StartCoroutine(turnOffGameObjectIn(moveButtons[i].gameObject,0.25f));
				} else {
					
					moveButtons[i].handleAutoSelect(true);
				//	moveButtons[i].gameObject.SetActive(true);
				}
			}
			
			//
			if(aMoveIndex==-1) {
				if(_show) {
					inventoryBtn.gameObject.SetActive(true);
					if(QuestLog.GetQuestState("Find_the_Elders")==QuestState.Success) {
						
						hintLabel.gameObject.SetActive(false);
					} else {
						
						hintLabel.gameObject.SetActive(true);
					}
					this.hintLabel.PointAtGameObjects(litButtons);
				}
			} else
			if(aMoveIndex!=5&&aMoveIndex!=-1&&aMoveIndex!=6) {
				TweenAlpha.Begin (inventoryBtn,0.25f,0.1f);
				StartCoroutine(turnOffGameObjectIn(inventoryBtn,0.25f));
				this.hintLabel.text = "Auto Selecting Move!";
				this.hintLabel.PointAtGameObjects(this.litButtons);
				hintLabel.gameObject.SetActive(true);
				StartCoroutine(waitToSelectMove(aMoveIndex));
			} else {
				if(aMoveIndex!=6) {
					
					inventoryBtn.gameObject.SetActive(true);
					TweenAlpha.Begin (inventoryBtn,0.25f,1f);
					this.hintLabel.text = "Open The Inventory";
					
					hintLabel.gameObject.SetActive(true);
					this.hintLabel.PointAtGameObject(GameObject.Find("BagBtn").transform.parent.gameObject);
				} else {
					inventoryBtn.gameObject.SetActive(false);
					this.baitButtonHint.gameObject.SetActive(true);
					hintLabel.FadeAway();
					hintLabel.gameObject.SetActive(false);
				}
			}
		}
		
		private GameObject[] litButtons {
			get {
				int c = 0;
				for(int i = 0;i<this.moveButtons.Length;i++) {
					if(moveButtons[i].isLit) {
						c++;
					}
				}
				GameObject[] r = new GameObject[c];
				c = 0;
				for(int i = 0;i<this.moveButtons.Length;i++) {
					if(moveButtons[i].isLit) {
						r[c] = moveButtons[i].gameObject;
						c++;
					}
				}
				return r;
			}
		}
		private IEnumerator waitToDisable() {
			yield return new WaitForSeconds(0.5f);
			if(allowFullDisable)
				moveHolder.gameObject.SetActive(false);

		}
		private IEnumerator waitToSelectMove(int aIndex) {
			yield return new WaitForSeconds(1f);
			doMoveSelect((byte) aIndex,true);
		}
		public bool show {
			set {
			 
			//	this.gameObject.SetActive(value);
				COUNT++;
				if(value==true) {
					this.gameObject.SetActive(true);
					if(QuestLog.GetQuestState("Find_the_Elders")==QuestState.Success) {
						
						hintLabel.gameObject.SetActive(false);
					} else {
						
						hintLabel.gameObject.SetActive(true);
					}

					//StopAllCoroutines();
					TweenAlpha.Begin(moveHolder.gameObject,0.5f,1f);
					
					allowFullDisable = false;
					moveHolder.gameObject.SetActive(true);;
					if(_autoSelectMove==-1) {
						
						this.hintLabel.PointAtGameObjects(this.litButtons);
					}
					if(_autoSelectMove!=6) 
						this.hintLabel.FadeIn(this.gameObject); else hintLabel.gameObject.SetActive(false);
					_allowClicks = true;

				} else {
					_autoSelectMove = -1;
					_allowClicks = false;
					//_hideShowBar = EFadingEnum.FadingOut;
					
					AutoSelectMove(_autoSelectMove);
					TweenAlpha.Begin(moveHolder.gameObject,0.5f,0.1f);
					
					if(this.gameObject.activeSelf) {
						allowFullDisable = true;
						StartCoroutine(waitToDisable());
					}
					if(this.hintLabel!=null) {
						
						this.hintLabel.text = "SELECT A MOVE";
						this.hintLabel.PointAtGameObjects(litButtons);
						this.hintLabel.FadeAway(); 
						} else {
							Debug.LogWarning("Battle Engine has no hint label!");
						}
				}
				_show = value;
			}
			get {
				return _show;
			}
		}
		private void initMoveButton(MoveButtonScript aMoveButton,SelectedMoveData aMove) {
			aMoveButton.initFromMove(aMove,(MonsterDataMain) this._monsterRef.monster);
		} 
		
		private void doMoveSelect(byte aMoveSelect,bool aAutomatic) {
			if(_monsterRef!=null&&this.show==true) {
				if(this._monsterRef.energy>=this._monsterRef.moves[aMoveSelect].moveData.getEnergy(_monsterRef.moves[aMoveSelect].move.currentUnlockLevel)) {
					this.show = false;
					this._monsterRef.setFutureMove(aMoveSelect,_monsterRef.targetTeam,_monsterRef.targetMonster,aAutomatic);
				
					_monsterRef = null; 
			//	if(onMoveSelected!=null) {
			//		onMoveSelected(aAutomatic);
			//		}
				} else {
					this.show = false;
					this._monsterRef.setFutureMove(aMoveSelect,_monsterRef.targetTeam,_monsterRef.targetMonster,aAutomatic);
			//		if(onMoveSelected!=null) {
			//			onMoveSelected(aAutomatic);
			//		}
				}
			}
		}
		public void onMoveClick1() {
			if(_allowClicks)
				doMoveSelect(0,false);
		}
		
		public void onMoveClick2() {
			if(_allowClicks)
				doMoveSelect(1,false);
		}
		
		public void onMoveClick3() {
			if(_allowClicks)
				doMoveSelect(2,false);
		}
		
		public void onMoveClick4() {
			if(_allowClicks)
				doMoveSelect(3,false);
		}
		
		public void onEscapeBattleClick() {
			if(onEscapeBattle!=null) {
				onEscapeBattle();
			}
		}
		public byte setMonsterMoves(BattleMonster aMonster) {
			_monsterRef = aMonster;
			byte i = 0;
			if(aMonster!=null) {
			BetterList<SelectedMoveData> moves = aMonster.moves;
			
			for(i = 0;i<moves.size&&i<moveButtons.Length;i++) {
				initMoveButton(moveButtons[i],moves[i]);
			}
			
			this.hintLabel.PointAtGameObjects(litButtons);
				if(QuestLog.GetQuestState("Find_the_Elders")==QuestState.Success) {
					
					hintLabel.gameObject.SetActive(false);
				}

			this.show = true;
			}
			return i;
		}
	}

}