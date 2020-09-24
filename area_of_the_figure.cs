using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area_of_the_figure
{
    public static class area_of_the_figure
    {
        public static double Circle(double radius)
        {
            return Math.Pow(radius, 2) * Math.PI;
        }
        public static double Triangle(double a,double b, double c)
        {
            double p = (a + b + c) / 2;
            double S = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
            
            return S;
        }
        public static double CheckRectangular(double a, double b, double c)
        {
            
            double rectangular;
            if (a * a == b * b + c * c)
            {
                rectangular = 1;
            }
            else if (b * b == a * a + c * c)
            {
                rectangular = 1;
            }
            else if (c * c == a * a + b * b)
            {
                rectangular = 1;
            }
            else
            {
                rectangular = 0;
            }
            return rectangular;
            //Если треугольник прямоугольный, то выведется единица. В ином случаем - 0.
        }
    }
}
