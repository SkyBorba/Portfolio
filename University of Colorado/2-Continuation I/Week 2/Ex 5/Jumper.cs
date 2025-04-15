using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    // Update is called once per frame
    void Update(){
        if (Input.GetMouseButtonDown(0)){
            // convert mouse position to world position
            Vector3 position = Input.mousePosition;
            position.z = -Camera.main.transform.position.z;
            position = Camera.main.ScreenToWorldPoint(position);

            // move character
            gameObject.transform.position = position;
        }
    }
}
