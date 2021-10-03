using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartBattle : MonoBehaviour
{
    /// <summary> The opponents that the playe will fight in the battle </summary>
    public GameObject[] opponents;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            SceneManager.LoadScene("Battle");
            SceneManager.sceneLoaded += BattleLoaded;
        }
    }

    // This goes before any Start function in the scene!
    private void BattleLoaded(Scene scene, LoadSceneMode mode)
    {
        Debug.Log("Scene loaded");
        GameObject.FindObjectOfType<BattleManager>().SpawnOpponents(opponents);
    }
}
