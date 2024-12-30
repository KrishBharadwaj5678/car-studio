using UnityEngine;

public class WheelMover : MonoBehaviour
{
    public GameObject[] tires;  // Array to store the 4 tire objects
    public float rotationSpeed = 360f;  // Rotation speed in degrees per second
    private bool isRotating = false;  // Flag to check if the tires are rotating

    void Update()
    {
        if (isRotating)
        {
            foreach (GameObject tire in tires)
            {
                tire.transform.Rotate(Vector3.right * rotationSpeed * -1f * Time.deltaTime);  // Rotate on the X-axis with clockwise rotation (-1f)
            }
        }
    }

    // Function to toggle the rotation on and off
    public void ToggleRotation()
    {
        isRotating = !isRotating;
    }

}
