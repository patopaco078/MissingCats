using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pipesScript : MonoBehaviour
{
    RectTransform recta;
    Button boton;
 GameManager1 gameManager1;
    public float[] correctRotation;
    int PossibleRotation=1;
   [SerializeField] bool isPlaced=false;
    // Start is called before the first frame update
  float[] rotations = {0,90,180,270};

void Awake()
{
  boton=GetComponent<Button>();
 gameManager1=GameObject.Find("GameManager").GetComponent<GameManager1>();
}
    void Start()
    {
      PossibleRotation=correctRotation.Length;
        recta=GetComponent<RectTransform>();
        int rand = Random.Range(0, rotations.Length);
if(boton!=null)
{
        boton.onClick.AddListener(Task);
}
      
  recta.eulerAngles = new Vector3(0,0,rotations[rand]);
  if(PossibleRotation>1)
  {
   if(recta.transform.eulerAngles.z==correctRotation[0] || recta.transform.eulerAngles.z==correctRotation[1])
      {
        isPlaced=true;
        gameManager1.CorrectMove();
      }
      
      
  }
  else{
        if(recta.transform.eulerAngles.z==correctRotation[0] || recta.transform.eulerAngles.z==correctRotation[1])
      {
        isPlaced=true;
          gameManager1.CorrectMove();
      }
      }
    }

    void Task()
    {
      recta.Rotate(new Vector3(0,0,90));
      if(PossibleRotation>1)
  {
      if(recta.transform.eulerAngles.z==correctRotation[0] || recta.transform.eulerAngles.z==correctRotation[1] && isPlaced==false)
      {
        isPlaced=true;
          gameManager1.CorrectMove();
      }
      else if(isPlaced==true){

isPlaced=false;
gameManager1.WrongMove();
      }
    } else
    {
    if(recta.transform.eulerAngles.z==correctRotation[0] && isPlaced==false)
      {
        isPlaced=true;
        gameManager1.CorrectMove();
      }
      else if(isPlaced==true){

isPlaced=false;
gameManager1.WrongMove();
      }
    }
    }
 
}
