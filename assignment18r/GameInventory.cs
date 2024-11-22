using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace assignment18r
{
public class GameInventory : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Inventory postions=new Inventory();
        postions.AddItem("Healing Potion");
        postions.AddItem("Strenghth Potion");
        Inventory elixires=new Inventory();
        elixires.AddItem("Elixir");
        elixires.AddItem("Dark Elixir");

        Inventory combination=postions+elixires;
        combination.ShowItems();
        
    }

 
}
}