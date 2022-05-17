using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creator : MonoBehaviour
{

    public GameObject cube1;
    public GameObject cube2;
    public int number;

    void Start()
    {
        for(int i=0; i<number; i++)
        {
            Instantiate(cube1, new Vector3(transform.position.x+2*i,0,0), Quaternion.identity);
        }
    }
}
