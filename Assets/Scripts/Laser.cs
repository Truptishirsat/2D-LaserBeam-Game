using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
   private LineRenderer laser;
   
   void Start()
   {
        laser = GetComponent<LineRenderer>();
        laser.enabled = false;
        laser.useWorldSpace = true;
   }

   void Update()
   {
        if(Input.GetKey(KeyCode.RightControl))
        {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.up);
            if(hit.collider.name == "Enemy(Clone)")
            {
               Destroy(GameObject.FindGameObjectWithTag("Enemy"));
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
