﻿using System.Data;

namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
          
            /* x += y;
             x -= y;
             x *= y;
             x /= y;
             x %= y; */

            int a = 17;

            int b = 4;
            int quotient = a / b;
            int remainder = a % b;

            if (a == 17 && b == 4)
            {
                Console.WriteLine(a + "/" + b + " is " + b + " remainder " + 1);
                //Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");
            }
         


            // Second Excercise //


            Console.WriteLine("What is the radius of your circle?");
            double input = double.Parse(Console.ReadLine());

            var answer = Circle.AreaOfCircle(input);
            Console.WriteLine(answer);




            



        }


    }
}