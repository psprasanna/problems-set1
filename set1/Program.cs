using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace set1
{
    class Program
    {
        static void Main(string[] args)
        {
            q5();
        }
        static int getInt(string message) 
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        static void q1() 
        {
            // Given two integers, write a program to display the sum, difference, and their product.
            Console.Write("Enter Num1 : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Num1 : ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Sum of two numbers : "+(num1+num2));
            Console.WriteLine("Differene of two numbers : " + Math.Abs(num1 - num2));
            Console.WriteLine("Product of two numbers : " + (num1 * num2));
        }
        static void q2() 
        {
            //write a program to find the value of a raised to the power of b, where a & b are positive integers.
            int a = getInt("Enter a : ");//used getInt() to get integer input from the user
            int b = getInt("Enter b : ");
            Console.WriteLine("Power Value of : "+Math.Pow(a,b));
        }
        static void q3() 
        {
            //write a program to find the volume of rectangular water tank.
            int Length = getInt("Enter Length : "); //int.Parse(Console.ReadLine());
            int breadth = getInt("Enter breadth : ");
            int height = getInt("Enter height : ");
            Console.WriteLine("Volume of rectangular is : "+(Length*breadth*height));
        }
        static void q4() 
        {
            //Find the perimeter of a circle given the radius
            int radius = getInt("Enter the radius : ");
            Console.WriteLine("Perimeter of a circle is : "+(2*Math.PI*radius));
        }
        static void q5() 
        {
            //Given a numerator and denominator, find the quotient and remainer.
            int numerator = getInt("Enter the Numerator : ");
            int denominator = getInt("Enter the Denominator : ");
            int quotient = numerator/denominator;
            int remainder = numerator%denominator;
            Console.WriteLine("Quotient is : "+quotient);
            Console.WriteLine("Remainder is : "+remainder);
        }
    }
}
