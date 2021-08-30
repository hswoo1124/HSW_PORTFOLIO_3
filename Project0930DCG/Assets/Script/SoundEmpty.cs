using UnityEngine;
using System.Collections;

public class SoundEmpty : MonoBehaviour {
	public float kill=0;
	void Awake() {
		DontDestroyOnLoad(transform.gameObject);
	}
	void Update()
	{
		if (kill == 3) {
			Destroy(gameObject);
		}
	}
}
