using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   public float speed;
    public float rotationspeed;

    
    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0, verticalInput);

        movement.Normalize();

        transform.Translate(movement * speed * Time.fixedDeltaTime);

       

   
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(-Vector3.up * rotationspeed * Time.deltaTime);
        else if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(Vector3.up * rotationspeed * Time.deltaTime);

    }
    
  

    void OnTriggerEnter(Collider collided) {
        if (collided.tag == "break") { 
             Debug.Log("break");

        }
    }
}
