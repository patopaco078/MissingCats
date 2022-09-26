using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class CameraInteractiveTouchController : MonoBehaviour
{
    [SerializeField] Touch touchPlayer;
    //[SerializeField] PostProcessVolume VolumeEffectCamera;
    private bool isInteractingObcjet = false;
    //[SerializeField] Transform targetTransform;

    private GameObject actualGameObjectUsing;

    private void Start()
    {
        //VolumeEffectCamera.enabled = false;
    }

    private void Update()
    {
        if(Input.touchCount > 0)
        {
            if(Input.touchCount == 1)
            {
                touchPlayer = Input.GetTouch(0);
                Ray ray = Camera.main.ScreenPointToRay(touchPlayer.position);
                RaycastHit hit;
                if(Physics.Raycast(ray, out hit))
                {
                    if(hit.transform.tag == "Interactable" && touchPlayer.phase == TouchPhase.Ended && !isInteractingObcjet)
                    {
                        //VolumeEffectCamera.enabled = true;
                        isInteractingObcjet = true;
                        actualGameObjectUsing = hit.transform.gameObject;
                        hit.transform.gameObject.GetComponent<InteractiveObjectController>().IsUsing();
                    }
                    if (hit.transform.tag == "boton" && touchPlayer.phase == TouchPhase.Ended)
                    {
                        Debug.Log("1");
                        hit.transform.gameObject.GetComponent<ButtonUV>().ActiveUVLight();
                    }
                }
            }
        }
    }

    public void ExitUsingObject()
    {
        isInteractingObcjet = false;
        actualGameObjectUsing.GetComponent<InteractiveObjectController>().IsNotUsing();
    }
}
