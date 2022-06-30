namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String Phrase = "Santosh Corps";
            Console.WriteLine("Hello \n World!");
            Console.WriteLine("Hello \" World!");
            Console.WriteLine(Phrase+" is cool");
            Console.WriteLine("Length is "+Phrase.Length);
            Console.WriteLine(Phrase.ToUpper());
            Console.WriteLine(Phrase.Contains("Santosh"));
            Console.WriteLine(Phrase[2]);
            Console.WriteLine(Phrase.IndexOf('t'));
            Console.WriteLine(Phrase.IndexOf("Corpso"));
            Console.WriteLine(Phrase.Substring(9));
            Console.WriteLine(Phrase.Substring(Phrase.IndexOf("Corps")));
        }
    }
}