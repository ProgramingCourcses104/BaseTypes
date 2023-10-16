namespace BaseTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write anything: ");

            string inputString = Console.ReadLine();

            if(double.TryParse(inputString, out double doubleResult))
            {
                Console.WriteLine("input string : '" + doubleResult + "' is double");
            }
            else
            {
                Console.WriteLine($"input string : '{doubleResult}' is not double");
            }

            Console.ReadKey();
        }
    }
}