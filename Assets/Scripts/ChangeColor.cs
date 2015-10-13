using UnityEngine;
using System.Collections;
using System.Collections.Generic;



[RequireComponent(typeof(Renderer))]
public class ChangeColor : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{

	}

	void OnCollisionEnter(Collision coll)
	{
		if(coll.gameObject.tag == "Ball")
		{
			Debug.Log ("ball has hit bumper");
		}

				Renderer r = GetComponent<Renderer> ();
				Color c = new Color (Random.Range (0, 256) / 255f, Random.Range (0, 256) / 255f, Random.Range (0, 256) / 255f);
				r.material.color = c;
				Debug.Log ("Color has changed as well");
	}
}
