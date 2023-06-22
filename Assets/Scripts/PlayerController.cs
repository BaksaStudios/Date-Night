using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] private float jumpSpeed;
    [SerializeField] private float maxSpeed;
    [SerializeField] private float acceleration;

    [Header("Physics")]
    [SerializeField] private float horizontalDrag;
    [SerializeField] private float groundCheckRadius;
    [SerializeField] private Vector2 groundCheckPosition;
    [SerializeField] private LayerMask whatIsGround;

    // self controlled variables
    private bool isGrounded;
    private float moveInput;

    // references
    private Rigidbody2D rb;
    private Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponentInChildren<Animator>();
    }

    void Update()
    {
        GroundCheck();
        ApplyMoveInput(moveInput);
    }

    void GroundCheck()
    {
        Collider2D groundCheckCollider = Physics2D.OverlapCircle(rb.position + groundCheckPosition, groundCheckRadius, whatIsGround);
        if (groundCheckCollider != null)
        {
            if (rb.velocity.y < 0f)
            {
                isGrounded = true;
                animator.SetBool("IsGrounded", isGrounded);
            }
        }
        else
        {
            isGrounded = false;
            animator.SetBool("IsGrounded", isGrounded);
        }
    }

    void ApplyMoveInput(float movement)
    {
        movement *= acceleration;
        float velocityToMaxSpeedRatio = Mathf.Abs(rb.velocity.x / maxSpeed);
        float lerp = Mathf.Lerp(maxSpeed, 0f, velocityToMaxSpeedRatio);

        Vector2 force = new Vector2(movement * lerp * acceleration * Time.fixedDeltaTime, 0f);
        Vector2 drag = new Vector2(-rb.velocity.x * horizontalDrag * Time.fixedDeltaTime, 0f);

        rb.AddForce(force + drag, ForceMode2D.Force);
        //rb.AddForce(drag, ForceMode2D.Force);
        // force - drag?
        animator.SetFloat("Speed", movement);
    }

    public void Move(float moveInput) => this.moveInput = moveInput;

    public void Jump()
    {
        if (isGrounded)
        {
            Vector2 vel = rb.velocity;
            vel.y = jumpSpeed;
            rb.velocity = vel;
            animator.SetBool("IsGrounded", isGrounded);
            animator.SetTrigger("Jump"); 
        }
    }

    void OnDrawGizmosSelected() => Gizmos.DrawWireSphere((Vector2)transform.position + groundCheckPosition, groundCheckRadius);

    void OnDisable() => animator.SetFloat("Speed", 0f);
}
