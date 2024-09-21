using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpandBeep : MonoBehaviour
{
    public float jumpForce = 5f;  // Force applied to the jump
    private Rigidbody rb;         // Reference to the Rigidbody component
    private AudioSource audioSource; // Reference to the AudioSource component

    void Start()
    {
        // Get the MeshFilter component attached to the cylinder
        MeshFilter meshFilter = GetComponent<MeshFilter>();

        // Get the mesh bounds
        float height = meshFilter.mesh.bounds.size.y * transform.localScale.y;

        // Put the cylinder on the ground
        transform.position = new Vector3(0, height / 2, 0);

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

        // Get the AudioSource component attached to the same GameObject
        audioSource = GetComponent<AudioSource>();

        // Check if the AudioSource component is attached
        if (audioSource == null)
        {
            Debug.LogError("AudioSource component is missing on this GameObject!");
        }

        // Check if an AudioClip is assigned
        if (audioSource.clip == null)
        {
            Debug.LogError("No AudioClip assigned to the AudioSource!");
        }
    }

    void Update()
    {
        // Check if the spacebar is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Make the object jump by applying a force upwards
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

            // Play the beep sound if the AudioSource is not null
            if (audioSource != null && audioSource.clip != null)
            {
                audioSource.Play();
            }
        }
    }
}

