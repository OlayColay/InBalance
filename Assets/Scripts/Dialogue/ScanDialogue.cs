using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;


/*
 * This class is specifically for scrolling dialogue, with waitTime
 * representing the time between each character.
 * This class must be added to an object in the scene to work, it 
 * cannot be called statically.
 */
public class ScanDialogue : MonoBehaviour
{

    public float waitTime = .025f;
    public bool inWrite = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void writeToBox(Text diaText, string dialogue)
    {
        StartCoroutine(writeOutDia(diaText, dialogue));
    }

    IEnumerator writeOutDia(Text diaText, string dialogue)
    {
        inWrite = true;
        string tempDia = dialogue;
        diaText.text = "";
        while (tempDia.Length != 0)
        {
            diaText.text += tempDia[0];
            tempDia = tempDia.Remove(0, 1);
            yield return new WaitForSeconds(waitTime);
            if (Keyboard.current.anyKey.wasPressedThisFrame)
            {
                diaText.text = dialogue;
                tempDia = "";
            }
        }
        inWrite = false;
    }
}
