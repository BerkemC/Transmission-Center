using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedProjectile : MonoBehaviour {

	#region Variables

	[SerializeField]
	private float speed;

	private Vector3 target;

	[SerializeField]
	private float errorRangeForX;

	[SerializeField]
	private float errorRangeForY;

	[SerializeField]
	private int damage;

	#endregion


	#region Awake
	// Use this for initialization
	void Awake () 
	{
		CalculateTarget ();
			
	}
	#endregion

	#region Update
	// Update is called once per frame
	void Update () 
	{
		MoveTowardsPlayer ();
		//transform.position = Vector3.Lerp (target,transform.position,Time.deltaTime);
	}
	#endregion

	#region Trigger
	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.gameObject.tag.Equals ("Player"))
		{
			col.gameObject.GetComponent<PlayerHealth>().TakeDamage (damage);
			Destroy (gameObject);
		}
	}
	#endregion


	#region Methods

	void CalculateTarget()
	{
		Transform player = GameObject.FindGameObjectWithTag ("Player").transform;

		float x = Random.Range ((player.position.x - (errorRangeForX / 2f)), (player.position.x + (errorRangeForX / 2f)));
		float y = Random.Range ((player.position.y - (errorRangeForY / 2f)), (player.position.y + (errorRangeForY / 2f)));

		target = new Vector3 (x-transform.position.x, y-transform.position.y, 0f);

	}

	void MoveTowardsPlayer()
	{
		transform.Translate (target*Time.deltaTime*speed,Space.Self);

	}

	#endregion
}
