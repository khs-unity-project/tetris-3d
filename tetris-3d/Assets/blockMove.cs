using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockMove : MonoBehaviour {


    public float speed = 3.5f;
    public float rotatingSpeed = 140f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey("s"))
        {
            transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime);
        }



        if (Input.GetKey("down"))
        {
            transform.Translate(0, -speed * Time.deltaTime, 0, Space.World);
        }
        if (Input.GetKey("right"))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0, Space.World);
        }
        if (Input.GetKey("left"))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0, Space.World);
        }


        if (Input.GetKey("z"))
        {
            transform.RotateAround(transform.position, Vector3.forward, rotatingSpeed * Time.deltaTime);
        }

        if (Input.GetKey("c"))
        {
            transform.RotateAround(transform.position, Vector3.forward, -rotatingSpeed * Time.deltaTime);
        }

        if (Input.GetKey("a"))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0, Space.World);
        }

        if (Input.GetKey("d"))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0, Space.World);
        }

    }
}
