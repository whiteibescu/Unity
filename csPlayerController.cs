using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class csPlayerController : MonoBehaviour
{
    public float walkSpeed = 3f;
    public float gravity = 20f;
    public float jumpSpeed = 8f;
    Vector3 velocity;
    CharacterController controller;
    Animation ani;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
        ani = GetComponent<Animation>();
    }

    void Update()
    {
        if (controller.isGrounded)
        {
            velocity = new Vector3(CrossPlatformInputManager.GetAxis("Horizontal"), 0, CrossPlatformInputManager.GetAxis("Vertical"));

            velocity *= walkSpeed;

            if (CrossPlatformInputManager.GetButtonDown("Jump"))
            {
                velocity.y = jumpSpeed;
                ani.Play("victory");
            }
            else
            {
                if (velocity.magnitude > 0.5f)
                {
                    ani.CrossFade("walk", 0.1f);
                    transform.LookAt(transform.position + velocity);
                }
                else
                {
                    ani.CrossFade("idle", 0.1f);
                }
            }
        }

        velocity.y = gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}
