namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating object
            ParameterDemo demo = new ParameterDemo();

            // 1. Calling method with ref parameter
            int value = 20;
            Console.WriteLine("Before Increase: " + value);
            demo.Increase(ref value);
            Console.WriteLine("After Increase: " + value);

            // 2. Calling method with out parameter
            demo.GetFullName(out string fullName);
            Console.WriteLine("Full Name: " + fullName);

            // 3. Calling method with params
            int total = demo.SumAll(5, 10, 15, 20);
            Console.WriteLine("Sum of all numbers: " + total);

            Console.ReadLine();
        }
    }
}
