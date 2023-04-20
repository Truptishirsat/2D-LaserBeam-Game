using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverController : MonoBehaviour
{
   public Button exitButton;
   public Button restartButton;
   public Barrier1 barrier1;

   void Awake()
   {
        exitButton.onClick.AddListener(LoadLobby);
        restartButton.onClick.AddListener(LoadCurrent);
   } 

   void Update()
   {
       if(barrier1.missedByA > 10)
       {
            gameObject.SetActive(true);
       } 
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
