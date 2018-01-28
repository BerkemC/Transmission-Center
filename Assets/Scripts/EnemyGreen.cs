using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGreen : MonoBehaviour {
	#region Variables

	[SerializeField]
	private float totalHorizantalDistance;

	[SerializeField]
	private float speed;

	[SerializeField]
	private int damage;


	private enum Movement{Right,Left};
	private Movement CurrentMovement;
	private Vector3 InitialLocation;



	#endregion


	#region Start
	// Use this for initialization
	void Start () 
	{
		CurrentMovement = Movement.Right;
		InitialLocation = transform.position;
	}
	#endregion
	#region Update
	// Update is called once per frame
	void Update () 
	{
		UpdatePosition ();
		CheckRotationAndLimits ();
	}
	#endregion

	#region Methods

	private void UpdatePosition()
	{
		if(CurrentMovement.Equals (Movement.Right))
		{
			transform.position += Vector3.right * speed * Time.deltaTime;
			return;
				
		}

		transform.position += Vector3.left * speed * Time.deltaTime;

	}

	private void CheckRotationAndLimits()
	{
		if(CurrentMovement.Equals (Movement.Right))
		{
			if(transform.position.x > (InitialLocation.x + (totalHorizantalDistance/2f)))
			{
				CurrentMovement = Movement.Left;
				transform.rotation = new Quaternion (0f, 0f, 0f, 0f);
				return;
			}
				
			return;
		}

		if(transform.position.x < (InitialLocation.x - (totalHorizantalDistance/2f)))
		{
			CurrentMovement = Movement.Right;
			transform.rotation = new Quaternion (0f, -180f, 0f, 0f);
			return;
		}

	}


	#endregion
	#region Collision
	void OnCollisionEnter2D(Collision2D col)
	{
		if(col.gameObject.tag.Equals ("Player"))
		{
			col.gameObject.GetComponent<PlayerHealth>().TakeDamage (damage);
		}
	}
	#endregion
}
