using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class inicioImagenes : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject fondo;

    public GameObject pagina1;
       public GameObject pagina2;
    public GameObject imagen1_1;
        public GameObject imagen1_2;
            public GameObject imagen1_3;
                public GameObject imagen1_4;

                  public GameObject imagen2_1;
                  
                  public GameObject imagen2_2;
                  
                  public GameObject imagen2_3;
                  
                  public GameObject imagen2_4;
                  
                  public GameObject imagen2_5;
                  
                  public GameObject imagen2_6;

public GameObject imagen3_1;

public GameObject imagen3_2;


public GameObject imagen3_3;


public GameObject imagen3_4;


public GameObject imagen3_5;


public GameObject imagen3_6;


public GameObject imagen3_7;


public GameObject imagen3_8;

public GameObject imagen3_9;



               public Button regreso;
                 public bool condicion =false;
                 public bool condicion2=false;
                  public bool condicion3=false;
                       public bool condicion4=false;


                 public GameObject manager1;
                 public GameObject manager2;
                 public GameObject manager3;

    public GameObject ganaste;
    
    void Start()
    {
      Renderer render1=pagina1.GetComponent<Renderer>();
      render1.material.SetColor("_Color",Color.green);
      Renderer render2=pagina2.GetComponent<Renderer>();
      render2.material.SetColor("_Color",Color.yellow);
        fondo.SetActive(false);
        imagen1_1.SetActive(false);     
          imagen1_2.SetActive(false);        

          imagen1_3.SetActive(false);        
           
             imagen1_4.SetActive(false);  

             imagen2_1.SetActive(false);
             imagen2_2.SetActive(false);
             imagen2_3.SetActive(false);
             imagen2_4.SetActive(false);
             imagen2_5.SetActive(false);
             imagen2_6.SetActive(false);
             imagen3_1.SetActive(false);
             imagen3_1.SetActive(false);
             imagen3_2.SetActive(false);
             imagen3_3.SetActive(false);
             imagen3_4.SetActive(false);
             imagen3_5.SetActive(false);
             imagen3_6.SetActive(false);
             imagen3_7.SetActive(false);
             imagen3_8.SetActive(false);
             imagen3_9.SetActive(false);
             ganaste.SetActive(false);  
             regreso.gameObject.SetActive(false);

             manager1.SetActive(false);
             manager2.SetActive(false);
             manager3.SetActive(false);

        regreso.onClick.AddListener(Task1);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {  
      Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);  
      
      RaycastHit hit;

      if (Physics.Raycast(ray, out hit)) {  

       if(condicion==false)
       {
        if(condicion2==false)
        {
     
        if(hit.transform.name.Equals("Clipboard1"))
        {
          fondo.SetActive(true);
        imagen1_1.SetActive(true);     
          imagen1_2.SetActive(true);        

          imagen1_3.SetActive(true);        
           
             imagen1_4.SetActive(true);  
             regreso.gameObject.SetActive(true);
             condicion=true;
             manager1.SetActive(true);
        }
       }
       if(condicion3==false)
       {
       if(hit.transform.name.Equals("Clipboard2"))
        {
          fondo.SetActive(true);
         imagen2_1.SetActive(true);
             imagen2_2.SetActive(true);
             imagen2_3.SetActive(true);
             imagen2_4.SetActive(true);
             imagen2_5.SetActive(true);
             imagen2_6.SetActive(true);
             regreso.gameObject.SetActive(true);
             condicion=true;
             manager2.SetActive(true);
        }
       }
       if(condicion4==false)
       {
       if(hit.transform.name.Equals("Clipboard3"))
        {
          fondo.SetActive(true);

             imagen3_1.SetActive(true);
             imagen3_1.SetActive(true);
             imagen3_2.SetActive(true);
             imagen3_3.SetActive(true);
             imagen3_4.SetActive(true);
             imagen3_5.SetActive(true);
             imagen3_6.SetActive(true);
             imagen3_7.SetActive(true);
             imagen3_8.SetActive(true);
             imagen3_9.SetActive(true);
         
             regreso.gameObject.SetActive(true);
             condicion=true;
             manager3.SetActive(true);
        }
       }
      }
        }
    }
    }
    

    void Task1()
    {
       fondo.SetActive(false);
        imagen1_1.SetActive(false);     
          imagen1_2.SetActive(false);        

          imagen1_3.SetActive(false);        
           
             imagen1_4.SetActive(false);  
             ganaste.SetActive(false); 
             regreso.gameObject.SetActive(false);   
             condicion=false;  
             manager1.SetActive(false);
              imagen2_1.SetActive(false);
             imagen2_2.SetActive(false);
             imagen2_3.SetActive(false);
             imagen2_4.SetActive(false);
             imagen2_5.SetActive(false);
             imagen2_6.SetActive(false);
             manager2.SetActive(false);
             imagen2_1.SetActive(false);
             imagen2_2.SetActive(false);
             imagen2_3.SetActive(false);
             imagen2_4.SetActive(false);
             imagen2_5.SetActive(false);
             imagen2_6.SetActive(false);
             imagen3_1.SetActive(false);
             imagen3_1.SetActive(false);
             imagen3_2.SetActive(false);
             imagen3_3.SetActive(false);
             imagen3_4.SetActive(false);
             imagen3_5.SetActive(false);
             imagen3_6.SetActive(false);
             imagen3_7.SetActive(false);
             imagen3_8.SetActive(false);
             imagen3_9.SetActive(false);
             manager3.SetActive(false);
         
    }
}
