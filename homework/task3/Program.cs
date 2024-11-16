namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("vvedit 4 cifri cherez probel: ");
            string input = Console.ReadLine();


            string[] digits = input.Split(' ');

            if (digits.Length == 4)
            {

                string result = string.Join("", digits);

                int number = int.Parse(result);

                Console.WriteLine("vashe chislo: " + number);
            }
            else
            {
                Console.WriteLine("vvod onle 4 cifri.");
            }

        }
    }
}