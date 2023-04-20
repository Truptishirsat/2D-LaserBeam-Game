using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MultiGameOverController : MonoBehaviour
{
    public Button exitButton;
    public Button restartButton;
   
   void Awake()
   {
        exitButton.onClick.AddListener(LoadLobby);
        restartButton.onClick.AddListener(LoadCurrent);
   } 

    void LoadLobby()
    {
        SceneManager.LoadScene("Lobby");
    }

   void LoadCurrent()
   {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }
}
