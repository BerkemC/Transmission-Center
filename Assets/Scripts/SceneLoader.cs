using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class SceneLoader : MonoBehaviour {
	[SerializeField]
	private static string Scene;
	[SerializeField]
	private Text LoadMessage;
	[SerializeField]
	private Text HintMessage;
	[SerializeField]
	private string[] messageList;
	public Texture progressBar;
	private bool isLoadScene = false;
	private float progress;

	private bool isGui = false;
	// Use this for initialization
	void Start () {
		StartCoroutine (LoadScene());
		SetHintMessage ();
		LoadMessage.text = "Loading...";
	}

	// Update is called once per frame
	void Update () {
		LoadMessage.color = new Color (Mathf.PingPong (Time.time, 1), Mathf.PingPong (Time.time, 1), Mathf.PingPong (Time.time, 1), Mathf.PingPong (Time.time, 1));



	}
	/// <summary>
	/// Sets the scene.
	/// </summary>
	/// <param name="newScene">New scene.</param>
	public static void SetScene(string newScene){
		Scene = newScene;
	}
	/// <summary>
	/// Sets the hint message randomly.
	/// </summary>
	private void SetHintMessage(){
		HintMessage.text = "Did You Know : ";
		HintMessage.text += messageList [(int)Random.Range (0f, messageList.Length)];
	}

	IEnumerator LoadScene(){

		yield return new WaitForSeconds (3f);
		AsyncOperation async = Application.LoadLevelAsync (Scene);

		while(!async.isDone){
			isGui = true;
			progress = async.progress; 
			yield return null;
		}
	}
}
