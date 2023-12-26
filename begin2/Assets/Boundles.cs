using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundles : MonoBehaviour
{

    private float topBound = 20;

    private float bottomBound = -10;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < bottomBound)
        {
            Destroy(gameObject);
        }



    }
}
