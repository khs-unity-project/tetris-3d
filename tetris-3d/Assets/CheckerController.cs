using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckerController : MonoBehaviour {
    public GameObject checkerPrefab;
    // Use this for initialization
    void Start () {
        //for (int i = 0; i < 2; i++)
        //{
            GameObject checkerPiece = Instantiate(checkerPrefab);
            checkerPiece.transform.position = new Vector3(
                1,
                2,
                0
                );
        //}
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
