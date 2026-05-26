namespace HomeWork4Task2
{
    internal class Program
    {
        public class User
        {

            private string name = "No information";
            public string Name
            {

                get => name;

                set
                {
                    if (name != value) // Fixing changes
                    {
                        Console.WriteLine($"Name {name} changed to {value}: {DateTime.Now}");
                        name = value;
                        
                    }
                }

            }
        }
        static void Main()
        {

            var user = new User();

            user.Name = "Alex";

            Thread.Sleep(3000);

            user.Name = "Nick";

            Thread.Sleep(3000);

            user.Name = "John";

        }
    }
}



