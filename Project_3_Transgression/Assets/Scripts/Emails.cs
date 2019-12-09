using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Emails : MonoBehaviour
{
    string value = "This is a string.";
    int startIndex = 5;
    int length = 2;

    void Start()
    {
        
    }

    void Update()
    {
        string substring = value.Substring(startIndex, length);
        Debug.Log(substring);
    }
}
