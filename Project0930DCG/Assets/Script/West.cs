using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class West : MonoBehaviour {
	public string Back_Please;
	public string GO_START;
	public GameObject Ascreen;
	private SoundEmpty2 s1;
	public Text bloon2;
	public GameObject blooonm;

	// Use this for initialization
	void Start () {
		Ascreen.SetActive (false);
		s1 = FindObjectOfType<SoundEmpty2> ();
		s1.music = 0;
		bloon2.text = "문화지를 선택하세요.";
	
	}

	public void sumok()
	{ blooonm.SetActive (false);
		Ascreen.SetActive (true);
	}

	public void close()
	{
		blooonm.SetActive (true);
		Ascreen.SetActive (false);
	}
	public void backplease()
	{
		s1.music = 3;
		Application.LoadLevel (Back_Please);

	}

	public void startplease()
	{
		s1.music = s1.music + 1;
		Application.LoadLevel (GO_START);
	}
	public void others()
	{
		bloon2.text = "개발 예정인 컨텐츠입니다.";
	}
}
