using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_move : MonoBehaviour
{
    public Rigidbody2D RB;
    public float speed;
    public float Jump;
    public bool isGround;
    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            //RB.velocity += Vector2.left * speed * 0.1f;
            transform.position += new Vector3(-speed, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            //RB.velocity += Vector2.left * speed * 0.1f;
            transform.position += new Vector3(speed, 0);
        }
        if (Input.GetKey(KeyCode.W) && isGround == true)
        {
            RB.velocity += Vector2.up * Jump * 0.1f;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "ground")
        {
            isGround = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            isGround = false;
        }
    }
}
