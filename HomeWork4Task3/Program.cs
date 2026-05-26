namespace HomeWork4Task3
{
    internal class Program
    {
        static void Main()
        {

            Message myMessage = new Message("Hello World!");

            OutBox myOutBox = new OutBox();

            myOutBox.SendMessage(myMessage);

            myOutBox.PrintMessageInfo(myMessage);

        }
    }
}
