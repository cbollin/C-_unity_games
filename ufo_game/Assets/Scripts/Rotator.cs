using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {


	
	void Update () 
	{
		//applies the Rotate function to the game object and spins it on the z axis
		//mutiplyng by Time.deltaTime will make the spin animation look smoother
		transform.Rotate (new Vector3 (0, 0, 45) * Time.deltaTime);
	
	}
}
