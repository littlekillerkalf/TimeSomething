using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 5f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    public bool isGrounded = true;
    [SerializeField]
    private bool jumped = false;

    private bool jumpTimerComplete = true;
    private float timer;

    public GameObject attachedCamera;


    private void Start()
    {
        groundCheck = GameObject.FindGameObjectWithTag("Ground").transform;
        timer = 1;
    }
    void Update()
    {

            if (isGrounded && velocity.y < 0)
            {
                velocity.y = -2f;
            }

            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");

            Vector3 move = (transform.right * x + transform.forward * z);

            velocity.y += gravity * Time.deltaTime;

            controller.Move(velocity * Time.deltaTime);
            //isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
            if (attachedCamera.gameObject.GetComponent<MouseLook>().open == false)
            {
                controller.Move(move * speed * Time.deltaTime);
                if (Input.GetButtonDown("Jump") && !jumped)
                {
                velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
                jumped = true;
                jumpTimerComplete = false;
                timer = 0.7f;
                }
            }

            if (!jumpTimerComplete)
            {
                timer = timer - Time.deltaTime;
            }
            if(timer <= 0)
            {
                jumpTimerComplete = true;
            }
            if (jumpTimerComplete)
            {
                jumped = false;
            }

    }
}
