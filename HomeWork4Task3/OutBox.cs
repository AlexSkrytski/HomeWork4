namespace HomeWork4Task3
{
    internal class OutBox
    {

        public string sendStatus;

        public int i = 0;
        public void SendMessage(Message message)
        {
            bool feedBack = false;

            while (!feedBack && i < 3)
            {

                Console.WriteLine($"Message {message.message} didn`t sent {DateTime.Now}. Trying to recent.");
                
                i++;

                Thread.Sleep(3000);

                if (i == 2)//server answer simulation
                {
                    feedBack = true;
                }

            }

            if (feedBack)
            {
                Console.WriteLine($"Message {message.message} sent {DateTime.Now}.");
                sendStatus = "Success sent!";
            }
            else
            {
                Console.WriteLine($"Message {message.message} didn`t sent {DateTime.Now}. No attemps more.");
                sendStatus = "Didn`t sent!";
            }

        }
        public void PrintMessageInfo(Message message)
        {
            Console.WriteLine("Message:      | Status:         | Attempts:");
            Console.WriteLine($"{message.message}  |  {sendStatus}  |  {i}");
        }
    }
}