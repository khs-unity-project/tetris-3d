using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckerController : MonoBehaviour {
    public GameObject checkerPrefab;
    public bool isDead;
    public string rowName;
    public string collumnName;
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
                //Debug.Log(rowName + collumnName);
                //rowName = rowName + j.ToString();
                
            }
           //collumnName = rowName + i.ToString();
        }



    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
