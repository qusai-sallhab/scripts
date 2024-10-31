using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class funnyRandomSentenceGenerator : MonoBehaviour
{
    string[] words={"Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird"};
    // Start is called before the first frame update
    void Start()
    {

        int counter=0;
        string fullSentence="";
        while(counter<7)
        {
            fullSentence+=words[Random.Range(0,7)];
            counter++;
        }
        Debug.Log(fullSentence);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
