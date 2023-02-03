using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerContro : MonoBehaviour
{
     public float speed = 0.001f;
    public float launchForce = 100;



    public Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         
        

         if (Input.GetKeyDown(KeyCode.Space)) {
            rb.useGravity = true;
            rb.AddForce(gameObject.transform.forward * launchForce);
        }

    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "TARGET")
        {
            col.gameObject.GetComponent<Renderer>().material.color = Color.red;
}
    }
}
