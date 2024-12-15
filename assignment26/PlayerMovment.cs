using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace assignment26
{
public class PlayerMovment : MonoBehaviour
{
    public int speed=10;
    PlayerState mystate;
    // Start is called before the first frame update
    void Start()
    {
        mystate=new PlayerState(); 
        mystate=PlayerState.stop;  
    }

    // Update is called once per frame
    void Update()
    {
        if(MainCamera.followPlayer)
        {
            if(Input.GetKey("a"))mystate=PlayerState.movingLeft;
            else if(Input.GetKey("d"))mystate=PlayerState.movingRight;
            else if(Input.GetKey("w"))mystate=PlayerState.movingForword;
            else if(Input.GetKey("s"))mystate=PlayerState.movingBackword;
            else mystate=PlayerState.stop;  

            switch(mystate)
            {
                case PlayerState.movingLeft:
                transform.Translate(-speed*Time.deltaTime,0,0);
                break;
                case PlayerState.movingRight:
                transform.Translate(speed*Time.deltaTime,0,0);
                break;   
                case PlayerState.movingForword:
                transform.Translate(0,0,speed*Time.deltaTime);
                break;                  
                case PlayerState.movingBackword:
                transform.Translate(0,0,-speed*Time.deltaTime);
                break;    
            }
        }
    }



}



}