namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("vvedit 6 chisel: ");
            string input = Console.ReadLine();

            if (input.Length != 6)
            {
                Console.WriteLine("mala chisel.");
                return;
            }

            Console.Write("vvedit cherez probel kavo pamenat: ");

            string[] positions = Console.ReadLine().Split();

            int pos1 = int.Parse(positions[0]) - 1;
            int pos2 = int.Parse(positions[1]) - 1;

            char[] digits = input.ToCharArray();
            char temp = digits[pos1];
            digits[pos1] = digits[pos2];
            digits[pos2] = temp;

            Console.WriteLine(new string(digits));

        }
    }
}