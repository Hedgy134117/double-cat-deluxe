using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CatMovement : MonoBehaviour
{
    public InputMaster controls;
    public int speedScale;
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
        dir = dir * speedScale;
        Vector2 vel = rb.velocity;

        // currently moving to the right, going to move left, and vice-versa
        if ((vel.x > 0 && dir.x < 0) || (vel.x < 0 && dir.x > 0)) {
            rb.velocity = new Vector2(0, vel.y);
        }
        rb.AddForce(dir);
    }
}
