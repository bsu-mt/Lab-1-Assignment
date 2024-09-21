using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallandCollapse : MonoBehaviour
{
    // Reference to the Rigidbody component
    public Rigidbody rb;

    void Start()
    {
        // Set the initial position of the object
        transform.position = new Vector3(3, 10, 0);

        // Add a Rigidbody component to the object if it doesn't have one
        if (GetComponent<Rigidbody>() == null)
        {
            rb = gameObject.AddComponent<Rigidbody>();
        }
        else
        {
            // Get the Rigidbody component
            rb = GetComponent<Rigidbody>();
        }
    }

    // This method is called when the object collides with another object
    void OnCollisionEnter(Collision collision)
    {
        // Check if the object has hit the ground
        if (collision.gameObject.name == "Plane")
        {
            Collapse();
        }
    }

    // Method to handle the collapse of the object
    void Collapse()
    {
        // Disable the Rigidbody to stop further physics interactions
        rb.isKinematic = true;

        // Trigger the collapse (scale down to 0)
        transform.localScale = Vector3.zero;
    }
}
