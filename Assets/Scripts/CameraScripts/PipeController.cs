using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PipeController : MonoBehaviour
{
    [SerializeField] RectTransform UiPipe;
    [SerializeField] float VelocityToMove = 0.2f;

    public void UpPipe()
    {
        UiPipe.DOMoveY(356, VelocityToMove);
    }

    public void DownPipe()
    {
        UiPipe.DOMoveY(-1200, VelocityToMove);
    }
}
