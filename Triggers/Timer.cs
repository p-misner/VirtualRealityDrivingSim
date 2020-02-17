using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    #region Fields
    float totalSeconds = 0;
    float elapsedSeconds = 0;
    bool running = false;
    bool started = false;
    #endregion

    #region Methods
    /// <summary>
    /// Runs the timer
    /// </summary>
    public void Run()
    {
        if (totalSeconds > 0)
        {
            started = true;
            running = true;
            elapsedSeconds = 0;
        }
    }
    /// <summary>
    /// Update this instance every frame.
    /// </summary>
    void Update()
    {
        if (running)
        {
            elapsedSeconds += Time.deltaTime;
            if (elapsedSeconds >= totalSeconds)
            {
                running = false;
            }
        }
    }
    #endregion

    #region Properties
    public bool Running
    {
        get { return running; }
    }

    /// <summary>
    /// Sets the duration of the timer
    /// Can only be set if tomer currently isn't running
    /// </summary>
    /// <value>Tduration</value>
    public float Duration
    {
        set
        {
            if (!running)
            {
                totalSeconds = value;
            }

        }
    }
    public bool Finished
    {
        get { return started && !running; }
    }
    #endregion



}
