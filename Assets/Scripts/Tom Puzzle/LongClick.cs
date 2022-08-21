using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class LongClick : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    bool ispressed = false;

    public UnityEvent DoWhile;
    public UnityEvent StopThis;
    public void OnPointerDown(PointerEventData eventData)
    {
        ispressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        ispressed = false;
    }

    private void Update()
    {
        if (ispressed == true)
        {
            DoWhile.Invoke();
        }
        if (ispressed == false)
        {
            StopThis.Invoke();
        }
    }
}