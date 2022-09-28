using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FModPlay : MonoBehaviour
{
    [SerializeField] public FMODUnity.EventReference FmodEvent;


    public void FmodFollowPlay()
    {
        FMODUnity.RuntimeManager.PlayOneShotAttached(FmodEvent, gameObject);
    }

    public void FmodPlay()
    {
        FMODUnity.RuntimeManager.PlayOneShot(FmodEvent, transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
