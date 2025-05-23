﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// The event manager
/// </summary>
public static class EventManager
{
    // DON'T change the fields, properties, or ClearInvokersAndListeners
    // method; if you do, you'll break the autograder! 
    // All your work in this class is in the last 4 methods

    #region Fields

    // no argument event support
    static Invoker noArgumentInvoker;
    static UnityAction noArgumentListener;

    // int argument event support
    static Invoker intArgumentInvoker;
    static UnityAction<int> intArgumentListener;

    #endregion

    #region Properties (for autograder use only)

    /// <summary>
    /// Gets the no argument invoker
    /// </summary>
    public static Invoker NoArgumentInvoker
    {
        get { return noArgumentInvoker; }
    }

    /// <summary>
    /// Gets the no argument listener
    /// </summary>
    public static UnityAction NoArgumentListener
    {
        get { return noArgumentListener; }
    }

    /// <summary>
    /// Gets the int argument invoker
    /// </summary>
    public static Invoker IntArgumentInvoker
    {
        get { return intArgumentInvoker; }
    }

    /// <summary>
    /// Gets the int argument listener
    /// </summary>
    public static UnityAction<int> IntArgumentListener
    {
        get { return intArgumentListener; }
    }

    #endregion

    #region Public methods

    /// <summary>
    /// Clears all the invokers and listeners from the event manager.
    /// 
    /// Note: We need this functionality so the autograder can start with
    /// a "clean" event manager at the start of each test case
    /// </summary>
    public static void ClearInvokersAndListeners()
    {
        // no argument invoker and listener
        if (noArgumentInvoker != null)
        {
            if (noArgumentListener != null)
            {
                noArgumentInvoker.RemoveNoArgumentListener(noArgumentListener);
                noArgumentListener = null;
            }
            noArgumentInvoker = null;
        }

        // int argument invoker and listener
        if (intArgumentInvoker != null)
        {
            if (intArgumentListener != null)
            {
                intArgumentInvoker.RemoveOneArgumentListener(intArgumentListener);
                intArgumentListener = null;
            }
            intArgumentInvoker = null;
        }
    }

    /// <summary>
    /// Adds the invoker for the no argument event
    /// </summary>
    /// <param name="invoker">invoker</param>
    public static void AddNoArgumentInvoker(Invoker invoker)
    {
        noArgumentInvoker = invoker;
        if (noArgumentListener != null)
        {
            noArgumentInvoker.AddNoArgumentListener(noArgumentListener);
        }
    }

    /// <summary>
    /// Adds the listener for the no argument event
    /// </summary>
    /// <param name="listener">listener</param>
    public static void AddNoArgumentListener(UnityAction listener)
    {
        noArgumentListener = listener;
        if (noArgumentInvoker != null)
        {
            noArgumentInvoker.AddNoArgumentListener(listener);
        }
    }

    /// <summary>
    /// Adds the invoker for the int argument event
    /// </summary>
    /// <param name="invoker">invoker</param>
    public static void AddIntArgumentInvoker(Invoker invoker)
    {
        intArgumentInvoker = invoker;
        if (intArgumentListener != null)
        {
            intArgumentInvoker.AddOneArgumentListener(intArgumentListener);
        }
    }

    /// <summary>
    /// Adds the listener for the int argument event
    /// </summary>
    /// <param name="listener">listener</param>
    public static void AddIntArgumentListener(UnityAction<int> listener)
    {
        intArgumentListener = listener;
        if (intArgumentInvoker != null)
        {
            intArgumentInvoker.AddOneArgumentListener(listener);
        }
    }

    #endregion
}
