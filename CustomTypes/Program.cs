
namespace CustomTypes
{
    internal class Program
    {
        class User
        {
            public string Name;
            public int Age;

            public User() { }
            
            public User(string name, int age)
            {
                Name = name;
                Age = age;
            }
        }

        struct StuctUser
        {
            public string Name;
            public int Age;

            public StuctUser(string name, int age)
            {
                Name = name;
                Age = age;
            }
        }

        static void Main(string[] args)
        {
            User user = new User();

            Console.WriteLine("Write name: ");
            string nameInput = Console.ReadLine();

            if (nameInput != null || nameInput != "") {
                user.Name = nameInput;
            }

            Console.WriteLine("Write age: ");
            string ageInput = Console.ReadLine();

            if (int.TryParse(ageInput, out int ageParsed))
            {
                user.Age = ageParsed;
            }
            else
            {
                Console.WriteLine($"input age : '{ageInput}' is not correct");
            }

            Console.WriteLine($"User name: {user}\n User age: {user.Age}");

            Console.ReadKey();
        }
    }
}