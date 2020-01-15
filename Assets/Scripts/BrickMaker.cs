using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickMaker : MonoBehaviour
{
    [SerializeField]
    private int maxY = 8;

    [SerializeField]
    private int maxX = 15;
    void Start()
    {
        for (int y = 0; y < maxY; y++)
        {
            for(int x = 0; x < maxX; x++)
            {
                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cube.transform.position = new Vector3(x * 2 - (maxX - 1), y - 1, 0);
                cube.transform.localScale = new Vector3(1.9f, 0.9f, 1);
                cube.gameObject.AddComponent<Brick>(); ;
                cube.GetComponent<Collider>().isTrigger = true;

                if (y < 2)
                    cube.GetComponent<Renderer>().material.color = Color.yellow;
                else if (y < 4)
                    cube.GetComponent<Renderer>().material.color = Color.cyan;
                else if (y < 6)
                    cube.GetComponent<Renderer>().material.color = Color.blue;
                else
                    cube.GetComponent<Renderer>().material.color = Color.red;
            }
        }
    }
}
