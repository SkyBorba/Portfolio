using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenTeddyBear : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // triple height
        Vector3 newScale = transform.localScale;

        newScale.y = newScale.y * 3;

        transform.localScale = newScale;
    }
}
