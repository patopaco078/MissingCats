using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class iniciolibreria : MonoBehaviour
{
    [SerializeField] private UnityEvent doThis;


    // Start is called before the first frame update
    public GameObject imagen;
    private GameObject cambio;

    private GameObject luzApro;

    public GameObject luzVerde;
    
    public GameObject luzRoja;

    public GameObject imagenFlechas;
        
       public bool condicion =false;
    public bool condicion2 = false;


    public GameObject reiniciar;
       public GameObject fondo;

       public GameObject contraseña_texto;

public GameObject text1_1;
public GameObject text1_2;
public GameObject text1_3;


public GameObject text2_1;
public GameObject text2_2;
public GameObject text2_3;
public GameObject text2_4;
    public GameObject text2_5;



    public GameObject text3_1;
public GameObject text3_2;
public GameObject text3_3;
public GameObject text3_4;


public GameObject uno;
public GameObject dos;
public GameObject tres;
public GameObject cuatro;
public GameObject cinco;
public GameObject seis;
public GameObject siete;
public GameObject ocho;
public GameObject nueve;


public Button retornoContraseña;
    public Button retornoimagen;

    public TMPro.TMP_Text codigo;

public Button ingresar;
    void Awake()
    {
        retornoimagen.gameObject.SetActive(false);
        imagen.SetActive(false);
       text1_1.SetActive(false);
        text1_2.SetActive(false);
         text1_3.SetActive(false);
         
           
             text2_1.SetActive(false);
              text2_2.SetActive(false);
               text2_3.SetActive(false);
                text2_4.SetActive(false);
        text2_5.SetActive(false);

        text3_1.SetActive(false);
                    text3_2.SetActive(false);
                     text3_3.SetActive(false);
                      text3_4.SetActive(false);
                     

       uno.SetActive(false);
       dos.SetActive(false);
       tres.SetActive(false);
       cuatro.SetActive(false);
       cinco.SetActive(false);
       seis.SetActive(false);
       siete.SetActive(false);
       ocho.SetActive(false);
       nueve.SetActive(false);
        retornoContraseña.gameObject.SetActive(false);
        retornoContraseña.onClick.AddListener(Task3);
       ingresar.onClick.AddListener(Task2);
        retornoimagen.onClick.AddListener(Task);
       imagenFlechas.SetActive(false);
       codigo.gameObject.SetActive(false);
     
       fondo.SetActive(false);
       contraseña_texto.SetActive(false);
       ingresar.gameObject.SetActive(false);
       luzVerde.SetActive(false);
       luzRoja.SetActive(false);
       reiniciar.SetActive(false);
      
    }
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
      if(luzRoja.active==true)
      {
        luzVerde.SetActive(false);
      }
       if(luzVerde.active==true)
      {
        luzRoja.SetActive(false);
      }
       if (Input.GetMouseButtonDown(0)) {  
      Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);  
      
      RaycastHit hit;

      if (Physics.Raycast(ray, out hit)) {  

       if(condicion==false)
       {
     
        if(hit.transform.name.Equals("Box101-3"))
        {
            imagen.SetActive(true);
           cambio=text3_1;
                        retornoimagen.gameObject.SetActive(true);
           cambio.SetActive(true);
           condicion=true;
        }
        if(hit.transform.name.Equals("Box102-3"))
        {
            
            imagen.SetActive(true);
              cambio=text3_4;
                        retornoimagen.gameObject.SetActive(true);
           cambio.SetActive(true);
           condicion=true;
           
        }
        if(hit.transform.name.Equals("Box103-3"))
        {
            imagen.SetActive(true);
              cambio=text3_3;
                        retornoimagen.gameObject.SetActive(true);
           cambio.SetActive(true);
           condicion=true;
           
        }
        
        if(hit.transform.name.Equals("Box104-3"))
        {
            imagen.SetActive(true);
              cambio=text3_2;
                        retornoimagen.gameObject.SetActive(true);
           cambio.SetActive(true);
           condicion=true;
           
        }
        if(hit.transform.name.Equals("Box101-2"))
        {
            imagen.SetActive(true);
              cambio=text2_2;
                        retornoimagen.gameObject.SetActive(true);
           cambio.SetActive(true);
           condicion=true;
      
        }
       
        if(hit.transform.name.Equals("Box102-2"))
        {
            imagen.SetActive(true);
              cambio=text2_1;
                        retornoimagen.gameObject.SetActive(true);
           cambio.SetActive(true);
           condicion=true;
      
           
        }
       
        if(hit.transform.name.Equals("Box103-2"))
        {
            imagen.SetActive(true);
              cambio=text2_3;
                        retornoimagen.gameObject.SetActive(true);
           cambio.SetActive(true);
           condicion=true;
      
           
        }
        if(hit.transform.name.Equals("Box104-2"))
        {
            imagen.SetActive(true);
              cambio=text2_4;
                        retornoimagen.gameObject.SetActive(true);
           cambio.SetActive(true);
           condicion=true;
      
           
        }
                 if (hit.transform.name.Equals("Box105-2"))
                    {
                        imagen.SetActive(true);
                        cambio = text2_5;
                        retornoimagen.gameObject.SetActive(true);
                        cambio.SetActive(true);
                        condicion = true;


                    }
                    if (hit.transform.name.Equals("Box101-1"))
        {
            imagen.SetActive(true);
              cambio=text1_1;
                        retornoimagen.gameObject.SetActive(true);
           cambio.SetActive(true);
           condicion=true;
      
           
        }
         if(hit.transform.name.Equals("Box102-1"))
        {
            imagen.SetActive(true);
              cambio=text1_2;
                        retornoimagen.gameObject.SetActive(true);
           cambio.SetActive(true);
           condicion=true;
      
           
        }
         if(hit.transform.name.Equals("Box103-1"))
        {
            imagen.SetActive(true);
              cambio=text1_3;
                        retornoimagen.gameObject.SetActive(true);
           cambio.SetActive(true);
           condicion=true;
      
           
        }
        
        
         

          if(hit.transform.name.Equals("Clipboard"))
        {
            imagenFlechas.SetActive(true);
                        cambio = text3_4;
                        retornoimagen.gameObject.SetActive(true);
                  condicion=true;
                      cambio.SetActive(false);
           
      
           
        }

           if(hit.transform.name.Equals("locker"))
        {
                        if (condicion2 == false)
                        {
                            fondo.SetActive(true);
                        
                            cambio = text3_4;
                            retornoContraseña.gameObject.SetActive(true);
                            condicion = true;
                            cambio.SetActive(false);
                            codigo.gameObject.SetActive(true);

                            ingresar.gameObject.SetActive(true);
                            uno.SetActive(true);
                            dos.SetActive(true);
                            tres.SetActive(true);
                            cuatro.SetActive(true);
                            cinco.SetActive(true);
                            seis.SetActive(true);
                            siete.SetActive(true);
                            ocho.SetActive(true);
                            nueve.SetActive(true);
                            reiniciar.SetActive(true);
                        }
      
           
        }


       }
       
      } 
    }
    
}

void Task()
{
    imagen.SetActive(false);
    cambio.SetActive(false);
        retornoimagen.gameObject.SetActive(false);
    imagenFlechas.SetActive(false);
    condicion=false;
  
  
}

    void Task3()
    {


     
      
        condicion = false;
        contraseña_texto.SetActive(false);
        fondo.SetActive(false);
        codigo.gameObject.SetActive(false);

        ingresar.gameObject.SetActive(false);
        luzRoja.SetActive(false);
        luzVerde.SetActive(false);
        uno.SetActive(false);
        dos.SetActive(false);
        tres.SetActive(false);
        cuatro.SetActive(false);
        cinco.SetActive(false);
        seis.SetActive(false);
        siete.SetActive(false);
        ocho.SetActive(false);
        nueve.SetActive(false);

        reiniciar.SetActive(false);
    }


void Task2()
{
   if(codigo.text=="5763")
            {
              luzRoja.SetActive(false);
              luzVerde.SetActive(true);
            condicion2 = true;
            Task();
            doThis.Invoke();
        }
            else{
              luzRoja.SetActive(true);
            }
      
}

}
