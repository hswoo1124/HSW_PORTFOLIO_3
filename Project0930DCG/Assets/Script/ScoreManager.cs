using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {
	public string regame;
	public string gotofirst;

	public Text board;

	// Use this for initialization
	void Start()
	{
		print(PlayerPrefs.GetFloat("scorecount"));		
		board.text = "비행 거리: " + Mathf.Round( PlayerPrefs.GetFloat("scorecount")) + "m";
	}

	public void replease()
	{
		Application.LoadLevel (regame);
	}

	public void gomain()
	{
		Application.LoadLevel (gotofirst);
	}

}
