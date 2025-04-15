using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConvertTemperatures : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int fahrenheit = 0;

        int celcius = (fahrenheit - 32)  * 5 / 9;

        int fahrenheitagain = (celcius * 9 / 5) + 32;

        print("Fahrenheit:" + fahrenheit);
        print("Celcius:" + celcius);
        print("Fahrenheit again:" + fahrenheitagain);
    }

 
}
