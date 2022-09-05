using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MazeBoxCompleted : MonoBehaviour
{
    [SerializeField] private UnityEvent doThis;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            {
                doThis.Invoke();
            }
        }
    }
}
