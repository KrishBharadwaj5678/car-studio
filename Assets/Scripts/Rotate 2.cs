using UnityEngine;

public class Rotate2 : MonoBehaviour
{

    public GameObject[] tires;  // Array to store the 4 tire objects
    public float rotationSpeed = 360f;  // Rotation speed in degrees per second
    public Vector3 rotationAxis = Vector3.right;  // Axis of rotation (default is X-axis)
    private bool isRotating = false;  // Flag to check if the tires are rotating

    void Update()
    {
        if (isRotating)
        {
            foreach (GameObject tire in tires)
            {
                tire.transform.Rotate(rotationAxis * rotationSpeed * Time.deltaTime);  // Rotate based on the chosen axis
            }
        }
    }

    // Function to toggle the rotation on and off
    public void ToggleRotation()
    {
        isRotating = !isRotating;
    }

}
