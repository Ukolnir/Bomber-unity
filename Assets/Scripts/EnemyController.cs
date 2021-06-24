using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public float speed;
    private bool isMove = false;

    public GameObject player; 

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isMove){
          rb2d.velocity = default;
          isMove = false;
        }
    }

    void FixedUpdate() {
        Vector3 direct = (player.transform.position - transform.position).normalized;
        Debug.Log(player.transform.position);
        rb2d.velocity = new Vector2(direct.x, direct.y) * speed;
        isMove = true;
    }
}
