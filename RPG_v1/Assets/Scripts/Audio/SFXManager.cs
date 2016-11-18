using UnityEngine;
using System.Collections;

public class SFXManager : MonoBehaviour 
{

	public AudioSource playerHurt;
	public AudioSource playerDead;
	public AudioSource playerAttack;
	public AudioSource pickUpCoin;
	public AudioSource slimeHurt;

	private static bool sfxManExists;

	// Use this for initialization
	void Start () 
	{
		if (!sfxManExists) 
		{
			sfxManExists = true;
			DontDestroyOnLoad (transform.gameObject);
		} 
		else 
		{
			Destroy (gameObject);
		}
	}
}