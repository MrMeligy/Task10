using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class BMICalculator<T>
    {
        private Stack<(T Height, T Weight, double BMI)> _bmiHistory = new Stack<(T, T, double)>();

        public double CalculateBMI(T height, T weight)
        {
            double heightValue = Convert.ToDouble(height);
            double weightValue = Convert.ToDouble(weight);

            double bmi = weightValue / (heightValue * heightValue);
            _bmiHistory.Push((height, weight, bmi));

            return bmi;
        }

        public string GetBMICategory(double bmi)
        {
            if (bmi < 18.5)
                return "Underweight";
            if (bmi >= 18.5 && bmi < 24.9)
                return "Normal weight";
            if (bmi >= 25 && bmi < 29.9)
                return "Overweight";
            return "Obesity";
        }

        public void DisplayBMIHistory()
        {
            if (_bmiHistory.Count == 0)
            {
                Console.WriteLine("No previous BMI calculations.");
                return;
            }

            Console.WriteLine("Previous BMI Calculations:");
            foreach (var rec in _bmiHistory)
            {
                Console.WriteLine($"Height: {rec.Height}, Weight: {rec.Weight}, BMI: {rec.BMI}");
            }
        }
    }

}
