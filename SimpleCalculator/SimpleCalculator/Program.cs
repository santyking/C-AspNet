namespace SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first Number");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second Number");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double sum = num1 + num2;
            double sub = num1 - num2;
            double mul = num1 * num2;
            double div = num1 / num2;
            Console.WriteLine("The Sum is : " + sum);
            Console.WriteLine("The Diffrence is : " + sub);
            Console.WriteLine("The Diffrence is : " + mul);
            Console.WriteLine("The Diffrence is : " + div);
        }
    }
}