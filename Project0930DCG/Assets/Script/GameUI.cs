using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameUI : MonoBehaviour {
	public GameObject Explane;
	public GameObject Option;
	public GameObject option2;
	public string First_Screen;
	public string Re_Play;
	public string Back_Screen;
	public AudioSource gamebgm;
	public Text score;
	public float scorecount;
	public float point;
	public bool scorebol;
	private health stopcount;
	private AccelerometerMove accel;




	// Use this for initialization
	void Start () {
		accel = FindObjectOfType<AccelerometerMove> ();
		stopcount = FindObjectOfType<health> ();
		accel.speed = 0.0f;
		Time.timeScale = 0.0f;
		Option.SetActive (false);
		option2.SetActive (false);

	
	}
	public void startclick()
	{
		accel.speed = 12.0f;
		Time.timeScale = 1.0f;
		Explane.SetActive (false);
	}



	public void optionclick()
	{
		accel.speed = 0.0f;
		Time.timeScale = 0.0f;
		Option.SetActive (true);
	}
	public void closeclick()
	{
		Option.SetActive (false);
		Time.timeScale = 1.0f;
		accel.speed = 12.0f;
	}

	public void gofirst()
	{
		Application.LoadLevel (First_Screen);
	}
	public void godetail()
	{
		accel.speed = 0.0f;
		Option.SetActive (false);
		option2.SetActive (true);
	}
	public void gore()
	{
		Application.LoadLevel (Re_Play);
	}
	 public void close2()
	{
		option2.SetActive (false);
		Time.timeScale = 1.0f;
		accel.speed = 12.0f;
	}

	public void slider(float newValue)
	{
		
		AudioListener.volume = newValue;
	}

	void Update()
	{
		if (scorebol) {
			scorecount += point * Time.deltaTime*10;
		}
		score.text = "비행 거리: " + Mathf.Round (scorecount) + "m";

		PlayerPrefs.SetFloat ("scorecount", scorecount);
	}


}
