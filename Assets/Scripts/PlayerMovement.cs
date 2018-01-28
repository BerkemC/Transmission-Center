using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour {
	#region Variables
	[SerializeField]
	private float movementSpeed;
	[SerializeField]
	private float jumpSpeed;
	[SerializeField]
	private float maxJumpCount;
	[SerializeField]
	private float jumpOffSet;


	private Rigidbody2D rb;
	private Animator animator;
	private bool IsRotationChanged;
	private bool IsMoving;
	private int JumpCount;

	public bool IsTransitionLine;


	private enum playerRotation{Right,Left};
	private playerRotation currentRotation;
	#endregion
	#region Start
	// Use this for initialization
	void Start () {

		rb = GetComponent <Rigidbody2D> ();
		currentRotation = playerRotation.Right;
		IsRotationChanged = false;
		animator = GetComponent<Animator> ();
		IsTransitionLine = false;
	}
	#endregion
	#region Update
	// Update is called once per frame
	void Update () {

		if(GetComponent<PlayerHealth>().GetPlayerHealthForGUI () > 0)
		{
			if(Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.RightArrow))
			{
				IsMoving = false;
			}

			///Left and Right Movement
			if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
			{
				transform.position += Vector3.right * movementSpeed * Time.deltaTime;
				currentRotation = playerRotation.Right;
				IsRotationChanged = true;
				IsMoving = true;
			}


			if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
			{
				transform.position += Vector3.left * movementSpeed * Time.deltaTime;
				currentRotation = playerRotation.Left;
				IsRotationChanged = true;
				IsMoving = true;

			}


			//Jump
			if((Input.GetKeyDown (KeyCode.UpArrow)||Input.GetKeyDown (KeyCode.W)) && maxJumpCount >= JumpCount)
			{
				JumpCount++;
				animator.SetBool ("IsJumping",true);
				IsMoving = false;
				HandleJumpAmount ();
				//Activate Particle
			}

			//Crouch
			if(Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.LeftControl))
			{

			}

			//Transition
			if(Input.GetKeyDown(KeyCode.E))
			{
				IsTransitionLine = true;
			}



			if(IsRotationChanged)
			{
				HandleRotation ();	
			}

			animator.SetBool ("IsMoving",IsMoving);
		}
			
	}
	#endregion
	#region Rotation
	private void HandleRotation()
	{
		if(currentRotation.Equals (playerRotation.Left))
		{
			transform.rotation = new Quaternion (0f, -180f, 0f,0f);
		}
		else if(currentRotation.Equals ((playerRotation.Right)))
		{
			transform.rotation = new Quaternion(0f,0f,0f,0f);
		}

		IsRotationChanged = false;
	}
	#endregion
	#region Collision
	void OnCollisionEnter2D(Collision2D col)
	{
		if(col.gameObject.tag.Equals ("Ground"))
		{
			JumpCount = 0;
			animator.SetBool ("IsJumping",false);

		}
	}
	#endregion
	#region Jump
	private void HandleJumpAmount()
	{
		switch(JumpCount)
		{
		case 1:
			rb.velocity = Vector3.up * jumpSpeed * Time.deltaTime;
			return;
		case 2:
			rb.velocity = Vector3.up * jumpSpeed * jumpOffSet * Time.deltaTime;
			return;
		}
	}
	#endregion
}
