using UnityEngine;
using System.Collections;

public class BeeWing : MonoBehaviour {


	// Update is called once per frame
	void Update () {
		transform.Rotate (0, 0, Random.Range(-270, 270));
	
	}
}
