using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XmoveArrow : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float vel;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.velocity -= new Vector3(vel, 0, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.velocity += new Vector3(vel, 0, 0);
        }
    }
}
