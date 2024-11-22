using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace assignment18r
{
public class Inventory 
{
    private List<string> names=new List<string>();

    public void AddItem(String item)
    {
        names.Add(item);
    }
    public void ShowItems()
    {
        for(int i=0;i<names.Count; i++)
        {
            Debug.Log(names[i]);
        }
    }

    private List<string>  GetItems()
    {
        return names;
    }


    public static Inventory operator +(Inventory n1,Inventory n2)
    {
        Inventory temp=new Inventory();
        List<string> tempList=n1.GetItems();
        for (int i=0;i<tempList.Count;i++)
        {
            temp.AddItem(tempList[i]);
        }
        tempList=n2.GetItems();
        for (int i=0;i<tempList.Count;i++)
        {
            temp.AddItem(tempList[i]);
        }

        return(temp);
    }
}

}