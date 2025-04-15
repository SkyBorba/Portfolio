using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Processes mouse button inputs
/// </summary>
public class MouseButtonProcessor : MonoBehaviour
{
    [SerializeField]
    GameObject prefabExplosion;
    [SerializeField]
    GameObject prefabTeddyBear;

    // first frame input support
    bool spawnInputOnPreviousFrame = false;
    bool explodeInputOnPreviousFrame = false;

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
    {
        // spawn teddy bear as appropriate
        if (Input.GetAxis("SpawnerTeddyBear") > 0)
        {
            // only spawn teddy bear on first frame of input
            if (spawnInputOnPreviousFrame==false)
            {
                spawnInputOnPreviousFrame = true;

                Vector3 mousePosition = Input.mousePosition;
                mousePosition.z = -Camera.main.transform.position.z;
                mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

                GameObject.Instantiate(prefabTeddyBear, mousePosition, Quaternion.identity);
            }
        }
        else
        {
            spawnInputOnPreviousFrame = false;
        }

        // explode teddy bear as appropriate
        if (Input.GetAxis("ExplodeTeddyBear") > 0)
        {
            // only explode teddy bear on first frame of input
            if (explodeInputOnPreviousFrame==false)
            {
                explodeInputOnPreviousFrame = true;

                GameObject teddyBear = GameObject.FindWithTag("TeddyBear");
                if (teddyBear != null)
                {
                    Instantiate(prefabExplosion, teddyBear.transform.position, Quaternion.identity);
                    Destroy(teddyBear);
                }
            }
        }
        else
        {
            explodeInputOnPreviousFrame = false;
        }
    }
}
