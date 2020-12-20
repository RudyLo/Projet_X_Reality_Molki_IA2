using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCapsule : MonoBehaviour
{
    public float force = 1000;


    private void Start()
    {

    }
    void Update()
    {

            if (Input.GetKeyDown(KeyCode.Space))
            {
                GetComponent<Rigidbody>().AddForce(transform.forward * force);
            }

        
    }
}