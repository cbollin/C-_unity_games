using UnityEngine;
using System.Collections;

public class CameraContoller : MonoBehaviour {

	public GameObject player;

	private Vector3 offset;

	// Use this for initialization
	void Start () 
	{
		//offset is finding the difference between the camera's position and the player's position
		offset = transform.position - player.transform.position;



	
	}
	
	// Update is called once per frame
	void LateUpdate () 
	{
		//each frame, the camera is moved into a new position aligned with the position of the player object 
		//the camera will follow the player but will not rotate whenever the player rotates
		transform.position = player.transform.position + offset;
	
	}
}
