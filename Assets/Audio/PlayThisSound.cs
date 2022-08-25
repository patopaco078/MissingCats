using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayThisSound : MonoBehaviour
{
    [SerializeField] private AudioClip[] SFXList;

    private AudioSource audioSource;
    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void Update()
    {
        if (Input.GetKey(KeyCode.M))
        {
            AudioClip clip = SFXList[UnityEngine.Random.Range(0, SFXList.Length)];
            audioSource.volume = Random.Range(0.9f, 1f);
            audioSource.pitch = Random.Range(0.9f, 1f);
            audioSource.PlayOneShot(clip);
        }
    }

    public void Play1Shot()
    {
        AudioClip clip = SFXList[UnityEngine.Random.Range(0, SFXList.Length)];
        audioSource.volume = Random.Range(0.9f, 1f);
        audioSource.pitch = Random.Range(0.9f, 1f);
        audioSource.PlayOneShot(clip);
    }
}
