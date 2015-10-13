using UnityEngine;
using System.Collections;

public class BLA : MonoBehaviour 
{
	[SerializeField]
	private float _movementSpeed;

	private Rigidbody _rigidbody;
	private Vector3 _newPosition;

	// Use this for initialization
	void Awake () 
	{
		_rigidbody = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		float x = Input.GetAxis ("Horizontal");
		_newPosition = new Vector3 (x, 0f, 0f);
	}

	void FixedUpdate()
	{
		_rigidbody.AddForce (_newPosition * _movementSpeed);
	}
}
