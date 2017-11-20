using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public static int RedScore=0;
    public static int BlueScore=0;
    

    // Use this for initialization
    void Start () {
      
        
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<TextMesh>().text = "" + RedScore + " " + BlueScore;
    }
}
