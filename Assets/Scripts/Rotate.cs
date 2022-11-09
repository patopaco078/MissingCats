using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

using System;

public class Rotate : MonoBehaviour
{
    [SerializeField] private UnityEvent doThis;

    public static event Action <string, int> Rotated = delegate { };
    private bool coroutineAllowed;
    private int numero;

    // Start is called before the first frame update
    private void Start()
    {
        coroutineAllowed = true;
        numero = 1;
    }

    // Update is called once per frame
    private void OnMouseDown()
    {
        
        if (coroutineAllowed==true)
        {
            StartCoroutine("rotatewheel");
        }
        
    }

    private IEnumerator rotatewheel()
    {
        doThis.Invoke();
        coroutineAllowed = false;

        for(int i=1;i<=9;i++)
        {
            transform.Rotate(0f, -5f, 0f);
            yield return new WaitForSeconds(0.01f);
                
        }
        coroutineAllowed = true;
        numero += 1;
       

        if(numero>8)
        {
            numero = 1;
        }
        Rotated(name, numero);
        Debug.Log(numero);
    }
}
