using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = true;
    }
    void Update()
    {
        if (Input.GetKey("left"))
            transform.Translate(-20 * Time.deltaTime, 0, 0);

        if (Input.GetKey("right"))
            transform.Translate(20 * Time.deltaTime, 0, 0);

        float h = 30.0f * Input.GetAxis("Mouse X") * Time.deltaTime;
        transform.Translate(h, 0, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        Ball.ySpeed = -Ball.ySpeed;

        if (other.gameObject.transform.position.x > gameObject.transform.position.x)
            Ball.xSpeed = Mathf.Abs(Ball.xSpeed);
        else
            Ball.xSpeed = -Mathf.Abs(Ball.xSpeed);

        Ball.collisionFlag = true;
    }
}
