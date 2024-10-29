using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour{
    [SerializeField] float movement;
    [SerializeField] Rigidbody2D rigid;
    [SerializeField] int SPEED = 10;
    [SerializeField] bool isFacingRight = true;
    [SerializeField] bool jumpPressed = false;
    [SerializeField] private float jumpForce = 500.0f;
    [SerializeField] bool isGrounded = true;
    [SerializeField] Animator anim;
    void Start(){
        if(rigid == null)
            rigid = GetComponent<Rigidbody2D>();
        if(anim == null)
            anim = GetComponent<Animator>();
    }
    void Update(){
        movement = Input.GetAxis("Horizontal");
        if(Input.GetButtonDown("Jump") || Input.GetKey("w"))
            jumpPressed = true;
        anim.SetBool("Run", movement != 0);
    }
    private void FixedUpdate(){
        rigid.velocity = new Vector2(SPEED * movement, rigid.velocity.y);
        if(movement < 0 && isFacingRight || movement > 0 && !isFacingRight)
            Flip();
        if(jumpPressed && isGrounded)
            Jump();
        else
            jumpPressed = false;

        
    }
    private void Flip(){
        transform.Rotate(0, 180, 0);
        isFacingRight = !isFacingRight;
    }

    private void Jump(){
        rigid.velocity = new Vector2(rigid.velocity.x, 0);
        rigid.AddForce(new Vector2(0, jumpForce));
        jumpPressed = false;
        isGrounded = false;
    }

    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == "Ground")
            isGrounded = true;

        if(collision.gameObject.tag == "KILLZONE"){
            GameObject reset = GameObject.FindGameObjectWithTag("GameController");
            Destroy(reset);
            SceneManager.LoadScene(1);
        }
    }
}
