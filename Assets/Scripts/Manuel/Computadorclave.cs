using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Computadorclave : MonoBehaviour
{
    [SerializeField] private UnityEvent doThis;


    // Start is called before the first frame update

    private GameObject cambio;

    private GameObject luzApro;

    public GameObject aprovado;

    public GameObject denegado;

   

    public bool condicion = false;
    public bool condicion2 = false;


    public GameObject reiniciar;
    public GameObject fondo;

    public GameObject codigo;

   

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
   

    public TMPro.TMP_Text codigo_texto;

    public Button ingresar;
    void Awake()
    {
       

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
        
        codigo.gameObject.SetActive(false);

        fondo.SetActive(false);
       
        ingresar.gameObject.SetActive(false);
     aprovado.SetActive(false);
       denegado.SetActive(false);
        reiniciar.SetActive(false);

    }
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (denegado.active == true)
        {
            aprovado.SetActive(false);
        }
        if (aprovado.active == true)
        {
            denegado.SetActive(false);
        }
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {

                if (condicion == false)
                {

                   




                }
                if (hit.transform.name.Equals("computer"))
                {
                    if (condicion2 == false)
                    {
                        fondo.SetActive(true);
                        codigo.SetActive(true);

                        retornoContraseña.gameObject.SetActive(true);


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

   

    void Task3()
    {




        condicion = false;
       codigo.SetActive(false);
        fondo.SetActive(false);
        codigo.gameObject.SetActive(false);
        retornoContraseña.gameObject.SetActive(false);

        ingresar.gameObject.SetActive(false);
        denegado.SetActive(false);
        aprovado.SetActive(false);
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
        if (codigo_texto.text == "7643")
        {
            denegado.SetActive(false);
            aprovado.SetActive(true);
            condicion2 = true;
            Task3();
            doThis.Invoke();
        }
        else
        {
            denegado.SetActive(true);
        }

    }

}
