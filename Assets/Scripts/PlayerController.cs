using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb2d;

    public float speed;
    private Vector2 movement;

    public Animator animator;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update() {
        movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    void FixedUpdate()
    {
        rb2d.MovePosition(rb2d.position + movement.normalized * speed * Time.fixedDeltaTime);
    }
}
