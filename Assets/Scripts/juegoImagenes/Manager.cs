using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Manager : MonoBehaviour
{
    // Start is called before the first frame update

public GameObject pagina;

    public GameObject pipesHolder;

    private inicioImagenes imagen;
    public GameObject[] Pipes;

    public GameObject Ganaste;

    public int CorrectedPipes=0;

    public ordenImagen1 imagen1;
    public ordenImagen1 imagen2;
    public ordenImagen1 imagen3;
    public ordenImagen1 imagen4;
    
    //public Button button;

    [SerializeField]int TotalPipes =0;
    
void Awake()
{
imagen=GameObject.Find("inicio").GetComponent<inicioImagenes>();
imagen1=GameObject.Find("Button 1.1").GetComponent<ordenImagen1>();
imagen2=GameObject.Find("Button 1.2").GetComponent<ordenImagen1>();
imagen3=GameObject.Find("Button 1.3").GetComponent<ordenImagen1>();
imagen4=GameObject.Find("Button 1.4").GetComponent<ordenImagen1>();
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
    }

    // Update is called once per frame
  public  void CorrectMove()
    {
        CorrectedPipes+=1;
        if(CorrectedPipes==TotalPipes)
        {
            Ganaste.SetActive(true);
            imagen.condicion2=true;
            Renderer color=pagina.GetComponent<Renderer>();
            color.material.SetColor("_Color",Color.red);
            imagen1.condicion=true;
              imagen2.condicion=true;
                imagen3.condicion=true;
                  imagen4.condicion=true;
           
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
