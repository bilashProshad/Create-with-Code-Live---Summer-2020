using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // private variables
    private float speed = 15.0f;
    private float turnSpeed = 45.0f;
    private float horizontalAxis;
    private float forwardAxis;

    public string horizontalInput;
    public string verticalInput;

    // camera switcher
    public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode switchKey;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // take player input
        horizontalAxis = Input.GetAxis(horizontalInput);
        forwardAxis = Input.GetAxis(verticalInput);

        // Move the car foroward based on verticle input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardAxis);
        // Rotate the car based on horizontal input
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalAxis);

        if (Input.GetKeyDown(switchKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;
        }
    }
}
