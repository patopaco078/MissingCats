using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class lockController : MonoBehaviour
{
    [SerializeField] private UnityEvent doThis;
    [SerializeField] private int numero1=3;
    [SerializeField] private int numero2=4;
    [SerializeField] private int numero3=8;
    [SerializeField] private int numero4=2;
    private int[] resultado;
    private int[] combinacionCorrecta;
    // Start is called before the first frame update
    private void Start()
    {
        combinacionCorrecta = new int[] { numero1, numero2, numero3, numero4 };
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
            doThis.Invoke();
        }
    }
    private void OnDestroy()
    {
        Rotate.Rotated -= CheckResults;
    }
    // Update is called once per frame
   
}
