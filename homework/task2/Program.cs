namespace ConsoleApp1
{
    public class Program
    {
        static void Main()
        {
            Console.Write("vvedit znachennya: ");
            double value = Convert.ToDouble(Console.ReadLine());

            Console.Write("vvedit vidsotok: ");
            double percentage = Convert.ToDouble(Console.ReadLine());

            double result = (value * percentage) / 100;

            Console.WriteLine($"{percentage} % vid {value} = {result}");
        }
    }
}