using UnityEngine;
using System.Collections;

public class WinMenu : MonoBehaviour {

	public string first;

	public void gof()
	{
		Application.LoadLevel (first);
	}
}
