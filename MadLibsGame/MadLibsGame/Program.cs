namespace MadLibsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Noun : ");
            String noun  = Console.ReadLine();
            Console.Write("Enter Adjective : ");
            String adjective  = Console.ReadLine();
            Console.Write("Enter name : ");
            String name = Console.ReadLine();
            Console.WriteLine( noun +" are red");
            Console.WriteLine("Voilets are "+adjective);
            Console.WriteLine(name+" love you");
        }
    }
}