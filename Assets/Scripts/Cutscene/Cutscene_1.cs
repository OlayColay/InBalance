using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cutscene_1 : MonoBehaviour
{
    [SerializeField] private GameObject dialogueBox;
    private Controls controls;
    private int pressCount; 

    private void Awake()
    {
        pressCount = 0;
        controls = new Controls();
        controls.Overworld.Interact.performed += pressed =>
        {
            pressCount += 1;
            switch (pressCount)
            {
                case 1:
                    dialogueBox.SetActive(true);
                    dialogueBox.GetComponent<RunMultipleDialogue>().loadDialogue(5, 1);
                    dialogueBox.GetComponent<RunMultipleDialogue>().startDialogue();
                    break;
                case 2:
                    dialogueBox.GetComponent<RunMultipleDialogue>().loadDialogue(6, 1);
                    dialogueBox.GetComponent<RunMultipleDialogue>().startDialogue();
                    break;
                case 3:
                    dialogueBox.GetComponent<RunMultipleDialogue>().loadDialogue(21, 1);
                    dialogueBox.GetComponent<RunMultipleDialogue>().startDialogue();
                    break;
                default:
                    SceneManager.LoadScene("0_House");
                    break;
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

}
