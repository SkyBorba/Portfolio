﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

/// <summary>
/// The HUD
/// </summary>
public class HUD : MonoBehaviour
{
    // bounce count support
    [SerializeField]
    TextMeshProUGUI bounceText;
    int bounces = 0;

    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    void Start()
	{
        bounceText.text = bounces.ToString();
	}
	
    /// <summary>
    /// Adds a bounce to the bounce counter
    /// </summary>
    public void AddBounce()
    {
        bounces++;
        bounceText.text = bounces.ToString();
    }
}
