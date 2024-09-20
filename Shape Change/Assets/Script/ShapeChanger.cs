using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeChanger : MonoBehaviour
{
    public float scaleSpeed = 0.01f; // Speed of scaling the object
    private Vector3 initialScale;
    private float initialMouseY;

    void Start()
    {
        // Store the original scale of the object
        initialScale = transform.localScale;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Left mouse button clicked
        {
            // Capture the mouse Y position when drag starts
            initialMouseY = Input.mousePosition.y;
        }

        if (Input.GetMouseButton(0)) // While dragging
        {
            // Get the current mouse Y position
            float currentMouseY = Input.mousePosition.y;

            // Calculate the difference in Y
            float mouseDeltaY = currentMouseY - initialMouseY;

            // Adjust the scale based on mouse movement
            Vector3 newScale = initialScale + Vector3.one * mouseDeltaY * scaleSpeed;

            // Apply the new scale to the object
            transform.localScale = newScale;
        }

        if (Input.GetMouseButtonUp(0)) // Left mouse button released
        {
            // Reset the scale when the dragging stops (optional)
            initialScale = transform.localScale;
        }
    }
}
