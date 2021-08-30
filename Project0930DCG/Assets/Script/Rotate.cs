using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {
		transform.Rotate (-10, 0, 0);
	}

	
	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Player") {
			Destroy(gameObject);
		}
	}
}
