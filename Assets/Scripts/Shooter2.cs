using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter2 : MonoBehaviour
{
     public float speed = 5f;
    private float current_rotation_angle = 0f;
    private float lefttarget_rotation_angle = -70f;
    private float righttarget_rotation_angle = 70f;


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.D))
        {
            if((current_rotation_angle <= righttarget_rotation_angle))
            {
                Quaternion current_rotation = transform.rotation;
                float newzrotation = current_rotation.eulerAngles.z + speed;
                transform.rotation = Quaternion.Euler(0f,0f,newzrotation); 
                current_rotation_angle += speed; 
            }
                
        }
        else if(Input.GetKeyDown(KeyCode.A))
        {
            if(current_rotation_angle >= lefttarget_rotation_angle)
            {
                Quaternion current_rotation = transform.rotation;
                float newzrotation = current_rotation.eulerAngles.z - speed;
                transform.rotation = Quaternion.Euler(0f,0f,newzrotation); 
                current_rotation_angle -= speed; 
            }
        }
    }


}
