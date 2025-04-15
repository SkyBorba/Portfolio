using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resizer : MonoBehaviour
{
    
    //timer support
    const float TotalResizeSeconds = 1;
    float elapsedResizeSeconds = 0;

    //resize control
    const float ScaleFactorPerSeconds = 1;
    int scaleFactorSignMultiplier = 1;


    // Update is called once per frame
    void Update()
    {      

        // resize the game object
        Vector3 size = transform.localScale;
        size.x = scaleFactorSignMultiplier * ScaleFactorPerSeconds * Time.deltaTime;
        size.y = scaleFactorSignMultiplier * ScaleFactorPerSeconds * Time.deltaTime;
        transform.localScale = size;


        // update timer and check if it's done
        elapsedResizeSeconds += Time.deltaTime;
        if (elapsedResizeSeconds >= TotalResizeSeconds)
        {   
            // reset timer and start resizing the game object
            // in the opposite direction
            elapsedResizeSeconds = 0;
            scaleFactorSignMultiplier *= -1;
        }
       

        
            
          
    }
}
