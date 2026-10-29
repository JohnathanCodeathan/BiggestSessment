using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    public Vector2 moving = new Vector2(); // Public variable to store player's movement direction
    public int JumpReleased = 0;
    public bool bigjump = false;
    // Start is called before the first frame update
    void Start()
    {
        // Initialization code can be placed here
    }

    // Update is called once per frame
    void Update()
    {
        // Reset the movement vector to (0, 0) at the start of each frame
        moving.x = moving.y = 0;
        // Check if the right arrow key or 'D' key is pressed
        if (Input.GetKey("right") || Input.GetKey("d")){
            // Set the x component of the movement vector to 1 (right direction)
            moving.x = 1;
        }

        // Check if the left arrow key or 'A' key is pressed
        else if (Input.GetKey("left") || Input.GetKey("a")){
            // Set the x component of the movement vector to -1 (left direction)
            moving.x = -1;
        }

        // Check if the up arrow key, 'W' key, or spacebar is pressed
        if (Input.GetKeyDown("up") || Input.GetKeyDown("w") || Input.GetKeyDown("space")){
            // Set the y component of the movement vector to 1 (upward direction)
            moving.y = 1;
            bigjump = true;
        }

        // Check if the down arrow key or 'S' key is pressed
        else if (Input.GetKey("down") || Input.GetKey("s")){
            // Set the y component of the movement vector to -1 (downward direction)
            moving.y = -1;
        }
        if (Input.GetKeyUp("up") || Input.GetKeyUp("w") || Input.GetKeyUp("space")){
            JumpReleased = 1;
            bigjump = false;
        }
    }
}