using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathPanelControl : MonoBehaviour {

	private Animator animator;
	private bool isPanelOpen;
	[SerializeField]
	private GameObject text;


	// Use this for initialization
	void Start () {

		animator = GetComponent<Animator> ();
		isPanelOpen = false;
	}




	public void OpenDeathPanel()
	{

		if(text)
		{
			text.SetActive (false);
		}


        if (!isPanelOpen) { animator.SetTrigger("OpenPanel"); isPanelOpen = true; }
		
	}

	public void CloseDeathPanel()
	{


		if(text)
		{
			text.SetActive (true);
		}

        if (isPanelOpen) { animator.SetTrigger("ClosePanel"); isPanelOpen = false; }
		
	}


}
