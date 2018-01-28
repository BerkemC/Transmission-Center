using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTransition : MonoBehaviour {
	#region Variables
	[SerializeField]
	private string nextLevelName;
	#endregion

	#region Trigger
	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.gameObject.tag.Equals ("Player"))
		{
			new LevelManager ().LoadGivenLevel (nextLevelName);
		}
	}
	#endregion
}
