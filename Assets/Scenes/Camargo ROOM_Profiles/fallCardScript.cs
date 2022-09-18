using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallCardScript : MonoBehaviour
{
    private Animator animator;
    [SerializeField] uvControllerGame UV;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            animator.SetTrigger("fall");
            UV.HaveACard();
        }
    }
}
