using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonUV : MonoBehaviour
{
    [SerializeField] private UnityEvent isPressing;
    [SerializeField] uvControllerGame UV;
    Animator animator;
    private bool attempt = true;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void ActiveUVLight()
    {
        isPressing.Invoke();
        if (UV.haveACard && !UV.ActiveUV && attempt)
        {
            animator.SetTrigger("pressButton");
            UV.LightUV();
            attempt = false;
        }
        else if (UV.haveACard && UV.ActiveUV && attempt)
        {
            animator.SetTrigger("desactiveButton");
            UV.DesactiveLightUV();
            attempt = false;
        }
        attempt = true;
    }
}
