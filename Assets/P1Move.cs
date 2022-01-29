using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1Move : StateMachineBehaviour
{
    // public float MovementSpeed = 1;
    // public float JumpForce = 1;

    // public const string RIGHT = "right";
    // public const string LEFT = "left";

    // private Rigidbody2D _rigidbody;
    
    // private void Start()
    // {
    //     _rigidbody = GetComponent<Rigidbody2D>();
    // }

    private void Update()
    {
        Input.GetKey(KeyCode.D);
        Input.GetKey(KeyCode.A);
        // if (Input.GetKey(KeyCode.D))
        // {
        //     transform.position += transform.right * (Time.deltaTime * MovementSpeed);
        // }
        // else if(Input.GetKey(KeyCode.A))
        // {
        //     transform.position -= transform.right * (Time.deltaTime * MovementSpeed);
        // }
        

        // if (Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y)  < 0.001f)
        // {
        //     _rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        // }

        
    }
}
