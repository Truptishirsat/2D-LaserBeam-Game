using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameStartController : MonoBehaviour
{
    public Button playButton;
    public GameObject playerSelection;

    void Awake()
    {
        playButton.onClick.AddListener(PlayerSelection);
    }

    void PlayerSelection()
    {
        gameObject.SetActive(false);
        playerSelection.SetActive(true);
    }

   
   
}
