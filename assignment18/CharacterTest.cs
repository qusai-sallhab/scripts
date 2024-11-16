using System.Collections;
using System.Collections.Generic;
using assignment14;
using assignment18;
using UnityEngine;


namespace assignment18
{
public class CharacterTest : MonoBehaviour
{

    Character[] characters=new Character[2];
    // Start is called before the first frame update
    void Start()
    {
        characters[0]=new Solidier();
        characters[1]=new Officer("jom3a",90,new Position(3,3,3));

        for(int i=0;i<characters.Length;i++)
        {
            characters[i].DisplayInfo();
        }

        //officer attacking solidier with the first type of overloading
        Debug.Log(characters[0].Health);
        characters[1].Attack(25,characters[0]);
        Debug.Log(characters[0].Health);

        //solidier attacking officer with the second type of overloading ....
        Debug.Log(characters[1].Health);
        characters[0].Attack(50,characters[1],"hard kick");
        Debug.Log(characters[1].Health);
    }


}
}