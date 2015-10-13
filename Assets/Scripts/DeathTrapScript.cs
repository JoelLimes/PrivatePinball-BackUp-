using UnityEngine;
using System.Collections;

public class DeathTrapScript : MonoBehaviour 
{
	[SerializeField]private Transform target;
	[SerializeField]private GameObject[] deathTraps;
	private float speed = 10f;
	private bool kill;
	public bool Kill {
		get {
			return kill;
		}
		set {
			kill = value;
		}
	}

	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		if (kill) {
			float step = speed * Time.deltaTime;
			deathTraps [0].transform.position = Vector3.MoveTowards (deathTraps [0].transform.position, new Vector3 (target.position.x + 1.5f, target.position.y, target.position.z), step);
			deathTraps [1].transform.position = Vector3.MoveTowards (deathTraps [1].transform.position, new Vector3 (target.position.x - 1.5f, target.position.y, target.position.z), step);
		}
	}
}