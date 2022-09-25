using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class cambioHoraTrigger : MonoBehaviour
{
    [SerializeField] private UnityEvent doThis;
    // Start is called before the first frame update
    private void OnMouseDown()
    {
        doThis.Invoke();
    }
}
