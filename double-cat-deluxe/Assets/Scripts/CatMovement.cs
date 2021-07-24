using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CatMovement : MonoBehaviour
{
    public InputMaster controls;
    public int speedScale;
    public int jumpScale;
    public int maxJumps = 1;
    public int jumps = 1;
    [SerializeField] Rigidbody2D rb;

    void Awake() {
        controls = new InputMaster();
    }

    void OnEnable() {
        controls.Enable();    
    }

    void OnDisable() {
        controls.Disable();    
    }

    public void move(Vector2 dir) {
        dir.x *= speedScale;
        dir.y *= jumpScale;
        Vector2 vel = rb.velocity;

        // currently moving to the right, going to move left, and vice-versa
        if ((vel.x > 0 && dir.x < 0) || (vel.x < 0 && dir.x > 0)) {
            rb.velocity = new Vector2(0, vel.y);
        }

        // trying to jump, make sure cat can jump
        if (dir.y > 0 && jumps > 0) {
            jumps -= 1;
        }
        else if (dir.y > 0 && jumps <= 0) {
            dir.y = 0;
        }

        rb.AddForce(dir);
    }

    void OnCollisionStay2D(Collision2D other) {
        // reset amount of jumps after touching platform
        if (other.gameObject.tag == "Platform") {
            jumps = maxJumps;
        }     
    }

    void OnCollisionExit2D(Collision2D other) {
        // reset amount of jumps after touching platform
        if (other.gameObject.tag == "Platform") {
            jumps = 0;
        }     
    }
}
