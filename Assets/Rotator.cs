using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    float speed = 120;
    void Update()
    {
        transform.Rotate(Vector3.right, speed * Time.deltaTime, Space.Self);
    }
}
