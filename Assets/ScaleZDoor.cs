using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ScaleZDoor : MonoBehaviour
{
    [SerializeField] private GameObject Door;
    [SerializeField] private int puzzlesRoom2Completed = 0;

    [SerializeField] private float Duration;

    [SerializeField] private bool Done = false;
    private void Start()
    {
        puzzlesRoom2Completed = 0;
    }


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
