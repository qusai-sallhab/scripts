using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace assignment19
{
public class Sculpture : MonoBehaviour
{
    int rotationFactor;
    // Start is called before the first frame update
    void Start()
    {
        rotationFactor=Random.Range(-180,180);   
    }

    // Update is called once per frame
    void Update()
    {

        this.transform.rotation=Quaternion.Euler(0,rotationFactor,0);
        rotationFactor+=1;
        
    }
}
}