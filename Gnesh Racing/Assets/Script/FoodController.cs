using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FoodController : MonoBehaviour
{
    private PlayerController m_Pc;
    public GameObject Cheese;
    // Start is called before the first frame update
    void Start()
    {
        m_Pc = GameObject.Find("Player").GetComponent<PlayerController>();
        
    }

    // Update is called once per frame
    void Update()
    {
         if(Vector3.Distance(m_Pc.transform.position, transform.position) < 1.0f)
        {

             if(gameObject == Cheese)
            {
                m_Pc.ReceiveScore();
            }
            else 
            {
               m_Pc.ReceiveDamageScore();
            }
           
            Destroy(gameObject);
           

        }    
    }
}
