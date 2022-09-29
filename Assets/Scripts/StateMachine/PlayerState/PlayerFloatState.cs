using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Data/Machine/State/Player/Float", fileName = "PlayerFloatData")]
public class PlayerFloatState : PlayerState
{
    [SerializeField] EventHandleData gameoverEventData;

    [SerializeField] float floatSpeed;

    [SerializeField] ParticleSystem VFX;

    [SerializeField] Vector3 VFXOffset;

    [SerializeField] Vector3 floatPositionOffset;

    Vector3 floatPosition;

    public override void Enter()
    {
        base.Enter();
        gameoverEventData.DoSomeActtion();

        Vector3 temp = player.transform.position + new Vector3(player.transform.localScale.x * VFXOffset.x,VFXOffset.y);

        Instantiate(VFX, temp, Quaternion.identity, player.transform);

        floatPosition = player.transform.position + floatPositionOffset;
    }

    public override void LogicUpdate()
    {
        Transform playerTransform = player.transform;

        if (Vector3.Distance(playerTransform.position, floatPosition) > floatSpeed * Time.deltaTime)
        {
            playerTransform.position = Vector3.MoveTowards(playerTransform.position, floatPosition, floatSpeed * Time.deltaTime);
        }
        else
        {
            floatPosition += (Vector3)Random.insideUnitCircle;
        }
    }


}
