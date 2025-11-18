namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Enum Task
            Console.Write("Enter a day: ");
            string day = Console.ReadLine().Trim().ToLower();

            DayType dayType;

            if (day == "friday" || day == "saturday")
            {
                dayType = DayType.Weekend;
            }
            else
            {
                dayType = DayType.Weekday;
            }

            Console.WriteLine($"It is: {dayType}");


            //Record Task

            // Creating first book record
            Book b1 = new Book("The Alchemist", "Paulo Coelho", 999.50);

            // Creating second book using "with" expression
            Book b2 = b1 with { title = "Rich Dad Poor Dad", price = 750.00 };

            Console.WriteLine("\nFirst Book:");
            Console.WriteLine($"Title: {b1.title}, Author: {b1.author}, Price: {b1.price}");


            // Deconstructing the second record
            var (title, author, price) = b2;

            Console.WriteLine("\nSecond Book (Deconstructed):");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Author: {author}");
            Console.WriteLine($"Price: {price}");

            Console.ReadLine();
        }
    }
}
