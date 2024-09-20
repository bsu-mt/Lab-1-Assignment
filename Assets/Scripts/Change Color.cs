using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    // Start is called before the first frame update

    // Reference to the Renderer component
    public Renderer objectRenderer;

    void Start()
    {
        // Get the Renderer component from the object
        objectRenderer = GetComponent<Renderer>();

        // Change the color to red
        objectRenderer.material.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
