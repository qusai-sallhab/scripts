using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace assignment18
{
public struct Position 
{
   public float x;
   public float y;
   public float z;

   public Position(int x, int y,int z)
   {
        this.x=x;
        this.y=y;
        this.z=z;
   }

    public void PrintPosition()
    {

        Debug.Log(x+","+y+","+z);
    }


}
}