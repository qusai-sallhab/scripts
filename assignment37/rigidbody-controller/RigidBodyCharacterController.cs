using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace  assignment37
{
    public class RigidBodyCharacterController : MonoBehaviour
    {
        bool moveLeft;
        bool moveRight;
        bool moveForward;
        bool moveBackward;
        bool jump;

        float xSpeed;
        float zSpeed;
        Rigidbody playerPh;

        Vector3 velocity;

        float speedFactor;
        // Start is called before the first frame update
        void Start()
        {
            moveLeft=false;
            moveRight=false;
            moveForward=false;
            moveBackward=false;
            xSpeed=0;
            zSpeed=0;
            velocity=new Vector3();
            speedFactor=7.24f;

            
            playerPh=GetComponent<Rigidbody>();   

            playerPh.constraints=RigidbodyConstraints.FreezeRotation;
            playerPh.mass=1.5f;
            playerPh.drag=.2f;
        }

        // Update is called once per frame
        void Update()
        {
            if(Input.GetKey("a")) moveLeft=true;
            else moveLeft=false;
            if(Input.GetKey("d")) moveRight=true;
            else moveRight=false;
            if(Input.GetKey("w")) moveForward=true;
            else moveForward=false;
            if(Input.GetKey("s")) moveBackward=true;
            else moveBackward=false;
            if(Input.GetKeyDown("space"))jump=true;

            
        }

        void FixedUpdate() 
        {
            xSpeed=0;
            zSpeed=0;

            if(moveLeft)
            xSpeed=-1;
            if(moveRight)
            xSpeed=1;
            if(moveForward)   
            zSpeed=1;
            if(moveBackward)   
            zSpeed=-1;

            if(jump)
            {
                playerPh.AddForce(new Vector3(0,speedFactor*1.27f,0),ForceMode.Impulse);
                jump=false;
            }
            velocity= new Vector3(xSpeed,0,zSpeed).normalized;
            playerPh.velocity=velocity*speedFactor+new Vector3(0,playerPh.velocity.y,0);

        }

    }
}