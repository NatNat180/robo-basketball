using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBall : MonoBehaviour {

	Animator animator;

	// Use this for initialization
	void Start () {

		animator = GetComponent<Animator>();
		
	}
	
	// Update is called once per frame
	void Update () {

		/* set up shoot animation trigger on button down */
		bool shoot = Input.GetButtonDown("Shoot");
		animator.SetBool("scoop flip", shoot);
		
	}
}
