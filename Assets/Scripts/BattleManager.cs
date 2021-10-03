using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using static Constants;

public class BattleManager : MonoBehaviour
{
    public EventSystem eventSystem;
    public Player player;

    /// <summary> Player's turn, so open necessary UI and let player control in it </summary>
    public Turn currentTurn = Turn.None;

    /// <summary> UI that player uses to select Attack, Flee, etc. </summary>
    public GameObject playerActionsUI;

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
                currentTurn = player.enemies.Length < 2 ? Turn.EnemiesToPlayer : Turn.Enemy2;
                EnemyTurn(1);
                break;
            case Turn.Enemy2:
                currentTurn = player.enemies.Length < 3 ? Turn.EnemiesToPlayer : Turn.Enemy3;
                EnemyTurn(2);
                break;
            case Turn.Enemy3:
                currentTurn = Turn.EnemiesToPlayer;
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
        NextTurn();
    }

    /// <summary> An enemy's turn </summary>
    private void EnemyTurn(int enemyNum)
    {
        player.enemies[enemyNum].Attack();
        Invoke("NextTurn", 1);
    }

    /// <summary> TODO: End the battle, do whatever victory animations happen, and return to overworld </summary>
    public void Victory()
    {
        player.battleActions.Disable();
        currentTurn = Turn.None;
    }
}
