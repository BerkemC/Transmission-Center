using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(BoxCollider2D))]
public class DelayControl : MonoBehaviour {

	#region Variables
	[SerializeField]
	private float slowMotionTime;

	[SerializeField]
	private float slowMotionPercentage;

	#endregion

	void OnTriggerEnter2D(Collider2D col)
	{

		if(col.gameObject.tag.Equals ("Player"))
		{
			Time.timeScale = Time.timeScale * slowMotionPercentage;
			gameObject.SetActive (false);
			Invoke ("TurnBackNormalTime",slowMotionTime); 
		}


	}
		

	private void TurnBackNormalTime()
	{
		Time.timeScale = 1f;
		Destroy (gameObject);
	}

}
