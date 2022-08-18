using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZMove : MonoBehaviour
{
    //Movimiento Cubos


    private Rigidbody rb;
    [SerializeField] private float vel;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    //private void Update()
    //{
    //    Vector3 localVelocity = transform.InverseTransformDirection(rb.velocity);
    //    localVelocity.x = 0;
    //    localVelocity.y = 0;

    //    rb.velocity = transform.TransformDirection(localVelocity);
    //}

    void FixedUpdate()
    {
        //Vector3 localVelocity = transform.InverseTransformDirection(rb.velocity);
        //localVelocity.x = 0;
        //localVelocity.y = 0;

       

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(-vel * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(vel * Time.deltaTime, 0, 0));
        }

        //rb.velocity = transform.TransformDirection(localVelocity);
    }
}