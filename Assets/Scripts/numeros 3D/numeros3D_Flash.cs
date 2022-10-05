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
    public float duracionSegundos;
    int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        RestarTheGame();
        transform = botones[0].transform;
        transform2 = transform.GetChild(0);
        r = transform2.GetComponent<Renderer>();
        material = r.material;
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
                    yield return new WaitForSeconds(duracionSegundos/2);
                    rend.material.color = material.color;
               
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

