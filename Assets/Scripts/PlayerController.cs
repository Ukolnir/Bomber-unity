using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb2d;

    public float speed;
    private bool isMove = false;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() {
        if (isMove) {
            //Debug.Log(transform.position);
            rb2d.velocity = default;
            isMove = false;
        }
    }

    void FixedUpdate()
    {
        //float moveVertical = Input.GetAxis("Vertical"); //Перемещение по вертикали -1..1
        //float moveHorizontal = Input.GetAxis("Horizontal"); //Перемещение по горизонтали -1..1

        if (Input.GetKey(KeyCode.W)){
            rb2d.velocity = new Vector2(rb2d.velocity.x, rb2d.velocity.y + 1) * speed;
            isMove = true;
            return;
        }
        if (Input.GetKey(KeyCode.A)){ //Left movement
            rb2d.velocity = new Vector2(rb2d.velocity.x - 1, rb2d.velocity.y) * speed;
            isMove = true;
            return;
        }

        if (Input.GetKey(KeyCode.S)){ //Down movement
            rb2d.velocity = new Vector2(rb2d.velocity.x, rb2d.velocity.y - 1) * speed;
            isMove = true;
            return;
        }

        if (Input.GetKey(KeyCode.D)){ //Right movement
            rb2d.velocity = new Vector2(rb2d.velocity.x + 1, rb2d.velocity.y) * speed;
            isMove = true;
            return;
        }



        //
        /*if (Input.GetKey(KeyCode.W)) { //Up movement
            rigidBody.velocity = new Vector3(rigidBody.velocity.x, rigidBody.velocity.y, moveSpeed);
            myTransform.rotation = Quaternion.Euler(0, 0, 0);
            animator.SetBool("Walking",true);
        }

        if (Input.GetKey(KeyCode.A)) { //Left movement
            rigidBody.velocity = new Vector3(-moveSpeed, rigidBody.velocity.y, rigidBody.velocity.z);
            myTransform.rotation = Quaternion.Euler(0, 270, 0);
            animator.SetBool("Walking", true);
        }

        if (Input.GetKey(KeyCode.S)) { //Down movement
            rigidBody.velocity = new Vector3(rigidBody.velocity.x, rigidBody.velocity.y, -moveSpeed);
            myTransform.rotation = Quaternion.Euler(0, 180, 0);
            animator.SetBool("Walking", true);
        }

        if (Input.GetKey(KeyCode.D)) { //Right movement
            rigidBody.velocity = new Vector3(moveSpeed, rigidBody.velocity.y, rigidBody.velocity.z);
            myTransform.rotation = Quaternion.Euler(0, 90, 0);
            animator.SetBool("Walking", true);
        }*/
    }
}
