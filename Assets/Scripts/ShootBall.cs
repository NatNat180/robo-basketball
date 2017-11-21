using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBall : MonoBehaviour
{

    Animator animator;
    public Rigidbody basketball;
    public float thrust;

    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        /* set up shoot animation trigger on button down */
        bool shoot = Input.GetButtonDown("Shoot");
        animator.SetBool("shoot", shoot);

		/* apply conditions before shooting ball */
        if (shoot && ScoopDetector.isInScoop)
        {
			Vector3 targetTrajectory = -(transform.forward / 1.1f) + (transform.up * 3);
            basketball.AddForce(targetTrajectory * thrust, ForceMode.Impulse);
			ScoopDetector.isInScoop = false;
        }

    }

}
