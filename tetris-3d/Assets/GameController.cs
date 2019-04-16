using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public GameObject borderPrefab;
    public int xpos;
    public int ypos;

	// Use this for initialization
	void Start () {
        for (int i = 0; i < 10; i++)
        {
            GameObject wallPiece = Instantiate(borderPrefab);
            wallPiece.transform.position = new Vector3(
                xpos + i,
                ypos + i + 1,
                0
                );
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
