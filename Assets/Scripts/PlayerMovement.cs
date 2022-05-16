using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed;
    public float gravity = 9.81f;
    public float jumpHeight = 3f;

    public Transform groundCheck;
    private bool isGrounded;
    private float groundDistance = 0.3f;
    public LayerMask groundMask;
    private bool isAbleToJump;

    private float horizontalInput;
    private float verticalInput;

    private CharacterController characterController;

    private Vector3 velocity;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        ReadInputs();
        CheckGround();
        Movement();
    }

    void CheckGround()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
    }

    void ReadInputs()
    {
        horizontalInput = Input.GetAxis(GameNames.Horizontal);
        verticalInput = Input.GetAxis(GameNames.Vertical);

        if (Input.GetButtonDown(GameNames.Jump))
        {
            isAbleToJump = true;
        }

        else
        {
            isAbleToJump = false;
        }
    }

    void Movement()
    {
        if(isGrounded && velocity.y < 0f)
        {
            velocity.y = 0f;
        }

        Vector3 forwardMovement = transform.forward * verticalInput;
        Vector3 rightMovement = transform.right * horizontalInput;

        Vector3 movementDirection = Vector3.ClampMagnitude(forwardMovement + rightMovement, 1f);
        characterController.Move(playerSpeed * Time.deltaTime * movementDirection);

        if(isAbleToJump && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * -gravity);
        }
        
        velocity.y -= gravity * Time.deltaTime;
        characterController.Move(velocity * Time.deltaTime);
    }
}