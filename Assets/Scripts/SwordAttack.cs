using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class SwordAttack : MonoBehaviour
{
   

    public float rotationSpeed = 360f; // The speed of rotation in degrees per second

    public string objectsToDestroyTag = "Slime";

    void Update()
    {
       

        rotate();
    }

    void OnCollisionEnter(Collision collision)
    {
        // Check if the collided game object has the specified tag
        if (collision.gameObject.tag == objectsToDestroyTag)
        {
            // Destroy the collided game object
            Destroy(collision.gameObject);
        }
    }

    void rotate()
    {
        // Get the parent's position as the center for rotation
        Vector3 center = transform.parent.position;

        // Rotate the object around its parent
        transform.RotateAround(center, Vector3.up, rotationSpeed * Time.deltaTime);
    }

  
}
