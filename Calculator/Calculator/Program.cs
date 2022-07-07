namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter First Number : ");
            decimal num1 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter Second Number : ");
            decimal num2 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter Operator : ");
            String symbol = Console.ReadLine();
            switch (symbol)
            {
                case "+":
                    Console.WriteLine(num1 + num2);
                    break;
                case "-":
                    Console.WriteLine(num1 - num2);
                    break;
                case "*":
                    Console.WriteLine(num1 * num2);
                    break;
                case "/":
                    Console.WriteLine(num1 / num2);
                    break;
                case "%":
                    Console.WriteLine(num1 % num2);
                    break;
                default:
                    Console.WriteLine(symbol + " is not a valid Opearator");
                    break;
            }
        }
    }
}