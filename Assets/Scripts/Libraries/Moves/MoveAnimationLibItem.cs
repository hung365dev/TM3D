using UnityEngine;
using System.Collections;
using GoogleFu;
public class MoveAnimationLibItem {
	
	private int _id;
	private string _name;
	private string _movementType;
	private float _seconds = 0.0f;
	private string _prefab;
	public string category;
	public float yOffset;
	public float xOffset;
	
	public float leftSideRotation = 0f;
	public float rightSideRotation = 0f;
	public MoveAnimationLibItem(MoveAnimationNamesRow aMoveAnimationName) {
		
		this._id = aMoveAnimationName._id;
		this._name = aMoveAnimationName._moveanimations;
		this._movementType = aMoveAnimationName._movementtype;
		this._seconds = aMoveAnimationName._moveonseconds;
		this._prefab = aMoveAnimationName._prefabname;
		this.category = aMoveAnimationName._animtype;
		yOffset = aMoveAnimationName._yoffset;
		xOffset = aMoveAnimationName._xoffset;
		
		leftSideRotation = aMoveAnimationName._yrotationforleftmove;
		rightSideRotation = aMoveAnimationName._yrotationforrightmove;
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
	public GameObject prefab {
		get {
			Object o = Resources.Load("Battles/MoveEffects/"+this._prefab);
			
			if(o==null) {
				Debug.Log(this._prefab+" could not load particle effect");
				return null;
			}
			GameObject prefab = UnityEngine.Object.Instantiate(o) as GameObject;
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
