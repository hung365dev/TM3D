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

public class Doorway
{
	private Map _targetMap;
	private int _id;
	private byte _trigger;
	private Vector2 _target;
	private string _futureNPCChat;
	public Doorway (string aTargetMap,Vector2 aTargetPosition)
	{
		_target = aTargetPosition;
		_targetMap = MapLibrary.getMap(aTargetMap);
	}
	public Doorway (string aTargetMap)
	{
		_targetMap = MapLibrary.getMap(aTargetMap);
		if(_targetMap==null) {
			
			_targetMap = MapLibrary.getMap("JinjaHQ");
		}
		if(_targetMap.reparentMap!=null) {
			_targetMap = _targetMap.reparentMap;
		}
		if(_targetMap==null) 
			Debug.LogError("No Map by name of: "+aTargetMap);
		_target = _targetMap.defaultStart;
	}
	
	public string futureNPCChat {
		get {
			return _futureNPCChat;
		}
		set {
			_futureNPCChat = value;
		}
	}
	public Vector2 targetXY {
		get {
			return new Vector2(this._target.x,this._target.y);
		}
		set {
			this._target = value;
		}
	}
	public Map targetMap {
		get {
			return _targetMap;
		}
	}
	
	public byte trigger {
		get {
			return _trigger;
			
		}
	}
}
