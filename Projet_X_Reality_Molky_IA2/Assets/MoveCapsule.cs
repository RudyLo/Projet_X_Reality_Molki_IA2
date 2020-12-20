using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCapsule : MonoBehaviour
{
    public float force = 4000;
  

    private void Start()
    {

    }
    void Update()
    {
    

            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
 
                GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * force);
            }

        
    }
}