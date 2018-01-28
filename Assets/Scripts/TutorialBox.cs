using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialBox : MonoBehaviour {

	private Text TutorialText;

	[SerializeField]
	private string messageToShow;

	void Awake()
	{
		TutorialText = GameObject.FindGameObjectWithTag ("Tutorial").GetComponent<Text>();
	}
	

	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.gameObject.tag.Equals ("Player"))
		{
			TutorialText.text = messageToShow;
		}
	}
}
