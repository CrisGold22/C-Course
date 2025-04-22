using System;

namespace FunctionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call the function to display the message
            DisplayMessage();

            int num1 = 5, num2 = 3;

            // Call the function to add two numbers
            int sum = AddNumbers(num1, num2);
            Console.WriteLine("The sum of {0} and {1} is: {2}", num1, num2, sum);

            //Now let's call the function again with numbers of user input
            Console.WriteLine("Enter first number:");
            string number1 = Console.ReadLine();
            Console.WriteLine("Enter second number:");
            string number2 = Console.ReadLine();

            Console.WriteLine("The result of sum of {0} and {1} is: {2}", number1, number2, AddNumbers(int.Parse(number1), int.Parse(number2)));

        }

        // Function to display a message
        static void DisplayMessage()
        {
            Console.WriteLine("Hello, this is a function method!");
        }

        // Function to add two numbers
        public static int AddNumbers(int a, int b)
        {
            return a + b;
        }
    }
}