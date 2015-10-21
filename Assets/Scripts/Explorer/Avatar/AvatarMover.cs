using UnityEngine;
using System.Collections;
using Battles;
using PixelCrushers.DialogueSystem;
using System;

public class AvatarMover : MonoBehaviour {
	
	public DynamicStick joystick = null;
	public WorldExplorer explorer;
	
	
	public GameObject frontView;
	public GameObject sideView;
	public GameObject backView;
	
	
	public GameObject mountFront;
	public GameObject mountSide;
	public GameObject mountBack;
	
	public static DynamicStick JoystickRef;
	public static bool RESET_TO_RANCH_POS = false;
	public float walkSpeed = 0.1f;
	public float runSpeed = 0.1f;
	public Animator frontAnimator;
	public Animator sideAnimator;
	public Animator backAnimator;
	public Animator _animator;
	private bool _firstUpdate = true;
	private Vector2 _lastTile = new Vector2();
	public float MOVEMENT_DAMPENER = 6f;
	private float _lastUpdate;
	private int _lastDirection = -1;
	private bool _allowAutoWalk = false;
	public float maxWalkSpeeds;
	private Vector3 _forcedWalkTo;
	public bool isMale = true;
	public string currentLayer;
	public Vector3 lastDirection;
	public GameObject forceConvoWith;
	public bool allowManualAnimations = true;
	// Use this for initialization
	void Start () {
		if(PlayerMain.REF==null) {
			Application.LoadLevel("InitGameScene");
			return;
		}
		this.tag = "Player";

		JoystickRef = joystick;
	/*	explorer.transitionManager.enabled = false;
		explorer.transitionManager.onTransitionComplete += onEntryComplete;
		explorer.transitionManager.renderer.material.SetTexture("_MainTex", explorer.transitionToMap);
		 
		explorer.transitionManager.Play();*/
//		Shader shad = explorer.transitionManager.GetComp
		//joystick.JoystickMovedEvent += onJoystickMoved;


		GameObject g = GameObject.FindGameObjectWithTag("LocationChangers");
		StartCoroutine(pauseForAutoMovements());
		
	}
	
	public void swapToMount() {
		
		GameObject t1 = frontView;
		GameObject t2 = sideView;
		GameObject t3 = backView;
		
		frontView = mountFront;
		sideView = mountSide;
		backView = mountBack;
		
		
		mountFront = t1;
		mountSide = t2;
		mountBack = t3;
		
		frontView.gameObject.SetActive(true);
		sideView.gameObject.SetActive(true);
		backView.gameObject.SetActive(true);
		
		mountFront.gameObject.SetActive(false);
		mountSide.gameObject.SetActive(false);
		mountBack.gameObject.SetActive(false);
		
		this.frontAnimator = frontView.GetComponent<Animator>();
		this.sideAnimator = sideView.GetComponent<Animator>();
		this.backAnimator = backView.GetComponent<Animator>();
		
		StartCoroutine(delayToChangeLayer());
		this.changeLayer(currentLayer);
		Debug.Log (lastDirection.magnitude);
		if(lastDirection.magnitude<0.1f) {
			lastDirection = new Vector3(0f,-0.1f,0f);
		}
		this.walkInDirection(lastDirection*3f);
		if(WorldExplorer.MOUNTED) {
			MOVEMENT_DAMPENER = 4.5f;
		} else {
			MOVEMENT_DAMPENER = 6f;
		}
	}
	private IEnumerator delayToChangeLayer() {
		yield return new WaitForSeconds(0.1f);
		this.changeLayer(currentLayer);
	}
	private IEnumerator pauseForAutoMovements() {
		yield return new WaitForEndOfFrame();
		
		Map thisMap = PlayerMain.REF.futureDoorway.targetMap;
		Vector3 pos = this.transform.position;
		if(PlayerMain.REF.futureDoorway!=null) {
			pos.x = PlayerMain.REF.futureDoorway.targetXY.x;
			pos.y = PlayerMain.REF.futureDoorway.targetXY.y;
			
			Vector2 doorwayPos = PlayerMain.REF.futureDoorway.targetXY;
			if(doorwayPos.x==0&&doorwayPos.y==0) {
				doorwayPos.x = thisMap.defaultStart.x;
				doorwayPos.y = thisMap.defaultStart.y;
			}
			if(thisMap.defaultStart.x==doorwayPos.x&&thisMap.defaultStart.y==doorwayPos.y) {
				if(explorer.locator!=null) {
					Vector2 v = explorer.locator.findLocation();
					if(v.x>0&&v.y>0) {
						pos.x = v.x;
						pos.y = v.y;
					}
				}
			}
		} else {
			if(explorer.locator!=null) {
				Vector2 v = explorer.locator.findLocation();
				if(v.x>0&&v.y>0) {
					pos.x = v.x;
					pos.y = v.y;
				}
			}
		}
		this.transform.position = pos;	
		
		this.changeLayer("MainPlayer");
		if(PlayerMain.REF.monsterCount==0) {
			pos.x = 25.6f;
			pos.y = 6.5f;
			
			this.transform.position = pos;	
		}
		

		
		_firstUpdate = true;
		updateCamera();
		walkInDirection(new Vector3(0f,-0.05f,0f));
		yield return new WaitForSeconds(0.5f);
		_allowAutoWalk = true;
		
		NPCForceConvo[] fc = explorer.allMap.GetComponentsInChildren<NPCForceConvo>();
		for(int i = 0;i<fc.Length;i++) {
			if(fc[i].forceConversation) {
				BoxCollider2D bc = fc[i].gameObject.GetComponent<BoxCollider2D>();
				if(bc!=null) {
					if(this.GetComponent<Collider2D>().bounds.Intersects(bc.bounds)) {
						OnTriggerEnter2D(bc);
					}
					
				}
			}
		}
		
	}
	public void directRouteTo(Vector2 aLocation) {
		this._forcedWalkTo = aLocation;
		
	}
	void OnTriggerEnter2D(Collider2D other) {
		if(_allowAutoWalk) {
			GameObject otherG = other.gameObject;
			if(otherG.GetComponent<NPCForceConvo>()!=null) {
				NPCForceConvo force = otherG.GetComponent<NPCForceConvo>();
				if(force.forceConversation) {
					setJoystickActive(false);
					directRouteTo(force.location);
					forceConvoWith = force.gameObject;
				}
			}
			if(otherG.GetComponent<MapDoorway>()!=null) {
				MapDoorway d = otherG.GetComponent<MapDoorway>();
				Debug.Log("Doorway is: "+d.name);
				if(d.name==this.explorer.map.name) {
					Vector3 pos = new Vector3();
					
					pos.x = d.targetXY.x;
					pos.y = d.targetXY.y;
					this.transform.position = pos;
					
				} else {
					PlayerMain.REF.futureDoorway = new Doorway(d.targetDoorway,d.targetXY);
					
			//		SplashScreenManager.ADTIME = EAdTime.MapChange;
					explorer.changeScene("MapChangeSplashScreen");
					setJoystickActive(false);
					return;
				}
			}
		
		}
	}
	
	public void OnCollisionEnter2D(Collision2D other) {

	}
	public void Awake() {
		_lastUpdate = Time.time;
		updateCamera();
	}
	
	
	public void setAnimationState(bool aAnimate) {
		//_animator.animation.enabled = aAnimate;
	}
	public static void setJoystickActive(bool aIsActive) {
	}
	private void onEntryComplete() {
		
	}
	
	private void walkInDirection(Vector3 aRelativeVec) {
		if(_firstUpdate) {
			
			_firstUpdate = false;
		}
		if((aRelativeVec.x!=0f)||(aRelativeVec.y!=0f)) {
			_lastUpdate = Time.time;
		}
		Vector2 originalPos = new Vector2(this.transform.position.x,this.transform.position.y);
		aRelativeVec = aRelativeVec / MOVEMENT_DAMPENER;
		
		int movementSpeed = 0; // Idle
		// 1 = Walking
		// 2 = Running
		// 3 = Bending down
		if((aRelativeVec.magnitude>0f)&&(aRelativeVec.magnitude<walkSpeed)) {
			movementSpeed = 1;
			lastDirection = aRelativeVec;
		} else
		if(aRelativeVec.magnitude>=walkSpeed) {
			movementSpeed = 2;
			lastDirection = aRelativeVec;
		}
		
		if(_animator!=null) {
			if(allowManualAnimations)
				_animator.SetInteger("AnimState",movementSpeed);
		}
		this.transform.position += aRelativeVec;
		Vector3 pos = this.transform.position;
		pos.y += 0.5f;

			

	}
	private void onJoystickMoved(Vector3 aRelativeVec) {
		if(_forcedWalkTo.x==0&&_forcedWalkTo.y==0)
			walkInDirection(aRelativeVec);
	}
	
	private IEnumerator waitToDoAnimState(int aAnimState) {
		yield return new WaitForSeconds(0.2f);
		allowManualAnimations = false;
		_animator.SetInteger("AnimState",aAnimState);
		yield return new WaitForSeconds(2f);
		allowManualAnimations = true;
		
	}
	public void doAnimState(int aAnimState) {
		setMyDirection(new Vector3(1f,0f,0f));
		StartCoroutine(waitToDoAnimState(aAnimState));
	}
	public void setMyDirection(Vector3 aRelativeVec) {
		if(aRelativeVec.sqrMagnitude<0.001f) {
			return;
		}
		float radians = Mathf.Atan2(aRelativeVec.y,aRelativeVec.x);
		int roughDegrees = (int) (radians * 57.2);
		roughDegrees = 360 - (roughDegrees+270);
		if(roughDegrees<0) {
			roughDegrees+=360;
		}
		if((roughDegrees>325)||roughDegrees<45) {
			
		//	if(_lastDirection!=2) {
				this.frontView.SetActive(false);
				this.sideView.SetActive(false);
				_animator = this.backAnimator;
				
		//		_animator.Play (0);
				this.backView.SetActive(true);
		//		_lastDirection = 2;
		//	}
		} else 
		if(roughDegrees>=45&&roughDegrees<135) {
		//	if(_lastDirection!=1) {
				this.frontView.SetActive(false);
				this.backView.SetActive(false);
				_animator = this.sideAnimator;
		//		_animator.Play (0);
				this.sideView.SetActive(true);
				Vector3 newScale = sideView.transform.localScale;
				newScale.x = 1;
				sideView.transform.localScale = newScale;
				_lastDirection = 1;
		//	}
		} else 
		if(roughDegrees>=135&&roughDegrees<225) {
			//	_animator.SetInteger("facing",2);
		//	if(_lastDirection!=0) {
				this.sideView.SetActive(false);
				this.backView.SetActive(false);
				_animator = this.frontAnimator;
		//		_animator.Play (0);
				this.frontView.SetActive(true);
		//		_lastDirection = 0;
	//		}
		} else {
			//	_animator.SetInteger("facing",3);
		//	if(_lastDirection!=3) {
				this.frontView.SetActive(false);
				this.backView.SetActive(false);
				this.sideView.SetActive(true);
				Vector3 newScale = sideView.transform.localScale;
				newScale.x = -1;
				sideView.transform.localScale = newScale;
				_animator = sideAnimator;
				
		//		_animator.Play (0);
		//		_lastDirection = 3;
		//	}
			
		}
		if(currentLayer.Length>0)
			changeLayer(currentLayer);
	}
	public void changeLayer(string aChangeTo) {
		currentLayer = aChangeTo;
		SpriteRenderer[] renderer = frontView.GetComponentsInChildren<SpriteRenderer>();
		for(int i = 0;i<renderer.Length;i++) {
			
			renderer[i].sortingLayerName = aChangeTo;
		}
		renderer = sideView.GetComponentsInChildren<SpriteRenderer>();
		for(int i = 0;i<renderer.Length;i++) {
			
			renderer[i].sortingLayerName = aChangeTo;
		}
		renderer = backView.GetComponentsInChildren<SpriteRenderer>();
		for(int i = 0;i<renderer.Length;i++) {
			
			renderer[i].sortingLayerName = aChangeTo;
		}
		
		renderer = this.gameObject.GetComponentsInChildren<SpriteRenderer>();
		for(int i = 0;i<renderer.Length;i++) {
			
			renderer[i].sortingLayerName = aChangeTo;
		}

	}
//	private void onTransitionToMapChange() {
//		Application.LoadLevel("MapChangeSplashScreen");
//	}
	private void updateCamera() {

	}
	// Update is called once per frame
	
	void FixedUpdate() {
		if(RESET_TO_RANCH_POS) {
			if(explorer.map.name.ToLower().Contains("house")||explorer.map.name.ToLower().Contains("guild")) {
			
			} else 
				this.transform.position = explorer.locator.findLocation();
			RESET_TO_RANCH_POS = false;
		}
		if(this._animator!=null) {
			if(Time.time-_lastUpdate>0.1f) {
				if(allowManualAnimations)
					_animator.SetInteger("AnimState",0);
			} else {
				//	this._animator.enabled = true;
			}
		}
		
		if(_forcedWalkTo!=null&&_forcedWalkTo.x!=0&&_forcedWalkTo.y!=0) {
			setJoystickActive(false);
			if(NPCManager.REF!=null)
				NPCManager.REF.resetDumpout();// = new Vector2(0f,0f);
			Vector3 forcedWalkSpeed = _forcedWalkTo-this.transform.position;
			if(forcedWalkSpeed.magnitude>maxWalkSpeeds) {
				float speedDivider = maxWalkSpeeds/forcedWalkSpeed.magnitude;
				forcedWalkSpeed.x = forcedWalkSpeed.x * speedDivider;
				forcedWalkSpeed.y = forcedWalkSpeed.y * speedDivider;
			}
			if(forcedWalkSpeed.magnitude<0.05) {
				
				_forcedWalkTo = new Vector2(0f,0f);
				if(forceConvoWith!=null) {
					ConversationTrigger t = forceConvoWith.GetComponent<ConversationTrigger>();
					if(t!=null)  {
 
						setMyDirection(forceConvoWith.transform.localPosition-this.gameObject.transform.position);
						if(!this.explorer.npcManager.changingScene)
							t.OnUse();
						NPCForceConvo c = forceConvoWith.GetComponent<NPCForceConvo>();
						if(c.dumpOutPosition.magnitude>0&&(!(c.dumpOutPosition.x==25&&c.dumpOutPosition.y==32.93))) {
							GameObject g = GameObject.FindGameObjectWithTag("NPCManager");
							NPCManager m = g.GetComponent<NPCManager>();
							m.setDumpOut(c.dumpOutPosition);
							
						}
					}
					forceConvoWith = null;
				}
				setJoystickActive(true);
			}
			this.walkInDirection(forcedWalkSpeed);
		} 
		
		
		updateCamera();
		if(joystick!=null) {
			if(joystick._JoyOffset.magnitude!=0.0f) {
				this.onJoystickMoved(new Vector3(joystick._JoyOffset.x,joystick._JoyOffset.y));
			}
		}
	}
	void Update () {

	}
}
