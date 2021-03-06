using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DG.Tweening;
using static Constants;

public class BattleManager : MonoBehaviour
{
    public EventSystem eventSystem;
    public Player player;
    public Transform gameOverUI;

    /// <summary> Player's prefab. Should be Assets/Prefabs/BattlePlayer.prefab </summary>
    public GameObject playerPrefab;

    /// <summary> Player's turn, so open necessary UI and let player control in it </summary>
    public Turn currentTurn = Turn.None;

    /// <summary> UI that player uses to select Attack, Flee, etc. </summary>
    public GameObject playerActionsUI;

    /// <summary> Spawnpoints of combatants. Player's is the first in the array </summary>
    public Transform[] spawnpoints;

    private GameObject overworldEnemy;

    public void SpawnOpponents(GameObject[] opponents, GameObject overworldObject, AudioClip battleMusic)
    {
        GetComponent<AudioSource>().clip = battleMusic;
        GetComponent<AudioSource>().Play();

        switch(opponents.Length)
        {
            case 1:
                Instantiate(opponents[0], spawnpoints[2].position, Quaternion.identity);
                break;
            case 2:
                Instantiate(opponents[0], spawnpoints[1].position, Quaternion.identity);
                Instantiate(opponents[1], spawnpoints[2].position, Quaternion.identity);
                break;
            case 3:
                Instantiate(opponents[0], spawnpoints[1].position, Quaternion.identity);
                Instantiate(opponents[1], spawnpoints[2].position, Quaternion.identity);
                Instantiate(opponents[2], spawnpoints[3].position, Quaternion.identity);
                break;
            default:
                Debug.LogError("Too many opponents to spawn!");
                break;
        }
        player.GetEnemies();

        overworldEnemy = overworldObject;
    }

    // Start is called before the first frame update
    private void Start()
    {
        currentTurn = Turn.Player;
        PlayerTurn();
    }

    /// <summary> Go to the next turn in the battle </summary>
    public void NextTurn()
    {
        switch(currentTurn)
        {
            case Turn.Player:
                currentTurn = Turn.PlayerToEnemies;
                PlayerToEnemyTurn();
                break;
            case Turn.PlayerToEnemies:
                currentTurn = Turn.Enemy1;
                EnemyTurn(0);
                break;
            case Turn.Enemy1:
                if (player.enemies.Length < 2)
                {
                    currentTurn = Turn.EnemiesToPlayer;
                    EnemyToPlayerTurn();
                }
                else
                {
                    currentTurn = Turn.Enemy2;
                    EnemyTurn(1);
                }
                break;
            case Turn.Enemy2:
                if (player.enemies.Length < 3)
                {
                    currentTurn = Turn.EnemiesToPlayer;
                    EnemyToPlayerTurn();
                }
                else
                {
                    currentTurn = Turn.Enemy3;
                    EnemyTurn(2);
                }
                break;
            case Turn.Enemy3:
                currentTurn = Turn.EnemiesToPlayer;
                EnemyToPlayerTurn();
                break;
            case Turn.EnemiesToPlayer:
                currentTurn = Turn.Player;
                PlayerTurn();
                break;
        }
    }

    /// <summary> Player's turn, so open necessary UI and let player control in it </summary>
    private void PlayerTurn()
    {
        playerActionsUI.SetActive(true);
        eventSystem.SetSelectedGameObject(playerActionsUI.transform.GetChild(0).gameObject);
    }

    /// <summary> Turn after player and before enemy. Some dialouge could happen here </summary>
    private void PlayerToEnemyTurn()
    {
        player.battleActions.Disable();
        Invoke("NextTurn", 0.5f);
    }

    /// <summary> An enemy's turn </summary>
    private void EnemyTurn(int enemyNum)
    {
        player.defendActions.Enable();
        player.enemies[enemyNum].Attack();
    }

    /// <summary> Turn after player and before enemy. Some dialouge could happen here </summary>
    private void EnemyToPlayerTurn()
    {
        player.defendActions.Disable();
        Invoke("NextTurn", 0.5f);
    }

    /// <summary> TODO: End the battle, do whatever victory animations happen, and return to overworld </summary>
    public IEnumerator Victory()
    {
        while (currentTurn != Turn.PlayerToEnemies)
        {
            yield return 0;
        }
        player.battleActions.Disable();
        playerActionsUI.SetActive(false);
        currentTurn = Turn.None;
        overworldEnemy.SetActive(false);
        
        Flee();
    }

    public void GameOver()
    {
        currentTurn = Turn.None;
        gameOverUI.gameObject.SetActive(true);
        gameOverUI.GetComponent<Image>().DOFade(1f, 2f);
        EventSystem.current.SetSelectedGameObject(gameOverUI.GetChild(0).gameObject);
    }

    public void Flee()
    {
        GameObject.FindObjectOfType<OverworldMovement>().controls.Overworld.Enable();
        GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>().enabled = true;
        GameObject.FindGameObjectWithTag("MainCamera").GetComponent<AudioListener>().enabled = true;
        SceneManager.UnloadSceneAsync("Battle");

        foreach (AudioSource audioSource in GameObject.FindObjectsOfType<AudioSource>())
        {
            if (!audioSource.isPlaying && audioSource.playOnAwake)
            {
                audioSource.Play();
            }
        }

        foreach(Actor enemy in player.enemies)
        {
            Destroy(enemy.gameObject);
        }
    }

    public void QuitToTitle()
    {
        SceneManager.LoadScene(0);
    }
}