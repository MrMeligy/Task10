using ConsoleApp1;
using System;

namespace BMICalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {

            BMICalculator<double> bmiCalculator = new BMICalculator<double>();
            Calculator<int> calculator = new Calculator<int>();
            Console.Write("Enter First num: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Second num: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Add: {calculator.Add(num1,num2)}");
            Console.WriteLine($"Subtract: {calculator.Subtract(num1, num2)}");
            Console.WriteLine($"Multiply: {calculator.Multiply(num1, num2)}");
            Console.WriteLine($"Divide: {calculator.Divide(num1, num2)}");
            Console.WriteLine("========================");
            while (true)
            {
                Console.WriteLine(""" 
                Press 1 To Calc New BMI
                Press 2 To display BMI_History 
                """);
                int input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    Console.Write("Enter height (meters): ");
                    double height = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter weight (kilograms): ");
                    double weight = Convert.ToDouble(Console.ReadLine());

                    double bmi = bmiCalculator.CalculateBMI(height, weight);
                    string category = bmiCalculator.GetBMICategory(bmi);

                    Console.WriteLine($"Calculated BMI: {bmi}");
                    Console.WriteLine($"BMI Category: {category}");

                }
                if(input == 2) { 
                    bmiCalculator.DisplayBMIHistory();
                }
            }
        }
    }
}
