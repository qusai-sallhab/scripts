using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace assignment29
{
public class UnitySpecificScript : MonoBehaviour
{
    GameObject targetObject;
    GameObject joker;

    bool targetObjectDisabled=false;

    void OnEnable()
    {
        print("gameObject Enabled");
    }

    void OnDisable()
    {
        print("gameObject Disabled");
    }


    // Start is called before the first frame update
    void Start()
    {
        print("Game started!");

       targetObject=GameObject.Find("TargetObject");
       joker=GameObject.FindGameObjectWithTag("Joker");


       if(targetObject!=null)print("Found object by name: "+targetObject.name);
       else print("No TargetObject found.");
      
       if(joker!=null)print("Found object by tag: "+joker.name);
       else print("No joker object found.");

       Light light=GameObject.FindObjectOfType<Light>();
       if(light!=null)print("Found object of type Light: "+light.name);
       else print("no light found");

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("d")&&!targetObjectDisabled) 
        {
            print("TargetObject is deactivated!");
            targetObject.SetActive(false); 
            targetObjectDisabled=true;
        }
    }
}
}