using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnTouch : MonoBehaviour
{
    public string name;
    public GameObject DesOBJ;
    public bool bullet;
    public GameObject FX;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        
        Debug.Log("Destoy");
        if (bullet)
        {
            Instantiate(FX, transform.position, transform.rotation);
        }
        Destroy(DesOBJ);
        
    }
}

