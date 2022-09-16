using System.Collections;
using UnityEngine;

public class flasherolibreria : MonoBehaviour
{
   private GameObject selectedObject;

private GameObject actual;



private GameObject siguiente;
   public bool lookingAtObject=false;
   public bool flashingIn=true;
   public bool stratedflashing=false;

   public int redCol;
   public int greenCol;

   public int blueCol;
   Color colorInicial;
   
    // Update is called once per frame
    void Awake()
    {
        redCol=255;
        greenCol=255;
        blueCol=255;
    }
    void Update()
    {
        
       if(lookingAtObject==true)
       {

        selectedObject.GetComponent<Renderer>().material.color = new Color32((byte)redCol,(byte)greenCol,(byte)blueCol,150);

       }
    }
    void OnMouseOver()
    {
        selectedObject= GameObject.Find(camaralibreria.selectedObject);
        actual=selectedObject;
       
      
       if(selectedObject.tag=="libro")
       {

        lookingAtObject=true;
        if(stratedflashing==false)

        { siguiente=selectedObject;
        
        
            colorInicial=selectedObject.GetComponent<Renderer>().material.color;
            stratedflashing=true;
             if(selectedObject.tag=="libro"){
            StartCoroutine(FlashObject());}
        
        }
       }
    }

    void OnMouseExit()
    {if(selectedObject.tag=="libro")

        {
            siguiente=selectedObject;
            if(actual==siguiente)
            {
        stratedflashing=false;
        lookingAtObject=false;
        
        StopCoroutine(FlashObject());
         selectedObject.GetComponent<Renderer>().material.color = colorInicial;}
         else {
            selectedObject=actual;
            
         }}
    }

IEnumerator FlashObject()
{
    while(lookingAtObject==true)
    {
        yield return new WaitForSeconds(0.05f);
       
    }
}
}
