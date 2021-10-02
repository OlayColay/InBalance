using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class NPCInteract_Test : MonoBehaviour
{
    [SerializeField] private GameObject dialogueBox;
    private Controls controls;
    private bool interactEnabled;

    private void Awake()
    {
        controls = new Controls();

        controls.Overworld.Interact.performed += pressed =>
        {
            if (interactEnabled)
            {
                if (dialogueBox.activeInHierarchy)
                {
                    dialogueBox.SetActive(false);
                }
                else
                {
                    dialogueBox.SetActive(true);
                }
            }
        };
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // dialogueBox.SetActive(true);
            interactEnabled = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            dialogueBox.SetActive(false);
            interactEnabled = false;
        }
    }

}
