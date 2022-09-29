using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneParamameterEvent<T> : ScriptableObject
{
    event System.Action<T> oneAction;

    public void DoSomething(T value)
    {
        oneAction?.Invoke(value);
    }

    public void AddListener(System.Action<T> value)
    {
        oneAction += value;
    }

    public void RemoveListener(System.Action<T> value)
    {
        oneAction -= value;
    }


}
