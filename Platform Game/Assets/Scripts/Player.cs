using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;

    public float speed;

    public bool isMoving;

    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Move();
    }

    void Move()
    {

        float x = Input.GetAxisRaw("Horizontal");

        float moveBy = x * speed;

        rb.velocity = new Vector2(moveBy, rb.velocity.y);

        if(x != 0)
        {
            isMoving = true;
            if(x == 1)
            {
                transform.eulerAngles = new Vector2(0, 0);
            }
            if(x == -1)
            {
                transform.eulerAngles = new Vector2(0, 180);
            }
        }
        else
        {
            isMoving = false;
        }

        if (isMoving)
        {
            anim.SetBool("isRunning", true); 
        }
        else
        {
            anim.SetBool("isRunning", false);
        }
    }
}
