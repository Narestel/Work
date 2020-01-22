using System;

namespace AreaOfShapeLibrary
{
    public class AreaOfShape
    {
        //Area of square, rectangle, parallelogram
        public static double AreaSquare(double width, double height)
        {
            if (width <= 0 || height <= 0)
                throw new Exception("Sides should be more than 0");

            return width * height;
        }

        //Area of triangle
        public static double AreaTriangle(double side1, double side2, double side3)
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
                throw new Exception("Sides should be more than 0");

            double pper = (side1 + side2 + side3) / 2;
            if (pper < side1 || pper < side2 || pper < side3)
                throw new Exception("Sides of the triangle are entered incorrectly");

            return Math.Sqrt((pper * (pper - side1) * (pper - side2) * (pper - side3)));
        }

        //Area of triangle with height
        public static double AreaTriangle(double b, double height)
        {
            if (b <= 0 || height <= 0)
                throw new Exception("Base and height should be more than 0");

            return b * height / 2;
        }

        //Area of circle    
        public static double AreaCircle(double radius)
        {
            if (radius <= 0)
                throw new Exception("Radius should be more than 0");

            return Math.PI * Math.Pow(radius, 2);
        }

        //Checking on right triangle
        public static bool IsRightTriangle(double side1, double side2, double side3)
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
                throw new Exception("Sides should be more than 0");

            return (side1 == Math.Sqrt(Math.Pow(side2, 2) + Math.Pow(side3, 2)) ||
                    side2 == Math.Sqrt(Math.Pow(side1, 2) + Math.Pow(side3, 2)) ||
                    side3 == Math.Sqrt(Math.Pow(side1, 2) + Math.Pow(side2, 2)));
        }
    }
}
