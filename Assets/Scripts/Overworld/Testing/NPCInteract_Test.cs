using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class NPCInteract_Test : MonoBehaviour
{
    [SerializeField] private GameObject dialogueBox;
    [SerializeField] private GameObject interactReminder;
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
                    interactReminder.SetActive(true);
                }
                else
                {
                    dialogueBox.SetActive(true);
                    interactReminder.SetActive(false);
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
            interactReminder.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            dialogueBox.SetActive(false);
            interactEnabled = false;
            interactReminder.SetActive(false);
        }
    }

}
