namespace IfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AndGenderHeight(false, true);
            OrGenderHeight(false, true);
        }

        static void AndGenderHeight(Boolean isMale,Boolean isTall)
        {
            // Using and
            if (isMale == true && isTall == true)
            {
                Console.WriteLine("You are male and tall");
            }
            else if (isMale == true && isTall == false)
            {
                Console.WriteLine("You are male and not tall");
            }
            else if (isMale == false && isTall == true)
            {
                Console.WriteLine("You are not male and u r tall");
            }
            else if(isMale == false && isTall == false )
            {
                Console.WriteLine("You are not male and not tall");
            }
            else
            {
                Console.WriteLine("invalid input");
            }

        }

        static void OrGenderHeight(Boolean isMale, Boolean isTall)
        {
            if (isMale == true || isTall == true)
            {
                Console.WriteLine("You are male or tall");
            }
            else if (isMale == true || isTall == false)
            {
                Console.WriteLine("You are male or not tall");
            }
            else if (isMale == false || isTall == true)
            {
                Console.WriteLine("You are not male or u r tall");
            }
            else if (isMale == false || isTall == false)
            {
                Console.WriteLine("You are not male or not tall");
            }
            else
            {
                Console.WriteLine("invalid input");
            }

        }
    }
}