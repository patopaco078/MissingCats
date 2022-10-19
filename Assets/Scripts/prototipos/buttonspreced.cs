using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class buttonspreced : MonoBehaviour
{

    public static event Action<string> ButtonPressed= delegate{};
    private string buttonName;
    // Start is called before the first frame update
    void Start()
    {
        buttonName=gameObject.name;
        gameObject.GetComponent<Button>().onClick.AddListener(buttonClicked);
    }

    // Update is called once per frame
   public void buttonClicked()
   {
    ButtonPressed(buttonName);
   }
}
