using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
/// <summary>
/// Axis Mouse Player Move.
/// Created By: Juandre Swart 
/// Email: info@3dforge.co.za
/// 
/// This script controls the player movement. Use the Vertical axis to move forward and back.
/// Use the horizontal axis to strafe player left and right. Character rotates to mouse position in scene.
/// The mouse must raycast, set layers to ignore colliders.
/// </summary>

// This script requires a character controller to be attached
[RequireComponent (typeof (CharacterController))]
public class AxisMouseTopDownPlayerMove : MonoBehaviour {

	public float moveSpeed = 6.0f; // Character movement speed.
	public int rotationSpeed = 8; // How quick the character rotate to target location.
	public float gravity = 20.0f; // Gravity for the character.
	public float jumpSpeed = 8.0f; // The Jump speed
	public float rayCastDistance = 500.0f; // The ray casting distance of the mouse posision.
	public LayerMask layerMask = 1<<7; // The layers the raycast should ignore.
	public SphereCollider aheadDropWatcher;

	public const float sidewaysDist = 0.75f;
	public const float vertDistMult = 1.2f;
	private Camera myCamera;
	private Transform myTransform;	
	private CharacterController controller;
	private Animator animator; // The animator for the toon. 
	
	private Vector3 moveDirection = Vector3.zero; // The move direction of the player.
	
	public static bool useThumbPad = true;
	public static float angle;
	public static float THUMB_X;
	public static float THUMB_Y;

	public bool noRotatingCamera = true;
	void Start()
	{		
		layerMask=~layerMask; // Get all the layers to raycast on, this will allow the raycast to ignore chosen layers.		
		myCamera = Camera.main; // Get main camera as the camera will not always be a child GameObject.
		if(myCamera == null)
		{
			Debug.LogError("No main camera, please add camera or set camera to MainCamera in the tag option.");
		}
		myTransform = transform;		
		// Get the player character controller.
		controller = myTransform.GetComponent<CharacterController>();			


	}
	public void OnConversationStart() {
	
	}
	public void OnConversationEnd() {
	
	}
	private void getAnimator() {
		// Get the player animator in child.
		this.animator = GetComponentInChildren<Animator>();
		if(animator==null) {
			animator = this.GetComponent<Animator>();
		}
	}
	public void OnEnable() {
	}
	public void OnDisable() {
	}

	public void OnDrawGizmos() {
	//	Gizmos.DrawSphere(this.transform.position+(this.transform.forward*1.5f),0.5f);

		bool hits = Physics.CheckCapsule(this.transform.position+(this.transform.forward*2f)+Vector3.up*vertDistMult,this.transform.position+(this.transform.forward*2f)+Vector3.down,0.1f);
		bool hitsLeft = Physics.CheckCapsule(this.transform.position+(this.transform.forward*2f)+Vector3.up*vertDistMult+(this.transform.right*-sidewaysDist),this.transform.position+(this.transform.forward*2f)+Vector3.down+(this.transform.right*-sidewaysDist),0.1f);
		bool hitsRight = Physics.CheckCapsule(this.transform.position+(this.transform.forward*2f)+Vector3.up*vertDistMult+(this.transform.right*sidewaysDist),this.transform.position+(this.transform.forward*2f)+Vector3.down+(this.transform.right*sidewaysDist),0.1f);
		
		Color middle = Color.green;
		if(!hits) {
			middle = Color.red;
		}
		Color left = Color.green;
		if(!hitsLeft) {
			left = Color.red;
		}
		Color right = Color.green;
		if(!hitsRight) {
			right = Color.red;
		}
		// Right
		Gizmos.color = right;
		Gizmos.DrawSphere(this.transform.position+(this.transform.forward*2f)+Vector3.down+(this.transform.right*0.75f),0.1f);

		Gizmos.color = middle;
		Gizmos.DrawSphere(this.transform.position+(this.transform.forward*2f)+Vector3.down,0.1f);

		Gizmos.color = left;
		Gizmos.DrawSphere(this.transform.position+(this.transform.forward*2f)+Vector3.down+(this.transform.right*-0.75f),0.1f);


		hits = Physics.CheckCapsule(this.transform.position+(this.transform.forward*2f)+Vector3.up*vertDistMult,this.transform.position+(this.transform.forward*2f)+Vector3.down,0.1f);
		hitsLeft = Physics.CheckCapsule(this.transform.position+(this.transform.forward*2f)+Vector3.up*vertDistMult+(this.transform.right*-sidewaysDist),this.transform.position+(this.transform.forward*2f)+Vector3.down+(this.transform.right*-sidewaysDist),0.1f);
		hitsRight = Physics.CheckCapsule(this.transform.position+(this.transform.forward*2f)+Vector3.up*vertDistMult+(this.transform.right*sidewaysDist),this.transform.position+(this.transform.forward*2f)+Vector3.down+(this.transform.right*sidewaysDist),0.1f);
		
		middle = Color.green;
		if(!hits) {
			middle = Color.red;
		}
		left = Color.green;
		if(!hitsLeft) {
			left = Color.red;
		}
		right = Color.green;
		if(!hitsRight) {
			right = Color.red;
		}
		// Right
		Gizmos.color = right;
		Gizmos.DrawSphere(this.transform.position+(this.transform.forward*2f)+Vector3.up+(this.transform.right*0.75f),0.1f);
		
		Gizmos.color = middle;
		Gizmos.DrawSphere(this.transform.position+(this.transform.forward*2f)+Vector3.up,0.1f);
		
		Gizmos.color = left;
		Gizmos.DrawSphere(this.transform.position+(this.transform.forward*2f)+Vector3.up*1.2f+(this.transform.right*-0.75f),0.1f);

		
	}
	public void Update()
	{			
		if(animator==null) {
			this.getAnimator();
			return;
		}
		float xMovement = Input.GetAxis("Horizontal");// The horizontal movement.
		float zMovement = Input.GetAxis("Vertical");// The vertical movement.	

		if(useThumbPad) {
			xMovement = THUMB_X;
			zMovement = THUMB_Y;
	//		this.transform.localEulerAngles = new Vector3(0f,angle,0f);
//return;
		}


		// Get mouse position and ignore certain layers.
	/*	Ray ray = myCamera.ScreenPointToRay(Input.mousePosition);		
		RaycastHit hit;
		Vector3 rotationToPos = Vector3.zero;
		if (Physics.Raycast(ray,out hit, rayCastDistance, layerMask)) 
		{
			rotationToPos = hit.point;	
			// Keep target height same as player height for accuracy.
			rotationToPos.y = myTransform.position.y;			
		}
	*/	
		// Are whe grounded, yes then move.

		if (IsGrounded()) {
			if(noRotatingCamera&&(xMovement!=0f||zMovement!=0f)) {	
				
				float tempAngle = Mathf.Atan2(xMovement,zMovement);
				this.transform.eulerAngles = new Vector3(0f,tempAngle*Mathf.Rad2Deg,0f);
				this.animateCharacter(Mathf.Abs(xMovement)+Mathf.Abs(zMovement));
				bool hits = Physics.CheckCapsule(this.transform.position+(this.transform.forward*2f)+Vector3.up*vertDistMult,this.transform.position+(this.transform.forward*2f)+Vector3.down,0.1f);
				bool hitsLeft = Physics.CheckCapsule(this.transform.position+(this.transform.forward*2f)+Vector3.up*vertDistMult+(this.transform.right*-sidewaysDist),this.transform.position+(this.transform.forward*2f)+Vector3.down+(this.transform.right*-sidewaysDist),0.1f);
				bool hitsRight = Physics.CheckCapsule(this.transform.position+(this.transform.forward*2f)+Vector3.up*vertDistMult+(this.transform.right*sidewaysDist),this.transform.position+(this.transform.forward*2f)+Vector3.down+(this.transform.right*sidewaysDist),0.1f);
				
				//if(hits&&hitsLeft&&hitsRight) { 
					moveDirection = this.transform.forward*(Mathf.Abs(xMovement)+Mathf.Abs(zMovement))*moveSpeed;
				 //} 
				//	else {
				//	 Debug.Log ("Not Hitting Ahead! "+hitsLeft+hits+hitsRight);
				//	moveDirection = Vector3.zero;
				 //}

				
			} else {
				if(zMovement==0f&&xMovement==0f) {
					moveDirection = Vector3.zero;
					this.animateCharacter(Mathf.Abs(xMovement)+Mathf.Abs(zMovement));
					
				} else {
				// move player forward or back by zmovement
				// Move player the same distance in each direction. Player must move in a circular motion.
					float tempAngle = Mathf.Atan2(zMovement,xMovement);
					xMovement *= Mathf.Abs(Mathf.Cos(tempAngle));
					zMovement *= Mathf.Abs(Mathf.Sin(tempAngle));	
				}	
				
			}		
			// Make the player jump.
	       	if (Input.GetButton("Jump"))
		   	{
	       		moveDirection.y = jumpSpeed;
				// TODO Add jump animation.
		   	}            
       	}
		
		// Apply gravity.
		moveDirection.y -= gravity * Time.deltaTime;        		
		
		// Rotate the player based on mouse position.
		if(xMovement != 0f && !this.noRotatingCamera)
		{		
			myTransform.Rotate(Vector3.up,rotationSpeed*xMovement);
		}
		
		
		controller.Move(moveDirection * Time.deltaTime);			
	}
	
	// Check if the player is grounded.
	bool IsGrounded () {
		return controller.isGrounded;
	}
	
	private float prevStrafe = 0f;
	
	/// <summary>
	/// Animates the character using Animator.
	/// Here you can set your animation variable.
	/// </summary>
	/// <param name='xMovement'>
	/// X axis movement.
	/// </param>
	/// <param name='zMovement'>
	/// Z axis movement.
	/// </param>
	private void animateCharacter(float aSpeed)
	{
		animator.SetFloat("Forward", aSpeed, 0.1f, Time.deltaTime);
		animator.SetFloat("Turn", 0f, 0.1f, Time.deltaTime);
		//	m_Animator.SetBool("Crouch", m_Crouching);
		animator.SetBool("OnGround", this.controller.isGrounded);
		if (!this.controller.isGrounded)
		{
			animator.SetFloat("Jump", controller.velocity.y);
		}
		
		// Removed, using 2D Simple Directional Blend type.
		// Using SoldierMulti Animator controller now.
		/*if(zMovement > 0 && xMovement !=0)
		{
			prevStrafe = (xMovement<0  ? -0.25f : 0.5f);
			animator.SetFloat("strafe", prevStrafe);			
		}
		else
		{
			
			if(zMovement == 0 && xMovement ==0)
			{
				prevStrafe = 0;
			}
			
			
			if(prevStrafe == 0 || prevStrafe == 1 || prevStrafe == -1  )
			{
				prevStrafe = 0;
				animator.SetFloat("strafe", xMovement);				
			}
			else
			{
				if(xMovement == 0)
				{
					if(prevStrafe<0)
					{
						prevStrafe += 0.05f;
						prevStrafe = prevStrafe > 0 ? 0 : prevStrafe;
					}
					else if(prevStrafe >0)
					{
						prevStrafe -= 0.05f;
						prevStrafe = prevStrafe < 0 ? 0 : prevStrafe;
					}
					
				}
				else
				{
					if(prevStrafe<0)
					{
						prevStrafe -= 0.05f;
						prevStrafe = prevStrafe<-1 ? -1 : prevStrafe;
					}
					else if(prevStrafe >0)
					{
						prevStrafe += 0.05f;
						prevStrafe = prevStrafe>1 ? 1 : prevStrafe;
					}
				}

				animator.SetFloat("strafe", prevStrafe);
				
			}
		}*/
	}
 
	private void animateCharacter(float xMovement, float zMovement)
	{
	
		animator.SetFloat("Forward", zMovement, 0.1f, Time.deltaTime);
		animator.SetFloat("Turn", xMovement, 0.1f, Time.deltaTime);
	//	m_Animator.SetBool("Crouch", m_Crouching);
		animator.SetBool("OnGround", this.controller.isGrounded);
		if (!this.controller.isGrounded)
		{
			animator.SetFloat("Jump", controller.velocity.y);
		}

		// Removed, using 2D Simple Directional Blend type.
		// Using SoldierMulti Animator controller now.
		/*if(zMovement > 0 && xMovement !=0)
		{
			prevStrafe = (xMovement<0  ? -0.25f : 0.5f);
			animator.SetFloat("strafe", prevStrafe);			
		}
		else
		{
			
			if(zMovement == 0 && xMovement ==0)
			{
				prevStrafe = 0;
			}
			
			
			if(prevStrafe == 0 || prevStrafe == 1 || prevStrafe == -1  )
			{
				prevStrafe = 0;
				animator.SetFloat("strafe", xMovement);				
			}
			else
			{
				if(xMovement == 0)
				{
					if(prevStrafe<0)
					{
						prevStrafe += 0.05f;
						prevStrafe = prevStrafe > 0 ? 0 : prevStrafe;
					}
					else if(prevStrafe >0)
					{
						prevStrafe -= 0.05f;
						prevStrafe = prevStrafe < 0 ? 0 : prevStrafe;
					}
					
				}
				else
				{
					if(prevStrafe<0)
					{
						prevStrafe -= 0.05f;
						prevStrafe = prevStrafe<-1 ? -1 : prevStrafe;
					}
					else if(prevStrafe >0)
					{
						prevStrafe += 0.05f;
						prevStrafe = prevStrafe>1 ? 1 : prevStrafe;
					}
				}

				animator.SetFloat("strafe", prevStrafe);
				
			}
		}*/
	}
	
}
