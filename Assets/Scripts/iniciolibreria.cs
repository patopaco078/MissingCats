using UnityEngine;
using UnityEngine.UI;

public class iniciolibreria : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject imagen;
    private GameObject cambio;

    private GameObject luzApro;

    public GameObject luzVerde;
    
    public GameObject luzRoja;

    public GameObject imagenFlechas;
        
       public bool condicion =false;

       public TMPro.TMP_InputField barra;

       public GameObject fondo;

       public GameObject contraseña_texto;

public GameObject text1_1;
public GameObject text1_2;
public GameObject text1_3;
public GameObject text1_4;
public GameObject text1_5;
public GameObject text1_6;
public GameObject text2_1;
public GameObject text2_2;
public GameObject text2_3;
public GameObject text2_4;
public GameObject text2_5;
public GameObject text2_6;

public GameObject text3_1;
public GameObject text3_2;
public GameObject text3_3;
public GameObject text3_4;
public GameObject text3_5;
public GameObject text3_6;
public Button flecha;

public Button ingresar;
    void Awake()
    {

        imagen.SetActive(false);
       text1_1.SetActive(false);
        text1_2.SetActive(false);
         text1_3.SetActive(false);
          text1_4.SetActive(false);
           text1_5.SetActive(false);
            text1_6.SetActive(false);
             text2_1.SetActive(false);
              text2_2.SetActive(false);
               text2_3.SetActive(false);
                text2_4.SetActive(false);
                 text2_5.SetActive(false);
                  text2_6.SetActive(false);
                   text3_1.SetActive(false);
                    text3_2.SetActive(false);
                     text3_3.SetActive(false);
                      text3_4.SetActive(false);
                       text3_5.SetActive(false);
                        text3_6.SetActive(false);
       flecha.gameObject.SetActive(false);
       flecha.onClick.AddListener(Task);
       ingresar.onClick.AddListener(Task2);
       imagenFlechas.SetActive(false);
       barra.gameObject.SetActive(false);
       fondo.SetActive(false);
       contraseña_texto.SetActive(false);
       ingresar.gameObject.SetActive(false);
       luzVerde.SetActive(false);
       luzRoja.SetActive(false);
       barra.characterLimit=4;
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
     
        if(hit.transform.name.Equals("Box104-3"))
        {
            imagen.SetActive(true);
           cambio=text1_1;
                  flecha.gameObject.SetActive(true);
           cambio.SetActive(true);
           condicion=true;
        }
        if(hit.transform.name.Equals("Box105-3"))
        {
            
            imagen.SetActive(true);
              cambio=text1_4;
                  flecha.gameObject.SetActive(true);
           cambio.SetActive(true);
           condicion=true;
           
        }
        if(hit.transform.name.Equals("Box106-3"))
        {
            imagen.SetActive(true);
              cambio=text1_3;
                  flecha.gameObject.SetActive(true);
           cambio.SetActive(true);
           condicion=true;
           
        }
        if(hit.transform.name.Equals("Box107-3"))
        {
            imagen.SetActive(true);
              cambio=text1_5;
                  flecha.gameObject.SetActive(true);
           cambio.SetActive(true);
           condicion=true;
         
        }
        if(hit.transform.name.Equals("Box108-3"))
        {
            imagen.SetActive(true);
              cambio=text1_6;
                  flecha.gameObject.SetActive(true);
           cambio.SetActive(true);
           condicion=true;
           
        }
        if(hit.transform.name.Equals("Box109-3"))
        {
            imagen.SetActive(true);
              cambio=text1_2;
                  flecha.gameObject.SetActive(true);
           cambio.SetActive(true);
           condicion=true;
           
        }
        if(hit.transform.name.Equals("Box104-2"))
        {
            imagen.SetActive(true);
              cambio=text2_2;
                  flecha.gameObject.SetActive(true);
           cambio.SetActive(true);
           condicion=true;
      
        }
        if(hit.transform.name.Equals("Box105-2"))
        {
            imagen.SetActive(true);
              cambio=text2_5;
                  flecha.gameObject.SetActive(true);
           cambio.SetActive(true);
           condicion=true;
      
      
        }
        if(hit.transform.name.Equals("Box106-2"))
        {
            imagen.SetActive(true);
              cambio=text2_1;
                  flecha.gameObject.SetActive(true);
           cambio.SetActive(true);
           condicion=true;
      
           
        }
        if(hit.transform.name.Equals("Box107-2"))
        {
            imagen.SetActive(true);
              cambio=text2_6;
                  flecha.gameObject.SetActive(true);
           cambio.SetActive(true);
           condicion=true;
      
            
        }
        if(hit.transform.name.Equals("Box108-2"))
        {
            imagen.SetActive(true);
              cambio=text2_3;
                  flecha.gameObject.SetActive(true);
           cambio.SetActive(true);
           condicion=true;
      
           
        }
        if(hit.transform.name.Equals("Box109-2"))
        {
            imagen.SetActive(true);
              cambio=text2_4;
                  flecha.gameObject.SetActive(true);
           cambio.SetActive(true);
           condicion=true;
      
           
        }
        if(hit.transform.name.Equals("Box104-1"))
        {
            imagen.SetActive(true);
              cambio=text3_1;
                  flecha.gameObject.SetActive(true);
           cambio.SetActive(true);
           condicion=true;
      
           
        }
         if(hit.transform.name.Equals("Box105-1"))
        {
            imagen.SetActive(true);
              cambio=text3_2;
                  flecha.gameObject.SetActive(true);
           cambio.SetActive(true);
           condicion=true;
      
           
        }
         if(hit.transform.name.Equals("Box106-1"))
        {
            imagen.SetActive(true);
              cambio=text3_3;
                  flecha.gameObject.SetActive(true);
           cambio.SetActive(true);
           condicion=true;
      
           
        }
         if(hit.transform.name.Equals("Box107-1"))
        {
            imagen.SetActive(true);
              cambio=text3_4;
                  flecha.gameObject.SetActive(true);
           cambio.SetActive(true);
           condicion=true;
      
           
        }
         if(hit.transform.name.Equals("Box108-1"))
        {
            imagen.SetActive(true);
              cambio=text3_5;
                  flecha.gameObject.SetActive(true);
           cambio.SetActive(true);
           condicion=true;
      
           
        }
          if(hit.transform.name.Equals("Box109-1"))
        {
            imagen.SetActive(true);
              cambio=text3_6;
                  flecha.gameObject.SetActive(true);
           cambio.SetActive(true);
           condicion=true;
      
           
        }

          if(hit.transform.name.Equals("Clipboard"))
        {
            imagenFlechas.SetActive(true);
             cambio=text3_6;
                  flecha.gameObject.SetActive(true);
                  condicion=true;
                      cambio.SetActive(false);
           
      
           
        }

           if(hit.transform.name.Equals("locker"))
        {
            fondo.SetActive(true);
            contraseña_texto.SetActive(true);
             cambio=text3_6;
                  flecha.gameObject.SetActive(true);
                  condicion=true;
                      cambio.SetActive(false);
                       barra.gameObject.SetActive(true);
             ingresar.gameObject.SetActive(true);
             
      
           
        }


       }
       
      } 
    }
    
}

void Task()
{
    imagen.SetActive(false);
    cambio.SetActive(false);
    flecha.gameObject.SetActive(false);
    imagenFlechas.SetActive(false);
    condicion=false;
    contraseña_texto.SetActive(false);
    fondo.SetActive(false);
 barra.gameObject.SetActive(false);
   ingresar.gameObject.SetActive(false);
   luzRoja.SetActive(false);
   luzVerde.SetActive(false);
}


void Task2()
{
   if(barra.text=="5763")
            {
              luzRoja.SetActive(false);
              luzVerde.SetActive(true);
            }
            else{
              luzRoja.SetActive(true);
            }
      
}

}
