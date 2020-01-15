using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (Ball.collisionFlag)
        {
            Ball.ySpeed = -Ball.ySpeed;
            Ball.collisionFlag = false;
            Destroy(gameObject);
            Score.score += 10;
        }
    }
}
