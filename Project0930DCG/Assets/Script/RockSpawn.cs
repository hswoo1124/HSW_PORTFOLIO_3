using UnityEngine;
using System.Collections;

public class RockSpawn : MonoBehaviour {

    // Use this for initialization

    public GameObject PrefabEnemy5;
    public GameObject PrefabEnemy6;
    public GameObject PrefabEnemy7;

    private float nextTime = 0.0f;
    public float spawnRate; //장애물 만든 빈도 ex)몇초마다 장애물 생성

    void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (nextTime < Time.time)
        {


            nextTime = Time.time + spawnRate;

            float E_Number = Random.Range(1, 4);
            if (E_Number == 1)
            {
                float addZPos = 2000.0f;
                float addXpos = Random.Range(-360, 360);
                float addYpos = 520;
                Vector3 spawnPos = transform.position + new Vector3(addXpos, addYpos, addZPos);
                Instantiate(PrefabEnemy5, spawnPos, Quaternion.identity);
            }
            else if (E_Number == 2)
            {
                float addZPos = 2000.0f;
                float addXpos = Random.Range(-360, 360);
                float addYpos = 520;
                Vector3 spawnPos = transform.position + new Vector3(addXpos, addYpos, addZPos);
                Instantiate(PrefabEnemy6, spawnPos, Quaternion.identity);
            }
            else if (E_Number == 3)
            {
                float addZPos = 2000.0f;
                float addXpos = Random.Range(-360, 360);
                float addYpos = Random.Range(500, 550);
                Vector3 spawnPos = transform.position + new Vector3(addXpos, addYpos, addZPos);
                Instantiate(PrefabEnemy7, spawnPos, Quaternion.identity);
            }
           // else if (E_Number == 4)
           // {
             //   float addZPos = 2000.0f;
             //   float addXpos = Random.Range(-360, 360);
             //   float addYpos = Random.Range(500, 550);
             //   Vector3 spawnPos = transform.position + new Vector3(addXpos, addYpos, addZPos);
             //   Instantiate(PrefabEnemy8, spawnPos, Quaternion.identity);
           // }
        }
    }
}
