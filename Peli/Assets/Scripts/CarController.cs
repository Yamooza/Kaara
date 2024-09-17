using UnityEngine;

public class CarController : MonoBehaviour
{
    // Movement Variables
    public float speed = 5.0f;

    // References to Rigidbody2D
    private Rigidbody2D rb;

    void Start()
    {
        // Get reference to Rigidbody2D
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Get input from the player
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate movement direction
        Vector2 movementDirection = new Vector2(horizontalInput, verticalInput);

        // Move the car
        rb.MovePosition(rb.position + movementDirection * speed * Time.deltaTime);
    }

    void FixedUpdate()
    {
        // Apply friction to slow down the car
        rb.velocity *= 0.95f;
    }
}