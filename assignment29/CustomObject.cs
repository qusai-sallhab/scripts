using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;

namespace assignment29
{
public class CustomObject 
{
    private int id;
    private string name;
    public int ID
    {   
        set{id=value;}
        get{return id;}
    }

    public string Name
    {   
        set{name=value;}
        get{return name;}
    }

    public CustomObject(int id,string name)
    {
        ID=id;
        Name=name;
    }

    public override string ToString()
    {
        return "object: ["+"ID: "+ID+", Name: "+Name+"]";
    }

/*  
    public override bool Equals(object obj)
    {
        CustomObject temp=obj as CustomObject;
        if(temp==null)return false;

        if(this.ID==temp.ID&&this.Name==temp.Name)
        {
            return true;
        }

        return false;
    }
*/


    public static bool operator ==(CustomObject o1, CustomObject o2)
    {
        if(o1.Equals(null) || o2.Equals(null))return false;

        if(o1.Name.Equals(o2.Name)&&o1.ID.Equals(o2.ID))return true;

        return false;
    }

    public static bool operator !=(CustomObject o1, CustomObject o2)
    {
        if(o1.Equals(null) || o2.Equals(null))return true;

        if(o1.Name.Equals(o2.Name)&&o1.ID.Equals(o2.ID))return false;

        return true;
    }

}
}