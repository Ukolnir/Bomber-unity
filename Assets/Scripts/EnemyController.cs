using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyController : MonoBehaviour
{
    private Rigidbody2D rb2d;

    public float speed;
    public Animator animator;
    public AIPath aiPath;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector2 velocity = aiPath.desiredVelocity.normalized;

        animator.SetFloat("Horizontal", velocity.x);
        animator.SetFloat("Vertical", velocity.y);
        animator.SetFloat("Speed", Mathf.Approximately(aiPath.desiredVelocity.sqrMagnitude, 0f) ? 0 : 1);
    }

    void FixedUpdate() {
     
    }
}
