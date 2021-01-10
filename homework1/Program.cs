using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1
{
    class Program
    {
        static void Main(string[] args)
        {      // Homework 1 
               //  Dear Teacher ödevlerimdeki gecikmelerden dolayı çok çok özür dilerim.

            Console.WriteLine("BMI CALCULATOR");
            Console.WriteLine("===================");
            Console.WriteLine("WELCOME");

            Console.WriteLine("Weight in kg: ");
            int kg;
            kg = Convert.ToInt32(Console.ReadLine());
           
            Console.Write("Height in cm: ");
            int m;
            m = Convert.ToInt32(Console.ReadLine());

            Console.Write("Gender (m/f):");
            string Gender  = Console.ReadLine();

            int BMI;
            BMI = kg / (m / 100) * (m / 100);

            if (BMI < 19 & Gender == "f")
            {
                Console.WriteLine("-> Underweight"); 
            }
            if (BMI >= 19 & BMI <= 24 & Gender == "f")
            {
                Console.WriteLine("-> Normal"); 
            }
            if (BMI > 24 & Gender == "f")
            {
                Console.WriteLine("-> Overweight"); 
            }

            if (BMI < 20 & Gender == "m")
            {
                Console.WriteLine("-> Underweight");
            }
            if (BMI >= 20 & BMI <= 25 & Gender == "m")
            {
                Console.WriteLine("-> Normal"); 
            }
            if (BMI > 25 & Gender == "m")
            {
                Console.WriteLine("-> Overweight");
            }


            Console.ReadLine();
            Console.ReadKey();

        }
    }
}
