using UnityEngine;
using System.Collections;

public class CameraControll : MonoBehaviour {

    // Use this for initialization

    public GameObject player;
    public Transform target;

    private Vector3 offset;
    private Vector3 offset2;

	void Start () {

        offset = transform.position - player.transform.position;
        float angle = Quaternion.Angle(transform.rotation, target.rotation);
	}
	
	// Update is called once per frame
	void Update () {

        transform.position = player.transform.position + offset;
	}
}
