using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Driver
/// </summary>
public class Driver : MonoBehaviour
{
    // movement support
    const float MoveUnitsPerSecond = 5;

    /// <summary>
	/// Update is called once per frame
	/// </summary>	
    void Update()
    {
        // move game object as appropriate
        Vector3 position = transform.position;
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        if (horizontalInput != 0)
        {
            position.x = position.x + horizontalInput * MoveUnitsPerSecond *
                Time.deltaTime;
        }
        if (verticalInput != 0)
        {
            position.y = position.y + verticalInput * MoveUnitsPerSecond *
                Time.deltaTime;
        }

        // move character
        transform.position = position;
    }

}
