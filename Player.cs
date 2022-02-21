using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    CharacterController controller;
    public float speed;
    Animator anim;
    public bool isGrounded = true;
    Vector3 jumpVel;
    float gravity;
    public GameObject plate;
    float jumpSpeed = 3;
    public bool isDead;
    void Start()
    {
        controller = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
        gravity = -15f;
    }

    
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            StartCoroutine(superJump());
        }
        movement();
        jump();
        Gravity();
    }

    void jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            anim.SetBool("jump", true);
            jumpVel.y = Mathf.Sqrt(gravity * jumpSpeed * -3);
            anim.SetBool("jump", false);
        }
    }

    void Gravity()
    {
        float distance = transform.position.y - plate.transform.position.y;
        if (distance <= 1.8)
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }

        if (isGrounded && jumpVel.y < 0)
        {
            jumpVel.y = 0;
        }

        jumpVel.y += gravity * Time.deltaTime;
        controller.Move(jumpVel * Time.deltaTime);
    }

    void movement()
    {
        if (Input.GetKeyDown(KeyCode.A) && transform.position.x > -9)
        {
            controller.Move(new Vector3(-9, 2.32f, 0));   
        } else if (Input.GetKeyDown(KeyCode.D) && transform.position.x < 8) 
        {
            controller.Move(new Vector3(9, 2.32f, 0));
        }
    }

    IEnumerator superJump()
    {
        jumpSpeed = 10;
        yield return new WaitForSeconds(20);
        jumpSpeed = 2;
    }
}
