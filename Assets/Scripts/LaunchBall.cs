using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LaunchBall : MonoBehaviour 
{

	[SerializeField]
	private string buttonName;
	public float force;
	public GameObject Smoke;

	private List<Rigidbody> ballList = new List<Rigidbody>();

	// Update is called once per frame
	void Update () 
	{
		if (Input.GetButtonDown (buttonName)) 
		{
			foreach (Rigidbody ball in ballList)
			{
				ball.AddForce(Vector3.forward * force, ForceMode.VelocityChange);
				Instantiate(Smoke, transform.position, transform.rotation);
			}
		}
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.GetComponent<Rigidbody>())
		{
			ballList.Add(col.GetComponent<Rigidbody>());
		}
	}
	
	void OnTriggerExit(Collider col)
	{
		if (col.GetComponent<Rigidbody>())
		{
			ballList.Remove(col.GetComponent<Rigidbody>());
		}
	}

}
