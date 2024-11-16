using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace assignment18
{
public class Officer : Character
{
   public Officer(string name , int health , Position position) : base(name,health,position)
   {

   }
    public Officer() : base()
   {

   }

   public override void DisplayInfo()
   {
        Debug.Log("Officer");
        base.DisplayInfo();
   }

}
}
