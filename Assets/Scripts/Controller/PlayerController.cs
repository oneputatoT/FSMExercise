using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] EventHandleData victoryEventData;


    PlayerInput input;
    PlayerGroundDetect groundDetect;

    public float MoveSpeed => Mathf.Abs(rd.velocity.x);

    public bool victory { get; private set; }

    public bool canDoubleJump { get; set; }

    public bool isGround => groundDetect.isGround;
    public bool isFall => rd.velocity.y < 0f && !isGround;

    public AudioSource audioSource;

    Rigidbody rd;

    private void Awake()
    {
        input = GetComponent<PlayerInput>();
        groundDetect = GetComponentInChildren<PlayerGroundDetect>();
        rd = GetComponent<Rigidbody>();
        audioSource = GetComponentInChildren<AudioSource>();
    }

    private void OnEnable()
    {
        input.EnablePlayerAtion();
        victoryEventData.AddListener(OnLevelCleared);
    }

    private void OnDisable()
    {
        victoryEventData.RemoveListener(OnLevelCleared);
    }

    private void OnGUI()
    {
        Rect rect = new Rect(50, 50, 200, 200);
        string str = "Current JumpBuffer : " + input.JumpBuffer;
        GUIStyle gUIStyle = new GUIStyle();

        gUIStyle.fontSize = 20;
        gUIStyle.fontStyle = FontStyle.Bold;

        GUI.Label(rect, str, gUIStyle);
    }

    public void Move(float velocity)
    {
        if (input.Move)
        {
            transform.localScale = new Vector3(input.Axis.x, 1f, 1f);
        }

        SetVelocityX(velocity * input.Axis.x);

    }

    public void SetVelocity(Vector2 veclocity)
    {
        rd.velocity = veclocity;
    }

    public void SetVelocityX(float velocity)
    {
        rd.velocity = new Vector3(velocity, rd.velocity.y);
    }

    public void SetVelocityY(float velocity)
    {
        rd.velocity = new Vector3(rd.velocity.x, velocity);
    }

    public void SetGravity(bool value)
    {
        rd.useGravity = value;
    }

    void OnLevelCleared()
    {
        victory = true;
    }

    public void GameOver()
    {
        input.DisablePlayerAction();
        rd.velocity = Vector3.zero;
        rd.detectCollisions = false;
        SetGravity(false);

        GetComponent<PlayerStateMachne>().SwitchOn(typeof(PlayerDefeatState));
    }

}
