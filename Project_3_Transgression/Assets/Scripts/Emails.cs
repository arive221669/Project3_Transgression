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

    //search within the 0 index within the first 10 chars or so to find if player said "I'm sorry" or "I apologize", etc. to determine response
    //Search 0 index within the last 10 chars to find the same thing. 
}
