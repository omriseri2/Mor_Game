using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_move : MonoBehaviour
{
    public Rigidbody2D RB;
    public float speed;
    public float Jump;
    public bool isGround;
    public float groundRadios;
    public LayerMask GroundMask;
    public Transform[] points;
    public bool S_Down;
    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        isGround = checkIsGrounded();
        if (Input.GetKey(KeyCode.A))
        {
            //RB.velocity += Vector2.left * speed * 0.1f;
            transform.position += new Vector3(-speed, 0);
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            //RB.velocity += Vector2.left * speed * 0.1f;
            transform.position += new Vector3(speed, 0);
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.W) && isGround == true)
        {
            //RB.velocity += Vector2.up * Jump * 0.1f;
            RB.AddForce(new Vector2(0, Jump), ForceMode2D.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.Space) && isGround == true)
        {
            //RB.velocity += Vector2.up * Jump * 0.1f;
            RB.AddForce(new Vector2(0, Jump), ForceMode2D.Impulse);
        }
        if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Rigidbody2D>().gravityScale = 5;
            S_Down = true;
        }
        else
        {
            GetComponent<Rigidbody2D>().gravityScale = 2;
            S_Down = false;
            //collider.isTrigger = false;
        }
    }
    bool checkIsGrounded()
    {
        for(int i=0;i < points.Length; i++)
        {
            if (Physics2D.OverlapCircle(points[i].position, groundRadios, GroundMask))
            {
                return true;
            }
        }
        return false;
    }
    public BoxCollider2D collider;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if(collision.gameObject.tag == "ground")
        //{
            //isGround = true;
        //}
        if (collision.gameObject.tag == "Next_Level")
        {
            Application.LoadLevel(Application.loadedLevel + 1);
        }
        if (collision.gameObject.tag == "Boss")
        {
            GameObject.FindGameObjectWithTag("MainCamera").gameObject.GetComponent<FollowPlayer>().boss = true;
        }
        if (collision.gameObject.tag == "LoadLevel")
        {
            Application.LoadLevel(Application.loadedLevel);
        }
        if (collision.gameObject.tag == "LoadLevel")
        {
            Application.LoadLevel(Application.loadedLevel);
        }
        //if (collision.gameObject.tag == "Platform" && S_Down == true)
        //{
        //    collider.isTrigger = true;
        //}
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        //if (collision.gameObject.tag == "ground")
        //{
        //isGround = false;
        //}
        //if (collision.gameObject.tag == "Platform")
        //{
        //    collider.isTrigger = false;
        //}
    }
}
