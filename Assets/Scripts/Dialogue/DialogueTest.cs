using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class DialogueTest : MonoBehaviour
{
    public Text tex;
    // Start is called before the first frame update
    void Awake()
    {
        this.gameObject.GetComponent<RunMultipleDialogue>().loadDialogue(60, 3);
        this.gameObject.GetComponent<RunMultipleDialogue>().startDialogue();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.anyKey.wasPressedThisFrame)
        {
            Debug.Log("pressed");
            if (this.gameObject.GetComponent<RunMultipleDialogue>().runNextDia() == 1)
            {
                Debug.Log("Finished");
            }
        }
    }
}
