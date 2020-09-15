using System;

namespace BMICalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            string userName = Console.ReadLine();

            Console.WriteLine("Enter your age: ");
            var userAge = Int32.Parse(Console.ReadLine());

            if (userAge < 20 ^ userAge > 60)
            {
                Console.WriteLine("This program is only for people between the ages of 20-60.");
                Environment.Exit(0);
            }
            Console.WriteLine("Enter your height in cm: ");
            int userHeight = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter your weight in kg: ");
            int userWeight = Int32.Parse(Console.ReadLine()) * 10000;

            double userBMI = (userWeight / (userHeight * userHeight));


            if (userBMI < 19)
            {
                Console.WriteLine($"{userName}, Your BMI is {userBMI}, you are underweight.");
            }
            else if (userBMI >= 19 && userBMI <= 24.9)
            {
                Console.WriteLine($"{userName}, Your BMI is {userBMI}, you are normal weight.");
            }
            else if (userBMI >= 25 && userBMI <= 25.9)
            {
                Console.WriteLine($"{userName}, Your BMI is {userBMI}, you are overweight.");
            }
            else if (userBMI >= 30)
            {
                Console.WriteLine($"{userName}, Your BMI is {userBMI}, you are obese.");
            }


        }
    }
}

