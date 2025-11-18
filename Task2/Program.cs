namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating object
            Calculator calc = new Calculator();

            // Caling welcome method
            calc.PrintWelcome();

            // Calling Addition method
            int sum = calc.Add(10, 20);
            Console.WriteLine("Addition Result: " + sum);

            // Calling Multiplication method with two parameters
            int product1 = calc.Multiply(5, 4);
            Console.WriteLine("Multiplication Result (5 * 4): " + product1);

            // Calling Multiply method with default second parameter
            int product2 = calc.Multiply(7);
            Console.WriteLine("Multiplication Result (7 * default): " + product2);

            Console.ReadLine();
        }
    }
}
