using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public static int RedScore=1;
    public static int BlueScore=2;
    

    // Use this for initialization
    void Start () {
      
        GetComponent<TextMesh>().text = ""+RedScore+" "+BlueScore;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
