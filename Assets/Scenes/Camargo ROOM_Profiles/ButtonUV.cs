using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonUV : MonoBehaviour
{
    [SerializeField] uvControllerGame UV;
    Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void ActiveUVLight()
    {
        if (UV.ActiveUV)
        {
            animator.SetTrigger("pressButton");
            UV.LightUV();
        }
    }
}
