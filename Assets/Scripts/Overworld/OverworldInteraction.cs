using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OverworldInteraction : MonoBehaviour
{
    [SerializeField] private GameObject dialogueBox;
    [SerializeField] private Text interactReminder;
    private Controls controls;
    private bool interactEnabled;
    private const string defaultReminderText = "Press Space to Interact with ";

    [SerializeField] private int rowNum;
    private HouseGlobals globals;

    public bool questInteractble;
    [SerializeField] private string Quest;

    private void Awake()
    {
        interactReminder.text = defaultReminderText;
        controls = new Controls();
        GameObject globalsObject = GameObject.Find("Level");
        globals = globalsObject.GetComponent<HouseGlobals>();

        controls.Overworld.Interact.performed += pressed =>
        {
            if (interactEnabled)
            {
                if (dialogueBox.activeInHierarchy)
                {
                    dialogueBox.SetActive(false);
                    interactReminder.gameObject.SetActive(true);
                    if (questInteractble)
                    {
                        GameObject.Find("QuestLog").GetComponent<QuestLog>().finishQuest(Quest);
                        questInteractble = false;
                    }
                }
                else
                {
                    int rowOffset = interactionByCase(name);
                    dialogueBox.GetComponent<RunMultipleDialogue>().loadDialogue(rowNum + rowOffset, 1);
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

    private int interactionByCase(string interactable)
    {
        int offset = 0;
        switch(interactable)
        {
            case "Plant":
                HouseGlobals.plantLevel += 1;
                if (HouseGlobals.plantLevel == 1)
                {
                    SpriteRenderer sr = GetComponent<SpriteRenderer>();
                    sr.sprite = globals.plant2;
                    offset = 0;
                }
                else if (HouseGlobals.plantLevel == 2)
                {
                    SpriteRenderer sr = GetComponent<SpriteRenderer>();
                    sr.sprite = globals.plant3;
                    offset = 2;
                }
                else
                {
                    offset = 3;
                }
                break;
            case "Book":
                HouseGlobals.bookLevel += 1;
                if (HouseGlobals.bookLevel == 1)
                {
                    offset = 0;
                }
                else
                {
                    offset = 2;
                }
                break;
            case "Yarn":
                HouseGlobals.yarnLevel += 1;
                if (HouseGlobals.yarnLevel == 1)
                {
                    SpriteRenderer sr = GetComponent<SpriteRenderer>();
                    sr.sprite = globals.yarn2;
                    offset = 0;
                }
                else if (HouseGlobals.yarnLevel == 2)
                {
                    SpriteRenderer sr = GetComponent<SpriteRenderer>();
                    sr.sprite = globals.yarn3;
                    offset = 1;
                }
                else
                {
                    offset = 2;
                }
                break;
            case "Pet Rock":
                HouseGlobals.petLevel += 1;
                offset = Mathf.Min(HouseGlobals.petLevel, HouseGlobals.petMax) - 1;
                break;
            case "Water":
                HouseGlobals.waterLevel += 1;
                offset = Mathf.Min(HouseGlobals.waterLevel, HouseGlobals.waterMax) - 1;
                break;
            case "Stove":
                HouseGlobals.cookLevel += 1;
                offset = Mathf.Min(HouseGlobals.cookLevel, HouseGlobals.cookMax) - 1;
                break;
            case "Bed":
                if (HouseGlobals.canSleep)
                {
                    offset = 1;
                    SceneManager.LoadScene("Cutscene_AfterHouse");
                }
                else
                {
                    offset = 0;
                }
                break;
            case "Door":
                offset = HouseGlobals.gateRand;
                break;
            default:
                break;
        }
        return offset;
    }

}
