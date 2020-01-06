using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeValueChange : MonoBehaviour
{
    private AudioSource music;
    private float musicVolume = 1f;

    void Start()
    {
        music = GetComponent<AudioSource>();
    }

    void Update()
    {
        music.volume = musicVolume;
    }

    public void SetVolume(float volume)
    {
        musicVolume = volume;
    }
}
