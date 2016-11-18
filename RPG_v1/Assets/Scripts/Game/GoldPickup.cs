using UnityEngine;
using System.Collections;

public class GoldPickup : MonoBehaviour 
{

	public int value;
	public MoneyManager theMM;
	private SFXManager sfxMan;


	// Use this for initialization
	void Start () 
	{
	
		theMM = FindObjectOfType<MoneyManager> ();
		sfxMan = FindObjectOfType<SFXManager> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.name == "Player") 
		{
			theMM.AddMoney (value);
			sfxMan.pickUpCoin.Play ();
			Destroy (gameObject);
		}
	}
}
