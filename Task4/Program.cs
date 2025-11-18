namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating object using default constructor
            Player p1 = new Player();
            p1.playerName = "Unknown Player";
            p1.level = 0;
            p1.health = 0;

            // Creating object using parameterized constructor
            Player p2 = new Player("Mausam", 5, 100);

            // Printing values of object created using default constructor
            Console.WriteLine("\nPlayer 1 (Default Constructor)");
            Console.WriteLine("Name: " + p1.playerName);
            Console.WriteLine("Level: " + p1.level);
            Console.WriteLine("Health: " + p1.health);

            // Printing values of object created using parameterized constructor
            Console.WriteLine("\nPlayer 2 (Parameterized Constructor)");
            Console.WriteLine("Name: " + p2.playerName);
            Console.WriteLine("Level: " + p2.level);
            Console.WriteLine("Health: " + p2.health);

            Console.ReadLine();
        }
    }
}
