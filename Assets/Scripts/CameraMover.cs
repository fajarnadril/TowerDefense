using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    public float moveSpeed = 10f;  // Speed of the camera movement

    // Set the min and max bounds for the camera movement
    public Vector2 minBounds;
    public Vector2 maxBounds;

    void Update()
    {
        // Get input from WASD keys
        float moveHorizontal = Input.GetKey(KeyCode.A) ? -1 : Input.GetKey(KeyCode.D) ? 1 : 0;
        float moveVertical = Input.GetKey(KeyCode.W) ? 1 : Input.GetKey(KeyCode.S) ? -1 : 0;

        // Calculate movement
        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0) * moveSpeed * Time.deltaTime;

        // Move the camera within the defined bounds
        Vector3 newPosition = transform.position + movement;
        newPosition.x = Mathf.Clamp(newPosition.x, minBounds.x, maxBounds.x);  // Clamp the x position
        newPosition.y = Mathf.Clamp(newPosition.y, minBounds.y, maxBounds.y);  // Clamp the y position

        // Set the new position
        transform.position = newPosition;
    }
}


