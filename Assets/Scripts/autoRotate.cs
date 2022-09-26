using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class autoRotate : MonoBehaviour
{
    [SerializeField] private UnityEvent doThis;

    float elapsedTime;
    float timeLimit = 3f;

    WaitForSeconds waitForSeconds = new WaitForSeconds(5f);

    IEnumerator Start()
    {
        while (true)
        {
            doThis.Invoke();
            yield return waitForSeconds;
        }
    }
}
