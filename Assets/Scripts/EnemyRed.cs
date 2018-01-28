using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRed : MonoBehaviour {
	#region Variables
	[SerializeField]
	[Range(0f,1f)]
	private float frequency;

	[SerializeField]
	private GameObject projectile;

	private bool IsPlayerInRange;
	#endregion

	#region Start
	// Use this for initialization
	void Start () {
		IsPlayerInRange = false;
	}
	#endregion

	#region Update
	// Update is called once per frame
	void Update () 
	{
		ManageProjectile ();
		
	}
	#endregion
	#region Methods
	private void ManageProjectile()
	{
		if(IsPlayerInRange)
		{
			if(Random.value <  frequency * Time.deltaTime)
			{
				GameObject newProjectile = Instantiate (projectile, transform.position, Quaternion.identity) as GameObject;
				Destroy (newProjectile,30f);
			}
		}
	}
	#endregion
	#region Trigger
	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.gameObject.tag.Equals ("Player"))
		{
			IsPlayerInRange = true;

		}
	}
	void OnTriggerExit2D(Collider2D col)
	{
		if(col.gameObject.tag.Equals ("Player"))
		{
			IsPlayerInRange = false;
		}
	}

	#endregion
}
