using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Barrier : MonoBehaviour
{
    public TextMeshProUGUI missiedAText;
    public TextMeshProUGUI missiedBText;
    public int missedByA = 0;
    public int missedByB = 0;
    public GameObject gameOver;
    public GameObject spawnPoint1;
    public GameObject spawnPoint2;
    public TextMeshProUGUI winText;
    private Laser laser;
    private Laser2 laser2;


    void Awake()
    {
        laser = FindObjectOfType<Laser>();
        laser2 = FindObjectOfType<Laser2>();
    }
    void Start()
    {
        missiedAText.text = "MissedByA: " + missedByA; 
        missiedBText.text = "MissedByB: " + missedByB; 
    }

    void Update()
    {
        if(missedByA >= 10 )
        {
            DisableObjects();
            ActivateWinner();
        }
        else if(missedByB >= 10 )
        {
            DisableObjects();
            ActivateWinner();
        }
    }


    void DisableObjects()
    {
        gameOver.SetActive(true);
        laser.enabled = false;
        laser2.enabled = false;
        spawnPoint1.SetActive(false);
        spawnPoint2.SetActive(false);
    }

    void ActivateWinner()
    {
        if(laser.scoreA > laser2.scoreB)
        {
            winText.text = "Player A is winner";
        }
        else if(laser.scoreA < laser2.scoreB)
        {
            winText.text = "Player B is winner";
        }
        else
        {
           if(missedByA > missedByB)
           {
                winText.text = "Player B is winner";
           }
           else
           {
                winText.text = "Player A is winner";
           }
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Enemy")
        {
            missedByA += 1;
            missiedAText.text = "MissedByA: " + missedByA; 
            Destroy(col.gameObject);
        }else if(col.gameObject.tag == "Enemy2")
        {
            missedByB += 1;
            missiedBText.text = "MissedByB: " + missedByB; 
            Destroy(col.gameObject);

        }else if(col.gameObject.tag == "Power" || col.gameObject.tag == "Power2")
        {
            Destroy(col.gameObject);
        }
    }
}
