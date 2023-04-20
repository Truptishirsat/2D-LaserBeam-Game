using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SingleLaser : MonoBehaviour
{
    private int scoreA = 0;
    private LineRenderer laser;
    public Barrier1 barrier1;
    [SerializeField] TextMeshProUGUI scoreAText;


   
   void Start()
   {
        laser = GetComponent<LineRenderer>();
        laser.enabled = false;
        laser.useWorldSpace = true;
        scoreAText.text = "ScoreA: " + scoreA;
   }

   void Update()
   {
        if(Input.GetKey(KeyCode.RightControl))
        {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.up);
            if(hit.collider.name == "Enemy(Clone)")
            {
                scoreA += 1;
                scoreAText.text = "ScoreA: " + scoreA;
                Destroy(GameObject.FindGameObjectWithTag("Enemy"));
            }
            else if(hit.collider.name == "Power(Clone)")
            {
                barrier1.missedByA = 0;
                barrier1.missiedAText.text = "MissedByA: " + barrier1.missedByA;

                Destroy(GameObject.FindGameObjectWithTag("Power"));
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
