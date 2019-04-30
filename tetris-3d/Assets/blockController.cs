using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockController : MonoBehaviour {

    public GameObject blockPrefab;
    public GameObject treePrefab;


    public float fallSpeed = 1;
    public float speed = 3.5f;
    public float rotatingSpeed = 140f;
    public bool blockCollide = false;
    public string detecter = "Untagged";
    public int blockLength = 6;
    public int blockHeight = 25;
    public float rndNum;

    // Use this for initialization
    void Start () {
        blockCollide = false;
        detecter = "Untagged";
    }
	
	// Update is called once per frame
	void Update () {

        blockPrefab.transform.Translate(0, -fallSpeed * Time.deltaTime, 0, Space.World);
        if (blockCollide == false)
        {

            if (Input.GetKey("down"))
            {
                blockPrefab.transform.Translate(0, -speed * Time.deltaTime, 0, Space.World);
            }
            if (Input.GetKey("right"))
            {
                blockPrefab.transform.Translate(speed * Time.deltaTime, 0, 0, Space.World);
            }
            if (Input.GetKey("left"))
            {
                blockPrefab.transform.Translate(-speed * Time.deltaTime, 0, 0, Space.World);
            }

           



            if (Input.GetKey("z"))
            {
                blockPrefab.transform.RotateAround(transform.position, Vector3.forward, rotatingSpeed * Time.deltaTime);
            }

            if (Input.GetKey("c"))
            {
                blockPrefab.transform.RotateAround(transform.position, Vector3.forward, -rotatingSpeed * Time.deltaTime);
            }

        }

    }
      void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == detecter)
        {
            blockCollide = true;

            rndNum = Random.Range(0, 2);

            if (rndNum == 0)
            { 
            SpawnBlock();
            }
            else if (rndNum == 1)
                {
                spawnTree();
            }

            detecter = "null";
        }
    }

    public void SpawnBlock()
    {
        GameObject blockPiece = Instantiate(blockPrefab);
        blockPiece.transform.position = new Vector3(blockLength, blockHeight+50, 0);
    }

    public void spawnTree()
    {
        GameObject treePiece = Instantiate(treePrefab);
        treePiece.transform.position = new Vector3(blockLength, blockHeight+100, 0);
    }







}
