using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Events;
public class GameManager3D : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject pipesHolder;
    public GameObject[] Pipes;

    [SerializeField] private UnityEvent doThis;


    pipesScript3D pipeS;

    bool condicion;

    public int CorrectedPipes=0;
    
    //public Button button;

    [SerializeField]int TotalPipes =0;
    void Start()
    {
        //button.onClick.AddListener(TaskP);
   
        TotalPipes=pipesHolder.transform.childCount;
        Pipes= new GameObject[TotalPipes];

        for (int i=0;i<Pipes.Length;i++)
        {
  Pipes[i]=pipesHolder.transform.GetChild(i).gameObject;
        }
    }

    void Update()
    {
        if(condicion==false)
        {
  if (Input.GetMouseButtonDown(0)) {  
  Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);  
      
      RaycastHit hit;

      if (Physics.Raycast(ray, out hit)) {  

      
        if(hit.transform.tag.Equals("Tuberia"))
        {
          pipeS=   hit.transform.GetComponent<pipesScript3D>();

          pipeS.Task2();
        }
    }
        }
        }
    }

    void Ganar()
    {
        doThis.Invoke();
    }

    // Update is called once per frame
  public  void CorrectMove()
    {
        CorrectedPipes+=1;
        if(CorrectedPipes==TotalPipes)
        {
            Ganar();
            condicion = true;
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
