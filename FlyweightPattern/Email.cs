using System;

namespace FlyweightPattern
{
    public class Email
    {
        public string Receiver { get; set; }
        public string Sender { get; }
        public string Subject { get; }
        public string Template { get; }
        public string Signature { get; }

        public Email(string sender, string subject, string template, string signature)
        {
            Sender = sender;
            Subject = subject;
            Template = template;
            Signature = signature;
        }

    }
}