using UnityEngine;
using System.Collections;

public class TankMove : MonoBehaviour 
{
	public DynamicStick dynamicStick = null;
	Transform thisTrans;
	public float speed = 1f;
	// Use this for initialization
	void Start()
	{
		thisTrans = transform;
	}
	// Update is called once per frame
	void Update () 
	{
		if(dynamicStick != null)
		{
			Vector3 tempDis = new Vector3(dynamicStick._JoyOffset.x * speed,0f,dynamicStick._JoyOffset.y * speed);
			thisTrans.position += tempDis;
			//tempDis.Normalize();
			//thisTrans.up = tempDis;
			if(tempDis.sqrMagnitude > 0.0001)
			{
				Quaternion targetRot = Quaternion.LookRotation(tempDis);
				thisTrans.rotation = Quaternion.Slerp(thisTrans.rotation, targetRot,11 * Time.deltaTime);
			}
		}
		
	}
}
