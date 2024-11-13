using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("Введіть довжину лінії:");
            int length = int.Parse(Console.ReadLine());

            Console.WriteLine("Введіть символ заповнювач:");
            char fillCharacter = Console.ReadLine()[0];

            Console.WriteLine("Введіть напрямок лінії (горизонтальна/вертикальна):");
            string direction = Console.ReadLine().ToLower();

            if (direction == "горизонтальна")
            {
                for (int i = 0; i < length; i++)
                {
                    Console.Write(fillCharacter);
                }
                Console.WriteLine(); 
            }
            else if (direction == "вертикальна")
            {
                for (int i = 0; i < length; i++)
                {
                    Console.WriteLine(fillCharacter);
                }
            }
            else
            {
                Console.WriteLine("Невідомий напрямок. Виберіть 'горизонтальна' або 'вертикальна'.");
            }
        }
    }
}
