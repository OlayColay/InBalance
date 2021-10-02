using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BattleManager : MonoBehaviour
{
    public EventSystem eventSystem;

    /// <summary> UI that player uses to select Attack, Flee, etc. </summary>
    public GameObject playerActionsUI;

    // Start is called before the first frame update
    private void Start()
    {
        PlayerTurn();
    }

    // Player's turn, so open necessary UI and let player control in it
    private void PlayerTurn()
    {
        playerActionsUI.SetActive(true);
        eventSystem.SetSelectedGameObject(playerActionsUI.transform.GetChild(0).gameObject);
    }
}
