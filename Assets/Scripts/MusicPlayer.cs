using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : Singleton
{
    void Awake()
    {
        SetupSingleton();
    }

    void Start()
    {
        var audioSource = GetComponent<AudioSource>();
        if (!audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }
}
