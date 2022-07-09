namespace BetterCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter First Number : ");
            decimal num1 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter Operator : ");
            String Op = Console.ReadLine();
            Console.Write("Enter Second Number : ");
            decimal num2 = Convert.ToDecimal(Console.ReadLine());
            decimal result = calculator(num1, Op, num2);
            Console.WriteLine(result);
        }
        static decimal calculator(decimal num1 ,String op, decimal num2)
        {
            decimal result;
            switch (op)
            {
                case "+":
                    result = num1+num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
                case "%":
                    result = num1 % num2;
                    break;
                default:
                    result = 0;
                    break;
            }
            return result;
        }
    }
}