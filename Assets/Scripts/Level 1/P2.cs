using UnityEngine;

public class P2 : MonoBehaviour
{
    public float MovementSpeed = 1;
    public float JumpForce = 1;

    public const string RIGHT = "right";
    public const string LEFT = "left";

    private Rigidbody2D _rigidbody;
    
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += transform.right * (Time.deltaTime * MovementSpeed);
        }
        else if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position -= transform.right * (Time.deltaTime * MovementSpeed);
        }
        

        if (Input.GetButtonDown("JumpAlt") && Mathf.Abs(_rigidbody.velocity.y)  < 0.001f)
        {
            _rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }
    }
    
}
