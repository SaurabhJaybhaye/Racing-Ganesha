using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour
{
 
    public float speed; //player Speed
    public float rotationspeed; // player rotation speed
    public HudManager hudManager;
    private Stats m_Stats;

    private void Awake()
    {
        m_Stats = GetComponent<Stats>();
        hudManager.UpdateScoreText(m_Stats.Score);
    }
    void FixedUpdate()
    {
        // player Movement
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0, verticalInput);

        movement.Normalize();

        transform.Translate(movement * speed * Time.fixedDeltaTime);

       
    // direction change Movements
   
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(-Vector3.up * rotationspeed * Time.deltaTime);
        else if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(Vector3.up * rotationspeed * Time.deltaTime);

    }
    
  
// collider info
    void OnTriggerEnter(Collider collided) {
        if (collided.name == "Cube") { 
            //  Debug.Log("break");
            Application.OpenURL("https://www.jnec.org/");
            
        }

    }

    public void ReceiveScore()
    {
        m_Stats.UpdateScore(1);
        hudManager.UpdateScoreText(m_Stats.Score);
    }
    
     public void ReceiveDamageScore()
    {
        m_Stats.DamageScore(1);
        hudManager.UpdateScoreText(m_Stats.Score);
    }

}
