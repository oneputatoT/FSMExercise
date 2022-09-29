using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUp : MonoBehaviour
{
    [SerializeField] EventHandleData eventData;


    [SerializeField] ParticleSystem VFX;
    [SerializeField] AudioClip clip;

    private void OnTriggerEnter(Collider other)
    {
        Instantiate(VFX, transform.position, Quaternion.identity);

        eventData.DoSomeActtion();

        AudioManager.audioSource.PlayOneShot(clip);

        Destroy(gameObject);
    }
}
