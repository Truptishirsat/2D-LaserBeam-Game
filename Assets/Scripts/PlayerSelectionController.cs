using System.Net;
using System.Runtime.CompilerServices;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerSelectionController : MonoBehaviour
{

    public Button singleSelecButton;
    public Button multiSelecButton;
    void Start()
    {
        singleSelecButton.onClick.AddListener(LoadSinglePlayer);
        multiSelecButton.onClick.AddListener(LoadMultiPlayer);
    }

    void LoadSinglePlayer()
    {
        SceneManager.LoadScene("SinglePlayerScene");
    }

    void LoadMultiPlayer()
    {
        SceneManager.LoadScene("MultiPlayerScene");
    }

   
}
