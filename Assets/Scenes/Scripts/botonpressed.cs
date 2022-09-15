using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
public class botonpressed : MonoBehaviour
{
    [Tooltip("True for rotation like valve (used for ramp/elevator only)")]
    public bool isValve = false;
    [Tooltip("SelfRotation speed of valve")]
    public float ValveSpeed = 10f;
    [Tooltip("If it isn't valve, it can be lever or button (animated)")]
    public bool isLever = false;
    [Tooltip("If it is false door can't be used")]

 
    public Transform RampObject;
    [Tooltip("Door can be opened")]
    
    public GameObject boton;
        


    numeros3D numeros;
    
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

    void Start()
    {
        numeros=GameObject.Find("GameManager").GetComponent<numeros3D>();
        anim = GetComponent<Animator>();
        startYPosition = RampObject.position.y;
        startQuat = transform.rotation;
        rampQuat = RampObject.rotation;
    }

    void Update()
    {
        if (!numeros.condicion)
        {
            if (Input.GetMouseButtonDown(0)) {  
      Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);  
      
      RaycastHit hit;

      if (Physics.Raycast(ray, out hit)) {  

   Debug.Log(hit.transform.name);
     
        if(hit.transform.tag.Equals("boton"))
        {
            
                // void in door script to open/close
                if (isLever) // animations
                {
             anim.SetBool("LeverUp", true);
       
                }
                else anim.SetTrigger("ButtonPress");
            }
      }
            }
        }
            else if (isValve && RampObject != null) // 3.valve
            {
                // changing value in script
                
            if (Input.GetMouseButtonDown(0)) {  
      Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);  
      
      RaycastHit hit;

      if (Physics.Raycast(ray, out hit)) {  

   
     
        if(hit.transform.tag.Equals("boton"))
        {
                    if (valveBool)
                    {
                        if (  current < max) current += speed * Time.deltaTime;
                        if (  current > min) current -= speed * Time.deltaTime;

                        if (current >= max)
                        {
                         
                            valveBool = false;
                        }
                        else if (current <= min)
                        {
                           
                            valveBool = false;
                        }
                    }

                }
      }
            }
            }
                else
                {
                    if ( current > min) current -= speed * Time.deltaTime;
                    if (current < max) current += speed * Time.deltaTime;
                    valveBool = true;
                }

                // using value on object
                transform.rotation = startQuat * Quaternion.Euler(0f, 0f, current * ValveSpeed);
                if (xRotation) RampObject.rotation = rampQuat * Quaternion.Euler(current, 0f, 0f); // I have a doubt in working correctly
                else if (yPosition) RampObject.position = new Vector3(RampObject.position.x, startYPosition + current, RampObject.position.z);
            }
        
            
            
        
    

    bool NearView() // it is true if you near interactive object
    {
        distance = Vector3.Distance(transform.position, Camera.main.transform.position);
        direction = transform.position - Camera.main.transform.position;
        angleView = Vector3.Angle(Camera.main.transform.forward, direction);
        if (angleView < 45f && distance < 2f) return true;
        else return false;
    }
}
