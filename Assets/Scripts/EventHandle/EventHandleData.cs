using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(menuName = "Data/Event", fileName = "EventData")]
public class EventHandleData : ScriptableObject
{
    event Action handle;

    public void DoSomeActtion()
    {
        handle?.Invoke();
    }

    public void AddListener(System.Action action)
    {
        handle += action;
    }

    public void RemoveListener(System.Action action)
    {
        handle -= action;
    }


}
