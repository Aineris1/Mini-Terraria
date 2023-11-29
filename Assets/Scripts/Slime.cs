using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : MonoBehaviour
{
    public string targetTag = "Player"; 
    public float speed = 5f; // Slime speed

    void Update()
    {
        // Find the target GameObject by tag
        GameObject targetObject = GameObject.FindGameObjectWithTag(targetTag);

        // Check if the target GameObject is found
        if (targetObject != null)
        {
            // Calculate the direction from the prefab to the target
            Vector3 direction = targetObject.transform.position - transform.position;

            
            direction.Normalize();

            // Update the position of the prefab based on the direction and speed
            transform.position += direction * speed * Time.deltaTime;
        }
    }
}
