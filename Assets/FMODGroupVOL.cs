using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FMODGroupVOL : MonoBehaviour
{
    private FMOD.Studio.VCA VCAController;
    public string VCAName;

    private Slider VolSlider;
    void Start()
    {
        VCAController = FMODUnity.RuntimeManager.GetVCA("vca:/" + VCAName);
        VolSlider = GetComponent<Slider>();
    }

    // Update is called once per frame
    public void UpdateVCAVol(float Vol)
    {
        VCAController.setVolume(Vol);
    }    
}
