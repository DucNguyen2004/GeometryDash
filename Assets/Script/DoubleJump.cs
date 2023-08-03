using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleJump : MonoBehaviour
{
    
    Movement movement;
    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cube"))
        {
            movement = collision.gameObject.GetComponent<Movement>();
            print(movement);
            if (Input.GetMouseButton(0))
            {
                movement.Jump();
            }
        }

        //if (GameObject.FindWithTag("Cube"))
        //{
        //    movement = GetComponent<Movement>();
        //    if (Input.GetMouseButton(0))
        //    {

        //    }
            
        //}

        
    }
}
