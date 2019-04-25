using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckerController : MonoBehaviour {
    public GameObject checkerPrefab;
    public int cxpos;
    public int cypos;
    // Use this for initialization
    void Start () {

        
        for (int i = 0; i < 23; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                GameObject checkerPiece = Instantiate(checkerPrefab);
                checkerPiece.transform.position = new Vector3(
                    cxpos + j + 1,
                    cypos + i + 2,
                    1
                    );
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
