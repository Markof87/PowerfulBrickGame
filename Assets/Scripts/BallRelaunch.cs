using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRelaunch : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        other.transform.position = new Vector3(0, -7, 0);
        Ball.xSpeed = 8.0f;
        Ball.ySpeed = -8.0f;
        Ball.collisionFlag = true;
        Ball.launchTimer = 1.0f;
    }
}
