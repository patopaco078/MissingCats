using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZMove : MonoBehaviour
{
    //Movimiento Cubos
    private bool MoveD = false;
    private bool MoveA = false;
    private Rigidbody rb;
    [SerializeField] private float vel;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void FixedUpdate()
    { 
        if (MoveD == true)
        {
            transform.Translate(new Vector3(-vel * Time.deltaTime, 0, 0));
        }
        if (MoveA == true)
        {
            transform.Translate(new Vector3(vel * Time.deltaTime, 0, 0));
        }
       

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

    public void DMove()
    {
        MoveD = true;
    }
    public void DStop()
    {
        MoveD = false;
    }

    public void AMove()
    {
        MoveA = true;
    }
    public void AStop()
    {
        MoveA = false;
    }
}