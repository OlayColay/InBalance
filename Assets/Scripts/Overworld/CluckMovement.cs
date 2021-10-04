using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CluckMovement : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private Rigidbody2D rb;
    private Animator anim;
    private Controls playerControls;
    private Vector2 moveDir;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        moveDir = GameObject.FindObjectOfType<OverworldMovement>().controls.Overworld.Move.ReadValue<Vector2>();
        // Debug.Log(moveDir);
    }

    private void FixedUpdate()
    {
        if (moveDir != Vector2.zero)
        {
            Vector2 offset = -moveDir;
            Vector2 playerPos = new Vector2(player.transform.position.x, player.transform.position.y);
            rb.MovePosition(playerPos + offset * 1f);
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
