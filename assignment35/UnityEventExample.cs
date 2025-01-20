using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;


namespace assignment35
{
public class UnityEventExample : MonoBehaviour
{
    public UnityEvent onEventTriggered;
    // Start is called before the first frame update
    void Start()
    {
        onEventTriggered=new UnityEvent();

        onEventTriggered.AddListener(OnEventResponse);   
    }

    void OnEventResponse()
    {
        Debug.Log("The event has been triggered!");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp("space"))onEventTriggered.Invoke();
        
    }
}
}