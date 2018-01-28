using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class PlayerSound : MonoBehaviour {
	#region Variables
	[SerializeField]
	private List<AudioClip> sounds;


	private AudioSource soundPlayer;

	#endregion
	#region Start
	// Use this for initialization
	void Start () {

		soundPlayer = GetComponent<AudioSource> ();
		soundPlayer.loop = false;

	}
	#endregion
	#region Methods
	public void PlayClip(int index)
	{
		soundPlayer.clip = sounds [index];
		soundPlayer.Play ();
	}
	#endregion
}
