using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {

	public static int PacketLossCount = 0;

	public static void IncrementPacketLossCount()
	{
		PacketLossCount++;
	}
}
