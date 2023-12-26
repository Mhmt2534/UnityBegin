using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject Player;
    private Vector3 offset = new Vector3(0, 5, -7);


    void Start()
    {
        
    }


    private void LateUpdate()
    {

        transform.position = Player.transform.position + offset;


    }


    void Update()
    {
       

        //transform.position=Player.transform.position;
    }
}
