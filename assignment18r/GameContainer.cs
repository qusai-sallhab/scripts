using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace assignment18r
{
public class GameContainer<T> 
{
    private T item;

    // public GameContainer(T item) constructor شكيت انه مطلوب بدون 
    // {
    //     this.item=item;
    // }
    public void SetItem (T item)
    {
        this.item=item;
    }

    public  T GetItem()
    {
        return item;
    }
    
}
}