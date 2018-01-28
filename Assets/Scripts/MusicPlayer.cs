using UnityEngine;
using System.Collections;

//TODO Arrange a detailed background music management
/*This script contains music player controls which is activated in splash
 * sceen and remains until the program is closed. As the program never reaches
 * to splash screen ever again, it does not need Singleton Pattern; it always has only one
 * instance at a time.
 */
[RequireComponent(typeof(AudioSource))]
public class MusicPlayer : MonoBehaviour {
	//Array of background musics
	public AudioClip[] clipList;
	//Static audio source to play sounds
	public static AudioSource musicPlayer;

	void Awake(){
		//Preventing object from being destroyed when the scene is changed
		DontDestroyOnLoad (gameObject);
	}
	// Use this for initialization
	void Start () {
		///Audio source is set with audio clip and volume, then loop is set to true
		musicPlayer = GetComponent<AudioSource>();
		musicPlayer.volume = PlayerPrefsManager.GetMasterVolume ();
		musicPlayer.clip = clipList[0];
		musicPlayer.Play ();
		musicPlayer.loop = true;

	}

	/*void OnLevelWasLoaded(int i)
	{
		if(i == 4)
		{
			musicPlayer.clip = clipList [2];


		else if(i == 5)
		{
			musicPlayer.clip = clipList [2;

		}
			musicPlayer.Play ();
			musicPlayer.loop = true;
		}
	}*/

}
