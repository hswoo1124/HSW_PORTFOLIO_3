using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SoundEmpty2 : MonoBehaviour {
	public float music=0;


	void Start()
	{
		music = 0;
	}
	void Awake() {
		DontDestroyOnLoad(transform.gameObject);
	}
	void Update()
	{
		if (music == 3) {
			Destroy(gameObject);
		}
	}


}
