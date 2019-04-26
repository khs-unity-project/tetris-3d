using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontController : MonoBehaviour {
    public GameObject frontPrefab;
    public float fxpos;
    public float fypos;
    public float fzpos;
    // Use this for initialization
    void Start () {

        fxpos = 5.5f;
        fypos = 13.5f;
        fzpos = -0.51f;

        GameObject frontPiece = Instantiate(frontPrefab);
        frontPiece.transform.position = new Vector3(
            fxpos,
            fypos,
            fzpos
            );
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
