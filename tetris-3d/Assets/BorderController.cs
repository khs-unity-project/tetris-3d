using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderController : MonoBehaviour {

    public GameObject borderPrefab;
    public GameObject wallPiece;
    public GameObject bottomWallPiece;
    public int bxpos;
    public int bypos;

	// Use this for initialization
	void Start () {
        for (int i = 0; i < 12; i++)
        {
            bottomWallPiece = Instantiate(borderPrefab);
            bottomWallPiece.transform.position = new Vector3(
                bxpos + i,
                bypos + 1,
                0
                );
            bottomWallPiece.tag = "Respawn";
        }

        for (int k = 1; k < 24; k++)
        {
            wallPiece = Instantiate(borderPrefab);
            wallPiece.transform.position = new Vector3(
                bxpos,
                bypos + k + 1,
                0
                );
            wallPiece.tag = "noBlockSpawn";
        }

        for (int j = 1; j < 24; j++)
        {
            wallPiece = Instantiate(borderPrefab);
            wallPiece.transform.position = new Vector3(
                bxpos + 11,
                bypos + j + 1,
                0
                );
            wallPiece.tag = "noBlockSpawn";
        }


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
