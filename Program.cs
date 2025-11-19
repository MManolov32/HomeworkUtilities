using System;
using HomeworkUtilities; // Task 6 namespace

namespace HomeworkApp
{
    class Program
    {
        // Task 7: static variable
        static int staticNumber = 10;

        static void Main()
        {
            // Task 6: Using Printer from custom namespace
            Printer printer = new Printer();
            printer.PrintMessage("Hello from HomeworkUtilities!");

            // Task 7: Declaring variables
            const double Pi = 3.14159;
            var name = "Alice";
            int age = 20;
            bool isStudent = true;

            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(isStudent);
            Console.WriteLine(staticNumber);
            Console.WriteLine(Pi);

            // Task 8: Arithmetic and logical operations
            int a = 8;
            int b = 3;

            Console.WriteLine("a + b = " + (a + b));
            Console.WriteLine("a - b = " + (a - b));
            Console.WriteLine("a * b = " + (a * b));
            Console.WriteLine("a / b = " + (a / b));
            Console.WriteLine("a % b = " + (a % b));

            Console.WriteLine("a > b: " + (a > b));
            Console.WriteLine("a < b: " + (a < b));
            Console.WriteLine("a == b: " + (a == b));
            Console.WriteLine("a != b: " + (a != b));
            Console.WriteLine("(a > 0 && b > 0): " + (a > 0 && b > 0));
        }
    }
}

// Task 6: Custom namespace in the same project (can be in Printer.cs)
namespace HomeworkUtilities
{
    class Printer
    {
        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
