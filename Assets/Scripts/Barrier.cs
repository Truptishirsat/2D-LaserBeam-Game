using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Barrier : MonoBehaviour
{
   void OnCollisionEnter2D(Collision2D col)
    {
        if( (col.gameObject.tag == "Enemy") || (col.gameObject.tag == "Enemy2") || (col.gameObject.tag == "Power") || (col.gameObject.tag == "Power2"))        {
            Destroy(col.gameObject);
        }
    }
}
