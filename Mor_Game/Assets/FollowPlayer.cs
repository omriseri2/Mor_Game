using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform playar;
    public float leroFactor = 0.05f;
    private void FixedUpdate()
    {
        Vector3 newPos = Vector3.Lerp(transform.position, playar.position, leroFactor);
        transform.position = new Vector3(newPos.x, newPos.y, -10);
    }
}
