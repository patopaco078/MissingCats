using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using TMPro;


public class numeros3D : MonoBehaviour
{


    [Tooltip("True for rotation like valve (used for ramp/elevator only)")]
    public bool isValve = false;
    [Tooltip("SelfRotation speed of valve")]
    public float ValveSpeed = 10f;
    [Tooltip("If it isn't valve, it can be lever or button (animated)")]
    public bool isLever = false;
    [Tooltip("If it is false door can't be used")]
    public bool Locked = false;
    [Tooltip("The door for remote control")]
   Transform RampObject;
    [Tooltip("Door can be opened")]
    
    public GameObject boton;
      


    public bool xRotation = true;
    [Tooltip("True for vertical movenment by valve (if xRotation is false)")]
    public bool yPosition = false;
    public float max = 90f, min = 0f, speed = 5f;
    bool valveBool = true;
    float current, startYPosition;
    Quaternion startQuat, rampQuat;

    Animator anim;

    // NearView()
    float distance;
    float angleView;
    Vector3 direction;
    public List<GameObject> botones;

    public bool condicion=false;
      public List<GameObject> revolverBotones;

    public ParticleSystem ganaste;

      int counter=0;
    // Start is called before the first frame update
    void Start()
    {
        ganaste.Pause();
        RestarTheGame();
       
    }

    void RestarTheGame()
    {
        counter=0;
        revolverBotones=botones.OrderBy(a => Random.Range(0,100)).ToList();
        for(int i=1;i<11;i++)
        {
           
            revolverBotones[i-1].GetComponentInChildren<TMP_Text>().text = i.ToString();
         
            Transform trans= revolverBotones[i-1].transform;
            Transform hijo=trans.GetChild(0);
            Renderer rend= hijo.GetComponent<Renderer>();
            
           rend.material.color=Color.black;
        }
    }
public void pressButton(Transform boton)
{
    if(int.Parse(boton.GetComponentInChildren<TMP_Text>().text)-1==counter)
    {
      
        counter++;
          Renderer botonrenderer=boton.GetComponent<Renderer>();
          botonrenderer.material.color=Color.green;
          
          
          if(counter==10)
          {
            StartCoroutine(presentResult(true));
            condicion=true;
            ganaste.Play();
           
        
    }
    }
    else{
            StartCoroutine(presentResult(false));
          
    }

}

public IEnumerator presentResult(bool win)
{
    if(!win)
    {
        foreach(var boton in revolverBotones)
        {
              Transform trans= boton.transform;
            Transform hijo=trans.GetChild(0);
            Renderer rend= hijo.GetComponent<Renderer>();
            
           rend.material.color=Color.red;
           
            
            RestarTheGame();
        }
          
    }
    yield return new WaitForSeconds(2f);
  

}
    // Update is called once per frame
    void Update()
    {
         if(condicion==false)
         {
         if (Input.GetMouseButtonDown(0)) {  
      Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);  
      
      RaycastHit hit;

      if (Physics.Raycast(ray, out hit)) {  

   Debug.Log(hit.transform.name);
     
        if(hit.transform.tag.Equals("boton"))
        {
           
            Transform hijo=hit.transform.GetChild(0);
            RampObject=hijo.transform;
             startYPosition = RampObject.position.y;
      
        rampQuat = RampObject.rotation;
             startQuat=hijo.rotation;
                anim=hijo.GetComponent<Animator>();
               pressButton(hijo);
            
                // void in door script to open/close
                if (isLever) // animations
                {
               anim.SetBool("LeverUp", true);
             
                }
                else {anim.SetTrigger("ButtonPress");
              
                
               
                }
              
                  transform.rotation = startQuat * Quaternion.Euler(0f, 0f, current * ValveSpeed);
                if (xRotation) RampObject.rotation = rampQuat * Quaternion.Euler(current, 0f, 0f); // I have a doubt in working correctly
                else if (yPosition) RampObject.position = new Vector3(RampObject.position.x, startYPosition + current, RampObject.position.z);
            }
      }
      }
            

    }
       
            
                // using value on object
              
    }

  

}

