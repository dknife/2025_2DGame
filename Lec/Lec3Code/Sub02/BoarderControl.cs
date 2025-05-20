using UnityEngine;

/// <summary>
/// Controls the rotation of a 2D Rigidbody using torque.
/// Designed for objects like snowboards, skateboards, etc.
/// </summary>
[RequireComponent(typeof(Rigidbody2D))] // Ensures a Rigidbody2D component is attached
public class BoardController : MonoBehaviour
{
    [Tooltip("The magnitude of torque applied for rotation. " +
             "NOTE: This value is a direct torque. You will likely need to adjust this value " +
             "significantly (likely making it smaller) compared to the original script " +
             "because Time.deltaTime scaling has been removed for physics correctness.")]
    [SerializeField] float torqueAmount = 1.0f; // Example: Might need to be 0.1 or 0.5 instead of 10

    private Rigidbody2D rb2d;
    private float rotationInput; // Stores the input for rotation (-1 for right, 1 for left, 0 for none)

    void Awake()
    {
        // Cache the Rigidbody2D component for performance and reliability
        rb2d = GetComponent<Rigidbody2D>();

        // Defensive check, though RequireComponent should prevent this
        if (rb2d == null)
        {
            Debug.LogError("BoardController on " + gameObject.name + " requires a Rigidbody2D component, but it's missing.", this);
            enabled = false; // Disable this script if the crucial component is not found
        }
    }

    void Update()
    {
        // Gather input in Update() for maximum responsiveness.
        // This determines the desired direction of rotation.
        rotationInput = 0f; // Reset input each frame

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rotationInput += 1f; // Positive for counter-clockwise torque (left rotation)
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rotationInput -= 1f; // Negative for clockwise torque (right rotation)
        }

        // Alternative for smoother/analog input (e.g., joystick or Input Manager axis):
        // rotationInput = Input.GetAxis("Horizontal"); // Adjust axis name and direction as needed
        // If using Horizontal axis, typically right is positive, so you might want:
        // rotationInput = -Input.GetAxis("Horizontal"); // To make left positive torque
    }

    void FixedUpdate()
    {
        // Apply physics-related changes in FixedUpdate() for consistency.
        if (rb2d == null || rotationInput == 0f)
        {
            // Do nothing if Rigidbody is missing or there's no input
            return;
        }

        // Apply torque. torqueAmount is the direct magnitude of the torque.
        // rotationInput determines the direction (+1 or -1).
        // The physics engine applies this torque over Time.fixedDeltaTime.
        rb2d.AddTorque(rotationInput * torqueAmount);
    }
}
