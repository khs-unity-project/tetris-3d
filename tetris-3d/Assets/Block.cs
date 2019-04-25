using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public string newName = "blockPiece";
    // Use this for initialization
    void Start()
    {
        transform.name = ImproveName(newName);


    }

    // Update is called once per frame
    void Update()
    {

    }

    string ImproveName(string originalString)
    {
        return "-[" + originalString + "]-";
    }

}