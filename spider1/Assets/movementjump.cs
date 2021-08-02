using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementjump : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 movement;
    public float rotatespeed = 38f, gravity = -9.81f, jumpForce = 10f;
    private float yvar;
    public int playerJumpCount;
    //public FloatData normalSpeed, fastSpeed;
   // public IntData JumpCountMax;
   //private FloatData moveSpeed;
    private int jumpCount;
   // public Vector3dataobject currentSpawnpoint;
    private void Start()
    {
      //  moveSpeed = normalSpeed;
        controller = GetComponent<CharacterController>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
         //   moveSpeed = fastSpeed;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
           // moveSpeed = normalSpeed;
        }

      //  var vInput = Input.GetAxis("Vertical") * moveSpeed.value;
      //  var hInput = Input.GetAxis("Horizontal") * moveSpeed.value;
      //  movement.Set(vInput, yvar, hInput);

      //  transform.Rotate(0, hInput, 0);
        yvar += gravity * Time.deltaTime;
        if (controller.isGrounded && movement.y < 0)
        {
            yvar = -2f;
            jumpCount = 0;
        }
       // if (Input.GetButtonDown("Jump") && jumpCount < JumpCountMax.value)
        {
            yvar = jumpForce;
            jumpCount++;

        }
        movement = transform.TransformDirection(movement);
        controller.Move(movement * Time.deltaTime);
    }

    private void OnEnable()
    {

        {

          //  transform.position = currentSpawnpoint.value;
        }

    }

}