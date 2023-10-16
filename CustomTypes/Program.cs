using CustomTypes.Models;

namespace CustomTypes
{
    internal class Program
    {

        static void Main(string[] args)
        {
            ExtendedUser user = new ExtendedUser();

            while (true)
            {
                Console.WriteLine("Write name: ");
                string nameInput = Console.ReadLine();

                if (nameInput != null && nameInput != "")
                {
                    user.Name = nameInput;
                }
                else
                {
                    Console.WriteLine($"input name : '{nameInput}' is not correct should not be null or empty");
                    continue;
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
                    continue;
                }

                if(user.Name != null && user.Age !=0) {
                    break;
                }
            }

            user.WriteMessage();

            Console.ReadKey();
        }
    }
}