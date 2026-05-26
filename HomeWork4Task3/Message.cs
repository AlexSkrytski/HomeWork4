using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork4Task3
{
    internal class Message
    {
        public string message;
        public string status = "Did`t send";
        public int attempCounter;

        public Message(string message)
        {
            this.message = message;
            this.status = status;
            this.attempCounter = attempCounter;
        }
    }
}
