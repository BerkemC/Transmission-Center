using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {

	#region Variables
	[SerializeField]
	private Vector3 offset;

	private Transform player;

	#endregion

	#region Start
	// Use this for initialization
	void Start () {

		player = GameObject.FindGameObjectWithTag ("Player").transform;

	}
	#endregion
	#region Update
	// Update is called once per frame
	void FixedUpdate () 
	{
		CalculateAndChangePosition ();

		
	}
	#endregion
	#region Methods
	void CalculateAndChangePosition ()
	{
		Vector3 newLocation = player.position + offset * Time.deltaTime;
		transform.position = newLocation;
	}
	#endregion
}
