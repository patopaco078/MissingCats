using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XMove : MonoBehaviour
{
    //Movimiento Cubos
    private bool MoveW = false;
    private bool MoveS = false;

    private Rigidbody rb;
    [SerializeField] private float vel;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void FixedUpdate()
    {

        if (MoveS == true)
        {
            transform.Translate(new Vector3(vel * Time.deltaTime, 0, 0));
        }
        if (MoveW == true)
        {
            transform.Translate(new Vector3(-vel * Time.deltaTime, 0, 0));
        }


        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(vel * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(-vel * Time.deltaTime, 0, 0));
        }
    }

    public void WMove()
    {
        MoveW = true;
    }
    public void WStop()
    {
        MoveW = false;
    }

    public void SMove()
    {
        MoveS = true;
    }
    public void SStop()
    {
        MoveS = false;
    }
}