using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBall : MonoBehaviour
{

    Animator animator;
    public Rigidbody basketball;
    public float thrust;
    bool isHoldingBall;

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
        if (shoot && isHoldingBall)
        {
            basketball.AddForce(Vector3.up * thrust, ForceMode.Impulse);
        }
    }
    private void OnCollisionEnter(Collision col)
    {
		Debug.Log("collision detected!");
        if (col.gameObject.tag == "Basketball")
        {
            isHoldingBall = true;
        }
    }
}
