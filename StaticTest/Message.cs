using System;
using System.Collections.Generic;
using System.Text;

namespace StaticTest
{
    class Message
    {
        public static int count = 0;


        public string Title { get; set; }
        public string Text { get; set; }

        public Message(string title, string text)
        {
            Title = title;
            Text = text;

            count++;
        }

        public static void Info()
        {
            Console.WriteLine("This is the Message class");
            Console.WriteLine("It has static members");
        }
    }
}
