﻿using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace UE.Email
{
    /// <summary>
    /// This class allows sending emails in the browser using an external javasript library.
    /// Based on https://smtpjs.com/ API
    /// </summary>
    public static partial class Email
    {
        private const string BuildWarning = "Sending Emails is only supported in WebGL build.";

        [DllImport("__Internal")]
        private static extern void SendMail(string from, string to, string subject, string body, string smtp,
            string user,
            string password);

        [DllImport("__Internal")]
        private static extern void SendMailToken(string from, string to, string subject, string body, string token);

        [DllImport("__Internal")]
        private static extern void SendMailTokenWithAttachment(string from, string to, string subject, string body,
            string token, string attachment);

        /// <summary>
        /// Sends an email with the given credentials.
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="subject"></param>
        /// <param name="body"></param>
        /// <param name="smtp">Address of the smtp server</param>
        /// <param name="user">Username on the smtp server</param>
        /// <param name="password"></param>
        public static void SendEmail(string from, string to, string subject, string body, string smtp, string user,
            string password)
        {
            SendMail(from, to, subject, body, smtp, user, password);
        }

        /// <summary>
        /// Sends an email with the given token.
        /// The token can be generated at https://smtpjs.com/
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="subject"></param>
        /// <param name="body"></param>
        /// <param name="token"></param>
        public static void SendEmailToken(string from, string to, string subject, string body, string token)
        {
            SendMailToken(from, to, subject, body, token);
        }

        /// <summary>
        /// Sends an email with the given token and an attachment as byte array.
        /// The token can be generated at https://smtpjs.com/
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="subject"></param>
        /// <param name="body"></param>
        /// <param name="token"></param>
        /// <param name="attachment"></param>
        public static void SendEmailToken(string from, string to, string subject, string body, string token,
            byte[] attachment)
        {
            Debug.LogWarning(BuildWarning);
        }

        /// <summary>
        /// Encodes the given byte array to the dataURI scheme (see https://en.wikipedia.org/wiki/Data_URI_scheme).
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private static string EncodeDataUri(byte[] data)
        {
            return "data:text/plain;charset=US-ASCII;base64," + Convert.ToBase64String(data);
        }
    }
}