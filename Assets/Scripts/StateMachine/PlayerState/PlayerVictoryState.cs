using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Data/Machine/State/Player/Victory", fileName = "PlayerVictoryData")]
public class PlayerVictoryState : PlayerState
{
    [SerializeField] AudioClip[] victoryClips;

    public override void Enter()
    {
        input.DisablePlayerAction();
        base.Enter();
        AudioManager.audioSource.PlayOneShot(victoryClips[Random.Range(0, victoryClips.Length)]);
    }
}
