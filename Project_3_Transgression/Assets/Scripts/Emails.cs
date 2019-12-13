using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Emails : MonoBehaviour
{
    public InputField userInput;
    public Text userReplies;
    private bool weGotIt = false;


     public void PlayText()
    {

        weGotIt = userInput.text.Contains("I'm sorry");


        if (weGotIt == true)
        {
            userReplies.text = userInput.text;
        }
        else
        {
            weGotIt = false;
        }
    }

    //search within the 0 index within the first 10 chars or so to find if player said "I'm sorry" or "I apologize", etc. to determine response
    //Search 0 index within the last 10 chars to find the same thing. 
}
