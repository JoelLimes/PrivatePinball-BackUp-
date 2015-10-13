using UnityEngine;
using System.Collections;

public class playerTest : MonoBehaviour 
{

	private float moveSpeed = 5f ;
	private float turnspeed = 150f ;


	void Start () 
	{
		
	}
	
	void FixedUpdate() 
	{
		
		if (Input.GetKey (KeyCode.UpArrow))
			transform.Translate (Vector3.forward * moveSpeed * Time.deltaTime);
		
		if (Input.GetKey (KeyCode.DownArrow))
			transform.Translate (-Vector3.forward * moveSpeed * Time.deltaTime);
		
		if (Input.GetKey (KeyCode.LeftArrow))
			transform.Rotate ( Vector3.up, -turnspeed * Time.deltaTime);
		
		if (Input.GetKey (KeyCode.RightArrow))
			transform.Rotate ( Vector3.up, turnspeed * Time.deltaTime);
		
	}

}