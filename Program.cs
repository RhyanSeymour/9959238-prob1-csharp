using System;

namespace _9959238_prob1_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tell user what the function of this app is
            Console.WriteLine("Hey there. This program will compare two numbers, just follow the instructions and this app will do it all for you");
            
            //Prompt user for a number and store it in variable
            Console.WriteLine("Please enter a number");
            var number1 = int.Parse(Console.ReadLine());

            //Prompt user for second number and store it in variable
            Console.WriteLine("Please enter another number");
            var number2 = int.Parse(Console.ReadLine());

            //using "if else" statement to display largest number
            if (number1 > number2)
            {
                Console.WriteLine("The first number you gave me is greater than the second");
            }
            else{
                Console.WriteLine("The second number you gave me is greater than the first");
            }
            
            //Prompt user to to exit
            Console.WriteLine("Press any key to exit app");
            Console.ReadKey();

        }
    }
}
