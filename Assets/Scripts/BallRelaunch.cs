using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallRelaunch : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Score.lives--;
        if (Score.lives == 0)
            SceneManager.LoadScene("TitleScene");

        other.transform.position = new Vector3(0, -7, 0);
        Ball.xSpeed = 8.0f;
        Ball.ySpeed = -8.0f;
        Ball.collisionFlag = true;
        Ball.launchTimer = 1.0f;
    }
}
