using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class randomNumberGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        while(true)
        {
            int randomNumber= Random.Range(0,21);
            if(randomNumber==5)continue;
            if(randomNumber==15) break;
            Debug.Log(randomNumber);
            
        }
        
    }
}
