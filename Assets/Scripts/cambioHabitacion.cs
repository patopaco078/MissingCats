using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class cambioHabitacion : MonoBehaviour
{
    [SerializeField]
    private Transform camara;
    [SerializeField] private float time;
    [SerializeField] private float x;
    [SerializeField] private float y;
    [SerializeField] private float z;
    [SerializeField] GameObject[] piezaMain;
    [SerializeField] GameObject[] pieza2;
    [SerializeField] GameObject[] pieza3;

    public void cambioPieza1()
    {
        camara.DOMove(new Vector3(-15, y, z), time);

        foreach (GameObject obj in piezaMain)
        {
            obj.SetActive(false);
        }
        foreach (GameObject obj in pieza2)
        {
            obj.SetActive(true);
        }

        foreach (GameObject obj in pieza3)
        {
            obj.SetActive(false);
        }
    }
    public void cambioPieza2()
    {
        camara.DOMove(new Vector3(-20, 10,z), time);
        foreach (GameObject obj in piezaMain)
        {
            obj.SetActive(false);
        }
        foreach (GameObject obj in pieza2)
        {
            obj.SetActive(false);
        }
        
        foreach (GameObject obj in pieza3)
        {
            obj.SetActive(true);
        }
    }

    public void cambioPiezaMain()
    {
        camara.DOMove(new Vector3(x, y, x), time);

        foreach (GameObject obj in piezaMain)
        {
            obj.SetActive(true);
        }
        foreach (GameObject obj in pieza2)
        {
            obj.SetActive(false);
        }

        foreach (GameObject obj in pieza3)
        {
            obj.SetActive(false);
        }
    }
 
}
