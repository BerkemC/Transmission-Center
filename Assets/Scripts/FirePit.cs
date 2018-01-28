using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePit : MonoBehaviour {

	[SerializeField]
	private ParticleSystem ps1;
	[SerializeField]
	private ParticleSystem ps2;
	[SerializeField]
	private ParticleSystem ps3;
	[SerializeField]
	private ParticleSystem ps4;
	[SerializeField]
	private ParticleSystem ps5;

	int counter = 0;
	// Update is called once per frame
	void FixedUpdate () {
		
		ps1.Simulate ((counter * Time.deltaTime)%6,true,true,true);
		ps2.Simulate ((counter * Time.deltaTime)%9,true,true,true);
		ps3.Simulate ((counter * Time.deltaTime)%12,true,true,true);
		ps4.Simulate ((counter * Time.deltaTime)%15,true,true,true);
		ps5.Simulate ((counter * Time.deltaTime)%18,true,true,true);

		counter++;

	}
}
