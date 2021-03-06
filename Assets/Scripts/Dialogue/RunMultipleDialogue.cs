using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/*
 * Use this class anytime for textbox dialogue the player is supposed to read.
 * Loads in a list of dialogue messages and utilizes scandialogue to write into box
 * Set diaText in editor to the text you want to change
 * Requires ScanDialogue on the same object
 * Not a dialogue controller class, only has functions for using dialogue
 */
public class RunMultipleDialogue : MonoBehaviour
{
    public List<string> diaMessages;
    public Text diaText;
    public int currDia = 0;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Loads a series of dialogue from the CSV file
    //starts with row start, then reads num rows
    public void loadDialogue(int start, int num)
    {
        diaMessages.Clear();
        for (int x = 0; x < num; x++)
        {
            diaMessages.Add(CsvToDialogue.pullColumn(start + x));
        }
    }


    //Starts the first dialogue message
    public void startDialogue()
    {
        this.gameObject.GetComponent<ScanDialogue>().writeToBox(diaText, diaMessages[0]);
    }


    //runs the next dialogue message in the list
    //0 for success, 1 for end of dialogue, 2 for in the middle of scan
    public int runNextDia()
    {
        currDia++;
        if (this.gameObject.GetComponent<ScanDialogue>().inWrite)
        {
            currDia--;
            return 2;
        }
        else if (currDia >= diaMessages.Count)
        {
            currDia--;
            return 1;
        }
        this.gameObject.GetComponent<ScanDialogue>().writeToBox(diaText, diaMessages[currDia]);
        return 0;
    }
}
