using UnityEngine;
using System.Collections;
using UnityEngine.UI;



public class Enemy_Movement : MonoBehaviour {

    // Use this for initialization

	public float speed= 5.0f;
	public float a = 0;//장애물 이동속도
	public float b;

    


	
	void Start () {	
		b = a * 5;
        

        /*	if (a >= 5) {
                a = 5;
            }
            if (a <= -5) {
                a = -4;
            } */

    }

	public void slider(float newValue)
	{
		
		a = newValue;
	}
	/*public void miner()
	{
		a = a - 1;
	
	}
	
	public void plus()
	{
		a = a + 1;
	
	}*/
	
	// Update is called once per frame
	void Update () {

        transform.Translate(new Vector3(0, 0, -100.0f * (speed+b) * Time.deltaTime));



        if (transform.position.z < 200)
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
