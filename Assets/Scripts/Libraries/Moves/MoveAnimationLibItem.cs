using UnityEngine;
using System.Collections;
using Google2u;
public class MoveAnimationLibItem {
	
	private int _id;
	private string _name;
	private string _movementType;
	private float _seconds = 0.0f;
	private string _prefab;
	public string category;
	public float yOffset;
	public float xOffset;

	public static BetterList<BetterList<GameObject>> prefabs = new BetterList<BetterList<GameObject>>();
	public float leftSideRotation = 0f;
	public float rightSideRotation = 0f;
	public MoveAnimationLibItem(MoveAnimationNamesRow aMoveAnimationName) {
		
		this._id = aMoveAnimationName._ID;
		this._name = aMoveAnimationName._MoveAnimations;
		this._movementType = aMoveAnimationName._MovementType;
		this._seconds = aMoveAnimationName._MoveOnSeconds;
		this._prefab = aMoveAnimationName._PrefabName;
		this.category = aMoveAnimationName._AnimType;
		yOffset = aMoveAnimationName._YOffset;
		xOffset = aMoveAnimationName._XOffset;
		
		leftSideRotation = aMoveAnimationName._YRotationForLeftMove;
		rightSideRotation = aMoveAnimationName._YRotationForRightMove;
	}
	
	public string name {
		get {
			return _name;
		}
	}
	public string movementType {
		get {
			return _movementType;
		}
	}
	public static void putBackParticles(GameObject aParticles) {
		ParticleSystem p1 = aParticles.GetComponent<ParticleSystem> ();
		p1.Clear ();
		ParticleSystem[] ps = aParticles.GetComponentsInChildren<ParticleSystem> ();
		for (int i = 0; i<ps.Length; i++) {
			ps[i].Clear();
		}
		aParticles.gameObject.SetActive (false);
		for (int i = 0; i<prefabs.size; i++) {
			if(prefabs[i][0].name==aParticles.name) {
				prefabs[i].Add(aParticles);
				return;
			}
		}
		prefabs.Add (new BetterList<GameObject> ());
		prefabs [prefabs.size - 1].Add (aParticles);
	}
	public GameObject prefab {
		get {
			for(int i = 0;i<prefabs.size;i++) {
				if(prefabs[i].size>0) {
					if(prefabs[i][0].name==this._prefab) {
						GameObject r = prefabs[i][0];
						prefabs[i].RemoveAt(0);
						if(prefabs[i].size==0) {
							prefabs.RemoveAt(i);
						}
						r.gameObject.SetActive(true);
						return r;
					}
				}
			}
			Object o = Resources.Load("Battles/MoveEffects/"+this._prefab);
		
			if(o==null) {
				Debug.Log(this._prefab+" could not load particle effect");
				return null;
			}
			GameObject prefab = UnityEngine.Object.Instantiate(o) as GameObject;
			prefab.name = this._prefab;
			ParticleSystem ps = prefab.GetComponent<ParticleSystem>();
			ps.startSize = ps.startSize * 1.5f;
			ParticleSystem[] particleS = prefab.GetComponentsInChildren<ParticleSystem>();
			for(int i = 0;i<particleS.Length;i++) {
				particleS[i].startSize = particleS[i].startSize * 1.5f;
			}
			return prefab;
		}
	}
	public float seconds {
		get {
			return _seconds;
		}
	}
	public int id {
		get {
			return _id;
		}
	}
	
}
