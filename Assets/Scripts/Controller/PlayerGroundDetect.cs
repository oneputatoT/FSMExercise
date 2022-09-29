using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGroundDetect : MonoBehaviour
{

    [SerializeField] float radius;

    [SerializeField] LayerMask mask;

    Collider[] colliderBuff = new Collider[1];
    public bool isGround =>Physics.OverlapSphereNonAlloc(transform.position, radius, colliderBuff, mask)!=0;

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;

        Gizmos.DrawWireSphere(transform.position, radius);
    }

}
