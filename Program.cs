using System;
using ShapeAreaLib;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealAlgebra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the RealAlgebra project");
            Console.WriteLine("1. Rectangle \n2. Square \n3. Circle \n4. Triangle ");
            Console.WriteLine("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    Console.WriteLine("Enter height of rectangle: ");
                    double rectangleHeight=Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter width of rectangle: ");
                    double rectangleWidth = Convert.ToDouble(Console.ReadLine());

                    Rectangle rectangle = new Rectangle();
                    double rectangleArea = rectangle.Area(rectangleHeight, rectangleWidth);
                    Console.WriteLine($"The area of the rectangle is:{rectangleArea}");
                    break;

                case 2:
                    Console.WriteLine("Enter the side length of the square:");
                    double squareSide = Convert.ToDouble(Console.ReadLine());
                    
                    Square square = new Square();   
                    double squareArea = square.Area(squareSide);
                    Console.WriteLine($"The area of the square is:{squareArea}");
                    break;

                case 3:
                    Console.WriteLine("Enter the radius of the circle:");
                    double circleRadius = Convert.ToDouble(Console.ReadLine());

                    Circle circle = new Circle();
                    double circleArea = circle.Area(circleRadius);
                    Console.WriteLine($"The area of the circle is:{circleArea}");
                    break;

                case 4:
                    Console.WriteLine("Enter the base length of the triangle");
                    double triangleBaseLength = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the height of the triangle");
                    double triangleHeight = Convert.ToDouble(Console.ReadLine());

                    Triangle triangle = new Triangle();
                    double triangleArea = triangle.Area(triangleBaseLength, triangleHeight);
                    Console.WriteLine($"The area of the triangle is:{triangleArea}");
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;


            }
            Console.ReadKey();
        }
    }
}
