using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ButterFly : MonoBehaviour {
	public float speed= 5.0f;

	public float a = 0;//장애물 이동속도
	public float b;
	
	
	
	void Start () {	
		b = a * 5;

		/*
		
		if (a >= 5) {
			a = 5;
		}
		if (a <= -5) {
			a = -4;
		} */
		
	}
	/*public void miner()
	{
		a = a - 1;
		
	}
	
	public void plus()
	{
		a = a + 1;
		
	}*/

	public void slider(float newValue)
	{
		
		a = newValue;
	}
	
	// Update is called once per frame
	void Update () {

		transform.Translate(new Vector3(Random.Range(-300, 300)* (speed+b) * Time.deltaTime, Random.Range(-100, 100)* (speed+b) * Time.deltaTime, -100.0f * (speed+b) * Time.deltaTime));

		
		
		if(transform.position.z < 200)
		{
			Destroy(gameObject);
		}
	}
	
	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Player") {
			Destroy(gameObject);
	
	}

}
}
