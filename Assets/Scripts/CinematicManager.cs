using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CinematicManager : MonoBehaviour {

	private Animator animator;


	// Use this for initialization
	void Start () {
		
		animator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown (KeyCode.Space))
		{
			animator.CrossFade (animator.GetCurrentAnimatorStateInfo (0).ToString(), 5f);
		}
	}
}
