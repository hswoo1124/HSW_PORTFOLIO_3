using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChoiceArea : MonoBehaviour {
	public string Goto_West;
	public string Goto_Back;
	private SoundEmpty killnumber2;
	public Text bloon;


	void Start()
	{
		bloon.text = "장소를 선택하세요";
		killnumber2 = FindObjectOfType<SoundEmpty> ();
	}
	public void westmenu()
	{
		killnumber2.kill = killnumber2.kill + 2;
		Application.LoadLevel (Goto_West);
	}

	public void backmenu()
	{
		killnumber2.kill = killnumber2.kill + 2;
		Application.LoadLevel (Goto_Back);
	}
	
	public void eastarea()
	{
		bloon.text = "개발 예정 컨텐츠입니다.";
	}
	
}
