using UnityEngine;

public class ThirdPersonCam : MonoBehaviour
{
    public Transform target;        // The object the camera follows
    public float distance = 5f;     // Default distance from the target
    public float zoomSpeed = 2f;    // Speed of zooming
    public float minDistance = 2f;  // Minimum zoom distance
    public float maxDistance = 10f; // Maximum zoom distance

    public float rotationSpeed = 100f;       // Speed of rotating the camera
    public Vector2 pitchLimits = new Vector2(-30f, 60f); // Vertical angle limits

    private float currentYaw = 0f;  // Horizontal rotation around the target
    private float currentPitch = 0f; // Vertical rotation of the camera

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void LateUpdate()
    {
        if (!target) return; // Ensure there is a target to follow

        // Handle camera rotation with mouse input
        float horizontal = Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;
        float vertical = -Input.GetAxis("Mouse Y") * rotationSpeed * Time.deltaTime;

        currentYaw += horizontal; // Accumulate horizontal rotation
        currentPitch = Mathf.Clamp(currentPitch + vertical, pitchLimits.x, pitchLimits.y); // Clamp vertical rotation

        // Calculate the camera's position and rotation
        Quaternion rotation = Quaternion.Euler(currentPitch, currentYaw, 0f);
        Vector3 offset = rotation * new Vector3(0, 0, -distance);
        transform.position = target.position + offset;
        transform.LookAt(target);

        // Align the player with the camera's horizontal direction
        AlignPlayerWithCamera();
    }

    private void AlignPlayerWithCamera()
    {
        if (target)
        {
            // Get camera's forward direction, ignoring vertical rotation
            Vector3 cameraForward = transform.forward;
            cameraForward.y = 0; // Ignore vertical component
            if (cameraForward.magnitude > 0.1f)
            {
                // Rotate player to face the camera's horizontal direction
                Quaternion targetRotation = Quaternion.LookRotation(cameraForward);
                target.rotation = Quaternion.Lerp(target.rotation, targetRotation, Time.deltaTime * 10f);
            }
        }
    }
}
