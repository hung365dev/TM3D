using UnityEngine;
using System.Collections;

public class PositionFollow : MonoBehaviour 
{
	public Transform targetTras;
	Transform thisTrans;
	float yValue;
	// Use this for initialization
	void Start () 
	{
		thisTrans = transform;
		yValue = thisTrans.position.y;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(targetTras != null)
		{
			thisTrans.position = new Vector3(targetTras.position.x,yValue,targetTras.position.z);
		}
	}
}
