using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerMovementController : MonoBehaviour
{
    #region Variables

    public float walkSpeed = 6f;
    public float sprintSpeed = 12f;
    public float rotationSpeed = 12f;
    public float gravity = 20f;

    private CharacterController controller;
    private Animator animator;

    private Vector3 velocity;

    // Input values (fed from input handler)
    private Vector2 moveInput;
    private bool sprintInput;

    #endregion

    private void Awake()
    {
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        
        Debug.Log("Current moveInput: " + moveInput);
        HandleMovement();
        // ApplyGravity();
        
        HandleMovement();
        // ApplyGravity();
    }

    // ====== CALLED BY INPUT HANDLER ======

    public void SetMovementInput(Vector2 input)
    {
        moveInput = input;
        Debug.Log("Movement input received: " + moveInput);
    }

    public void SetSprint(bool sprint)
    {
        sprintInput = sprint;
    }

    // ====== INTERNAL LOGIC ======

    void HandleMovement()
    {
        Vector3 input = new Vector3(moveInput.x, 0, moveInput.y);
        float speed01 = Mathf.Clamp01(input.magnitude);

        // Animator
        animator.SetFloat("MoveSpeed", speed01);

        if (speed01 > 0.1f)
        {
            Vector3 moveDir = input.normalized;

            float currentSpeed = sprintInput ? sprintSpeed : walkSpeed;

            Vector3 moveDirSPeed = moveDir * currentSpeed;
            controller.Move(moveDirSPeed * Time.deltaTime);

            Quaternion targetRot = Quaternion.LookRotation(moveDir);
            transform.rotation = Quaternion.Slerp(
                transform.rotation,
                targetRot,
                rotationSpeed * Time.deltaTime
            );
        }
    }

    void ApplyGravity()
    {
        velocity.y -= gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    
        if (controller.isGrounded)
        {
            velocity.y = -2f;
        }
    }
}