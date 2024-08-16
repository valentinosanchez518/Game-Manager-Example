﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundManager : MonoBehaviour
{
    public static soundManager Instance;
    public AudioSource sourceSFX;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = this;
        }
        DontDestroyOnLoad(this);
    }

    public void PlaySound(AudioClip clip)
    {
        sourceSFX.PlayOneShot(clip);
    }
}
