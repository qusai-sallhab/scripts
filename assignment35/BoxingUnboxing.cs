using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace assignment35
{
public class BoxingUnboxing : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int health=100;
        object boxedHealth= health as object;
        int unBoxedHealth= (int)boxedHealth;
        unBoxedHealth--;
        print(health);
        print(boxedHealth);
        print(unBoxedHealth);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
}