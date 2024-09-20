using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASDMove : MonoBehaviour
{
    // This script is for the 1st interactive element: Using WASD to move the object

    // Define moving "speed"
    public float speed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Move foward when pressing "W"
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }

        // Move backward when pressing "S"
        if (Input.GetKey(KeyCode.S))
        {
            // Use -1 to move backward
            transform.Translate(-1 * Vector3.forward * Time.deltaTime * speed);
        }

        // Move right when pressing "D"
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }

        // Move ledt when pressing "A"
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-1 * Vector3.right * Time.deltaTime * speed);
        }
    }
}
