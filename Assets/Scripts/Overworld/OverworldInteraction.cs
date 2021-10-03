using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OverworldInteraction : MonoBehaviour
{
    [SerializeField] private GameObject dialogueBox;
    [SerializeField] private Text interactReminder;
    private Controls controls;
    private bool interactEnabled;
    private const string defaultReminderText = "Press Space to Interact with ";
    [SerializeField] private int rowNum;

    private void Awake()
    {
        interactReminder.text = defaultReminderText;
        controls = new Controls();

        controls.Overworld.Interact.performed += pressed =>
        {
            if (interactEnabled)
            {
                if (dialogueBox.activeInHierarchy)
                {
                    dialogueBox.SetActive(false);
                    interactReminder.gameObject.SetActive(true);
                }
                else
                {
                    dialogueBox.GetComponent<RunMultipleDialogue>().loadDialogue(rowNum, 1);
                    dialogueBox.SetActive(true);
                    dialogueBox.GetComponent<RunMultipleDialogue>().startDialogue();
                    interactReminder.gameObject.SetActive(false);
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
            interactReminder.text = interactReminder.text + name;
            interactReminder.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            dialogueBox.SetActive(false);
            interactEnabled = false;
            interactReminder.gameObject.SetActive(false);
            interactReminder.text = defaultReminderText;
        }
    }

}
