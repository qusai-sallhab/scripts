using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEditor.PackageManager;
using UnityEngine;

namespace assignment29
{
public class ExceptionHandling : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int playerScore=100;
        int diviser=0;

        try 
        {
            Debug.Log("Attempting to calculate score multiplier...");
            int totalScore = playerScore / diviser;
        }
        catch(DivideByZeroException ex)
        {
            Debug.LogError("Error: Division by zero occurred while calculating score multiplier.");
        }
        finally
        {
            Debug.Log("Score calculation complete. Cleaning up resources.");
        }

    }


}
}