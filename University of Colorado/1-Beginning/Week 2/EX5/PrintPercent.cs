using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        const int MaxScore=100;

        int score = 69;
        float percent = ((float)score / MaxScore)*100;

        print(percent + "%");
    }

   
}
