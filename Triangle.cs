using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryShape
{
    public class Triangle : Shape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public Triangle (double a, double b, double c )
        {
            if (a < 0 || b < 0 || c < 0 )
            {
                throw new ArgumentException("Стороны не могут быть меньше или равны нулю");
            }
            SideA = a;
            SideB = b; 
            SideC = c;
        }

        public override double Area ()
        {
            double a = Perimeter() / 2;
            return Math.Sqrt(a*(a-SideA)*(a - SideB)*(a - SideC));
        }

        public override double Perimeter ()
        {
            return SideA + SideB + SideC;
        }

        public override string ToString ()
        {
            return $"Информация прямоугольника: \n" +
                   $"Сторона а - {SideA} \n" +
                   $"Сторона b - {SideB} \n" +
                   $"Сторона b - {SideC} \n" +
                   $"Площадь - {Area()} \n" +
                   $"Периметр - {Perimeter()} \n";
        }
    }
}
