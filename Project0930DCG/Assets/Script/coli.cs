using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class coli : MonoBehaviour
{
    public GameObject player;
    private health thehealth;
    private int maxhealthamount = 5;
    public Image[] healthimage;
    public Sprite[] healthsprite;
    // Use this for initialization
    void Start()
    {
        thehealth = FindObjectOfType<health>();
    }

  
    void checkHealthAmount()
    {
        for (int i = 0; i < maxhealthamount; i++)
        {
            if (thehealth.starthealth <= i)
            {
                healthimage[i].enabled = false;
            }
            else
            {
                healthimage[i].enabled = true;
            }
        }
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            thehealth.starthealth--;
            thehealth.starthealth = Mathf.Clamp(thehealth.starthealth, 0, maxhealthamount);
            // 여기 주석처리
            // curhealth = starthealth * healthperheart;
            // maxhealth = maxhealthamount * healthperheart;
            // 가능함 ㅋ
            checkHealthAmount();
        }

    }
}
