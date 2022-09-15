using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lockController : MonoBehaviour
{
    private int[] resultado;
    private int[] combinacionCorrecta;
    // Start is called before the first frame update
    private void Start()
    {
        combinacionCorrecta = new int[] { 3, 4, 8,2 };
        resultado = new int[]{1,1,1,1};
        Rotate.Rotated += CheckResults;
        
    }
    private void CheckResults(string Wheelname,int numero)
    {
        switch(Wheelname)
        {
            case "rueda1":
                resultado[0] = numero;
                break;
        
            case"rueda2":
                resultado[1] = numero;
            break;
        
        
            case"rueda3":
                resultado[2] = numero;
            break;

            case "rueda4":
                resultado[3] = numero;
                break;
        }
        if(resultado[0]==combinacionCorrecta[0]&&resultado[1]==combinacionCorrecta[1]&&resultado[2]==combinacionCorrecta[2] && resultado[3] == combinacionCorrecta[3])
        {
            Debug.Log("candado resuelto");
        }
    }
    private void OnDestroy()
    {
        Rotate.Rotated -= CheckResults;
    }
    // Update is called once per frame
   
}
