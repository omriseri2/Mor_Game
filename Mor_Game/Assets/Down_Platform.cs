using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Down_Platform : MonoBehaviour
{
    public bool x;
    public bool y;
    private void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
            x = true;
        }
        else
        {
            x = false;
        }
        if (x && y)
        {
            GetComponent<PolygonCollider2D>().isTrigger = true;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            y = true;
            
        }
    }
   
    private void OnTriggerExit2D(Collider2D collision)
    {
        y = false;
        if (collision.gameObject.tag == "Player")
        {
            GetComponent<PolygonCollider2D>().isTrigger = false;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        y = false;
    }
}
