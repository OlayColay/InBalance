using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

/*
 * Manager for the Quest Log
 * All quests are held as strings in the currQuests
 * Whenever a quest is ready to be finished call finishQuest
 * Whenever a quest needs to be added, call addQuest
 * To check if a quest is in the quest log, call checkQuest
 * the questbox will automatically update whenever it is changed
 */
public class QuestLog : MonoBehaviour
{
    public List<string> currQuests;
    public List<Text> questTexts;
    public List<Image> checkboxes;
    public Image Background;
    public Image blackScreen;

    public GameObject checkBox;
    public GameObject questText;

    public RunMultipleDialogue dialogueBox;

    public int startYPos = -40;
    public int startXPosText = 0;
    public int startXPosCheck = 0;
    public int spacing = 35;
    public int backgroundXSize = 300;

    private bool bedDone = false;

    // Start is called before the first frame update
    void Awake()
    {
        if (globals.currQuests != null)
        {
            currQuests = globals.currQuests;
            Debug.Log("here");
        }
        setQuestBox();
    }

    private void Start()
    {
        blackScreen.gameObject.SetActive(true);
        blackScreen.DOFade(0f, 1f).SetEase(Ease.Linear).OnComplete(() => {
            /*
            dialogueBox.loadDialogue(5, 1);
            dialogueBox.gameObject.SetActive(true);
            dialogueBox.startDialogue();
            */
            blackScreen.gameObject.SetActive(false);
        });
    }

    public void addQuest(string quest)
    {
        currQuests.Add(quest);
        setQuestBox();
    }

    public void finishQuest(string quest)
    {
        Destroy(questTexts[currQuests.IndexOf(quest)].gameObject);
        questTexts.Remove(questTexts[currQuests.IndexOf(quest)]);
        currQuests.Remove(quest);
        if (!bedDone && currQuests.Count < 1)
        {
            currQuests = new List<string>();
            currQuests.Add("Go to bed");
            bedDone = true;
        }
        else if (bedDone)
        {
            Destroy(this.gameObject);
        }
        setQuestBox();
    }

    public bool checkQuest(string quest)
    {
        return currQuests.Contains(quest);
    }

    void clearQuestTexts()
    {
        if (questTexts != null)
        {
            Debug.Log(questTexts.Count);
            for (int x = 0; x < questTexts.Count; x++)
            {
                Destroy(questTexts[x].gameObject);
                //Destroy(checkboxes[x].gameObject);
            }
            questTexts.Clear();
            checkboxes.Clear();
        }
    }

    void setQuestBox()
    {
        clearQuestTexts();
        
        for (int x = 0; x < currQuests.Count; x++)
        {
            questTexts.Add(Instantiate(questText).GetComponent<Text>());
            questTexts[x].text = currQuests[x];
            questTexts[x].gameObject.GetComponent<Transform>().SetParent(this.gameObject.GetComponent<Transform>());
            questTexts[x].gameObject.GetComponent<RectTransform>().sizeDelta = new Vector3(220, 30, 1);
            questTexts[x].gameObject.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
            questTexts[x].gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector3(startXPosText, startYPos - spacing*x, 1);
            /*checkboxes.Add(Instantiate(checkBox).GetComponent<Image>());
            checkboxes[x].gameObject.GetComponent<Transform>().SetParent(this.gameObject.GetComponent<Transform>());
            checkboxes[x].gameObject.GetComponent<RectTransform>().sizeDelta = new Vector3(20, 20, 1);
            checkboxes[x].gameObject.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
            checkboxes[x].gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector3(startXPosCheck, startYPos - spacing * x, 1);*/
        }
        Background.gameObject.GetComponent<RectTransform>().sizeDelta = new Vector3(250, spacing+ 15 +spacing*currQuests.Count);
        globals.currQuests = currQuests;
    }
}
