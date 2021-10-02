using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


/*
 * Manager class for the dialogue system
 * Input System to be changed, but I dont know how it works yet
 * startRow and endRow should be changed in editor
 */
public class DialogueManager : MonoBehaviour
{
    RunMultipleDialogue runScript;
    public int startRow;
    public int endRow;
    // Start is called before the first frame update
    void Awake()
    {
        runScript = this.gameObject.GetComponent<RunMultipleDialogue>();
        runScript.loadDialogue(startRow, startRow-endRow);
        runScript.startDialogue();
    }

    // Update is called once per frame
    // TODO Fix the input System code
    void Update()
    {
        if (Keyboard.current.anyKey.wasPressedThisFrame)
        //This line right here ^^^^^
        {
            Debug.Log("pressed");
            int res = runScript.runNextDia();
            if (res == 2)
            {
                this.gameObject.GetComponent<ScanDialogue>().keyPress();
            }
            else if (res == 1)
            {
                Debug.Log("finish");
            }
        }
    }
}
