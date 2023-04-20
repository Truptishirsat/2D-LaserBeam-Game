using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Laser2 : MonoBehaviour
{
    private LineRenderer laser;
    public Barrier barrier;
    public int scoreB = 0;
    [SerializeField] TextMeshProUGUI scoreBText;


   void Start()
   {
        laser = GetComponent<LineRenderer>();
        laser.enabled = false;
        laser.useWorldSpace = true;
        scoreBText.text = "ScoreB: " + scoreB;

   }

   void Update()
   {
        if(Input.GetKey(KeyCode.LeftControl))
        {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, -transform.up);
            if(hit.collider.name == "Enemy2(Clone)")
            {
                scoreB += 1;
                scoreBText.text = "ScoreB: " + scoreB;    
                Destroy(GameObject.FindGameObjectWithTag("Enemy2"));
            }
            else if(hit.collider.name == "Power2(Clone)")
            {
                barrier.missedByB = 0;
                barrier.missiedBText.text = "MissedByB: " + barrier.missedByB;
                Destroy(GameObject.FindGameObjectWithTag("Power2"));
            }
            laser.SetPosition(0, transform.position);
            laser.SetPosition(1, hit.point);
            laser.enabled = true;
        }
        else
        {
            laser.enabled = false;
        }
   }
}
