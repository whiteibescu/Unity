using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csJump : MonoBehaviour
{
    float gravity = -20f;
    float jumpSpeed = 10f;
    Vector3 velocity;
    CharacterController controller;
    void Start()
    {
        controller = GetComponent<CharacterController>();
        velocity = new Vector3(0, 0, 0);
    }

    void Update()
    {
        float y = transform.position.y;

        if (controller.isGrounded)
        {
            if (Input.GetButtonDown("Jump"))
            {
                velocity.y = jumpSpeed;
            }
        }

        velocity.y += (gravity * Time.deltaTime);
        controller.Move(velocity * Time.deltaTime);
    }
}
