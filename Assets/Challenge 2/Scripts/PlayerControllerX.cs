using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    
    public float horizontalInput; //declare movement variable
    public float movementSpeed = 10f; //declare speed movement
    public float xRange = 16;//declare range of the boundary
    public GameObject dogPrefab;
    void Update()
        {
           //if statement to set boundary on our left side/boundary - stopping the player from leaving the screen.
            if(transform.position.x < -xRange)
            {
                transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
            } 

            //if statement to set boundary on our right side/boundary - stopping the player from leaving the screen.
            if(transform.position.x > xRange)
            {
                transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
            } 
            
            horizontalInput = Input.GetAxis("Horizontal");//access the movement by an input.
            transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * movementSpeed ); //it allows movement using speed

            //spawnfood out only when space is pressed
            if(Input.GetKeyDown(KeyCode.Space))
            {
                //Launch prefab from player
                Instantiate(dogPrefab,transform.position,dogPrefab.transform.rotation);
            }
        }
}
