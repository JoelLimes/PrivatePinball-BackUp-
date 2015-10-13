using UnityEngine;
using System.Collections;

public class OntriggerScript : MonoBehaviour {

	void OnTriggerEnter(Collider coll) {
		if (coll.transform.tag == "Player") {
			DeathTrapScript dts = GameObject.FindObjectOfType<DeathTrapScript>();
			dts.Kill = true;
		}
	}
}
