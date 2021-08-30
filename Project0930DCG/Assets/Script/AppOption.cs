using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AppOption : MonoBehaviour {
	public GameObject Option_Screen;
	public string Start_Level;
	private SoundEmpty killnumber;
	public GameObject kumdol;
	// Use this for initialization
	void Start () {
		Option_Screen.SetActive (false);
		killnumber = FindObjectOfType<SoundEmpty> ();
	
	}
	
	public void clickoption()
	{
		kumdol.SetActive (false);
		Option_Screen.SetActive (true);
	}
	public void exitoption()
	{
		kumdol.SetActive (true);
		Option_Screen.SetActive (false);
	}

	public void slider(float newValue)
	{
		
		AudioListener.volume = newValue;
	}


	public void searchstart()
	{
		killnumber.kill = killnumber.kill + 1;
		Application.LoadLevel (Start_Level);
	}

	public void exitclick()
	{
		Application.Quit ();
	}
}
