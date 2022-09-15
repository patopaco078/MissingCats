using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Manager3 : MonoBehaviour
{
    // Start is called before the first frame update

public GameObject pagina;

    public GameObject pipesHolder;

    private inicioImagenes imagen;
    public GameObject[] Pipes;

    public GameObject Ganaste;

    public int CorrectedPipes=0;
    
    //public Button button;
    
    public ordenImagen3 imagen1;
    public ordenImagen3 imagen2;
    public ordenImagen3 imagen3;
    public ordenImagen3 imagen4;
     public ordenImagen3 imagen5;
      public ordenImagen3 imagen6;
            public ordenImagen3 imagen7;
                  public ordenImagen3 imagen8;
                        public ordenImagen3 imagen9;

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
        imagen1=GameObject.Find("Button 3.1").GetComponent<ordenImagen3>();
imagen2=GameObject.Find("Button 3.2").GetComponent<ordenImagen3>();
imagen3=GameObject.Find("Button 3.3").GetComponent<ordenImagen3>();
imagen4=GameObject.Find("Button 3.4").GetComponent<ordenImagen3>();
imagen5=GameObject.Find("Button 3.5").GetComponent<ordenImagen3>();
imagen6=GameObject.Find("Button 3.6").GetComponent<ordenImagen3>();
imagen7=GameObject.Find("Button 3.7").GetComponent<ordenImagen3>();
imagen8=GameObject.Find("Button 3.8").GetComponent<ordenImagen3>();
imagen9=GameObject.Find("Button 3.9").GetComponent<ordenImagen3>();
    }

    // Update is called once per frame
  public  void CorrectMove()
    {
        CorrectedPipes+=1;
        if(CorrectedPipes==TotalPipes)
        {
            Ganaste.SetActive(true);
            imagen.condicion4=true;
            Renderer color=pagina.GetComponent<Renderer>();
            color.material.SetColor("_Color",Color.red);
            imagen1.condicion=true;
              imagen2.condicion=true;
                imagen3.condicion=true;
                  imagen4.condicion=true;
                   imagen5.condicion=true;
                    imagen6.condicion=true;
                     imagen7.condicion=true;
                      imagen8.condicion=true;
                       imagen9.condicion=true;
           
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
