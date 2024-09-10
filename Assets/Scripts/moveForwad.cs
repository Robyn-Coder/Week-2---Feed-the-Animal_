using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveForward : MonoBehaviour
{

    public float foodSpeed = 40f;

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * foodSpeed); //shoot the food forward
    }
}
