using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class Level2FinalEvent : MonoBehaviour
{
    [SerializeField] float TimeScape;
    [SerializeField] bool FinalEvent = false;
    [SerializeField] GameObject[] InitialsLight;
    [SerializeField] GameObject[] RedLights;
    [SerializeField] TextMeshProUGUI AlarmCount;

    [SerializeField] UnityEvent WhenFinalCount;

    private void Start()
    {
        for (int i = 0; i < RedLights.Length; i++)
        {
            RedLights[i].SetActive(false);
        }
        AlarmCount.text = "";
    }

    private void Update()
    {
        if (FinalEvent)
        {
            ActiveTramp();//borrar cuando este implementado de forma natural
            TimeScape -= Time.deltaTime;
            AlarmCount.text = "Corre te quedan: " + (int)TimeScape;

            if(TimeScape < 0)
            {
                AlarmCount.text = "¡BOOM!";
                WhenFinalCount.Invoke();
            }
        }
    }

    public void ActiveTramp()
    {
        FinalEvent = true;
        for(int i = 0; i < InitialsLight.Length; i++)
        {
            InitialsLight[i].SetActive(false);
        }
        for(int i = 0; i < RedLights.Length; i++)
        {
            RedLights[i].SetActive(true);
        }
    }

    public void EndTramp()
    {
        FinalEvent = false;
    }
}
