using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class LongClick : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private bool ispressed = false;
    private bool firstTime = true;
    private bool isPlaying;

    public UnityEvent DoWhile;
    public UnityEvent DoOneTime;
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
            firstTime = true; //To Reset First time
            DoWhile.Invoke();
            if (isPlaying == false)
            {
                DoOneTime.Invoke();
                isPlaying = true;
            }
        }
        if (ispressed == false)
        {
            if (firstTime == true)
            {
                isPlaying = false;
                firstTime = false;
                StopThis.Invoke();
            }
        }
    }
}