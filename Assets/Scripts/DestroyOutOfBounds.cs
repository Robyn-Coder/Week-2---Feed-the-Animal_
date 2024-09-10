using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBoundry = 35;
    public float bottomBoundry = -10;
    void Update()
    {

        //pizza destroy
        if(transform.position.z > topBoundry)
        {
            Destroy(gameObject);
        }
        //animal destroy
        else if(transform.position.z < bottomBoundry)
        {
            Debug.Log("Game Over");
            Destroy(gameObject);
        }
    }
}
