using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ScaleZDoor : MonoBehaviour
{
    [SerializeField] private GameObject Door;
    private int puzzlesRoom2Completed;

    [SerializeField] private float Duration;

    private bool Done = false;



    void Update()
    {
        if (puzzlesRoom2Completed == 2)
        {
            if (Done == false)
            {
                ScaleZ();
                Done = true;
            }
        }
    }

    private void ScaleZ()
    {
        Door.transform.DOScaleZ(0, Duration);
    }

    public void MasUno()
    {
        puzzlesRoom2Completed++;
    }
}
