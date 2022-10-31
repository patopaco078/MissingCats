using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Level2_ControllerZoom : MonoBehaviour
{
    [SerializeField] RectTransform UiPuerta;
    [SerializeField] RectTransform UiTuberias;
    //[SerializeField] Flowchart flowTest;
    private void Start()
    {
        UiTuberias.localPosition = new Vector3(0, 600, 0);
        UiPuerta.localPosition = new Vector3(0,400,0);
    }

    public void ActivePuertaUi(float Velocity)
    {
        UiPuerta.DOMoveY(375, Velocity);
        //flowTest.ExecuteBlock("Reloj Antiguo");
    }
    public void DesactivePuertaUi(float Velocity)
    {
        UiPuerta.DOMoveY(1500, Velocity);
    }
    public void ActiveTuberiasUi(float Velocity)
    {
        UiTuberias.DOMoveY(375, Velocity);
        //flowTest.ExecuteBlock("Laberinto");
    }
    public void DesactiveTuberiasUi(float Velocity)
    {
        UiTuberias.DOMoveY(1500, Velocity);
    }
}
