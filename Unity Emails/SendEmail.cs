using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UE.Email;
using System;

public class SendEmail : MonoBehaviour
{

    // Example script for sending emails based on any user specified event

    // Public variables for the editor

    [Header("Email Server Configuration")]

    [Tooltip("The outgoing server.")]
    public string smtp;

    [Tooltip("This is the username for the email address you want to send from. Don't share this information with anyone! ")]
    public string username;

    [Tooltip("This is the password for the email address you want to send from. Don't share this information with anyone! ")]
    public string password;


    [Header("Email Message Configuration")]

    [Tooltip("Who is sending this message?")]
    public string from;

    [Tooltip("To who are you sending this message?")]
    public string to;

    [Tooltip("What is the message subject? ")]
    public string subject;

    [Tooltip("You can use HTML.Bold() or HTML.Italic() in the body/message.")]
    public string message;

    public string token = "TokenHereIfApplicable";

    private void Start()
    {
        smtp = "SMTPServerHere";
        username = "EmailUsernameHere";
        password = "EmailPasswordHere";

        from = "FromEmail";
        to = "ToEmail";
        subject = "Security Notification";
        message = "This is a notification to let you know that we've detected suspicious activity";

        Debug.Log(from);
        Debug.Log(to);
        Debug.Log(subject);
        Debug.Log(message);
        Debug.Log(smtp);
        Debug.Log(username);
        Debug.Log(password);
    }

    // When the user clicks the button, an email gets sent
    public void SendWebmail ()
    {
        try
        {
            Email.SendEmailToken(from, to, subject, message, token);
        }
        catch (Exception e)
        {
            Debug.Log(e);
        }
    }

}
