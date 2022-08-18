using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DOTWall : MonoBehaviour
{
    [SerializeField] Transform wallTarget;
    [SerializeField] float height;
    [SerializeField] float Time;
    private float initialHeight;

    private void Awake()
    {
        initialHeight = wallTarget.position.y;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "RemoveWallActived")
        {
            wallTarget.DOMoveY(height, Time);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "RemoveWallActived")
        {
            wallTarget.DOMoveY(initialHeight, Time);
        }
    }
}
