using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager3D2 : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject pipesHolder;
    public GameObject[] Pipes;

    public ParticleSystem Ganaste;

    Imagenes3D pipeS;

    public int CorrectedPipes=0;
    
    //public Button button;

    [SerializeField]int TotalPipes =0;
    void Start()
    {
        //button.onClick.AddListener(TaskP);
        Ganaste.Pause();
        TotalPipes=pipesHolder.transform.childCount;
        Pipes= new GameObject[TotalPipes];

        for (int i=0;i<Pipes.Length;i++)
        {
  Pipes[i]=pipesHolder.transform.GetChild(i).gameObject;
        }
    }

    void Update()
    {
  if (Input.GetMouseButtonDown(0)) {  
  Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);  
      
      RaycastHit hit;

      if (Physics.Raycast(ray, out hit)) {  

      
        if(hit.transform.tag.Equals("cuadro"))
        {
          pipeS=   hit.transform.GetComponent<Imagenes3D>();

          pipeS.Task2();
        }
    }
        }
    }

    // Update is called once per frame
  public  void CorrectMove()
    {
        CorrectedPipes+=1;
        if(CorrectedPipes==TotalPipes)
        {
            Ganaste.Play();
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
