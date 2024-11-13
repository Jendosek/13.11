using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {

            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("Введіть межі числового діапазону:");

            int lowerBound = int.Parse(Console.ReadLine());
            int upperBound = int.Parse(Console.ReadLine());

            if (lowerBound > upperBound)
            {
                Console.WriteLine("Невірний діапазон. Нижня межа повинна бути меншою за верхню.");
                return;
            }

            int a = 0, b = 1;

            Console.WriteLine("Числа Фібоначчі в діапазоні:");

            if (lowerBound <= a && a <= upperBound)
            {
                Console.Write(a + " ");
            }

            while (b <= upperBound)
            {
                if (b >= lowerBound)
                {
                    Console.Write(b + " ");
                }

                int next = a + b;
                a = b;
                b = next;
            }
            Console.WriteLine();
        }
    }
}
