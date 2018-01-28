using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/*This script contains Options Menu controller, connected to player preferences class
 * in order to set last modified settings or enable user to set new settings with a choice of
 * default settings too.
 */

public class OptionsController : MonoBehaviour {
	//Volume bar
	#region Variables
	[SerializeField]
	private Slider MasterVol;
	//Music player reference in order to change volume settings at that instant
	private MusicPlayer music;
	#endregion



	#region Start Calculations
	// Use this for initialization
	void Start () {
		///Setting the last modified value of master vol and object references
		music = GameObject.FindObjectOfType<MusicPlayer> ();
		MasterVol.value = PlayerPrefsManager.GetMasterVolume ();

	}
	#endregion
	#region Update Time Calculations
	// Update is called once per frame
	void Update () {
		//Setting master volume every frame to change it at new instance
		if(MasterVol)music.GetComponent<AudioSource> ().volume = MasterVol.value;
	}
	#endregion
	#region Volume Methods
	//Default settings function
	public void SetDefaultSettings(){
		MasterVol.value = 0.7f;
	}
	//Saves the entered values to options menu and returns to menu
	public void SaveAndExit(){
		PlayerPrefsManager.SetMasterVolume (MasterVol.value);
		LevelManager.LoadGivenLevelImmediateS ("Menu");
	}
	#endregion

}
