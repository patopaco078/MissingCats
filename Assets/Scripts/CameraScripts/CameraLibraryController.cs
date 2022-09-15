using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CameraLibraryController : MonoBehaviour
{
    [SerializeField] RectTransform ButtonMoveRight;
    [SerializeField] RectTransform ButtonMoveLeft;

    [SerializeField] Transform Camera;
    [SerializeField] Transform FrontPosition;
    [SerializeField] Transform RightPosition;
    [SerializeField] float VelocityToMove = 0.3f;

    public void PositionFront()
    {
        Camera.DOMove(FrontPosition.position, VelocityToMove);
        Camera.DORotate(FrontPosition.rotation.eulerAngles, VelocityToMove);
        ButtonMoveLeft.DOMoveY(1200, VelocityToMove);
        ButtonMoveRight.DOMoveY(375, VelocityToMove);
    }

    public void PositionRight()
    {
        Camera.DOMove(RightPosition.position, VelocityToMove);
        Camera.DORotate(RightPosition.rotation.eulerAngles, VelocityToMove);
        ButtonMoveRight.DOMoveY(1200, VelocityToMove);
        ButtonMoveLeft.DOMoveY(375, VelocityToMove);
    }

    public void UpButtons()
    {
        ButtonMoveRight.DOMoveY(1200, VelocityToMove);
        ButtonMoveLeft.DOMoveY(1200, VelocityToMove);
    }

    public void DownButton()
    {
        ButtonMoveRight.DOMoveY(375, VelocityToMove);
    }
}
