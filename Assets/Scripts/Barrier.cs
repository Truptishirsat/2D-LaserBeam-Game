using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Barrier : MonoBehaviour
{
   
    void Start()
    {
       
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "EnemyDown")
        {
            Destroy(col.gameObject);
        }
        else if(col.gameObject.tag == "EnemyUp")
        {
            Destroy(col.gameObject);
        }
    }
}
