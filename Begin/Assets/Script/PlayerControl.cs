using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private float speed = 20;

    private float horizontalInput;

    private float verticalInput;


    void Start()
    {

    }




    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed*verticalInput);
        //transform.Translate(Vector3.right * Time.deltaTime * speed*horizontalInput);
        transform.Rotate(Vector3.up * Time.deltaTime * speed*horizontalInput);


    }
}
