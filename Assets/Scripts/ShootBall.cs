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

		/* apply target trajectory of object */
		Vector3 targetDir = transform.position * -1;
		float angle = Vector3.Angle(targetDir, transform.forward);
		Vector3 trajectoryDir = Quaternion.AngleAxis(angle, Vector3.forward) * Vector3.right;

		/* apply conditions for ball to be shot */
        if (shoot && ScoopDetector.isInScoop)
        {
            basketball.AddForce(trajectoryDir * thrust, ForceMode.Impulse);
			ScoopDetector.isInScoop = false;
        }
    }

}
