using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    private Transform cameraPosition;
    public int cameraPosCounter = 0; //Para el DOTWEEN
    [SerializeField] float rotationSpeed = 15f;
    [SerializeField] float rotationTime = 2f;
    private bool isRotatingR = false;
    private bool isRotatingL = false;

    private void Awake()
    {
        cameraPosition = gameObject.GetComponent<Transform>();
        
    }
    IEnumerator StopRotation()
    {
        yield return new WaitForSeconds(rotationTime);
        isRotatingR = false;
        isRotatingL = false;

    }
    private void Update()
    {
        if (isRotatingR == true )
        {
            transform.Rotate(new Vector3(0, Time.deltaTime * -rotationSpeed, 0));
        }
        if (isRotatingL == true)
        {
            transform.Rotate(new Vector3(0, Time.deltaTime * rotationSpeed, 0));
        }
    }

    
    public void MoveCameraR()
    {
        if (isRotatingL == false)
        {
            isRotatingR = true;
            StartCoroutine(StopRotation());
        }
            

        //if (cameraPosCounter == 0)
        //{
        //    cameraPosCounter++;
            
        //}
        //if (cameraPosCounter == 1)
        //{
        //    cameraPosCounter++;
        //    transform.Rotate(0, -90, 0);
        //}
        //if (cameraPosCounter == 2)
        //{
        //    cameraPosCounter++;
        //    transform.Rotate(0, -90, 0);
        //} 
        //if (cameraPosCounter == 3)
        //{
        //    cameraPosCounter = 0;
        //    transform.Rotate(0, -90, 0);
        //}

    }
    public void MoveCameraL()
    {
        if (isRotatingR == false)
        {
            isRotatingL = true;
            StartCoroutine(StopRotation());
        }
    }
}
