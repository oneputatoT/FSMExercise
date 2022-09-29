using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictorItem : MonoBehaviour
{
    [SerializeField] EventHandleData eventData;

    [SerializeField] ParticleSystem VFX;
    [SerializeField] AudioClip clip;

    private void OnTriggerEnter(Collider other)
    {
        Instantiate(VFX, transform.position, Quaternion.identity);

        AudioManager.audioSource.PlayOneShot(clip);

        eventData.DoSomeActtion();

        Destroy(gameObject);
    }
}
