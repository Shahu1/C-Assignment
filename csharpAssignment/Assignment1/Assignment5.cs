using System;

namespace Assignment5
{

    public class Exercise5
    {
        public static void Main()
        {

            double r, circumference,Area;
            double PI = 3.14;
            Console.WriteLine("Input the radius of the circle : ");
            r = Convert.ToDouble(Console.ReadLine());
            circumference = 2 * PI * r;
            Console.WriteLine("Circumference of Circle : {0}", circumference);
            //for area of circle
            Area = (PI * r * r);
            Console.WriteLine("Area of Circle :{0}",Area);


            Console.ReadLine();
        }
    }
}
