using UnityEngine;
using System.Collections;
using GoogleFu;
using System.Collections.Generic;
using Battles;


public class AnimTest : MonoBehaviour {

	// Use this for initialization
	
	public UIPopupList move1;
	
	public BattleMonster leftMonster;
	public BattleMonster rightMonster;
	
	public UIPopupList move2;
	
	public bool isLeftMove = true;
	public UIPopupList animCategory1;
	public UIPopupList animCategory2;
	void Start () {
		BetterList<MoveAnimationLibItem> items = MovesAnimationLib.REF.items;
		for(int i = 0 ;i<items.size;i++) {
			if(!animCategory1.items.Contains(items[i].category)) {
				animCategory1.items.Add(items[i].category);
				animCategory2.items.Add(items[i].category);
			}
		}
		animCategory1.onChange.Add(new EventDelegate(this,"onAnimCat1Change"));
		animCategory2.onChange.Add(new EventDelegate(this,"onAnimCat2Change"));
		showItemsInCategory("Generic",move1);
		showItemsInCategory("Hits",move2);
		move1.onChange.Add(new EventDelegate(this,"onMoveChange"));
		move2.onChange.Add(new EventDelegate(this,"onMoveChange"));
	}
	public void onMoveChange() {
		//StartTest();
	}
	public void onAnimCat1Change() {
		showItemsInCategory(animCategory1.value,move1);
	}
	public void onAnimCat2Change() {
		showItemsInCategory(animCategory2.value,move2);
	}
	void showItemsInCategory(string aCategory,UIPopupList aList) {
		aList.Clear();
		BetterList<MoveAnimationLibItem> items = MovesAnimationLib.REF.items;
		for(int i = 0 ;i<items.size;i++) {
			if(items[i].category==aCategory) {
				aList.AddItem(items[i].name,items[i]);
			
			}
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
	
	public void StartTest() {
		BattleMonster thisTarget = rightMonster;
		if(thisTarget!=null) {
			MoveAnimationLibItem anim = (MoveAnimationLibItem) move1.data;
			if(anim==null) {
				return;
			}
			GameObject animPrefab = anim.prefab;
			if(animPrefab==null) {
				return;
			}
			Vector3 offsets = new Vector3(anim.xOffset,anim.yOffset);
			animPrefab.tag = "ParticleSystems";
			if((anim.movementType=="Normal")||(anim.movementType=="OnTargetOnly")) {
				if(animPrefab==null||animPrefab.transform==null) {
					Debug.Log ("Error here");
				} else
					animPrefab.transform.position = rightMonster.SpawnPosition+offsets;
			} else if(anim.movementType=="OriginToTarget") {
				animPrefab.transform.position = leftMonster.SpawnPosition+offsets;
				Hashtable h = new Hashtable();
				h.Add("position",rightMonster.SpawnPosition+offsets);
				h.Add ("time",anim.seconds); 
				h.Add ("oncompletetarget",this.gameObject);
				h.Add ("oncomplete","AttackAnimationFinish");
				h.Add ("oncompleteparams",animPrefab);
				h.Add("easetype",iTween.EaseType.easeInQuad);
				iTween.MoveTo(animPrefab,h);
			}
			if(!isLeftMove&&anim.leftSideRotation!=0f) {
				animPrefab.transform.rotation = Quaternion.Euler(0f,anim.rightSideRotation,0f);
				animPrefab.transform.position = rightMonster.SpawnPosition+offsets;
			} if(isLeftMove&&anim.rightSideRotation!=0f) {
				animPrefab.transform.rotation = Quaternion.Euler(0f,anim.leftSideRotation,0f);
				animPrefab.transform.position = leftMonster.SpawnPosition+offsets;
			}
			
			adaptAnimPrefabPositionByOffset(animPrefab,isLeftMove,anim);
			StartCoroutine(waitToNext(anim.seconds));
		}
		putParticlesInfront();
	}
	
	private IEnumerator waitToNext(float aDelay) {
		yield return new WaitForSeconds(aDelay);
		BattleMonster thisTarget = rightMonster;
		if(thisTarget!=null) {
			MoveAnimationLibItem anim = (MoveAnimationLibItem) move2.data;
			bool isLeftMove = false;
			if(anim==null) {
				yield return null;
			} else {
				GameObject animPrefab = anim.prefab;
				if(animPrefab==null) {
					yield return null;
				} else {
					
					Vector3 offsets = new Vector3(anim.xOffset,anim.yOffset);
					animPrefab.tag = "ParticleSystems";
					if((anim.movementType=="Normal")||(anim.movementType=="OnTargetOnly")) {
						if(animPrefab==null||animPrefab.transform==null) {
							Debug.Log ("Error here");
						} else
							animPrefab.transform.position = rightMonster.SpawnPosition+offsets;
					} else if(anim.movementType=="OriginToTarget") {
						animPrefab.transform.position = leftMonster.SpawnPosition+offsets;
						Hashtable h = new Hashtable();
						h.Add("position",rightMonster.SpawnPosition+offsets);
						h.Add ("time",anim.seconds);
						h.Add ("oncompletetarget",this.gameObject);
						h.Add ("oncomplete","AttackAnimationFinish");
						h.Add ("oncompleteparams",animPrefab);
						h.Add("easetype",iTween.EaseType.easeInQuad);
						iTween.MoveTo(animPrefab,h);
					}
					if(!isLeftMove&&anim.leftSideRotation!=0f) {
						animPrefab.transform.rotation = Quaternion.Euler(0f,anim.rightSideRotation,0f);
						animPrefab.transform.position = rightMonster.SpawnPosition+offsets;
					} if(isLeftMove&&anim.rightSideRotation!=0f) {
						animPrefab.transform.rotation = Quaternion.Euler(0f,anim.leftSideRotation,0f);
						animPrefab.transform.position = leftMonster.SpawnPosition+offsets;
					}
					adaptAnimPrefabPositionByOffset(animPrefab,isLeftMove,anim);
				}
			}
		}
		putParticlesInfront();
	}
	public void AttackAnimationFinish(UnityEngine.Object aAnimation) {
		Destroy ((GameObject) aAnimation);
		this.rightMonster.doDefenseAnimation();
	}
	
	protected void adaptAnimPrefabPositionByOffset(GameObject aAnimPrefab,bool aIsLeftMove,MoveAnimationLibItem aLibItem) {
		Vector3 pos = aAnimPrefab.transform.localPosition;
		if(aIsLeftMove) {
			pos.x += aLibItem.xOffset;
		} else {
			pos.x -= aLibItem.xOffset;
		}
		aAnimPrefab.transform.localPosition = pos;
	}
	
	public static void putParticlesInfront() {
		GameObject[] allParticles = GameObject.FindGameObjectsWithTag("ParticleSystems");
		for(int i = 0;i<allParticles.Length;i++) {
			
			allParticles[i].GetComponent<ParticleSystem>().renderer.sortingLayerName = "ParticleLayer";
			ParticleSystem[] children = allParticles[i].GetComponentsInChildren<ParticleSystem>();
			for(int j = 0;j<children.Length;j++) {
				children[j].renderer.sortingLayerName = "ParticleLayer";
			}
		}
	}
	
}
