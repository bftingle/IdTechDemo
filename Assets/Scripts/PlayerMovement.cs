using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;

    public float speed = 12;
    public float jumpForce = 12;
    public bool isGrounded = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isGrounded == true && Input.GetKey("space")) {
            isGrounded = false;
            rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * speed, jumpForce);
        } else rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * speed, rb.velocity.y);
    }

    void OnCollisionEnter2D(Collision2D theCollision) {
        if (theCollision.gameObject.tag == "Ground") {
            isGrounded = true;
        }
    }
}
