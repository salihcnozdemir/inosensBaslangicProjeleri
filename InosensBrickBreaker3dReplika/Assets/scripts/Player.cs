using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool rightControl = false;
    public bool leftControl = false;
    public float moveSpeed=2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("right") && !rightControl)
        {
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        }

        else if (Input.GetKey("left") && !leftControl)
        {
            transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        }
       

    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "rightWall")
            rightControl = true;
        else if (collision.gameObject.tag == "leftWall")
            leftControl = true;
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "rightWall")
            rightControl = false;
        else if (collision.gameObject.tag == "leftWall")
            leftControl = false;
    }

   
}
