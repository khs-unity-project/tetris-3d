using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Border : MonoBehaviour {
    public string newName = "Cubey";
    // Use this for initialization
    void Start () {
        transform.name = ImproveName(newName);


	}
	
	// Update is called once per frame
	void Update () {
		
	}

    string ImproveName ( string originalString )
    {
        return "-[" + originalString + "]-";
    }

}
