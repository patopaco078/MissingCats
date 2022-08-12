using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class InteractiveObjectController : MonoBehaviour
{
    [SerializeField] Transform Target;
    [SerializeField] float Velocity = 0.5f;
    private Vector3 originalPosition, originalRotation;
    private bool isUsing = false;

    Vector2 touchDeltaPosition;
    Vector3 rotationCamera;
    [SerializeField] private float velocity = 0.2f;

    private void Start()
    {
        originalPosition = transform.position;
        originalRotation = transform.rotation.eulerAngles;
    }

    private void Update()
    {
        if (isUsing)
        {
            if (Input.touchCount > 0)
            {
                Touch touchZero = Input.GetTouch(0);
                if (touchZero.phase == TouchPhase.Moved)
                {
                    touchDeltaPosition = Input.GetTouch(0).deltaPosition;
                    rotationCamera.x -= touchDeltaPosition.y * velocity;
                    rotationCamera.y += touchDeltaPosition.x * velocity;
                }

                Debug.Log(touchDeltaPosition);
            }
            gameObject.transform.rotation = Quaternion.Euler(rotationCamera);
        }
    }

    public void IsUsing()
    {
        gameObject.transform.DOMove(Target.position, Velocity);
        isUsing = true;
    }

    public void IsNotUsing()
    {
        gameObject.transform.DOMove(originalPosition, Velocity);
        gameObject.transform.DORotate(originalRotation, Velocity);
        isUsing=false;
    }
}
