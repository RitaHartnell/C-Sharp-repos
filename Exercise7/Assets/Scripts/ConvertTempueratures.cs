using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConvertTempueratures : MonoBehaviour
{
    /// <summary>
    /// takes an integer array and for each element in deg F, prints it, converts it to C, prints that, ans converts back to F and prints again
    /// </summary>
    /// <param name="startFs"></param>
    void printy(int[] startFs)
    {
        foreach (int i in startFs)
        {
            int tempC = ((i - 32) / 9) * 5;
            int finF = ((tempC * 9) / 5) + 32;
            print("Starting Farenheit: " + i);
            print("Calculated Celsius: " + tempC);
            print("Calculated Farenheit: " + finF);
        }
    }

    /// <summary>
    /// takes a temps in deg F, floating-point style and prints it, converts it to C, prints that, ans converts back to F and prints again
    /// </summary>
    /// <param name="startF"></param>
    void printy(float startF)
    {
        float tempC = ((startF - 32) / 9) * 5;
        float finF = ((tempC * 9) / 5) + 32;
        print("Starting Farenheit: " + startF);
        print("Calculated Celsius: " + tempC);
        print("Calculated Farenheit: " + finF);
    }

    /// <summary>
    /// takes a temp in deg F, double-point precision, and prints it, converts it to C, prints that, ans converts back to F and prints again
    /// </summary>
    /// <param name="startF"></param>
    void printy(double startF)
    {
        double tempC = ((startF - 32) / 9) * 5;
        double finF = ((tempC * 9) / 5) + 32;
        print("Starting Farenheit: " + startF);
        print("Calculated Celsius: " + tempC);
        print("Calculated Farenheit: " + finF);
    }

    // Start is called before the first frame update
    void Start()
    {
        //problem 1 integer math for temp conversions
        int[] startInts = { 0, 32, 212 };
        printy(startInts);

        //problem 2 floating point math
        float startFloat = 0f;
        printy(startFloat);

        // problem 3 for double precision maths
        double startDouble = 0.0;
        printy(startDouble);
    }

}
