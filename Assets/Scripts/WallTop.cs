using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallTop : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Ball.ySpeed = -Ball.ySpeed;
        Ball.collisionFlag = true;
    }
}
