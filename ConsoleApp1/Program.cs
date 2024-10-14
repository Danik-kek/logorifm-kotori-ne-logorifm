namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int n) && n >= 0)
            {
                long factorial = CalculateFactorial(n);
                Console.WriteLine($"Факториал числа {n} равен  {factorial}");

            }
            else
            {
                Console.WriteLine("полложительное чмсло ввел ? ");
            }
        }
        static long CalculateFactorial(int n)
        {
            long result = 1;
            for (int i = 2; i < n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
