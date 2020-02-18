using System.Collections;
using System.Collections.Generic;
using System;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StartPython : MonoBehaviour
{
    public string file_address;
 
    void OnMouseDown()
    {
        // using System.Diagnostics;
        ProcessStartInfo p = new ProcessStartInfo();
        p.FileName = "python";
        p.Arguments = file_address;
        p.CreateNoWindow = true;
        p.RedirectStandardOutput = true;

        // Where the script lives
        p.UseShellExecute = false;
        Process process = Process.Start(p);

    }






}
