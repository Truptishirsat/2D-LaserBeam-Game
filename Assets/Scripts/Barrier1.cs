using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Barrier1 : MonoBehaviour
{
    public TextMeshProUGUI missiedAText;
    public int missedByA = 0;
    public GameObject gameOver;
    public SingleLaser singleLaser;
    
    public GameObject spawnPoint;

    void Start()
    {
        missiedAText.text = "MissedByA: " + missedByA; 
    }

    void Update()
    {
        if(missedByA >= 10)
        {
            gameOver.SetActive(true);
            singleLaser.enabled = false;
            spawnPoint.SetActive(false);
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Enemy")
        {
            missedByA += 1;
            missiedAText.text = "MissedByA: " + missedByA; 
            Destroy(col.gameObject);
        }else if(col.gameObject.tag == "Power")
        {
            Destroy(col.gameObject);
        }
    }
}
