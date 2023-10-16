namespace ExampleTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool boolVariable = true; // false || true
            byte byteVariable = 1;

            short shortVariable = 2;

            int intVariable = 3;
            long longVariable = 4;

            float floatVariable = (float)5.1;
            double doubleVariable = 6.1;
            decimal decimalVariable = (decimal)7.1;


            char charVariable = 'a';
            string stringVariable = "test string value";

            int[] array = new int[3] { 1, 2, 3 };

            DateTime dateTimeVariable = DateTime.Now;

            Console.WriteLine($"Type bool: {boolVariable} or {!boolVariable}\n");
            Console.ReadKey();
            Console.WriteLine($"Type byte: {byteVariable}  min: {byte.MinValue} max: {byte.MaxValue}\n");
            Console.ReadKey();

            Console.WriteLine($"Type short: {shortVariable}  min: {short.MinValue} max: {short.MaxValue}\n");
            Console.ReadKey();
            Console.WriteLine($"Type int: {intVariable}  min: {int.MinValue} max: {int.MaxValue}\n");
            Console.ReadKey();
            Console.WriteLine($"Type long: {longVariable}  min: {long.MinValue} max: {long.MaxValue}\n");
            Console.ReadKey();

            Console.WriteLine($"Type float: {floatVariable}  min: {float.MinValue} max: {float.MaxValue}\n");
            Console.ReadKey();
            Console.WriteLine($"Type double: {doubleVariable}  min: {double.MinValue} max: {double.MaxValue}\n");
            Console.ReadKey();
            Console.WriteLine($"Type decimal: {decimalVariable}  min: {decimal.MinValue} max: {decimal.MaxValue}\n");
            Console.ReadKey();


            Console.WriteLine($"Type char: {charVariable} min: '{char.MinValue}' max: '{char.MaxValue}'\nChar index: {(int)charVariable}\n");
            Console.WriteLine($"Char index: {(int)charVariable} min: {(int)char.MinValue} max: {(int)char.MaxValue}\n");
            Console.ReadKey();

            Console.WriteLine($"Type string: {stringVariable} Count chars:{stringVariable.Count()}\n");
            Console.ReadKey();

            Console.WriteLine("Array:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Element {i} from array: {array[i]}");
            }

            Console.WriteLine($"\nType DateTime: {dateTimeVariable}  min: {DateTime.MinValue} max: {DateTime.MaxValue}\n");
            Console.ReadKey();

            Console.ReadKey();
        }
    }
}