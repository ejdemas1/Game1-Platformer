using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BobController : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer sprite;
    private Animator anim;

    private float dirX = 0f;
    private float moveSpeed = 7f;
    private float jumpForce = 10f;
    private bool grounded = true;


    private enum MovementState {idle, running, jumping, falling}


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        dirX = Input.GetAxisRaw("Horizontal");
        sprite = GetComponent<SpriteRenderer>();
        rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y);
       
        if(Input.GetButtonDown("Jump") && grounded) {
                rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
        UpdateAnimataion();
    }
    
    private void UpdateAnimataion() {
        MovementState state;

        if (dirX > 0f) {
            state = MovementState.running;
            sprite.flipX = false;
        } 
        else if (dirX < 0f) {
            state = MovementState.running;
            sprite.flipX = true;
        }
        else {
            state = MovementState.idle;
        }

        if (rb.velocity.y > .1f) {
            state = MovementState.jumping;
        } else if (rb.velocity.y < -.1f ) {
            state = MovementState.falling;
        }
        anim.SetInteger("state", (int)state);
    }

    void OnCollisionEnter2D(Collision2D coll) {
        if(coll.gameObject.tag == "Ground") {
            grounded = true;
        }
        if(coll.gameObject.tag == "Spikes") {
            ResartGame();
        }
    }
    void OnCollisionExit2D(Collision2D coll) {
        if(coll.gameObject.tag == "Ground") {
            grounded = false;
        }
    }

    public void ResartGame() {
       Scene scene = SceneManager.GetActiveScene(); 
       SceneManager.LoadScene(scene.name);
    }
}
