using System;
using System.Collections;
using System.Collections.Generic;
using assignment26;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Timeline;

namespace assignment26
{

public class Book : MonoBehaviour
{
   
    float rotationFactor;
    float value;
    float timer;
    bool flag;
    bool flag1;
    // Start is called before the first frame update
    void Start()
    {
        flag=false;
        value=0;
        rotationFactor=90;
        timer=0;
        flag1=false;
    }

    // Update is called once per frame
    void Update()
    {
        if(!MainCamera.followPlayer)
        {
            if(!flag)
            {
                timer=Time.time;
                flag=true;
            }

            if(Time.time<timer+4)
            {
                value=math.lerp(value,rotationFactor,.1f);
                transform.Rotate(0,value *Time.deltaTime,0);
            }
            else 
            {
                if(!flag1)
                {
                     transform.rotation=new Quaternion(transform.rotation.x,0,0,0);
                     flag1=true;
                }
                
                if(transform.rotation.x<.5f)
                //Debug.Log(transform.rotation.x);
                transform.Rotate(12.5f*Time.deltaTime,0,0);

            }
            
        }
        
    }
}
}