using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	public float speed;

	private Rigidbody2D rb2d;

	public Text countText;
	public Text winText;

	private int count;

	void Start()
	{
		rb2d = GetComponent<Rigidbody2D> ();
		count = 0;
		winText.text = "";
		SetCountText ();
	}
		
	void FixedUpdate()
	{
		//this function gets the player's input from the keyboard to record the player's current x and y coordinates
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		//Vector2 is made up of the current x value and a y value
		Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
		//applies movement to our player object
		rb2d.AddForce (movement * speed);

	}

	//this method will deactivate the pickup once the player collides with it and picks it up
	void OnTriggerEnter2D(Collider2D other) 
	{
		if (other.gameObject.CompareTag ("PickUp")) 
		{
			other.gameObject.SetActive (false);
			count += 1;
			SetCountText ();

		}
	}

	void SetCountText()
	{
		countText.text = "Count: " + count.ToString ();
		if (count >= 12) 
		{
			winText.text = "You Win!";
		}
	}
}
