namespace MaxMinIf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(max(1000, 3000,5000)); 
        }

        //for 2 numbers
        static int max(int num1,int num2)
        {
            int result;
            if (num1 > num2)
            {
                result = num1;
                //return result;
            }
            else
            {
                result = num2;
            }
                return result;

        }
        //for 3 numbers
        static int max(int num1,int num2,int num3)
        {
            int result;
            if (num1 >= num2 && num1 >= num3)
            {
                result = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                result = num2;
            }
            else
            {
                result = num3;
            }
            return result;
        }
    }
}