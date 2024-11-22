using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace assignment20
{
public class movmentScript : MonoBehaviour
{
    float xSpeed;
    float zSpeed;

    int rotationSide;
    // Start is called before the first frame update
    void Start()
    {
      rotationSide=0;
      xSpeed=0;
      zSpeed=0;  
    }

    // Update is called once per frame
    void Update()
    {
        xSpeed=0;
        zSpeed=0;  
        if(Input.GetKey(KeyCode.A))
        {
            rotationSide=0;
            xSpeed=.1f;
        }
        if(Input.GetKey(KeyCode.D))
        {
            rotationSide=1;
            xSpeed=-.1f;
        }
        if(Input.GetKey(KeyCode.W))
        {
            rotationSide=2;
            zSpeed=-.1f;
        }
        if(Input.GetKey(KeyCode.S))
        {
            rotationSide=3;
            zSpeed=.1f;
        }
        if(rotationSide==0)transform.rotation=Quaternion.Euler(0,90,0);
        else if(rotationSide==1)transform.rotation=Quaternion.Euler(0,-90,0);
        if(rotationSide==2)transform.rotation=Quaternion.Euler(0,180,0);
        if(rotationSide==3)transform.rotation=Quaternion.Euler(0,0,0);

        this.transform.position+=new Vector3(xSpeed,0,zSpeed);
        
    }
}
}
