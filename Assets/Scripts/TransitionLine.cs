using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionLine : MonoBehaviour {
	#region Variables

	[SerializeField]
	private GameObject Lightning;

	#endregion


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void MakeTransitionAnimation()
	{
		foreach(Transform child in transform)
		{
			GameObject lightning = Instantiate (Lightning, child.transform.position,child.transform.rotation) as GameObject;
			Destroy (lightning.gameObject,lightning.gameObject.GetComponent<Animator>().GetCurrentAnimatorClipInfo (0).Length);

		}
	}

}
