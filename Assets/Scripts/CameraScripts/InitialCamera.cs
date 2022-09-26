using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialCamera : MonoBehaviour
{
    [SerializeField] Transform Camera;
    [SerializeField] private bool canMove = true;

    public bool CanMove {set => canMove = value; }

    private void Update()
    {
        if (canMove)
        {
            
            transform.position = Camera.transform.position;
            transform.rotation = Camera.transform.rotation;
        }
    }
}
