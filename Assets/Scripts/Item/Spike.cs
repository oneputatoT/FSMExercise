using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<PlayerController>(out PlayerController player))
        {
            player.GameOver();
        
        }
    }
}
