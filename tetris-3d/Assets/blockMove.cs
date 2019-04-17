using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockMove : MonoBehaviour {

    public GameObject blockPrefab;


    public float fallSpeed = 1;
    public float speed = 3.5f;
    public float rotatingSpeed = 140f;
    public bool blockCollide = false;

    // Use this for initialization
    void Start () {
        blockCollide = false;
	}
	
	// Update is called once per frame
	void Update () {

        if (blockCollide == false)
        {

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

            transform.Translate(0, -fallSpeed * Time.deltaTime, 0, Space.World);



            if (Input.GetKey("z"))
            {
                transform.RotateAround(transform.position, Vector3.forward, rotatingSpeed * Time.deltaTime);
            }

            if (Input.GetKey("c"))
            {
                transform.RotateAround(transform.position, Vector3.forward, -rotatingSpeed * Time.deltaTime);
            }

        }


        



    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "TriggerExplosion")
        {
            blockCollide = true;

            GameObject blockObject = Instantiate(blockPrefab);
            //   blockObject.transform.position = transform.TransformPoint(0,10,0);
            blockObject.transform.position = new Vector3(0,10,0);
        }
    }


}
