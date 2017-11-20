using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoopDetector : MonoBehaviour
{

	public static bool isInScoop;

    // Use this for initialization
    void Start()
    {
		isInScoop = false;
    }

    // Update is called once per frame
    void Update()
    {
		
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Scoop")
        {
            isInScoop = true;
        }

    }
}
