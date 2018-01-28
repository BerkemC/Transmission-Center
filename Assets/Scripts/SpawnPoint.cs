using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour {
	private GameObject player;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");	
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void RespawnPlayer()
	{
		Time.timeScale = 1f;
		ScoreManager.IncrementPacketLossCount ();
		GameObject.FindObjectOfType<DeathPanelControl> ().CloseDeathPanel ();
		player.transform.position = transform.position;
		player.GetComponent<PlayerHealth>().FillHealth ();

		PauseControl pc = GameObject.FindObjectOfType<PauseControl> ();
		if(pc.isPanelOpen)
		{
			pc.ClosePauseMenu ();
		}
	}
}
