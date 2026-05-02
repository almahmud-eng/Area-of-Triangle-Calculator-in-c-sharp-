using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Triangle Area = 0.5*base*height
            double baseValue;
            double height;
            Console.WriteLine("Triangle Area Calculator");
             
            Console.WriteLine("Input Value of base to calculate the area of triangle = ");
            baseValue = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Input Value of height to calculate the area of triangle = ");
            height = Convert.ToDouble(Console.ReadLine());

            double AreaOfTriangle = 0.5 * baseValue * height;

            Console.WriteLine("Area of Triangle is = " + AreaOfTriangle);

            Console.ReadLine();

        }
    }
}
