using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Level1_ControllerZoom : MonoBehaviour
{
    [SerializeField] RectTransform UiRelog;
    [SerializeField] RectTransform UiTablero;

    private void Start()
    {
        UiTablero.localPosition = new Vector3(0, 600, 0);
        UiRelog.localPosition = new Vector3(0,400,0);
    }

    public void ActiveRelogUi(float Velocity)
    {
        UiRelog.DOMoveY(375, Velocity);
    }
    public void DesactiveRelogUi(float Velocity)
    {
        UiRelog.DOMoveY(1500, Velocity);
    }
    public void ActiveTableroUi(float Velocity)
    {
        UiTablero.DOMoveY(375, Velocity);
    }
    public void DesactiveTableroUi(float Velocity)
    {
        UiTablero.DOMoveY(1500, Velocity);
    }
}
