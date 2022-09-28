using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FModPlay : MonoBehaviour
{
    private FMOD.Studio.EventInstance instance;

    [SerializeField] public FMODUnity.EventReference FmodEvent;

    [SerializeField] [Range(0, 3)] int SongStep = 0;

    private void Start()
    {
        SongStep = 0;
        instance = FMODUnity.RuntimeManager.CreateInstance(FmodEvent);
        instance.start();
    }

    public void NextSongStep()
    {
        SongStep++;
    }

    // Update is called once per frame
    void Update()
    {
        instance.setParameterByName("Puzzle counter", SongStep);
    }
}
