using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryShape
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle (double w, double h)
        {
            if (w <= 0 || h <= 0)
            {
                throw new ArgumentException("Стороны не могут быть меньше или равны нулю");
            }
            Width = w;
            Height = h;
        }
        public override double Area ()
        {
            return Width * Height;
        }

        public override double Perimeter ()
        {
            return (Width + Height) * 2;
        }

        public override string ToString ()
        {
            return $"Информация прямоугольника: \n" +
                   $"Сторона а - {Width} \n" +
                   $"Сторона b - {Height} \n" +
                   $"Площадь - {Area()} \n" +
                   $"Периметр - {Perimeter()} \n";
        }
    }
}
