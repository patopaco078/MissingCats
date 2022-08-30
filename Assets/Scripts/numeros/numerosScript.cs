using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using TMPro;


public class numerosScript : MonoBehaviour
{

    public List<Button> botones;
      public List<Button> revolverBotones;

public GameObject ganaste;
      int counter=0;
    // Start is called before the first frame update
    void Start()
    {
        ganaste.SetActive(false);
        RestarTheGame();
    }

    void RestarTheGame()
    {
        counter=0;
        revolverBotones=botones.OrderBy(a => Random.Range(0,100)).ToList();
        for(int i=1;i<11;i++)
        {
            revolverBotones[i-1].GetComponentInChildren<TMP_Text>().text = i.ToString();
            revolverBotones[i-1].interactable=true;
           revolverBotones[i-1].image.color=Color.white;
        }
    }
public void pressButton(Button boton)
{
    if(int.Parse(boton.GetComponentInChildren<TMP_Text>().text)-1==counter)
    {
        counter++;
          boton.image.color= Color.green;
          boton.interactable=false;
          if(counter==10)
          {
            StartCoroutine(presentResult(true));
            ganaste.SetActive(true);
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
            boton.image.color=Color.red;
            boton.interactable=false;
            RestarTheGame();
        }
          
    }
    yield return new WaitForSeconds(2f);
  

}
    // Update is called once per frame
    void Update()
    {
        
    }

}
