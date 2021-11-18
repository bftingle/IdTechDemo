using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSttMach : MonoBehaviour
{
    private Animator animator;
    private PlayerMovement movement;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        movement = GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("Running", (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0) ? true : false);
        animator.SetFloat("Horizontal", Input.GetAxisRaw("Horizontal"));
        animator.SetFloat("Vertical", Input.GetAxisRaw("Vertical"));
        animator.SetBool("isGrounded", movement.isGrounded);
    }
}
