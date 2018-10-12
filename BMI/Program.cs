using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your weight in kilograms?");
            float kg = float.Parse(Console.ReadLine());

            Console.WriteLine("What is your height in meters?");
            float height = float.Parse(Console.ReadLine());

            float bmi = kg / (height * height);
            Console.WriteLine("Your BMI is : {0}", bmi);
        }
    }
}
