using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using DG.Tweening;

public class InteractiveObjectController : MonoBehaviour
{
    //funtion Activate
    [SerializeField] UnityEvent IsUsingFuntions;
    [SerializeField] UnityEvent IsNotUsingFuntions;


    //camera propietys
    [SerializeField] Transform Camera;
    [SerializeField] GameObject InitialCameraPosition;
    [SerializeField] Transform ZoomTarget;
    [SerializeField] RectTransform ButtonMove;
    [SerializeField] float ButtonYMove;
    [SerializeField] RectTransform ButtonBack;

    [SerializeField] Transform Target;
    [SerializeField] float VelocityToMoving = 0.5f;
    private Vector3 originalPosition, originalRotation;
    private bool isUsing = false;
    [SerializeField] CameraLibraryController CLC;
    //[SerializeField] PipeController Pipe;

    [SerializeField] bool IsLybrary = false;
    [SerializeField] bool isOtherObject = false;
    [SerializeField] UnityEvent OtherObjectEvents;

    Vector2 touchDeltaPosition;
    Vector3 rotationCamera;
    [SerializeField] private float velocity = 0.2f;

    private void Start()
    {
        originalPosition = transform.position;
        originalRotation = transform.rotation.eulerAngles;
    }

    public void IsUsing()
    {
        Debug.Log("usingON");
        IsUsingFuntions.Invoke();
        InitialCameraPosition.GetComponent<InitialCamera>().CanMove = false;
        ButtonMove.transform.DOMoveY(2000f, VelocityToMoving);
        ButtonBack.DOMoveY(500, VelocityToMoving);
        Camera.DOMove(ZoomTarget.position, VelocityToMoving);
        Camera.DORotate(ZoomTarget.rotation.eulerAngles, VelocityToMoving);
        gameObject.GetComponent<BoxCollider>().enabled = false;

        /*if (IsLybrary)
        {
        }*/
        if (IsLybrary && CLC != null)
        {
            CLC.DownButton();
        }

        if(isOtherObject)
        {
            OtherObjectEvents.Invoke();
        }

        isUsing = true;
    }

    public void IsNotUsing()
    {
        IsNotUsingFuntions.Invoke();
        Camera.DOMove(InitialCameraPosition.transform.position, VelocityToMoving);
        Camera.DORotate(InitialCameraPosition.transform.rotation.eulerAngles, VelocityToMoving);
        ButtonMove.transform.DOMoveY(ButtonYMove, VelocityToMoving);
        ButtonBack.DOMoveY(1300, VelocityToMoving);
        
        StartCoroutine(CanMovePosition());
        isUsing =false;
    }

    IEnumerator CanMovePosition()
    {
        yield return new WaitForSeconds(VelocityToMoving);
        InitialCameraPosition.GetComponent<InitialCamera>().CanMove = true;
        gameObject.GetComponent<BoxCollider>().enabled = true;
    }
}
