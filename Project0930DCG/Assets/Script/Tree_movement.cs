using UnityEngine;
using System.Collections;

public class Tree_movement : MonoBehaviour {

    // Use this for initialization

    public float speed = 5.0f;
    public float a = 0;//장애물 이동속도
    public float b;

    void Start () {
        b = a * 5;
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezePositionY;
    }

    // Update is called once per frame

    public void slider(float newValue)
    {

        a = newValue;
    }

    void Update () {
        transform.Translate(new Vector3(0, 0, -100.0f * (speed + b) * Time.deltaTime));



        if (transform.position.z < 200)
        {
            Destroy(gameObject);
        }

    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Destroy(gameObject);

        }
    }
}

