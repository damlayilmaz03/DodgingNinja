using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrier_action : MonoBehaviour
{
    
    Rigidbody rb;

    void Start()
    {
        rb= GetComponent<Rigidbody>();    
    }
    private void OnTriggerStay(Collider collision)
    {
        if (barrier_movement.random_num > 0)
        {
            rb.velocity = Vector3.back * 100f * Time.deltaTime;
        }

        
    }
    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.name == "character")
        {
            Debug.Log("karaktere çarptý");
            ninja_heal.heal_new_count--;
            ninja_heal.heart.fillAmount = ninja_heal.heal_new_count / ninja_heal.heal_count;
        }
    }
    void Update()
    {

        
        
        



    }
}
