using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Ball.xSpeed = -Ball.xSpeed;
        Ball.collisionFlag = true;
    }
}
