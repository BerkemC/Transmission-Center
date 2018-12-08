using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManualWriter : MonoBehaviour {

	#region Variables
	[SerializeField]
	private List<string> messages;

	[SerializeField]
	private List<Text> texts;

	private int CurrentText = 0;
	private int CurrentIndex = 0;
	#endregion



	#region Update
	// Update is called once per frame
	void FixedUpdate () 
	{
		PrintLetter ();
	}
	#endregion


	#region Methods
	private void PrintLetter()
	{
        if (CurrentText < texts.Count)
        {

            texts[CurrentText].text += messages[CurrentText][CurrentIndex];
            CurrentIndex++;

        }
        else { return; }

        if (CurrentIndex >= messages[CurrentText].Length && CurrentText < texts.Count )
		{
			CurrentText++;
			CurrentIndex = 0;
		}
		
	}
	#endregion
}

