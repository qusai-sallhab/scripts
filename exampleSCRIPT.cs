using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class exampleSCRIPT : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        

        
        
        while (true)
        {
            int randomNum = Random.Range(0, 21);
            if (randomNum == 15) break;
            if (randomNum == 5) continue;
            Debug.Log(randomNum);

        }

        Debug.Log("qusai");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
