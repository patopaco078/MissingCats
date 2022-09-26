using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uvControllerGame : MonoBehaviour
{
    [SerializeField] public bool haveACard = false;
    private bool activeUV = false;
    [SerializeField] GameObject lightUV;
    [SerializeField] GameObject normalLight;

    public bool ActiveUV { get => activeUV;}

    private void Start()
    {
        lightUV.SetActive(false);
    }

    private void Update()
    {
        if(lightUV == null || normalLight == null)
        {
            Debug.Log("¡REVISA LAS LUCES, TANTO LA UV COMO LA NORMAL DE ESTE SCRIPT!");
        }
        if (ActiveUV && (lightUV != null && normalLight != null))
        {
            normalLight.SetActive(false);
            lightUV.SetActive(true);
        }
        if(!ActiveUV && lightUV.activeSelf)
        {
            normalLight.SetActive(true);
            lightUV.SetActive(false);
        }
    }

    public void HaveACard()
    {
        haveACard = true;
    }

    public void LightUV()
    {
        if (haveACard)
        {
            activeUV = true;
        }
    }

    public void DesactiveLightUV()
    {
        if (haveACard)
        {
            activeUV = false;
        }
    }
}
