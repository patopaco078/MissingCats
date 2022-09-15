using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class verificaReloj : MonoBehaviour
{
    private int[] actual;
    private int[] resuelto;
    [SerializeField] private UnityEvent doThis;

    // Start is called before the first frame update
    private void Start()
    {
        resuelto = new int[] { 1, 6 };
        actual = new int[] { 1, 1,};
        transformHora.CambioHora += verificahora;

    }
    private void verificahora(string manecilla, int numero)
    {
        switch (manecilla)
        {
            case "hour":
                actual[0] = numero;
                break;

            case "minute":
                actual[1] = numero;
                break;
        }

        if (actual[0] == resuelto[0] && actual[1] == resuelto[1])
        {
            Debug.Log("reloj resuelto");
            doThis.Invoke();
        }

    }
        private void OnDestroy()
        {
            transformHora.CambioHora -= verificahora;
        }
    }
