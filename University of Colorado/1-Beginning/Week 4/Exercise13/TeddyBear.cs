using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A teddy bear
/// </summary>
public class TeddyBear : MonoBehaviour
{
	/// <summary>
    /// Start is called before the first frame update
    /// </summary>
	void Start()
    {
        // get the teddy bear moving
        Rigidbody2D rb2d = GetComponent<Rigidbody2D>();

        rb2d.AddForce(new Vector2(0, 5), ForceMode2D.Impulse);
    }
	
}