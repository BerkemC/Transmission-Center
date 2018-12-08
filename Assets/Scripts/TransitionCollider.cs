using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionCollider : MonoBehaviour {

	private GameObject InLocation,OutLocation;
	[SerializeField]
	private Animator animator;
	[SerializeField]
	private GameObject player;
	[SerializeField]
	private float transitionTime;

	void Awake()
	{
		player = GameObject.FindGameObjectWithTag ("Player");
	}

	void Start()
	{
		foreach(Transform child in transform.parent.transform)
		{
			if(child.gameObject.tag.Equals ("In"))
			{
				InLocation = child.gameObject;
			}
			else if(child.gameObject.tag.Equals ("Out"))
			{
				OutLocation = child.gameObject;
			}
		}
	}

	void OnTriggerStay2D(Collider2D col )
	{
		if(col.gameObject.tag.Equals ("Player") && col.gameObject.GetComponent<PlayerMovement>().IsTransitionLine)
		{
			
			col.gameObject.SetActive (false);
			transform.parent.gameObject.GetComponent<TransitionLine>().MakeTransitionAnimation ();

			if(gameObject.tag.Equals ("In"))
			{
				
				Invoke ("TransferPlayerToOut",transitionTime);
			}
			else
			{
				Invoke ("TransferPlayerToIn",transitionTime);
			}
		}
	}


	private void TransferPlayerToOut()
	{

		player.transform.position = OutLocation.transform.position;
		player.SetActive (true);
		player.GetComponent<PlayerMovement>().IsTransitionLine = false;

	}

	private void TransferPlayerToIn()
	{

		player.transform.position = InLocation.transform.position;
		player.SetActive (true);
		player.GetComponent<PlayerMovement>().IsTransitionLine = false;


	}
}
