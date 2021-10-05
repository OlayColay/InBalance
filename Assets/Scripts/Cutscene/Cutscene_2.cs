using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cutscene_2 : MonoBehaviour
{
    [SerializeField] private GameObject dialogueBox;
    [SerializeField] private GameObject art1;
    [SerializeField] private GameObject art2;
    private Controls controls;
    private int pressCount;

    private void Awake()
    {
        pressCount = 0;
        controls = new Controls();
        controls.Overworld.Interact.performed += pressed =>
        {
            if (dialogueBox.GetComponent<ScanDialogue>().inWrite)
                return;
            pressCount += 1;
            switch (pressCount)
            {
                case 1:
                    art1.SetActive(true);
                    dialogueBox.SetActive(true);
                    dialogueBox.GetComponent<RunMultipleDialogue>().loadDialogue(49, 1);
                    dialogueBox.GetComponent<RunMultipleDialogue>().startDialogue();
                    break;
                case 2:
                    dialogueBox.GetComponent<RunMultipleDialogue>().loadDialogue(50, 1);
                    dialogueBox.GetComponent<RunMultipleDialogue>().startDialogue();
                    break;
                case 3:
                    art1.SetActive(false);
                    art2.SetActive(true);
                    dialogueBox.GetComponent<RunMultipleDialogue>().loadDialogue(53, 1);
                    dialogueBox.GetComponent<RunMultipleDialogue>().startDialogue();
                    break;
                case 4:
                    dialogueBox.GetComponent<RunMultipleDialogue>().loadDialogue(46, 1);
                    dialogueBox.GetComponent<RunMultipleDialogue>().startDialogue();
                    break;
                case 5:
                    dialogueBox.GetComponent<RunMultipleDialogue>().loadDialogue(47, 1);
                    dialogueBox.GetComponent<RunMultipleDialogue>().startDialogue();
                    break;
                case 6:
                    art1.SetActive(true);
                    art2.SetActive(false);
                    dialogueBox.GetComponent<RunMultipleDialogue>().loadDialogue(54, 1);
                    dialogueBox.GetComponent<RunMultipleDialogue>().startDialogue();
                    break;
                // case 7:
                //     art1.SetActive(false);
                //     art2.SetActive(true);
                //     dialogueBox.GetComponent<RunMultipleDialogue>().loadDialogue(57, 1);
                //     dialogueBox.GetComponent<RunMultipleDialogue>().startDialogue();
                //     break;
                default:
                    SceneManager.LoadScene("Starting");
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
