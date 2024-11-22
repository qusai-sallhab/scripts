using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Subsystems;


namespace assignment18r
{
public class GenaricsTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       GameContainer<string> example=new GameContainer<string>();
       example.SetItem("Healing Potion");
       Debug.Log("Stored item: "+example.GetItem());
       Debug.Log(GameUtils.DescribeItem<string>(example.GetItem()));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
}  