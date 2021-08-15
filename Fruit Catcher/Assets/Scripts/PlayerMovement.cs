using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //public static PlayerMovement instance;
    public float speed = 2f;

    Rigidbody2D rb;

    public float movement;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxisRaw("Horizontal");

        rb.velocity = new Vector2(speed * movement, rb.velocity.y);
    }
}
