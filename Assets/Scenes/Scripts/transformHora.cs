using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class transformHora : MonoBehaviour
{
    //[SerializeField]
    //KeyCode cambioHora;
    
    string hcorrecta=("6:05");


    public static event Action<string, int> CambioHora = delegate { };
    

    float counter = -30f;
    private int numero;

    // Start is called before the first frame update
    void Start()
    {
        numero = 12;
    }
 // Update is called once per frame
    void Update()
    {
        //var q = Quaternion.AngleAxis(24, vector3.left);
       // if (Input.GetKeyDown(cambioHora) )
       // {
         //   GetComponent<Rigidbody>().rotation = Quaternion.Euler(counter, 0f, 0f);
       //     counter += 30f;
            //Debug.Log(counter);
       // }

      //  if(GetComponent<Rigidbody>().rotation == Quaternion.Euler(hcorrecta,0f, 0f ) && gano==false)
      //  {
       //     Debug.Log("posicion correcta");
        //    gano = true;
        //}


       
    }
    public void MoveHour()
    {
        GetComponent<Rigidbody>().rotation = Quaternion.Euler( counter,0f, 0f );
        counter -= 30f;
        numero += 1;
        if (numero >12)
        {
            numero = 1;
        }
        
        CambioHora(name, numero);
        Debug.Log(numero);
    }
}
