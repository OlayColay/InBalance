using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class DialogueTest : MonoBehaviour
{
    public Text tex;
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<RunMultipleDialogue>().startDialogue();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.anyKey.wasPressedThisFrame)
        {
            Debug.Log("pressed");
            this.gameObject.GetComponent<RunMultipleDialogue>().runNextDia();
        }
    }
}
