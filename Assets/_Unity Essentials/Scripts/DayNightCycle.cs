using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Header("Cycle Settings")]
    [Tooltip("Duration of a full day cycle in seconds")]
    public float dayDuration = 0.3f; // Default to 2 minutes

    private float rotationSpeed;
    private float currentRotation = 0f;

    void Start()
    {
        // Calculate the rotation speed (degrees per second) for a full day cycle
        rotationSpeed = 360f / dayDuration;
    }

    void Update()
    {
        // Rotate the light around the X-axis based on the calculated speed
        float rotationThisFrame = rotationSpeed * Time.deltaTime;
        transform.Rotate(Vector3.right, rotationThisFrame);

        // Track the total rotation and reset after a full cycle
        currentRotation += rotationThisFrame;
        if (currentRotation >= 360f)
        {
            currentRotation -= 360f; // Start a new cycle
        }
    }
}