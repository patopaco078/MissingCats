using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using DG.Tweening;

public class CameraRotate : MonoBehaviour
{

    public UnityEvent TiggerThis;

    private Transform cameraPosition;
    public int cameraPosCounter = 0; //Para el DOTWEEN
    [SerializeField] private int FirstPosCounter = 0;
    [SerializeField] float rotationSpeed = 15f;
    [SerializeField] float rotationTime = 2f;
    private bool isRotatingR = false;
    private bool isRotatingL = false;

    private DOTMove DOT;

    private void Awake()
    {
        cameraPosition = gameObject.GetComponent<Transform>();
        DOT = gameObject.GetComponent<DOTMove>();
    }
    IEnumerator StopRotation()
    {
        yield return new WaitForSeconds(rotationTime);
        isRotatingR = false;
        isRotatingL = false;

    }
    //private void Update()
    //{
    //    if (isRotatingR == true )
    //    {
    //        transform.Rotate(new Vector3(0, Time.deltaTime * -rotationSpeed, 0));
    //    }
    //    if (isRotatingL == true)
    //    {
    //        transform.Rotate(new Vector3(0, Time.deltaTime * rotationSpeed, 0));
    //    }
    //}

    
    public void MoveCameraR()
    {
        if (isRotatingL == false && isRotatingR == false)
        {
            TiggerThis.Invoke();
            isRotatingR = true;
            StartCoroutine(StopRotation());

            if (cameraPosCounter == 0)
            {
                cameraPosCounter++;

                if (FirstPosCounter == 0)
                {
                    
                    DOT.Prop0Up();
                    DOT.Prop1Up();
                    Debug.Log("0Up");
                    FirstPosCounter++;
                    transform.DORotate(new Vector3(0, -90f, 0), rotationTime);
                }
                else
                {

                    DOT.Prop0Up();
                    DOT.Prop1Up();
                    DOT.Prop3Down();
                    Debug.Log("0Up 1Up y 3Down");
                    FirstPosCounter++;
                    transform.DORotate(new Vector3(0, -90f, 0), rotationTime);
                }
            }
            else if (cameraPosCounter == 1)
            {
                
                DOT.Prop1Up();
                DOT.Prop2Up();
                DOT.Prop0Down();
                Debug.Log("1Up 2Up y 0Down");
                cameraPosCounter++;
                transform.DORotate(new Vector3(0, -180f, 0), rotationTime);
            }
            else if (cameraPosCounter == 2)
            {
                
                DOT.Prop2Up();
                DOT.Prop3Up();
                DOT.Prop1Down();
                Debug.Log("2Up 3Up y 1Down");
                cameraPosCounter++;
                transform.DORotate(new Vector3(0, -270f, 0), rotationTime);
            }
            else if (cameraPosCounter == 3)
            {
                
                DOT.Prop3Up();
                DOT.Prop0Up();
                DOT.Prop2Down();
                Debug.Log("3Up 0Up y 2Down");
                cameraPosCounter = 0;
                transform.DORotate(new Vector3(0, -360f, 0), rotationTime);
            }
        }
    }
    public void MoveCameraL()
    {
        if (isRotatingL == false && isRotatingR == false)
        {
            TiggerThis.Invoke();
            isRotatingL = true;
            StartCoroutine(StopRotation());

            if (cameraPosCounter == 0)
            {
                cameraPosCounter = 3;

                if (FirstPosCounter == 0)
                {
                    DOT.Prop3Up();
                    DOT.Prop2Up();
                    Debug.Log("0Up");
                    FirstPosCounter++;
                    transform.DORotate(new Vector3(0, 90f, 0), rotationTime);
                }
                else
                {
                    DOT.Prop3Up();
                    DOT.Prop2Up();
                    DOT.Prop0Down();
                    Debug.Log("0Up 1Up y 3Down");
                    FirstPosCounter++;
                    transform.DORotate(new Vector3(0, 90f, 0), rotationTime);
                }
            }
            else if (cameraPosCounter == 3)
            {
                DOT.Prop1Up();
                DOT.Prop2Up();
                DOT.Prop3Down();
                Debug.Log("3Up 0Up y 2Down");
                cameraPosCounter--;
                transform.DORotate(new Vector3(0, 180f, 0), rotationTime);
            }
            else if (cameraPosCounter == 2)
            {
                DOT.Prop1Up();
                DOT.Prop0Up();
                DOT.Prop2Down();
                Debug.Log("2Up 3Up y 1Down");
                cameraPosCounter--;
                transform.DORotate(new Vector3(0, 270f, 0), rotationTime);
            }
            else if (cameraPosCounter == 1)
            {
                DOT.Prop3Up();
                DOT.Prop0Up();
                DOT.Prop1Down();
                Debug.Log("1Up 2Up y 0Down");
                cameraPosCounter--;
                transform.DORotate(new Vector3(0, 360f, 0), rotationTime);
            }
        }
    }
}
