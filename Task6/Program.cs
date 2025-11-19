namespace Task6
{
    /*Incorrect version of code
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter marks obtained: ");
            string inputMarks = Console.ReadLine();

            Console.Write("Enter total marks: ");
            string inputTotal = Console.ReadLine();

            int marks;
            int total;

            bool isMarksValid = int.TryParse(inputMarks, out marks);
            bool isTotalValid = int.TryParse(inputTotal, out total);

            if (!isMarksValid || !isTotalValid)
            {
                Console.WriteLine("Invalid input. Please enter integer values.");
                return;
            }

            double percentage = marks / total * 100;

            Console.WriteLine("Percentage: " + percentage);
            Console.ReadLine();
        }
    }
    */

    //corrected version of code
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Enter marks obtained: ");
                string inputMarks = Console.ReadLine();

                Console.Write("Enter total marks: ");
                string inputTotal = Console.ReadLine();

                int marks;
                int total;

                bool isMarksValid = int.TryParse(inputMarks, out marks);
                bool isTotalValid = int.TryParse(inputTotal, out total);

                if (!isMarksValid || !isTotalValid)
                {
                    Console.WriteLine("Invalid input. Please enter integer values.");
                    return;
                }

                //Converting to double before division
                double percentage = (double)marks / total * 100;

                Console.WriteLine("Percentage: " + percentage);
                Console.ReadLine();
            }
        }
  }


