using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uvControllerGame : MonoBehaviour
{
    [SerializeField] private bool haveACard = false;
    private bool ActiveUV = false;
    [SerializeField] GameObject lightUV;
    [SerializeField] GameObject normalLight;

    Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
        lightUV.SetActive(false);
    }

    private void Update()
    {
        if(lightUV == null || normalLight == null)
        {
            Debug.Log("�REVISA LAS LUCES, TANTO LA UV COMO LA NORMAL DE ESTE SCRIPT!");
        }
        if (ActiveUV && (lightUV != null && normalLight != null))
        {
            animator.SetTrigger("active");
            normalLight.SetActive(false);
            lightUV.SetActive(true);
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
            ActiveUV = true;
        }
    }
}
