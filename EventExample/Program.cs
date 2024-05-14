using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventExample
{
    internal class Program
    {
        public delegate void Notify(string address,string message);

        public event Notify Notification;

        static void Main(string[] args)
        {
            var instance=new Program();

            instance.Notification += EmailNotification;
            instance.Notification += SMSNotification;
            instance.Notification += HotmailNotification;

            instance.Notification("sumon@gmail.com", "hello world");
            instance.Notification-= SMSNotification;

            instance.Notification("sumon@gmail.com", "hello world");

        }
        public static void EmailNotification(string address, string message)
        {
            Console.WriteLine($"sending email to {address} with {message}");
        }
        public static void SMSNotification(string mobilenumber , string message)
        {
            Console.WriteLine($"sending message to {mobilenumber} to with  {message}");
        }
        public static void HotmailNotification (string hotmail, string message)
        {
            Console.WriteLine($"sending hotmail to {hotmail} with {message} ");

        }

    }
}
