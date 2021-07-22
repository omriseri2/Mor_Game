using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trap_RB : MonoBehaviour
{
    public Rigidbody rb;
    public bool x;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            rb.isKinematic = false;
            x = true;
        }
    }
}
