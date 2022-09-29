using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallDestory : MonoBehaviour
{
    [SerializeField] EventHandleData eventDate;

    private void OnEnable()
    {
        eventDate.AddListener(DestroyItself);
    }

    private void OnDisable()
    {
        eventDate.RemoveListener(DestroyItself);
    }

    void DestroyItself()
    {
        Destroy(gameObject);
    }
}
