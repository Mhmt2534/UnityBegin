using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForw : MonoBehaviour
{
    public float speed = 10;

  
    void Start()
    {
        
    }

    

    void Update()
    {
        transform.Translate(Vector3.forward * speed*Time.deltaTime);


      


    }
}
