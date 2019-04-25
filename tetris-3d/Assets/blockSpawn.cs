using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockSpawn : MonoBehaviour {

    public GameObject blockPrefab;

    public string newName = "blockPiece";

    public bool blockCollide = false;
    // Use this for initialization
    void Start () {
        blockCollide = false;

        transform.name = ImproveName(newName);

        GameObject blockPiece = Instantiate(blockPrefab);
        blockPiece.transform.position = new Vector3(0, 10, 0);
    }
	
	// Update is called once per frame
	void Update () {
    }
  /*  void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "TriggerExplosion")
        {
            blockCollide = true;

            GameObject blockPiece = Instantiate(blockPrefab);
            blockPiece.transform.position = new Vector3(0, 10, 0);
        }
    }
*/
    string ImproveName(string originalString)
    {
        return "-[" + originalString + "]-";
    }

}
