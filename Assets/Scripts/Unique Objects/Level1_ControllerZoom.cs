using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine;
//using Fungus;

public class Level1_ControllerZoom : MonoBehaviour
{
    [SerializeField] RectTransform UiRelog;
    [SerializeField] RectTransform UiTablero;
    //[SerializeField] Flowchart flowTest;
    private void Start()
    {
        UiTablero.localPosition = new Vector3(0, 600, 0);
        UiRelog.localPosition = new Vector3(0,400,0);
    }

    public void ActiveRelogUi(float Velocity)
    {
        UiRelog.DOMoveY(375, Velocity);
        //flowTest.ExecuteBlock("Reloj Antiguo");
    }
    public void DesactiveRelogUi(float Velocity)
    {
        UiRelog.DOMoveY(1500, Velocity);
    }
    public void ActiveTableroUi(float Velocity)
    {
        UiTablero.DOMoveY(375, Velocity);
        //flowTest.ExecuteBlock("Laberinto");
    }
    public void DesactiveTableroUi(float Velocity)
    {
        UiTablero.DOMoveY(1500, Velocity);
    }
    
}
