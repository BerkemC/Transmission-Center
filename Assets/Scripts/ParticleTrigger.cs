using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleTrigger : MonoBehaviour {

	private ParticleSystem ps;
	[SerializeField]
	private int damage;


	// Use this for initialization
	void Start () {

		ps = transform.parent.gameObject.GetComponent<ParticleSystem> ();

	}
	
	void OnTriggerStay2D(Collider2D col)
	{
		 
		if(col.gameObject.tag.Equals ("Player") && ps.particleCount > 0)
		{
			col.gameObject.GetComponent<PlayerHealth>().TakeDamage (damage);
		}
	}
}
