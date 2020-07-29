using System.Collections;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 15f;

  
   

    void Update()
    {
        if (Input.GetKey("escape")) FindObjectOfType<GameManager>().Endgame();
        else if(rb.position.y<0) FindObjectOfType<GameManager>().Endgame();
    }

    // Update is called once per frame
    void FixedUpdate()
    {


        float x = Input.GetAxis("Horizontal") * Time.fixedDeltaTime * speed;
        rb.MovePosition(rb.position + Vector3.right * x);
       /* if (left) rb.AddForce(-sideforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        if (right) rb.AddForce(sideforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        

        left = false;
        right = false;*/
      
    }

}
        