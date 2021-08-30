using UnityEngine;
using System.Collections;

public class AccelerometerMove : MonoBehaviour
{

    // Use this for initialization

    public float speed;
    public float RotationSpeed;
    


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		transform.Translate(Input.acceleration.x * speed, Input.acceleration.y * speed, Input.acceleration.z * speed);
       

    }

}
