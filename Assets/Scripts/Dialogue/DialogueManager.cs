using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DialogueManager : MonoBehaviour
{
    RunMultipleDialogue runScript;
    // Start is called before the first frame update
    void Awake()
    {
        runScript = this.gameObject.GetComponent<RunMultipleDialogue>();
        runScript.loadDialogue(60, 3);
        runScript.startDialogue();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.anyKey.wasPressedThisFrame)
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
