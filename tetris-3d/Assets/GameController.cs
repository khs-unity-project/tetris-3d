using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public GameObject borderPrefab;
    public int xpos;
    public int ypos;

	// Use this for initialization
	void Start () {
        for (int i = 0; i < 12; i++)
        {
            GameObject wallPiece = Instantiate(borderPrefab);
            wallPiece.transform.position = new Vector3(
                xpos + i,
                ypos + 1,
                0
                );
        }

        for (int k = 1; k < 24; k++)
        {
            GameObject wallPiece = Instantiate(borderPrefab);
            wallPiece.transform.position = new Vector3(
                xpos,
                ypos + k + 1,
                0
                );
        }

        for (int j = 1; j < 24; j++)
        {
            GameObject wallPiece = Instantiate(borderPrefab);
            wallPiece.transform.position = new Vector3(
                xpos + 11,
                ypos + j + 1,
                0
                );
        }


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
