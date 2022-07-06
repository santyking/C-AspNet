namespace GettingUserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your Name : ");
            String name = Console.ReadLine();
            Console.Write("Enter your age : ");
            String age = Console.ReadLine();
            Console.WriteLine("Hi! "+name+". You are "+age+" years old");
        }
    }
}