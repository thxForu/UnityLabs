using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    
    public float speed = 10f;
    public float gravity = -9.81f;
    public float jumpHeight = 2f;
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    
    private Vector3 _velocity;
    private bool _isGrounded;
    private float _increaseSpeed;

    private void Update()
    {
        _isGrounded = Physics.CheckSphere(groundCheck.position,groundDistance, groundMask);
        if (_isGrounded && _velocity.y < 0)
        {
            _velocity.y = -2f;
        }
        
        var x = Input.GetAxis("Horizontal");
        var z = Input.GetAxis("Vertical");
        _increaseSpeed = 0;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            _increaseSpeed = 10f;
        }

        var move = (transform.right * x + transform.forward * z);
        controller.Move(move * (speed+_increaseSpeed) * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && _isGrounded)
        {
            _velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }
        _velocity.y += gravity * Time.deltaTime;
        controller.Move(_velocity * Time.deltaTime);
    }
}
