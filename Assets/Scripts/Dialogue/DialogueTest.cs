using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueTest : MonoBehaviour
{
    public Text tex;
    // Start is called before the first frame update
    void Start()
    {
        tex.text = CsvToDialogue.pullColumn(10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
