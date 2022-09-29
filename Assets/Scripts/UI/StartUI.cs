using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartUI : MonoBehaviour
{
    [SerializeField] AudioClip startClip;
    [SerializeField] EventHandleData startData;


    void HideStartUI()
    {
        startData.DoSomeActtion();

        GetComponent<Canvas>().enabled = false;
        GetComponent<Animator>().enabled = false;
    }

    void PlayStartVoice()
    {
        AudioManager.audioSource.PlayOneShot(startClip);
    }
}
