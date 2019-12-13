using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Chats : MonoBehaviour
{


    public InputField userInput;
    public Text userReplies;
    public Text customer;
    public Text customerReplies;
    private bool weGotIt = false;

    private int states;

    private float timer;
    private float timerForCustomerReplies = 3f;

    private string currentTime;
    private string timeNow;
    private bool stopTime;


    public void Update()
    {

        timer += Time.deltaTime;

        while(stopTime == false)
        {
            currentTime = DateTime.Now.ToLongTimeString();
        }

        if (timer >= 5f && states == 0)
        {
            stopTime = true;
            timeNow = currentTime;
            
            customer.text = timeNow + " The salsa was packed upside down! It opened and spilled everywhere! Everything is ruined in this bag!";
            customer.GetComponent<Text>().enabled = true;
        }

        else if (timer >= timerForCustomerReplies && states == 1)
        {
            customer.GetComponent<Text>().enabled = false;
            customerReplies.GetComponent<Text>().enabled = true;
        }

        else if (timer >= timerForCustomerReplies && states == 2)
        {
            customerReplies.text = timeNow + " Why can't you help?? Are you being serious right now?! That's completely unacceptable, I demand to speak to a manager!";
            customer.GetComponent<Text>().enabled = false;
            customerReplies.GetComponent<Text>().enabled = true;

        }
    }


    public void RepliesToCustomer()
        {
            userReplies.text = "10:31:50 AM [Agent] " + userInput.text;
        }

    public void PlayText()
    {

        weGotIt = userInput.text.Contains("I'm sorry");


        if (weGotIt == true)
        {
            timer = 0;
            states = 1;

        }
        else if (weGotIt == false)
        {
            timer = 0;
            states = 2;
        }

    }
}