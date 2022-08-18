using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZmoveArrow : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float vel;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity -= new Vector3(0, 0, vel);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity += new Vector3(0, 0, vel);
        }
    }
}
