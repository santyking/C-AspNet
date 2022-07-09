namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayHi("Santosh",28);
            int sumNo = Sum(2, 2);
            Console.WriteLine(sumNo);
            int sum3 = Sum(3, 3, 3);
            Console.WriteLine(sum3);

        }

        static void SayHi(String name,int age)
        {
            Console.WriteLine("Hello! "+name+". You are "+age);
        }
        static int Sum(int num1,int num2)
        {
            return num1 + num2;
        }
        static int Sum(int num1,int num2,int num3)
        {
            return num1 + num2 + num3;
        }
    }
}