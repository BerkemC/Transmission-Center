using UnityEngine;
using System.Collections;

/*This script contains some key values in order to save user preferences
 * to local memory (to store very small amount), so that user can use the same settings
 * always.These settings include master volume and username and password in case if user
 * wants to use remember functionality.
 */

public class PlayerPrefsManager : MonoBehaviour {
	#region Keys
	//Key Declerations
	const string MASTER_VOLUME_KEY = "master_vol";
	const string REMEMBER_KEY = "me_remember";
	#endregion

	#region Setters and Getters for Keys
	/// Sets the master volume by checking interval
	public static void SetMasterVolume(float volume){
		if (0f <= volume && volume <= 1f)
			PlayerPrefs.SetFloat (MASTER_VOLUME_KEY, volume);
	}

	/// Gets the master volume.
	public static float GetMasterVolume(){
		return PlayerPrefs.GetFloat (MASTER_VOLUME_KEY);
	}
	#endregion

}
