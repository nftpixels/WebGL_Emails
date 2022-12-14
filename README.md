# WebGL_Emails
Send emails through Unity WebGL using Smtp.js

![Banner](https://user-images.githubusercontent.com/97366705/207487988-55e75600-7e36-43a8-8509-f87f14e8a819.jpg)

## HOW DOES IT WORK?

Thought I'd post this in case someone out there is trying to make use of email notifications in-game or just outright send yourself notifications for in-game security breaches triggered by other players or someone mints your NFTs or any user/system action really.

Unity doesn't support sending emails outside of the editor using SMTP, so to get around that, we use https://smtpjs.com/.

You can create a **FREE SMTP** server and encrypt it by following the steps on the website and then use that same server for sending mail, however you can use your own mail server if you prefer. 


**INSTALLATION:**

1. Extract folder contents
2. Copy the Plugin file, into your Unity Plugins folder
3. Copy the Scripts folder into your build (They just need to be present somewhere in your project)
4. Use either of the following two functions to send mail:

 ``` 
  // Send an email using the encryption token
  Email.SendEmailToken(from, to, subject, message, token);

  // Send a standard email with an unencrypted SMTP server
  Email.SendEmail(from, to, subject, message, smtp, username, password);```
