using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] float unbindJumpBuffTime;

    WaitForSeconds unbindTime;

    InputActions inputActions;

    public Vector2 Axis => inputActions.PlayerAction.Move.ReadValue<Vector2>();

    public bool Move => Axis.x != 0;


    public bool JumpBuffer;


    public bool Jump;


    public bool StopJump;

    private void Awake()
    {
        inputActions = new InputActions();

        unbindTime = new WaitForSeconds(unbindJumpBuffTime);
    }

    public void EnablePlayerAtion()
    {
        inputActions.PlayerAction.Enable();
        inputActions.PlayerAction.Jump.performed += i => Jump = true;

        inputActions.PlayerAction.Jump.canceled += delegate
        {
            Jump = false;
            //JumpBuffer = false;
        };

        inputActions.PlayerAction.Jump.performed += i => StopJump = false;
        inputActions.PlayerAction.Jump.canceled += i => StopJump = true;
    }

    public void DisablePlayerAction()
    {
        inputActions.PlayerAction.Disable();
    }

    public void SetJumpBuffer()
    {
        StopCoroutine(nameof(AutoJumpBuffer));
        StartCoroutine(nameof(AutoJumpBuffer));
    }


    IEnumerator AutoJumpBuffer()
    {
        JumpBuffer = true;
        yield return unbindTime;
        JumpBuffer = false;
    }
}
