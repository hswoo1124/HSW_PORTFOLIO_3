using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {
	private AccelerometerMove accel;
	// Use this for initialization
	void Start () {
		accel = FindObjectOfType<AccelerometerMove> ();
	}
	
	// Update is called once per frame
	void Update () {

	}
}
