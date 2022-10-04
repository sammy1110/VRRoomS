using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class clock : MonoBehaviour
{
    public TextMeshProUGUI Textclock;

  
    private void Update()
    {
        DateTime time = DateTime.Now;
        string hour = LeadingZero(time.Hour);
        string minute = LeadingZero(time.Minute);
        string second = LeadingZero(time.Second);

        Textclock.text = hour + ":" + minute + ":" + second;
    }

    string LeadingZero (int n)
    {
        return n.ToString().PadLeft(2, '0');  //Add zero infront of single digit number
    }
}
