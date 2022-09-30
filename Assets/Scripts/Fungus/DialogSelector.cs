using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
using UnityEngine.Events;


public class DialogSelector: MonoBehaviour
{
    [SerializeField] private UnityEvent doThisWhenActivate;
    public Flowchart flowTest;
    private string mensaje;

    public void DialogBlocksActivation(string blockName)
    {
        flowTest.ExecuteBlock(blockName);
        mensaje = blockName;
        doThisWhenActivate.Invoke();
    }
    public void TestMethod() {
        Debug.Log(mensaje);
    }
}
