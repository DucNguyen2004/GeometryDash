using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperJump : MonoBehaviour
{
    Movement movement;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cube"))
        {
            print("touch");
            movement = collision.gameObject.GetComponent<Movement>();          
            movement.SuperJump();
            
        }

    }
}
