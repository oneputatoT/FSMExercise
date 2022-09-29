using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotate : MonoBehaviour
{
    [SerializeField] Vector3 rotationAxis;

    private void Update()
    {
        transform.Rotate(rotationAxis * Time.deltaTime);
    }
}
