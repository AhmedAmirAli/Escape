using UnityEngine;
using UnityEngine.SceneManagement;

public class P2_L3 : MonoBehaviour
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
        if (Input.GetKey(KeyCode.D))
        {
            transform.position -= transform.right * (Time.deltaTime * MovementSpeed);
        }
        else if(Input.GetKey(KeyCode.A))
        {
            transform.position += transform.right * (Time.deltaTime * MovementSpeed);
        }
        

        if (Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y)  < 0.001f)
        {
            _rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }

        if(_rigidbody.position.y < -5f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        }
    }
    
}

