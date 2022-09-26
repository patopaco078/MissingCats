using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DigitalDisplay : MonoBehaviour
{

    private TMPro.TMP_Text texto;
    private string codeSequence;
 
    // Start is called before the first frame update
    void Start()

    {
        
        codeSequence="";
        texto=GetComponent<TMPro.TMP_Text>();
        buttonspreced.ButtonPressed+=AddDigitToCodeSecuence;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void AddDigitToCodeSecuence(string digitalEntered)
    {
 if(codeSequence.Length <4)
 {
    switch(digitalEntered)
    {
        case "1":
        codeSequence+=1;
        texto.text=codeSequence;
        break;
        case "2":
        codeSequence+=2;
        texto.text=codeSequence;
        break;
        case "3":
        codeSequence+=3;
        texto.text=codeSequence;
        break;
        case "4":
        codeSequence+=4;
        texto.text=codeSequence;
        break;
        case "5":
        codeSequence+=5;
        texto.text=codeSequence;
        break;
        case "6":
        codeSequence+=6;
        texto.text=codeSequence;
        break;
        case "7":
        codeSequence+=7;
        texto.text=codeSequence;
        break;
        case "8":
        codeSequence+=8;
        texto.text=codeSequence;
        break;
        case "9":
        codeSequence+=9;
        texto.text=codeSequence;
        break;

   
    }
 }
  switch(digitalEntered)
  {
     case "Reiniciar":
        codeSequence="";
        texto.text=codeSequence;
        break;

        


  }
    
}
}
