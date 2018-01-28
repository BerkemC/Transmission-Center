using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseControl : MonoBehaviour {

	private Animator animator;
	public bool isPanelOpen;

	// Use this for initialization
	void Start () {

		animator = GetComponent<Animator> ();
		isPanelOpen = false;
	}
	
	// Update is called once per frame
	void Update () {

		/*if(Input.GetKeyDown (KeyCode.Escape))
		{
			if(isPanelOpen)
			{
				ClosePauseMenu ();
			}
			else
			{
				OpenPauseMenu ();
			}
		}*/
		
	}
	public void StopTime()
	{
		Time.timeScale = 0f;
	}

	public void StartTime()
	{
		Time.timeScale = 1f;
	}

	public void OpenPauseMenu()
	{
		animator.SetTrigger ("OpenPause");
		isPanelOpen = true;
	}

	public void ClosePauseMenu()
	{
		StartTime ();
		animator.SetTrigger ("ClosePause");
		isPanelOpen = false;
	}

	public void ManagePauseMenu()
	{
		if(isPanelOpen)
		{
			ClosePauseMenu ();
		}
		else
		{
			OpenPauseMenu ();
		}
	}

}
