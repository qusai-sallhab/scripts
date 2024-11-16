using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace assignment18
{
public class Solidier : Character
{
   
   public Solidier(string name , int health , Position position) : base(name,health,position)
   {

   }
   public Solidier() : base()
   {

   }
   public override void DisplayInfo()
   {
        Debug.Log("Solidier");
        base.DisplayInfo();
   }



}
}