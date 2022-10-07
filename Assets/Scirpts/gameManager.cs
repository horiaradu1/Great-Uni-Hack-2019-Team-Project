using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    public GameObject honeyEngine;
    public GameObject timerTextBox;

    private float timer = 0.0f;

    // Start
    Stopwatch stopwatch;
    void Start()
    {
        stopwatch = new Stopwatch();
        stopwatch.Start();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        int seconds = Convert.ToInt32(timer % 60);
        TimeSpan ts = stopwatch.Elapsed;
        string elapsed = string.Format("{0:00}:{1:00}", ts.Minutes, ts.Seconds);
        timerTextBox.GetComponent<Text>().text =elapsed;
    }
}
