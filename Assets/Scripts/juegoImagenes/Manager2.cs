using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Manager2 : MonoBehaviour
{
    // Start is called before the first frame update

public GameObject pagina;

    public GameObject pipesHolder;

    private inicioImagenes imagen;
    public GameObject[] Pipes;

    public GameObject Ganaste;

    public int CorrectedPipes=0;
    
    //public Button button;
    
    public ordenImagen2 imagen1;
    public ordenImagen2 imagen2;
    public ordenImagen2 imagen3;
    public ordenImagen2 imagen4;
     public ordenImagen2 imagen5;
      public ordenImagen2 imagen6;

    [SerializeField]int TotalPipes =0;
    
void Awake()
{
imagen=GameObject.Find("inicio").GetComponent<inicioImagenes>();
}
    void Start()
    {
        //button.onClick.AddListener(TaskP);
        Ganaste.SetActive(false);
        TotalPipes=pipesHolder.transform.childCount;
        Pipes= new GameObject[TotalPipes];

        for (int i=0;i<Pipes.Length;i++)
        {
  Pipes[i]=pipesHolder.transform.GetChild(i).gameObject;
        }
        imagen1=GameObject.Find("Button 2.1").GetComponent<ordenImagen2>();
imagen2=GameObject.Find("Button 2.2").GetComponent<ordenImagen2>();
imagen3=GameObject.Find("Button 2.3").GetComponent<ordenImagen2>();
imagen4=GameObject.Find("Button 2.4").GetComponent<ordenImagen2>();
imagen5=GameObject.Find("Button 2.5").GetComponent<ordenImagen2>();
imagen6=GameObject.Find("Button 2.6").GetComponent<ordenImagen2>();
    }

    // Update is called once per frame
  public  void CorrectMove()
    {
        CorrectedPipes+=1;
        if(CorrectedPipes==TotalPipes)
        {
            Ganaste.SetActive(true);
            imagen.condicion3=true;
            Renderer color=pagina.GetComponent<Renderer>();
            color.material.SetColor("_Color",Color.red);
            imagen1.condicion=true;
              imagen2.condicion=true;
                imagen3.condicion=true;
                  imagen4.condicion=true;
                   imagen5.condicion=true;
                    imagen6.condicion=true;
           
        }
    }

    public void WrongMove()
    {
        CorrectedPipes-=1;
    }

    void TaskP()
    {
SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex, LoadSceneMode.Single);
    }
}
