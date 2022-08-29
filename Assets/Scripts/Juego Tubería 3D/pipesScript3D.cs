using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pipesScript3D : MonoBehaviour
{
    RectTransform recta;

       
    
 GameManager3D gameManager1;
 Transform transformar;
    public float[] correctRotation;
    int PossibleRotation=1;
   [SerializeField] bool isPlaced=false;
    // Start is called before the first frame update
  float[] rotations = {0,90,180,270};

void Awake()
{
  transformar=GetComponent<Transform>();
 gameManager1=GameObject.Find("GameManager").GetComponent<GameManager3D>();
}
    void Start()
    {
      PossibleRotation=correctRotation.Length;
      
        int rand = Random.Range(0, rotations.Length);
      
  transformar.eulerAngles = new Vector3(0,0,rotations[rand]);
  if(PossibleRotation>1)
  {
   if(transformar.transform.eulerAngles.z==correctRotation[0] || transformar.transform.eulerAngles.z==correctRotation[1])
      {
        isPlaced=true;
        gameManager1.CorrectMove();
      }
      
      
  }
  else{
        if(transformar.transform.eulerAngles.z==correctRotation[0])
      {
        isPlaced=true;
          gameManager1.CorrectMove();
      }
      }
    }

    

    void Update()
    {
        
    }
 
 public void Task2()
 { 
   transformar.Rotate(new Vector3(0,0,90));
   
   Debug.Log(transform.eulerAngles.z);
      if(PossibleRotation>1)
  {
      if(transformar.transform.eulerAngles.z==correctRotation[0] || transformar.transform.eulerAngles.z==correctRotation[1] && isPlaced==false)
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
    if(transformar.transform.eulerAngles.z==correctRotation[0] && isPlaced==false)
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
