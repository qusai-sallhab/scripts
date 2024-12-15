using System.Collections;
using System.Collections.Generic;
using assignment26;
using Unity.VisualScripting;
using UnityEngine;

namespace assignment26
{
public class OpenTheBook : MonoBehaviour
{
    public GameObject[] content;
    float ratio;
    float timer;
    // Start is called before the first frame update
    void Start()
    {   
        ratio=0;
        foreach(GameObject g in content)
        {
            g.transform.localScale=new Vector3(0,0,0);
        }
        //content.transform.localScale=new Vector3(0,0,0);
        
    }

    // Update is called once per frame
    void Update()
    {

        if(MainCamera.openTheBook)
        {
            if(transform.rotation.eulerAngles.y<179)
            {
                ratio=transform.rotation.eulerAngles.y/115;
                foreach(GameObject g in content)
                {
                    g.transform.localScale=Vector3.one*ratio;
                }
                transform.Rotate(0,20*Time.deltaTime,0);
                timer=Time.time;
            }
            else
            {
                if(Time.time>timer+2.2f)
                FlipThePage.flipped=true;
            }
        }
        
    }
}
}