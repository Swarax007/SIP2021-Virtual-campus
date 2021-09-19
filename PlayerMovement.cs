using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    Joystick joystick;

    

   

    public Rigidbody2D rb;
    public Animator animator;

    PhotonView view;

    Vector2 movement;

    private void Start()
    {
        view = GetComponent<PhotonView>();

        GameObject gJoystick = GameObject.FindWithTag("joystick");

        if (gJoystick)
            joystick = gJoystick.GetComponent<Joystick>();
        else
            print("couldn't found the gameobject with the tag");
        //debug found
        if (joystick)
            print("found the joystick");

    }


   

    void Update()
    {

        if(view.IsMine)
        {
            movement.x = joystick.Horizontal;
            movement.y = joystick.Vertical;  

            /*   movement.x = Input.GetAxisRaw("Horizontal");
               movement.y = Input.GetAxisRaw("Vertical"); */

            animator.SetFloat("Horizontal", movement.x);
            animator.SetFloat("Vertical", movement.y);
            animator.SetFloat("Speed", movement.sqrMagnitude);

            rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        }
        

        

    }
  /*  private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    } */
    
}
