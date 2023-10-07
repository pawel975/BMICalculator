using System.Runtime.ExceptionServices;

namespace ConsoleApp
{
    public class BMICalulator
    {
        public static double CalculateBMI(double weightInKG, double heightInMeters)
        {
            return weightInKG / Math.Pow(heightInMeters, 2);
        }

        public static string GetBMIWeightStatus(double BMIIndex)
        {
            string BMIWeightStatus;

            switch (BMIIndex) 
            {
                case < 18.5:
                    BMIWeightStatus = "Underweight";
                    break;
                case < 25:
                    BMIWeightStatus = "Normal range";
                    break;
                case < 30:
                    BMIWeightStatus = "Overwieght";
                    break;
                case < 35:
                    BMIWeightStatus = "Obese";
                    break;
                default:
                    BMIWeightStatus = "Obese II";
                    break;
            }

            return BMIWeightStatus;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BMI Calculator");

            Console.Write("Your mass in [kg]: ");
            double weight = double.Parse(Console.ReadLine());

            Console.Write("Your height in [m]: ");
            double height = double.Parse(Console.ReadLine());

            double BMIIndex = BMICalulator.CalculateBMI(weight, height);


            Console.WriteLine($"Your BMI mass index is: {BMIIndex}");
            Console.WriteLine($"BMI status is: {BMICalulator.GetBMIWeightStatus(BMIIndex)}");


        }
    }
}