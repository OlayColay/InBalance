using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishCredits : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("LoadTitleScreen", 25f);
    }

    void LoadTitleScreen()
    {
        SceneManager.LoadScene(0);
    }
}
