using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoboBehaviour : MonoBehaviour {

	private Rigidbody player;
	private Collider playerCollder;
	public float moveSpeed;
	public float rotationSpeed;

	// Use this for initialization
	void Start () 
	{

		player = GetComponent<Rigidbody>();
		playerCollder = GetComponent<Collider>();

	}
	
	// Update is called once per frame
	void Update () 
	{

		float rotate = Input.GetAxis("Horizontal");
		float move = Input.GetAxis("Vertical");

		player.velocity = transform.forward  * moveSpeed * move;
		transform.Rotate(Vector3.up * rotationSpeed * rotate * Time.deltaTime);
		
	}
}
