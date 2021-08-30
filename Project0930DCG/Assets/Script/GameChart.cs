using UnityEngine;
using System.Collections;

public class GameChart : MonoBehaviour {
	public float speed= 3.0f;
	public string win;
	/*public GameObject flower;*/
	// Use this for initialization
	void Start () {
		/*flower.SetActive (false);*/
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "goal") {
			Application.LoadLevel(win);
		}
		/*if (col.gameObject.tag == "before") {
			flower.SetActive(true);
		}*/
	}
}
