using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockSpawn : MonoBehaviour {

    public GameObject blockPrefab;

    public int spawnLength = 6;
    public int spawnHeight = 25;

    public string newName = "blockPiece";

    public bool blockCollide = false;
    // Use this for initialization
    void Start () {
        blockCollide = false;

        transform.name = ImproveName(newName);

        GameObject blockPiece = Instantiate(blockPrefab);
        blockPiece.transform.position = new Vector3(spawnLength, spawnHeight, .5);
    }
	
	// Update is called once per frame
	void Update () {
    }
 
    string ImproveName(string originalString)
    {
        return "-[" + originalString + "]-";
    }

}
