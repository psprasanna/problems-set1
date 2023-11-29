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
            q17();
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
        static void q6() 
        {
            //program to find the square of a given number
            int a = getInt("Enter the number to find its square : ");
            Console.WriteLine("square of "+a+" is : "+(a*a));
            //Console.WriteLine("square of " + a + " is : " + Math.Pow(a,2));
        }
        static void q7() 
        {
            //program to find the square root of a given number
            int a = getInt("Enter the number to find its square root : ");
            Console.WriteLine("Square root of "+a+" is : "+Math.Sqrt(a));
        }
        static void q8() //doubt
        {
            //program to calculate the area of triangle
            double breadth = getInt("Enter the breadth : ");
            int height = getInt("Enter the height : ");
            Console.WriteLine("Area of triangle is : "+(0.5 *(breadth*height)));
        }
        static void q9() 
        {
            //program to convert kilometers to miles
            int kilometer = getInt("Enter the Kilometers : ");
            double miles = kilometer * 0.621371;
            Console.WriteLine("miles :"+miles);
        }
        static void q10() 
        {
            //program to convert celcius to fahrenheit
            int celcius = getInt("Enter the celcius : ");
            int fahrenheit = (celcius * 9 / 5) + 32;
            Console.WriteLine("Fahrenheit is " + fahrenheit);
        }
        static void q11() 
        {
            //program to swap two variables
            int a = getInt("Enter the a : ");
            int b = getInt("Enter the b : ") ;
            int temp = 0;
            temp = b;
            b = a;
            a = temp;
            Console.WriteLine("a is : "+a);
            Console.WriteLine("b is : " + b);
        }
        static void q12() 
        {
            //program to swap two variables without using temporary variables
            int a = getInt("Enter the a : ");
            int b = getInt("Enter the b : ");
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("a is : " + a);
            Console.WriteLine("b is : " + b);
        }
        static void q13() 
        {
            //program to swap variables without causing overflow
            int a = getInt("Enter the a : ");
            int b = getInt("Enter the b : ");
            a = a ^ b;
            b = a ^ b;
            a = a ^ b;
            Console.WriteLine("a is : " + a);
            Console.WriteLine("b is : " + b);
        }
        static void q14() 
        {
            //generate random numbers between 1 to 100
            Random randomNumer = new Random();
            int generateRandom = randomNumer.Next(1,100);
            Console.WriteLine(generateRandom);
        }
        static void q15() 
        {

            double length, width, sqft, acres;
            Console.Write("Enter the length : ");
            length = double.Parse(Console.ReadLine());
            Console.Write("Enter the width : ");
            width = double.Parse(Console.ReadLine());
            sqft = length * width;
            acres = sqft / 43560;
            Console.WriteLine("square feet is : "+sqft+"\nacres is : "+acres);
        }
        static void q16()
        {
            //sum of natural numbers
            int n = getInt("Enter the number : ");
            int naturalNumbers = n * (n + 1) / 2;
            Console.WriteLine("sum of natural numbers : "+naturalNumbers);
        }
        static void q17() 
        {
            //get three numbers and find the average
            int n1, n2, n3, total;
            n1 = getInt("Enter the first number : ");
            n2 = getInt("Enter the second number : ");
            n3 = getInt("Enter the third number : ");
            total = n1 + n2 + n3;
            double average = total / 3.0;
            Console.WriteLine("Total is : "+total+"\nAverage is : "+average);
        }
    }
}
