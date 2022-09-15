using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitalCameraController : MonoBehaviour
{
    [SerializeField] private Transform TargetObject;
    [SerializeField] private float CameraDistance;

    private Transform cameraPosition;
    Quaternion quaternionCamera;
    [SerializeField] Vector3 rotationCamera;
    Vector3 cAngles = new Vector3(90, 0, 0);


    //touch position
    Vector2 touchDeltaPosition;
    [SerializeField] private float velocity = 0.1f;

    private void Awake()
    {
        cameraPosition = gameObject.GetComponent<Transform>();
    }

    private void Update()
    {
        
        //Orbite camera
        cameraPosition.position = new Vector3(((Mathf.Sin(rotationCamera.y * Mathf.PI / 180) * CameraDistance) * -1)*(Mathf.Cos(rotationCamera.x * Mathf.PI / 180)), Mathf.Sin(rotationCamera.x * Mathf.PI / 180) * CameraDistance, ((Mathf.Cos(rotationCamera.y * Mathf.PI / 180) * CameraDistance)*-1) * (Mathf.Cos(rotationCamera.x * Mathf.PI / 180)));

        //actualization rotation

        quaternionCamera = Quaternion.Euler(rotationCamera);
        cameraPosition.rotation = quaternionCamera;
    }
}
