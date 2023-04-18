using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Barrier : MonoBehaviour
{
    public TextMeshProUGUI missed_text;
    private int missed_enemy;

    void Start()
    {
        missed_enemy = 0;
        missed_text.text =  "MissedByA : " + 0;

    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Enemy")
        {
            missed_enemy += 1;
            missed_text.text =  "MissedByA : " + missed_enemy;
            Destroy(col.gameObject);
        }
        else if(col.gameObject.tag == "Enemy2")
        {
            Destroy(col.gameObject);
        }
    }
}
