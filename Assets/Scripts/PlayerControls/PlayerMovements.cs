using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    public float walkSpeed = 3f; // Movement speed
    public float sprintSpeed = 8f;
    public float jumpHeight = 2f; // Jump height
    public float gravity = -9.81f; // Gravity force

    private CharacterController controller;
    [SerializeField]
    private Animator animator;

    private Vector3 velocity;
    private bool isGrounded;

    private void Awake()
    {
        controller = GetComponent<CharacterController>();
        animator = GetComponentInChildren<Animator>();
    }
    void Update()
    {
        // Check if the player is on the ground
        isGrounded = controller.isGrounded;

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f; // Reset vertical velocity when grounded
        }

        // Get input for movement
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        bool isSprinting = Input.GetKey(KeyCode.LeftShift);
        float speed = isSprinting ? sprintSpeed : walkSpeed;

        bool isWalking = moveX != 0 || moveZ != 0;

        animator.SetBool("isWalking", isWalking);

        Vector3 move = transform.right * moveX + transform.forward * moveZ;

        // Apply movement
        controller.Move(move * speed * Time.deltaTime);

        // Jumping
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        // Apply gravity
        velocity.y += gravity * Time.deltaTime;

        // Apply vertical velocity
        controller.Move(velocity * Time.deltaTime);
    }

    private void OnDisable()
    {
        if (controller != null)
        {
            if (!isGrounded)
            {
                velocity.y = 0;
                StartCoroutine(FallToTheGround());
            }
        }
    }

    private System.Collections.IEnumerator FallToTheGround()
    {
        while (!controller.isGrounded)
        {
            velocity.y += gravity * Time.deltaTime;
            controller.Move(velocity * Time.deltaTime);
            yield return null;
        }

        velocity.y = -2f;
    }
}
