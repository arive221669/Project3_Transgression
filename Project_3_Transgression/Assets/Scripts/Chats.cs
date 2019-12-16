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
    private bool refund = false;

    private int states;

    private float timer;
    private float timerForCustomerReplies = 3f;

    private string currentTime;



    public void Update()
    {
        timer += Time.deltaTime;
        currentTime = DateTime.Now.ToLongTimeString();
        
        if (timer >= 5f && states == 0)
        {

            customer.text = currentTime + " The salsa was packed upside down! It opened and spilled everywhere! Everything is ruined in this bag!";
            customer.GetComponent<Text>().enabled = true;
        }

        else if (timer >= timerForCustomerReplies && states == 1)
        {
            customerReplies.text = currentTime + " Thank you, but can I just have a refund? I don't have time to get a new order";
            customer.GetComponent<Text>().enabled = false;
            customerReplies.GetComponent<Text>().enabled = true;
        }

        else if (timer >= timerForCustomerReplies && states == 2)
        {
            customerReplies.text = currentTime + " So you guys can't even get things right and you're just going not do anything?! How dumb is that?!";
            customer.GetComponent<Text>().enabled = false;
            customerReplies.GetComponent<Text>().enabled = true;

        }

    }


    public void RepliesToCustomer()
        {
        userReplies.text = currentTime + "  " + userInput.text;
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