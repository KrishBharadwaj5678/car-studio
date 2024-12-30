using UnityEngine;

public class Rotate : MonoBehaviour
{
    public GameObject carModel;  // Reference to the 3D car model
    public Vector3 rotateSpeed;  // Rotation speed (degrees per second)
    public Vector3 initialRotationEuler;  // Set the initial rotation as Euler angles in the Inspector
    private bool isRotating = false;
    private Quaternion originalRotation;  // To store the original rotation of the car model

    void Start()
    {
        // Convert the manually set Euler angles to a Quaternion
        originalRotation = Quaternion.Euler(initialRotationEuler);
    }

    void Update()
    {
        if (isRotating)
        {
            // Rotate the car model continuously
            carModel.transform.Rotate(rotateSpeed * Time.deltaTime);
        }
    }

    // Function to toggle the rotation state
    public void ToggleRotation()
    {
        isRotating = !isRotating;

        if (!isRotating)
        {
            // Reset only the rotation without affecting position or scale
            carModel.transform.rotation = originalRotation;
        }
    }
}
