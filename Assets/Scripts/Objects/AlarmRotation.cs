using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlarmRotation : MonoBehaviour
{
    private float zRotation = 5f;
    [SerializeField] private Vector3 actualRotation = new Vector3(-90,0,0);
    private void FixedUpdate()
    {
        actualRotation += new Vector3(0, 0, zRotation);
        transform.rotation = Quaternion.Euler(actualRotation);
    }
}
