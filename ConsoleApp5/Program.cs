using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp5
{
    public class Triangle
    {
        public static bool IsValid(double side1, double side2, double side3)
        {
            return (!(side1 >= side2 + side3 || side2 >= side1 + side3 || side3 >= side1 + side2));
        }
        public Triangle(double side1, double side2, double side3)
        {
            if (IsValid(side1, side2, side3))
            {
                Side1 = side1;
                Side2 = side2;
                Side3 = side3;
            }
            else
                throw new InvalidOperationException();
        }
        public double Side1;
        public double Side2;
        public double Side3;
        public double Perimeter { get { return Side1 + Side2 + Side3; } }
        public double Area { get { return Math.Sqrt((Perimeter / 2) * (Perimeter / 2 - Side1) * (Perimeter / 2 - Side2) * (Perimeter / 2 - Side3)); } }
        public bool IsRightAngled
        {
            get
            {
                double[] arr = new double[3] { Side1, Side2, Side3 };
                Array.Sort(arr);
                return (CheckEqual(arr[2] * arr[2], arr[1] * arr[1] + arr[0] * arr[0]));
            }
        }
        public bool IsEquilateral { get { return (Side1 == Side2 && Side1 == Side3); } }
        public bool AreCongruents(Triangle b)
        {
            double[] tr1 = new double[3] { Side1, Side2, Side3 };
            double[] tr2 = new double[3] { b.Side1, b.Side2, b.Side3 };

            Array.Sort(tr1);
            Array.Sort(tr2);

            if (CheckEqual(tr1[0] / tr2[0], tr1[1] / tr2[1]) &&
                CheckEqual(tr1[1] / tr2[1], tr1[2] / tr2[2]) &&
                CheckEqual(tr1[0] / tr2[0], tr1[2] / tr2[2]))
                return true;
            else
                return false;
        }
        public static bool CheckEqual(double a, double b)
        {
            return (b <= a * 1.000001 && b >= a * 0.999999);
        }
    }
    class Program
    {

        static void Main(string[] args)
        {

        }
    }
}