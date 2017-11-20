using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScore : MonoBehaviour
{

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "BlueGoal")
        {
            Score.BlueScore++;
            Debug.Log (Score.BlueScore);

        }
        if (col.gameObject.tag == "RedGoal")
        {
            Score.RedScore++;

        }

    }

}
