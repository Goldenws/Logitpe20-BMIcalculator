using System;

namespace BMICalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your age; ");
            int age =Int32.Parse( Console.ReadLine());
            if (age >= 60)
            {
                Console.WriteLine("Sorry but you are too old");

            }else if(age <= 20)
            {
                Console.WriteLine("Sorry but you are too young");


            }
            else
            {
                Console.WriteLine("Perfect lets begin");

                Console.WriteLine("Enter  your height");
                double Height = Double.Parse(Console.ReadLine());
                Console.WriteLine("Enter your Weight in kilograms");
                double Weight = Double.Parse(Console.ReadLine());
                double heightm2 = Height * Height;
                double BMI = (Weight / heightm2)*10000;
                if (BMI <= 19)
                {
                    Console.WriteLine($"Your BMI is {BMI},your underweight");
                
                } else if(BMI >= 24.9)
                {
                    Console.WriteLine($"Your BMI is {BMI},you are normal weight");
                }
            }
            
        }
    }
}
