using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour {

	[SerializeField]
	private Text packetCount;
	
	// Update is called once per frame
	void Update () {

		packetCount.text = "Packet Loss: " + ScoreManager.PacketLossCount.ToString ();
	}
}
