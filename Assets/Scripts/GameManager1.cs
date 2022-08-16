using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager1 : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject pipesHolder;
    public GameObject[] Pipes;

    public GameObject Ganaste;

    public int CorrectedPipes=0;
    
    public Button button;

    [SerializeField]int TotalPipes =0;
    void Start()
    {
        button.onClick.AddListener(TaskP);
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
