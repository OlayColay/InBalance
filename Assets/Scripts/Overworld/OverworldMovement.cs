using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class OverworldMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 8f;
    private Rigidbody2D rb;
    private Animator anim;
    public Controls controls;
    private Vector2 moveDir;

    private void Awake()
    {
        controls = new Controls();
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }

    private void Update()
    {
        moveDir = controls.Overworld.Move.ReadValue<Vector2>();
        // Debug.Log(moveDir);
    }

    private void FixedUpdate()
    {
        if (moveDir != Vector2.zero)
        {
            rb.MovePosition(rb.position + moveDir * moveSpeed * Time.fixedDeltaTime);
            anim.SetBool("IsWalking", true);
            anim.SetFloat("MoveX", moveDir.x);
            anim.SetFloat("MoveY", moveDir.y);
        }
        else
        {
            anim.SetBool("IsWalking", false);
        }
    }

}
