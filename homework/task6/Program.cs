namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vvedit temperatyry:");

            double temperature = double.Parse(Console.ReadLine());

            Console.WriteLine("Convert to celsiy or farenheit?");
            char choice = Char.ToUpper(Console.ReadKey().KeyChar);

            if (choice == 'C')
            {
                double celsius = (temperature - 32) * 5 / 9;
                Console.WriteLine($"\n{temperature} Fahrenheit is {celsius} Celsiy.");
            }
            else if (choice == 'F')
            {
                double fahrenheit = (temperature * 9 / 5) + 32;
                Console.WriteLine($"\n{temperature} Celsiy is {fahrenheit} Fahrenheit.");
            }
            else
            {
                Console.WriteLine("\nnekanon, vvedit 'C' or 'F'.");
            }
        }
    }
}