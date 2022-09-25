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

    public void cambioPieza1()
    {
        camara.DOMove(new Vector3(-15, y, z), time);
    }
    public void cambioPieza2()
    {
        camara.DOMove(new Vector3(x, y, 15), time);
    }

    public void cambioPiezaMain()
    {
        camara.DOMove(new Vector3(x, y, x), time);
    }
 
}
