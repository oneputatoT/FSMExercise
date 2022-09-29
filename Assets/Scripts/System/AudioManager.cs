using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioSource audioSource { get; private set; }

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
}
