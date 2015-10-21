
using UnityEngine;
public class UIFollowTarget : MonoBehaviour
{
	/// <summary>
	/// 3D target that this object will be positioned above.
	/// </summary>
	
	public Transform target;
	
	/// <summary>
	/// Game camera to use.
	/// </summary>
	
	public Camera gameCamera;
	
	/// <summary>
	/// UI camera to use.
	/// </summary>
	
	public Camera uiCamera;
	
	/// <summary>
	/// Whether the children will be disabled when this object is no longer visible.
	/// </summary>
	
	public bool disableIfInvisible = true;
	public float heightOffset = 0;
	public float heightToAddPerFrame = 0;
	Transform mTrans;
	bool mIsVisible = false;
	
	/// <summary>
	/// Cache the transform;
	/// </summary>
	
	void Awake () { mTrans = transform; }
	
	/// <summary>
	/// Find both the UI camera and the game camera so they can be used for the position calculations
	/// </summary>
	
	void Start()
	{
		if (target != null)
		{
			if (gameCamera == null) gameCamera = NGUITools.FindCameraForLayer(target.gameObject.layer);
			if (uiCamera == null) uiCamera = NGUITools.FindCameraForLayer(gameObject.layer);
			SetVisible(false);
		}
		else
		{
		//	Debug.LogError("Expected to have 'target' set to a valid transform", this);
			enabled = false;
		}
	}
	
	/// <summary>
	/// Enable or disable child objects.
	/// </summary>
	
	void SetVisible (bool val)
	{
		mIsVisible = val;
		
		for (int i = 0, imax = mTrans.childCount; i < imax; ++i)
		{
			NGUITools.SetActive(mTrans.GetChild(i).gameObject, val);
		}
	}
	
	public void initTarget(Transform aTarget) {
		target = aTarget;
		if (gameCamera == null) gameCamera = NGUITools.FindCameraForLayer(target.gameObject.layer);
		if (uiCamera == null) uiCamera = NGUITools.FindCameraForLayer(gameObject.layer);
		SetVisible(false);
		
	}
	/// <summary>
	/// Update the position of the HUD object every frame such that is position correctly over top of its real world object.
	/// </summary>
	
	void Update ()
	{	if(gameCamera==null||target==null) {
			return;
		}
		Vector3 pos = gameCamera.WorldToViewportPoint(target.position);
		pos.y = pos.y + 0.3f;
		// Determine the visibility and the target alpha
		bool isVisible = (gameCamera.orthographic || pos.z > 0f) && (!disableIfInvisible || (pos.x > 0f && pos.x < 1f && pos.y > 0f && pos.y < 1f));
		
		// Update the visibility flag
		if (mIsVisible != isVisible && disableIfInvisible) SetVisible(isVisible);
		
		// If visible, update the position
		if (isVisible)
		{
			transform.position = uiCamera.ViewportToWorldPoint(pos);
			pos = mTrans.localPosition;
			pos.x = Mathf.FloorToInt(pos.x);
			if(heightToAddPerFrame!=0) {
				heightOffset+=heightToAddPerFrame;
			}
			pos.y = Mathf.FloorToInt(pos.y)+heightOffset;
			
			pos.z = 0f;
			mTrans.localPosition = pos;
		}
		OnUpdate(isVisible);
	}
	
	/// <summary>
	/// Custom update function.
	/// </summary>
	
	protected virtual void OnUpdate (bool isVisible) { }
}
