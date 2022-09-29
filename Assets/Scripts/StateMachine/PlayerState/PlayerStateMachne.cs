using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMachne : StateMachine
{
    public PlayerState[] allPlayerState;

    Animator aim;

    private void Awake()
    {
        aim = GetComponentInChildren<Animator>();

        dic = new Dictionary<System.Type, IState>();

        input = GetComponent<PlayerInput>();

        player = GetComponent<PlayerController>();

        //foreach (PlayerState playerState in allPlayerState)
        //{
        //    Debug.Log(playerState.GetType());
        //}

        foreach (PlayerState playerState in allPlayerState)
        {
            playerState.Initialize(aim, input,player,this);
            dic.Add(playerState.GetType(), playerState);
        }

    }

    private void Start()
    {
        SwitchOn(typeof(PlayerIdleState));
    }



}
