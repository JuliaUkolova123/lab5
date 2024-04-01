namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число а");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите число b");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите операцию (+-*/)");
            String operation = Console.ReadLine();
            switch (operation)
            {
                case "+":
                    Console.WriteLine(a + b);
                    break;
                case "-":
                    Console.WriteLine(a - b);
                    break;
                case "*":
                    Console.WriteLine(a * b);
                    break;
                case "/":
                    Console.WriteLine(a / b);
                    break;
            }
        }
    }
}