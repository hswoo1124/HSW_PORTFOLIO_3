using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class health : MonoBehaviour {
    private int maxhealthamount = 5;
    public int starthealth = 5;
    public int curhealth;
    private int maxhealth;
    private int healthperheart = 1;

    public Image[] healthimage;
    public Sprite[] healthsprite;
	public float speedX = 2.0f;
	public float speedY = 2.0f;
	public float speedX1 = 2.0f;
	public float speedY2 = 2.0f;
	public float speedz = 2.0f;
	public GameObject Wall;
	public GameObject Wall1;
	public GameObject Wall2;
	public GameObject Wall3;
	public GameObject Wall4;
	public string youdie;
	public ParticleSystem damage;
	public ParticleSystem heal;


	void Start () {
        curhealth = starthealth * healthperheart;
        maxhealth = maxhealthamount * healthperheart;
        checkHealthAmount();

	}

    void checkHealthAmount() {
     for (int i = 0; i < maxhealthamount; i++)
        {
           if (starthealth <= i)
            {
                healthimage[i].enabled = false;
            }
            else
            {
                healthimage[i].enabled = true;
            }   
			if(starthealth < 1)
			{
				Application.LoadLevel(youdie);
			}
        } 
        UpdateHealth();
    }
    void UpdateHealth()
    {
        bool empty = false;
        int i = 0;

        foreach (Image image in healthimage)
        {
            if (empty)
            {
                image.sprite = healthsprite[0];
            }
            else
            {
                int currenthealth = (int)(healthperheart - (healthperheart * i - curhealth));
                int healthperimage = healthperheart / (healthsprite.Length - 1);
                int imageinbex = currenthealth / healthperimage;
                image.sprite = healthsprite[imageinbex];
                empty = true;
            }
        }
    }
	

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject == Wall) {
			transform.position = new Vector3 (transform.position.x - Time.deltaTime * speedX, transform.position.y, transform.position.z);
		} 
	
		if (other.gameObject == Wall1)
		{
			transform.position = new Vector3(transform.position.x - Time.deltaTime*speedX1, transform.position.y, transform.position.z);
		}
		if (other.gameObject == Wall2)
		{
			transform.position = new Vector3(transform.position.x, transform.position.y - Time.deltaTime*speedY, transform.position.z);
		}
		if (other.gameObject == Wall3)
		{
			transform.position = new Vector3(transform.position.x, transform.position.y - Time.deltaTime*speedY2, transform.position.z);
		}
		if (other.gameObject == Wall4)
		{
			transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z- Time.deltaTime*speedz);
		}
		if (other.gameObject.tag == "Enemy") {
		starthealth--;
		starthealth = Mathf.Clamp(starthealth, 0, maxhealthamount);
			damage.Play();
			// 여기 주석처리
			// curhealth = starthealth * healthperheart;
			// maxhealth = maxhealthamount * healthperheart;
			// 가능함 ㅋ
			checkHealthAmount();
		}

		if (other.gameObject.tag == "Heal") {
			starthealth++;
			starthealth = Mathf.Clamp(starthealth, 0, maxhealthamount);
			heal.Play();
			// 여기 주석처리
			// curhealth = starthealth * healthperheart;
			// maxhealth = maxhealthamount * healthperheart;
			// 가능함 ㅋ
			checkHealthAmount();
		}


	}


}
