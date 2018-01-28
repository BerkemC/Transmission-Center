using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {
	#region Variables
	[SerializeField]
	private int health;
	[SerializeField]
	private int maxHealth;
	[SerializeField]
	private Text HealthText;

	#endregion
	#region Start
	// Use this for initialization
	void Start () {
		
	}
	#endregion


	#region Update
	// Update is called once per frame
	void Update () {
		
	}
	#endregion

	#region Methods

	public void TakeDamage(int damage)
	{

		GetComponent<PlayerSound>().PlayClip (0);
		health -= damage;
		
		if(health <= 0)
		{
			GameObject.FindObjectOfType<DeathPanelControl> ().OpenDeathPanel ();
		}

		HealthText.text = "Health: "+ GetPlayerHealthForGUI ().ToString ();
	}


	public int GetPlayerHealthForGUI()
	{
		return (int)(Mathf.Clamp ((float)health, 0f,(float) maxHealth));
	}

	public void FillHealth()
	{
		health = maxHealth;
		HealthText.text = "Health: "+ GetPlayerHealthForGUI ().ToString ();
	}

	#endregion
}
