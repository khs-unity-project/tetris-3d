using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public GameObject borderPrefab; 


	// Use this for initialization
	void Start () {
        GameObject wallPiece = Instantiate(borderPrefab);
        wallPiece.transform.position = new Vector3(
            0,
            0,
            0
            );
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
