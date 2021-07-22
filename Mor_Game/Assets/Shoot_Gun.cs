using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot_Gun : MonoBehaviour
{
    public GameObject bulet;
    public Transform point;
    public float speed;

    public float time;
    public float delay;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (Input.GetMouseButton(0) && time > delay)
        {
            GameObject MyBullet = GameObject.Instantiate(bulet, point.position, point.rotation);
            Rigidbody MyRB = MyBullet.GetComponent<Rigidbody>();
            MyRB.velocity += transform.right * speed;
            time = 0;
        }
    }
}
