using UnityEngine;
using System.Collections;

public class FlowerGarden : MonoBehaviour {
	public float speed= 200.0f;
	
	// Update is called once per frame
	void Update () {
		transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
	}
}
