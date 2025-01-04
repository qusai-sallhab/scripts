using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace assignment29
{
public static class Utilities 
{

    public static int Add(params int[] numbers)
    {
        int sum=0;
        for(int i =0 ;i< numbers.Length;i++)
        {
            sum+=numbers[i];
        }
        return sum;
    }

    public static string RepeatString(this String str,int times)
    {
        string temp="";

        for(int i=0;i<times;i++)
        {
            temp+=str;
        }
        return temp;
    }

}
}