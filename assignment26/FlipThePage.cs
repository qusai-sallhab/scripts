using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace assignment26
{
public class FlipThePage : MonoBehaviour
{
    public GameObject[] content;
    public GameObject[] previuosContent;
    float ratio;

    public static bool flipped;
    // Start is called before the first frame update
    void Start()
    {
       ratio=0;
        foreach(GameObject g in content)
        {
            g.transform.localScale=new Vector3(0,0,0);
        }   
        flipped=false;
    }

    // Update is called once per frame
    void Update()
    {
        if (flipped)
        {
          if(transform.rotation.eulerAngles.y<179)
            {
                ratio=transform.rotation.eulerAngles.y/115;
                foreach(GameObject g in previuosContent)
                {
                    g.transform.localScale=Vector3.one-Vector3.one*ratio;
                }
                transform.Rotate(0,20*Time.deltaTime,0);
            }


            if(transform.rotation.eulerAngles.y<179)
            {
                ratio=transform.rotation.eulerAngles.y/155;
                foreach(GameObject g in content)
                {
                    g.transform.localScale=Vector3.one*ratio;
                }
                transform.Rotate(0,20*Time.deltaTime,0);
            }
        }
    }
}
}