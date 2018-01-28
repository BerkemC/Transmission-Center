using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpikeControl : MonoBehaviour {
	#region Variables
	[SerializeField]
	private int damage;
	#endregion
	#region Start
	// Use this for initialization
	void Start () {
		
	}
	#endregion
	#region Update
	// Update is called once per frame
	void Update () {
		
	}
	#endregion
	#region Trigger
	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.gameObject.tag.Equals ("Player"))
		{
			col.gameObject.GetComponent<PlayerHealth>().TakeDamage (damage);
		}
	}
	#endregion
	#region Methods
	#endregion
}
