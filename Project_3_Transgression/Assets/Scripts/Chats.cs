using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    public void Update()
    {
        

    timer += Time.deltaTime;

        Debug.Log(timer);

        if(timer >= 2f && states == 0)
        {
            customer.GetComponent<Text>().enabled = true;
        }

        else if (timer >= timerForCustomerReplies && states == 1)
        {
            customer.GetComponent<Text>().enabled = false;
            customerReplies.GetComponent<Text>().enabled = true;
        }

        else if (timer >= timerForCustomerReplies && states == 2)
        {
            customerReplies.text = "Why can't you help?? Are you being serious right now?! That's completely unaccetable, I demand to speak to a manager!";
            customer.GetComponent<Text>().enabled = false;
            customerReplies.GetComponent<Text>().enabled = true;

        }
    }

    public void RepliesToCustomer()
{
    userReplies.text = userInput.text;
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
//Testing gitkraken