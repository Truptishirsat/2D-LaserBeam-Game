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
        if(Input.GetKeyDown(KeyCode.RightControl))
        {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.up);
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
