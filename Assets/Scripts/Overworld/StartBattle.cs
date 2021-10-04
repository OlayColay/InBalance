using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartBattle : MonoBehaviour
{
    /// <summary> The opponents that the player will fight in the battle </summary>
    public GameObject[] opponents;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            GameObject.FindObjectOfType<OverworldMovement>().controls.Overworld.Disable();
            SceneManager.LoadScene(0, LoadSceneMode.Additive);
            SceneManager.sceneLoaded += BattleLoaded;
        }
    }

    // This goes before any Start function in the scene!
    private void BattleLoaded(Scene scene, LoadSceneMode mode)
    {
        GameObject.FindObjectOfType<BattleManager>().SpawnOpponents(opponents, this.gameObject);
        GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>().enabled = false;
    }
}
