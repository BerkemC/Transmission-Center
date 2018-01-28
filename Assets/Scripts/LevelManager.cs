using UnityEngine;
using System.Collections;

/*This script contains level control system that enables user to move between scenes.
 */

public class LevelManager : MonoBehaviour {

	/// <summary>
	/// Loads the next level.
	/// </summary>
	public void LoadNextLevel(){
		Application.LoadLevel (Application.loadedLevel + 1);
	}
	/// <summary>
	/// Loads the given level.
	/// </summary>
	/// <param name="name">Name.</param>
	public void LoadGivenLevel(string levelName){
		Application.LoadLevel ("Loading");
		SceneLoader.SetScene (levelName);
	}
	/// <summary>
	/// Exits the game.
	/// </summary>
	public void ExitGame(){
		Application.Quit ();
	}

	/// <summary>
	/// Loads the next level.
	/// </summary>
	public static void LoadNextLevelS(){
		Application.LoadLevel (Application.loadedLevel + 1);
	}
	/// <summary>
	/// Loads the given level.
	/// </summary>
	/// <param name="name">Name.</param>
	public static void LoadGivenLevelS(string levelName){
		Application.LoadLevel ("Loading");
		SceneLoader.SetScene (levelName);
	}
	/// <summary>
	/// Exits the game.
	/// </summary>
	public static void ExitGameS(){
		Application.Quit ();
	}

	/// <summary>
	/// Loads the given level immediate.
	/// </summary>
	/// <param name="level">Level.</param>
	public static void LoadGivenLevelImmediateS(string level){
		Application.LoadLevel (level);
	}

	/// <summary>
	/// Loads the given level immediate.
	/// </summary>
	/// <param name="level">Level.</param>
	public  void LoadGivenLevelImmediate(string level){
		Application.LoadLevel (level);
	}
}

