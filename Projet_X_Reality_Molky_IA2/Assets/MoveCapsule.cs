using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCapsule : MonoBehaviour
{
    // Start is called before the first frame update

    public float force = 3f;
    bool lance = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (lance == false)
        {
            Vector3 position = transform.position;
            float axeX = Input.GetAxis("Horizontal");
            position.z = axeX/4;

            transform.position = position;

            if (Input.GetKeyDown(KeyCode.Space))
            {
                lance = true;
                GetComponent<Rigidbody>().AddForce(transform.forward * force);
            }
        }
    }
}
