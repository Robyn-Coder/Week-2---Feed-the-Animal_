using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float leftLimit = 40; 
    private float bottomLimit = -25; 

    // Update is called once per frame
    void Update()
    {
        // Destroy ball if x position less than left limit
        if (transform.position.y > leftLimit)
        {
            Debug.Log("Ball fell");
            Destroy(gameObject);
        } 
        // Destroy dog if y position is less than bottomLimit
        else if (transform.position.x < bottomLimit)
        {
            //Debug.Log("Game Over"); Tested and works
            Destroy(gameObject);
        }

    }
}
