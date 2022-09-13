using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
using Collision = UnityEngine.Collision;

public class DialogSelector: MonoBehaviour
{
    public Flowchart flowTest;

    private void OnCollisionStay(Collision collision)
    {
        flowTest.ExecuteBlock("Reloj Antiguo");
    }
/*
    private void OnTriggerEnter(Collider other)
    {
        flowTest.ExecuteBlock("Reloj Antiguo");
    }
*/
    public void TestMethod(string mensaje) {
        Debug.Log(mensaje);
    }
}
