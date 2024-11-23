using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateOnZ : MonoBehaviour
{
    int rotationFactor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.rotation=Quaternion.Euler(0,0,rotationFactor);
        rotationFactor+=1;
    }
}
