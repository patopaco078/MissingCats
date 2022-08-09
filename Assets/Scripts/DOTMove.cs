using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DOTMove : MonoBehaviour
{
    [SerializeField] private Transform[] props0;
    [SerializeField] private Transform[] props1;
    [SerializeField] private Transform[] props2;
    [SerializeField] private Transform[] props3;


    [SerializeField] private float time;
    [SerializeField] private float x;
    [SerializeField] private float y;
    [SerializeField] private float z;

    public void Prop0Up()
    {
        for (int i = 0; i < props0.Length -1; i++)
        {
            Debug.Log(props0.Length);
            Debug.Log(i);
            props0[i].DOMove(new Vector3(x, y, z), time);
        }
    }
    public void Prop0Down()
    {
        for (int i = 0; i < props0.Length -1; i++)
        {
            props0[i].DOMove(new Vector3(x, 0, z), time);
        }
    }

    public void Prop1Up()
    {
        for (int i = 0; i < props1.Length -1; i++)
        {
            props1[i].DOMove(new Vector3(x, y, z), time);
        }
    }
    public void Prop1Down()
    {
        for (int i = 0; i < props1.Length -1; i++)
        {
            props1[i].DOMove(new Vector3(x, 0, z), time);
        }
    }
    public void Prop2Up()
    {
        for (int i = 0; i < props2.Length - 1; i++)
        {
            props2[i].DOMove(new Vector3(x, y, z), time);
        }
    }
    public void Prop2Down()
    {
        for (int i = 0; i < props2.Length - 1; i++)
        {
            props2[i].DOMove(new Vector3(x, 0, z), time);
        }
    }

    public void Prop3Up()
    {
        for (int i = 0; i < props3.Length - 1; i++)
        {
            props3[i].DOMove(new Vector3(x, y, z), time);
        }
    }
    public void Prop3Down()
    {
        for (int i = 0; i < props3.Length - 1; i++)
        {
            props3[i].DOMove(new Vector3(x, 0, z), time);
        }
    }
}
