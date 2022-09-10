using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class transporte1_2 : MonoBehaviour
{

    public Button boton;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Task()
    {
        SceneManager.LoadScene("prueba inventario 2");
    }
}
