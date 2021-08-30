using UnityEngine;
using System.Collections;

public class Enemy_Spawn : MonoBehaviour
{

    // Use this for initialization

    public GameObject PrefabEnemy1;
    public GameObject PrefabEnemy2;
    public GameObject PrefabEnemy3;
    public GameObject PrefabEnemy4;
    


    private float nextTime = 0.0f;
    public float spawnRate; //장애물 만든 빈도 ex)몇초마다 장애물 생성

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (nextTime < Time.time)
        {

            
            nextTime = Time.time + spawnRate;

            float E_Number = Random.Range(1, 5);

            if (E_Number == 1)
            {
                float addZPos = 2000.0f;
                float addXpos = Random.Range(-360, 360);
                float addYpos = Random.Range(680, 800);
                Vector3 spawnPos = transform.position + new Vector3(addXpos, addYpos, addZPos);
                Instantiate(PrefabEnemy1, spawnPos, Quaternion.identity);
            }
            else if (E_Number == 2)
            {
                float addZPos = 2000.0f;
                float addXpos = Random.Range(-360, 360);
                float addYpos = Random.Range(680, 800);
                Vector3 spawnPos = transform.position + new Vector3(addXpos, addYpos, addZPos);
                Instantiate(PrefabEnemy2, spawnPos, Quaternion.identity);
            }
            else if (E_Number == 3)
            {
                float addZPos = 2000.0f;
                float addXpos = Random.Range(-360, 360);
                float addYpos = Random.Range(680, 800);
                Vector3 spawnPos = transform.position + new Vector3(addXpos, addYpos, addZPos);
                Instantiate(PrefabEnemy3, spawnPos, Quaternion.identity);
            }
            else if (E_Number == 4)
            {
                float addZPos = 2000.0f;
                float addXpos = Random.Range(-360, 360);
                float addYpos = 520;
                Vector3 spawnPos = transform.position + new Vector3(addXpos, addYpos, addZPos);
                Instantiate(PrefabEnemy4, spawnPos, Quaternion.identity);
            }      
        }


       
    }
}
