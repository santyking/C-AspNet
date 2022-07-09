namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declaring whole array at once
            int[] luckyNumbers = { 11,22,33,44,55,66 };
            Console.WriteLine(luckyNumbers[0]);
            // declaring array elements individually
            String[] friends = new String[5];
            friends[0] = "Santosh";
            friends[1] = "Bantosh";
            friends[2] = "Kantosh";
            friends[3] = "Tantosh";
            friends[4] = "Pantosh";
            Console.WriteLine(friends[4]);
        }
    }
}