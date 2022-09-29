using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarPickUp : MonoBehaviour
{

    [SerializeField] float recoverTime = 3.0f;

    [SerializeField]ParticleSystem pickUpVFX;

    [SerializeField] AudioClip starAudioClip;

    AudioSource starAudio;
    MeshRenderer mesh;
    BoxCollider col;

    WaitForSeconds recoverSeconds;

    private void Awake()
    {
        mesh = GetComponentInChildren<MeshRenderer>();
        col = GetComponent<BoxCollider>();
        recoverSeconds = new WaitForSeconds(recoverTime);
        starAudio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<PlayerController>(out PlayerController player))
        {
            player.canDoubleJump = true;

            mesh.enabled = false;
            col.enabled = false;
            starAudio.PlayOneShot(starAudioClip);
            Instantiate(pickUpVFX, transform.position, Quaternion.identity);

            //ÏûºÄ×ÊÔ´
            //Invoke(nameof(Recover), recoverTime);

            StartCoroutine(nameof(Next));
        }
    }

    void Recover()
    {
        mesh.enabled = true;
        col.enabled = true;
    }

    IEnumerator Next()
    {
        yield return recoverSeconds;

        Recover();
    }
}
