using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField]
    private AudioClip beepSound;

    private AudioSource audioSource;

    public static float launchTimer;
    public static float xSpeed;
    public static float ySpeed;
    public static bool collisionFlag;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        launchTimer = 2.0f;
        xSpeed = 8.0f;
        ySpeed = 8.0f;
        collisionFlag = true;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, 0);

        launchTimer -= Time.deltaTime;
        if(launchTimer <= 0)
        {
            transform.Translate(new Vector3(xSpeed, ySpeed, 0) * Time.deltaTime);
            launchTimer = 0;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        audioSource.PlayOneShot(beepSound);
    }
}
