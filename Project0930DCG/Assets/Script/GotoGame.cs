using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class GotoGame : MonoBehaviour {
	public string GoGameLevel;
	public string alreadygo;
	private SoundEmpty2 hitomi;



	void Start()
	{
		hitomi = FindObjectOfType<SoundEmpty2> ();
	}
	public void gotogame(){
		hitomi.music = hitomi.music + 2;
		Application.LoadLevel (GoGameLevel);
	}
	public void hurrygo(){
		hitomi.music = hitomi.music + 2;
		Application.LoadLevel (alreadygo);
	}
}


