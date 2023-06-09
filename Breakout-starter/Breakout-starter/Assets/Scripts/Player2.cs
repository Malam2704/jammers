using UnityEngine;
using System.Collections;

public class Player2 : MonoBehaviour
{
	// The speed at which the player's paddle can move.
	public int speed = 15;
	
	// Use this for initialization
	void Update () 
	{
		// If the left button is pressed, move left.
		if(Input.GetKey(KeyCode.A))
		{
			transform.Translate(speed * Vector3.left * Time.deltaTime);
		}
		
		// If the right button is pressed, move right.
		
		if(Input.GetKey(KeyCode.D))
		{
			transform.Translate(speed * Vector3.right * Time.deltaTime);
		}

		
		// If the player is past the right boundary, place it at the right boundary.
		if (transform.position.x > 9.75) transform.position = new Vector3(9.75f, transform.position.y, transform.position.z);
		
		
		// If the ball is past the left boundary, place it at the left boundary.
		if (transform.position.x < -9.75) transform.position = new Vector3(-9.75f, transform.position.y, transform.position.z);
	}
}