namespace BaseTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write anything: ");

            string inputString = Console.ReadLine();

            bool isDouble = double.TryParse(inputString, out double doubleResult);

            if (isDouble)
            {
                Console.WriteLine("input string : '" + doubleResult + "' is double");
            }
            else
            {
                Console.WriteLine($"input string : '{doubleResult}' is not double is {inputString}");
            }

            Console.ReadKey();
        }
    }
}