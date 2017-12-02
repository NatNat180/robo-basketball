using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper : MonoBehaviour {

    public bool isActive;
    HingeJoint myJoint;

	// Use this for initialization
	void Start () {
        myJoint = GetComponent<HingeJoint>();
        GetComponent<Rigidbody>().maxAngularVelocity = Mathf.Infinity;
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Input.GetButton("Shoot")&& isActive == false)
        {
            isActive = true;
            JointSpring spring = myJoint.spring;
            spring.targetPosition = -50;
            myJoint.spring = spring;

            Debug.Log("sprung");
        }
        else if (Input.GetButton("Shoot")==false && isActive == true){

            isActive = false;
            JointSpring spring = myJoint.spring;
            spring.targetPosition = 1;
            myJoint.spring = spring;
        }
    }
}
