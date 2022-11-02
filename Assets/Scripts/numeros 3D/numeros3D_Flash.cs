using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using TMPro;


public class numeros3D_Flash : MonoBehaviour
{



    public float timerLimit = 1.0f;
    private float timer = 0.0f;

    public List<GameObject> botones;

    public bool condicion = true;
    public List<GameObject> revolverBotones;
    public int clave;
    private char[] listaNumeros;
    private string numerosLetra;
    public int Tamaño_De_la_Clave;
    private Material material;
    private Transform transform;
    private Transform transform2;
    private Renderer r;
    public GameObject cambio;
    public GameObject botonprueba;
    public float duracionSegundos;
    int counter = 0;
    // Start is called before the first frame update
    private void Awake()
    {
        transform = botonprueba.transform;
        transform2 = transform.GetChild(0);
        r = transform2.GetComponent<Renderer>();
        material = r.material;
    }
    void Start()
    {
        RestarTheGame();
        
        numerosLetra = clave.ToString();
        listaNumeros = numerosLetra.ToArray<char>();
     
        StartCoroutine(condicionInicio());
    }

    void RestarTheGame()
    {
        counter = 0;
        revolverBotones = botones.OrderBy(a => Random.Range(0, 100)).ToList();
        for (int i = 0; i < 10; i++)
        {

            revolverBotones[i].GetComponentInChildren<TMP_Text>().text = i.ToString();

            Transform trans = revolverBotones[i].transform;
            Transform hijo = trans.GetChild(0);
            Renderer rend = hijo.GetComponent<Renderer>();

            rend.material.color = Color.black;
        }
    }

    public IEnumerator condicionFinal()
    {

        Transform t = cambio.transform;
        Transform t2 = t.GetChild(0);
        Renderer re = t2.GetComponent<Renderer>();
        re.material.color = Color.red;
        yield return new WaitForSeconds(3);
        StartCoroutine(condicionInicio());
    }
    public IEnumerator condicionInicio()
    {
        Transform t = cambio.transform;
        Transform t2 = t.GetChild(0);
        Renderer re = t2.GetComponent<Renderer>();
        re.material.color = Color.green;
        Transform trans1 = botones[0].transform;
        Transform hijo1 = trans1.GetChild(0);
        Renderer rend1 = hijo1.GetComponent<Renderer>();
        rend1.material.color = material.color;
        Transform trans2 = botones[1].transform;
        Transform hijo2 = trans2.GetChild(0);
        Renderer rend2 = hijo2.GetComponent<Renderer>();
        rend2.material.color = material.color;
        Transform trans3 = botones[2].transform;
        Transform hijo3 = trans3.GetChild(0);
        Renderer rend3 = hijo3.GetComponent<Renderer>();
        rend3.material.color = material.color;
        Transform trans4 = botones[3].transform;
        Transform hijo4 = trans4.GetChild(0);
        Renderer rend4 = hijo4.GetComponent<Renderer>();
        rend4.material.color = material.color;
        Transform trans5 = botones[4].transform;
        Transform hijo5 = trans5.GetChild(0);
        Renderer rend5 = hijo5.GetComponent<Renderer>();
        rend5.material.color = material.color;
        Transform trans6 = botones[5].transform;
        Transform hijo6 = trans6.GetChild(0);
        Renderer rend6 = hijo6.GetComponent<Renderer>();
        rend6.material.color = material.color;
        Transform trans7 = botones[6].transform;
        Transform hijo7 = trans7.GetChild(0);
        Renderer rend7 = hijo7.GetComponent<Renderer>();
        rend7.material.color = material.color;
        Transform trans8 = botones[7].transform;
        Transform hijo8 = trans8.GetChild(0);
        Renderer rend8 = hijo8.GetComponent<Renderer>();
        rend8.material.color = material.color;
        Transform trans9 = botones[8].transform;
        Transform hijo9 = trans9.GetChild(0);
        Renderer rend9 = hijo9.GetComponent<Renderer>();
        rend9.material.color = material.color;
        Transform trans10 = botones[9].transform;
        Transform hijo10 = trans10.GetChild(0);
        Renderer rend10 = hijo10.GetComponent<Renderer>();
        rend10.material.color = material.color;

        parpaderoNumeros();
        yield return new WaitForSeconds(duracionSegundos*5);
        StartCoroutine(condicionFinal());
    }
    public IEnumerator condicionFalse()

    {
        yield return new WaitForSeconds(4);
    }
        public void parpaderoNumeros()
    {
        if (listaNumeros.Length == Tamaño_De_la_Clave)
        {
            StartCoroutine(DelayInstantiate1());
        }
        else
        {
            throw new System.Exception("Cantidad de números en la clave Inválida");
        }
       
    }
    public IEnumerator DelayInstantiate1()
    {

        for (int i = 0; i < listaNumeros.Length; i++)
        {
            for (int j = 0; j < botones.Count; j++)
            {
                Debug.Log("aquí");
                if (botones[j].GetComponentInChildren<TMP_Text>().text == listaNumeros[i].ToString())
                {
                    Transform trans = botones[j].transform;
                    Transform hijo = trans.GetChild(0);
                    Renderer rend = hijo.GetComponent<Renderer>();

                    rend.material.color = Color.blue;
                   
               
                }

            }
            yield return new WaitForSeconds(duracionSegundos);
        }

       


    }

    public IEnumerator DelayInstantiate2(Transform actual)
    {
        Debug.Log("hola");
        Renderer rend = actual.GetComponent<Renderer>();
        rend.material.color = material.color;
        yield return new WaitForSeconds(3);
    }
        private void Update()
    {
        
   


    }

    

}

