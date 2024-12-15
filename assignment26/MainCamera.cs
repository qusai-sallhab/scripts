using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace assignment26
{
public class MainCamera : MonoBehaviour
{
    public static bool followPlayer;
    public Transform playerTransform;
    Vector3 differance=new Vector3(0,2f,-4.5f);

    public static bool openTheBook;
    // Start is called before the first frame update
    void Start()
    {
        followPlayer=true;   
        openTheBook=false;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if(followPlayer)
        {
            Vector3 tempPos=Vector3.Lerp(transform.position,playerTransform.position+differance,.05f);
            transform.position=tempPos;
        }

        if(PlayerAtPosition())
        {
            followPlayer=false;
            transform.position= Vector3.Lerp(transform.position,new Vector3(1.4f,7.85f,37),.025f);
            transform.rotation= Quaternion.Euler(Vector3.Lerp(transform.rotation.eulerAngles , new Vector3(34,0,0),.0055f));
            if(transform.rotation.eulerAngles.x>32)
            openTheBook=true;
        }
        
    }

        
    bool PlayerAtPosition()
    {

        return((playerTransform.position.z>38 && playerTransform.position.z<40.5f)&&( playerTransform.position.x>9f&&playerTransform.position.x<12));
    }
}
}