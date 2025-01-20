using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace assignment35
{
public class ListMethodsExample : MonoBehaviour
{
    List<int> numbers=new List<int>(){ 3, 1, 4, 1, 5, 9 };
    List<int> numbers2=new List<int>(){ 3, 1, 4, 1, 5, 9, 2, 6};

    // Start is called before the first frame update
    void Start()
    {
        numbers.Sort((int x,int y)=>y.CompareTo(x));
        print(string.Join(", " , numbers));


        List<int> filteredNumbers=numbers2.FindAll((int value)=>value%2==0);
        print(string.Join(", " , filteredNumbers));

    }

}
}