namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating first object
            Student s1 = new Student();
            s1.name = "Mausam";
            s1.age = 21;
            s1.course = "Application Development";

            // Creating second object
            Student s2 = new Student();
            s2.name = "Rajendra";
            s2.age = 22;
            s2.course = "Database";

            // Displaying values for object 1
            Console.WriteLine("Student 1 Details");
            Console.WriteLine("Name: " + s1.name);
            Console.WriteLine("Age: " + s1.age);
            Console.WriteLine("Course: " + s1.course);

            // Display values for object 2
            Console.WriteLine("\nStudent 2 Details");
            Console.WriteLine("Name: " + s2.name);
            Console.WriteLine("Age: " + s2.age);
            Console.WriteLine("Course: " + s2.course);

            // Printing static field
            Console.WriteLine("\nCollege Name (Static Field): " + Student.collegeName);

            Console.ReadLine();
        }
    }

}
