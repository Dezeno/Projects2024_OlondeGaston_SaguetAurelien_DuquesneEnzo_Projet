using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rd2d;
    public float id; 
    public float moveSpeed = 5f;

    private void Update()
    {
        float movement = ProcessInput();
        Move(movement);
    }

    private float ProcessInput()
    {
        float movement = 0f;
        switch (id)
        {
            case 1:
                movement = Input.GetAxis("MovePlayer1");
                break;
            case 2:
                movement = Input.GetAxis("MovePlayer2");
                break;
        }

        return movement;
    }

    public void Move(float movement)
    {
        Vector2 velocity = rd2d.velocity;
        velocity.y = moveSpeed * movement;
        rd2d.velocity = velocity;
    }

}
