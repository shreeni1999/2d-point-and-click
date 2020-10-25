using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    //Private variables
    private float speed = 15.0f;
    private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        // We move forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
        //We move right and left
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
