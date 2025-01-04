using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace assignment29
{
public class BasicsScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var num=3;
        var text="";
        var isEven=false;

       isEven=(num%2==0)?true:false;
       text=isEven?"the number "+num+" is even":"the number "+num+" is odd";
       Debug.Log(text);


        Debug.Log(System.DateTime.Now.Date);
        Debug.Log(System.DateTime.Now.TimeOfDay);
        Debug.Log(System.DateTime.Now.Date.DayOfWeek);


    }
}
}